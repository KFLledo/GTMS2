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
using ExcelDataReader; // Requires ExcelDataReader NuGet package
using System.IO;

namespace GTMS2.Resources
{
    public partial class instructorForm : Form
    {
        private string empName;
        private bool canSwitchToAdmin;
        private string selectedYear, selectedSemester, selectedPeriod;
        private bool isVerifiedSelected; // Track which mode we are in
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

        private void UploadExcelFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                openFileDialog.Title = "Select an Excel File to Upload Grades";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                        {
                            // Auto-detect format (xls or xlsx)
                            using (var reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                // Choose one of the following:

                                // Option A: Read as a DataSet (easiest for DataGridViews)
                                var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                    {
                                        UseHeaderRow = true // Use first row as column names
                                    }
                                });

                                DataTable dt = result.Tables[0];

                                // Display the data in your existing DataGridView to let the instructor review it
                                nonverifiedGrades.DataSource = dt;

                                MessageBox.Show("Excel file loaded successfully! Please review and click Save to confirm.", "Success");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error reading Excel file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void viewGrades_Click(object sender, EventArgs e)
        {
            isVerifiedSelected = true; // Flow for viewing/editing verified grades
            welcomePanel.Visible = false;
            yearLevelPanel.Visible = true;
        }

        private void welcomeUpload_Click(object sender, EventArgs e)
        {
            isVerifiedSelected = false; // Flow for uploading/editing non-verified grades
            welcomePanel.Visible = false;
            yearLevelPanel.Visible = true;
        }

        private void ProgressToPeriodSelection()
        {
            semesterPanel.Visible = false;
            periodPanel.Visible = true;
        }
        private void ProgressToSemesterSelection()
        {
            yearLevelPanel.Visible = false;
            periodPanel.Visible = true;
        }
        // Logic to load ONLY assigned courses
        private void LoadInstructorCourses(string period)
        {
            selectedPeriod = period;
            string query = @"
        SELECT c.course_code, c.course_description, ca.section 
        FROM courses c
        JOIN course_assignments ca ON c.course_code = ca.course_code
        JOIN employees e ON ca.employee_id = e.employee_id
        WHERE e.name = @instructorName 
        AND c.year_level = @year 
        AND c.semester = @sem";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@instructorName", empName); // Filters by current instructor
                cmd.Parameters.AddWithValue("@year", selectedYear);
                cmd.Parameters.AddWithValue("@sem", selectedSemester);

