using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GTMS2.Resources
{
    public partial class instructorForm : Form
    {
        private string empName;
        public instructorForm(string empName)
        {
            InitializeComponent();
            placeholderName.Text = empName;
        }

        string connString = "server=localhost;database=gtms2;uid=root;pwd=;";
        MySqlDataAdapter userAdapter;
        DataTable userTable;
        MySqlDataAdapter courseAdapter;
        DataTable courseTable;

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

        }
    }
}
