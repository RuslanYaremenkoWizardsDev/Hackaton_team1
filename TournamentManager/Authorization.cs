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
    public partial class Authorization : Form
    {
        public string login = string.Empty;
        public string password = string.Empty;
        public bool rightlogin;
        public bool rightpassword;

        public Authorization()
        {
            InitializeComponent();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            string st1 = "&!$#^&*()=*+,";
            login = textBoxLogin.Text;
            if (login != null && login.Length <= 100)
            {
                for (int i = 0; i < st1.Length; i++)
                {
                    if (login.IndexOf(st1[i]) >= 0)
                    {
                        labelErrorLogin.Text = "The string must not contain invalid characters &!$#^&*()=*+,";
                        textBoxLogin.BackColor = Color.Red;
                    }
                    else
                    {
                        login = textBoxLogin.Text;
                        rightlogin = true;
                    }
                }
            }
            else
            {
                labelErrorLogin.Text = "Please, enter your login";
            }
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

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginAuthorization_Click(object sender, EventArgs e)
        {
            if (rightlogin == true && rightpassword == true)
            {
                TournamentPage tournamentPage = new TournamentPage();
                tournamentPage.ShowDialog();
                this.Close();
            }
            else
            {
                labelErrorLogin.Text = "Please, check for correctness login";
                textBoxLogin.BackColor = Color.Red;
                labelErrorPassword.Text = "Please, check for correctness password";
                textBoxPassword.BackColor = Color.Red;
            }
        }
    }
}
