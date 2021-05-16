
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
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Search = new System.Windows.Forms.Button();
            this.TableFromTournamentPage = new System.Windows.Forms.TableLayoutPanel();
            this.AddTour = new System.Windows.Forms.Button();
            this.buttonPagination = new System.Windows.Forms.Button();
            this.buttonLeftPageReturn = new System.Windows.Forms.Button();
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
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.StripMenuItemFile.Name = "StripMenuItemFile";
            this.StripMenuItemFile.Size = new System.Drawing.Size(66, 39);
            this.StripMenuItemFile.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(159, 40);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(159, 40);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(159, 40);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // StripMenuItemEdit
            // 
            this.StripMenuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.manageToolStripMenuItem});
            this.StripMenuItemEdit.Name = "StripMenuItemEdit";
            this.StripMenuItemEdit.Size = new System.Drawing.Size(71, 39);
            this.StripMenuItemEdit.Text = "Edit";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(188, 40);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(188, 40);
            this.modifyToolStripMenuItem.Text = "Modify";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(188, 40);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(188, 40);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // StripMenuItemView
            // 
            this.StripMenuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem});
            this.StripMenuItemView.Name = "StripMenuItemView";
            this.StripMenuItemView.Size = new System.Drawing.Size(82, 39);
            this.StripMenuItemView.Text = "View";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(173, 40);
            this.themeToolStripMenuItem.Text = "Theme";
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
            this.TableFromTournamentPage.BackColor = System.Drawing.Color.Silver;
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
            this.AddTour.Text = "Add Tour";
            this.AddTour.UseVisualStyleBackColor = true;
            // 
            // buttonPagination
            // 
            this.buttonPagination.Location = new System.Drawing.Point(934, 937);
            this.buttonPagination.Name = "buttonPagination";
            this.buttonPagination.Size = new System.Drawing.Size(35, 39);
            this.buttonPagination.TabIndex = 5;
            this.buttonPagination.Text = "1";
            this.buttonPagination.UseVisualStyleBackColor = true;
            // 
            // buttonLeftPageReturn
            // 
            this.buttonLeftPageReturn.FlatAppearance.BorderSize = 0;
            this.buttonLeftPageReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeftPageReturn.Image = ((System.Drawing.Image)(resources.GetObject("buttonLeftPageReturn.Image")));
            this.buttonLeftPageReturn.Location = new System.Drawing.Point(893, 937);
            this.buttonLeftPageReturn.Name = "buttonLeftPageReturn";
            this.buttonLeftPageReturn.Size = new System.Drawing.Size(35, 39);
            this.buttonLeftPageReturn.TabIndex = 6;
            this.buttonLeftPageReturn.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.buttonLeftPageReturn);
            this.Controls.Add(this.buttonPagination);
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
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItemView;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TableLayoutPanel TableFromTournamentPage;
        private System.Windows.Forms.Button AddTour;
        private System.Windows.Forms.Button buttonPagination;
        private System.Windows.Forms.Button buttonLeftPageReturn;
        private System.Windows.Forms.Button buttonRightPageForward;
    }
}

