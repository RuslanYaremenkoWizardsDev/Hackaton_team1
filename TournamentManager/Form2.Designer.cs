
namespace TournamentManager
{
    partial class editResult
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
            this.teamOne = new System.Windows.Forms.Label();
            this.teamSecond = new System.Windows.Forms.Label();
            this.enteResult = new System.Windows.Forms.Label();
            this.comboTeamOne = new System.Windows.Forms.ComboBox();
            this.comboteamSecond = new System.Windows.Forms.ComboBox();
            this.textBoxEnteResult = new System.Windows.Forms.TextBox();
            this.saveResult = new System.Windows.Forms.Button();
            this.cancelResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teamOne
            // 
            this.teamOne.AutoSize = true;
            this.teamOne.Location = new System.Drawing.Point(34, 76);
            this.teamOne.Name = "teamOne";
            this.teamOne.Size = new System.Drawing.Size(55, 13);
            this.teamOne.TabIndex = 0;
            this.teamOne.Text = "Team one";
            // 
            // teamSecond
            // 
            this.teamSecond.AutoSize = true;
            this.teamSecond.Location = new System.Drawing.Point(143, 76);
            this.teamSecond.Name = "teamSecond";
            this.teamSecond.Size = new System.Drawing.Size(72, 13);
            this.teamSecond.TabIndex = 1;
            this.teamSecond.Text = "Team second";
            // 
            // enteResult
            // 
            this.enteResult.AutoSize = true;
            this.enteResult.Location = new System.Drawing.Point(277, 76);
            this.enteResult.Name = "enteResult";
            this.enteResult.Size = new System.Drawing.Size(53, 13);
            this.enteResult.TabIndex = 2;
            this.enteResult.Text = "Edit result";
            // 
            // comboTeamOne
            // 
            this.comboTeamOne.FormattingEnabled = true;
            this.comboTeamOne.Location = new System.Drawing.Point(-2, 102);
            this.comboTeamOne.Name = "comboTeamOne";
            this.comboTeamOne.Size = new System.Drawing.Size(121, 21);
            this.comboTeamOne.TabIndex = 3;
            // 
            // comboteamSecond
            // 
            this.comboteamSecond.FormattingEnabled = true;
            this.comboteamSecond.Location = new System.Drawing.Point(125, 102);
            this.comboteamSecond.Name = "comboteamSecond";
            this.comboteamSecond.Size = new System.Drawing.Size(121, 21);
            this.comboteamSecond.TabIndex = 4;
            // 
            // textBoxEnteResult
            // 
            this.textBoxEnteResult.Location = new System.Drawing.Point(261, 103);
            this.textBoxEnteResult.Name = "textBoxEnteResult";
            this.textBoxEnteResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnteResult.TabIndex = 5;
            // 
            // saveResult
            // 
            this.saveResult.Location = new System.Drawing.Point(217, 415);
            this.saveResult.Name = "saveResult";
            this.saveResult.Size = new System.Drawing.Size(75, 23);
            this.saveResult.TabIndex = 18;
            this.saveResult.Text = "Save";
            this.saveResult.UseVisualStyleBackColor = true;
            // 
            // cancelResult
            // 
            this.cancelResult.Location = new System.Drawing.Point(298, 415);
            this.cancelResult.Name = "cancelResult";
            this.cancelResult.Size = new System.Drawing.Size(75, 23);
            this.cancelResult.TabIndex = 17;
            this.cancelResult.Text = "Cancel";
            this.cancelResult.UseVisualStyleBackColor = true;
            // 
            // editResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 450);
            this.Controls.Add(this.saveResult);
            this.Controls.Add(this.cancelResult);
            this.Controls.Add(this.textBoxEnteResult);
            this.Controls.Add(this.comboteamSecond);
            this.Controls.Add(this.comboTeamOne);
            this.Controls.Add(this.enteResult);
            this.Controls.Add(this.teamSecond);
            this.Controls.Add(this.teamOne);
            this.Name = "editResult";
            this.Text = "Edit result";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label teamOne;
        private System.Windows.Forms.Label teamSecond;
        private System.Windows.Forms.Label enteResult;
        private System.Windows.Forms.ComboBox comboTeamOne;
        private System.Windows.Forms.ComboBox comboteamSecond;
        private System.Windows.Forms.TextBox textBoxEnteResult;
        private System.Windows.Forms.Button saveResult;
        private System.Windows.Forms.Button cancelResult;
    }
}