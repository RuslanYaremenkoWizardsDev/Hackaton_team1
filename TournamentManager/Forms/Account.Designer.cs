
namespace TournamentManager
{
    partial class Account
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
            this.Password = new System.Windows.Forms.Label();
            this.SubmitPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxSubmitPassword = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.labelErrorPassword = new System.Windows.Forms.Label();
            this.labelErrorSubmitPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Segoe UI Semibold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.ForeColor = System.Drawing.Color.Gold;
            this.Password.Location = new System.Drawing.Point(83, 51);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(96, 25);
            this.Password.TabIndex = 0;
            this.Password.Text = "Password:";
            // 
            // SubmitPassword
            // 
            this.SubmitPassword.AutoSize = true;
            this.SubmitPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitPassword.ForeColor = System.Drawing.Color.Gold;
            this.SubmitPassword.Location = new System.Drawing.Point(83, 98);
            this.SubmitPassword.Name = "SubmitPassword";
            this.SubmitPassword.Size = new System.Drawing.Size(163, 25);
            this.SubmitPassword.TabIndex = 1;
            this.SubmitPassword.Text = "Submit password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(264, 57);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(200, 20);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // textBoxSubmitPassword
            // 
            this.textBoxSubmitPassword.Location = new System.Drawing.Point(264, 103);
            this.textBoxSubmitPassword.Name = "textBoxSubmitPassword";
            this.textBoxSubmitPassword.Size = new System.Drawing.Size(200, 20);
            this.textBoxSubmitPassword.TabIndex = 3;
            this.textBoxSubmitPassword.TextChanged += new System.EventHandler(this.textBoxSubmitpassword_TextChanged);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.Gold;
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.Font = new System.Drawing.Font("Segoe UI Semibold", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OK.Location = new System.Drawing.Point(113, 177);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(100, 40);
            this.OK.TabIndex = 4;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.Gold;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logout.Font = new System.Drawing.Font("Segoe UI Semibold", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Logout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Logout.Location = new System.Drawing.Point(226, 177);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(100, 40);
            this.Logout.TabIndex = 5;
            this.Logout.Text = "Log out";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Gold;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(340, 177);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 40);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // labelErrorPassword
            // 
            this.labelErrorPassword.AutoSize = true;
            this.labelErrorPassword.ForeColor = System.Drawing.Color.Gold;
            this.labelErrorPassword.Location = new System.Drawing.Point(267, 83);
            this.labelErrorPassword.Name = "labelErrorPassword";
            this.labelErrorPassword.Size = new System.Drawing.Size(0, 13);
            this.labelErrorPassword.TabIndex = 7;
            // 
            // labelErrorSubmitPassword
            // 
            this.labelErrorSubmitPassword.AutoSize = true;
            this.labelErrorSubmitPassword.ForeColor = System.Drawing.Color.Gold;
            this.labelErrorSubmitPassword.Location = new System.Drawing.Point(268, 133);
            this.labelErrorSubmitPassword.Name = "labelErrorSubmitPassword";
            this.labelErrorSubmitPassword.Size = new System.Drawing.Size(0, 13);
            this.labelErrorSubmitPassword.TabIndex = 8;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(556, 354);
            this.Controls.Add(this.labelErrorSubmitPassword);
            this.Controls.Add(this.labelErrorPassword);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.textBoxSubmitPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.SubmitPassword);
            this.Controls.Add(this.Password);
            this.Name = "Account";
            this.Text = "Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label SubmitPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxSubmitPassword;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label labelErrorPassword;
        private System.Windows.Forms.Label labelErrorSubmitPassword;
    }
}