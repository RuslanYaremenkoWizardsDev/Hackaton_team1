
namespace TournamentManager.Forms
{
    partial class Participant
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
            this.Name = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.AddNewPartipant = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.labelErrorName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.Location = new System.Drawing.Point(30, 33);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(55, 21);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(104, 34);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(159, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddNewPartipant
            // 
            this.AddNewPartipant.Location = new System.Drawing.Point(34, 77);
            this.AddNewPartipant.Name = "AddNewPartipant";
            this.AddNewPartipant.Size = new System.Drawing.Size(35, 35);
            this.AddNewPartipant.TabIndex = 2;
            this.AddNewPartipant.Text = "+";
            this.AddNewPartipant.UseVisualStyleBackColor = true;
            this.AddNewPartipant.Click += new System.EventHandler(this.AddNewPartipant_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(193, 429);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 34);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(311, 429);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 34);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // labelErrorName
            // 
            this.labelErrorName.AutoSize = true;
            this.labelErrorName.Location = new System.Drawing.Point(108, 60);
            this.labelErrorName.Name = "labelErrorName";
            this.labelErrorName.Size = new System.Drawing.Size(0, 13);
            this.labelErrorName.TabIndex = 5;
            // 
            // Participant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 491);
            this.Controls.Add(this.labelErrorName);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.AddNewPartipant);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.Name);
            this.Name = "Participant";
            this.Text = "Participant";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.Cancel = new System.Windows.Forms.Button();
            this.labelErrorName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.Location = new System.Drawing.Point(30, 33);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(55, 21);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(104, 34);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(159, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddNewPartipant
            // 
            this.AddNewPartipant.Location = new System.Drawing.Point(34, 77);
            this.AddNewPartipant.Name = "AddNewPartipant";
            this.AddNewPartipant.Size = new System.Drawing.Size(35, 35);
            this.AddNewPartipant.TabIndex = 2;
            this.AddNewPartipant.Text = "+";
            this.AddNewPartipant.UseVisualStyleBackColor = true;
            this.AddNewPartipant.Click += new System.EventHandler(this.AddNewPartipant_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(104, 326);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 34);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(222, 326);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 34);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // labelErrorName
            // 
            this.labelErrorName.AutoSize = true;
            this.labelErrorName.Location = new System.Drawing.Point(108, 60);
            this.labelErrorName.Name = "labelErrorName";
            this.labelErrorName.Size = new System.Drawing.Size(0, 13);
            this.labelErrorName.TabIndex = 5;
            // 
            // Participant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 491);
            this.Controls.Add(this.labelErrorName);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.AddNewPartipant);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.Name);
            this.Name = "Participant";
            this.Text = "Participant";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.Location = new System.Drawing.Point(30, 33);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(55, 21);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(104, 34);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(159, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddNewPartipant
            // 
            this.AddNewPartipant.Location = new System.Drawing.Point(34, 77);
            this.AddNewPartipant.Name = "AddNewPartipant";
            this.AddNewPartipant.Size = new System.Drawing.Size(35, 35);
            this.AddNewPartipant.TabIndex = 2;
            this.AddNewPartipant.Text = "+";
            this.AddNewPartipant.UseVisualStyleBackColor = true;
            this.AddNewPartipant.Click += new System.EventHandler(this.AddNewPartipant_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(104, 326);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 34);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(222, 326);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 34);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Participant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 491);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.AddNewPartipant);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.Name);
            this.Name = "Participant";
            this.Text = "Participant";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.Location = new System.Drawing.Point(30, 33);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(55, 21);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(104, 34);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(159, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddNewPartipant
            // 
            this.AddNewPartipant.Location = new System.Drawing.Point(34, 77);
            this.AddNewPartipant.Name = "AddNewPartipant";
            this.AddNewPartipant.Size = new System.Drawing.Size(35, 35);
            this.AddNewPartipant.TabIndex = 2;
            this.AddNewPartipant.Text = "+";
            this.AddNewPartipant.UseVisualStyleBackColor = true;
            this.AddNewPartipant.Click += new System.EventHandler(this.AddNewPartipant_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(104, 326);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 34);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(222, 326);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 34);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Participant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 491);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.AddNewPartipant);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.Name);
            this.Name = "Participant";
            this.Text = "Participant";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.Location = new System.Drawing.Point(30, 33);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(55, 21);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddNewPartipant
            // 
            this.AddNewPartipant.Location = new System.Drawing.Point(34, 77);
            this.AddNewPartipant.Name = "AddNewPartipant";
            this.AddNewPartipant.Size = new System.Drawing.Size(35, 35);
            this.AddNewPartipant.TabIndex = 2;
            this.AddNewPartipant.Text = "+";
            this.AddNewPartipant.UseVisualStyleBackColor = true;
            this.AddNewPartipant.Click += new System.EventHandler(this.AddNewPartipant_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(104, 326);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 34);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(222, 326);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 34);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Participant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 491);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.AddNewPartipant);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Name);
            this.Name = "Participant";
            this.Text = "Participant";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.Location = new System.Drawing.Point(30, 33);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(55, 21);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddNewPartipant
            // 
            this.AddNewPartipant.Location = new System.Drawing.Point(34, 77);
            this.AddNewPartipant.Name = "AddNewPartipant";
            this.AddNewPartipant.Size = new System.Drawing.Size(35, 35);
            this.AddNewPartipant.TabIndex = 2;
            this.AddNewPartipant.Text = "+";
            this.AddNewPartipant.UseVisualStyleBackColor = true;
            this.AddNewPartipant.Click += new System.EventHandler(this.AddNewPartipant_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(104, 326);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 34);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(222, 326);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 34);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Participant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 491);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.AddNewPartipant);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Name);
            this.Name = "Participant";
            this.Text = "Participant";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.Location = new System.Drawing.Point(30, 33);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(55, 21);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddNewPartipant
            // 
            this.AddNewPartipant.Location = new System.Drawing.Point(34, 77);
            this.AddNewPartipant.Name = "AddNewPartipant";
            this.AddNewPartipant.Size = new System.Drawing.Size(35, 35);
            this.AddNewPartipant.TabIndex = 2;
            this.AddNewPartipant.Text = "+";
            this.AddNewPartipant.UseVisualStyleBackColor = true;
            this.AddNewPartipant.Click += new System.EventHandler(this.AddNewPartipant_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(104, 326);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 34);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(222, 326);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 34);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Participant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 491);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.AddNewPartipant);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Name);
            this.Name = "Participant";
            this.Text = "Participant";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.Location = new System.Drawing.Point(30, 33);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(55, 21);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddNewPartipant
            // 
            this.AddNewPartipant.Location = new System.Drawing.Point(34, 77);
            this.AddNewPartipant.Name = "AddNewPartipant";
            this.AddNewPartipant.Size = new System.Drawing.Size(35, 35);
            this.AddNewPartipant.TabIndex = 2;
            this.AddNewPartipant.Text = "+";
            this.AddNewPartipant.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(104, 326);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 34);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(222, 326);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 34);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Participant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 491);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.AddNewPartipant);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Name);
            this.Name = "Participant";
            this.Text = "Participant";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Name = "Participant";
            this.Text = "Participant";
            this.ResumeLayout(false);

        }

        #endregion
    }
}