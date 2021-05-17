
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
            this.textBoxCountPlayer = new System.Windows.Forms.TextBox();
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
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.dateTimeEndRegistration = new System.Windows.Forms.DateTimePicker();
            this.dateTimeStartTourn = new System.Windows.Forms.DateTimePicker();
            this.discription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.GenerateName = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.labelErrorPlace = new System.Windows.Forms.Label();
            this.labelErrorDescription = new System.Windows.Forms.Label();
            this.labelErrorCount = new System.Windows.Forms.Label();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelErrorDateStart = new System.Windows.Forms.Label();
            this.addParticipant = new System.Windows.Forms.Button();
            this.comboBoxScenario = new System.Windows.Forms.ComboBox();
            this.labelTournSc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCountPlayer
            // 
            this.textBoxCountPlayer.Location = new System.Drawing.Point(258, 136);
            this.textBoxCountPlayer.Name = "textBoxCountPlayer";
            this.textBoxCountPlayer.Size = new System.Drawing.Size(200, 20);
            this.textBoxCountPlayer.TabIndex = 1;
            this.textBoxCountPlayer.TextChanged += new System.EventHandler(this.textBoxCountPlayer_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(258, 45);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 20);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // nemeTournament
            // 
            this.nemeTournament.AutoSize = true;
            this.nemeTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nemeTournament.ForeColor = System.Drawing.Color.Gold;
            this.nemeTournament.Location = new System.Drawing.Point(48, 43);
            this.nemeTournament.Name = "nemeTournament";
            this.nemeTournament.Size = new System.Drawing.Size(49, 19);
            this.nemeTournament.TabIndex = 7;
            this.nemeTournament.Text = "Name:";
            // 
            // playerСount
            // 
            this.playerСount.AutoSize = true;
            this.playerСount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerСount.ForeColor = System.Drawing.Color.Gold;
            this.playerСount.Location = new System.Drawing.Point(49, 136);
            this.playerСount.Name = "playerСount";
            this.playerСount.Size = new System.Drawing.Size(112, 19);
            this.playerСount.TabIndex = 8;
            this.playerСount.Text = "Сount  player(s):";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Segoe UI Semibold", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type.ForeColor = System.Drawing.Color.Gold;
            this.type.Location = new System.Drawing.Point(54, 224);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(42, 19);
            this.type.TabIndex = 9;
            this.type.Text = "Type:";
            // 
            // registrationEndDate
            // 
            this.registrationEndDate.AutoSize = true;
            this.registrationEndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationEndDate.ForeColor = System.Drawing.Color.Gold;
            this.registrationEndDate.Location = new System.Drawing.Point(53, 314);
            this.registrationEndDate.Name = "registrationEndDate";
            this.registrationEndDate.Size = new System.Drawing.Size(146, 19);
            this.registrationEndDate.TabIndex = 11;
            this.registrationEndDate.Text = "Registration end date:";
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Font = new System.Drawing.Font("Segoe UI Semibold", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.level.ForeColor = System.Drawing.Color.Gold;
            this.level.Location = new System.Drawing.Point(54, 270);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(44, 19);
            this.level.TabIndex = 10;
            this.level.Text = "Level:";
            // 
            // tournamentStartDate
            // 
            this.tournamentStartDate.AutoSize = true;
            this.tournamentStartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tournamentStartDate.ForeColor = System.Drawing.Color.Gold;
            this.tournamentStartDate.Location = new System.Drawing.Point(54, 359);
            this.tournamentStartDate.Name = "tournamentStartDate";
            this.tournamentStartDate.Size = new System.Drawing.Size(151, 19);
            this.tournamentStartDate.TabIndex = 13;
            this.tournamentStartDate.Text = "Tournament start date:";
            // 
            // GeneratePlace
            // 
            this.GeneratePlace.BackColor = System.Drawing.Color.Gold;
            this.GeneratePlace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GeneratePlace.Font = new System.Drawing.Font("Segoe UI Semibold", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GeneratePlace.Location = new System.Drawing.Point(474, 177);
            this.GeneratePlace.Name = "GeneratePlace";
            this.GeneratePlace.Size = new System.Drawing.Size(99, 25);
            this.GeneratePlace.TabIndex = 14;
            this.GeneratePlace.Text = "Generate place";
            this.GeneratePlace.UseVisualStyleBackColor = false;
            // 
            // cancelTournament
            // 
            this.cancelTournament.BackColor = System.Drawing.Color.Gold;
            this.cancelTournament.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelTournament.Location = new System.Drawing.Point(375, 494);
            this.cancelTournament.Name = "cancelTournament";
            this.cancelTournament.Size = new System.Drawing.Size(125, 45);
            this.cancelTournament.TabIndex = 15;
            this.cancelTournament.Text = "Cancel";
            this.cancelTournament.UseVisualStyleBackColor = false;
            this.cancelTournament.Click += new System.EventHandler(this.cancelTournament_Click);
            // 
            // saveTournament
            // 
            this.saveTournament.BackColor = System.Drawing.Color.Gold;
            this.saveTournament.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveTournament.Location = new System.Drawing.Point(236, 494);
            this.saveTournament.Name = "saveTournament";
            this.saveTournament.Size = new System.Drawing.Size(125, 45);
            this.saveTournament.TabIndex = 16;
            this.saveTournament.Text = "Save";
            this.saveTournament.UseVisualStyleBackColor = false;
            this.saveTournament.Click += new System.EventHandler(this.saveTournament_Click);
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(258, 180);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(200, 20);
            this.textBoxPlace.TabIndex = 17;
            this.textBoxPlace.TextChanged += new System.EventHandler(this.textBoxPlace_TextChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Cup"});
            this.comboBoxType.Location = new System.Drawing.Point(258, 224);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(200, 21);
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
            this.comboBoxLevel.Location = new System.Drawing.Point(258, 270);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(200, 21);
            this.comboBoxLevel.TabIndex = 20;
            this.comboBoxLevel.SelectedIndexChanged += new System.EventHandler(this.comboBoxLevel_SelectedIndexChanged);
            // 
            // dateTimeEndRegistration
            // 
            this.dateTimeEndRegistration.Location = new System.Drawing.Point(258, 314);
            this.dateTimeEndRegistration.Name = "dateTimeEndRegistration";
            this.dateTimeEndRegistration.Size = new System.Drawing.Size(200, 20);
            this.dateTimeEndRegistration.TabIndex = 21;
            this.dateTimeEndRegistration.ValueChanged += new System.EventHandler(this.dateTimeEndRegistration_ValueChanged);
            // 
            // dateTimeStartTourn
            // 
            this.dateTimeStartTourn.Location = new System.Drawing.Point(258, 360);
            this.dateTimeStartTourn.Name = "dateTimeStartTourn";
            this.dateTimeStartTourn.Size = new System.Drawing.Size(200, 20);
            this.dateTimeStartTourn.TabIndex = 22;
            this.dateTimeStartTourn.ValueChanged += new System.EventHandler(this.dateTimeStartTourn_ValueChanged);
            // 
            // discription
            // 
            this.discription.AutoSize = true;
            this.discription.Font = new System.Drawing.Font("Segoe UI Semibold", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discription.ForeColor = System.Drawing.Color.Gold;
            this.discription.Location = new System.Drawing.Point(49, 90);
            this.discription.Name = "discription";
            this.discription.Size = new System.Drawing.Size(84, 19);
            this.discription.TabIndex = 24;
            this.discription.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(258, 91);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(200, 20);
            this.textBoxDescription.TabIndex = 23;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // GenerateName
            // 
            this.GenerateName.BackColor = System.Drawing.Color.Gold;
            this.GenerateName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GenerateName.Font = new System.Drawing.Font("Segoe UI Semibold", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GenerateName.Location = new System.Drawing.Point(474, 42);
            this.GenerateName.Name = "GenerateName";
            this.GenerateName.Size = new System.Drawing.Size(99, 25);
            this.GenerateName.TabIndex = 25;
            this.GenerateName.Text = "Generate name";
            this.GenerateName.UseVisualStyleBackColor = false;
            this.GenerateName.Click += new System.EventHandler(this.GenerateName_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Gold;
            this.labelError.Location = new System.Drawing.Point(263, 73);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 26;
            this.labelError.Click += new System.EventHandler(this.labelError_Click);
            // 
            // labelErrorPlace
            // 
            this.labelErrorPlace.AutoSize = true;
            this.labelErrorPlace.ForeColor = System.Drawing.Color.Gold;
            this.labelErrorPlace.Location = new System.Drawing.Point(263, 208);
            this.labelErrorPlace.Name = "labelErrorPlace";
            this.labelErrorPlace.Size = new System.Drawing.Size(0, 13);
            this.labelErrorPlace.TabIndex = 27;
            // 
            // labelErrorDescription
            // 
            this.labelErrorDescription.AutoSize = true;
            this.labelErrorDescription.ForeColor = System.Drawing.Color.Gold;
            this.labelErrorDescription.Location = new System.Drawing.Point(263, 118);
            this.labelErrorDescription.Name = "labelErrorDescription";
            this.labelErrorDescription.Size = new System.Drawing.Size(0, 13);
            this.labelErrorDescription.TabIndex = 28;
            this.labelErrorDescription.Click += new System.EventHandler(this.labelErrorDescription_Click);
            // 
            // labelErrorCount
            // 
            this.labelErrorCount.AutoSize = true;
            this.labelErrorCount.ForeColor = System.Drawing.Color.Gold;
            this.labelErrorCount.Location = new System.Drawing.Point(263, 164);
            this.labelErrorCount.Name = "labelErrorCount";
            this.labelErrorCount.Size = new System.Drawing.Size(0, 13);
            this.labelErrorCount.TabIndex = 29;
            this.labelErrorCount.Click += new System.EventHandler(this.labelErrorCount_Click);
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Font = new System.Drawing.Font("Segoe UI Semibold", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlace.ForeColor = System.Drawing.Color.Gold;
            this.labelPlace.Location = new System.Drawing.Point(53, 180);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(45, 19);
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
            // addParticipant
            // 
            this.addParticipant.BackColor = System.Drawing.Color.Gold;
            this.addParticipant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addParticipant.Font = new System.Drawing.Font("Segoe UI Semibold", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addParticipant.Location = new System.Drawing.Point(100, 494);
            this.addParticipant.Name = "addParticipant";
            this.addParticipant.Size = new System.Drawing.Size(125, 45);
            this.addParticipant.TabIndex = 33;
            this.addParticipant.Text = "Add ";
            this.addParticipant.UseVisualStyleBackColor = false;
            this.addParticipant.Click += new System.EventHandler(this.addParticipant_Click);
            // 
            // comboBoxScenario
            // 
            this.comboBoxScenario.FormattingEnabled = true;
            this.comboBoxScenario.Items.AddRange(new object[] {
            "OneMatchConfrontation",
            "TwoMatchConfrontation",
            "TwoThreeWins"});
            this.comboBoxScenario.Location = new System.Drawing.Point(258, 405);
            this.comboBoxScenario.Name = "comboBoxScenario";
            this.comboBoxScenario.Size = new System.Drawing.Size(200, 21);
            this.comboBoxScenario.TabIndex = 35;
            this.comboBoxScenario.SelectedIndexChanged += new System.EventHandler(this.comboBoxScenario_SelectedIndexChanged);
            // 
            // labelTournSc
            // 
            this.labelTournSc.AutoSize = true;
            this.labelTournSc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTournSc.ForeColor = System.Drawing.Color.Gold;
            this.labelTournSc.Location = new System.Drawing.Point(54, 405);
            this.labelTournSc.Name = "labelTournSc";
            this.labelTournSc.Size = new System.Drawing.Size(144, 19);
            this.labelTournSc.TabIndex = 34;
            this.labelTournSc.Text = "Tournament scenario:";
            // 
            // CreateTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(589, 598);
            this.Controls.Add(this.comboBoxScenario);
            this.Controls.Add(this.labelTournSc);
            this.Controls.Add(this.addParticipant);
            this.Controls.Add(this.labelErrorDateStart);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.labelErrorCount);
            this.Controls.Add(this.labelErrorDescription);
            this.Controls.Add(this.labelErrorPlace);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.GenerateName);
            this.Controls.Add(this.discription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.dateTimeStartTourn);
            this.Controls.Add(this.dateTimeEndRegistration);
            this.Controls.Add(this.comboBoxLevel);
            this.Controls.Add(this.comboBoxType);
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
            this.Controls.Add(this.textBoxCountPlayer);
            this.Name = "CreateTournament";
            this.Text = "Create tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCountPlayer;
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
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.DateTimePicker dateTimeEndRegistration;
        private System.Windows.Forms.DateTimePicker dateTimeStartTourn;
        private System.Windows.Forms.Label discription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button GenerateName;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelErrorPlace;
        private System.Windows.Forms.Label labelErrorDescription;
        private System.Windows.Forms.Label labelErrorCount;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelErrorDateStart;
        private System.Windows.Forms.Button addParticipant;
        private System.Windows.Forms.ComboBox comboBoxScenario;
        private System.Windows.Forms.Label labelTournSc;
    }
}