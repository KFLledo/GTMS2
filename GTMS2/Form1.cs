using GTMS2.Resources;
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
        string connectionString = "server=localhost;database=gtms2;uid=root;pwd=;";

        public LoginSignup()
        {
            InitializeComponent();
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

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailLogin.Text;
            string password = passwordLogin.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    conn.Open();
                    // JOIN users and students to get the role and student number
                    string query = @"SELECT u.role, s.first_name, s.last_name, s.student_number 
                             FROM users u 
                             LEFT JOIN students s ON u.user_id = s.user_id 
                             WHERE u.email = @email AND u.password = @pass";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@pass", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string fullName = $"{reader["first_name"]} {reader["last_name"]}";
                            string sNum = reader["student_number"].ToString();

                            studentForm sForm = new studentForm(fullName, sNum);
                            sForm.Show();
                            this.Hide();

                        this.Hide(); // Hide the current Login/Signup form

                            switch (userRole)
                            {
                                case "STUDENT":
                                    // Construct the full name from database columns
                                    string fullName = $"{reader["first_name"]} {reader["last_name"]}";

                                    // Pass the name to the new form
                                    studentForm sForm = new studentForm(fullName);
                                    sForm.Show();
                                    break;

                                case "ADMIN":
                                    adminForm aForm = new adminForm();
                                    aForm.Show();
                                    break;

                                case "INSTRUCTOR":
                                    instructorForm iForm = new instructorForm();
                                    iForm.Show();
                                    break;

                            default:
                                MessageBox.Show("Role not recognized. Contact support.");
                                this.Show(); // Show login back if role is undefined
                                break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
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

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();

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
