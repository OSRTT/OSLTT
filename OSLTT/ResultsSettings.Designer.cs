
namespace OSLTT
{
    partial class ResultsSettings
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
            this.yAxisSlider = new MaterialSkin.Controls.MaterialSlider();
            this.axisColourSelect = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.graphViewSelect = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.autoScreenshotSelect = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.SuspendLayout();
            // 
            // yAxisSlider
            // 
            this.yAxisSlider.Depth = 0;
            this.yAxisSlider.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.yAxisSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.yAxisSlider.Location = new System.Drawing.Point(23, 19);
            this.yAxisSlider.MouseState = MaterialSkin.MouseState.HOVER;
            this.yAxisSlider.Name = "yAxisSlider";
            this.yAxisSlider.RangeMin = 5;
            this.yAxisSlider.Size = new System.Drawing.Size(718, 40);
            this.yAxisSlider.TabIndex = 2;
            this.yAxisSlider.Text = "RAW PNG Y Axis Maximum";
            this.yAxisSlider.UseAccentColor = true;
            this.yAxisSlider.Value = 30;
            this.yAxisSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.yAxisSlider_MouseUp);
            // 
            // axisColourSelect
            // 
            this.axisColourSelect.AutoResize = false;
            this.axisColourSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.axisColourSelect.Depth = 0;
            this.axisColourSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.axisColourSelect.DropDownHeight = 174;
            this.axisColourSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.axisColourSelect.DropDownWidth = 121;
            this.axisColourSelect.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.axisColourSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.axisColourSelect.FormattingEnabled = true;
            this.axisColourSelect.IntegralHeight = false;
            this.axisColourSelect.ItemHeight = 43;
            this.axisColourSelect.Location = new System.Drawing.Point(314, 17);
            this.axisColourSelect.MaxDropDownItems = 4;
            this.axisColourSelect.MouseState = MaterialSkin.MouseState.OUT;
            this.axisColourSelect.Name = "axisColourSelect";
            this.axisColourSelect.Size = new System.Drawing.Size(427, 49);
            this.axisColourSelect.StartIndex = 0;
            this.axisColourSelect.TabIndex = 3;
            this.axisColourSelect.SelectedIndexChanged += new System.EventHandler(this.axisColourSelect_SelectedIndexChanged);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.yAxisSlider);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 355);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(766, 78);
            this.materialCard1.TabIndex = 4;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialLabel1);
            this.materialCard2.Controls.Add(this.axisColourSelect);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(17, 261);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(766, 81);
            this.materialCard2.TabIndex = 5;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(18, 26);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(189, 29);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Chart Text Colour";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialLabel2);
            this.materialCard3.Controls.Add(this.graphViewSelect);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(17, 78);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(766, 81);
            this.materialCard3.TabIndex = 6;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(18, 26);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(205, 29);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Default Graph View";
            // 
            // graphViewSelect
            // 
            this.graphViewSelect.AutoResize = false;
            this.graphViewSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.graphViewSelect.Depth = 0;
            this.graphViewSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.graphViewSelect.DropDownHeight = 174;
            this.graphViewSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.graphViewSelect.DropDownWidth = 121;
            this.graphViewSelect.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.graphViewSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.graphViewSelect.FormattingEnabled = true;
            this.graphViewSelect.IntegralHeight = false;
            this.graphViewSelect.ItemHeight = 43;
            this.graphViewSelect.Location = new System.Drawing.Point(314, 17);
            this.graphViewSelect.MaxDropDownItems = 4;
            this.graphViewSelect.MouseState = MaterialSkin.MouseState.OUT;
            this.graphViewSelect.Name = "graphViewSelect";
            this.graphViewSelect.Size = new System.Drawing.Size(427, 49);
            this.graphViewSelect.StartIndex = 0;
            this.graphViewSelect.TabIndex = 3;
            this.graphViewSelect.SelectedIndexChanged += new System.EventHandler(this.graphViewSelect_SelectedIndexChanged);
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.materialLabel3);
            this.materialCard4.Controls.Add(this.autoScreenshotSelect);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(17, 168);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(766, 81);
            this.materialCard4.TabIndex = 7;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.Location = new System.Drawing.Point(18, 26);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(237, 29);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Auto Save Screenshot";
            // 
            // autoScreenshotSelect
            // 
            this.autoScreenshotSelect.AutoResize = false;
            this.autoScreenshotSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoScreenshotSelect.Depth = 0;
            this.autoScreenshotSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.autoScreenshotSelect.DropDownHeight = 174;
            this.autoScreenshotSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.autoScreenshotSelect.DropDownWidth = 121;
            this.autoScreenshotSelect.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.autoScreenshotSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.autoScreenshotSelect.FormattingEnabled = true;
            this.autoScreenshotSelect.IntegralHeight = false;
            this.autoScreenshotSelect.ItemHeight = 43;
            this.autoScreenshotSelect.Location = new System.Drawing.Point(314, 17);
            this.autoScreenshotSelect.MaxDropDownItems = 4;
            this.autoScreenshotSelect.MouseState = MaterialSkin.MouseState.OUT;
            this.autoScreenshotSelect.Name = "autoScreenshotSelect";
            this.autoScreenshotSelect.Size = new System.Drawing.Size(427, 49);
            this.autoScreenshotSelect.StartIndex = 0;
            this.autoScreenshotSelect.TabIndex = 3;
            this.autoScreenshotSelect.SelectedIndexChanged += new System.EventHandler(this.autoScreenshotSelect_SelectedIndexChanged);
            // 
            // ResultsSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.materialCard4);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Name = "ResultsSettings";
            this.Text = "Results Settings";
            this.materialCard1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSlider yAxisSlider;
        private MaterialSkin.Controls.MaterialComboBox axisColourSelect;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox graphViewSelect;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox autoScreenshotSelect;
    }
}