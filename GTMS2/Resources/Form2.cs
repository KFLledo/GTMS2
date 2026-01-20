using Microsoft.VisualBasic;
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
using System.Xml.Linq;

namespace GTMS2.Resources
{
    public partial class instructorForm : Form
    {
        private string empName;
        private bool canSwitchToAdmin;
        public instructorForm(string empName, bool canSwitchToAdmin)
        {
            InitializeComponent();
            placeholderName.Text = empName; // Or whatever your label is
            this.canSwitchToAdmin = true;

            // Show switch button only if they are also an Admin
            switchUser.Visible = canSwitchToAdmin;
        }

        string connString = "server=localhost;database=gtms2;uid=root;pwd=;";
        MySqlDataAdapter userAdapter;
        DataTable userTable;
        MySqlDataAdapter courseAdapter;
        DataTable courseTable;
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
        private void viewGrades_Click(object sender, EventArgs e)
        {

        }

        private void welcomeUpload_Click(object sender, EventArgs e)
        {

        }

        private void year1Student_Click(object sender, EventArgs e)
        {

        }

        private void year2Student_Click(object sender, EventArgs e)
        {

        }

        private void year3Student_Click(object sender, EventArgs e)
        {

        }

        private void year4Student_Click(object sender, EventArgs e)
        {

        }

        private void semester1Student_Click(object sender, EventArgs e)
        {

        }

        private void semester2Student_Click(object sender, EventArgs e)
        {

        }

        private void returntoYear_Click(object sender, EventArgs e)
        {

        }

        private void midtermsStudent_Click(object sender, EventArgs e)
        {

        }

        private void finalsStudent_Click(object sender, EventArgs e)
        {

        }

        private void returntoSemester_Click(object sender, EventArgs e)
        {

        }

        private void uploadaswell_Click(object sender, EventArgs e)
        {

        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void verifyButton_Click(object sender, EventArgs e)
        {

        }

        private void saveChangesNonverified_Click(object sender, EventArgs e)
        {

        }

        private void cancelChangesNonverified_Click(object sender, EventArgs e)
        {

        }

        private void searchBoxNonverified_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void searchboxVerified_TextChanged(object sender, EventArgs e)
        {

        }

        private void switchUser_Click(object sender, EventArgs e)
        {
            // 1. Ask for Admin Passkey
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter Admin Passkey to Switch:", "Security Check", "");

            if (input == GetPasskeyFromDb("admin_pin"))
            {
                // 2. Open Admin Form and pass 'true' for isInstructor switch
                adminForm aForm = new adminForm(empName, true);
                aForm.Show();
                this.Close();
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
