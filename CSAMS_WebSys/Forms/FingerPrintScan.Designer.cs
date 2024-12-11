namespace CSAMS_WebSys.Forms
{
    partial class FingerPrintScan
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
            this.components = new System.ComponentModel.Container();
            this.DescriptionText_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.noOfTimes_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.ScannerTitle_gunaPanel = new Guna.UI.WinForms.GunaPanel();
            this.Scanner_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.fingerPrintImage_gunaShadowPanel = new Guna.UI.WinForms.GunaShadowPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ScannerTitle_gunaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DescriptionText_gunaLabel
            // 
            this.DescriptionText_gunaLabel.AutoSize = true;
            this.DescriptionText_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionText_gunaLabel.Location = new System.Drawing.Point(18, 333);
            this.DescriptionText_gunaLabel.Name = "DescriptionText_gunaLabel";
            this.DescriptionText_gunaLabel.Size = new System.Drawing.Size(258, 25);
            this.DescriptionText_gunaLabel.TabIndex = 0;
            this.DescriptionText_gunaLabel.Text = "Please put finger in the scanner";
            // 
            // noOfTimes_gunaLabel
            // 
            this.noOfTimes_gunaLabel.AutoSize = true;
            this.noOfTimes_gunaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfTimes_gunaLabel.Location = new System.Drawing.Point(43, 131);
            this.noOfTimes_gunaLabel.Name = "noOfTimes_gunaLabel";
            this.noOfTimes_gunaLabel.Size = new System.Drawing.Size(233, 31);
            this.noOfTimes_gunaLabel.TabIndex = 1;
            this.noOfTimes_gunaLabel.Text = "No device connected";
            // 
            // ScannerTitle_gunaPanel
            // 
            this.ScannerTitle_gunaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.ScannerTitle_gunaPanel.Controls.Add(this.Scanner_gunaLabel);
            this.ScannerTitle_gunaPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ScannerTitle_gunaPanel.Location = new System.Drawing.Point(0, 0);
            this.ScannerTitle_gunaPanel.Name = "ScannerTitle_gunaPanel";
            this.ScannerTitle_gunaPanel.Size = new System.Drawing.Size(539, 91);
            this.ScannerTitle_gunaPanel.TabIndex = 2;
            // 
            // Scanner_gunaLabel
            // 
            this.Scanner_gunaLabel.AutoSize = true;
            this.Scanner_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.Scanner_gunaLabel.ForeColor = System.Drawing.Color.White;
            this.Scanner_gunaLabel.Location = new System.Drawing.Point(24, 16);
            this.Scanner_gunaLabel.Name = "Scanner_gunaLabel";
            this.Scanner_gunaLabel.Size = new System.Drawing.Size(172, 54);
            this.Scanner_gunaLabel.TabIndex = 1;
            this.Scanner_gunaLabel.Text = "Scanner";
            // 
            // fingerPrintImage_gunaShadowPanel
            // 
            this.fingerPrintImage_gunaShadowPanel.BackgroundImage = global::CSAMS_WebSys.Properties.Resources.fingerprint;
            this.fingerPrintImage_gunaShadowPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fingerPrintImage_gunaShadowPanel.BaseColor = System.Drawing.Color.Transparent;
            this.fingerPrintImage_gunaShadowPanel.Location = new System.Drawing.Point(313, 111);
            this.fingerPrintImage_gunaShadowPanel.Name = "fingerPrintImage_gunaShadowPanel";
            this.fingerPrintImage_gunaShadowPanel.ShadowColor = System.Drawing.Color.Transparent;
            this.fingerPrintImage_gunaShadowPanel.Size = new System.Drawing.Size(204, 258);
            this.fingerPrintImage_gunaShadowPanel.TabIndex = 3;
            // 
            // FingerPrintScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 390);
            this.Controls.Add(this.fingerPrintImage_gunaShadowPanel);
            this.Controls.Add(this.ScannerTitle_gunaPanel);
            this.Controls.Add(this.noOfTimes_gunaLabel);
            this.Controls.Add(this.DescriptionText_gunaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FingerPrintScan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FingerPrintScan_FormClosing);
            this.Load += new System.EventHandler(this.FingerPrintScan_Load);
            this.ScannerTitle_gunaPanel.ResumeLayout(false);
            this.ScannerTitle_gunaPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel DescriptionText_gunaLabel;
        private Guna.UI.WinForms.GunaLabel noOfTimes_gunaLabel;
        private Guna.UI.WinForms.GunaPanel ScannerTitle_gunaPanel;
        private Guna.UI.WinForms.GunaLabel Scanner_gunaLabel;
        private Guna.UI.WinForms.GunaShadowPanel fingerPrintImage_gunaShadowPanel;
        private System.Windows.Forms.Timer timer1;
    }
}