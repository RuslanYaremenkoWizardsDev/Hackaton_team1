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
    public partial class Welcome : Form
    {
        public bool check;
        public Welcome()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            check = true;
            Authorization authorization = new Authorization();
            authorization.ShowDialog();
            if (check == true)
            {
                this.Close();
            }
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();
            this.Close();
        }
    }
}
