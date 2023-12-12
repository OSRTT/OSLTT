
namespace OSLTT
{
    partial class debugForm
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
            this.closeBtn = new MaterialSkin.Controls.MaterialButton();
            this.debugBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.testMicBtn = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.closeBtn.Depth = 0;
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.HighEmphasis = true;
            this.closeBtn.Icon = null;
            this.closeBtn.Location = new System.Drawing.Point(717, 666);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.closeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.closeBtn.Size = new System.Drawing.Size(149, 36);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "Close Debug Log";
            this.closeBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.closeBtn.UseAccentColor = false;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // debugBox
            // 
            this.debugBox.AnimateReadOnly = true;
            this.debugBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.debugBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.debugBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.debugBox.Depth = 0;
            this.debugBox.HideSelection = true;
            this.debugBox.Location = new System.Drawing.Point(9, 70);
            this.debugBox.MaxLength = 32767;
            this.debugBox.MouseState = MaterialSkin.MouseState.OUT;
            this.debugBox.Name = "debugBox";
            this.debugBox.PasswordChar = '\0';
            this.debugBox.ReadOnly = true;
            this.debugBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.debugBox.SelectedText = "";
            this.debugBox.SelectionLength = 0;
            this.debugBox.SelectionStart = 0;
            this.debugBox.ShortcutsEnabled = true;
            this.debugBox.Size = new System.Drawing.Size(899, 651);
            this.debugBox.TabIndex = 2;
            this.debugBox.TabStop = false;
            this.debugBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.debugBox.UseSystemPasswordChar = false;
            // 
            // testMicBtn
            // 
            this.testMicBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.testMicBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.testMicBtn.Depth = 0;
            this.testMicBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.testMicBtn.HighEmphasis = true;
            this.testMicBtn.Icon = null;
            this.testMicBtn.Location = new System.Drawing.Point(773, 618);
            this.testMicBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.testMicBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.testMicBtn.Name = "testMicBtn";
            this.testMicBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.testMicBtn.Size = new System.Drawing.Size(93, 36);
            this.testMicBtn.TabIndex = 3;
            this.testMicBtn.Text = "Mic dump";
            this.testMicBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.testMicBtn.UseAccentColor = false;
            this.testMicBtn.UseVisualStyleBackColor = true;
            this.testMicBtn.Click += new System.EventHandler(this.testMicBtn_Click);
            // 
            // debugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(914, 727);
            this.Controls.Add(this.testMicBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.debugBox);
            this.Name = "debugForm";
            this.Text = "Debug Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton closeBtn;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 debugBox;
        private MaterialSkin.Controls.MaterialButton testMicBtn;
    }
}