
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
            this.textBoxSubmitPassword = new System.Windows.Forms.TextBox();
            this.Signup = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.labelErrorLoginRegistration = new System.Windows.Forms.Label();
            this.labelErrorPasswordRegistration = new System.Windows.Forms.Label();
            this.labelErrorSubmitPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(193, 99);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(56, 21);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Log in:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(193, 154);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(79, 21);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password:";
            // 
            // SubmitPassword
            // 
            this.SubmitPassword.AutoSize = true;
            this.SubmitPassword.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitPassword.Location = new System.Drawing.Point(193, 208);
            this.SubmitPassword.Name = "SubmitPassword";
            this.SubmitPassword.Size = new System.Drawing.Size(134, 21);
            this.SubmitPassword.TabIndex = 2;
            this.SubmitPassword.Text = "Submit password:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(333, 102);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(150, 20);
            this.textBoxLogin.TabIndex = 3;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(333, 154);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(150, 20);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // textBoxSubmitPassword
            // 
            this.textBoxSubmitPassword.Location = new System.Drawing.Point(333, 211);
            this.textBoxSubmitPassword.Name = "textBoxSubmitPassword";
            this.textBoxSubmitPassword.Size = new System.Drawing.Size(150, 20);
            this.textBoxSubmitPassword.TabIndex = 5;
            this.textBoxSubmitPassword.TextChanged += new System.EventHandler(this.textBoxSubmitpassword_TextChanged);
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
            // labelErrorLoginRegistration
            // 
            this.labelErrorLoginRegistration.AutoSize = true;
            this.labelErrorLoginRegistration.Location = new System.Drawing.Point(330, 125);
            this.labelErrorLoginRegistration.Name = "labelErrorLoginRegistration";
            this.labelErrorLoginRegistration.Size = new System.Drawing.Size(0, 13);
            this.labelErrorLoginRegistration.TabIndex = 8;
            // 
            // labelErrorPasswordRegistration
            // 
            this.labelErrorPasswordRegistration.AutoSize = true;
            this.labelErrorPasswordRegistration.Location = new System.Drawing.Point(330, 177);
            this.labelErrorPasswordRegistration.Name = "labelErrorPasswordRegistration";
            this.labelErrorPasswordRegistration.Size = new System.Drawing.Size(0, 13);
            this.labelErrorPasswordRegistration.TabIndex = 9;
            // 
            // labelErrorSubmitPassword
            // 
            this.labelErrorSubmitPassword.AutoSize = true;
            this.labelErrorSubmitPassword.Location = new System.Drawing.Point(330, 234);
            this.labelErrorSubmitPassword.Name = "labelErrorSubmitPassword";
            this.labelErrorSubmitPassword.Size = new System.Drawing.Size(0, 13);
            this.labelErrorSubmitPassword.TabIndex = 10;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelErrorSubmitPassword);
            this.Controls.Add(this.labelErrorPasswordRegistration);
            this.Controls.Add(this.labelErrorLoginRegistration);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.textBoxSubmitPassword);
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
        private System.Windows.Forms.TextBox textBoxSubmitPassword;
        private System.Windows.Forms.Button Signup;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label labelErrorLoginRegistration;
        private System.Windows.Forms.Label labelErrorPasswordRegistration;
        private System.Windows.Forms.Label labelErrorSubmitPassword;
    }
}