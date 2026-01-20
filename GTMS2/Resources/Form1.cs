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

namespace GTMS2.Resources
{
    public partial class studentForm : Form
    {
        private string _studentNumber;
        private string selectedYear;
        private string selectedSemester;
        private bool isVerifiedSelected;
        private string _studentName;
        public studentForm(string fullName, string studentNum)
        {
            InitializeComponent();
            _studentName = fullName;
            _studentNumber = studentNum;
        }

        private void studentForm_Load(object sender, EventArgs e)
        {
            placeholderName.Text = _studentName;
        }

        private void verified_Click(object sender, EventArgs e)
        {
            isVerifiedSelected = true;
            ProgressToYearSelection();
        }

        private void nonVerified_Click(object sender, EventArgs e)
        {
            isVerifiedSelected = false;
            ProgressToYearSelection();
        }

        private void ProgressToYearSelection()
        {
            // Instead of hiding the panel, we just disable the buttons
            verified.Enabled = false;
            nonVerified.Enabled = false;
            logout.Enabled = false;

            // Show the next step in the chain
            yearLevelPanel.Visible = true;
        }

        private void ShowYearPanel()
        {
            welcomePanel.Visible = false;
            yearLevelPanel.Visible = true;
        }

        private void LoadStudentGrades(string periodType)
        {
            string connString = "server=localhost;database=gtms2;uid=root;pwd=;";

            string gradeTable = (periodType == "Midterms") ? "midterm_grades" : "final_grades";
            string gradeCol = (periodType == "Midterms") ? "midterm_grade" : "final_grade";
            int verifiedValue = isVerifiedSelected ? 1 : 0;

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    // Updated query adding AND g.year_level = @year
                    string query = $@"
                SELECT 
                    g.course_code, 
                    g.{gradeCol} AS Grade, 
                    e.name AS Instructor
                FROM {gradeTable} g
                JOIN course_assignments ca ON g.course_code = ca.course_code 
                    AND g.semester = ca.semester
                JOIN employees e ON ca.employee_id = e.employee_id
                WHERE g.student_number = @snum 
                AND g.semester = @sem
                AND g.year_level = @year
                AND g.isVerified = @isVerified";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@snum", _studentNumber);
                    cmd.Parameters.AddWithValue("@sem", selectedSemester);
                    cmd.Parameters.AddWithValue("@year", selectedYear); // Added year parameter
                    cmd.Parameters.AddWithValue("@isVerified", verifiedValue);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (isVerifiedSelected)
                        verifiedGrades.DataSource = dt;
                    else
                        nonverifiedGrades.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void year1Student_Click(object sender, EventArgs e)
        {
            selectedYear = "1";
            yearLevelPanel.Visible = false;
            semesterPanel.Visible = true;
        }

        private void year2Student_Click(object sender, EventArgs e)
        {
            selectedYear = "2";
            yearLevelPanel.Visible = false;
            semesterPanel.Visible = true;
        }

        private void year3Student_Click(object sender, EventArgs e)
        {
            selectedYear = "3";
            yearLevelPanel.Visible = false;
            semesterPanel.Visible = true;
        }

        private void year4Student_Click(object sender, EventArgs e)
        {
            selectedYear = "4";
            yearLevelPanel.Visible = false;
            semesterPanel.Visible = true;
        }

        private void semester1Student_Click(object sender, EventArgs e)
        {
            selectedSemester = "1";
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

        private void ShowCorrectGradesPanel()
        {
            welcomePanel.Visible = false;
            if (isVerifiedSelected)
            {
                verifiedGradesPanel.Visible = true;
                nonVerifiedGradesPanel.Visible = false;
            }
            else
            {
                nonVerifiedGradesPanel.Visible = true;
                verifiedGradesPanel.Visible = false;
            }
        }

        private void LoadPerformanceData(string courseCode, bool isVerified)
        {
            string connString = "server=localhost;database=gtms2;uid=root;pwd=;";
            // Determine which table to pull performance from based on current period selection
            // You can track this via a class-level variable or check which panel is visible
            string tableName = (midtermsStudent.BackColor == Color.SkyBlue) ? "midterm_grades" : "final_grades";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    // Query filters strictly by student_number and the clicked course_code
                    string query = $@"
                SELECT 
                    lecture_attendance, 
                    lab_attendance, 
                    seatworks, 
                    quizzes, 
                    lab_activities, 
                    midterm_exam 
                FROM {tableName} 
                WHERE student_number = @snum 
                AND course_code = @ccode";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@snum", _studentNumber);
                    cmd.Parameters.AddWithValue("@ccode", courseCode);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Assign to the correct Performance DataGridView
                    if (isVerified)
                        verifiedPerformance.DataSource = dt;
                    else
                        nonverifiedPerformance.DataSource = dt; // Assuming you have this named in Designer
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading performance: " + ex.Message);
                }
            }
        }

        // Event for the Verified Grades Grid
        private void verifiedGrades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string courseCode = verifiedGrades.Rows[e.RowIndex].Cells["course_code"].Value.ToString();
                LoadPerformanceData(courseCode, true);
            }
        }

        // Event for the Non-Verified Grades Grid
        private void nonverifiedGrades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string courseCode = nonverifiedGrades.Rows[e.RowIndex].Cells["course_code"].Value.ToString();
                LoadPerformanceData(courseCode, false);
            }
        }

        private void midtermsStudent_Click(object sender, EventArgs e)
        {
            periodPanel.Visible = true;
            midtermsStudent.Enabled = false;
            finalsStudent.Enabled = true;
            welcomePanel.Visible = false;
            LoadStudentGrades("Midterms");

            // Load the data
            LoadStudentGrades("Midterms");

            // Show the appropriate panel based on verification
            ShowCorrectGradesPanel();
        }

        private void finalsStudent_Click(object sender, EventArgs e)
        {
            periodPanel.Visible = true;
            midtermsStudent.Enabled = true;
            finalsStudent.Enabled = false;

            // Load the data specifically for this student before showing the panel
            // Load the data
            LoadStudentGrades("Finals");

            // Show the appropriate panel based on verification
            ShowCorrectGradesPanel();
        }

        private void returntoSemester_Click(object sender, EventArgs e)
        {
            periodPanel.Visible = false;
            semesterPanel.Visible = true;
        }

        private void backtoWelcome_Click(object sender, EventArgs e)
        {
            verifiedGradesPanel.Visible = false;
            nonVerifiedGradesPanel.Visible = false;
            periodPanel.Visible = false; // Hide the period selection

            // Re-enable all selection buttons for the next use
            verified.Enabled = true;
            nonVerified.Enabled = true;
            logout.Enabled = true;
            midtermsStudent.Enabled = true;
            finalsStudent.Enabled = true;

            welcomePanel.Visible = true;
        }

        private void alsobacktowelcome_Click(object sender, EventArgs e)
        {
            verifiedGradesPanel.Visible = false;
            nonVerifiedGradesPanel.Visible = false;
            periodPanel.Visible = false; // Hide the period selection

            // Re-enable all selection buttons for the next use
            verified.Enabled = true;
            nonVerified.Enabled = true;
            logout.Enabled = true;
            midtermsStudent.Enabled = true;
            finalsStudent.Enabled = true;

            welcomePanel.Visible = true;
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
