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
    public partial class Registration : Form
    {
        public string login = "";
        public string password = "";
        public string submitpassword = "";
        public bool rightlogin;
        public bool rightpassword;
        public bool rightsubmitpassword;
        public bool same;
       

        public Registration()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            string st1 = "%&!$#^&*()=*+,";
            login = textBoxLogin.Text;
            if (login != null && login.Length <= 100)
            {
                for (int i = 0; i < st1.Length; i++)
                {
                    if (login.IndexOf(st1[i]) >= 0)
                    {
                        labelErrorLoginRegistration.Text = "The string must not contain invalid characters %&!$#^&*()=*+,";
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
                labelErrorLoginRegistration.Text = "Please, enter your login";
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            password = textBoxPassword.Text;
            if (password != null && password.Length <= 100)
            {
                password = textBoxPassword.Text;
                rightpassword = true;
                labelErrorPasswordRegistration.Text = "";
                textBoxPassword.BackColor = Color.White;
            }
            else
            {
                labelErrorPasswordRegistration.Text = "Please, enter your password";
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

        private void Signup_Click(object sender, EventArgs e)
        {
            if (rightlogin == true && rightpassword == true && rightsubmitpassword)
            {
                Authorization authorization = new Authorization();
                authorization.ShowDialog();
                this.Close();
            }
            else
            {
                labelErrorLoginRegistration.Text = "Please, check for correctness login";
                textBoxLogin.BackColor = Color.Red;
                labelErrorPasswordRegistration.Text = "Please, check for correctness password";
                textBoxPassword.BackColor = Color.Red;
                labelErrorSubmitPassword.Text = "Please, check for correctness submit password";
                textBoxSubmitPassword.BackColor = Color.Red;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.ShowDialog();
            this.Close();
        }
    }
}
