
namespace OSLTT
{
    partial class SettingsPane
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.settingsCard = new MaterialSkin.Controls.MaterialCard();
            this.MouseKeyboardToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.displaySelect = new MaterialSkin.Controls.MaterialComboBox();
            this.audioSourceToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.autoClickToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.preTestToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.gameExternalToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.directXToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.timeBetweenSelect = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.audioSensorToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.clickCountSelect = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lightSensorToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.pinTriggerToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.audioTriggerToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonTriggerToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.clickTrackingToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.settingsCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsCard
            // 
            this.settingsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.settingsCard.Controls.Add(this.materialLabel1);
            this.settingsCard.Controls.Add(this.clickTrackingToggle);
            this.settingsCard.Controls.Add(this.MouseKeyboardToggle);
            this.settingsCard.Controls.Add(this.materialLabel10);
            this.settingsCard.Controls.Add(this.displaySelect);
            this.settingsCard.Controls.Add(this.audioSourceToggle);
            this.settingsCard.Controls.Add(this.autoClickToggle);
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
            this.settingsCard.Location = new System.Drawing.Point(2, 2);
            this.settingsCard.Margin = new System.Windows.Forms.Padding(14);
            this.settingsCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingsCard.Name = "settingsCard";
            this.settingsCard.Padding = new System.Windows.Forms.Padding(14);
            this.settingsCard.Size = new System.Drawing.Size(883, 320);
            this.settingsCard.TabIndex = 45;
            // 
            // MouseKeyboardToggle
            // 
            this.MouseKeyboardToggle.AutoSize = true;
            this.MouseKeyboardToggle.Depth = 0;
            this.MouseKeyboardToggle.Location = new System.Drawing.Point(622, 173);
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
            this.materialLabel10.Location = new System.Drawing.Point(627, 13);
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
            this.displaySelect.Location = new System.Drawing.Point(632, 48);
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
            this.audioSourceToggle.Location = new System.Drawing.Point(622, 244);
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
            this.autoClickToggle.Location = new System.Drawing.Point(260, 42);
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
            // preTestToggle
            // 
            this.preTestToggle.AutoSize = true;
            this.preTestToggle.Depth = 0;
            this.preTestToggle.Location = new System.Drawing.Point(260, 234);
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
            this.gameExternalToggle.Location = new System.Drawing.Point(622, 207);
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
            this.materialLabel2.Location = new System.Drawing.Point(627, 113);
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
            this.directXToggle.Location = new System.Drawing.Point(622, 142);
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
            this.materialLabel8.Location = new System.Drawing.Point(268, 13);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(141, 29);
            this.materialLabel8.TabIndex = 48;
            this.materialLabel8.Text = "Test Settings";
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
            this.timeBetweenSelect.Location = new System.Drawing.Point(427, 132);
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
            this.materialLabel5.Location = new System.Drawing.Point(269, 149);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(147, 19);
            this.materialLabel5.TabIndex = 45;
            this.materialLabel5.Text = "Time Between Clicks";
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
            this.clickCountSelect.Location = new System.Drawing.Point(408, 75);
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
            this.materialLabel4.Location = new System.Drawing.Point(269, 95);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(122, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Number of Clicks";
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
            // clickTrackingToggle
            // 
            this.clickTrackingToggle.AutoSize = true;
            this.clickTrackingToggle.Depth = 0;
            this.clickTrackingToggle.Location = new System.Drawing.Point(14, 272);
            this.clickTrackingToggle.Margin = new System.Windows.Forms.Padding(0);
            this.clickTrackingToggle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.clickTrackingToggle.MouseState = MaterialSkin.MouseState.HOVER;
            this.clickTrackingToggle.Name = "clickTrackingToggle";
            this.clickTrackingToggle.Ripple = true;
            this.clickTrackingToggle.Size = new System.Drawing.Size(168, 37);
            this.clickTrackingToggle.TabIndex = 63;
            this.clickTrackingToggle.Text = "Click/Keystroke";
            this.clickTrackingToggle.UseVisualStyleBackColor = true;
            this.clickTrackingToggle.CheckedChanged += new System.EventHandler(this.clickTrackingToggle_CheckedChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(267, 205);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(249, 29);
            this.materialLabel1.TabIndex = 64;
            this.materialLabel1.Text = "Isolate System Latency";
            // 
            // SettingsPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.settingsCard);
            this.Name = "SettingsPane";
            this.Size = new System.Drawing.Size(887, 324);
            this.settingsCard.ResumeLayout(false);
            this.settingsCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard settingsCard;
        private MaterialSkin.Controls.MaterialSwitch MouseKeyboardToggle;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialComboBox displaySelect;
        private MaterialSkin.Controls.MaterialSwitch audioSourceToggle;
        private MaterialSkin.Controls.MaterialSwitch autoClickToggle;
        private MaterialSkin.Controls.MaterialSwitch preTestToggle;
        private MaterialSkin.Controls.MaterialSwitch gameExternalToggle;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSwitch directXToggle;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialComboBox timeBetweenSelect;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSwitch audioSensorToggle;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialComboBox clickCountSelect;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSwitch lightSensorToggle;
        private MaterialSkin.Controls.MaterialSwitch pinTriggerToggle;
        private MaterialSkin.Controls.MaterialSwitch audioTriggerToggle;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSwitch buttonTriggerToggle;
        private MaterialSkin.Controls.MaterialSwitch clickTrackingToggle;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
