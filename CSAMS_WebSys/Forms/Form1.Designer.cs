namespace CSAMS_WebSys.Forms
{
    partial class Form1
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
            this.ScannerTitle_gunaPanel = new Guna.UI.WinForms.GunaPanel();
            this.eventDetailsText_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.AddEvents_gunaAdvenceButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.eventNameText = new System.Windows.Forms.Label();
            this.eventName = new System.Windows.Forms.Label();
            this.scanButtomEventDetails1 = new CSAMS_WebSys.UserControls.scanButtomEventDetails();
            this.absencesButtomEventDetails1 = new CSAMS_WebSys.UserControls.absencesButtomEventDetails();
            this.ScannerTitle_gunaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScannerTitle_gunaPanel
            // 
            this.ScannerTitle_gunaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.ScannerTitle_gunaPanel.Controls.Add(this.eventDetailsText_gunaLabel);
            this.ScannerTitle_gunaPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ScannerTitle_gunaPanel.Location = new System.Drawing.Point(0, 0);
            this.ScannerTitle_gunaPanel.Name = "ScannerTitle_gunaPanel";
            this.ScannerTitle_gunaPanel.Size = new System.Drawing.Size(1462, 91);
            this.ScannerTitle_gunaPanel.TabIndex = 3;
            // 
            // eventDetailsText_gunaLabel
            // 
            this.eventDetailsText_gunaLabel.AutoSize = true;
            this.eventDetailsText_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.eventDetailsText_gunaLabel.ForeColor = System.Drawing.Color.White;
            this.eventDetailsText_gunaLabel.Location = new System.Drawing.Point(24, 16);
            this.eventDetailsText_gunaLabel.Name = "eventDetailsText_gunaLabel";
            this.eventDetailsText_gunaLabel.Size = new System.Drawing.Size(269, 54);
            this.eventDetailsText_gunaLabel.TabIndex = 1;
            this.eventDetailsText_gunaLabel.Text = "Event Details";
            // 
            // AddEvents_gunaAdvenceButton
            // 
            this.AddEvents_gunaAdvenceButton.AnimationHoverSpeed = 0.07F;
            this.AddEvents_gunaAdvenceButton.AnimationSpeed = 0.03F;
            this.AddEvents_gunaAdvenceButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.AddEvents_gunaAdvenceButton.BorderColor = System.Drawing.Color.Black;
            this.AddEvents_gunaAdvenceButton.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.AddEvents_gunaAdvenceButton.Checked = true;
            this.AddEvents_gunaAdvenceButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.AddEvents_gunaAdvenceButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.AddEvents_gunaAdvenceButton.CheckedForeColor = System.Drawing.Color.White;
            this.AddEvents_gunaAdvenceButton.CheckedImage = null;
            this.AddEvents_gunaAdvenceButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AddEvents_gunaAdvenceButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEvents_gunaAdvenceButton.ForeColor = System.Drawing.Color.White;
            this.AddEvents_gunaAdvenceButton.Image = null;
            this.AddEvents_gunaAdvenceButton.ImageSize = new System.Drawing.Size(20, 20);
            this.AddEvents_gunaAdvenceButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddEvents_gunaAdvenceButton.Location = new System.Drawing.Point(33, 97);
            this.AddEvents_gunaAdvenceButton.Name = "AddEvents_gunaAdvenceButton";
            this.AddEvents_gunaAdvenceButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.AddEvents_gunaAdvenceButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddEvents_gunaAdvenceButton.OnHoverForeColor = System.Drawing.Color.White;
            this.AddEvents_gunaAdvenceButton.OnHoverImage = null;
            this.AddEvents_gunaAdvenceButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddEvents_gunaAdvenceButton.OnPressedColor = System.Drawing.Color.Black;
            this.AddEvents_gunaAdvenceButton.Radius = 8;
            this.AddEvents_gunaAdvenceButton.Size = new System.Drawing.Size(210, 40);
            this.AddEvents_gunaAdvenceButton.TabIndex = 4;
            this.AddEvents_gunaAdvenceButton.Text = "Scan";
            this.AddEvents_gunaAdvenceButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddEvents_gunaAdvenceButton.Click += new System.EventHandler(this.AddEvents_gunaAdvenceButton_Click);
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = null;
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = null;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(261, 97);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 8;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(210, 40);
            this.gunaAdvenceButton1.TabIndex = 5;
            this.gunaAdvenceButton1.Text = "Absences";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // eventNameText
            // 
            this.eventNameText.AutoSize = true;
            this.eventNameText.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameText.Location = new System.Drawing.Point(487, 102);
            this.eventNameText.Name = "eventNameText";
            this.eventNameText.Size = new System.Drawing.Size(151, 31);
            this.eventNameText.TabIndex = 6;
            this.eventNameText.Text = "Event Name: ";
            // 
            // eventName
            // 
            this.eventName.AutoSize = true;
            this.eventName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventName.Location = new System.Drawing.Point(653, 102);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(135, 31);
            this.eventName.TabIndex = 7;
            this.eventName.Text = "Rhuel BDAY";
            // 
            // scanButtomEventDetails1
            // 
            this.scanButtomEventDetails1.Location = new System.Drawing.Point(0, 145);
            this.scanButtomEventDetails1.Name = "scanButtomEventDetails1";
            this.scanButtomEventDetails1.Size = new System.Drawing.Size(1462, 646);
            this.scanButtomEventDetails1.TabIndex = 8;
            // 
            // absencesButtomEventDetails1
            // 
            this.absencesButtomEventDetails1.Location = new System.Drawing.Point(0, 145);
            this.absencesButtomEventDetails1.Name = "absencesButtomEventDetails1";
            this.absencesButtomEventDetails1.Size = new System.Drawing.Size(1462, 646);
            this.absencesButtomEventDetails1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1462, 803);
            this.Controls.Add(this.absencesButtomEventDetails1);
            this.Controls.Add(this.scanButtomEventDetails1);
            this.Controls.Add(this.eventName);
            this.Controls.Add(this.eventNameText);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.AddEvents_gunaAdvenceButton);
            this.Controls.Add(this.ScannerTitle_gunaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ScannerTitle_gunaPanel.ResumeLayout(false);
            this.ScannerTitle_gunaPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel ScannerTitle_gunaPanel;
        private Guna.UI.WinForms.GunaLabel eventDetailsText_gunaLabel;
        private Guna.UI.WinForms.GunaAdvenceButton AddEvents_gunaAdvenceButton;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private System.Windows.Forms.Label eventNameText;
        private System.Windows.Forms.Label eventName;
        private UserControls.scanButtomEventDetails scanButtomEventDetails1;
        private UserControls.absencesButtomEventDetails absencesButtomEventDetails1;
    }
}