﻿using System;
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
    }
}