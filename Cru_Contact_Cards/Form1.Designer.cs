namespace Cru_Contact_Cards
{
    partial class CruContactCard
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
            this.btnDone = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblResidence = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.grpAffiliation = new System.Windows.Forms.GroupBox();
            this.tboOther = new System.Windows.Forms.TextBox();
            this.chkOther = new System.Windows.Forms.CheckBox();
            this.chkUndecided = new System.Windows.Forms.CheckBox();
            this.chkAgnostic = new System.Windows.Forms.CheckBox();
            this.chkAtheist = new System.Windows.Forms.CheckBox();
            this.chkTaoist = new System.Windows.Forms.CheckBox();
            this.chkHindu = new System.Windows.Forms.CheckBox();
            this.chkBuddhist = new System.Windows.Forms.CheckBox();
            this.chkJewish = new System.Windows.Forms.CheckBox();
            this.chkMuslim = new System.Windows.Forms.CheckBox();
            this.chkChristian = new System.Windows.Forms.CheckBox();
            this.grpRelationship = new System.Windows.Forms.GroupBox();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl0 = new System.Windows.Forms.Label();
            this.trkRelationship = new System.Windows.Forms.TrackBar();
            this.grpConvo = new System.Windows.Forms.GroupBox();
            this.rdoNo = new System.Windows.Forms.RadioButton();
            this.rdoMaybe = new System.Windows.Forms.RadioButton();
            this.rdoYes = new System.Windows.Forms.RadioButton();
            this.grpCruInfo = new System.Windows.Forms.GroupBox();
            this.rdoCruNo = new System.Windows.Forms.RadioButton();
            this.rdoCruMaybe = new System.Windows.Forms.RadioButton();
            this.rdoCruYes = new System.Windows.Forms.RadioButton();
            this.tboName = new System.Windows.Forms.TextBox();
            this.cboResidence = new System.Windows.Forms.ComboBox();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.tboRoom = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tboRaceOther = new System.Windows.Forms.TextBox();
            this.chkRaceOther = new System.Windows.Forms.CheckBox();
            this.chkAsian = new System.Windows.Forms.CheckBox();
            this.chkNative = new System.Windows.Forms.CheckBox();
            this.chkHispanic = new System.Windows.Forms.CheckBox();
            this.chkBlack = new System.Windows.Forms.CheckBox();
            this.chkWhite = new System.Windows.Forms.CheckBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.grpAffiliation.SuspendLayout();
            this.grpRelationship.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkRelationship)).BeginInit();
            this.grpConvo.SuspendLayout();
            this.grpCruInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(530, 464);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 0;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(157, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(268, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Cru Contact Card";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // lblResidence
            // 
            this.lblResidence.AutoSize = true;
            this.lblResidence.Location = new System.Drawing.Point(379, 56);
            this.lblResidence.Name = "lblResidence";
            this.lblResidence.Size = new System.Drawing.Size(61, 13);
            this.lblResidence.TabIndex = 3;
            this.lblResidence.Text = "Residence:";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(11, 83);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(39, 13);
            this.lblGrade.TabIndex = 4;
            this.lblGrade.Text = "Grade:";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(402, 83);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(38, 13);
            this.lblRoom.TabIndex = 5;
            this.lblRoom.Text = "Room:";
            // 
            // grpAffiliation
            // 
            this.grpAffiliation.Controls.Add(this.tboOther);
            this.grpAffiliation.Controls.Add(this.chkOther);
            this.grpAffiliation.Controls.Add(this.chkUndecided);
            this.grpAffiliation.Controls.Add(this.chkAgnostic);
            this.grpAffiliation.Controls.Add(this.chkAtheist);
            this.grpAffiliation.Controls.Add(this.chkTaoist);
            this.grpAffiliation.Controls.Add(this.chkHindu);
            this.grpAffiliation.Controls.Add(this.chkBuddhist);
            this.grpAffiliation.Controls.Add(this.chkJewish);
            this.grpAffiliation.Controls.Add(this.chkMuslim);
            this.grpAffiliation.Controls.Add(this.chkChristian);
            this.grpAffiliation.Location = new System.Drawing.Point(15, 111);
            this.grpAffiliation.Name = "grpAffiliation";
            this.grpAffiliation.Size = new System.Drawing.Size(313, 156);
            this.grpAffiliation.TabIndex = 6;
            this.grpAffiliation.TabStop = false;
            this.grpAffiliation.Text = "Would you consider yourself...";
            // 
            // tboOther
            // 
            this.tboOther.Enabled = false;
            this.tboOther.Location = new System.Drawing.Point(193, 40);
            this.tboOther.Name = "tboOther";
            this.tboOther.Size = new System.Drawing.Size(100, 20);
            this.tboOther.TabIndex = 15;
            // 
            // chkOther
            // 
            this.chkOther.AutoSize = true;
            this.chkOther.Location = new System.Drawing.Point(138, 42);
            this.chkOther.Name = "chkOther";
            this.chkOther.Size = new System.Drawing.Size(55, 17);
            this.chkOther.TabIndex = 14;
            this.chkOther.Text = "Other:";
            this.chkOther.UseVisualStyleBackColor = true;
            this.chkOther.CheckedChanged += new System.EventHandler(this.chkOther_CheckedChanged);
            // 
            // chkUndecided
            // 
            this.chkUndecided.AutoSize = true;
            this.chkUndecided.Location = new System.Drawing.Point(138, 19);
            this.chkUndecided.Name = "chkUndecided";
            this.chkUndecided.Size = new System.Drawing.Size(78, 17);
            this.chkUndecided.TabIndex = 14;
            this.chkUndecided.Text = "Undecided";
            this.chkUndecided.UseVisualStyleBackColor = true;
            // 
            // chkAgnostic
            // 
            this.chkAgnostic.AutoSize = true;
            this.chkAgnostic.Location = new System.Drawing.Point(78, 88);
            this.chkAgnostic.Name = "chkAgnostic";
            this.chkAgnostic.Size = new System.Drawing.Size(67, 17);
            this.chkAgnostic.TabIndex = 14;
            this.chkAgnostic.Text = "Agnostic";
            this.chkAgnostic.UseVisualStyleBackColor = true;
            // 
            // chkAtheist
            // 
            this.chkAtheist.AutoSize = true;
            this.chkAtheist.Location = new System.Drawing.Point(78, 65);
            this.chkAtheist.Name = "chkAtheist";
            this.chkAtheist.Size = new System.Drawing.Size(58, 17);
            this.chkAtheist.TabIndex = 14;
            this.chkAtheist.Text = "Atheist";
            this.chkAtheist.UseVisualStyleBackColor = true;
            // 
            // chkTaoist
            // 
            this.chkTaoist.AutoSize = true;
            this.chkTaoist.Location = new System.Drawing.Point(78, 42);
            this.chkTaoist.Name = "chkTaoist";
            this.chkTaoist.Size = new System.Drawing.Size(55, 17);
            this.chkTaoist.TabIndex = 5;
            this.chkTaoist.Text = "Taoist";
            this.chkTaoist.UseVisualStyleBackColor = true;
            // 
            // chkHindu
            // 
            this.chkHindu.AutoSize = true;
            this.chkHindu.Location = new System.Drawing.Point(78, 19);
            this.chkHindu.Name = "chkHindu";
            this.chkHindu.Size = new System.Drawing.Size(54, 17);
            this.chkHindu.TabIndex = 4;
            this.chkHindu.Text = "Hindu";
            this.chkHindu.UseVisualStyleBackColor = true;
            // 
            // chkBuddhist
            // 
            this.chkBuddhist.AutoSize = true;
            this.chkBuddhist.Location = new System.Drawing.Point(6, 88);
            this.chkBuddhist.Name = "chkBuddhist";
            this.chkBuddhist.Size = new System.Drawing.Size(67, 17);
            this.chkBuddhist.TabIndex = 3;
            this.chkBuddhist.Text = "Buddhist";
            this.chkBuddhist.UseVisualStyleBackColor = true;
            // 
            // chkJewish
            // 
            this.chkJewish.AutoSize = true;
            this.chkJewish.Location = new System.Drawing.Point(6, 65);
            this.chkJewish.Name = "chkJewish";
            this.chkJewish.Size = new System.Drawing.Size(58, 17);
            this.chkJewish.TabIndex = 2;
            this.chkJewish.Text = "Jewish";
            this.chkJewish.UseVisualStyleBackColor = true;
            // 
            // chkMuslim
            // 
            this.chkMuslim.AutoSize = true;
            this.chkMuslim.Location = new System.Drawing.Point(6, 42);
            this.chkMuslim.Name = "chkMuslim";
            this.chkMuslim.Size = new System.Drawing.Size(58, 17);
            this.chkMuslim.TabIndex = 1;
            this.chkMuslim.Text = "Muslim";
            this.chkMuslim.UseVisualStyleBackColor = true;
            // 
            // chkChristian
            // 
            this.chkChristian.AutoSize = true;
            this.chkChristian.Location = new System.Drawing.Point(6, 19);
            this.chkChristian.Name = "chkChristian";
            this.chkChristian.Size = new System.Drawing.Size(66, 17);
            this.chkChristian.TabIndex = 0;
            this.chkChristian.Text = "Christian";
            this.chkChristian.UseVisualStyleBackColor = true;
            // 
            // grpRelationship
            // 
            this.grpRelationship.Controls.Add(this.lbl10);
            this.grpRelationship.Controls.Add(this.lbl0);
            this.grpRelationship.Controls.Add(this.trkRelationship);
            this.grpRelationship.Location = new System.Drawing.Point(15, 273);
            this.grpRelationship.Name = "grpRelationship";
            this.grpRelationship.Size = new System.Drawing.Size(590, 81);
            this.grpRelationship.TabIndex = 7;
            this.grpRelationship.TabStop = false;
            this.grpRelationship.Text = "On a scale of 0-10, how interested are you in a relationship with God?";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Location = new System.Drawing.Point(565, 51);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(19, 13);
            this.lbl10.TabIndex = 2;
            this.lbl10.Text = "10";
            // 
            // lbl0
            // 
            this.lbl0.AutoSize = true;
            this.lbl0.Location = new System.Drawing.Point(6, 51);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(13, 13);
            this.lbl0.TabIndex = 1;
            this.lbl0.Text = "0";
            // 
            // trkRelationship
            // 
            this.trkRelationship.Location = new System.Drawing.Point(6, 19);
            this.trkRelationship.Name = "trkRelationship";
            this.trkRelationship.Size = new System.Drawing.Size(578, 45);
            this.trkRelationship.TabIndex = 0;
            // 
            // grpConvo
            // 
            this.grpConvo.Controls.Add(this.rdoNo);
            this.grpConvo.Controls.Add(this.rdoMaybe);
            this.grpConvo.Controls.Add(this.rdoYes);
            this.grpConvo.Location = new System.Drawing.Point(300, 360);
            this.grpConvo.Name = "grpConvo";
            this.grpConvo.Size = new System.Drawing.Size(305, 98);
            this.grpConvo.TabIndex = 8;
            this.grpConvo.TabStop = false;
            this.grpConvo.Text = "Would you be interested in a spiritual follow-up conversation?";
            // 
            // rdoNo
            // 
            this.rdoNo.AutoSize = true;
            this.rdoNo.Location = new System.Drawing.Point(101, 65);
            this.rdoNo.Name = "rdoNo";
            this.rdoNo.Size = new System.Drawing.Size(39, 17);
            this.rdoNo.TabIndex = 2;
            this.rdoNo.TabStop = true;
            this.rdoNo.Text = "No";
            this.rdoNo.UseVisualStyleBackColor = true;
            // 
            // rdoMaybe
            // 
            this.rdoMaybe.AutoSize = true;
            this.rdoMaybe.Location = new System.Drawing.Point(101, 42);
            this.rdoMaybe.Name = "rdoMaybe";
            this.rdoMaybe.Size = new System.Drawing.Size(57, 17);
            this.rdoMaybe.TabIndex = 1;
            this.rdoMaybe.TabStop = true;
            this.rdoMaybe.Text = "Maybe";
            this.rdoMaybe.UseVisualStyleBackColor = true;
            // 
            // rdoYes
            // 
            this.rdoYes.AutoSize = true;
            this.rdoYes.Location = new System.Drawing.Point(101, 19);
            this.rdoYes.Name = "rdoYes";
            this.rdoYes.Size = new System.Drawing.Size(43, 17);
            this.rdoYes.TabIndex = 0;
            this.rdoYes.TabStop = true;
            this.rdoYes.Text = "Yes";
            this.rdoYes.UseVisualStyleBackColor = true;
            // 
            // grpCruInfo
            // 
            this.grpCruInfo.Controls.Add(this.rdoCruNo);
            this.grpCruInfo.Controls.Add(this.rdoCruMaybe);
            this.grpCruInfo.Controls.Add(this.rdoCruYes);
            this.grpCruInfo.Location = new System.Drawing.Point(14, 360);
            this.grpCruInfo.Name = "grpCruInfo";
            this.grpCruInfo.Size = new System.Drawing.Size(280, 98);
            this.grpCruInfo.TabIndex = 9;
            this.grpCruInfo.TabStop = false;
            this.grpCruInfo.Text = "Would you be interested in more info about Cru?";
            // 
            // rdoCruNo
            // 
            this.rdoCruNo.AutoSize = true;
            this.rdoCruNo.Location = new System.Drawing.Point(94, 65);
            this.rdoCruNo.Name = "rdoCruNo";
            this.rdoCruNo.Size = new System.Drawing.Size(39, 17);
            this.rdoCruNo.TabIndex = 2;
            this.rdoCruNo.TabStop = true;
            this.rdoCruNo.Text = "No";
            this.rdoCruNo.UseVisualStyleBackColor = true;
            // 
            // rdoCruMaybe
            // 
            this.rdoCruMaybe.AutoSize = true;
            this.rdoCruMaybe.Location = new System.Drawing.Point(94, 42);
            this.rdoCruMaybe.Name = "rdoCruMaybe";
            this.rdoCruMaybe.Size = new System.Drawing.Size(57, 17);
            this.rdoCruMaybe.TabIndex = 1;
            this.rdoCruMaybe.TabStop = true;
            this.rdoCruMaybe.Text = "Maybe";
            this.rdoCruMaybe.UseVisualStyleBackColor = true;
            // 
            // rdoCruYes
            // 
            this.rdoCruYes.AutoSize = true;
            this.rdoCruYes.Location = new System.Drawing.Point(94, 19);
            this.rdoCruYes.Name = "rdoCruYes";
            this.rdoCruYes.Size = new System.Drawing.Size(43, 17);
            this.rdoCruYes.TabIndex = 0;
            this.rdoCruYes.TabStop = true;
            this.rdoCruYes.Text = "Yes";
            this.rdoCruYes.UseVisualStyleBackColor = true;
            // 
            // tboName
            // 
            this.tboName.Location = new System.Drawing.Point(56, 53);
            this.tboName.Name = "tboName";
            this.tboName.Size = new System.Drawing.Size(176, 20);
            this.tboName.TabIndex = 10;
            // 
            // cboResidence
            // 
            this.cboResidence.FormattingEnabled = true;
            this.cboResidence.Items.AddRange(new object[] {
            "Cary - East",
            "Cary - NE",
            "Cary - NW",
            "Cary - SE",
            "Cary - SW",
            "Cary - West",
            "Earhart",
            "First Street Towers - Central",
            "First Street Towers - East",
            "First Street Towers - West",
            "Harrison",
            "Hawkins",
            "Hillenbrand",
            "Hilltop Apartments",
            "Honors College North",
            "Honors College South",
            "McCutcheon",
            "Meredith - NE",
            "Meredith - NW",
            "Meredith - SE",
            "Meredith - SW",
            "Owen",
            "Purdue Village",
            "Shreve",
            "Third Street Suites",
            "Wiley",
            "Windsor - Duhme",
            "Windsor - Shealy",
            "Windsor - Vawter",
            "Windsor - Warren",
            "Windsor - Wood"});
            this.cboResidence.Location = new System.Drawing.Point(446, 53);
            this.cboResidence.Name = "cboResidence";
            this.cboResidence.Size = new System.Drawing.Size(159, 21);
            this.cboResidence.TabIndex = 11;
            // 
            // cboGrade
            // 
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Items.AddRange(new object[] {
            "Freshman",
            "Sophomore",
            "Junior",
            "Senior",
            "Grad"});
            this.cboGrade.Location = new System.Drawing.Point(56, 80);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(176, 21);
            this.cboGrade.TabIndex = 12;
            // 
            // tboRoom
            // 
            this.tboRoom.Location = new System.Drawing.Point(446, 80);
            this.tboRoom.Name = "tboRoom";
            this.tboRoom.Size = new System.Drawing.Size(159, 20);
            this.tboRoom.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tboRaceOther);
            this.groupBox1.Controls.Add(this.chkRaceOther);
            this.groupBox1.Controls.Add(this.chkAsian);
            this.groupBox1.Controls.Add(this.chkNative);
            this.groupBox1.Controls.Add(this.chkHispanic);
            this.groupBox1.Controls.Add(this.chkBlack);
            this.groupBox1.Controls.Add(this.chkWhite);
            this.groupBox1.Location = new System.Drawing.Point(334, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 156);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Are you...";
            // 
            // tboRaceOther
            // 
            this.tboRaceOther.Enabled = false;
            this.tboRaceOther.Location = new System.Drawing.Point(67, 130);
            this.tboRaceOther.Name = "tboRaceOther";
            this.tboRaceOther.Size = new System.Drawing.Size(100, 20);
            this.tboRaceOther.TabIndex = 6;
            // 
            // chkRaceOther
            // 
            this.chkRaceOther.AutoSize = true;
            this.chkRaceOther.Location = new System.Drawing.Point(6, 132);
            this.chkRaceOther.Name = "chkRaceOther";
            this.chkRaceOther.Size = new System.Drawing.Size(55, 17);
            this.chkRaceOther.TabIndex = 5;
            this.chkRaceOther.Text = "Other:";
            this.chkRaceOther.UseVisualStyleBackColor = true;
            this.chkRaceOther.CheckedChanged += new System.EventHandler(this.chkRaceOther_CheckedChanged);
            // 
            // chkAsian
            // 
            this.chkAsian.AutoSize = true;
            this.chkAsian.Location = new System.Drawing.Point(6, 109);
            this.chkAsian.Name = "chkAsian";
            this.chkAsian.Size = new System.Drawing.Size(135, 17);
            this.chkAsian.TabIndex = 4;
            this.chkAsian.Text = "Asian / Pacific Islander";
            this.chkAsian.UseVisualStyleBackColor = true;
            // 
            // chkNative
            // 
            this.chkNative.AutoSize = true;
            this.chkNative.Location = new System.Drawing.Point(6, 86);
            this.chkNative.Name = "chkNative";
            this.chkNative.Size = new System.Drawing.Size(195, 17);
            this.chkNative.TabIndex = 3;
            this.chkNative.Text = "Native American or American Indian";
            this.chkNative.UseVisualStyleBackColor = true;
            // 
            // chkHispanic
            // 
            this.chkHispanic.AutoSize = true;
            this.chkHispanic.Location = new System.Drawing.Point(6, 63);
            this.chkHispanic.Name = "chkHispanic";
            this.chkHispanic.Size = new System.Drawing.Size(111, 17);
            this.chkHispanic.TabIndex = 2;
            this.chkHispanic.Text = "Hispanic or Latino";
            this.chkHispanic.UseVisualStyleBackColor = true;
            // 
            // chkBlack
            // 
            this.chkBlack.AutoSize = true;
            this.chkBlack.Location = new System.Drawing.Point(6, 40);
            this.chkBlack.Name = "chkBlack";
            this.chkBlack.Size = new System.Drawing.Size(148, 17);
            this.chkBlack.TabIndex = 1;
            this.chkBlack.Text = "Black or African American";
            this.chkBlack.UseVisualStyleBackColor = true;
            // 
            // chkWhite
            // 
            this.chkWhite.AutoSize = true;
            this.chkWhite.Location = new System.Drawing.Point(6, 19);
            this.chkWhite.Name = "chkWhite";
            this.chkWhite.Size = new System.Drawing.Size(54, 17);
            this.chkWhite.TabIndex = 0;
            this.chkWhite.Text = "White";
            this.chkWhite.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(238, 56);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 15;
            this.lblGender.Text = "Gender:";
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(289, 53);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(84, 21);
            this.cboGender.TabIndex = 16;
            // 
            // CruContactCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 498);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tboRoom);
            this.Controls.Add(this.cboGrade);
            this.Controls.Add(this.cboResidence);
            this.Controls.Add(this.tboName);
            this.Controls.Add(this.grpCruInfo);
            this.Controls.Add(this.grpConvo);
            this.Controls.Add(this.grpRelationship);
            this.Controls.Add(this.grpAffiliation);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblResidence);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDone);
            this.Name = "CruContactCard";
            this.Text = "Contact Card";
            this.grpAffiliation.ResumeLayout(false);
            this.grpAffiliation.PerformLayout();
            this.grpRelationship.ResumeLayout(false);
            this.grpRelationship.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkRelationship)).EndInit();
            this.grpConvo.ResumeLayout(false);
            this.grpConvo.PerformLayout();
            this.grpCruInfo.ResumeLayout(false);
            this.grpCruInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblResidence;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.GroupBox grpAffiliation;
        private System.Windows.Forms.GroupBox grpRelationship;
        private System.Windows.Forms.GroupBox grpConvo;
        private System.Windows.Forms.GroupBox grpCruInfo;
        private System.Windows.Forms.TextBox tboName;
        private System.Windows.Forms.ComboBox cboResidence;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.TextBox tboRoom;
        private System.Windows.Forms.TextBox tboOther;
        private System.Windows.Forms.CheckBox chkOther;
        private System.Windows.Forms.CheckBox chkUndecided;
        private System.Windows.Forms.CheckBox chkAgnostic;
        private System.Windows.Forms.CheckBox chkAtheist;
        private System.Windows.Forms.CheckBox chkTaoist;
        private System.Windows.Forms.CheckBox chkHindu;
        private System.Windows.Forms.CheckBox chkBuddhist;
        private System.Windows.Forms.CheckBox chkJewish;
        private System.Windows.Forms.CheckBox chkMuslim;
        private System.Windows.Forms.CheckBox chkChristian;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.TrackBar trkRelationship;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tboRaceOther;
        private System.Windows.Forms.CheckBox chkRaceOther;
        private System.Windows.Forms.CheckBox chkAsian;
        private System.Windows.Forms.CheckBox chkNative;
        private System.Windows.Forms.CheckBox chkHispanic;
        private System.Windows.Forms.CheckBox chkBlack;
        private System.Windows.Forms.CheckBox chkWhite;
        private System.Windows.Forms.RadioButton rdoNo;
        private System.Windows.Forms.RadioButton rdoMaybe;
        private System.Windows.Forms.RadioButton rdoYes;
        private System.Windows.Forms.RadioButton rdoCruNo;
        private System.Windows.Forms.RadioButton rdoCruMaybe;
        private System.Windows.Forms.RadioButton rdoCruYes;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cboGender;
    }
}