                // Load into the DataGridView (verifiedGrades or nonverifiedGrades)
                // ... standard adapter fill logic ...
            }
        }

        private void LoadGrades(string period)
        {
            selectedPeriod = period;
            periodPanel.Visible = false;

            if (isVerifiedSelected)
            {
                verifiedGradesPanel.Visible = true;
                // Load data into verifiedGrades DGV filtering by Instructor name and is_verified = 1
            }
            else
            {
                nonVerifiedGradesPanel.Visible = true;
                // Load data into nonverifiedGrades DGV filtering by Instructor name and is_verified = 0
            }
        }
        private void LoadDataByAssignment(string period)
        {
            string tableName = (period == "Midterms") ? "midterm_grades" : "final_grades";
            string isVerifiedValue = isVerifiedSelected ? "1" : "0";

            // This query ensures ONLY courses assigned to THIS instructor in course_assignments are shown
            string query = $@"
        SELECT g.* FROM {tableName} g
        INNER JOIN course_assignments ca ON g.course_code = ca.course_code
        INNER JOIN employees e ON ca.employee_id = e.employee_id
        WHERE e.name = @instructorName 
        AND g.isVerified = @isVerified
        AND g.semester = @semester";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@instructorName", empName); // From the instructorForm constructor
                cmd.Parameters.AddWithValue("@isVerified", isVerifiedValue);
                cmd.Parameters.AddWithValue("@semester", selectedSemester);

                if (isVerifiedSelected)
                {
                    courseTable = new DataTable();
                    courseAdapter = new MySqlDataAdapter(cmd);
                    courseAdapter.Fill(courseTable);
                    verifiedGrades.DataSource = courseTable;
                }
                else
                {
                    userTable = new DataTable();
                    userAdapter = new MySqlDataAdapter(cmd);
                    userAdapter.Fill(userTable);
                    nonverifiedGrades.DataSource = userTable;
                }
            }
        }

        private void year1Student_Click(object sender, EventArgs e)
        {
            selectedYear = "1";
            ProgressToSemesterSelection();
        }

        private void year2Student_Click(object sender, EventArgs e)
        {
            selectedYear = "2";
            ProgressToSemesterSelection();

        }

        private void year3Student_Click(object sender, EventArgs e)
        {
            selectedYear = "3";
            ProgressToSemesterSelection();
        }

        private void year4Student_Click(object sender, EventArgs e)
        {
            selectedYear = "4";
            ProgressToSemesterSelection();
        }

        private void semester1Student_Click(object sender, EventArgs e)
        {
            selectedSemester = "2";
            semesterPanel.Visible = false;
            periodPanel.Visible = true;
        }

        private void semester2Student_Click(object sender, EventArgs e)
        {
            selectedSemester = "2";
            semesterPanel.Visible = false;
            periodPanel.Visible = true;
        }

        private void returntoYear_Click(object sender, EventArgs e)
        {
            semesterPanel.Visible = false;
            yearLevelPanel.Visible = true;
        }

        private void midtermsStudent_Click(object sender, EventArgs e)
        {
            selectedPeriod = "Midterms";
            periodPanel.Visible = false;
            nonVerifiedGradesPanel.Visible = true;
            // Call a method here to load data from DB based on selectedYear, selectedSemester, and selectedPeriod
        }

        private void finalsStudent_Click(object sender, EventArgs e)
        {
            selectedPeriod = "Finals";
            periodPanel.Visible = false;
            nonVerifiedGradesPanel.Visible = true;
            // Call a method here to load data from DB based on selectedYear, selectedSemester, and selectedPeriod
        }

        private void returntoSemester_Click(object sender, EventArgs e)
        {
            periodPanel.Visible = false;
            semesterPanel.Visible = true;
        }

        private void uploadaswell_Click(object sender, EventArgs e)
        {
            UploadExcelFile();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    // Use the adapter associated with the verified grades
                    MySqlCommandBuilder builder = new MySqlCommandBuilder(courseAdapter);
                    courseAdapter.Update(courseTable); // This pushes changes to the DB
                    MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving changes: " + ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Discard all unsaved changes?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Re-run your load method to refresh the data from the DB
                LoadInstructorCourses(selectedPeriod);
            }
        }

        private void verifyButton_Click(object sender, EventArgs e)
        {
            if (nonverifiedGrades.CurrentRow == null) return;

            string studentNum = nonverifiedGrades.CurrentRow.Cells["student_number"].Value.ToString();
            string courseCode = nonverifiedGrades.CurrentRow.Cells["course_code"].Value.ToString();
            string tableName = (selectedPeriod == "Midterms") ? "midterm_grades" : "final_grades";

            string updateQuery = $"UPDATE {tableName} SET isVerified = 1 WHERE student_number = @sNum AND course_code = @cCode";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@sNum", studentNum);
                cmd.Parameters.AddWithValue("@cCode", courseCode);
                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Student grade verified successfully!");
                LoadDataByAssignment(selectedPeriod); // Refresh the list
            }
        }

        private void saveChangesNonverified_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommandBuilder builder = new MySqlCommandBuilder(userAdapter);
                userAdapter.Update(userTable);
                MessageBox.Show("Non-verified grades updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cancelChangesNonverified_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Discard changes?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LoadGrades(selectedPeriod); // Refresh from DB
            }
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

        private void label8_Click(object sender, EventArgs e)
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
