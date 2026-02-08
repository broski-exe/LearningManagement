using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LearningManagement
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserId.Text == "Teacher" && txtUserPass.Text == "Admin")
            {
                MessageBox.Show("Welcome in!");

                LMS newLMS = new LMS();
                newLMS.Show();
                this.Hide();

            
            }
        }
    }
}
