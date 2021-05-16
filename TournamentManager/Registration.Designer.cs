﻿
namespace TournamentManager
{
    partial class Registration
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.SubmitPassword = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxSubmitpassword = new System.Windows.Forms.TextBox();
            this.Signup = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(193, 99);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(68, 25);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Log in:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(193, 154);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(95, 25);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password:";
            // 
            // SubmitPassword
            // 
            this.SubmitPassword.AutoSize = true;
            this.SubmitPassword.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitPassword.Location = new System.Drawing.Point(193, 208);
            this.SubmitPassword.Name = "SubmitPassword";
            this.SubmitPassword.Size = new System.Drawing.Size(160, 25);
            this.SubmitPassword.TabIndex = 2;
            this.SubmitPassword.Text = "Submit password:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(286, 104);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(150, 20);
            this.textBoxLogin.TabIndex = 3;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(306, 159);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(150, 20);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // textBoxSubmitpassword
            // 
            this.textBoxSubmitpassword.Location = new System.Drawing.Point(371, 213);
            this.textBoxSubmitpassword.Name = "textBoxSubmitpassword";
            this.textBoxSubmitpassword.Size = new System.Drawing.Size(150, 20);
            this.textBoxSubmitpassword.TabIndex = 5;
            this.textBoxSubmitpassword.TextChanged += new System.EventHandler(this.textBoxSubmitpassword_TextChanged);
            // 
            // Signup
            // 
            this.Signup.Location = new System.Drawing.Point(219, 299);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(132, 44);
            this.Signup.TabIndex = 6;
            this.Signup.Text = "Sign up";
            this.Signup.UseVisualStyleBackColor = true;
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(371, 299);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(132, 44);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.textBoxSubmitpassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.SubmitPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.labelLogin);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label SubmitPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxSubmitpassword;
        private System.Windows.Forms.Button Signup;
        private System.Windows.Forms.Button Cancel;
    }
}