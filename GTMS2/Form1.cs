using GTMS2.Resources;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTMS2
{
    public partial class LoginSignup : Form
    {
        // 1. This is just the text (the connection string)
        string connStringText = "server=localhost;database=gtms2;uid=root;pwd=;";

        // 2. This is the actual Connection Object
        MySqlConnection conn;

        public LoginSignup()
        {
            InitializeComponent();
            conn = new MySqlConnection(connStringText);
        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signupRedirect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signupPanel.Visible = true;
            loginPanel.Visible = false;
        }

        private void loginRedirect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signupPanel.Visible = false;
            loginPanel.Visible = true;
        }
        private string GetGlobalInstructorPasskey()
        {
            using (MySqlConnection conn = new MySqlConnection(connStringText))
            {
                conn.Open();
                // You can create a simple table 'settings' with one row for this
                string query = "SELECT passkey_value FROM system_settings WHERE setting_name = 'instructor_pin'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                return cmd.ExecuteScalar()?.ToString() ?? "1234"; // Default to 1234 if not found
            }
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailLogin.Text.Trim();
            string password = passwordLogin.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = @"SELECT u.role, e.first_name, e.last_name, e.isAdmin, e.isInstructor, s.student_number 
                             FROM users u 
                             LEFT JOIN employees e ON u.user_id = e.user_id 
                             LEFT JOIN students s ON u.user_id = s.user_id
                             WHERE u.email = @email AND u.password = @pass";

            try
            {
                // FIX: Use 'conn' (the object), not 'connectionString' (the text)
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@pass", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string role = reader["role"].ToString();

                            // Get names from either student or employee table
                            string firstName = reader["first_name"]?.ToString() ?? "";
                            string lastName = reader["last_name"]?.ToString() ?? "";
                            string empName = reader["name"]?.ToString() ?? "";
                            string fullName = $"{firstName} {lastName}".Trim();

                            if (role == "STUDENT")
                            {
                                string sNum = reader["student_number"].ToString();
                                studentForm sForm = new studentForm(fullName, sNum);
                                sForm.Show();
                                this.Hide();
                            }
                            else if (role == "EMPLOYEE")
                            {
                                bool isAdmin = reader["isAdmin"] != DBNull.Value && Convert.ToBoolean(reader["isAdmin"]);
                                bool isInstructor = reader["isInstructor"] != DBNull.Value && Convert.ToBoolean(reader["isInstructor"]);

                                if (isAdmin)
                                {
                                    new adminForm(fullName).Show();
                                    this.Hide();
                                }
                                else if (isInstructor)
                                {
                                    // Simple Popup to ask for PIN
                                    string input = Interaction.InputBox("Enter Instructor Passkey:", "Security Check", "");

                                    // Fetch the global passkey (assuming it's stored in a table called 'system_settings')
                                    if (input == GetGlobalInstructorPasskey())
                                    {
                                        instructorForm iForm = new instructorForm(empName);
                                        iForm.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid Passkey!");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            finally
            {
                // FIX: Use 'conn' to close
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        private void signupButton_Click(object sender, EventArgs e)
        {
            // Basic validation
            if (passwordSignup.Text != confirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            // Using the string variable here to create a temporary connection
            using (MySqlConnection signupConn = new MySqlConnection(connStringText))
            {
                signupConn.Open();
                MySqlTransaction transaction = signupConn.BeginTransaction();

                try
                {
                    // 1. Insert into users table
                    string userQuery = "INSERT INTO users (email, password, role) VALUES (@email, @pass, 'STUDENT'); SELECT LAST_INSERT_ID();";
                    MySqlCommand userCmd = new MySqlCommand(userQuery, conn, transaction);
                    userCmd.Parameters.AddWithValue("@email", emailSignup.Text);
                    userCmd.Parameters.AddWithValue("@pass", passwordSignup.Text);

                    int newUserId = Convert.ToInt32(userCmd.ExecuteScalar());

                    // 2. Insert into students table
                    string studentQuery = "INSERT INTO students (user_id, student_number, first_name, last_name, middle_initial, suffix, birthday) " +
                                         "VALUES (@uid, @snum, @fname, @lname, @mi, @suffix, @bday)";
                    MySqlCommand studentCmd = new MySqlCommand(studentQuery, conn, transaction);
                    studentCmd.Parameters.AddWithValue("@uid", newUserId);
                    studentCmd.Parameters.AddWithValue("@snum", studentNumber.Text);
                    studentCmd.Parameters.AddWithValue("@fname", firstName.Text);
                    studentCmd.Parameters.AddWithValue("@lname", lastName.Text);
                    studentCmd.Parameters.AddWithValue("@mi", middleInitial.Text);
                    studentCmd.Parameters.AddWithValue("@suffix", suffix.Text);
                    studentCmd.Parameters.AddWithValue("@bday", birthday.Value.ToString("yyyy-MM-dd"));

                    studentCmd.ExecuteNonQuery();
                    transaction.Commit();

                    MessageBox.Show("Registration Successful! You can now log in.");
                    loginRedirect_LinkClicked(null, null); // Switch to login panel
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Registration failed: " + ex.Message);
                }
            }
        }
    }
}
