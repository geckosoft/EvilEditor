namespace EvilPlug.Editors.SaveGameEditor
{
    partial class EvilGameEditor
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabEditor = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.cmbAlertState = new System.Windows.Forms.ComboBox();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.tabEvilGenius = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEGEndurance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEGAttention = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEGSmarts = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEGLoyalty = new System.Windows.Forms.TextBox();
            this.lblHealth = new System.Windows.Forms.Label();
            this.txtEGHealth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEGName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEGID = new System.Windows.Forms.TextBox();
            this.tabMinRecruitment = new System.Windows.Forms.TabPage();
            this.grpRec = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtValet = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtTechnician = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtGuard = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtDiplomat = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtPlayboy = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSpindoctor = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtBiochemist = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtQuantum = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtScientist = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMartialArts = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMarkman = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMercenary = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtWorker = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRecTime = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRecRate = new System.Windows.Forms.TextBox();
            this.lblrec = new System.Windows.Forms.Label();
            this.txtRecCost = new System.Windows.Forms.TextBox();
            this.tabHenchman = new System.Windows.Forms.TabPage();
            this.tabRegions = new System.Windows.Forms.TabPage();
            this.lblTotalNotoriety = new System.Windows.Forms.Label();
            this.tabTools = new System.Windows.Forms.TabPage();
            this.btnToolsHider = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFixStuckFleeing = new System.Windows.Forms.Button();
            this.tmrLoadProgress = new System.Windows.Forms.Timer(this.components);
            this.tmrNotoriety = new System.Windows.Forms.Timer(this.components);
            this.label26 = new System.Windows.Forms.Label();
            this.txtBasePower = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.btnUnbuildableBitsReplacer = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabEditor.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabEvilGenius.SuspendLayout();
            this.tabMinRecruitment.SuspendLayout();
            this.grpRec.SuspendLayout();
            this.tabRegions.SuspendLayout();
            this.tabTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 460);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(502, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(163, 17);
            this.lblStatus.Text = "Status: Loading saved game...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // tabEditor
            // 
            this.tabEditor.Controls.Add(this.tabGeneral);
            this.tabEditor.Controls.Add(this.tabEvilGenius);
            this.tabEditor.Controls.Add(this.tabMinRecruitment);
            this.tabEditor.Controls.Add(this.tabHenchman);
            this.tabEditor.Controls.Add(this.tabRegions);
            this.tabEditor.Controls.Add(this.tabTools);
            this.tabEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEditor.Location = new System.Drawing.Point(0, 0);
            this.tabEditor.Name = "tabEditor";
            this.tabEditor.SelectedIndex = 0;
            this.tabEditor.Size = new System.Drawing.Size(502, 460);
            this.tabEditor.TabIndex = 3;
            this.tabEditor.Visible = false;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.label26);
            this.tabGeneral.Controls.Add(this.txtBasePower);
            this.tabGeneral.Controls.Add(this.cmbAlertState);
            this.tabGeneral.Controls.Add(this.cmbDifficulty);
            this.tabGeneral.Controls.Add(this.label3);
            this.tabGeneral.Controls.Add(this.label2);
            this.tabGeneral.Controls.Add(this.label1);
            this.tabGeneral.Controls.Add(this.txtMoney);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(494, 434);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // cmbAlertState
            // 
            this.cmbAlertState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlertState.FormattingEnabled = true;
            this.cmbAlertState.Items.AddRange(new object[] {
            "Green",
            "Yellow",
            "Red"});
            this.cmbAlertState.Location = new System.Drawing.Point(171, 42);
            this.cmbAlertState.Name = "cmbAlertState";
            this.cmbAlertState.Size = new System.Drawing.Size(126, 21);
            this.cmbAlertState.TabIndex = 7;
            this.cmbAlertState.SelectedIndexChanged += new System.EventHandler(this.cmbAlertState_SelectedIndexChanged);
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cmbDifficulty.Location = new System.Drawing.Point(171, 69);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(126, 21);
            this.cmbDifficulty.TabIndex = 6;
            this.cmbDifficulty.SelectedIndexChanged += new System.EventHandler(this.cmbDifficulty_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Difficulty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alert State";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Money";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(171, 16);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(126, 20);
            this.txtMoney.TabIndex = 0;
            this.txtMoney.Text = "0";
            this.txtMoney.TextChanged += new System.EventHandler(this.txtMoney_TextChanged);
            // 
            // tabEvilGenius
            // 
            this.tabEvilGenius.Controls.Add(this.label6);
            this.tabEvilGenius.Controls.Add(this.txtEGEndurance);
            this.tabEvilGenius.Controls.Add(this.label9);
            this.tabEvilGenius.Controls.Add(this.txtEGAttention);
            this.tabEvilGenius.Controls.Add(this.label8);
            this.tabEvilGenius.Controls.Add(this.txtEGSmarts);
            this.tabEvilGenius.Controls.Add(this.label7);
            this.tabEvilGenius.Controls.Add(this.txtEGLoyalty);
            this.tabEvilGenius.Controls.Add(this.lblHealth);
            this.tabEvilGenius.Controls.Add(this.txtEGHealth);
            this.tabEvilGenius.Controls.Add(this.label5);
            this.tabEvilGenius.Controls.Add(this.txtEGName);
            this.tabEvilGenius.Controls.Add(this.label4);
            this.tabEvilGenius.Controls.Add(this.txtEGID);
            this.tabEvilGenius.Location = new System.Drawing.Point(4, 22);
            this.tabEvilGenius.Name = "tabEvilGenius";
            this.tabEvilGenius.Size = new System.Drawing.Size(494, 434);
            this.tabEvilGenius.TabIndex = 1;
            this.tabEvilGenius.Text = "Evil Genius";
            this.tabEvilGenius.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Endurance";
            // 
            // txtEGEndurance
            // 
            this.txtEGEndurance.Location = new System.Drawing.Point(171, 172);
            this.txtEGEndurance.Name = "txtEGEndurance";
            this.txtEGEndurance.Size = new System.Drawing.Size(126, 20);
            this.txtEGEndurance.TabIndex = 21;
            this.txtEGEndurance.Text = "0";
            this.txtEGEndurance.TextChanged += new System.EventHandler(this.txtEGEndurance_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Attention";
            // 
            // txtEGAttention
            // 
            this.txtEGAttention.Location = new System.Drawing.Point(171, 146);
            this.txtEGAttention.Name = "txtEGAttention";
            this.txtEGAttention.Size = new System.Drawing.Size(126, 20);
            this.txtEGAttention.TabIndex = 12;
            this.txtEGAttention.Text = "0";
            this.txtEGAttention.TextChanged += new System.EventHandler(this.txtEGAttention_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Smarts";
            // 
            // txtEGSmarts
            // 
            this.txtEGSmarts.Location = new System.Drawing.Point(171, 120);
            this.txtEGSmarts.Name = "txtEGSmarts";
            this.txtEGSmarts.Size = new System.Drawing.Size(126, 20);
            this.txtEGSmarts.TabIndex = 10;
            this.txtEGSmarts.Text = "0";
            this.txtEGSmarts.TextChanged += new System.EventHandler(this.txtEGSmarts_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Loyalty";
            // 
            // txtEGLoyalty
            // 
            this.txtEGLoyalty.Location = new System.Drawing.Point(171, 94);
            this.txtEGLoyalty.Name = "txtEGLoyalty";
            this.txtEGLoyalty.Size = new System.Drawing.Size(126, 20);
            this.txtEGLoyalty.TabIndex = 8;
            this.txtEGLoyalty.Text = "0";
            this.txtEGLoyalty.TextChanged += new System.EventHandler(this.txtEGLoyalty_TextChanged);
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(9, 75);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(38, 13);
            this.lblHealth.TabIndex = 7;
            this.lblHealth.Text = "Health";
            // 
            // txtEGHealth
            // 
            this.txtEGHealth.Location = new System.Drawing.Point(171, 68);
            this.txtEGHealth.Name = "txtEGHealth";
            this.txtEGHealth.Size = new System.Drawing.Size(126, 20);
            this.txtEGHealth.TabIndex = 6;
            this.txtEGHealth.Text = "0";
            this.txtEGHealth.TextChanged += new System.EventHandler(this.txtEGHealth_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Name";
            // 
            // txtEGName
            // 
            this.txtEGName.Location = new System.Drawing.Point(171, 42);
            this.txtEGName.Name = "txtEGName";
            this.txtEGName.Size = new System.Drawing.Size(126, 20);
            this.txtEGName.TabIndex = 4;
            this.txtEGName.Text = "Sinner \"Evil\" G";
            this.txtEGName.TextChanged += new System.EventHandler(this.txtEGName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Evil Genius\' Entity ID";
            // 
            // txtEGID
            // 
            this.txtEGID.Enabled = false;
            this.txtEGID.Location = new System.Drawing.Point(171, 16);
            this.txtEGID.Name = "txtEGID";
            this.txtEGID.Size = new System.Drawing.Size(126, 20);
            this.txtEGID.TabIndex = 2;
            this.txtEGID.Text = "0";
            // 
            // tabMinRecruitment
            // 
            this.tabMinRecruitment.Controls.Add(this.grpRec);
            this.tabMinRecruitment.Controls.Add(this.label12);
            this.tabMinRecruitment.Controls.Add(this.txtRecTime);
            this.tabMinRecruitment.Controls.Add(this.label11);
            this.tabMinRecruitment.Controls.Add(this.txtRecRate);
            this.tabMinRecruitment.Controls.Add(this.lblrec);
            this.tabMinRecruitment.Controls.Add(this.txtRecCost);
            this.tabMinRecruitment.Location = new System.Drawing.Point(4, 22);
            this.tabMinRecruitment.Name = "tabMinRecruitment";
            this.tabMinRecruitment.Size = new System.Drawing.Size(494, 410);
            this.tabMinRecruitment.TabIndex = 3;
            this.tabMinRecruitment.Text = "Minion Recruitment";
            this.tabMinRecruitment.UseVisualStyleBackColor = true;
            // 
            // grpRec
            // 
            this.grpRec.Controls.Add(this.label23);
            this.grpRec.Controls.Add(this.txtValet);
            this.grpRec.Controls.Add(this.label24);
            this.grpRec.Controls.Add(this.txtTechnician);
            this.grpRec.Controls.Add(this.label25);
            this.grpRec.Controls.Add(this.txtGuard);
            this.grpRec.Controls.Add(this.label22);
            this.grpRec.Controls.Add(this.txtDiplomat);
            this.grpRec.Controls.Add(this.label21);
            this.grpRec.Controls.Add(this.txtPlayboy);
            this.grpRec.Controls.Add(this.label20);
            this.grpRec.Controls.Add(this.txtSpindoctor);
            this.grpRec.Controls.Add(this.label19);
            this.grpRec.Controls.Add(this.txtBiochemist);
            this.grpRec.Controls.Add(this.label18);
            this.grpRec.Controls.Add(this.txtQuantum);
            this.grpRec.Controls.Add(this.label17);
            this.grpRec.Controls.Add(this.txtScientist);
            this.grpRec.Controls.Add(this.label16);
            this.grpRec.Controls.Add(this.txtMartialArts);
            this.grpRec.Controls.Add(this.label15);
            this.grpRec.Controls.Add(this.txtMarkman);
            this.grpRec.Controls.Add(this.label14);
            this.grpRec.Controls.Add(this.txtMercenary);
            this.grpRec.Controls.Add(this.label13);
            this.grpRec.Controls.Add(this.txtWorker);
            this.grpRec.Location = new System.Drawing.Point(12, 102);
            this.grpRec.Name = "grpRec";
            this.grpRec.Size = new System.Drawing.Size(474, 162);
            this.grpRec.TabIndex = 10;
            this.grpRec.TabStop = false;
            this.grpRec.Text = "Minion recruitment amount";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(346, 56);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 13);
            this.label23.TabIndex = 31;
            this.label23.Text = "Valet";
            // 
            // txtValet
            // 
            this.txtValet.Location = new System.Drawing.Point(418, 49);
            this.txtValet.Name = "txtValet";
            this.txtValet.Size = new System.Drawing.Size(21, 20);
            this.txtValet.TabIndex = 30;
            this.txtValet.Tag = "102";
            this.txtValet.Text = "0";
            this.txtValet.TextChanged += new System.EventHandler(this.desiredMinions_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(169, 56);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(60, 13);
            this.label24.TabIndex = 29;
            this.label24.Text = "Technician";
            // 
            // txtTechnician
            // 
            this.txtTechnician.Location = new System.Drawing.Point(266, 49);
            this.txtTechnician.Name = "txtTechnician";
            this.txtTechnician.Size = new System.Drawing.Size(21, 20);
            this.txtTechnician.TabIndex = 28;
            this.txtTechnician.Tag = "103";
            this.txtTechnician.Text = "0";
            this.txtTechnician.TextChanged += new System.EventHandler(this.desiredMinions_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(24, 56);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(36, 13);
            this.label25.TabIndex = 27;
            this.label25.Text = "Guard";
            // 
            // txtGuard
            // 
            this.txtGuard.Location = new System.Drawing.Point(96, 49);
            this.txtGuard.Name = "txtGuard";
            this.txtGuard.Size = new System.Drawing.Size(21, 20);
            this.txtGuard.TabIndex = 26;
            this.txtGuard.Tag = "104";
            this.txtGuard.Text = "0";
            this.txtGuard.TextChanged += new System.EventHandler(this.desiredMinions_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(346, 134);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(48, 13);
            this.label22.TabIndex = 25;
            this.label22.Text = "Diplomat";
            // 
            // txtDiplomat
            // 
            this.txtDiplomat.Location = new System.Drawing.Point(418, 127);
            this.txtDiplomat.Name = "txtDiplomat";
            this.txtDiplomat.Size = new System.Drawing.Size(21, 20);
            this.txtDiplomat.TabIndex = 24;
            this.txtDiplomat.Tag = "109";
            this.txtDiplomat.Text = "0";
            this.txtDiplomat.TextChanged += new System.EventHandler(this.desiredMinions_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(346, 108);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 13);
            this.label21.TabIndex = 23;
            this.label21.Text = "Playboy";
            // 
            // txtPlayboy
            // 
            this.txtPlayboy.Location = new System.Drawing.Point(418, 101);
            this.txtPlayboy.Name = "txtPlayboy";
            this.txtPlayboy.Size = new System.Drawing.Size(21, 20);
            this.txtPlayboy.TabIndex = 22;
            this.txtPlayboy.Tag = "110";
            this.txtPlayboy.Text = "0";
            this.txtPlayboy.TextChanged += new System.EventHandler(this.desiredMinions_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(346, 82);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 13);
            this.label20.TabIndex = 21;
            this.label20.Text = "Spindoctor";
            // 
            // txtSpindoctor
            // 
            this.txtSpindoctor.Location = new System.Drawing.Point(418, 75);
            this.txtSpindoctor.Name = "txtSpindoctor";
            this.txtSpindoctor.Size = new System.Drawing.Size(21, 20);
            this.txtSpindoctor.TabIndex = 20;
            this.txtSpindoctor.Tag = "107";
            this.txtSpindoctor.Text = "0";
            this.txtSpindoctor.TextChanged += new System.EventHandler(this.desiredMinions_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(169, 134);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 19;
            this.label19.Tag = "";
            this.label19.Text = "Biochemist";
            // 
            // txtBiochemist
            // 
            this.txtBiochemist.Location = new System.Drawing.Point(266, 127);
            this.txtBiochemist.Name = "txtBiochemist";
            this.txtBiochemist.Size = new System.Drawing.Size(21, 20);
            this.txtBiochemist.TabIndex = 18;
            this.txtBiochemist.Tag = "105";
            this.txtBiochemist.Text = "0";
            this.txtBiochemist.TextChanged += new System.EventHandler(this.desiredMinions_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(169, 108);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Quantum Phys.";
            // 
            // txtQuantum
            // 
            this.txtQuantum.Location = new System.Drawing.Point(266, 101);
            this.txtQuantum.Name = "txtQuantum";
            this.txtQuantum.Size = new System.Drawing.Size(21, 20);
            this.txtQuantum.TabIndex = 16;
            this.txtQuantum.Tag = "112";
            this.txtQuantum.Text = "0";
            this.txtQuantum.TextChanged += new System.EventHandler(this.desiredMinions_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(169, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Scientist";
            // 
            // txtScientist
            // 
            this.txtScientist.Location = new System.Drawing.Point(266, 75);
            this.txtScientist.Name = "txtScientist";
            this.txtScientist.Size = new System.Drawing.Size(21, 20);
            this.txtScientist.TabIndex = 14;
            this.txtScientist.Tag = "106";
            this.txtScientist.Text = "0";
            this.txtScientist.TextChanged += new System.EventHandler(this.desiredMinions_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 134);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Martial Artist";
            // 
            // txtMartialArts
            // 
            this.txtMartialArts.Location = new System.Drawing.Point(96, 127);
            this.txtMartialArts.Name = "txtMartialArts";
            this.txtMartialArts.Size = new System.Drawing.Size(21, 20);
            this.txtMartialArts.TabIndex = 12;
            this.txtMartialArts.Tag = "111";
            this.txtMartialArts.Text = "0";
            this.txtMartialArts.TextChanged += new System.EventHandler(this.desiredMinions_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Marksman";
            // 
            // txtMarkman
            // 
            this.txtMarkman.Location = new System.Drawing.Point(96, 101);
            this.txtMarkman.Name = "txtMarkman";
            this.txtMarkman.Size = new System.Drawing.Size(21, 20);
            this.txtMarkman.TabIndex = 10;
            this.txtMarkman.Tag = "101";
            this.txtMarkman.Text = "0";
            this.txtMarkman.TextChanged += new System.EventHandler(this.desiredMinions_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Mercenary";
            // 
            // txtMercenary
            // 
            this.txtMercenary.Location = new System.Drawing.Point(96, 75);
            this.txtMercenary.Name = "txtMercenary";
            this.txtMercenary.Size = new System.Drawing.Size(21, 20);
            this.txtMercenary.TabIndex = 8;
            this.txtMercenary.Tag = "108";
            this.txtMercenary.Text = "0";
            this.txtMercenary.TextChanged += new System.EventHandler(this.desiredMinions_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Worker";
            // 
            // txtWorker
            // 
            this.txtWorker.Location = new System.Drawing.Point(96, 23);
            this.txtWorker.Name = "txtWorker";
            this.txtWorker.Size = new System.Drawing.Size(21, 20);
            this.txtWorker.TabIndex = 6;
            this.txtWorker.Tag = "100";
            this.txtWorker.Text = "0";
            this.txtWorker.TextChanged += new System.EventHandler(this.desiredMinions_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Time since last recruited";
            // 
            // txtRecTime
            // 
            this.txtRecTime.Location = new System.Drawing.Point(171, 68);
            this.txtRecTime.Name = "txtRecTime";
            this.txtRecTime.Size = new System.Drawing.Size(126, 20);
            this.txtRecTime.TabIndex = 8;
            this.txtRecTime.Text = "0";
            this.txtRecTime.TextChanged += new System.EventHandler(this.txtRecTime_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Recruitment rate";
            // 
            // txtRecRate
            // 
            this.txtRecRate.Location = new System.Drawing.Point(171, 42);
            this.txtRecRate.Name = "txtRecRate";
            this.txtRecRate.Size = new System.Drawing.Size(126, 20);
            this.txtRecRate.TabIndex = 6;
            this.txtRecRate.Text = "0";
            this.txtRecRate.TextChanged += new System.EventHandler(this.txtRecRate_TextChanged);
            // 
            // lblrec
            // 
            this.lblrec.AutoSize = true;
            this.lblrec.Location = new System.Drawing.Point(9, 23);
            this.lblrec.Name = "lblrec";
            this.lblrec.Size = new System.Drawing.Size(87, 13);
            this.lblrec.TabIndex = 5;
            this.lblrec.Text = "Recruitment cost";
            // 
            // txtRecCost
            // 
            this.txtRecCost.Location = new System.Drawing.Point(171, 16);
            this.txtRecCost.Name = "txtRecCost";
            this.txtRecCost.Size = new System.Drawing.Size(126, 20);
            this.txtRecCost.TabIndex = 4;
            this.txtRecCost.Text = "0";
            this.txtRecCost.TextChanged += new System.EventHandler(this.txtRecCost_TextChanged);
            // 
            // tabHenchman
            // 
            this.tabHenchman.AutoScroll = true;
            this.tabHenchman.Location = new System.Drawing.Point(4, 22);
            this.tabHenchman.Name = "tabHenchman";
            this.tabHenchman.Size = new System.Drawing.Size(494, 410);
            this.tabHenchman.TabIndex = 4;
            this.tabHenchman.Text = "Henchmen";
            this.tabHenchman.UseVisualStyleBackColor = true;
            this.tabHenchman.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tabHenchman_Scroll);
            // 
            // tabRegions
            // 
            this.tabRegions.AutoScroll = true;
            this.tabRegions.Controls.Add(this.lblTotalNotoriety);
            this.tabRegions.Location = new System.Drawing.Point(4, 22);
            this.tabRegions.Name = "tabRegions";
            this.tabRegions.Size = new System.Drawing.Size(494, 410);
            this.tabRegions.TabIndex = 5;
            this.tabRegions.Text = "Regions";
            this.tabRegions.UseVisualStyleBackColor = true;
            // 
            // lblTotalNotoriety
            // 
            this.lblTotalNotoriety.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalNotoriety.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalNotoriety.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNotoriety.Location = new System.Drawing.Point(0, 0);
            this.lblTotalNotoriety.Name = "lblTotalNotoriety";
            this.lblTotalNotoriety.Size = new System.Drawing.Size(494, 40);
            this.lblTotalNotoriety.TabIndex = 0;
            this.lblTotalNotoriety.Text = "Global notoriety (sum of all regions): 0";
            this.lblTotalNotoriety.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabTools
            // 
            this.tabTools.AutoScroll = true;
            this.tabTools.Controls.Add(this.label27);
            this.tabTools.Controls.Add(this.btnUnbuildableBitsReplacer);
            this.tabTools.Controls.Add(this.label10);
            this.tabTools.Controls.Add(this.btnFixStuckFleeing);
            this.tabTools.Controls.Add(this.btnToolsHider);
            this.tabTools.Location = new System.Drawing.Point(4, 22);
            this.tabTools.Name = "tabTools";
            this.tabTools.Size = new System.Drawing.Size(494, 434);
            this.tabTools.TabIndex = 2;
            this.tabTools.Text = "Tools";
            this.tabTools.UseVisualStyleBackColor = true;
            // 
            // btnToolsHider
            // 
            this.btnToolsHider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnToolsHider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToolsHider.Location = new System.Drawing.Point(0, 0);
            this.btnToolsHider.Name = "btnToolsHider";
            this.btnToolsHider.Size = new System.Drawing.Size(494, 434);
            this.btnToolsHider.TabIndex = 2;
            this.btnToolsHider.Text = "!! ALWAYS BACKUP FIRST !!\r\n\r\nUnstable features ahead. Use with caution. \r\n\r\n!! AL" +
                "WAYS BACKUP FIRST !!";
            this.btnToolsHider.UseVisualStyleBackColor = true;
            this.btnToolsHider.Click += new System.EventHandler(this.btnToolsHider_Click);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(60, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(403, 48);
            this.label10.TabIndex = 1;
            this.label10.Text = "Attempts to fix stuck minions. \r\nMake sure they do not have any tasks assigned fi" +
                "rst! \r\nMay result in breaking whatever the minions were assigned too!\r\n";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFixStuckFleeing
            // 
            this.btnFixStuckFleeing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFixStuckFleeing.Location = new System.Drawing.Point(8, 14);
            this.btnFixStuckFleeing.Name = "btnFixStuckFleeing";
            this.btnFixStuckFleeing.Size = new System.Drawing.Size(46, 48);
            this.btnFixStuckFleeing.TabIndex = 0;
            this.btnFixStuckFleeing.Text = "Fix it!";
            this.btnFixStuckFleeing.UseVisualStyleBackColor = true;
            this.btnFixStuckFleeing.Click += new System.EventHandler(this.btnFixStuckFleeing_Click);
            // 
            // tmrLoadProgress
            // 
            this.tmrLoadProgress.Enabled = true;
            this.tmrLoadProgress.Interval = 25;
            this.tmrLoadProgress.Tick += new System.EventHandler(this.tmrLoadProgress_Tick);
            // 
            // tmrNotoriety
            // 
            this.tmrNotoriety.Enabled = true;
            this.tmrNotoriety.Tick += new System.EventHandler(this.tmrNotoriety_Tick);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(9, 103);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(64, 13);
            this.label26.TabIndex = 9;
            this.label26.Text = "Base Power";
            // 
            // txtBasePower
            // 
            this.txtBasePower.Location = new System.Drawing.Point(171, 96);
            this.txtBasePower.Name = "txtBasePower";
            this.txtBasePower.Size = new System.Drawing.Size(126, 20);
            this.txtBasePower.TabIndex = 8;
            this.txtBasePower.Text = "0";
            this.txtBasePower.TextChanged += new System.EventHandler(this.txtBasePower_TextChanged);
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(60, 68);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(403, 48);
            this.label27.TabIndex = 4;
            this.label27.Text = "Unbuildable bits replacer\r\n\r\nReplaces rocky parts within the mountain with builda" +
                "ble parts";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUnbuildableBitsReplacer
            // 
            this.btnUnbuildableBitsReplacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnbuildableBitsReplacer.Location = new System.Drawing.Point(8, 68);
            this.btnUnbuildableBitsReplacer.Name = "btnUnbuildableBitsReplacer";
            this.btnUnbuildableBitsReplacer.Size = new System.Drawing.Size(46, 48);
            this.btnUnbuildableBitsReplacer.TabIndex = 3;
            this.btnUnbuildableBitsReplacer.Text = "Fix it!";
            this.btnUnbuildableBitsReplacer.UseVisualStyleBackColor = true;
            this.btnUnbuildableBitsReplacer.Click += new System.EventHandler(this.btnUnbuildableBitsReplacer_Click);
            // 
            // EvilGameEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 482);
            this.Controls.Add(this.tabEditor);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "EvilGameEditor";
            this.Text = "Evil Genius: Save Game Editor";
            this.Load += new System.EventHandler(this.EvilGameEditor_Load);
            this.Shown += new System.EventHandler(this.EvilGameEditor_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EvilGameEditor_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabEditor.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabEvilGenius.ResumeLayout(false);
            this.tabEvilGenius.PerformLayout();
            this.tabMinRecruitment.ResumeLayout(false);
            this.tabMinRecruitment.PerformLayout();
            this.grpRec.ResumeLayout(false);
            this.grpRec.PerformLayout();
            this.tabRegions.ResumeLayout(false);
            this.tabTools.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabEditor;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.ComboBox cmbAlertState;
        private System.Windows.Forms.ComboBox cmbDifficulty;
        private System.Windows.Forms.Timer tmrLoadProgress;
        internal System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.TabPage tabEvilGenius;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEGAttention;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEGSmarts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEGLoyalty;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.TextBox txtEGHealth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEGName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEGID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEGEndurance;
        private System.Windows.Forms.TabPage tabTools;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnFixStuckFleeing;
        private System.Windows.Forms.Button btnToolsHider;
        private System.Windows.Forms.TabPage tabMinRecruitment;
        private System.Windows.Forms.Label lblrec;
        private System.Windows.Forms.TextBox txtRecCost;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRecTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRecRate;
        private System.Windows.Forms.GroupBox grpRec;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtDiplomat;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtPlayboy;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtSpindoctor;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtBiochemist;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtQuantum;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtScientist;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMartialArts;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMarkman;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMercenary;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtWorker;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtValet;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtTechnician;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtGuard;
        private System.Windows.Forms.TabPage tabHenchman;
        private System.Windows.Forms.TabPage tabRegions;
        private System.Windows.Forms.Label lblTotalNotoriety;
        private System.Windows.Forms.Timer tmrNotoriety;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtBasePower;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnUnbuildableBitsReplacer;
    }
}