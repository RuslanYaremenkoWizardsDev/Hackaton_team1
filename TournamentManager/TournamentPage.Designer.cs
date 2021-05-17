
namespace TournamentManager
{
    partial class TournamentPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentPage));
            this.menuStripTournamentPage = new System.Windows.Forms.MenuStrip();
            this.StripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.newFile = new System.Windows.Forms.ToolStripMenuItem();
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.createEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.themeView = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddTour = new System.Windows.Forms.Button();
            this.Pagination = new System.Windows.Forms.Button();
            this.LeftPageReturn = new System.Windows.Forms.Button();
            this.buttonRightPageForward = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tournamentManagerDataSet = new TournamentManager.TournamentManagerDataSet();
            this.tournamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tournamentTableAdapter = new TournamentManager.TournamentManagerDataSetTableAdapters.TournamentTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tournamentLavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.participantsNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tournamentScenarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripTournamentPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripTournamentPage
            // 
            this.menuStripTournamentPage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStripTournamentPage.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStripTournamentPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuItemFile,
            this.StripMenuItemEdit,
            this.StripMenuItemView});
            this.menuStripTournamentPage.Location = new System.Drawing.Point(0, 0);
            this.menuStripTournamentPage.Name = "menuStripTournamentPage";
            this.menuStripTournamentPage.Size = new System.Drawing.Size(1167, 38);
            this.menuStripTournamentPage.TabIndex = 0;
            this.menuStripTournamentPage.Text = "menuStripFromTornPage";
            // 
            // StripMenuItemFile
            // 
            this.StripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFile,
            this.open,
            this.save});
            this.StripMenuItemFile.Name = "StripMenuItemFile";
            this.StripMenuItemFile.Size = new System.Drawing.Size(56, 34);
            this.StripMenuItemFile.Text = "File";
            // 
            // newFile
            // 
            this.newFile.Name = "newFile";
            this.newFile.Size = new System.Drawing.Size(180, 34);
            this.newFile.Text = "New";
            this.newFile.Click += new System.EventHandler(this.newFile_Click);
            // 
            // open
            // 
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(180, 34);
            this.open.Text = "Open";
            this.open.Click += new System.EventHandler(this.openFile_Click);
            // 
            // save
            // 
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(180, 34);
            this.save.Text = "Save";
            this.save.Click += new System.EventHandler(this.saveFile);
            // 
            // StripMenuItemEdit
            // 
            this.StripMenuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createEdit,
            this.modifyEdit,
            this.deleteEdit,
            this.manageEdit});
            this.StripMenuItemEdit.Name = "StripMenuItemEdit";
            this.StripMenuItemEdit.Size = new System.Drawing.Size(60, 34);
            this.StripMenuItemEdit.Text = "Edit";
            // 
            // createEdit
            // 
            this.createEdit.Name = "createEdit";
            this.createEdit.Size = new System.Drawing.Size(162, 34);
            this.createEdit.Text = "Create";
            this.createEdit.Click += new System.EventHandler(this.createEdit_Click);
            // 
            // modifyEdit
            // 
            this.modifyEdit.Name = "modifyEdit";
            this.modifyEdit.Size = new System.Drawing.Size(162, 34);
            this.modifyEdit.Text = "Modify";
            this.modifyEdit.Click += new System.EventHandler(this.modifyEdit_Click);
            // 
            // deleteEdit
            // 
            this.deleteEdit.Name = "deleteEdit";
            this.deleteEdit.Size = new System.Drawing.Size(162, 34);
            this.deleteEdit.Text = "Delete";
            this.deleteEdit.Click += new System.EventHandler(this.deleteEdit_Click);
            // 
            // manageEdit
            // 
            this.manageEdit.Name = "manageEdit";
            this.manageEdit.Size = new System.Drawing.Size(162, 34);
            this.manageEdit.Text = "Manage";
            // 
            // StripMenuItemView
            // 
            this.StripMenuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeView});
            this.StripMenuItemView.Name = "StripMenuItemView";
            this.StripMenuItemView.Size = new System.Drawing.Size(69, 34);
            this.StripMenuItemView.Text = "View";
            // 
            // themeView
            // 
            this.themeView.Name = "themeView";
            this.themeView.Size = new System.Drawing.Size(149, 34);
            this.themeView.Text = "Theme";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AddTour
            // 
            this.AddTour.Location = new System.Drawing.Point(506, 277);
            this.AddTour.Name = "AddTour";
            this.AddTour.Size = new System.Drawing.Size(150, 45);
            this.AddTour.TabIndex = 4;
            this.AddTour.Text = "Add Tournament";
            this.AddTour.UseVisualStyleBackColor = true;
            this.AddTour.Click += new System.EventHandler(this.Create_tournament);
            // 
            // Pagination
            // 
            this.Pagination.Location = new System.Drawing.Point(934, 937);
            this.Pagination.Name = "Pagination";
            this.Pagination.Size = new System.Drawing.Size(35, 39);
            this.Pagination.TabIndex = 5;
            this.Pagination.Text = "1";
            this.Pagination.UseVisualStyleBackColor = true;
            // 
            // LeftPageReturn
            // 
            this.LeftPageReturn.FlatAppearance.BorderSize = 0;
            this.LeftPageReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftPageReturn.Image = ((System.Drawing.Image)(resources.GetObject("LeftPageReturn.Image")));
            this.LeftPageReturn.Location = new System.Drawing.Point(893, 937);
            this.LeftPageReturn.Name = "LeftPageReturn";
            this.LeftPageReturn.Size = new System.Drawing.Size(35, 39);
            this.LeftPageReturn.TabIndex = 6;
            this.LeftPageReturn.UseVisualStyleBackColor = true;
            // 
            // buttonRightPageForward
            // 
            this.buttonRightPageForward.FlatAppearance.BorderSize = 0;
            this.buttonRightPageForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRightPageForward.Image = ((System.Drawing.Image)(resources.GetObject("buttonRightPageForward.Image")));
            this.buttonRightPageForward.Location = new System.Drawing.Point(975, 937);
            this.buttonRightPageForward.Name = "buttonRightPageForward";
            this.buttonRightPageForward.Size = new System.Drawing.Size(35, 39);
            this.buttonRightPageForward.TabIndex = 7;
            this.buttonRightPageForward.UseVisualStyleBackColor = true;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(1756, 58);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(119, 46);
            this.Username.TabIndex = 8;
            this.Username.UseVisualStyleBackColor = true;
            this.Username.Click += new System.EventHandler(this.Username_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.gameStartDataGridViewTextBoxColumn,
            this.registrationEndDataGridViewTextBoxColumn,
            this.tournamentLavelDataGridViewTextBoxColumn,
            this.participantsNumberDataGridViewTextBoxColumn,
            this.tournamentScenarioDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tournamentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1144, 215);
            this.dataGridView1.TabIndex = 9;
            // 
            // tournamentManagerDataSet
            // 
            this.tournamentManagerDataSet.DataSetName = "TournamentManagerDataSet";
            this.tournamentManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tournamentBindingSource
            // 
            this.tournamentBindingSource.DataMember = "Tournament";
            this.tournamentBindingSource.DataSource = this.tournamentManagerDataSet;
            // 
            // tournamentTableAdapter
            // 
            this.tournamentTableAdapter.ClearBeforeFill = true;
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
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // gameStartDataGridViewTextBoxColumn
            // 
            this.gameStartDataGridViewTextBoxColumn.DataPropertyName = "GameStart";
            this.gameStartDataGridViewTextBoxColumn.HeaderText = "GameStart";
            this.gameStartDataGridViewTextBoxColumn.Name = "gameStartDataGridViewTextBoxColumn";
            // 
            // registrationEndDataGridViewTextBoxColumn
            // 
            this.registrationEndDataGridViewTextBoxColumn.DataPropertyName = "RegistrationEnd";
            this.registrationEndDataGridViewTextBoxColumn.HeaderText = "RegistrationEnd";
            this.registrationEndDataGridViewTextBoxColumn.Name = "registrationEndDataGridViewTextBoxColumn";
            // 
            // tournamentLavelDataGridViewTextBoxColumn
            // 
            this.tournamentLavelDataGridViewTextBoxColumn.DataPropertyName = "TournamentLavel";
            this.tournamentLavelDataGridViewTextBoxColumn.HeaderText = "TournamentLavel";
            this.tournamentLavelDataGridViewTextBoxColumn.Name = "tournamentLavelDataGridViewTextBoxColumn";
            // 
            // participantsNumberDataGridViewTextBoxColumn
            // 
            this.participantsNumberDataGridViewTextBoxColumn.DataPropertyName = "ParticipantsNumber";
            this.participantsNumberDataGridViewTextBoxColumn.HeaderText = "ParticipantsNumber";
            this.participantsNumberDataGridViewTextBoxColumn.Name = "participantsNumberDataGridViewTextBoxColumn";
            // 
            // tournamentScenarioDataGridViewTextBoxColumn
            // 
            this.tournamentScenarioDataGridViewTextBoxColumn.DataPropertyName = "TournamentScenario";
            this.tournamentScenarioDataGridViewTextBoxColumn.HeaderText = "TournamentScenario";
            this.tournamentScenarioDataGridViewTextBoxColumn.Name = "tournamentScenarioDataGridViewTextBoxColumn";
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "Result";
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            // 
            // TournamentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1167, 346);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.buttonRightPageForward);
            this.Controls.Add(this.LeftPageReturn);
            this.Controls.Add(this.Pagination);
            this.Controls.Add(this.AddTour);
            this.Controls.Add(this.menuStripTournamentPage);
            this.MainMenuStrip = this.menuStripTournamentPage;
            this.Name = "TournamentPage";
            this.Text = "Tournament Page";
            this.Load += new System.EventHandler(this.TournamentPage_Load);
            this.menuStripTournamentPage.ResumeLayout(false);
            this.menuStripTournamentPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTournamentPage;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem newFile;
        private System.Windows.Forms.ToolStripMenuItem open;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem createEdit;
        private System.Windows.Forms.ToolStripMenuItem modifyEdit;
        private System.Windows.Forms.ToolStripMenuItem deleteEdit;
        private System.Windows.Forms.ToolStripMenuItem manageEdit;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItemView;
        private System.Windows.Forms.ToolStripMenuItem themeView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button AddTour;
        private System.Windows.Forms.Button Pagination;
        private System.Windows.Forms.Button LeftPageReturn;
        private System.Windows.Forms.Button buttonRightPageForward;
        private System.Windows.Forms.Button Username;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TournamentManagerDataSet tournamentManagerDataSet;
        private System.Windows.Forms.BindingSource tournamentBindingSource;
        private TournamentManagerDataSetTableAdapters.TournamentTableAdapter tournamentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tournamentLavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn participantsNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tournamentScenarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
    }
}

