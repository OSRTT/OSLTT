
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.deviceStatusPanel = new System.Windows.Forms.Panel();
            this.checkImg = new System.Windows.Forms.PictureBox();
            this.devStat = new System.Windows.Forms.Label();
            this.deviceStatusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkImg)).BeginInit();
            this.SuspendLayout();
            // 
            // deviceStatusPanel
            // 
            this.deviceStatusPanel.BackColor = System.Drawing.Color.White;
            this.deviceStatusPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deviceStatusPanel.Controls.Add(this.checkImg);
            this.deviceStatusPanel.Controls.Add(this.devStat);
            this.deviceStatusPanel.Location = new System.Drawing.Point(12, 12);
            this.deviceStatusPanel.Name = "deviceStatusPanel";
            this.deviceStatusPanel.Size = new System.Drawing.Size(776, 45);
            this.deviceStatusPanel.TabIndex = 31;
            // 
            // checkImg
            // 
            this.checkImg.ErrorImage = ((System.Drawing.Image)(resources.GetObject("checkImg.ErrorImage")));
            this.checkImg.Location = new System.Drawing.Point(219, 7);
            this.checkImg.Name = "checkImg";
            this.checkImg.Size = new System.Drawing.Size(58, 29);
            this.checkImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.checkImg.TabIndex = 7;
            this.checkImg.TabStop = false;
            // 
            // devStat
            // 
            this.devStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devStat.Location = new System.Drawing.Point(12, 9);
            this.devStat.Name = "devStat";
            this.devStat.Size = new System.Drawing.Size(265, 25);
            this.devStat.TabIndex = 6;
            this.devStat.Text = "Device Connected";
            this.devStat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deviceStatusPanel);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.deviceStatusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel deviceStatusPanel;
        private System.Windows.Forms.PictureBox checkImg;
        private System.Windows.Forms.Label devStat;
    }
}

