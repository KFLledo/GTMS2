using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTMS2
{
    public partial class LoginSignup : Form
    {
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
    }
}
