
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
            this.dataGridResaltTour = new System.Windows.Forms.DataGridView();
            this.Edit_result = new System.Windows.Forms.Button();
            this.cupGrid = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResaltTour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cupGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridResaltTour
            // 
            this.dataGridResaltTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResaltTour.Location = new System.Drawing.Point(10, 20);
            this.dataGridResaltTour.Name = "dataGridResaltTour";
            this.dataGridResaltTour.RowHeadersWidth = 47;
            this.dataGridResaltTour.Size = new System.Drawing.Size(776, 175);
            this.dataGridResaltTour.TabIndex = 0;
            // 
            // Edit_result
            // 
            this.Edit_result.Location = new System.Drawing.Point(670, 232);
            this.Edit_result.Name = "Edit_result";
            this.Edit_result.Size = new System.Drawing.Size(118, 44);
            this.Edit_result.TabIndex = 1;
            this.Edit_result.Text = "Edit Result";
            this.Edit_result.UseVisualStyleBackColor = true;
            // 
            // cupGrid
            // 
            this.cupGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cupGrid.Location = new System.Drawing.Point(0, 335);
            this.cupGrid.Name = "cupGrid";
            this.cupGrid.Size = new System.Drawing.Size(807, 320);
            this.cupGrid.TabIndex = 2;
            this.cupGrid.TabStop = false;
            // 
            // Tournament_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 655);
            this.Controls.Add(this.cupGrid);
            this.Controls.Add(this.Edit_result);
            this.Controls.Add(this.dataGridResaltTour);
            this.Name = "Tournament_manager";
            this.Text = "Tournament manager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResaltTour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cupGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridResaltTour;
        private System.Windows.Forms.Button Edit_result;
        private System.Windows.Forms.PictureBox cupGrid;
    }
}