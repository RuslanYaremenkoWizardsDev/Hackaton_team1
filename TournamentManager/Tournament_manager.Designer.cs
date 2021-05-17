
namespace TournamentManager
{
    partial class Tournament_manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridResaltTour = new System.Windows.Forms.DataGridView();
            this.Edit_result = new System.Windows.Forms.Button();
            this.cupGrid = new System.Windows.Forms.PictureBox();
            this.tournamentManagerDataSet1 = new TournamentManager.TournamentManagerDataSet1();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamTableAdapter = new TournamentManager.TournamentManagerDataSet1TableAdapters.TeamTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResaltTour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cupGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentManagerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridResaltTour
            // 
            this.dataGridResaltTour.AllowUserToAddRows = false;
            this.dataGridResaltTour.AllowUserToDeleteRows = false;
            this.dataGridResaltTour.AutoGenerateColumns = false;
            this.dataGridResaltTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResaltTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.playersNumberDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn});
            this.dataGridResaltTour.DataSource = this.teamBindingSource;
            this.dataGridResaltTour.Location = new System.Drawing.Point(189, 31);
            this.dataGridResaltTour.Name = "dataGridResaltTour";
            this.dataGridResaltTour.RowHeadersWidth = 47;
            this.dataGridResaltTour.Size = new System.Drawing.Size(450, 148);
            this.dataGridResaltTour.TabIndex = 0;
            // 
            // Edit_result
            // 
            this.Edit_result.Location = new System.Drawing.Point(339, 226);
            this.Edit_result.Name = "Edit_result";
            this.Edit_result.Size = new System.Drawing.Size(150, 45);
            this.Edit_result.TabIndex = 1;
            this.Edit_result.Text = "Edit Result";
            this.Edit_result.UseVisualStyleBackColor = true;
            this.Edit_result.Click += new System.EventHandler(this.EditResult);
            // 
            // cupGrid
            // 
            this.cupGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cupGrid.Location = new System.Drawing.Point(0, 356);
            this.cupGrid.Name = "cupGrid";
            this.cupGrid.Size = new System.Drawing.Size(839, 300);
            this.cupGrid.TabIndex = 2;
            this.cupGrid.TabStop = false;
            // 
            // tournamentManagerDataSet1
            // 
            this.tournamentManagerDataSet1.DataSetName = "TournamentManagerDataSet1";
            this.tournamentManagerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataMember = "Team";
            this.teamBindingSource.DataSource = this.tournamentManagerDataSet1;
            // 
            // teamTableAdapter
            // 
            this.teamTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // playersNumberDataGridViewTextBoxColumn
            // 
            this.playersNumberDataGridViewTextBoxColumn.DataPropertyName = "PlayersNumber";
            this.playersNumberDataGridViewTextBoxColumn.HeaderText = "PlayersNumber";
            this.playersNumberDataGridViewTextBoxColumn.Name = "playersNumberDataGridViewTextBoxColumn";
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            // 
            // Tournament_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 656);
            this.Controls.Add(this.cupGrid);
            this.Controls.Add(this.Edit_result);
            this.Controls.Add(this.dataGridResaltTour);
            this.Name = "Tournament_manager";
            this.Text = "Tournament manager";
            this.Load += new System.EventHandler(this.Tournament_manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResaltTour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cupGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentManagerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridResaltTour;
        private System.Windows.Forms.Button Edit_result;
        private System.Windows.Forms.PictureBox cupGrid;
        private TournamentManagerDataSet1 tournamentManagerDataSet1;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private TournamentManagerDataSet1TableAdapters.TeamTableAdapter teamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playersNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
    }
}