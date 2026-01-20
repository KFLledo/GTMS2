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
        private bool canSwitchToInstructor;


        public adminForm(string empName, bool canSwitchToInstructor)
        {
            InitializeComponent();
            this.empName = empName;
            this.canSwitchToInstructor = canSwitchToInstructor;

            placeholderName.Text = empName;
            switchUser.Visible = canSwitchToInstructor;

            // Initialize Data and UI
            SetupDatabaseBinding();

            // Wire up event handlers for the Grids so they track edits
            employeeInfo.CellValueChanged += (s, e) => ToggleButtons(saveChangesUser, cancelChangesUser, true);
            courses.CellValueChanged += (s, e) => ToggleButtons(saveChangesCourses, cancelChangesCourses, true);
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

        private string GetPasskeyFromDb(string keyName)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT passkey_value FROM system_settings WHERE setting_name = @name", conn);
                cmd.Parameters.AddWithValue("@name", keyName);
                return cmd.ExecuteScalar()?.ToString() ?? "0000"; // Fallback default
            }
        }

        private void UpdatePasskeyInDb(string keyName, string newValue)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                var cmd = new MySqlCommand("UPDATE system_settings SET passkey_value = @val WHERE setting_name = @name", conn);
                cmd.Parameters.AddWithValue("@val", newValue);
                cmd.Parameters.AddWithValue("@name", keyName);
                cmd.ExecuteNonQuery();
            }
        }

        // Logic for the buttons
        private void HandlePasskeyChange(string roleName, string settingKey)
        {
            // Step 1: Confirmation
            if (MessageBox.Show($"Are you sure you want to change the {roleName} passkey?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Step 2: Verify Current
                string current = Interaction.InputBox("Enter current passkey:", "Verify Identity", "");
                if (current == GetPasskeyFromDb(settingKey))
                {
                    // Step 3: Get New
                    string newKey = Interaction.InputBox("Enter new passkey:", "Update", "");
                    if (!string.IsNullOrWhiteSpace(newKey))
                    {
                        // Step 4: Final Save/Cancel
                        if (MessageBox.Show("Save new passkey?", "Confirm Save",
                            MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            UpdatePasskeyInDb(settingKey, newKey);
                            MessageBox.Show("Passkey updated!");
                        }
                    }
                }
                else { MessageBox.Show("Verification failed."); }
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
            // 1. Ask for Instructor Passkey
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter Instructor Passkey to Switch:", "Security Check", "");

            if (input == GetPasskeyFromDb("instructor_pin"))
            {
                instructorForm iForm = new instructorForm(empName, true);
                iForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Passkey!");
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            // Ask for confirmation before logging out
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Option A: If your login form is the 'Main' entry point and currently hidden
                // Application.OpenForms["loginFormName"].Show(); 

                // Option B: Close this form and return to the login screen
                this.Close();
            }
        }
    }
}
