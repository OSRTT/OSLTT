﻿
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
            this.barPlot = new ScottPlot.FormsPlot();
            this.controlsPanel = new MaterialSkin.Controls.MaterialCard();
            this.saveWhitePNGBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.savePNGBtn = new MaterialSkin.Controls.MaterialButton();
            this.graphedData = new ScottPlot.FormsPlot();
            this.switchGraphTypeBtn = new MaterialSkin.Controls.MaterialButton();
            this.importPanel.SuspendLayout();
            this.controlsPanel.SuspendLayout();
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
            this.importPanel.Size = new System.Drawing.Size(679, 60);
            this.importPanel.TabIndex = 0;
            // 
            // importProcessedBtn
            // 
            this.importProcessedBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.importProcessedBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.importProcessedBtn.Depth = 0;
            this.importProcessedBtn.HighEmphasis = true;
            this.importProcessedBtn.Icon = null;
            this.importProcessedBtn.Location = new System.Drawing.Point(457, 12);
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
            this.importRawBtn.Location = new System.Drawing.Point(256, 12);
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
            // barPlot
            // 
            this.barPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barPlot.Location = new System.Drawing.Point(17, 148);
            this.barPlot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barPlot.Name = "barPlot";
            this.barPlot.Size = new System.Drawing.Size(1184, 666);
            this.barPlot.TabIndex = 34;
            // 
            // controlsPanel
            // 
            this.controlsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.controlsPanel.Controls.Add(this.switchGraphTypeBtn);
            this.controlsPanel.Controls.Add(this.saveWhitePNGBtn);
            this.controlsPanel.Controls.Add(this.materialLabel2);
            this.controlsPanel.Controls.Add(this.savePNGBtn);
            this.controlsPanel.Depth = 0;
            this.controlsPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.controlsPanel.Location = new System.Drawing.Point(17, 78);
            this.controlsPanel.Margin = new System.Windows.Forms.Padding(14);
            this.controlsPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Padding = new System.Windows.Forms.Padding(14);
            this.controlsPanel.Size = new System.Drawing.Size(1184, 60);
            this.controlsPanel.TabIndex = 35;
            // 
            // saveWhitePNGBtn
            // 
            this.saveWhitePNGBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveWhitePNGBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveWhitePNGBtn.Depth = 0;
            this.saveWhitePNGBtn.HighEmphasis = true;
            this.saveWhitePNGBtn.Icon = null;
            this.saveWhitePNGBtn.Location = new System.Drawing.Point(1026, 12);
            this.saveWhitePNGBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveWhitePNGBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveWhitePNGBtn.Name = "saveWhitePNGBtn";
            this.saveWhitePNGBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveWhitePNGBtn.Size = new System.Drawing.Size(140, 36);
            this.saveWhitePNGBtn.TabIndex = 2;
            this.saveWhitePNGBtn.Text = "Save White PNG";
            this.saveWhitePNGBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveWhitePNGBtn.UseAccentColor = false;
            this.saveWhitePNGBtn.UseVisualStyleBackColor = true;
            this.saveWhitePNGBtn.Click += new System.EventHandler(this.saveWhitePNGBtn_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(17, 15);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(92, 29);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Controls";
            // 
            // savePNGBtn
            // 
            this.savePNGBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.savePNGBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.savePNGBtn.Depth = 0;
            this.savePNGBtn.HighEmphasis = true;
            this.savePNGBtn.Icon = null;
            this.savePNGBtn.Location = new System.Drawing.Point(927, 12);
            this.savePNGBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.savePNGBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.savePNGBtn.Name = "savePNGBtn";
            this.savePNGBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.savePNGBtn.Size = new System.Drawing.Size(91, 36);
            this.savePNGBtn.TabIndex = 0;
            this.savePNGBtn.Text = "Save PNG";
            this.savePNGBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.savePNGBtn.UseAccentColor = false;
            this.savePNGBtn.UseVisualStyleBackColor = true;
            this.savePNGBtn.Click += new System.EventHandler(this.savePNGBtn_Click);
            // 
            // graphedData
            // 
            this.graphedData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphedData.Location = new System.Drawing.Point(17, 148);
            this.graphedData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.graphedData.Name = "graphedData";
            this.graphedData.Size = new System.Drawing.Size(1184, 666);
            this.graphedData.TabIndex = 36;
            // 
            // switchGraphTypeBtn
            // 
            this.switchGraphTypeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.switchGraphTypeBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.switchGraphTypeBtn.Depth = 0;
            this.switchGraphTypeBtn.HighEmphasis = true;
            this.switchGraphTypeBtn.Icon = null;
            this.switchGraphTypeBtn.Location = new System.Drawing.Point(637, 12);
            this.switchGraphTypeBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.switchGraphTypeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchGraphTypeBtn.Name = "switchGraphTypeBtn";
            this.switchGraphTypeBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.switchGraphTypeBtn.Size = new System.Drawing.Size(248, 36);
            this.switchGraphTypeBtn.TabIndex = 3;
            this.switchGraphTypeBtn.Text = "Switch to Individual Results";
            this.switchGraphTypeBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.switchGraphTypeBtn.UseAccentColor = false;
            this.switchGraphTypeBtn.UseVisualStyleBackColor = true;
            // 
            // ResultsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 829);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.graphedData);
            this.Controls.Add(this.barPlot);
            this.Controls.Add(this.importPanel);
            this.Name = "ResultsView";
            this.Text = "Results View";
            this.importPanel.ResumeLayout(false);
            this.importPanel.PerformLayout();
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard importPanel;
        private MaterialSkin.Controls.MaterialButton importRawBtn;
        private MaterialSkin.Controls.MaterialButton importProcessedBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private ScottPlot.FormsPlot barPlot;
        private MaterialSkin.Controls.MaterialCard controlsPanel;
        private MaterialSkin.Controls.MaterialButton saveWhitePNGBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton savePNGBtn;
        private ScottPlot.FormsPlot graphedData;
        private MaterialSkin.Controls.MaterialButton switchGraphTypeBtn;
    }
}