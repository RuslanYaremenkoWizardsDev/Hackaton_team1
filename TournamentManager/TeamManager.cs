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
    public partial class TeamManager : Form
    {
        public TeamManager()
        {
            InitializeComponent();
        }

        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            DataHelper.TeamDataInsert(textBoxName.Text, Convert.ToInt32(textBoxQuantity.Text), Convert.ToInt32(textBoxScore.Text));
        }
    }
}
