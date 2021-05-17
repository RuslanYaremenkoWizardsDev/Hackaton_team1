
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
            this.textBoxCountPlayers = new System.Windows.Forms.TextBox();
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
            this.Place = new System.Windows.Forms.Label();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.dateTimeEndRegistration = new System.Windows.Forms.DateTimePicker();
            this.dateTimeStartTournament = new System.Windows.Forms.DateTimePicker();
            this.discription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.GenerateName = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.labelErrorPlace = new System.Windows.Forms.Label();
            this.labelErrorDescription = new System.Windows.Forms.Label();
            this.labelErrorCount = new System.Windows.Forms.Label();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelErrorDateStart = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxScenario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxCountPlayers
            // 
            this.textBoxCountPlayers.Location = new System.Drawing.Point(168, 159);
            this.textBoxCountPlayers.Name = "textBoxCountPlayers";
            this.textBoxCountPlayers.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountPlayers.TabIndex = 1;
            this.textBoxCountPlayers.TextChanged += new System.EventHandler(this.textBoxCounPlayer_TextChanged);
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
            this.playerСount.Location = new System.Drawing.Point(45, 166);
            this.playerСount.Name = "playerСount";
            this.playerСount.Size = new System.Drawing.Size(83, 13);
            this.playerСount.TabIndex = 8;
            this.playerСount.Text = "Сount  player(s):";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(45, 277);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(34, 13);
            this.type.TabIndex = 9;
            this.type.Text = "Type:";
            // 
            // registrationEndDate
            // 
            this.registrationEndDate.AutoSize = true;
            this.registrationEndDate.Location = new System.Drawing.Point(45, 347);
            this.registrationEndDate.Name = "registrationEndDate";
            this.registrationEndDate.Size = new System.Drawing.Size(111, 13);
            this.registrationEndDate.TabIndex = 11;
            this.registrationEndDate.Text = "Registration end date:";
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Location = new System.Drawing.Point(45, 311);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(36, 13);
            this.level.TabIndex = 10;
            this.level.Text = "Level:";
            // 
            // tournamentStartDate
            // 
            this.tournamentStartDate.AutoSize = true;
            this.tournamentStartDate.Location = new System.Drawing.Point(45, 393);
            this.tournamentStartDate.Name = "tournamentStartDate";
            this.tournamentStartDate.Size = new System.Drawing.Size(114, 13);
            this.tournamentStartDate.TabIndex = 13;
            this.tournamentStartDate.Text = "Tournament start date:";
            // 
            // GeneratePlace
            // 
            this.GeneratePlace.Location = new System.Drawing.Point(300, 211);
            this.GeneratePlace.Name = "GeneratePlace";
            this.GeneratePlace.Size = new System.Drawing.Size(99, 25);
            this.GeneratePlace.TabIndex = 14;
            this.GeneratePlace.Text = "Generate place";
            this.GeneratePlace.UseVisualStyleBackColor = true;
            // 
            // cancelTournament
            // 
            this.cancelTournament.Location = new System.Drawing.Point(318, 498);
            this.cancelTournament.Name = "cancelTournament";
            this.cancelTournament.Size = new System.Drawing.Size(75, 25);
            this.cancelTournament.TabIndex = 15;
            this.cancelTournament.Text = "Cancel";
            this.cancelTournament.UseVisualStyleBackColor = true;
            this.cancelTournament.Click += new System.EventHandler(this.cancelTournament_Click);
            // 
            // saveTournament
            // 
            this.saveTournament.Location = new System.Drawing.Point(237, 498);
            this.saveTournament.Name = "saveTournament";
            this.saveTournament.Size = new System.Drawing.Size(75, 25);
            this.saveTournament.TabIndex = 16;
            this.saveTournament.Text = "Save";
            this.saveTournament.UseVisualStyleBackColor = true;
            this.saveTournament.Click += new System.EventHandler(this.saveTournament_Click);
            // 
            // Place
            // 
            this.Place.Location = new System.Drawing.Point(0, 0);
            this.Place.Name = "Place";
            this.Place.Size = new System.Drawing.Size(100, 23);
            this.Place.TabIndex = 30;
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(168, 214);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlace.TabIndex = 17;
            this.textBoxPlace.TextChanged += new System.EventHandler(this.textBoxPlace_TextChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Cup"});
            this.comboBoxType.Location = new System.Drawing.Point(168, 274);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(100, 21);
            this.comboBoxType.TabIndex = 19;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Items.AddRange(new object[] {
            "Begginer",
            "Middle",
            "Advanced"});
            this.comboBoxLevel.Location = new System.Drawing.Point(168, 303);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(100, 21);
            this.comboBoxLevel.TabIndex = 20;
            this.comboBoxLevel.SelectedIndexChanged += new System.EventHandler(this.comboBoxLevel_SelectedIndexChanged);
            // 
            // dateTimeEndRegistration
            // 
            this.dateTimeEndRegistration.Location = new System.Drawing.Point(168, 341);
            this.dateTimeEndRegistration.Name = "dateTimeEndRegistration";
            this.dateTimeEndRegistration.Size = new System.Drawing.Size(178, 20);
            this.dateTimeEndRegistration.TabIndex = 21;
            this.dateTimeEndRegistration.ValueChanged += new System.EventHandler(this.dateTimeEndRegistration_ValueChanged);
            // 
            // dateTimeStartTournament
            // 
            this.dateTimeStartTournament.Location = new System.Drawing.Point(168, 387);
            this.dateTimeStartTournament.Name = "dateTimeStartTournament";
            this.dateTimeStartTournament.Size = new System.Drawing.Size(178, 20);
            this.dateTimeStartTournament.TabIndex = 22;
            this.dateTimeStartTournament.ValueChanged += new System.EventHandler(this.dateTimeStartTourn_ValueChanged);
            // 
            // discription
            // 
            this.discription.AutoSize = true;
            this.discription.Location = new System.Drawing.Point(45, 105);
            this.discription.Name = "discription";
            this.discription.Size = new System.Drawing.Size(63, 13);
            this.discription.TabIndex = 24;
            this.discription.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(168, 102);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescription.TabIndex = 23;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
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
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(165, 73);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 26;
            // 
            // labelErrorPlace
            // 
            this.labelErrorPlace.AutoSize = true;
            this.labelErrorPlace.Location = new System.Drawing.Point(168, 239);
            this.labelErrorPlace.Name = "labelErrorPlace";
            this.labelErrorPlace.Size = new System.Drawing.Size(0, 13);
            this.labelErrorPlace.TabIndex = 27;
            // 
            // labelErrorDescription
            // 
            this.labelErrorDescription.AutoSize = true;
            this.labelErrorDescription.Location = new System.Drawing.Point(165, 125);
            this.labelErrorDescription.Name = "labelErrorDescription";
            this.labelErrorDescription.Size = new System.Drawing.Size(0, 13);
            this.labelErrorDescription.TabIndex = 28;
            // 
            // labelErrorCount
            // 
            this.labelErrorCount.AutoSize = true;
            this.labelErrorCount.Location = new System.Drawing.Point(165, 182);
            this.labelErrorCount.Name = "labelErrorCount";
            this.labelErrorCount.Size = new System.Drawing.Size(0, 13);
            this.labelErrorCount.TabIndex = 29;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(48, 223);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(37, 13);
            this.labelPlace.TabIndex = 31;
            this.labelPlace.Text = "Place:";
            // 
            // labelErrorDateStart
            // 
            this.labelErrorDateStart.AutoSize = true;
            this.labelErrorDateStart.Location = new System.Drawing.Point(168, 419);
            this.labelErrorDateStart.Name = "labelErrorDateStart";
            this.labelErrorDateStart.Size = new System.Drawing.Size(0, 13);
            this.labelErrorDateStart.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tournament scenario:";
            // 
            // comboBoxScenario
            // 
            this.comboBoxScenario.FormattingEnabled = true;
            this.comboBoxScenario.Items.AddRange(new object[] {
            "OneMatchConfrontation",
            "TwoMatchConfrontation",
            "ToThreeWins"});
            this.comboBoxScenario.Location = new System.Drawing.Point(165, 419);
            this.comboBoxScenario.Name = "comboBoxScenario";
            this.comboBoxScenario.Size = new System.Drawing.Size(100, 21);
            this.comboBoxScenario.TabIndex = 36;
            // 
            // CreateTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 535);
            this.Controls.Add(this.comboBoxScenario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelErrorDateStart);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.labelErrorCount);
            this.Controls.Add(this.labelErrorDescription);
            this.Controls.Add(this.labelErrorPlace);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.GenerateName);
            this.Controls.Add(this.discription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.dateTimeStartTournament);
            this.Controls.Add(this.dateTimeEndRegistration);
            this.Controls.Add(this.comboBoxLevel);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.Place);
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
            this.Controls.Add(this.textBoxCountPlayers);
            this.Name = "CreateTournament";
            this.Text = "Create tournament";
            this.Load += new System.EventHandler(this.CreateTournament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCountPlayers;
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
        private System.Windows.Forms.Label Place;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.DateTimePicker dateTimeEndRegistration;
        private System.Windows.Forms.DateTimePicker dateTimeStartTournament;
        private System.Windows.Forms.Label discription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button GenerateName;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelErrorPlace;
        private System.Windows.Forms.Label labelErrorDescription;
        private System.Windows.Forms.Label labelErrorCount;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelErrorDateStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxScenario;
    }
}