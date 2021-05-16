using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TournamentManager.Logic.Tournament;

namespace TournamentManager
{

    public partial class CreateTournament : Form
    {
        public string name = "";
        public string place = "";
        public string description = "";
        public bool temp;
        public int count, countplayers;
        public string LevelTournament;
        public DateTime DateEndRegistration, DateStarttemp, DateStartTournament;

        public CreateTournament()
        {
            InitializeComponent();
        }


        private void cancelTournament_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveTournament_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            string st1 = "0123456789&!@$#^&*()=*+,";
            name = textBoxName.Text; 
            if ( name != null && name.Length <= 255)
            {
                for (int i = 0; i < st1.Length; i++)
                {
                    if (name.IndexOf(st1[i]) >= 0)
                    {
                        labelError.Text = "The string must not contain numbers and invalid characters";
                        textBoxName.BackColor = Color.Red;
                    }
                    else
                    {
                        name = textBoxName.Text;
                    }
                }
            }
        }

        private void textBoxCounPlayer_TextChanged(object sender, EventArgs e)
        {
            temp  = Int32.TryParse(textBoxCounPlayer.Text, out count);
            if ( count > 0 && count <= 255)
            {
                 countplayers = count;
                textBoxCounPlayer.Text = countplayers.ToString();
            }
            else
            {
                labelErrorCount.Text = "The string must contain only numbers and number not be 0";
                textBoxCounPlayer.BackColor = Color.Red;
            }
        }

        private void textBoxPlace_TextChanged(object sender, EventArgs e)
        {
            string st1 = "0123456789&!@$#^&*()=*+,";
            place = textBoxPlace.Text;
            if (place != null && place.Length <= 255)
            {
                for (int i = 0; i < st1.Length; i++)
                {
                    if (place.IndexOf(st1[i]) >= 0)
                    {
                        labelErrorPlace.Text = "The string must not contain numbers and invalid characters";
                        textBoxPlace.BackColor = Color.Red;
                    }
                    else
                    {
                        place = textBoxName.Text;
                    }
                }
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxLevel_SelectedIndexChanged(object sender, EventArgs e) 
        {
            LevelTournament = comboBoxLevel.Text;   
        }

        private void dateTimeEndRegistration_ValueChanged(object sender, EventArgs e)
        {
            DateEndRegistration = dateTimeEndRegistration.Value;
        }

        private void dateTimeStartTourn_ValueChanged(object sender, EventArgs e)
        {
            DateStarttemp  = dateTimeStartTourn.Value;
            if (DateStarttemp < DateEndRegistration)
            {
                labelErrorDateStart.Text = "The start date of the tournament must not be earlier than the registration date";
                labelErrorDateStart.BackColor = Color.Red;
            }
            else
            {
                DateStartTournament = DateStarttemp;
            }
          
        }

        private void GenerateName_Click(object sender, EventArgs e)
        {

        }

        private void CreateTournament_Load(object sender, EventArgs e)
        {

        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            description = textBoxDescription.Text;
            if (description != null && description.Length <= 10000)
            {
                description = textBoxDescription.Text;
            }
            else
            {
                labelErrorDescription.Text = "The string must not contain numbers and invalid characters";
                textBoxDescription.BackColor = Color.Red;
            }
        }
    }
}
