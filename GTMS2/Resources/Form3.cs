using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace GTMS2.Resources
{
    public partial class adminForm : Form
    {

        private string empName;
        

        public adminForm(string empName)
        {
            InitializeComponent();
            placeholderName.Text = empName; 
            SetupDatabaseBinding();
        }

        string connString = "server=localhost;database=gtms2;uid=root;pwd=;";
        MySqlDataAdapter userAdapter;
        DataTable userTable;
        MySqlDataAdapter courseAdapter;
        DataTable courseTable;

        private void SetupDatabaseBinding()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                // Users Table Setup
                userAdapter = new MySqlDataAdapter("SELECT * FROM users", conn);
                MySqlCommandBuilder userBuilder = new MySqlCommandBuilder(userAdapter);
                userTable = new DataTable();
                userAdapter.Fill(userTable);
                employeeInfo.DataSource = userTable;

                // Course Assignments Table Setup
                courseAdapter = new MySqlDataAdapter("SELECT * FROM course_assignments", conn);
                MySqlCommandBuilder courseBuilder = new MySqlCommandBuilder(courseAdapter);
                courseTable = new DataTable();
                courseAdapter.Fill(courseTable);
                courses.DataSource = courseTable;
            }

            // Disable buttons initially
            ToggleButtons(saveChangesUser, cancelChangesUser, false);
            ToggleButtons(saveChangesCourses, cancelChangesCourses, false);
        }

        private string GetPasskeyFromDb(string settingName)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT passkey_value FROM system_settings WHERE setting_name = @name";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", settingName);
                return cmd.ExecuteScalar()?.ToString();
            }
        }

        // Helper method to update passkey in DB
        private void UpdatePasskeyInDb(string settingName, string newPin)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "UPDATE system_settings SET passkey_value = @pin WHERE setting_name = @name";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pin", newPin);
                cmd.Parameters.AddWithValue("@name", settingName);
                cmd.ExecuteNonQuery();
            }
        }

        // Logic for the buttons
        private void HandlePasskeyChange(string roleName, string settingKey)
        {
            // 1. "Are you sure?"
            DialogResult confirm = MessageBox.Show($"Are you sure you want to change the {roleName} passkey?",
                "Confirm Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                // 2. "Enter current passkey"
                string currentInput = Interaction.InputBox("Enter current passkey:", "Verification", "");
                string actualCurrent = GetPasskeyFromDb(settingKey);

                if (currentInput == actualCurrent)
                {
                    // 3. "Enter new passkey"
                    string newPin = Interaction.InputBox("Enter new passkey:", "New Passkey", "");

                    if (!string.IsNullOrWhiteSpace(newPin))
                    {
                        // 4. Save Changes or Cancel
                        DialogResult saveConfirm = MessageBox.Show("Save changes?", "Final Step",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                        if (saveConfirm == DialogResult.OK)
                        {
                            UpdatePasskeyInDb(settingKey, newPin);
                            MessageBox.Show($"{roleName} Passkey updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Change cancelled.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect current passkey. Access denied.");
                }
            }
        }

        private void ToggleButtons(Button save, Button cancel, bool enabled)
        {
            save.Enabled = enabled;
            cancel.Enabled = enabled;
        }
        private void manageUsers_Click(object sender, EventArgs e)
        {
            welcomePanel.Visible = false;
            userControl.Visible = true;
        }

        private void changeInstructorPasskey_Click(object sender, EventArgs e)
        {
            HandlePasskeyChange("Instructor", "instructor_pin");
        }

        private void manageCourses_Click(object sender, EventArgs e)
        {
            welcomePanel.Visible = false;
            courseControl.Visible = true;
        }

        private void changeAdminPasskey_Click(object sender, EventArgs e)
        {
            HandlePasskeyChange("Admin", "admin_pin");
        }

        private void saveChangesCourses_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender == saveChangesUser)
                {
                    userAdapter.Update(userTable);
                    ToggleButtons(saveChangesUser, cancelChangesUser, false);
                }
                else
                {
                    courseAdapter.Update(courseTable);
                    ToggleButtons(saveChangesCourses, cancelChangesCourses, false);
                }
                MessageBox.Show("Changes saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cancelChangesCourses_Click(object sender, EventArgs e)
        {
            if (sender == cancelChangesUser)
            {
                userTable.Clear();
                userAdapter.Fill(userTable); // Re-fetch from DB
                ToggleButtons(saveChangesUser, cancelChangesUser, false);
            }
            else
            {
                courseTable.Clear();
                courseAdapter.Fill(courseTable); // Re-fetch from DB
                ToggleButtons(saveChangesCourses, cancelChangesCourses, false);
            }
        }

        private void saveChangesUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender == saveChangesUser)
                {
                    userAdapter.Update(userTable);
                    ToggleButtons(saveChangesUser, cancelChangesUser, false);
                }
                else
                {
                    courseAdapter.Update(courseTable);
                    ToggleButtons(saveChangesCourses, cancelChangesCourses, false);
                }
                MessageBox.Show("Changes saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cancelChangesUser_Click(object sender, EventArgs e)
        {
            if (sender == cancelChangesUser)
            {
                userTable.Clear();
                userAdapter.Fill(userTable); // Re-fetch from DB
                ToggleButtons(saveChangesUser, cancelChangesUser, false);
            }
            else
            {
                courseTable.Clear();
                courseAdapter.Fill(courseTable); // Re-fetch from DB
                ToggleButtons(saveChangesCourses, cancelChangesCourses, false);
            }
        }

        private void userRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchBoxUsers_TextChanged(object sender, EventArgs e)
        {

        }

        private void switchUser_Click(object sender, EventArgs e)
        {

        }
    }
}
