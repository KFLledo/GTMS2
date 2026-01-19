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

            // Choose the table based on whether they clicked Midterms or Finals
            string tableName = (periodType == "Midterms") ? "midterm_grades" : "final_grades";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    // Filter by student_number, year, and semester
                    string query = $@"SELECT course_code, grade, instructor 
                             FROM {tableName} 
                             WHERE student_number = @snum 
                             AND year_level = @year 
                             AND semester = @sem";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@snum", _studentNumber);
                    cmd.Parameters.AddWithValue("@year", selectedYear);
                    cmd.Parameters.AddWithValue("@sem", selectedSemester);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind to the correct DataGridView
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
            yearLevelPanel.Visible = false;
            semesterPanel.Visible = true;
        }

        private void year3Student_Click(object sender, EventArgs e)
        {
            yearLevelPanel.Visible = false;
            semesterPanel.Visible = true;
        }

        private void year4Student_Click(object sender, EventArgs e)
        {
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
            periodPanel.Visible = true;
            midtermsStudent.Enabled = false;
            welcomePanel.Visible = false;
            LoadStudentGrades("Midterms");

            if (isVerifiedSelected)
                verifiedGradesPanel.Visible = true;
            else
                nonVerifiedGradesPanel.Visible = true;
        }

        private void finalsStudent_Click(object sender, EventArgs e)
        {
            periodPanel.Visible = true;
            finalsStudent.Enabled = false;
            welcomePanel.Visible = false;

            // Load the data specifically for this student before showing the panel
            LoadGrades("Finals");

            if (isVerifiedSelected)
            {
                verifiedGradesPanel.Visible = true;
            }
            else
            {
                nonVerifiedGradesPanel.Visible = true;
            }
        }

        private void returntoSemester_Click(object sender, EventArgs e)
        {
            periodPanel.Visible = false;
            semesterPanel.Visible = true;
        }

        private void backtoWelcome_Click(object sender, EventArgs e)
        {
            // Reset everything back to the start
            verifiedGradesPanel.Visible = false;
            nonVerifiedGradesPanel.Visible = false;

            // Re-enable and show the welcome panel
            welcomePanel.Visible = true;
            verified.Enabled = true;
            nonVerified.Enabled = true;
            logout.Enabled = true;
        }

        private void alsobacktowelcome_Click(object sender, EventArgs e)
        {
            // Reset everything back to the start
            verifiedGradesPanel.Visible = false;
            nonVerifiedGradesPanel.Visible = false;

            // Re-enable and show the welcome panel
            welcomePanel.Visible = true;
            verified.Enabled = true;
            nonVerified.Enabled = true;
            logout.Enabled = true;
        }

        

    }
}
