
namespace TournamentManager
{
    partial class Players
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
            this.NamePlayer = new System.Windows.Forms.Label();
            this.InputNameInPlayers = new System.Windows.Forms.Button();
            this.AddNameNewPlayer = new System.Windows.Forms.Button();
            this.SaveNamesPlayers = new System.Windows.Forms.Button();
            this.CancelNewNamePlayers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NamePlayer
            // 
            this.NamePlayer.AutoSize = true;
            this.NamePlayer.Location = new System.Drawing.Point(29, 44);
            this.NamePlayer.Name = "NamePlayer";
            this.NamePlayer.Size = new System.Drawing.Size(38, 13);
            this.NamePlayer.TabIndex = 0;
            this.NamePlayer.Text = "Name:";
            // 
            // InputNameInPlayers
            // 
            this.InputNameInPlayers.Location = new System.Drawing.Point(72, 38);
            this.InputNameInPlayers.Name = "InputNameInPlayers";
            this.InputNameInPlayers.Size = new System.Drawing.Size(200, 25);
            this.InputNameInPlayers.TabIndex = 1;
            this.InputNameInPlayers.UseVisualStyleBackColor = true;
            // 
            // AddNameNewPlayer
            // 
            this.AddNameNewPlayer.Location = new System.Drawing.Point(72, 69);
            this.AddNameNewPlayer.Name = "AddNameNewPlayer";
            this.AddNameNewPlayer.Size = new System.Drawing.Size(25, 25);
            this.AddNameNewPlayer.TabIndex = 2;
            this.AddNameNewPlayer.Text = "+";
            this.AddNameNewPlayer.UseVisualStyleBackColor = true;
            // 
            // SaveNamesPlayers
            // 
            this.SaveNamesPlayers.Location = new System.Drawing.Point(116, 248);
            this.SaveNamesPlayers.Name = "SaveNamesPlayers";
            this.SaveNamesPlayers.Size = new System.Drawing.Size(75, 25);
            this.SaveNamesPlayers.TabIndex = 3;
            this.SaveNamesPlayers.Text = "Save";
            this.SaveNamesPlayers.UseVisualStyleBackColor = true;
            // 
            // CancelNewNamePlayers
            // 
            this.CancelNewNamePlayers.Location = new System.Drawing.Point(197, 248);
            this.CancelNewNamePlayers.Name = "CancelNewNamePlayers";
            this.CancelNewNamePlayers.Size = new System.Drawing.Size(75, 25);
            this.CancelNewNamePlayers.TabIndex = 4;
            this.CancelNewNamePlayers.Text = "Cancel";
            this.CancelNewNamePlayers.UseVisualStyleBackColor = true;
            // 
            // Players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 491);
            this.Controls.Add(this.CancelNewNamePlayers);
            this.Controls.Add(this.SaveNamesPlayers);
            this.Controls.Add(this.AddNameNewPlayer);
            this.Controls.Add(this.InputNameInPlayers);
            this.Controls.Add(this.NamePlayer);
            this.Name = "Players";
            this.Text = "Players";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NamePlayer;
        private System.Windows.Forms.Button InputNameInPlayers;
        private System.Windows.Forms.Button AddNameNewPlayer;
        private System.Windows.Forms.Button SaveNamesPlayers;
        private System.Windows.Forms.Button CancelNewNamePlayers;
    }
}