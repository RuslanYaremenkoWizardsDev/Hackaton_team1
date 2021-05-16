﻿
namespace TournamentManager
{
    partial class CreateTournament
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
            this.textBoxCounPlayer = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.nemeTournament = new System.Windows.Forms.Label();
            this.playerСount = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.registrationEndDate = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Label();
            this.tournamentStartDate = new System.Windows.Forms.Label();
            this.GeneratePlace = new System.Windows.Forms.Button();
            this.cancelTournament = new System.Windows.Forms.Button();
            this.saveTournament = new System.Windows.Forms.Button();
            this.place = new System.Windows.Forms.Label();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.dateTimeEndRegistration = new System.Windows.Forms.DateTimePicker();
            this.dateTimeStartTourn = new System.Windows.Forms.DateTimePicker();
            this.discription = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GenerateName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCounPlayer
            // 
            this.textBoxCounPlayer.Location = new System.Drawing.Point(165, 117);
            this.textBoxCounPlayer.Name = "textBoxCounPlayer";
            this.textBoxCounPlayer.Size = new System.Drawing.Size(100, 20);
            this.textBoxCounPlayer.TabIndex = 1;
            this.textBoxCounPlayer.TextChanged += new System.EventHandler(this.textBoxCounPlayer_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(165, 50);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // nemeTournament
            // 
            this.nemeTournament.AutoSize = true;
            this.nemeTournament.Location = new System.Drawing.Point(42, 57);
            this.nemeTournament.Name = "nemeTournament";
            this.nemeTournament.Size = new System.Drawing.Size(38, 13);
            this.nemeTournament.TabIndex = 7;
            this.nemeTournament.Text = "Name:";
            // 
            // playerСount
            // 
            this.playerСount.AutoSize = true;
            this.playerСount.Location = new System.Drawing.Point(42, 124);
            this.playerСount.Name = "playerСount";
            this.playerСount.Size = new System.Drawing.Size(83, 13);
            this.playerСount.TabIndex = 8;
            this.playerСount.Text = "Сount  player(s):";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(42, 193);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(34, 13);
            this.type.TabIndex = 9;
            this.type.Text = "Type:";
            // 
            // registrationEndDate
            // 
            this.registrationEndDate.AutoSize = true;
            this.registrationEndDate.Location = new System.Drawing.Point(42, 261);
            this.registrationEndDate.Name = "registrationEndDate";
            this.registrationEndDate.Size = new System.Drawing.Size(111, 13);
            this.registrationEndDate.TabIndex = 11;
            this.registrationEndDate.Text = "Registration end date:";
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Location = new System.Drawing.Point(42, 227);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(36, 13);
            this.level.TabIndex = 10;
            this.level.Text = "Level:";
            // 
            // tournamentStartDate
            // 
            this.tournamentStartDate.AutoSize = true;
            this.tournamentStartDate.Location = new System.Drawing.Point(42, 297);
            this.tournamentStartDate.Name = "tournamentStartDate";
            this.tournamentStartDate.Size = new System.Drawing.Size(114, 13);
            this.tournamentStartDate.TabIndex = 13;
            this.tournamentStartDate.Text = "Tournament start date:";
            // 
            // GeneratePlace
            // 
            this.GeneratePlace.Location = new System.Drawing.Point(294, 147);
            this.GeneratePlace.Name = "GeneratePlace";
            this.GeneratePlace.Size = new System.Drawing.Size(99, 25);
            this.GeneratePlace.TabIndex = 14;
            this.GeneratePlace.Text = "Generate place";
            this.GeneratePlace.UseVisualStyleBackColor = true;
            
            // 
            // cancelTournament
            // 
            this.cancelTournament.Location = new System.Drawing.Point(318, 438);
            this.cancelTournament.Name = "cancelTournament";
            this.cancelTournament.Size = new System.Drawing.Size(75, 25);
            this.cancelTournament.TabIndex = 15;
            this.cancelTournament.Text = "Cancel";
            this.cancelTournament.UseVisualStyleBackColor = true;
            this.cancelTournament.Click += new System.EventHandler(this.cancelTournament_Click);
            // 
            // saveTournament
            // 
            this.saveTournament.Location = new System.Drawing.Point(237, 438);
            this.saveTournament.Name = "saveTournament";
            this.saveTournament.Size = new System.Drawing.Size(75, 25);
            this.saveTournament.TabIndex = 16;
            this.saveTournament.Text = "Save";
            this.saveTournament.UseVisualStyleBackColor = true;
            this.saveTournament.Click += new System.EventHandler(this.saveTournament_Click);
            // 
            // place
            // 
            this.place.AutoSize = true;
            this.place.Location = new System.Drawing.Point(42, 159);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(37, 13);
            this.place.TabIndex = 18;
            this.place.Text = "Place:";
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(165, 152);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlace.TabIndex = 17;
            this.textBoxPlace.TextChanged += new System.EventHandler(this.textBoxPlace_TextChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(165, 190);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(100, 21);
            this.comboBoxType.TabIndex = 19;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Location = new System.Drawing.Point(165, 219);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(100, 21);
            this.comboBoxLevel.TabIndex = 20;
            this.comboBoxLevel.SelectedIndexChanged += new System.EventHandler(this.comboBoxLevel_SelectedIndexChanged);
            // 
            // dateTimeEndRegistration
            // 
            this.dateTimeEndRegistration.Location = new System.Drawing.Point(165, 255);
            this.dateTimeEndRegistration.Name = "dateTimeEndRegistration";
            this.dateTimeEndRegistration.Size = new System.Drawing.Size(112, 20);
            this.dateTimeEndRegistration.TabIndex = 21;
            this.dateTimeEndRegistration.ValueChanged += new System.EventHandler(this.dateTimeEndRegistration_ValueChanged);
            // 
            // dateTimeStartTourn
            // 
            this.dateTimeStartTourn.Location = new System.Drawing.Point(165, 291);
            this.dateTimeStartTourn.Name = "dateTimeStartTourn";
            this.dateTimeStartTourn.Size = new System.Drawing.Size(112, 20);
            this.dateTimeStartTourn.TabIndex = 22;
            this.dateTimeStartTourn.ValueChanged += new System.EventHandler(this.dateTimeStartTourn_ValueChanged);
            // 
            // discription
            // 
            this.discription.AutoSize = true;
            this.discription.Location = new System.Drawing.Point(42, 88);
            this.discription.Name = "discription";
            this.discription.Size = new System.Drawing.Size(63, 13);
            this.discription.TabIndex = 24;
            this.discription.Text = "Description:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GenerateName
            // 
            this.GenerateName.Location = new System.Drawing.Point(294, 50);
            this.GenerateName.Name = "GenerateName";
            this.GenerateName.Size = new System.Drawing.Size(99, 25);
            this.GenerateName.TabIndex = 25;
            this.GenerateName.Text = "Generate name";
            this.GenerateName.UseVisualStyleBackColor = true;
            this.GenerateName.Click += new System.EventHandler(this.GenerateName_Click);
            // 
            // CreateTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 491);
            this.Controls.Add(this.GenerateName);
            this.Controls.Add(this.discription);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimeStartTourn);
            this.Controls.Add(this.dateTimeEndRegistration);
            this.Controls.Add(this.comboBoxLevel);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.place);
            this.Controls.Add(this.textBoxPlace);
            this.Controls.Add(this.saveTournament);
            this.Controls.Add(this.cancelTournament);
            this.Controls.Add(this.GeneratePlace);
            this.Controls.Add(this.tournamentStartDate);
            this.Controls.Add(this.registrationEndDate);
            this.Controls.Add(this.level);
            this.Controls.Add(this.type);
            this.Controls.Add(this.playerСount);
            this.Controls.Add(this.nemeTournament);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxCounPlayer);
            this.Name = "CreateTournament";
            this.Text = "Create tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCounPlayer;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label nemeTournament;
        private System.Windows.Forms.Label playerСount;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label registrationEndDate;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.Label tournamentStartDate;
        private System.Windows.Forms.Button GeneratePlace;
        private System.Windows.Forms.Button cancelTournament;
        private System.Windows.Forms.Button saveTournament;
        private System.Windows.Forms.Label place;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.DateTimePicker dateTimeEndRegistration;
        private System.Windows.Forms.DateTimePicker dateTimeStartTourn;
        private System.Windows.Forms.Label discription;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button GenerateName;
    }
}