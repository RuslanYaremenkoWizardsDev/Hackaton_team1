
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
            this.Search = new System.Windows.Forms.Button();
            this.TableFromTournamentPage = new System.Windows.Forms.TableLayoutPanel();
            this.AddTour = new System.Windows.Forms.Button();
            this.Pagination = new System.Windows.Forms.Button();
            this.LeftPageReturn = new System.Windows.Forms.Button();
            this.buttonRightPageForward = new System.Windows.Forms.Button();
            this.menuStripTournamentPage.SuspendLayout();
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
            this.menuStripTournamentPage.Size = new System.Drawing.Size(1904, 43);
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
            this.StripMenuItemFile.Size = new System.Drawing.Size(66, 39);
            this.StripMenuItemFile.Text = "File";
            // 
            // newFile
            // 
            this.newFile.Name = "newFile";
            this.newFile.Size = new System.Drawing.Size(159, 40);
            this.newFile.Text = "New";
            this.newFile.Click += new System.EventHandler(this.newFile_Click);
            // 
            // open
            // 
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(159, 40);
            this.open.Text = "Open";
            this.open.Click += new System.EventHandler(this.openFile_Click);
            // 
            // save
            // 
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(159, 40);
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
            this.StripMenuItemEdit.Size = new System.Drawing.Size(71, 39);
            this.StripMenuItemEdit.Text = "Edit";
            // 
            // createEdit
            // 
            this.createEdit.Name = "createEdit";
            this.createEdit.Size = new System.Drawing.Size(188, 40);
            this.createEdit.Text = "Create";
            this.createEdit.Click += new System.EventHandler(this.createEdit_Click);
            // 
            // modifyEdit
            // 
            this.modifyEdit.Name = "modifyEdit";
            this.modifyEdit.Size = new System.Drawing.Size(188, 40);
            this.modifyEdit.Text = "Modify";
            this.modifyEdit.Click += new System.EventHandler(this.modifyEdit_Click);
            // 
            // deleteEdit
            // 
            this.deleteEdit.Name = "deleteEdit";
            this.deleteEdit.Size = new System.Drawing.Size(188, 40);
            this.deleteEdit.Text = "Delete";
            this.deleteEdit.Click += new System.EventHandler(this.deleteEdit_Click);
            // 
            // manageEdit
            // 
            this.manageEdit.Name = "manageEdit";
            this.manageEdit.Size = new System.Drawing.Size(188, 40);
            this.manageEdit.Text = "Manage";
            // 
            // StripMenuItemView
            // 
            this.StripMenuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeView});
            this.StripMenuItemView.Name = "StripMenuItemView";
            this.StripMenuItemView.Size = new System.Drawing.Size(82, 39);
            this.StripMenuItemView.Text = "View";
            // 
            // themeView
            // 
            this.themeView.Name = "themeView";
            this.themeView.Size = new System.Drawing.Size(206, 40);
            this.themeView.Text = "Theme";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Search
            // 
            this.Search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Search.Location = new System.Drawing.Point(687, 79);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(525, 40);
            this.Search.TabIndex = 2;
            this.Search.UseVisualStyleBackColor = true;
            // 
            // TableFromTournamentPage
            // 
            this.TableFromTournamentPage.ColumnCount = 9;
            this.TableFromTournamentPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TableFromTournamentPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TableFromTournamentPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TableFromTournamentPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TableFromTournamentPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TableFromTournamentPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TableFromTournamentPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TableFromTournamentPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TableFromTournamentPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TableFromTournamentPage.Location = new System.Drawing.Point(485, 201);
            this.TableFromTournamentPage.Name = "TableFromTournamentPage";
            this.TableFromTournamentPage.RowCount = 2;
            this.TableFromTournamentPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableFromTournamentPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TableFromTournamentPage.Size = new System.Drawing.Size(898, 359);
            this.TableFromTournamentPage.TabIndex = 3;
            // 
            // AddTour
            // 
            this.AddTour.Location = new System.Drawing.Point(860, 627);
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
            // TournamentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.buttonRightPageForward);
            this.Controls.Add(this.LeftPageReturn);
            this.Controls.Add(this.Pagination);
            this.Controls.Add(this.AddTour);
            this.Controls.Add(this.TableFromTournamentPage);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.menuStripTournamentPage);
            this.MainMenuStrip = this.menuStripTournamentPage;
            this.Name = "TournamentPage";
            this.Text = "Tournament Page";
            this.menuStripTournamentPage.ResumeLayout(false);
            this.menuStripTournamentPage.PerformLayout();
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
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TableLayoutPanel TableFromTournamentPage;
        private System.Windows.Forms.Button AddTour;
        private System.Windows.Forms.Button Pagination;
        private System.Windows.Forms.Button LeftPageReturn;
        private System.Windows.Forms.Button buttonRightPageForward;
    }
}

