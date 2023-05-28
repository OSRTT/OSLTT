
namespace OSLTT
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.deviceStatusPanel = new System.Windows.Forms.Panel();
            this.fwLbl = new MaterialSkin.Controls.MaterialLabel();
            this.fwLblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.devStat = new MaterialSkin.Controls.MaterialLabel();
            this.checkImg = new System.Windows.Forms.PictureBox();
            this.buttonTriggerToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.clickCountSelect = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.timeBetweenSelect = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.settingsCard = new MaterialSkin.Controls.MaterialCard();
            this.MouseKeyboardToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.displaySelect = new MaterialSkin.Controls.MaterialComboBox();
            this.audioSourceToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.autoClickToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.preTestToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.gameExternalToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.directXToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.audioSensorToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.lightSensorToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.pinTriggerToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.audioTriggerToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.resultsViewBtn = new MaterialSkin.Controls.MaterialButton();
            this.notesBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.deviceNameBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.startTestBtn = new MaterialSkin.Controls.MaterialButton();
            this.debugBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.helpBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.MonitorsTab = new System.Windows.Forms.TabPage();
            this.MiceKeyboardsTab = new System.Windows.Forms.TabPage();
            this.GamesTab = new System.Windows.Forms.TabPage();
            this.HeadsetsTab = new System.Windows.Forms.TabPage();
            this.CustomTab1 = new System.Windows.Forms.TabPage();
            this.TestTab = new System.Windows.Forms.TabPage();
            this.typeTextCard = new MaterialSkin.Controls.MaterialCard();
            this.textTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.clickTestBox = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.settingsPane1 = new OSLTT.SettingsPane();
            this.deviceStatusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkImg)).BeginInit();
            this.settingsCard.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.MonitorsTab.SuspendLayout();
            this.MiceKeyboardsTab.SuspendLayout();
            this.TestTab.SuspendLayout();
            this.typeTextCard.SuspendLayout();
            this.clickTestBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceStatusPanel
            // 
            this.deviceStatusPanel.BackColor = System.Drawing.Color.White;
            this.deviceStatusPanel.Controls.Add(this.fwLbl);
            this.deviceStatusPanel.Controls.Add(this.fwLblTitle);
            this.deviceStatusPanel.Controls.Add(this.devStat);
            this.deviceStatusPanel.Controls.Add(this.checkImg);
            this.deviceStatusPanel.Location = new System.Drawing.Point(200, 24);
            this.deviceStatusPanel.Name = "deviceStatusPanel";
            this.deviceStatusPanel.Size = new System.Drawing.Size(831, 40);
            this.deviceStatusPanel.TabIndex = 31;
            // 
            // fwLbl
            // 
            this.fwLbl.AutoSize = true;
            this.fwLbl.BackColor = System.Drawing.Color.Transparent;
            this.fwLbl.Depth = 0;
            this.fwLbl.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.fwLbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.fwLbl.Location = new System.Drawing.Point(716, 8);
            this.fwLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.fwLbl.Name = "fwLbl";
            this.fwLbl.Size = new System.Drawing.Size(53, 24);
            this.fwLbl.TabIndex = 12;
            this.fwLbl.Text = "V0.00";
            // 
            // fwLblTitle
            // 
            this.fwLblTitle.AutoSize = true;
            this.fwLblTitle.BackColor = System.Drawing.Color.Transparent;
            this.fwLblTitle.Depth = 0;
            this.fwLblTitle.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.fwLblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.fwLblTitle.Location = new System.Drawing.Point(679, 8);
            this.fwLblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.fwLblTitle.Name = "fwLblTitle";
            this.fwLblTitle.Size = new System.Drawing.Size(35, 24);
            this.fwLblTitle.TabIndex = 11;
            this.fwLblTitle.Text = "FW:";
            // 
            // devStat
            // 
            this.devStat.AutoSize = true;
            this.devStat.BackColor = System.Drawing.Color.Transparent;
            this.devStat.Depth = 0;
            this.devStat.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.devStat.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.devStat.Location = new System.Drawing.Point(13, 8);
            this.devStat.MouseState = MaterialSkin.MouseState.HOVER;
            this.devStat.Name = "devStat";
            this.devStat.Size = new System.Drawing.Size(162, 24);
            this.devStat.TabIndex = 10;
            this.devStat.Text = "Device Connected";
            // 
            // checkImg
            // 
            this.checkImg.BackColor = System.Drawing.Color.Transparent;
            this.checkImg.BackgroundImage = global::OSLTT.Properties.Resources.check;
            this.checkImg.ErrorImage = global::OSLTT.Properties.Resources.check;
            this.checkImg.Image = global::OSLTT.Properties.Resources.check;
            this.checkImg.InitialImage = global::OSLTT.Properties.Resources.check;
            this.checkImg.Location = new System.Drawing.Point(184, 5);
            this.checkImg.Name = "checkImg";
            this.checkImg.Size = new System.Drawing.Size(58, 29);
            this.checkImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.checkImg.TabIndex = 7;
            this.checkImg.TabStop = false;
            // 
            // buttonTriggerToggle
            // 
            this.buttonTriggerToggle.AutoSize = true;
            this.buttonTriggerToggle.Checked = true;
            this.buttonTriggerToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.buttonTriggerToggle.Depth = 0;
            this.buttonTriggerToggle.Location = new System.Drawing.Point(14, 43);
            this.buttonTriggerToggle.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTriggerToggle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.buttonTriggerToggle.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonTriggerToggle.Name = "buttonTriggerToggle";
            this.buttonTriggerToggle.Ripple = true;
            this.buttonTriggerToggle.Size = new System.Drawing.Size(159, 37);
            this.buttonTriggerToggle.TabIndex = 41;
            this.buttonTriggerToggle.Text = "OSLTT Button";
            this.buttonTriggerToggle.UseVisualStyleBackColor = true;
            this.buttonTriggerToggle.CheckedChanged += new System.EventHandler(this.buttonTriggerToggle_CheckedChanged);
            // 
            // materialDrawer1
            // 
            this.materialDrawer1.AutoHide = false;
            this.materialDrawer1.AutoShow = false;
            this.materialDrawer1.BackgroundWithAccent = false;
            this.materialDrawer1.BaseTabControl = null;
            this.materialDrawer1.Depth = 0;
            this.materialDrawer1.HighlightWithAccent = true;
            this.materialDrawer1.IndicatorWidth = 0;
            this.materialDrawer1.IsOpen = false;
            this.materialDrawer1.Location = new System.Drawing.Point(-250, 273);
            this.materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer1.Name = "materialDrawer1";
            this.materialDrawer1.ShowIconsWhenHidden = false;
            this.materialDrawer1.Size = new System.Drawing.Size(250, 120);
            this.materialDrawer1.TabIndex = 42;
            this.materialDrawer1.Text = "materialDrawer1";
            this.materialDrawer1.UseColors = false;
            // 
            // clickCountSelect
            // 
            this.clickCountSelect.AutoResize = false;
            this.clickCountSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clickCountSelect.Depth = 0;
            this.clickCountSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.clickCountSelect.DropDownHeight = 174;
            this.clickCountSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clickCountSelect.DropDownWidth = 121;
            this.clickCountSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.clickCountSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clickCountSelect.FormattingEnabled = true;
            this.clickCountSelect.IntegralHeight = false;
            this.clickCountSelect.ItemHeight = 43;
            this.clickCountSelect.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "100",
            "150",
            "200",
            "250",
            "500"});
            this.clickCountSelect.Location = new System.Drawing.Point(355, 76);
            this.clickCountSelect.MaxDropDownItems = 4;
            this.clickCountSelect.MouseState = MaterialSkin.MouseState.OUT;
            this.clickCountSelect.Name = "clickCountSelect";
            this.clickCountSelect.Size = new System.Drawing.Size(140, 49);
            this.clickCountSelect.StartIndex = 0;
            this.clickCountSelect.TabIndex = 44;
            this.clickCountSelect.SelectedIndexChanged += new System.EventHandler(this.clickCountSelect_SelectedIndexChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(216, 96);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(122, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Number of Clicks";
            // 
            // timeBetweenSelect
            // 
            this.timeBetweenSelect.AutoResize = false;
            this.timeBetweenSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.timeBetweenSelect.Depth = 0;
            this.timeBetweenSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.timeBetweenSelect.DropDownHeight = 174;
            this.timeBetweenSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeBetweenSelect.DropDownWidth = 121;
            this.timeBetweenSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.timeBetweenSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timeBetweenSelect.FormattingEnabled = true;
            this.timeBetweenSelect.IntegralHeight = false;
            this.timeBetweenSelect.ItemHeight = 43;
            this.timeBetweenSelect.Items.AddRange(new object[] {
            "0.5",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.timeBetweenSelect.Location = new System.Drawing.Point(374, 133);
            this.timeBetweenSelect.MaxDropDownItems = 4;
            this.timeBetweenSelect.MouseState = MaterialSkin.MouseState.OUT;
            this.timeBetweenSelect.Name = "timeBetweenSelect";
            this.timeBetweenSelect.Size = new System.Drawing.Size(121, 49);
            this.timeBetweenSelect.StartIndex = 0;
            this.timeBetweenSelect.TabIndex = 46;
            this.timeBetweenSelect.SelectedIndexChanged += new System.EventHandler(this.timeBetweenSelect_SelectedIndexChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(216, 150);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(147, 19);
            this.materialLabel5.TabIndex = 45;
            this.materialLabel5.Text = "Time Between Clicks";
            // 
            // settingsCard
            // 
            this.settingsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.settingsCard.Controls.Add(this.MouseKeyboardToggle);
            this.settingsCard.Controls.Add(this.materialLabel10);
            this.settingsCard.Controls.Add(this.displaySelect);
            this.settingsCard.Controls.Add(this.audioSourceToggle);
            this.settingsCard.Controls.Add(this.autoClickToggle);
            this.settingsCard.Controls.Add(this.materialLabel9);
            this.settingsCard.Controls.Add(this.preTestToggle);
            this.settingsCard.Controls.Add(this.gameExternalToggle);
            this.settingsCard.Controls.Add(this.materialLabel2);
            this.settingsCard.Controls.Add(this.directXToggle);
            this.settingsCard.Controls.Add(this.materialLabel8);
            this.settingsCard.Controls.Add(this.timeBetweenSelect);
            this.settingsCard.Controls.Add(this.materialLabel5);
            this.settingsCard.Controls.Add(this.audioSensorToggle);
            this.settingsCard.Controls.Add(this.materialLabel7);
            this.settingsCard.Controls.Add(this.clickCountSelect);
            this.settingsCard.Controls.Add(this.materialLabel4);
            this.settingsCard.Controls.Add(this.lightSensorToggle);
            this.settingsCard.Controls.Add(this.pinTriggerToggle);
            this.settingsCard.Controls.Add(this.audioTriggerToggle);
            this.settingsCard.Controls.Add(this.materialLabel6);
            this.settingsCard.Controls.Add(this.buttonTriggerToggle);
            this.settingsCard.Depth = 0;
            this.settingsCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settingsCard.Location = new System.Drawing.Point(3, 9);
            this.settingsCard.Margin = new System.Windows.Forms.Padding(14);
            this.settingsCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingsCard.Name = "settingsCard";
            this.settingsCard.Padding = new System.Windows.Forms.Padding(14);
            this.settingsCard.Size = new System.Drawing.Size(892, 286);
            this.settingsCard.TabIndex = 44;
            // 
            // MouseKeyboardToggle
            // 
            this.MouseKeyboardToggle.AutoSize = true;
            this.MouseKeyboardToggle.Depth = 0;
            this.MouseKeyboardToggle.Location = new System.Drawing.Point(517, 174);
            this.MouseKeyboardToggle.Margin = new System.Windows.Forms.Padding(0);
            this.MouseKeyboardToggle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MouseKeyboardToggle.MouseState = MaterialSkin.MouseState.HOVER;
            this.MouseKeyboardToggle.Name = "MouseKeyboardToggle";
            this.MouseKeyboardToggle.Ripple = true;
            this.MouseKeyboardToggle.Size = new System.Drawing.Size(180, 37);
            this.MouseKeyboardToggle.TabIndex = 62;
            this.MouseKeyboardToggle.Text = "Mouse/Keyboard";
            this.MouseKeyboardToggle.UseVisualStyleBackColor = true;
            this.MouseKeyboardToggle.CheckedChanged += new System.EventHandler(this.MouseKeyboardToggle_CheckedChanged);
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel10.Location = new System.Drawing.Point(522, 14);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(131, 29);
            this.materialLabel10.TabIndex = 61;
            this.materialLabel10.Text = "Test Display";
            // 
            // displaySelect
            // 
            this.displaySelect.AutoResize = false;
            this.displaySelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.displaySelect.Depth = 0;
            this.displaySelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.displaySelect.DropDownHeight = 174;
            this.displaySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.displaySelect.DropDownWidth = 121;
            this.displaySelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.displaySelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.displaySelect.FormattingEnabled = true;
            this.displaySelect.IntegralHeight = false;
            this.displaySelect.ItemHeight = 43;
            this.displaySelect.Location = new System.Drawing.Point(527, 49);
            this.displaySelect.MaxDropDownItems = 4;
            this.displaySelect.MouseState = MaterialSkin.MouseState.OUT;
            this.displaySelect.Name = "displaySelect";
            this.displaySelect.Size = new System.Drawing.Size(208, 49);
            this.displaySelect.StartIndex = 0;
            this.displaySelect.TabIndex = 60;
            this.displaySelect.SelectedIndexChanged += new System.EventHandler(this.displaySelect_SelectedIndexChanged);
            // 
            // audioSourceToggle
            // 
            this.audioSourceToggle.AutoSize = true;
            this.audioSourceToggle.Depth = 0;
            this.audioSourceToggle.Location = new System.Drawing.Point(517, 245);
            this.audioSourceToggle.Margin = new System.Windows.Forms.Padding(0);
            this.audioSourceToggle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.audioSourceToggle.MouseState = MaterialSkin.MouseState.HOVER;
            this.audioSourceToggle.Name = "audioSourceToggle";
            this.audioSourceToggle.Ripple = true;
            this.audioSourceToggle.Size = new System.Drawing.Size(99, 37);
            this.audioSourceToggle.TabIndex = 59;
            this.audioSourceToggle.Text = "Audio";
            this.audioSourceToggle.UseVisualStyleBackColor = true;
            this.audioSourceToggle.CheckedChanged += new System.EventHandler(this.audioSourceToggle_CheckedChanged);
            // 
            // autoClickToggle
            // 
            this.autoClickToggle.AutoSize = true;
            this.autoClickToggle.Depth = 0;
            this.autoClickToggle.Location = new System.Drawing.Point(207, 43);
            this.autoClickToggle.Margin = new System.Windows.Forms.Padding(0);
            this.autoClickToggle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.autoClickToggle.MouseState = MaterialSkin.MouseState.HOVER;
            this.autoClickToggle.Name = "autoClickToggle";
            this.autoClickToggle.Ripple = true;
            this.autoClickToggle.Size = new System.Drawing.Size(129, 37);
            this.autoClickToggle.TabIndex = 55;
            this.autoClickToggle.Text = "Auto Click";
            this.autoClickToggle.UseVisualStyleBackColor = true;
            this.autoClickToggle.CheckedChanged += new System.EventHandler(this.autoClickToggle_CheckedChanged);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel9.Location = new System.Drawing.Point(202, 197);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(243, 29);
            this.materialLabel9.TabIndex = 53;
            this.materialLabel9.Text = "Isolate Device Latency";
            // 
            // preTestToggle
            // 
            this.preTestToggle.AutoSize = true;
            this.preTestToggle.Depth = 0;
            this.preTestToggle.Location = new System.Drawing.Point(197, 226);
            this.preTestToggle.Margin = new System.Windows.Forms.Padding(0);
            this.preTestToggle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.preTestToggle.MouseState = MaterialSkin.MouseState.HOVER;
            this.preTestToggle.Name = "preTestToggle";
            this.preTestToggle.Ripple = true;
            this.preTestToggle.Size = new System.Drawing.Size(168, 37);
            this.preTestToggle.TabIndex = 52;
            this.preTestToggle.Text = "Pre-test System";
            this.preTestToggle.UseVisualStyleBackColor = true;
            this.preTestToggle.CheckedChanged += new System.EventHandler(this.preTestToggle_CheckedChanged);
            // 
            // gameExternalToggle
            // 
            this.gameExternalToggle.AutoSize = true;
            this.gameExternalToggle.Depth = 0;
            this.gameExternalToggle.Location = new System.Drawing.Point(517, 208);
            this.gameExternalToggle.Margin = new System.Windows.Forms.Padding(0);
            this.gameExternalToggle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.gameExternalToggle.MouseState = MaterialSkin.MouseState.HOVER;
            this.gameExternalToggle.Name = "gameExternalToggle";
            this.gameExternalToggle.Ripple = true;
            this.gameExternalToggle.Size = new System.Drawing.Size(164, 37);
            this.gameExternalToggle.TabIndex = 51;
            this.gameExternalToggle.Text = "Game/External";
            this.gameExternalToggle.UseVisualStyleBackColor = true;
            this.gameExternalToggle.CheckedChanged += new System.EventHandler(this.gameExternalToggle_CheckedChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(522, 114);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(129, 29);
            this.materialLabel2.TabIndex = 50;
            this.materialLabel2.Text = "Test Source";
            // 
            // directXToggle
            // 
            this.directXToggle.AutoSize = true;
            this.directXToggle.Checked = true;
            this.directXToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.directXToggle.Depth = 0;
            this.directXToggle.Location = new System.Drawing.Point(517, 143);
            this.directXToggle.Margin = new System.Windows.Forms.Padding(0);
            this.directXToggle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.directXToggle.MouseState = MaterialSkin.MouseState.HOVER;
            this.directXToggle.Name = "directXToggle";
            this.directXToggle.Ripple = true;
            this.directXToggle.Size = new System.Drawing.Size(174, 37);
            this.directXToggle.TabIndex = 49;
            this.directXToggle.Text = "DirectX Program";
            this.directXToggle.UseVisualStyleBackColor = true;
            this.directXToggle.CheckedChanged += new System.EventHandler(this.directXToggle_CheckedChanged);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel8.Location = new System.Drawing.Point(215, 14);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(141, 29);
            this.materialLabel8.TabIndex = 48;
            this.materialLabel8.Text = "Test Settings";
            // 
            // audioSensorToggle
            // 
            this.audioSensorToggle.AutoSize = true;
            this.audioSensorToggle.Depth = 0;
            this.audioSensorToggle.Location = new System.Drawing.Point(14, 235);
            this.audioSensorToggle.Margin = new System.Windows.Forms.Padding(0);
            this.audioSensorToggle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.audioSensorToggle.MouseState = MaterialSkin.MouseState.HOVER;
            this.audioSensorToggle.Name = "audioSensorToggle";
            this.audioSensorToggle.Ripple = true;
            this.audioSensorToggle.Size = new System.Drawing.Size(152, 37);
            this.audioSensorToggle.TabIndex = 47;
            this.audioSensorToggle.Text = "Audio Sensor";
            this.audioSensorToggle.UseVisualStyleBackColor = true;
            this.audioSensorToggle.CheckedChanged += new System.EventHandler(this.audioSensorToggle_CheckedChanged);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel7.Location = new System.Drawing.Point(17, 169);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(132, 29);
            this.materialLabel7.TabIndex = 46;
            this.materialLabel7.Text = "Sensor Type";
            // 
            // lightSensorToggle
            // 
            this.lightSensorToggle.AutoSize = true;
            this.lightSensorToggle.Checked = true;
            this.lightSensorToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lightSensorToggle.Depth = 0;
            this.lightSensorToggle.Location = new System.Drawing.Point(14, 198);
            this.lightSensorToggle.Margin = new System.Windows.Forms.Padding(0);
            this.lightSensorToggle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lightSensorToggle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lightSensorToggle.Name = "lightSensorToggle";
            this.lightSensorToggle.Ripple = true;
            this.lightSensorToggle.Size = new System.Drawing.Size(147, 37);
            this.lightSensorToggle.TabIndex = 45;
            this.lightSensorToggle.Text = "Light Sensor";
            this.lightSensorToggle.UseVisualStyleBackColor = true;
            this.lightSensorToggle.CheckedChanged += new System.EventHandler(this.lightSensorToggle_CheckedChanged);
            // 
            // pinTriggerToggle
            // 
            this.pinTriggerToggle.AutoSize = true;
            this.pinTriggerToggle.Depth = 0;
            this.pinTriggerToggle.Location = new System.Drawing.Point(14, 117);
            this.pinTriggerToggle.Margin = new System.Windows.Forms.Padding(0);
            this.pinTriggerToggle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.pinTriggerToggle.MouseState = MaterialSkin.MouseState.HOVER;
            this.pinTriggerToggle.Name = "pinTriggerToggle";
            this.pinTriggerToggle.Ripple = true;
            this.pinTriggerToggle.Size = new System.Drawing.Size(134, 37);
            this.pinTriggerToggle.TabIndex = 44;
            this.pinTriggerToggle.Text = "2 Pin Input";
            this.pinTriggerToggle.UseVisualStyleBackColor = true;
            this.pinTriggerToggle.CheckedChanged += new System.EventHandler(this.pinTriggerToggle_CheckedChanged);
            // 
            // audioTriggerToggle
            // 
            this.audioTriggerToggle.AutoSize = true;
            this.audioTriggerToggle.Depth = 0;
            this.audioTriggerToggle.Location = new System.Drawing.Point(14, 80);
            this.audioTriggerToggle.Margin = new System.Windows.Forms.Padding(0);
            this.audioTriggerToggle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.audioTriggerToggle.MouseState = MaterialSkin.MouseState.HOVER;
            this.audioTriggerToggle.Name = "audioTriggerToggle";
            this.audioTriggerToggle.Ripple = true;
            this.audioTriggerToggle.Size = new System.Drawing.Size(178, 37);
            this.audioTriggerToggle.TabIndex = 43;
            this.audioTriggerToggle.Text = "Audio Jack (Mic)";
            this.audioTriggerToggle.UseVisualStyleBackColor = true;
            this.audioTriggerToggle.CheckedChanged += new System.EventHandler(this.audioTriggerToggle_CheckedChanged);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel6.Location = new System.Drawing.Point(17, 14);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(133, 29);
            this.materialLabel6.TabIndex = 42;
            this.materialLabel6.Text = "Trigger Type";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.resultsViewBtn);
            this.materialCard2.Controls.Add(this.notesBox);
            this.materialCard2.Controls.Add(this.deviceNameBox);
            this.materialCard2.Controls.Add(this.startTestBtn);
            this.materialCard2.Controls.Add(this.debugBtn);
            this.materialCard2.Controls.Add(this.materialButton1);
            this.materialCard2.Controls.Add(this.helpBtn);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(70, 78);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(899, 136);
            this.materialCard2.TabIndex = 45;
            // 
            // resultsViewBtn
            // 
            this.resultsViewBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resultsViewBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.resultsViewBtn.Depth = 0;
            this.resultsViewBtn.HighEmphasis = true;
            this.resultsViewBtn.Icon = global::OSLTT.Properties.Resources.chart_bar_solid;
            this.resultsViewBtn.Location = new System.Drawing.Point(713, 13);
            this.resultsViewBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.resultsViewBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.resultsViewBtn.Name = "resultsViewBtn";
            this.resultsViewBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.resultsViewBtn.Size = new System.Drawing.Size(168, 36);
            this.resultsViewBtn.TabIndex = 57;
            this.resultsViewBtn.Text = "Results Viewer";
            this.resultsViewBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.resultsViewBtn.UseAccentColor = false;
            this.resultsViewBtn.UseVisualStyleBackColor = true;
            // 
            // notesBox
            // 
            this.notesBox.AnimateReadOnly = false;
            this.notesBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.notesBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.notesBox.Depth = 0;
            this.notesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.notesBox.HideSelection = true;
            this.notesBox.Hint = "Test Notes";
            this.notesBox.LeadingIcon = null;
            this.notesBox.Location = new System.Drawing.Point(14, 73);
            this.notesBox.MaxLength = 32767;
            this.notesBox.MouseState = MaterialSkin.MouseState.OUT;
            this.notesBox.Name = "notesBox";
            this.notesBox.PasswordChar = '\0';
            this.notesBox.PrefixSuffixText = null;
            this.notesBox.ReadOnly = false;
            this.notesBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.notesBox.SelectedText = "";
            this.notesBox.SelectionLength = 0;
            this.notesBox.SelectionStart = 0;
            this.notesBox.ShortcutsEnabled = true;
            this.notesBox.Size = new System.Drawing.Size(524, 48);
            this.notesBox.TabIndex = 5;
            this.notesBox.TabStop = false;
            this.notesBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.notesBox.TrailingIcon = null;
            this.notesBox.UseSystemPasswordChar = false;
            // 
            // deviceNameBox
            // 
            this.deviceNameBox.AnimateReadOnly = false;
            this.deviceNameBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deviceNameBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.deviceNameBox.Depth = 0;
            this.deviceNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.deviceNameBox.HideSelection = true;
            this.deviceNameBox.Hint = "Device Name";
            this.deviceNameBox.LeadingIcon = null;
            this.deviceNameBox.Location = new System.Drawing.Point(14, 13);
            this.deviceNameBox.MaxLength = 32767;
            this.deviceNameBox.MouseState = MaterialSkin.MouseState.OUT;
            this.deviceNameBox.Name = "deviceNameBox";
            this.deviceNameBox.PasswordChar = '\0';
            this.deviceNameBox.PrefixSuffixText = null;
            this.deviceNameBox.ReadOnly = false;
            this.deviceNameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deviceNameBox.SelectedText = "";
            this.deviceNameBox.SelectionLength = 0;
            this.deviceNameBox.SelectionStart = 0;
            this.deviceNameBox.ShortcutsEnabled = true;
            this.deviceNameBox.Size = new System.Drawing.Size(310, 48);
            this.deviceNameBox.TabIndex = 3;
            this.deviceNameBox.TabStop = false;
            this.deviceNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.deviceNameBox.TrailingIcon = null;
            this.deviceNameBox.UseSystemPasswordChar = false;
            // 
            // startTestBtn
            // 
            this.startTestBtn.AutoSize = false;
            this.startTestBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startTestBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.startTestBtn.Depth = 0;
            this.startTestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTestBtn.HighEmphasis = true;
            this.startTestBtn.Icon = global::OSLTT.Properties.Resources.play_solid;
            this.startTestBtn.Location = new System.Drawing.Point(703, 67);
            this.startTestBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.startTestBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.startTestBtn.Name = "startTestBtn";
            this.startTestBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.startTestBtn.Size = new System.Drawing.Size(178, 54);
            this.startTestBtn.TabIndex = 56;
            this.startTestBtn.Text = "Start Testing";
            this.startTestBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.startTestBtn.UseAccentColor = true;
            this.startTestBtn.UseVisualStyleBackColor = true;
            this.startTestBtn.Click += new System.EventHandler(this.startTestBtn_Click);
            // 
            // debugBtn
            // 
            this.debugBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.debugBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.debugBtn.Depth = 0;
            this.debugBtn.HighEmphasis = true;
            this.debugBtn.Icon = global::OSLTT.Properties.Resources.bug_solid;
            this.debugBtn.Location = new System.Drawing.Point(601, 13);
            this.debugBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.debugBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.debugBtn.Name = "debugBtn";
            this.debugBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.debugBtn.Size = new System.Drawing.Size(96, 36);
            this.debugBtn.TabIndex = 57;
            this.debugBtn.Text = "Debug";
            this.debugBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.debugBtn.UseAccentColor = false;
            this.debugBtn.UseVisualStyleBackColor = true;
            this.debugBtn.Click += new System.EventHandler(this.debugBtn_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = global::OSLTT.Properties.Resources.bug_solid;
            this.materialButton1.Location = new System.Drawing.Point(560, 80);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(126, 36);
            this.materialButton1.TabIndex = 58;
            this.materialButton1.Text = "(Dev) Test";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.helpBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.helpBtn.Depth = 0;
            this.helpBtn.HighEmphasis = true;
            this.helpBtn.Icon = global::OSLTT.Properties.Resources.circle_question_solid;
            this.helpBtn.Location = new System.Drawing.Point(497, 13);
            this.helpBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.helpBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.helpBtn.Size = new System.Drawing.Size(86, 36);
            this.helpBtn.TabIndex = 54;
            this.helpBtn.Text = "Help";
            this.helpBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.helpBtn.UseAccentColor = false;
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.MonitorsTab);
            this.materialTabControl1.Controls.Add(this.MiceKeyboardsTab);
            this.materialTabControl1.Controls.Add(this.GamesTab);
            this.materialTabControl1.Controls.Add(this.HeadsetsTab);
            this.materialTabControl1.Controls.Add(this.CustomTab1);
            this.materialTabControl1.Controls.Add(this.TestTab);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(70, 231);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(905, 397);
            this.materialTabControl1.TabIndex = 48;
            // 
            // MonitorsTab
            // 
            this.MonitorsTab.Controls.Add(this.settingsCard);
            this.MonitorsTab.ImageKey = "desktop-solid.png";
            this.MonitorsTab.Location = new System.Drawing.Point(4, 23);
            this.MonitorsTab.Name = "MonitorsTab";
            this.MonitorsTab.Padding = new System.Windows.Forms.Padding(3);
            this.MonitorsTab.Size = new System.Drawing.Size(897, 370);
            this.MonitorsTab.TabIndex = 0;
            this.MonitorsTab.Text = "Monitors";
            this.MonitorsTab.UseVisualStyleBackColor = true;
            // 
            // MiceKeyboardsTab
            // 
            this.MiceKeyboardsTab.Controls.Add(this.settingsPane1);
            this.MiceKeyboardsTab.ImageKey = "computer-mouse-solid.png";
            this.MiceKeyboardsTab.Location = new System.Drawing.Point(4, 23);
            this.MiceKeyboardsTab.Name = "MiceKeyboardsTab";
            this.MiceKeyboardsTab.Padding = new System.Windows.Forms.Padding(3);
            this.MiceKeyboardsTab.Size = new System.Drawing.Size(897, 370);
            this.MiceKeyboardsTab.TabIndex = 1;
            this.MiceKeyboardsTab.Text = "Mice & Keyboards";
            this.MiceKeyboardsTab.UseVisualStyleBackColor = true;
            // 
            // GamesTab
            // 
            this.GamesTab.ImageKey = "gamepad-solid.png";
            this.GamesTab.Location = new System.Drawing.Point(4, 23);
            this.GamesTab.Name = "GamesTab";
            this.GamesTab.Size = new System.Drawing.Size(897, 370);
            this.GamesTab.TabIndex = 2;
            this.GamesTab.Text = "Games";
            this.GamesTab.UseVisualStyleBackColor = true;
            // 
            // HeadsetsTab
            // 
            this.HeadsetsTab.ImageKey = "headset-solid.png";
            this.HeadsetsTab.Location = new System.Drawing.Point(4, 23);
            this.HeadsetsTab.Name = "HeadsetsTab";
            this.HeadsetsTab.Size = new System.Drawing.Size(897, 370);
            this.HeadsetsTab.TabIndex = 3;
            this.HeadsetsTab.Text = "Headsets";
            this.HeadsetsTab.UseVisualStyleBackColor = true;
            // 
            // CustomTab1
            // 
            this.CustomTab1.Location = new System.Drawing.Point(4, 23);
            this.CustomTab1.Name = "CustomTab1";
            this.CustomTab1.Size = new System.Drawing.Size(897, 370);
            this.CustomTab1.TabIndex = 4;
            this.CustomTab1.Text = "Custom";
            this.CustomTab1.UseVisualStyleBackColor = true;
            // 
            // TestTab
            // 
            this.TestTab.Controls.Add(this.typeTextCard);
            this.TestTab.Controls.Add(this.clickTestBox);
            this.TestTab.Location = new System.Drawing.Point(4, 23);
            this.TestTab.Name = "TestTab";
            this.TestTab.Size = new System.Drawing.Size(897, 370);
            this.TestTab.TabIndex = 5;
            this.TestTab.Text = "Test Tab";
            this.TestTab.UseVisualStyleBackColor = true;
            // 
            // typeTextCard
            // 
            this.typeTextCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.typeTextCard.Controls.Add(this.textTextBox);
            this.typeTextCard.Depth = 0;
            this.typeTextCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.typeTextCard.Location = new System.Drawing.Point(10, 427);
            this.typeTextCard.Margin = new System.Windows.Forms.Padding(14);
            this.typeTextCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.typeTextCard.Name = "typeTextCard";
            this.typeTextCard.Padding = new System.Windows.Forms.Padding(14);
            this.typeTextCard.Size = new System.Drawing.Size(691, 92);
            this.typeTextCard.TabIndex = 49;
            // 
            // textTextBox
            // 
            this.textTextBox.AnimateReadOnly = false;
            this.textTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textTextBox.Depth = 0;
            this.textTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textTextBox.HideSelection = true;
            this.textTextBox.Hint = "Type in here";
            this.textTextBox.LeadingIcon = null;
            this.textTextBox.Location = new System.Drawing.Point(69, 17);
            this.textTextBox.MaxLength = 32767;
            this.textTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.PasswordChar = '\0';
            this.textTextBox.PrefixSuffixText = null;
            this.textTextBox.ReadOnly = false;
            this.textTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textTextBox.SelectedText = "";
            this.textTextBox.SelectionLength = 0;
            this.textTextBox.SelectionStart = 0;
            this.textTextBox.ShortcutsEnabled = true;
            this.textTextBox.Size = new System.Drawing.Size(289, 48);
            this.textTextBox.TabIndex = 3;
            this.textTextBox.TabStop = false;
            this.textTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textTextBox.TrailingIcon = null;
            this.textTextBox.UseSystemPasswordChar = false;
            // 
            // clickTestBox
            // 
            this.clickTestBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clickTestBox.Controls.Add(this.materialLabel11);
            this.clickTestBox.Depth = 0;
            this.clickTestBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clickTestBox.Location = new System.Drawing.Point(10, 9);
            this.clickTestBox.Margin = new System.Windows.Forms.Padding(14);
            this.clickTestBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.clickTestBox.Name = "clickTestBox";
            this.clickTestBox.Padding = new System.Windows.Forms.Padding(14);
            this.clickTestBox.Size = new System.Drawing.Size(892, 410);
            this.clickTestBox.TabIndex = 48;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel11.Location = new System.Drawing.Point(185, 14);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(531, 29);
            this.materialLabel11.TabIndex = 1;
            this.materialLabel11.Text = "Click anywhere in this box for mouse click latency";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "headset-solid.png");
            this.imageList1.Images.SetKeyName(1, "gamepad-solid.png");
            this.imageList1.Images.SetKeyName(2, "desktop-solid.png");
            this.imageList1.Images.SetKeyName(3, "computer-mouse-solid.png");
            // 
            // settingsPane1
            // 
            this.settingsPane1.Location = new System.Drawing.Point(6, 3);
            this.settingsPane1.Name = "settingsPane1";
            this.settingsPane1.Size = new System.Drawing.Size(871, 325);
            this.settingsPane1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 588);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialDrawer1);
            this.Controls.Add(this.deviceStatusPanel);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.DrawerUseColors = true;
            this.Name = "Main";
            this.Text = "OSLTT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.deviceStatusPanel.ResumeLayout(false);
            this.deviceStatusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkImg)).EndInit();
            this.settingsCard.ResumeLayout(false);
            this.settingsCard.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.MonitorsTab.ResumeLayout(false);
            this.MiceKeyboardsTab.ResumeLayout(false);
            this.TestTab.ResumeLayout(false);
            this.typeTextCard.ResumeLayout(false);
            this.clickTestBox.ResumeLayout(false);
            this.clickTestBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox checkImg;
        private System.Windows.Forms.Panel deviceStatusPanel;
        private MaterialSkin.Controls.MaterialSwitch buttonTriggerToggle;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialLabel devStat;
        private MaterialSkin.Controls.MaterialComboBox clickCountSelect;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox timeBetweenSelect;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialCard settingsCard;
        private MaterialSkin.Controls.MaterialSwitch audioSensorToggle;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSwitch lightSensorToggle;
        private MaterialSkin.Controls.MaterialSwitch pinTriggerToggle;
        private MaterialSkin.Controls.MaterialSwitch audioTriggerToggle;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSwitch directXToggle;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialSwitch preTestToggle;
        private MaterialSkin.Controls.MaterialSwitch gameExternalToggle;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton helpBtn;
        private MaterialSkin.Controls.MaterialSwitch autoClickToggle;
        private MaterialSkin.Controls.MaterialButton startTestBtn;
        private MaterialSkin.Controls.MaterialLabel fwLbl;
        private MaterialSkin.Controls.MaterialLabel fwLblTitle;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialTextBox2 notesBox;
        private MaterialSkin.Controls.MaterialTextBox2 deviceNameBox;
        private MaterialSkin.Controls.MaterialButton debugBtn;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialSwitch audioSourceToggle;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialComboBox displaySelect;
        private MaterialSkin.Controls.MaterialSwitch MouseKeyboardToggle;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage MonitorsTab;
        private System.Windows.Forms.TabPage MiceKeyboardsTab;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage GamesTab;
        private System.Windows.Forms.TabPage HeadsetsTab;
        private System.Windows.Forms.TabPage CustomTab1;
        private System.Windows.Forms.TabPage TestTab;
        private MaterialSkin.Controls.MaterialCard clickTestBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialCard typeTextCard;
        private MaterialSkin.Controls.MaterialTextBox2 textTextBox;
        private MaterialSkin.Controls.MaterialButton resultsViewBtn;
        private SettingsPane settingsPane1;
    }
}

