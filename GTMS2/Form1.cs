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
        private string GetPasskeyFromDb(string keyName)
        {
            using (MySqlConnection conn = new MySqlConnection(connStringText))
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT passkey_value FROM system_settings WHERE setting_name = @name", conn);
                cmd.Parameters.AddWithValue("@name", keyName);
                return cmd.ExecuteScalar()?.ToString() ?? "0000"; // Fallback default
            }
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
            using (MySqlConnection conn = new MySqlConnection(connStringText))
            {
                try
                {
                    conn.Open();
                    // SQL query to fetch role, names, and the specific ID flags
                    string query = @"SELECT u.role, s.first_name, s.last_name, e.isAdmin, e.isInstruct, s.student_number, e.name 
                             FROM users u 
                             LEFT JOIN employees e ON u.user_id = e.user_id 
                             LEFT JOIN students s ON u.user_id = s.user_id
                             WHERE u.email = @email AND u.password = @pass";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", emailLogin.Text);
                    cmd.Parameters.AddWithValue("@pass", passwordLogin.Text);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string role = reader["role"].ToString();
                            string fullName = $"{reader["first_name"]} {reader["last_name"]}";
                            string name = $"{reader["name"]}";

                            if (role == "STUDENT")
                            {
                                // Match your studentForm(string fullName, string studentNum) constructor
                                string sNum = reader["student_number"].ToString();
                                new studentForm(fullName, sNum).Show();
                                this.Hide();
                            }
                            else if (role == "EMPLOYEE")
                            {
                                bool isAdmin = reader["isAdmin"] != DBNull.Value && Convert.ToBoolean(reader["isAdmin"]);
                                bool isInstructor = reader["isInstructor"] != DBNull.Value && Convert.ToBoolean(reader["isInstructor"]);

                                // Priority: If Admin, ask for Admin Passkey first
                                if (isAdmin)
                                {
                                    string input = Interaction.InputBox("Enter Admin Passkey:", "Security Verification", "");
                                    if (input == GetPasskeyFromDb("admin_pin"))
                                    {
                                        // Pass 'isInstructor' to handle the Switch Button visibility in adminForm
                                        new adminForm(name, isInstructor).Show();
                                        this.Hide();
                                    }
                                    else { MessageBox.Show("Invalid Admin Passkey."); }
                                }
                                else if (isInstructor)
                                {
                                    string input = Interaction.InputBox("Enter Instructor Passkey:", "Security Verification", "");
                                    if (input == GetPasskeyFromDb("instructor_pin"))
                                    {
                                        // Pass 'isAdmin' to handle the Switch Button visibility in instructorForm
                                        // Ensure your instructorForm constructor is updated to: public instructorForm(string name, bool canSwitch)
                                        new instructorForm(name, isAdmin).Show(); 
                                        this.Hide();
                                    }
                                    else { MessageBox.Show("Invalid Instructor Passkey."); }
                                }
                                else if (isInstructor && isAdmin)
                                {
                                    string input = Interaction.InputBox("Enter Instructor Passkey:", "Security Verification", "");
                                    if (input == GetPasskeyFromDb("instructor_pin"))
                                    {
                                        // Pass 'isAdmin' to handle the Switch Button visibility in instructorForm
                                        // Ensure your instructorForm constructor is updated to: public instructorForm(string name, bool canSwitch)
                                        new instructorForm(name, isAdmin).Show(); 
                                        this.Hide();
                                    }
                                    else { MessageBox.Show("Invalid Instructor Passkey."); }
                                }
                            }
                        }
                        else { MessageBox.Show("Invalid email or password."); }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Login Error: " + ex.Message); }
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
