
namespace OSLTT
{
    partial class ResultsView
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
            this.importPanel = new MaterialSkin.Controls.MaterialCard();
            this.importProcessedBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.importRawBtn = new MaterialSkin.Controls.MaterialButton();
            this.importPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // importPanel
            // 
            this.importPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.importPanel.Controls.Add(this.importProcessedBtn);
            this.importPanel.Controls.Add(this.materialLabel1);
            this.importPanel.Controls.Add(this.importRawBtn);
            this.importPanel.Depth = 0;
            this.importPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.importPanel.Location = new System.Drawing.Point(17, 78);
            this.importPanel.Margin = new System.Windows.Forms.Padding(14);
            this.importPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.importPanel.Name = "importPanel";
            this.importPanel.Padding = new System.Windows.Forms.Padding(14);
            this.importPanel.Size = new System.Drawing.Size(1002, 60);
            this.importPanel.TabIndex = 0;
            // 
            // importProcessedBtn
            // 
            this.importProcessedBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.importProcessedBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.importProcessedBtn.Depth = 0;
            this.importProcessedBtn.HighEmphasis = true;
            this.importProcessedBtn.Icon = null;
            this.importProcessedBtn.Location = new System.Drawing.Point(691, 12);
            this.importProcessedBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.importProcessedBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.importProcessedBtn.Name = "importProcessedBtn";
            this.importProcessedBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.importProcessedBtn.Size = new System.Drawing.Size(195, 36);
            this.importProcessedBtn.TabIndex = 2;
            this.importProcessedBtn.Text = "Import Processed File";
            this.importProcessedBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.importProcessedBtn.UseAccentColor = false;
            this.importProcessedBtn.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(17, 15);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(161, 29);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Import Options";
            // 
            // importRawBtn
            // 
            this.importRawBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.importRawBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.importRawBtn.Depth = 0;
            this.importRawBtn.HighEmphasis = true;
            this.importRawBtn.Icon = null;
            this.importRawBtn.Location = new System.Drawing.Point(342, 12);
            this.importRawBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.importRawBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.importRawBtn.Name = "importRawBtn";
            this.importRawBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.importRawBtn.Size = new System.Drawing.Size(144, 36);
            this.importRawBtn.TabIndex = 0;
            this.importRawBtn.Text = "Import Raw File";
            this.importRawBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.importRawBtn.UseAccentColor = false;
            this.importRawBtn.UseVisualStyleBackColor = true;
            // 
            // ResultsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 732);
            this.Controls.Add(this.importPanel);
            this.Name = "ResultsView";
            this.Text = "Results View";
            this.importPanel.ResumeLayout(false);
            this.importPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard importPanel;
        private MaterialSkin.Controls.MaterialButton importRawBtn;
        private MaterialSkin.Controls.MaterialButton importProcessedBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}