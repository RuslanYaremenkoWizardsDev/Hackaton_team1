
namespace TournamentManager
{
    partial class EditResult
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
            this.teamOne.Location = new System.Drawing.Point(83, 55);
            this.teamOne.Name = "teamOne";
            this.teamOne.Size = new System.Drawing.Size(52, 13);
            this.teamOne.TabIndex = 0;
            this.teamOne.Text = "First team";
            // 
            // teamSecond
            // 
            this.teamSecond.AutoSize = true;
            this.teamSecond.Location = new System.Drawing.Point(192, 55);
            this.teamSecond.Name = "teamSecond";
            this.teamSecond.Size = new System.Drawing.Size(73, 13);
            this.teamSecond.TabIndex = 1;
            this.teamSecond.Text = "Second team ";
            // 
            // enteResult
            // 
            this.enteResult.AutoSize = true;
            this.enteResult.Location = new System.Drawing.Point(332, 55);
            this.enteResult.Name = "enteResult";
            this.enteResult.Size = new System.Drawing.Size(53, 13);
            this.enteResult.TabIndex = 2;
            this.enteResult.Text = "Edit result";
            // 
            // comboTeamOne
            // 
            this.comboTeamOne.FormattingEnabled = true;
            this.comboTeamOne.Location = new System.Drawing.Point(47, 81);
            this.comboTeamOne.Name = "comboTeamOne";
            this.comboTeamOne.Size = new System.Drawing.Size(121, 21);
            this.comboTeamOne.TabIndex = 3;
            this.comboTeamOne.SelectedIndexChanged += new System.EventHandler(this.comboTeamOne_SelectedIndexChanged);
            // 
            // comboteamSecond
            // 
            this.comboteamSecond.FormattingEnabled = true;
            this.comboteamSecond.Location = new System.Drawing.Point(174, 81);
            this.comboteamSecond.Name = "comboteamSecond";
            this.comboteamSecond.Size = new System.Drawing.Size(121, 21);
            this.comboteamSecond.TabIndex = 4;
            this.comboteamSecond.SelectedIndexChanged += new System.EventHandler(this.comboteamSecond_SelectedIndexChanged);
            // 
            // textBoxEnteResult
            // 
            this.textBoxEnteResult.Location = new System.Drawing.Point(310, 81);
            this.textBoxEnteResult.Name = "textBoxEnteResult";
            this.textBoxEnteResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnteResult.TabIndex = 5;
            this.textBoxEnteResult.TextChanged += new System.EventHandler(this.textBoxEnteResult_TextChanged);
            // 
            // saveResult
            // 
            this.saveResult.Location = new System.Drawing.Point(254, 421);
            this.saveResult.Name = "saveResult";
            this.saveResult.Size = new System.Drawing.Size(75, 25);
            this.saveResult.TabIndex = 18;
            this.saveResult.Text = "Save";
            this.saveResult.UseVisualStyleBackColor = true;
            this.saveResult.Click += new System.EventHandler(this.saveResult_Click);
            // 
            // cancelResult
            // 
            this.cancelResult.Location = new System.Drawing.Point(335, 421);
            this.cancelResult.Name = "cancelResult";
            this.cancelResult.Size = new System.Drawing.Size(75, 25);
            this.cancelResult.TabIndex = 17;
            this.cancelResult.Text = "Cancel";
            this.cancelResult.UseVisualStyleBackColor = true;
            this.cancelResult.Click += new System.EventHandler(this.cancelResult_Click);
            // 
            // EditResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 491);
            this.Controls.Add(this.saveResult);
            this.Controls.Add(this.cancelResult);
            this.Controls.Add(this.textBoxEnteResult);
            this.Controls.Add(this.comboteamSecond);
            this.Controls.Add(this.comboTeamOne);
            this.Controls.Add(this.enteResult);
            this.Controls.Add(this.teamSecond);
            this.Controls.Add(this.teamOne);
            this.Name = "EditResult";
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