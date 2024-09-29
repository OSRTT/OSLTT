
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
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.fwLbl = new MaterialSkin.Controls.MaterialLabel();
            this.fwLblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.devStat = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.deviceNameBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.notesBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.resultsViewBtn = new MaterialSkin.Controls.MaterialButton();
            this.startTestBtn = new MaterialSkin.Controls.MaterialButton();
            this.debugBtn = new MaterialSkin.Controls.MaterialButton();
            this.helpBtn = new MaterialSkin.Controls.MaterialButton();
            this.clickTestBox = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.gamepadPresetBtn = new MaterialSkin.Controls.MaterialButton();
            this.keyboardPresetBtn = new MaterialSkin.Controls.MaterialButton();
            this.customPresetBtn = new MaterialSkin.Controls.MaterialButton();
            this.headsetPresetBtn = new MaterialSkin.Controls.MaterialButton();
            this.gamePresetBtn = new MaterialSkin.Controls.MaterialButton();
            this.mouseClickPresetBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.monitorPresetBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.resultsFolderBtn = new MaterialSkin.Controls.MaterialButton();
            this.runPretestButton = new MaterialSkin.Controls.MaterialButton();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.hotkeySelect = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.settingsPane1 = new OSLTT.SettingsPane();
            this.consolesPresetBtn = new MaterialSkin.Controls.MaterialButton();
            this.deviceStatusPanel.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.clickTestBox.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceStatusPanel
            // 
            this.deviceStatusPanel.BackColor = System.Drawing.Color.White;
            this.deviceStatusPanel.Controls.Add(this.materialButton2);
            this.deviceStatusPanel.Controls.Add(this.fwLbl);
            this.deviceStatusPanel.Controls.Add(this.fwLblTitle);
            this.deviceStatusPanel.Controls.Add(this.devStat);
            this.deviceStatusPanel.Controls.Add(this.materialButton1);
            this.deviceStatusPanel.Location = new System.Drawing.Point(200, 24);
            this.deviceStatusPanel.Name = "deviceStatusPanel";
            this.deviceStatusPanel.Size = new System.Drawing.Size(831, 40);
            this.deviceStatusPanel.TabIndex = 31;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(260, 2);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(150, 36);
            this.materialButton2.TabIndex = 59;
            this.materialButton2.Text = "(Dev) Test Board";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // fwLbl
            // 
            this.fwLbl.AutoSize = true;
            this.fwLbl.BackColor = System.Drawing.Color.Transparent;
            this.fwLbl.Depth = 0;
            this.fwLbl.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.fwLbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.fwLbl.Location = new System.Drawing.Point(653, 8);
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
            this.fwLblTitle.Location = new System.Drawing.Point(612, 8);
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
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(418, 2);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(98, 36);
            this.materialButton1.TabIndex = 58;
            this.materialButton1.Text = "(Dev) Test";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
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
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.deviceNameBox);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 228);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(903, 77);
            this.materialCard2.TabIndex = 45;
            // 
            // deviceNameBox
            // 
            this.deviceNameBox.AnimateReadOnly = false;
            this.deviceNameBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deviceNameBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.deviceNameBox.Depth = 0;
            this.deviceNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.deviceNameBox.HideSelection = true;
            this.deviceNameBox.Hint = "Test Name - Device, Settings, etc";
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
            this.deviceNameBox.Size = new System.Drawing.Size(874, 48);
            this.deviceNameBox.TabIndex = 3;
            this.deviceNameBox.TabStop = false;
            this.deviceNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.deviceNameBox.TrailingIcon = null;
            this.deviceNameBox.UseSystemPasswordChar = false;
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
            this.notesBox.Location = new System.Drawing.Point(1009, 241);
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
            this.notesBox.Size = new System.Drawing.Size(305, 48);
            this.notesBox.TabIndex = 5;
            this.notesBox.TabStop = false;
            this.notesBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.notesBox.TrailingIcon = null;
            this.notesBox.UseSystemPasswordChar = false;
            this.notesBox.Visible = false;
            // 
            // resultsViewBtn
            // 
            this.resultsViewBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resultsViewBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.resultsViewBtn.Depth = 0;
            this.resultsViewBtn.HighEmphasis = true;
            this.resultsViewBtn.Icon = global::OSLTT.Properties.Resources.chart_bar_solid;
            this.resultsViewBtn.Location = new System.Drawing.Point(42, 17);
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
            this.resultsViewBtn.Click += new System.EventHandler(this.resultsViewBtn_Click);
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
            this.startTestBtn.Location = new System.Drawing.Point(65, 148);
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
            this.debugBtn.Location = new System.Drawing.Point(144, 13);
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
            // helpBtn
            // 
            this.helpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.helpBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.helpBtn.Depth = 0;
            this.helpBtn.HighEmphasis = true;
            this.helpBtn.Icon = global::OSLTT.Properties.Resources.circle_question_solid;
            this.helpBtn.Location = new System.Drawing.Point(18, 13);
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
            // clickTestBox
            // 
            this.clickTestBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clickTestBox.Controls.Add(this.materialLabel11);
            this.clickTestBox.Depth = 0;
            this.clickTestBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clickTestBox.Location = new System.Drawing.Point(14, 80);
            this.clickTestBox.Margin = new System.Windows.Forms.Padding(14);
            this.clickTestBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.clickTestBox.Name = "clickTestBox";
            this.clickTestBox.Padding = new System.Windows.Forms.Padding(14);
            this.clickTestBox.Size = new System.Drawing.Size(903, 578);
            this.clickTestBox.TabIndex = 48;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel11.Location = new System.Drawing.Point(324, 14);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(248, 29);
            this.materialLabel11.TabIndex = 1;
            this.materialLabel11.Text = "Click or type in this box";
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
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.consolesPresetBtn);
            this.materialCard1.Controls.Add(this.gamepadPresetBtn);
            this.materialCard1.Controls.Add(this.keyboardPresetBtn);
            this.materialCard1.Controls.Add(this.customPresetBtn);
            this.materialCard1.Controls.Add(this.headsetPresetBtn);
            this.materialCard1.Controls.Add(this.gamePresetBtn);
            this.materialCard1.Controls.Add(this.mouseClickPresetBtn);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.monitorPresetBtn);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 77);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(903, 140);
            this.materialCard1.TabIndex = 58;
            // 
            // gamepadPresetBtn
            // 
            this.gamepadPresetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gamepadPresetBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.gamepadPresetBtn.Depth = 0;
            this.gamepadPresetBtn.HighEmphasis = true;
            this.gamepadPresetBtn.Icon = global::OSLTT.Properties.Resources.gamepad_solid;
            this.gamepadPresetBtn.Location = new System.Drawing.Point(479, 47);
            this.gamepadPresetBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gamepadPresetBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.gamepadPresetBtn.Name = "gamepadPresetBtn";
            this.gamepadPresetBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.gamepadPresetBtn.Size = new System.Drawing.Size(119, 36);
            this.gamepadPresetBtn.TabIndex = 64;
            this.gamepadPresetBtn.Text = "Gamepad";
            this.gamepadPresetBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.gamepadPresetBtn.UseAccentColor = false;
            this.gamepadPresetBtn.UseVisualStyleBackColor = true;
            this.gamepadPresetBtn.Click += new System.EventHandler(this.gamepadPresetBtn_Click);
            // 
            // keyboardPresetBtn
            // 
            this.keyboardPresetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.keyboardPresetBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.keyboardPresetBtn.Depth = 0;
            this.keyboardPresetBtn.HighEmphasis = true;
            this.keyboardPresetBtn.Icon = global::OSLTT.Properties.Resources.keyboard_solid;
            this.keyboardPresetBtn.Location = new System.Drawing.Point(331, 47);
            this.keyboardPresetBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.keyboardPresetBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.keyboardPresetBtn.Name = "keyboardPresetBtn";
            this.keyboardPresetBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.keyboardPresetBtn.Size = new System.Drawing.Size(124, 36);
            this.keyboardPresetBtn.TabIndex = 63;
            this.keyboardPresetBtn.Text = "Keyboard";
            this.keyboardPresetBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.keyboardPresetBtn.UseAccentColor = false;
            this.keyboardPresetBtn.UseVisualStyleBackColor = true;
            this.keyboardPresetBtn.Click += new System.EventHandler(this.keyboardPresetBtn_Click);
            // 
            // customPresetBtn
            // 
            this.customPresetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.customPresetBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.customPresetBtn.Depth = 0;
            this.customPresetBtn.HighEmphasis = true;
            this.customPresetBtn.Icon = global::OSLTT.Properties.Resources.wrench_solid;
            this.customPresetBtn.Location = new System.Drawing.Point(165, 93);
            this.customPresetBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.customPresetBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.customPresetBtn.Name = "customPresetBtn";
            this.customPresetBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.customPresetBtn.Size = new System.Drawing.Size(109, 36);
            this.customPresetBtn.TabIndex = 62;
            this.customPresetBtn.Text = "Custom";
            this.customPresetBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.customPresetBtn.UseAccentColor = false;
            this.customPresetBtn.UseVisualStyleBackColor = true;
            this.customPresetBtn.Click += new System.EventHandler(this.customPresetBtn_Click);
            // 
            // headsetPresetBtn
            // 
            this.headsetPresetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.headsetPresetBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.headsetPresetBtn.Depth = 0;
            this.headsetPresetBtn.HighEmphasis = true;
            this.headsetPresetBtn.Icon = global::OSLTT.Properties.Resources.headset_solid;
            this.headsetPresetBtn.Location = new System.Drawing.Point(751, 47);
            this.headsetPresetBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.headsetPresetBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.headsetPresetBtn.Name = "headsetPresetBtn";
            this.headsetPresetBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.headsetPresetBtn.Size = new System.Drawing.Size(123, 36);
            this.headsetPresetBtn.TabIndex = 61;
            this.headsetPresetBtn.Text = "Headsets";
            this.headsetPresetBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.headsetPresetBtn.UseAccentColor = false;
            this.headsetPresetBtn.UseVisualStyleBackColor = true;
            this.headsetPresetBtn.Click += new System.EventHandler(this.headsetPresetBtn_Click);
            // 
            // gamePresetBtn
            // 
            this.gamePresetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gamePresetBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.gamePresetBtn.Depth = 0;
            this.gamePresetBtn.HighEmphasis = true;
            this.gamePresetBtn.Icon = global::OSLTT.Properties.Resources.gamepad_solid;
            this.gamePresetBtn.Location = new System.Drawing.Point(626, 47);
            this.gamePresetBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gamePresetBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.gamePresetBtn.Name = "gamePresetBtn";
            this.gamePresetBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.gamePresetBtn.Size = new System.Drawing.Size(99, 36);
            this.gamePresetBtn.TabIndex = 60;
            this.gamePresetBtn.Text = "Games";
            this.gamePresetBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.gamePresetBtn.UseAccentColor = false;
            this.gamePresetBtn.UseVisualStyleBackColor = true;
            this.gamePresetBtn.Click += new System.EventHandler(this.gamePresetBtn_Click);
            // 
            // mouseClickPresetBtn
            // 
            this.mouseClickPresetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mouseClickPresetBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mouseClickPresetBtn.Depth = 0;
            this.mouseClickPresetBtn.HighEmphasis = true;
            this.mouseClickPresetBtn.Icon = global::OSLTT.Properties.Resources.computer_mouse_solid;
            this.mouseClickPresetBtn.Location = new System.Drawing.Point(165, 47);
            this.mouseClickPresetBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mouseClickPresetBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.mouseClickPresetBtn.Name = "mouseClickPresetBtn";
            this.mouseClickPresetBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mouseClickPresetBtn.Size = new System.Drawing.Size(144, 36);
            this.mouseClickPresetBtn.TabIndex = 59;
            this.mouseClickPresetBtn.Text = "Mouse Click";
            this.mouseClickPresetBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mouseClickPresetBtn.UseAccentColor = false;
            this.mouseClickPresetBtn.UseVisualStyleBackColor = true;
            this.mouseClickPresetBtn.Click += new System.EventHandler(this.miceKeyboardPresetBtn_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(17, 12);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(150, 29);
            this.materialLabel1.TabIndex = 58;
            this.materialLabel1.Text = "Preset Modes";
            // 
            // monitorPresetBtn
            // 
            this.monitorPresetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.monitorPresetBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.monitorPresetBtn.Depth = 0;
            this.monitorPresetBtn.HighEmphasis = true;
            this.monitorPresetBtn.Icon = global::OSLTT.Properties.Resources.desktop_solid;
            this.monitorPresetBtn.Location = new System.Drawing.Point(14, 47);
            this.monitorPresetBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.monitorPresetBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.monitorPresetBtn.Name = "monitorPresetBtn";
            this.monitorPresetBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.monitorPresetBtn.Size = new System.Drawing.Size(124, 36);
            this.monitorPresetBtn.TabIndex = 57;
            this.monitorPresetBtn.Text = "Monitors";
            this.monitorPresetBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.monitorPresetBtn.UseAccentColor = false;
            this.monitorPresetBtn.UseVisualStyleBackColor = true;
            this.monitorPresetBtn.Click += new System.EventHandler(this.monitorPresetBtn_Click);
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.resultsFolderBtn);
            this.materialCard3.Controls.Add(this.resultsViewBtn);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(648, 389);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(258, 118);
            this.materialCard3.TabIndex = 60;
            // 
            // resultsFolderBtn
            // 
            this.resultsFolderBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resultsFolderBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.resultsFolderBtn.Depth = 0;
            this.resultsFolderBtn.HighEmphasis = true;
            this.resultsFolderBtn.Icon = global::OSLTT.Properties.Resources.folder_solid;
            this.resultsFolderBtn.Location = new System.Drawing.Point(42, 67);
            this.resultsFolderBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.resultsFolderBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.resultsFolderBtn.Name = "resultsFolderBtn";
            this.resultsFolderBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.resultsFolderBtn.Size = new System.Drawing.Size(169, 36);
            this.resultsFolderBtn.TabIndex = 58;
            this.resultsFolderBtn.Text = "Results Folder";
            this.resultsFolderBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.resultsFolderBtn.UseAccentColor = false;
            this.resultsFolderBtn.UseVisualStyleBackColor = true;
            this.resultsFolderBtn.Click += new System.EventHandler(this.resultsFolderBtn_Click);
            // 
            // runPretestButton
            // 
            this.runPretestButton.AutoSize = false;
            this.runPretestButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.runPretestButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.runPretestButton.Depth = 0;
            this.runPretestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runPretestButton.HighEmphasis = true;
            this.runPretestButton.Icon = null;
            this.runPretestButton.Location = new System.Drawing.Point(120, 82);
            this.runPretestButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.runPretestButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.runPretestButton.Name = "runPretestButton";
            this.runPretestButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.runPretestButton.Size = new System.Drawing.Size(123, 54);
            this.runPretestButton.TabIndex = 56;
            this.runPretestButton.Text = "Run Pretest";
            this.runPretestButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.runPretestButton.UseAccentColor = true;
            this.runPretestButton.UseVisualStyleBackColor = true;
            this.runPretestButton.Click += new System.EventHandler(this.runPretestButton_Click);
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.runPretestButton);
            this.materialCard5.Controls.Add(this.startTestBtn);
            this.materialCard5.Controls.Add(this.hotkeySelect);
            this.materialCard5.Controls.Add(this.materialLabel9);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(648, 519);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(258, 219);
            this.materialCard5.TabIndex = 77;
            // 
            // hotkeySelect
            // 
            this.hotkeySelect.AutoResize = false;
            this.hotkeySelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hotkeySelect.Depth = 0;
            this.hotkeySelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.hotkeySelect.DropDownHeight = 174;
            this.hotkeySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hotkeySelect.DropDownWidth = 121;
            this.hotkeySelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.hotkeySelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hotkeySelect.FormattingEnabled = true;
            this.hotkeySelect.IntegralHeight = false;
            this.hotkeySelect.ItemHeight = 43;
            this.hotkeySelect.Location = new System.Drawing.Point(109, 17);
            this.hotkeySelect.MaxDropDownItems = 4;
            this.hotkeySelect.MouseState = MaterialSkin.MouseState.OUT;
            this.hotkeySelect.Name = "hotkeySelect";
            this.hotkeySelect.Size = new System.Drawing.Size(134, 49);
            this.hotkeySelect.StartIndex = 0;
            this.hotkeySelect.TabIndex = 67;
            this.hotkeySelect.SelectedIndexChanged += new System.EventHandler(this.hotkeySelect_SelectedIndexChanged);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel9.Location = new System.Drawing.Point(13, 23);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(76, 29);
            this.materialLabel9.TabIndex = 66;
            this.materialLabel9.Text = "Hotkey";
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.helpBtn);
            this.materialCard4.Controls.Add(this.debugBtn);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(648, 317);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(258, 60);
            this.materialCard4.TabIndex = 61;
            // 
            // settingsPane1
            // 
            this.settingsPane1.Location = new System.Drawing.Point(21, 310);
            this.settingsPane1.Name = "settingsPane1";
            this.settingsPane1.Size = new System.Drawing.Size(623, 458);
            this.settingsPane1.TabIndex = 59;
            // 
            // consolesPresetBtn
            // 
            this.consolesPresetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.consolesPresetBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.consolesPresetBtn.Depth = 0;
            this.consolesPresetBtn.HighEmphasis = true;
            this.consolesPresetBtn.Icon = global::OSLTT.Properties.Resources.gamepad_solid;
            this.consolesPresetBtn.Location = new System.Drawing.Point(14, 93);
            this.consolesPresetBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.consolesPresetBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.consolesPresetBtn.Name = "consolesPresetBtn";
            this.consolesPresetBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.consolesPresetBtn.Size = new System.Drawing.Size(124, 36);
            this.consolesPresetBtn.TabIndex = 65;
            this.consolesPresetBtn.Text = "Consoles";
            this.consolesPresetBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.consolesPresetBtn.UseAccentColor = false;
            this.consolesPresetBtn.UseVisualStyleBackColor = true;
            this.consolesPresetBtn.Click += new System.EventHandler(this.consolesPresetBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 755);
            this.Controls.Add(this.notesBox);
            this.Controls.Add(this.materialCard5);
            this.Controls.Add(this.settingsPane1);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard4);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialDrawer1);
            this.Controls.Add(this.deviceStatusPanel);
            this.Controls.Add(this.clickTestBox);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerUseColors = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "OSLTT V";
            this.Load += new System.EventHandler(this.Main_Load);
            this.deviceStatusPanel.ResumeLayout(false);
            this.deviceStatusPanel.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.clickTestBox.ResumeLayout(false);
            this.clickTestBox.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel deviceStatusPanel;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialLabel devStat;
        private MaterialSkin.Controls.MaterialButton helpBtn;
        private MaterialSkin.Controls.MaterialButton startTestBtn;
        private MaterialSkin.Controls.MaterialLabel fwLbl;
        private MaterialSkin.Controls.MaterialLabel fwLblTitle;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialTextBox2 notesBox;
        private MaterialSkin.Controls.MaterialTextBox2 deviceNameBox;
        private MaterialSkin.Controls.MaterialButton debugBtn;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialCard clickTestBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialButton resultsViewBtn;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton monitorPresetBtn;
        private SettingsPane settingsPane1;
        private MaterialSkin.Controls.MaterialButton headsetPresetBtn;
        private MaterialSkin.Controls.MaterialButton gamePresetBtn;
        private MaterialSkin.Controls.MaterialButton mouseClickPresetBtn;
        private MaterialSkin.Controls.MaterialButton customPresetBtn;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialButton runPretestButton;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialComboBox hotkeySelect;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton resultsFolderBtn;
        private MaterialSkin.Controls.MaterialButton gamepadPresetBtn;
        private MaterialSkin.Controls.MaterialButton keyboardPresetBtn;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialButton consolesPresetBtn;
    }
}

