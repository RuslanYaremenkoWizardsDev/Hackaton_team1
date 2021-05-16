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

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSubmitpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Signup_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.ShowDialog();
        }
    }
}
