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
    public partial class Tournament_manager : Form
    {    
        public Tournament_manager()
        {
            InitializeComponent();
        }
        private void EditResult(object sender, EventArgs e)
        {
            EditResult editresult = new EditResult();
            editresult.ShowDialog();
        }
        private void Tournament_manager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tournamentManagerDataSet1.Team' table. You can move, or remove it, as needed.
            this.teamTableAdapter.Fill(this.tournamentManagerDataSet1.Team);
            DrawTournTable drowTeble = new DrawTournTable();
            Bitmap _mainBitmap;
            Bitmap _tmpBitmap;
            Graphics _graphics;
            Pen _pen;

            _mainBitmap = new Bitmap(cupGrid.Width, cupGrid.Height);
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.LightSteelBlue);
            _pen = new Pen(Color.Black);

            drowTeble.Initialize();
            drowTeble.Draw(_graphics, _pen);
            cupGrid.Image = _mainBitmap;
        }
    }
}
