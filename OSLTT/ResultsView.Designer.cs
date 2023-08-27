
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
            this.importBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.barPlot = new ScottPlot.FormsPlot();
            this.controlsPanel = new MaterialSkin.Controls.MaterialCard();
            this.switchGraphTypeBtn = new MaterialSkin.Controls.MaterialButton();
            this.saveWhitePNGBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.savePNGBtn = new MaterialSkin.Controls.MaterialButton();
            this.graphedData = new ScottPlot.FormsPlot();
            this.resultsTable = new System.Windows.Forms.DataGridView();
            this.importPanel.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // importPanel
            // 
            this.importPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.importPanel.Controls.Add(this.importBtn);
            this.importPanel.Controls.Add(this.materialLabel1);
            this.importPanel.Depth = 0;
            this.importPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.importPanel.Location = new System.Drawing.Point(17, 78);
            this.importPanel.Margin = new System.Windows.Forms.Padding(14);
            this.importPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.importPanel.Name = "importPanel";
            this.importPanel.Padding = new System.Windows.Forms.Padding(14);
            this.importPanel.Size = new System.Drawing.Size(1490, 60);
            this.importPanel.TabIndex = 0;
            // 
            // importBtn
            // 
            this.importBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.importBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.importBtn.Depth = 0;
            this.importBtn.HighEmphasis = true;
            this.importBtn.Icon = null;
            this.importBtn.Location = new System.Drawing.Point(1295, 12);
            this.importBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.importBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.importBtn.Name = "importBtn";
            this.importBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.importBtn.Size = new System.Drawing.Size(177, 36);
            this.importBtn.TabIndex = 2;
            this.importBtn.Text = "Import Existing File";
            this.importBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.importBtn.UseAccentColor = false;
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
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
            this.switchGraphTypeBtn.Click += new System.EventHandler(this.switchGraphTypeBtn_Click);
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
            // resultsTable
            // 
            this.resultsTable.AllowUserToAddRows = false;
            this.resultsTable.AllowUserToDeleteRows = false;
            this.resultsTable.AllowUserToResizeColumns = false;
            this.resultsTable.AllowUserToResizeRows = false;
            this.resultsTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.resultsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultsTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.resultsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.resultsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsTable.ColumnHeadersVisible = false;
            this.resultsTable.Location = new System.Drawing.Point(1208, 170);
            this.resultsTable.Name = "resultsTable";
            this.resultsTable.RowHeadersVisible = false;
            this.resultsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.resultsTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.resultsTable.Size = new System.Drawing.Size(299, 598);
            this.resultsTable.TabIndex = 37;
            // 
            // ResultsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 829);
            this.Controls.Add(this.resultsTable);
            this.Controls.Add(this.graphedData);
            this.Controls.Add(this.barPlot);
            this.Controls.Add(this.importPanel);
            this.Controls.Add(this.controlsPanel);
            this.Name = "ResultsView";
            this.Text = "Results View";
            this.importPanel.ResumeLayout(false);
            this.importPanel.PerformLayout();
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard importPanel;
        private MaterialSkin.Controls.MaterialButton importBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private ScottPlot.FormsPlot barPlot;
        private MaterialSkin.Controls.MaterialCard controlsPanel;
        private MaterialSkin.Controls.MaterialButton saveWhitePNGBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton savePNGBtn;
        private ScottPlot.FormsPlot graphedData;
        private MaterialSkin.Controls.MaterialButton switchGraphTypeBtn;
        private System.Windows.Forms.DataGridView resultsTable;
    }
}