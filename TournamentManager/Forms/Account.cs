using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentManager
{
    public partial class Account : Form
    {
        public string login = "";
        public string password = "";
        public string submitpassword = "";
        public bool rightlogin;
        public bool rightpassword;
        public bool rightsubmitpassword;
        public bool same;

        public Account()
        {
            InitializeComponent();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            password = textBoxPassword.Text;
            if (password != null && password.Length <= 100)
            {
                password = textBoxPassword.Text;
                rightpassword = true;
            }
            else
            {
                labelErrorPassword.Text = "Please, enter your password";
                textBoxPassword.BackColor = Color.Red;
            }
        }

        private void textBoxSubmitpassword_TextChanged(object sender, EventArgs e)
        {
            submitpassword = textBoxSubmitPassword.Text;
            if (submitpassword != null && submitpassword.Length <= 100)
            {
                if (password == submitpassword)
                {
                    submitpassword = textBoxSubmitPassword.Text;
                    rightsubmitpassword = true;
                    textBoxSubmitPassword.BackColor = Color.White;
                    labelErrorSubmitPassword.Text = "";
                }
                else
                {
                    labelErrorSubmitPassword.Text = "Please, enter the same password";
                    textBoxSubmitPassword.BackColor = Color.Red;
                }
            }
            else
            {
                labelErrorSubmitPassword.Text = "Please, enter your password";
                textBoxSubmitPassword.BackColor = Color.Red;
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            TournamentPage tournamentPage = new TournamentPage();
            tournamentPage.ShowDialog();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.ShowDialog();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
