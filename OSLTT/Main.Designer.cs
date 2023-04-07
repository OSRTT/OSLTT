﻿
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
            this.fwLbl = new System.Windows.Forms.Label();
            this.fwLblTitle = new System.Windows.Forms.Label();
            this.checkImg = new System.Windows.Forms.PictureBox();
            this.deviceStatusPanel = new System.Windows.Forms.Panel();
            this.devStat = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.audioPresetBtn = new MaterialSkin.Controls.MaterialButton();
            this.gamePresetBtn = new MaterialSkin.Controls.MaterialButton();
            this.micePresetBtn = new MaterialSkin.Controls.MaterialButton();
            this.monitorPresetBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonTriggerToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.clickCountSelect = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.timeBetweenSelect = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.settingsCard = new MaterialSkin.Controls.MaterialCard();
            this.helpBtn = new MaterialSkin.Controls.MaterialButton();
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
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.resultsViewBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.autoClickToggle = new MaterialSkin.Controls.MaterialSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.checkImg)).BeginInit();
            this.deviceStatusPanel.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.settingsCard.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // fwLbl
            // 
            this.fwLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fwLbl.Location = new System.Drawing.Point(486, 8);
            this.fwLbl.Name = "fwLbl";
            this.fwLbl.Size = new System.Drawing.Size(80, 25);
            this.fwLbl.TabIndex = 9;
            this.fwLbl.Text = "V0.00";
            this.fwLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fwLblTitle
            // 
            this.fwLblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fwLblTitle.Location = new System.Drawing.Point(440, 8);
            this.fwLblTitle.Name = "fwLblTitle";
            this.fwLblTitle.Size = new System.Drawing.Size(61, 25);
            this.fwLblTitle.TabIndex = 8;
            this.fwLblTitle.Text = "FW:";
            this.fwLblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkImg
            // 
            this.checkImg.ErrorImage = global::OSLTT.Properties.Resources.check;
            this.checkImg.Location = new System.Drawing.Point(184, 5);
            this.checkImg.Name = "checkImg";
            this.checkImg.Size = new System.Drawing.Size(58, 29);
            this.checkImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.checkImg.TabIndex = 7;
            this.checkImg.TabStop = false;
            // 
            // deviceStatusPanel
            // 
            this.deviceStatusPanel.BackColor = System.Drawing.Color.White;
            this.deviceStatusPanel.Controls.Add(this.devStat);
            this.deviceStatusPanel.Controls.Add(this.fwLbl);
            this.deviceStatusPanel.Controls.Add(this.fwLblTitle);
            this.deviceStatusPanel.Controls.Add(this.checkImg);
            this.deviceStatusPanel.Location = new System.Drawing.Point(201, 24);
            this.deviceStatusPanel.Name = "deviceStatusPanel";
            this.deviceStatusPanel.Size = new System.Drawing.Size(569, 40);
            this.deviceStatusPanel.TabIndex = 31;
            // 
            // devStat
            // 
            this.devStat.AutoSize = true;
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
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.audioPresetBtn);
            this.materialCard1.Controls.Add(this.gamePresetBtn);
            this.materialCard1.Controls.Add(this.micePresetBtn);
            this.materialCard1.Controls.Add(this.monitorPresetBtn);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(11, 81);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(547, 100);
            this.materialCard1.TabIndex = 39;
            // 
            // audioPresetBtn
            // 
            this.audioPresetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.audioPresetBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.audioPresetBtn.Depth = 0;
            this.audioPresetBtn.HighEmphasis = true;
            this.audioPresetBtn.Icon = null;
            this.audioPresetBtn.Location = new System.Drawing.Point(358, 49);
            this.audioPresetBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.audioPresetBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.audioPresetBtn.Name = "audioPresetBtn";
            this.audioPresetBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.audioPresetBtn.Size = new System.Drawing.Size(173, 36);
            this.audioPresetBtn.TabIndex = 42;
            this.audioPresetBtn.Text = "Headsets/Speakers";
            this.audioPresetBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.audioPresetBtn.UseAccentColor = false;
            this.audioPresetBtn.UseVisualStyleBackColor = true;
            this.audioPresetBtn.Click += new System.EventHandler(this.audioPresetBtn_Click);
            // 
            // gamePresetBtn
            // 
            this.gamePresetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gamePresetBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.gamePresetBtn.Depth = 0;
            this.gamePresetBtn.HighEmphasis = true;
            this.gamePresetBtn.Icon = null;
            this.gamePresetBtn.Location = new System.Drawing.Point(279, 49);
            this.gamePresetBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gamePresetBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.gamePresetBtn.Name = "gamePresetBtn";
            this.gamePresetBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.gamePresetBtn.Size = new System.Drawing.Size(71, 36);
            this.gamePresetBtn.TabIndex = 41;
            this.gamePresetBtn.Text = "Games";
            this.gamePresetBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.gamePresetBtn.UseAccentColor = false;
            this.gamePresetBtn.UseVisualStyleBackColor = true;
            this.gamePresetBtn.Click += new System.EventHandler(this.gamePresetBtn_Click);
            // 
            // micePresetBtn
            // 
            this.micePresetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.micePresetBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.micePresetBtn.Depth = 0;
            this.micePresetBtn.HighEmphasis = true;
            this.micePresetBtn.Icon = null;
            this.micePresetBtn.Location = new System.Drawing.Point(123, 49);
            this.micePresetBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.micePresetBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.micePresetBtn.Name = "micePresetBtn";
            this.micePresetBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.micePresetBtn.Size = new System.Drawing.Size(146, 36);
            this.micePresetBtn.TabIndex = 40;
            this.micePresetBtn.Text = "Mice/Keyboards";
            this.micePresetBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.micePresetBtn.UseAccentColor = false;
            this.micePresetBtn.UseVisualStyleBackColor = true;
            this.micePresetBtn.Click += new System.EventHandler(this.micePresetBtn_Click);
            // 
            // monitorPresetBtn
            // 
            this.monitorPresetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.monitorPresetBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.monitorPresetBtn.Depth = 0;
            this.monitorPresetBtn.HighEmphasis = true;
            this.monitorPresetBtn.Icon = null;
            this.monitorPresetBtn.Location = new System.Drawing.Point(18, 49);
            this.monitorPresetBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.monitorPresetBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.monitorPresetBtn.Name = "monitorPresetBtn";
            this.monitorPresetBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.monitorPresetBtn.Size = new System.Drawing.Size(96, 36);
            this.monitorPresetBtn.TabIndex = 39;
            this.monitorPresetBtn.Text = "Monitors";
            this.monitorPresetBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.monitorPresetBtn.UseAccentColor = false;
            this.monitorPresetBtn.UseVisualStyleBackColor = true;
            this.monitorPresetBtn.Click += new System.EventHandler(this.monitorPresetBtn_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(17, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(203, 29);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Preset Test Modes";
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
            this.clickCountSelect.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
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
            this.clickCountSelect.Location = new System.Drawing.Point(364, 76);
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
            this.materialLabel4.Location = new System.Drawing.Point(225, 96);
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
            this.timeBetweenSelect.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
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
            this.timeBetweenSelect.Location = new System.Drawing.Point(383, 133);
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
            this.materialLabel5.Location = new System.Drawing.Point(225, 150);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(147, 19);
            this.materialLabel5.TabIndex = 45;
            this.materialLabel5.Text = "Time Between Clicks";
            // 
            // settingsCard
            // 
            this.settingsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.settingsCard.Controls.Add(this.autoClickToggle);
            this.settingsCard.Controls.Add(this.helpBtn);
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
            this.settingsCard.Location = new System.Drawing.Point(11, 190);
            this.settingsCard.Margin = new System.Windows.Forms.Padding(14);
            this.settingsCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingsCard.Name = "settingsCard";
            this.settingsCard.Padding = new System.Windows.Forms.Padding(14);
            this.settingsCard.Size = new System.Drawing.Size(745, 286);
            this.settingsCard.TabIndex = 44;
            // 
            // helpBtn
            // 
            this.helpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.helpBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.helpBtn.Depth = 0;
            this.helpBtn.HighEmphasis = true;
            this.helpBtn.Icon = null;
            this.helpBtn.Location = new System.Drawing.Point(663, 236);
            this.helpBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.helpBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.helpBtn.Size = new System.Drawing.Size(64, 36);
            this.helpBtn.TabIndex = 54;
            this.helpBtn.Text = "?";
            this.helpBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.helpBtn.UseAccentColor = false;
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel9.Location = new System.Drawing.Point(211, 197);
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
            this.preTestToggle.Location = new System.Drawing.Point(206, 226);
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
            this.gameExternalToggle.Location = new System.Drawing.Point(530, 80);
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
            this.materialLabel2.Location = new System.Drawing.Point(535, 14);
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
            this.directXToggle.Location = new System.Drawing.Point(530, 43);
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
            this.materialLabel8.Location = new System.Drawing.Point(224, 14);
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
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.Location = new System.Drawing.Point(17, 14);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(159, 29);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Results Viewer";
            // 
            // resultsViewBtn
            // 
            this.resultsViewBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resultsViewBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.resultsViewBtn.Depth = 0;
            this.resultsViewBtn.HighEmphasis = true;
            this.resultsViewBtn.Icon = null;
            this.resultsViewBtn.Location = new System.Drawing.Point(18, 49);
            this.resultsViewBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.resultsViewBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.resultsViewBtn.Name = "resultsViewBtn";
            this.resultsViewBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.resultsViewBtn.Size = new System.Drawing.Size(140, 36);
            this.resultsViewBtn.TabIndex = 39;
            this.resultsViewBtn.Text = "Results Viewer";
            this.resultsViewBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.resultsViewBtn.UseAccentColor = false;
            this.resultsViewBtn.UseVisualStyleBackColor = true;
            this.resultsViewBtn.Click += new System.EventHandler(this.resultsViewBtn_Click);
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.resultsViewBtn);
            this.materialCard3.Controls.Add(this.materialLabel3);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(570, 81);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(186, 100);
            this.materialCard3.TabIndex = 42;
            // 
            // autoClickToggle
            // 
            this.autoClickToggle.AutoSize = true;
            this.autoClickToggle.Depth = 0;
            this.autoClickToggle.Location = new System.Drawing.Point(216, 43);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 495);
            this.Controls.Add(this.settingsCard);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialDrawer1);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.deviceStatusPanel);
            this.Name = "Main";
            this.Text = "OSLTT";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkImg)).EndInit();
            this.deviceStatusPanel.ResumeLayout(false);
            this.deviceStatusPanel.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.settingsCard.ResumeLayout(false);
            this.settingsCard.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox checkImg;
        private System.Windows.Forms.Label fwLbl;
        private System.Windows.Forms.Label fwLblTitle;
        private System.Windows.Forms.Panel deviceStatusPanel;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialSwitch buttonTriggerToggle;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialButton micePresetBtn;
        private MaterialSkin.Controls.MaterialButton monitorPresetBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel devStat;
        private MaterialSkin.Controls.MaterialButton gamePresetBtn;
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
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton resultsViewBtn;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialButton audioPresetBtn;
        private MaterialSkin.Controls.MaterialSwitch directXToggle;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialSwitch preTestToggle;
        private MaterialSkin.Controls.MaterialSwitch gameExternalToggle;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton helpBtn;
        private MaterialSkin.Controls.MaterialSwitch autoClickToggle;
    }
}

