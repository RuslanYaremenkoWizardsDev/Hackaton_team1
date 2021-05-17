using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentManager
{
    public partial class TournamentPage : Form
    {
        public TournamentPage()
        {
            InitializeComponent();
        }

        private void Create_tournament(object sender, EventArgs e)
        {
            CreateTournament createtournament = new CreateTournament();
            createtournament.ShowDialog();
        }

        private void newFile_Click(object sender, EventArgs e)
        {

        }

        private void openFile_Click(object sender, EventArgs e)
        {

        }

        private void saveFile(object sender, EventArgs e)
        {

        }

        private void createEdit_Click(object sender, EventArgs e)
        {

        }

        private void modifyEdit_Click(object sender, EventArgs e)
        {

        }

        private void deleteEdit_Click(object sender, EventArgs e)
        {

        }

        private void PreviousPagination(object sender, EventArgs e)
        {

        }

        private void NextPegination(object sender, EventArgs e)
        {

        }

        private void manageEdit_Click(object sender, EventArgs e)
        {

        }

        private void themeView_Click(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.ShowDialog();
        }

        private void TournamentPage_Load(object sender, EventArgs e)
        {
            this.tournamentTableAdapter.Fill(this.tournamentManagerDataSet.Tournament);

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.tournamentTableAdapter.Fill(this.tournamentManagerDataSet.Tournament);
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.ShowDialog();
        }
    }
}
