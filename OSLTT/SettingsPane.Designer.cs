
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
            this.settingsCard = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.twoPinTriggerSelect = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.mouseActionSelect = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.clickCountSelect = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.autoClickToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.timeBetweenSelect = new MaterialSkin.Controls.MaterialComboBox();
            this.preTestToggle = new MaterialSkin.Controls.MaterialSwitch();
            this.isolateLabel = new MaterialSkin.Controls.MaterialLabel();
            this.triggerCard = new MaterialSkin.Controls.MaterialCard();
            this.testSelect = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.sensorSelect = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.triggerSelect = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.displayCard.SuspendLayout();
            this.settingsCard.SuspendLayout();
            this.triggerCard.SuspendLayout();
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
            this.displayCard.Location = new System.Drawing.Point(8, 304);
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
            // settingsCard
            // 
            this.settingsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.settingsCard.Controls.Add(this.materialLabel7);
            this.settingsCard.Controls.Add(this.twoPinTriggerSelect);
            this.settingsCard.Controls.Add(this.materialLabel2);
            this.settingsCard.Controls.Add(this.mouseActionSelect);
            this.settingsCard.Controls.Add(this.materialLabel8);
            this.settingsCard.Controls.Add(this.materialLabel4);
            this.settingsCard.Controls.Add(this.clickCountSelect);
            this.settingsCard.Controls.Add(this.materialLabel5);
            this.settingsCard.Controls.Add(this.autoClickToggle);
            this.settingsCard.Controls.Add(this.timeBetweenSelect);
            this.settingsCard.Controls.Add(this.preTestToggle);
            this.settingsCard.Controls.Add(this.isolateLabel);
            this.settingsCard.Depth = 0;
            this.settingsCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settingsCard.Location = new System.Drawing.Point(267, 7);
            this.settingsCard.Margin = new System.Windows.Forms.Padding(14);
            this.settingsCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingsCard.Name = "settingsCard";
            this.settingsCard.Padding = new System.Windows.Forms.Padding(14);
            this.settingsCard.Size = new System.Drawing.Size(340, 420);
            this.settingsCard.TabIndex = 73;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(30, 287);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(91, 19);
            this.materialLabel7.TabIndex = 58;
            this.materialLabel7.Text = "2 Pin Trigger";
            // 
            // twoPinTriggerSelect
            // 
            this.twoPinTriggerSelect.AutoResize = false;
            this.twoPinTriggerSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.twoPinTriggerSelect.Depth = 0;
            this.twoPinTriggerSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.twoPinTriggerSelect.DropDownHeight = 174;
            this.twoPinTriggerSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.twoPinTriggerSelect.DropDownWidth = 121;
            this.twoPinTriggerSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.twoPinTriggerSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.twoPinTriggerSelect.FormattingEnabled = true;
            this.twoPinTriggerSelect.IntegralHeight = false;
            this.twoPinTriggerSelect.ItemHeight = 43;
            this.twoPinTriggerSelect.Items.AddRange(new object[] {
            "RISING",
            "FALLING"});
            this.twoPinTriggerSelect.Location = new System.Drawing.Point(134, 270);
            this.twoPinTriggerSelect.MaxDropDownItems = 4;
            this.twoPinTriggerSelect.MouseState = MaterialSkin.MouseState.OUT;
            this.twoPinTriggerSelect.Name = "twoPinTriggerSelect";
            this.twoPinTriggerSelect.Size = new System.Drawing.Size(175, 49);
            this.twoPinTriggerSelect.StartIndex = 0;
            this.twoPinTriggerSelect.TabIndex = 59;
            this.twoPinTriggerSelect.SelectedIndexChanged += new System.EventHandler(this.twoPinTriggerSelect_SelectedIndexChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(30, 225);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(98, 19);
            this.materialLabel2.TabIndex = 56;
            this.materialLabel2.Text = "Mouse Action";
            // 
            // mouseActionSelect
            // 
            this.mouseActionSelect.AutoResize = false;
            this.mouseActionSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mouseActionSelect.Depth = 0;
            this.mouseActionSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mouseActionSelect.DropDownHeight = 174;
            this.mouseActionSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mouseActionSelect.DropDownWidth = 121;
            this.mouseActionSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mouseActionSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mouseActionSelect.FormattingEnabled = true;
            this.mouseActionSelect.IntegralHeight = false;
            this.mouseActionSelect.ItemHeight = 43;
            this.mouseActionSelect.Items.AddRange(new object[] {
            "Left Click",
            "(L) Small Move",
            "(R) Small Move",
            "Hold Left Click"});
            this.mouseActionSelect.Location = new System.Drawing.Point(134, 208);
            this.mouseActionSelect.MaxDropDownItems = 4;
            this.mouseActionSelect.MouseState = MaterialSkin.MouseState.OUT;
            this.mouseActionSelect.Name = "mouseActionSelect";
            this.mouseActionSelect.Size = new System.Drawing.Size(175, 49);
            this.mouseActionSelect.StartIndex = 0;
            this.mouseActionSelect.TabIndex = 57;
            this.mouseActionSelect.SelectedIndexChanged += new System.EventHandler(this.mouseActionSelect_SelectedIndexChanged);
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
            this.materialLabel4.Location = new System.Drawing.Point(30, 98);
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
            this.clickCountSelect.Location = new System.Drawing.Point(169, 78);
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
            this.materialLabel5.Location = new System.Drawing.Point(30, 161);
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
            this.autoClickToggle.Location = new System.Drawing.Point(23, 45);
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
            this.timeBetweenSelect.Location = new System.Drawing.Point(188, 144);
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
            this.preTestToggle.Location = new System.Drawing.Point(23, 362);
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
            // isolateLabel
            // 
            this.isolateLabel.AutoSize = true;
            this.isolateLabel.Depth = 0;
            this.isolateLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.isolateLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.isolateLabel.Location = new System.Drawing.Point(28, 332);
            this.isolateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.isolateLabel.Name = "isolateLabel";
            this.isolateLabel.Size = new System.Drawing.Size(243, 29);
            this.isolateLabel.TabIndex = 53;
            this.isolateLabel.Text = "Isolate Device Latency";
            // 
            // triggerCard
            // 
            this.triggerCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.triggerCard.Controls.Add(this.testSelect);
            this.triggerCard.Controls.Add(this.materialLabel11);
            this.triggerCard.Controls.Add(this.sensorSelect);
            this.triggerCard.Controls.Add(this.materialLabel9);
            this.triggerCard.Controls.Add(this.triggerSelect);
            this.triggerCard.Controls.Add(this.materialLabel6);
            this.triggerCard.Depth = 0;
            this.triggerCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.triggerCard.Location = new System.Drawing.Point(8, 7);
            this.triggerCard.Margin = new System.Windows.Forms.Padding(14);
            this.triggerCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.triggerCard.Name = "triggerCard";
            this.triggerCard.Padding = new System.Windows.Forms.Padding(14);
            this.triggerCard.Size = new System.Drawing.Size(242, 290);
            this.triggerCard.TabIndex = 74;
            // 
            // testSelect
            // 
            this.testSelect.AutoResize = false;
            this.testSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.testSelect.Depth = 0;
            this.testSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.testSelect.DropDownHeight = 174;
            this.testSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.testSelect.DropDownWidth = 121;
            this.testSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.testSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.testSelect.FormattingEnabled = true;
            this.testSelect.IntegralHeight = false;
            this.testSelect.ItemHeight = 43;
            this.testSelect.Location = new System.Drawing.Point(17, 226);
            this.testSelect.MaxDropDownItems = 4;
            this.testSelect.MouseState = MaterialSkin.MouseState.OUT;
            this.testSelect.Name = "testSelect";
            this.testSelect.Size = new System.Drawing.Size(208, 49);
            this.testSelect.StartIndex = 0;
            this.testSelect.TabIndex = 69;
            this.testSelect.SelectedIndexChanged += new System.EventHandler(this.testSelect_SelectedIndexChanged);
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel11.Location = new System.Drawing.Point(17, 190);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(105, 29);
            this.materialLabel11.TabIndex = 70;
            this.materialLabel11.Text = "Test Type";
            // 
            // sensorSelect
            // 
            this.sensorSelect.AutoResize = false;
            this.sensorSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sensorSelect.Depth = 0;
            this.sensorSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.sensorSelect.DropDownHeight = 174;
            this.sensorSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sensorSelect.DropDownWidth = 121;
            this.sensorSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.sensorSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sensorSelect.FormattingEnabled = true;
            this.sensorSelect.IntegralHeight = false;
            this.sensorSelect.ItemHeight = 43;
            this.sensorSelect.Location = new System.Drawing.Point(17, 138);
            this.sensorSelect.MaxDropDownItems = 4;
            this.sensorSelect.MouseState = MaterialSkin.MouseState.OUT;
            this.sensorSelect.Name = "sensorSelect";
            this.sensorSelect.Size = new System.Drawing.Size(208, 49);
            this.sensorSelect.StartIndex = 0;
            this.sensorSelect.TabIndex = 67;
            this.sensorSelect.SelectedIndexChanged += new System.EventHandler(this.sensorSelect_SelectedIndexChanged);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel9.Location = new System.Drawing.Point(17, 102);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(132, 29);
            this.materialLabel9.TabIndex = 68;
            this.materialLabel9.Text = "Sensor Type";
            // 
            // triggerSelect
            // 
            this.triggerSelect.AutoResize = false;
            this.triggerSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.triggerSelect.Depth = 0;
            this.triggerSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.triggerSelect.DropDownHeight = 174;
            this.triggerSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.triggerSelect.DropDownWidth = 121;
            this.triggerSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.triggerSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.triggerSelect.FormattingEnabled = true;
            this.triggerSelect.IntegralHeight = false;
            this.triggerSelect.ItemHeight = 43;
            this.triggerSelect.Location = new System.Drawing.Point(17, 50);
            this.triggerSelect.MaxDropDownItems = 4;
            this.triggerSelect.MouseState = MaterialSkin.MouseState.OUT;
            this.triggerSelect.Name = "triggerSelect";
            this.triggerSelect.Size = new System.Drawing.Size(208, 49);
            this.triggerSelect.StartIndex = 0;
            this.triggerSelect.TabIndex = 60;
            this.triggerSelect.SelectedIndexChanged += new System.EventHandler(this.triggerSelect_SelectedIndexChanged);
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
            // SettingsPane
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.displayCard);
            this.Controls.Add(this.settingsCard);
            this.Controls.Add(this.triggerCard);
            this.Name = "SettingsPane";
            this.Size = new System.Drawing.Size(621, 438);
            this.displayCard.ResumeLayout(false);
            this.displayCard.PerformLayout();
            this.settingsCard.ResumeLayout(false);
            this.settingsCard.PerformLayout();
            this.triggerCard.ResumeLayout(false);
            this.triggerCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard displayCard;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialComboBox displaySelect;
        private MaterialSkin.Controls.MaterialCard settingsCard;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox clickCountSelect;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSwitch autoClickToggle;
        private MaterialSkin.Controls.MaterialComboBox timeBetweenSelect;
        private MaterialSkin.Controls.MaterialSwitch preTestToggle;
        private MaterialSkin.Controls.MaterialLabel isolateLabel;
        private MaterialSkin.Controls.MaterialCard triggerCard;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialButton refreshMonitorsBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox mouseActionSelect;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialComboBox twoPinTriggerSelect;
        private MaterialSkin.Controls.MaterialComboBox testSelect;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialComboBox sensorSelect;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialComboBox triggerSelect;
    }
}
