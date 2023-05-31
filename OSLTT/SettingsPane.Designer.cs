
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
            this.displayCard = new MaterialSkin.Controls.MaterialCard();
            this.refreshMonitorsBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.displaySelect = new MaterialSkin.Controls.MaterialComboBox();
            this.sensorCard = new MaterialSkin.Controls.MaterialCard();
            this.clickKeypressRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.audioSensorRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.lightSensorRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.settingsCard = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.clickCountSelect = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.autoClickToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.timeBetweenSelect = new MaterialSkin.Controls.MaterialComboBox();
            this.preTestToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.triggerCard = new MaterialSkin.Controls.MaterialCard();
            this.twoPinRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.audioTriggerRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.buttonTriggerRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.sourceCard = new MaterialSkin.Controls.MaterialCard();
            this.audioSourceRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.gameExternalRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.mouseKeyboardRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.DirectXRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.displayCard.SuspendLayout();
            this.sensorCard.SuspendLayout();
            this.settingsCard.SuspendLayout();
            this.triggerCard.SuspendLayout();
            this.sourceCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayCard
            // 
            this.displayCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.displayCard.Controls.Add(this.refreshMonitorsBtn);
            this.displayCard.Controls.Add(this.materialLabel10);
            this.displayCard.Controls.Add(this.displaySelect);
            this.displayCard.Depth = 0;
            this.displayCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.displayCard.Location = new System.Drawing.Point(604, 7);
            this.displayCard.Margin = new System.Windows.Forms.Padding(14);
            this.displayCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.displayCard.Name = "displayCard";
            this.displayCard.Padding = new System.Windows.Forms.Padding(14);
            this.displayCard.Size = new System.Drawing.Size(242, 123);
            this.displayCard.TabIndex = 77;
            // 
            // refreshMonitorsBtn
            // 
            this.refreshMonitorsBtn.AutoSize = false;
            this.refreshMonitorsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.refreshMonitorsBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.refreshMonitorsBtn.Depth = 0;
            this.refreshMonitorsBtn.HighEmphasis = true;
            this.refreshMonitorsBtn.Icon = global::OSLTT.Properties.Resources.arrow_rotate_right;
            this.refreshMonitorsBtn.Location = new System.Drawing.Point(185, 11);
            this.refreshMonitorsBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.refreshMonitorsBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.refreshMonitorsBtn.Name = "refreshMonitorsBtn";
            this.refreshMonitorsBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.refreshMonitorsBtn.Size = new System.Drawing.Size(40, 36);
            this.refreshMonitorsBtn.TabIndex = 62;
            this.refreshMonitorsBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.refreshMonitorsBtn.UseAccentColor = false;
            this.refreshMonitorsBtn.UseVisualStyleBackColor = true;
            this.refreshMonitorsBtn.Click += new System.EventHandler(this.refreshMonitorsBtn_Click);
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel10.Location = new System.Drawing.Point(12, 13);
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
            this.displaySelect.Location = new System.Drawing.Point(17, 57);
            this.displaySelect.MaxDropDownItems = 4;
            this.displaySelect.MouseState = MaterialSkin.MouseState.OUT;
            this.displaySelect.Name = "displaySelect";
            this.displaySelect.Size = new System.Drawing.Size(208, 49);
            this.displaySelect.StartIndex = 0;
            this.displaySelect.TabIndex = 60;
            this.displaySelect.SelectedIndexChanged += new System.EventHandler(this.displaySelect_SelectedIndexChanged);
            // 
            // sensorCard
            // 
            this.sensorCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sensorCard.Controls.Add(this.clickKeypressRadio);
            this.sensorCard.Controls.Add(this.audioSensorRadio);
            this.sensorCard.Controls.Add(this.lightSensorRadio);
            this.sensorCard.Controls.Add(this.materialLabel1);
            this.sensorCard.Depth = 0;
            this.sensorCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sensorCard.Location = new System.Drawing.Point(4, 191);
            this.sensorCard.Margin = new System.Windows.Forms.Padding(14);
            this.sensorCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.sensorCard.Name = "sensorCard";
            this.sensorCard.Padding = new System.Windows.Forms.Padding(14);
            this.sensorCard.Size = new System.Drawing.Size(195, 169);
            this.sensorCard.TabIndex = 75;
            // 
            // clickKeypressRadio
            // 
            this.clickKeypressRadio.AutoSize = true;
            this.clickKeypressRadio.Depth = 0;
            this.clickKeypressRadio.Location = new System.Drawing.Point(14, 123);
            this.clickKeypressRadio.Margin = new System.Windows.Forms.Padding(0);
            this.clickKeypressRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.clickKeypressRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.clickKeypressRadio.Name = "clickKeypressRadio";
            this.clickKeypressRadio.Ripple = true;
            this.clickKeypressRadio.Size = new System.Drawing.Size(164, 37);
            this.clickKeypressRadio.TabIndex = 69;
            this.clickKeypressRadio.TabStop = true;
            this.clickKeypressRadio.Text = "Clicks/Keypresses";
            this.clickKeypressRadio.UseVisualStyleBackColor = true;
            this.clickKeypressRadio.CheckedChanged += new System.EventHandler(this.clickKeypressRadio_CheckedChanged);
            // 
            // audioSensorRadio
            // 
            this.audioSensorRadio.AutoSize = true;
            this.audioSensorRadio.Depth = 0;
            this.audioSensorRadio.Location = new System.Drawing.Point(14, 86);
            this.audioSensorRadio.Margin = new System.Windows.Forms.Padding(0);
            this.audioSensorRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.audioSensorRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.audioSensorRadio.Name = "audioSensorRadio";
            this.audioSensorRadio.Ripple = true;
            this.audioSensorRadio.Size = new System.Drawing.Size(129, 37);
            this.audioSensorRadio.TabIndex = 68;
            this.audioSensorRadio.TabStop = true;
            this.audioSensorRadio.Text = "Audio Sensor";
            this.audioSensorRadio.UseVisualStyleBackColor = true;
            this.audioSensorRadio.CheckedChanged += new System.EventHandler(this.audioSensorRadio_CheckedChanged);
            // 
            // lightSensorRadio
            // 
            this.lightSensorRadio.AutoSize = true;
            this.lightSensorRadio.Checked = true;
            this.lightSensorRadio.Depth = 0;
            this.lightSensorRadio.Location = new System.Drawing.Point(14, 49);
            this.lightSensorRadio.Margin = new System.Windows.Forms.Padding(0);
            this.lightSensorRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lightSensorRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lightSensorRadio.Name = "lightSensorRadio";
            this.lightSensorRadio.Ripple = true;
            this.lightSensorRadio.Size = new System.Drawing.Size(124, 37);
            this.lightSensorRadio.TabIndex = 67;
            this.lightSensorRadio.TabStop = true;
            this.lightSensorRadio.Text = "Light Sensor";
            this.lightSensorRadio.UseVisualStyleBackColor = true;
            this.lightSensorRadio.CheckedChanged += new System.EventHandler(this.lightSensorRadio_CheckedChanged);
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
            this.materialLabel1.Size = new System.Drawing.Size(132, 29);
            this.materialLabel1.TabIndex = 66;
            this.materialLabel1.Text = "Sensor Type";
            // 
            // settingsCard
            // 
            this.settingsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.settingsCard.Controls.Add(this.materialLabel8);
            this.settingsCard.Controls.Add(this.materialLabel4);
            this.settingsCard.Controls.Add(this.clickCountSelect);
            this.settingsCard.Controls.Add(this.materialLabel5);
            this.settingsCard.Controls.Add(this.autoClickToggle);
            this.settingsCard.Controls.Add(this.timeBetweenSelect);
            this.settingsCard.Controls.Add(this.preTestToggle);
            this.settingsCard.Controls.Add(this.materialLabel9);
            this.settingsCard.Depth = 0;
            this.settingsCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settingsCard.Location = new System.Drawing.Point(232, 7);
            this.settingsCard.Margin = new System.Windows.Forms.Padding(14);
            this.settingsCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingsCard.Name = "settingsCard";
            this.settingsCard.Padding = new System.Windows.Forms.Padding(14);
            this.settingsCard.Size = new System.Drawing.Size(340, 280);
            this.settingsCard.TabIndex = 73;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel8.Location = new System.Drawing.Point(28, 14);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(141, 29);
            this.materialLabel8.TabIndex = 48;
            this.materialLabel8.Text = "Test Settings";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(30, 96);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(122, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Number of Clicks";
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
            this.clickCountSelect.Location = new System.Drawing.Point(169, 76);
            this.clickCountSelect.MaxDropDownItems = 4;
            this.clickCountSelect.MouseState = MaterialSkin.MouseState.OUT;
            this.clickCountSelect.Name = "clickCountSelect";
            this.clickCountSelect.Size = new System.Drawing.Size(140, 49);
            this.clickCountSelect.StartIndex = 0;
            this.clickCountSelect.TabIndex = 44;
            this.clickCountSelect.SelectedIndexChanged += new System.EventHandler(this.clickCountSelect_SelectedIndexChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(30, 150);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(147, 19);
            this.materialLabel5.TabIndex = 45;
            this.materialLabel5.Text = "Time Between Clicks";
            // 
            // autoClickToggle
            // 
            this.autoClickToggle.AutoSize = true;
            this.autoClickToggle.Depth = 0;
            this.autoClickToggle.Location = new System.Drawing.Point(23, 43);
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
            this.timeBetweenSelect.Location = new System.Drawing.Point(188, 133);
            this.timeBetweenSelect.MaxDropDownItems = 4;
            this.timeBetweenSelect.MouseState = MaterialSkin.MouseState.OUT;
            this.timeBetweenSelect.Name = "timeBetweenSelect";
            this.timeBetweenSelect.Size = new System.Drawing.Size(121, 49);
            this.timeBetweenSelect.StartIndex = 0;
            this.timeBetweenSelect.TabIndex = 46;
            this.timeBetweenSelect.SelectedIndexChanged += new System.EventHandler(this.timeBetweenSelect_SelectedIndexChanged);
            // 
            // preTestToggle
            // 
            this.preTestToggle.AutoSize = true;
            this.preTestToggle.Depth = 0;
            this.preTestToggle.Location = new System.Drawing.Point(23, 226);
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
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel9.Location = new System.Drawing.Point(28, 196);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(243, 29);
            this.materialLabel9.TabIndex = 53;
            this.materialLabel9.Text = "Isolate Device Latency";
            // 
            // triggerCard
            // 
            this.triggerCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.triggerCard.Controls.Add(this.twoPinRadio);
            this.triggerCard.Controls.Add(this.audioTriggerRadio);
            this.triggerCard.Controls.Add(this.buttonTriggerRadio);
            this.triggerCard.Controls.Add(this.materialLabel6);
            this.triggerCard.Depth = 0;
            this.triggerCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.triggerCard.Location = new System.Drawing.Point(4, 7);
            this.triggerCard.Margin = new System.Windows.Forms.Padding(14);
            this.triggerCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.triggerCard.Name = "triggerCard";
            this.triggerCard.Padding = new System.Windows.Forms.Padding(14);
            this.triggerCard.Size = new System.Drawing.Size(195, 169);
            this.triggerCard.TabIndex = 74;
            // 
            // twoPinRadio
            // 
            this.twoPinRadio.AutoSize = true;
            this.twoPinRadio.Depth = 0;
            this.twoPinRadio.Location = new System.Drawing.Point(14, 123);
            this.twoPinRadio.Margin = new System.Windows.Forms.Padding(0);
            this.twoPinRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.twoPinRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.twoPinRadio.Name = "twoPinRadio";
            this.twoPinRadio.Ripple = true;
            this.twoPinRadio.Size = new System.Drawing.Size(111, 37);
            this.twoPinRadio.TabIndex = 69;
            this.twoPinRadio.TabStop = true;
            this.twoPinRadio.Text = "2 Pin Input";
            this.twoPinRadio.UseVisualStyleBackColor = true;
            this.twoPinRadio.CheckedChanged += new System.EventHandler(this.twoPinRadio_CheckedChanged);
            // 
            // audioTriggerRadio
            // 
            this.audioTriggerRadio.AutoSize = true;
            this.audioTriggerRadio.Depth = 0;
            this.audioTriggerRadio.Location = new System.Drawing.Point(14, 86);
            this.audioTriggerRadio.Margin = new System.Windows.Forms.Padding(0);
            this.audioTriggerRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.audioTriggerRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.audioTriggerRadio.Name = "audioTriggerRadio";
            this.audioTriggerRadio.Ripple = true;
            this.audioTriggerRadio.Size = new System.Drawing.Size(155, 37);
            this.audioTriggerRadio.TabIndex = 68;
            this.audioTriggerRadio.TabStop = true;
            this.audioTriggerRadio.Text = "Audio Jack (Mic)";
            this.audioTriggerRadio.UseVisualStyleBackColor = true;
            this.audioTriggerRadio.CheckedChanged += new System.EventHandler(this.audioTriggerRadio_CheckedChanged);
            // 
            // buttonTriggerRadio
            // 
            this.buttonTriggerRadio.AutoSize = true;
            this.buttonTriggerRadio.Checked = true;
            this.buttonTriggerRadio.Depth = 0;
            this.buttonTriggerRadio.Location = new System.Drawing.Point(14, 49);
            this.buttonTriggerRadio.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTriggerRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.buttonTriggerRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonTriggerRadio.Name = "buttonTriggerRadio";
            this.buttonTriggerRadio.Ripple = true;
            this.buttonTriggerRadio.Size = new System.Drawing.Size(136, 37);
            this.buttonTriggerRadio.TabIndex = 67;
            this.buttonTriggerRadio.TabStop = true;
            this.buttonTriggerRadio.Text = "OSLTT Button";
            this.buttonTriggerRadio.UseVisualStyleBackColor = true;
            this.buttonTriggerRadio.CheckedChanged += new System.EventHandler(this.buttonTriggerRadio_CheckedChanged);
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
            this.materialLabel6.TabIndex = 66;
            this.materialLabel6.Text = "Trigger Type";
            // 
            // sourceCard
            // 
            this.sourceCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sourceCard.Controls.Add(this.audioSourceRadio);
            this.sourceCard.Controls.Add(this.gameExternalRadio);
            this.sourceCard.Controls.Add(this.mouseKeyboardRadio);
            this.sourceCard.Controls.Add(this.DirectXRadio);
            this.sourceCard.Controls.Add(this.materialLabel3);
            this.sourceCard.Depth = 0;
            this.sourceCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sourceCard.Location = new System.Drawing.Point(604, 140);
            this.sourceCard.Margin = new System.Windows.Forms.Padding(14);
            this.sourceCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.sourceCard.Name = "sourceCard";
            this.sourceCard.Padding = new System.Windows.Forms.Padding(14);
            this.sourceCard.Size = new System.Drawing.Size(242, 198);
            this.sourceCard.TabIndex = 76;
            // 
            // audioSourceRadio
            // 
            this.audioSourceRadio.AutoSize = true;
            this.audioSourceRadio.Depth = 0;
            this.audioSourceRadio.Location = new System.Drawing.Point(14, 160);
            this.audioSourceRadio.Margin = new System.Windows.Forms.Padding(0);
            this.audioSourceRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.audioSourceRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.audioSourceRadio.Name = "audioSourceRadio";
            this.audioSourceRadio.Ripple = true;
            this.audioSourceRadio.Size = new System.Drawing.Size(107, 37);
            this.audioSourceRadio.TabIndex = 70;
            this.audioSourceRadio.TabStop = true;
            this.audioSourceRadio.Text = "Audio Clip";
            this.audioSourceRadio.UseVisualStyleBackColor = true;
            this.audioSourceRadio.CheckedChanged += new System.EventHandler(this.audioSourceRadio_CheckedChanged);
            // 
            // gameExternalRadio
            // 
            this.gameExternalRadio.AutoSize = true;
            this.gameExternalRadio.Depth = 0;
            this.gameExternalRadio.Location = new System.Drawing.Point(14, 123);
            this.gameExternalRadio.Margin = new System.Windows.Forms.Padding(0);
            this.gameExternalRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.gameExternalRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.gameExternalRadio.Name = "gameExternalRadio";
            this.gameExternalRadio.Ripple = true;
            this.gameExternalRadio.Size = new System.Drawing.Size(141, 37);
            this.gameExternalRadio.TabIndex = 69;
            this.gameExternalRadio.TabStop = true;
            this.gameExternalRadio.Text = "Game/External";
            this.gameExternalRadio.UseVisualStyleBackColor = true;
            this.gameExternalRadio.CheckedChanged += new System.EventHandler(this.gameExternalRadio_CheckedChanged);
            // 
            // mouseKeyboardRadio
            // 
            this.mouseKeyboardRadio.AutoSize = true;
            this.mouseKeyboardRadio.Depth = 0;
            this.mouseKeyboardRadio.Location = new System.Drawing.Point(14, 86);
            this.mouseKeyboardRadio.Margin = new System.Windows.Forms.Padding(0);
            this.mouseKeyboardRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mouseKeyboardRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.mouseKeyboardRadio.Name = "mouseKeyboardRadio";
            this.mouseKeyboardRadio.Ripple = true;
            this.mouseKeyboardRadio.Size = new System.Drawing.Size(157, 37);
            this.mouseKeyboardRadio.TabIndex = 68;
            this.mouseKeyboardRadio.TabStop = true;
            this.mouseKeyboardRadio.Text = "Mouse/Keyboard";
            this.mouseKeyboardRadio.UseVisualStyleBackColor = true;
            this.mouseKeyboardRadio.CheckedChanged += new System.EventHandler(this.mouseKeyboardRadio_CheckedChanged);
            // 
            // DirectXRadio
            // 
            this.DirectXRadio.AutoSize = true;
            this.DirectXRadio.Checked = true;
            this.DirectXRadio.Depth = 0;
            this.DirectXRadio.Location = new System.Drawing.Point(14, 49);
            this.DirectXRadio.Margin = new System.Windows.Forms.Padding(0);
            this.DirectXRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DirectXRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.DirectXRadio.Name = "DirectXRadio";
            this.DirectXRadio.Ripple = true;
            this.DirectXRadio.Size = new System.Drawing.Size(122, 37);
            this.DirectXRadio.TabIndex = 67;
            this.DirectXRadio.TabStop = true;
            this.DirectXRadio.Text = "DirectX Tool";
            this.DirectXRadio.UseVisualStyleBackColor = true;
            this.DirectXRadio.CheckedChanged += new System.EventHandler(this.DirectXRadio_CheckedChanged);
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
            this.materialLabel3.Size = new System.Drawing.Size(129, 29);
            this.materialLabel3.TabIndex = 66;
            this.materialLabel3.Text = "Test Source";
            // 
            // SettingsPane
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.displayCard);
            this.Controls.Add(this.sensorCard);
            this.Controls.Add(this.settingsCard);
            this.Controls.Add(this.triggerCard);
            this.Controls.Add(this.sourceCard);
            this.Name = "SettingsPane";
            this.Size = new System.Drawing.Size(866, 373);
            this.displayCard.ResumeLayout(false);
            this.displayCard.PerformLayout();
            this.sensorCard.ResumeLayout(false);
            this.sensorCard.PerformLayout();
            this.settingsCard.ResumeLayout(false);
            this.settingsCard.PerformLayout();
            this.triggerCard.ResumeLayout(false);
            this.triggerCard.PerformLayout();
            this.sourceCard.ResumeLayout(false);
            this.sourceCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard displayCard;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialComboBox displaySelect;
        private MaterialSkin.Controls.MaterialCard sensorCard;
        private MaterialSkin.Controls.MaterialRadioButton clickKeypressRadio;
        private MaterialSkin.Controls.MaterialRadioButton audioSensorRadio;
        private MaterialSkin.Controls.MaterialRadioButton lightSensorRadio;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard settingsCard;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox clickCountSelect;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSwitch autoClickToggle;
        private MaterialSkin.Controls.MaterialComboBox timeBetweenSelect;
        private MaterialSkin.Controls.MaterialSwitch preTestToggle;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialCard triggerCard;
        private MaterialSkin.Controls.MaterialRadioButton twoPinRadio;
        private MaterialSkin.Controls.MaterialRadioButton audioTriggerRadio;
        private MaterialSkin.Controls.MaterialRadioButton buttonTriggerRadio;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialCard sourceCard;
        private MaterialSkin.Controls.MaterialRadioButton audioSourceRadio;
        private MaterialSkin.Controls.MaterialRadioButton gameExternalRadio;
        private MaterialSkin.Controls.MaterialRadioButton mouseKeyboardRadio;
        private MaterialSkin.Controls.MaterialRadioButton DirectXRadio;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton refreshMonitorsBtn;
    }
}
