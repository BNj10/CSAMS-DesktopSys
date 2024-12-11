namespace CSAMS_WebSys.Forms
{
    partial class EventDetailsForm
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
            this.EventDetailsTitle_gunaPanel = new Guna.UI.WinForms.GunaPanel();
            this.EventDetailsText_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scan_gunaAdvenceButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.absences_gunaAdvenceButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.scanEventDetails1 = new CSAMS_WebSys.UserControls.ScanEventDetails();
            this.absencesEventDetails1 = new CSAMS_WebSys.UserControls.AbsencesEventDetails();
            this.eventName_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.eventNameText_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.EventDetailsTitle_gunaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EventDetailsTitle_gunaPanel
            // 
            this.EventDetailsTitle_gunaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.EventDetailsTitle_gunaPanel.Controls.Add(this.EventDetailsText_gunaLabel);
            this.EventDetailsTitle_gunaPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EventDetailsTitle_gunaPanel.Location = new System.Drawing.Point(0, 0);
            this.EventDetailsTitle_gunaPanel.Name = "EventDetailsTitle_gunaPanel";
            this.EventDetailsTitle_gunaPanel.Size = new System.Drawing.Size(1462, 91);
            this.EventDetailsTitle_gunaPanel.TabIndex = 3;
            // 
            // EventDetailsText_gunaLabel
            // 
            this.EventDetailsText_gunaLabel.AutoSize = true;
            this.EventDetailsText_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.EventDetailsText_gunaLabel.ForeColor = System.Drawing.Color.White;
            this.EventDetailsText_gunaLabel.Location = new System.Drawing.Point(24, 16);
            this.EventDetailsText_gunaLabel.Name = "EventDetailsText_gunaLabel";
            this.EventDetailsText_gunaLabel.Size = new System.Drawing.Size(269, 54);
            this.EventDetailsText_gunaLabel.TabIndex = 1;
            this.EventDetailsText_gunaLabel.Text = "Event Details";
            // 
            // scan_gunaAdvenceButton
            // 
            this.scan_gunaAdvenceButton.AnimationHoverSpeed = 0.07F;
            this.scan_gunaAdvenceButton.AnimationSpeed = 0.03F;
            this.scan_gunaAdvenceButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.scan_gunaAdvenceButton.BorderColor = System.Drawing.Color.Black;
            this.scan_gunaAdvenceButton.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.scan_gunaAdvenceButton.Checked = true;
            this.scan_gunaAdvenceButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.scan_gunaAdvenceButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.scan_gunaAdvenceButton.CheckedForeColor = System.Drawing.Color.White;
            this.scan_gunaAdvenceButton.CheckedImage = null;
            this.scan_gunaAdvenceButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.scan_gunaAdvenceButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scan_gunaAdvenceButton.ForeColor = System.Drawing.Color.White;
            this.scan_gunaAdvenceButton.Image = null;
            this.scan_gunaAdvenceButton.ImageSize = new System.Drawing.Size(20, 20);
            this.scan_gunaAdvenceButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.scan_gunaAdvenceButton.Location = new System.Drawing.Point(12, 97);
            this.scan_gunaAdvenceButton.Name = "scan_gunaAdvenceButton";
            this.scan_gunaAdvenceButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.scan_gunaAdvenceButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.scan_gunaAdvenceButton.OnHoverForeColor = System.Drawing.Color.White;
            this.scan_gunaAdvenceButton.OnHoverImage = null;
            this.scan_gunaAdvenceButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.scan_gunaAdvenceButton.OnPressedColor = System.Drawing.Color.Black;
            this.scan_gunaAdvenceButton.Radius = 8;
            this.scan_gunaAdvenceButton.Size = new System.Drawing.Size(210, 40);
            this.scan_gunaAdvenceButton.TabIndex = 4;
            this.scan_gunaAdvenceButton.Text = "Scan";
            this.scan_gunaAdvenceButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.scan_gunaAdvenceButton.Click += new System.EventHandler(this.scan_gunaAdvenceButton_Click);
            // 
            // absences_gunaAdvenceButton
            // 
            this.absences_gunaAdvenceButton.AnimationHoverSpeed = 0.07F;
            this.absences_gunaAdvenceButton.AnimationSpeed = 0.03F;
            this.absences_gunaAdvenceButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.absences_gunaAdvenceButton.BorderColor = System.Drawing.Color.Black;
            this.absences_gunaAdvenceButton.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.absences_gunaAdvenceButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.absences_gunaAdvenceButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.absences_gunaAdvenceButton.CheckedForeColor = System.Drawing.Color.White;
            this.absences_gunaAdvenceButton.CheckedImage = null;
            this.absences_gunaAdvenceButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.absences_gunaAdvenceButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absences_gunaAdvenceButton.ForeColor = System.Drawing.Color.White;
            this.absences_gunaAdvenceButton.Image = null;
            this.absences_gunaAdvenceButton.ImageSize = new System.Drawing.Size(20, 20);
            this.absences_gunaAdvenceButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.absences_gunaAdvenceButton.Location = new System.Drawing.Point(228, 97);
            this.absences_gunaAdvenceButton.Name = "absences_gunaAdvenceButton";
            this.absences_gunaAdvenceButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.absences_gunaAdvenceButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.absences_gunaAdvenceButton.OnHoverForeColor = System.Drawing.Color.White;
            this.absences_gunaAdvenceButton.OnHoverImage = null;
            this.absences_gunaAdvenceButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.absences_gunaAdvenceButton.OnPressedColor = System.Drawing.Color.Black;
            this.absences_gunaAdvenceButton.Radius = 8;
            this.absences_gunaAdvenceButton.Size = new System.Drawing.Size(210, 40);
            this.absences_gunaAdvenceButton.TabIndex = 5;
            this.absences_gunaAdvenceButton.Text = "Absences";
            this.absences_gunaAdvenceButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.absences_gunaAdvenceButton.Click += new System.EventHandler(this.absences_gunaAdvenceButton_Click);
            // 
            // scanEventDetails1
            // 
            this.scanEventDetails1.Location = new System.Drawing.Point(0, 145);
            this.scanEventDetails1.Name = "scanEventDetails1";
            this.scanEventDetails1.Size = new System.Drawing.Size(1462, 646);
            this.scanEventDetails1.TabIndex = 6;
            // 
            // absencesEventDetails1
            // 
            this.absencesEventDetails1.Location = new System.Drawing.Point(0, 145);
            this.absencesEventDetails1.Name = "absencesEventDetails1";
            this.absencesEventDetails1.Size = new System.Drawing.Size(1462, 646);
            this.absencesEventDetails1.TabIndex = 0;
            // 
            // eventName_gunaLabel
            // 
            this.eventName_gunaLabel.AutoSize = true;
            this.eventName_gunaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventName_gunaLabel.Location = new System.Drawing.Point(603, 102);
            this.eventName_gunaLabel.Name = "eventName_gunaLabel";
            this.eventName_gunaLabel.Size = new System.Drawing.Size(345, 31);
            this.eventName_gunaLabel.TabIndex = 7;
            this.eventName_gunaLabel.Text = "Rhuel BDay Party with PBD date";
            // 
            // eventNameText_gunaLabel
            // 
            this.eventNameText_gunaLabel.AutoSize = true;
            this.eventNameText_gunaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameText_gunaLabel.Location = new System.Drawing.Point(444, 102);
            this.eventNameText_gunaLabel.Name = "eventNameText_gunaLabel";
            this.eventNameText_gunaLabel.Size = new System.Drawing.Size(140, 31);
            this.eventNameText_gunaLabel.TabIndex = 8;
            this.eventNameText_gunaLabel.Text = "Event name:";
            // 
            // EventDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 803);
            this.Controls.Add(this.eventNameText_gunaLabel);
            this.Controls.Add(this.eventName_gunaLabel);
            // this.Controls.Add(this.absencesEventDetails1);
            //this.Controls.Add(this.scanEventDetails1);
            this.Controls.Add(this.absences_gunaAdvenceButton);
            this.Controls.Add(this.scan_gunaAdvenceButton);
            this.Controls.Add(this.EventDetailsTitle_gunaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EventDetailsForm";
            this.EventDetailsTitle_gunaPanel.ResumeLayout(false);
            this.EventDetailsTitle_gunaPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel EventDetailsTitle_gunaPanel;
        private Guna.UI.WinForms.GunaLabel EventDetailsText_gunaLabel;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaAdvenceButton scan_gunaAdvenceButton;
        private Guna.UI.WinForms.GunaAdvenceButton absences_gunaAdvenceButton;
        private UserControls.ScanEventDetails scanEventDetails1;
        private UserControls.AbsencesEventDetails absencesEventDetails1;
        private Guna.UI.WinForms.GunaLabel eventName_gunaLabel;
        private Guna.UI.WinForms.GunaLabel eventNameText_gunaLabel;
    }
}