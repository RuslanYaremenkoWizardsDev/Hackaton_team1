using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentManager.Forms
{
    public partial class Participant : Form
    {
        public string name = "";
        public bool rightname;
        public Participant()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string st1 = "&!$#^&*()=*+,";
            name = textBoxName.Text;
            if (name != null && name.Length <= 100)
            {
                for (int i = 0; i < st1.Length; i++)
                {
                    if (name.IndexOf(st1[i]) >= 0)
                    {
                        labelErrorName.Text = "The string must not contain invalid characters &!$#^&*()=*+,";
                        textBoxName.BackColor = Color.Red;
                    }
                    else
                    {
                        name = textBoxName.Text;
                        rightname = true;
                    }
                }
            }
            else
            {
                labelErrorName.Text = "Please, enter your login";
            }
        }

        private void AddNewPartipant_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
