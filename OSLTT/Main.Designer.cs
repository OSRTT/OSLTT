
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
            this.fwLbl = new System.Windows.Forms.Label();
            this.fwLblTitle = new System.Windows.Forms.Label();
            this.devStat = new System.Windows.Forms.Label();
            this.checkImg = new System.Windows.Forms.PictureBox();
            this.deviceStatusPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.checkImg)).BeginInit();
            this.deviceStatusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fwLbl
            // 
            this.fwLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fwLbl.Location = new System.Drawing.Point(679, 9);
            this.fwLbl.Name = "fwLbl";
            this.fwLbl.Size = new System.Drawing.Size(80, 25);
            this.fwLbl.TabIndex = 9;
            this.fwLbl.Text = "V0.00";
            this.fwLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fwLblTitle
            // 
            this.fwLblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fwLblTitle.Location = new System.Drawing.Point(633, 9);
            this.fwLblTitle.Name = "fwLblTitle";
            this.fwLblTitle.Size = new System.Drawing.Size(61, 25);
            this.fwLblTitle.TabIndex = 8;
            this.fwLblTitle.Text = "FW:";
            this.fwLblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // checkImg
            // 
            this.checkImg.ErrorImage = global::OSLTT.Properties.Resources.check;
            this.checkImg.Location = new System.Drawing.Point(219, 7);
            this.checkImg.Name = "checkImg";
            this.checkImg.Size = new System.Drawing.Size(58, 29);
            this.checkImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.checkImg.TabIndex = 7;
            this.checkImg.TabStop = false;
            // 
            // deviceStatusPanel
            // 
            this.deviceStatusPanel.BackColor = System.Drawing.Color.White;
            this.deviceStatusPanel.Controls.Add(this.fwLbl);
            this.deviceStatusPanel.Controls.Add(this.fwLblTitle);
            this.deviceStatusPanel.Controls.Add(this.checkImg);
            this.deviceStatusPanel.Controls.Add(this.devStat);
            this.deviceStatusPanel.Location = new System.Drawing.Point(-5, -1);
            this.deviceStatusPanel.Name = "deviceStatusPanel";
            this.deviceStatusPanel.Size = new System.Drawing.Size(809, 45);
            this.deviceStatusPanel.TabIndex = 31;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deviceStatusPanel);
            this.Name = "Main";
            this.Text = "OSLTT";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkImg)).EndInit();
            this.deviceStatusPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox checkImg;
        private System.Windows.Forms.Label devStat;
        private System.Windows.Forms.Label fwLbl;
        private System.Windows.Forms.Label fwLblTitle;
        private System.Windows.Forms.Panel deviceStatusPanel;
    }
}

