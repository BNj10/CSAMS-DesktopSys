namespace CSAMS_WebSys.Forms
{
    partial class AddSchoolYear
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
            this.MemYearLevelTitle_gunaPanel = new Guna.UI.WinForms.GunaPanel();
            this.YearLevelTitle_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.EventNameText_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.SchoolYear = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.guna2DateTimePicker3 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.MemYearLevelTitle_gunaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MemYearLevelTitle_gunaPanel
            // 
            this.MemYearLevelTitle_gunaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.MemYearLevelTitle_gunaPanel.Controls.Add(this.YearLevelTitle_gunaLabel);
            this.MemYearLevelTitle_gunaPanel.Location = new System.Drawing.Point(1, 1);
            this.MemYearLevelTitle_gunaPanel.Name = "MemYearLevelTitle_gunaPanel";
            this.MemYearLevelTitle_gunaPanel.Size = new System.Drawing.Size(405, 75);
            this.MemYearLevelTitle_gunaPanel.TabIndex = 8;
            // 
            // YearLevelTitle_gunaLabel
            // 
            this.YearLevelTitle_gunaLabel.AutoSize = true;
            this.YearLevelTitle_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.YearLevelTitle_gunaLabel.ForeColor = System.Drawing.Color.White;
            this.YearLevelTitle_gunaLabel.Location = new System.Drawing.Point(14, 18);
            this.YearLevelTitle_gunaLabel.Name = "YearLevelTitle_gunaLabel";
            this.YearLevelTitle_gunaLabel.Size = new System.Drawing.Size(258, 32);
            this.YearLevelTitle_gunaLabel.TabIndex = 0;
            this.YearLevelTitle_gunaLabel.Text = "Add New School Year";
            // 
            // EventNameText_gunaLabel
            // 
            this.EventNameText_gunaLabel.AutoSize = true;
            this.EventNameText_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.EventNameText_gunaLabel.Location = new System.Drawing.Point(19, 98);
            this.EventNameText_gunaLabel.Name = "EventNameText_gunaLabel";
            this.EventNameText_gunaLabel.Size = new System.Drawing.Size(113, 28);
            this.EventNameText_gunaLabel.TabIndex = 24;
            this.EventNameText_gunaLabel.Text = "School Year";
            // 
            // SchoolYear
            // 
            this.SchoolYear.BaseColor = System.Drawing.Color.White;
            this.SchoolYear.BorderColor = System.Drawing.Color.Silver;
            this.SchoolYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SchoolYear.FocusedBaseColor = System.Drawing.Color.White;
            this.SchoolYear.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.SchoolYear.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.SchoolYear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SchoolYear.Location = new System.Drawing.Point(24, 138);
            this.SchoolYear.Name = "SchoolYear";
            this.SchoolYear.PasswordChar = '\0';
            this.SchoolYear.Radius = 8;
            this.SchoolYear.Size = new System.Drawing.Size(186, 40);
            this.SchoolYear.TabIndex = 25;
            this.SchoolYear.Text = "2024-2025";
            this.SchoolYear.Enter += new System.EventHandler(this.onEnter);
            this.SchoolYear.Leave += new System.EventHandler(this.onLeave);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gunaLabel1.Location = new System.Drawing.Point(19, 200);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(94, 28);
            this.gunaLabel1.TabIndex = 26;
            this.gunaLabel1.Text = "StartDate";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(24, 242);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(252, 36);
            this.guna2DateTimePicker1.TabIndex = 27;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 12, 7, 22, 18, 0, 531);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gunaLabel2.Location = new System.Drawing.Point(19, 308);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(91, 28);
            this.gunaLabel2.TabIndex = 28;
            this.gunaLabel2.Text = "End Date";
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
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
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(21, 425);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 8;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(155, 40);
            this.gunaAdvenceButton1.TabIndex = 34;
            this.gunaAdvenceButton1.Text = "Add";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaAdvenceButton2
            // 
            this.gunaAdvenceButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.gunaAdvenceButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.gunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.CheckedImage = null;
            this.gunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.Image = null;
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(240, 425);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.OnHoverImage = null;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.Radius = 8;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(155, 40);
            this.gunaAdvenceButton2.TabIndex = 35;
            this.gunaAdvenceButton2.Text = "Cancel";
            this.gunaAdvenceButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton2.Click += new System.EventHandler(this.gunaAdvenceButton2_Click);
            // 
            // guna2DateTimePicker3
            // 
            this.guna2DateTimePicker3.Checked = true;
            this.guna2DateTimePicker3.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker3.Location = new System.Drawing.Point(21, 348);
            this.guna2DateTimePicker3.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker3.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker3.Name = "guna2DateTimePicker3";
            this.guna2DateTimePicker3.Size = new System.Drawing.Size(251, 36);
            this.guna2DateTimePicker3.TabIndex = 36;
            this.guna2DateTimePicker3.Value = new System.DateTime(2024, 12, 7, 22, 18, 3, 357);
            // 
            // AddSchoolYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 476);
            this.Controls.Add(this.guna2DateTimePicker3);
            this.Controls.Add(this.gunaAdvenceButton2);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.SchoolYear);
            this.Controls.Add(this.EventNameText_gunaLabel);
            this.Controls.Add(this.MemYearLevelTitle_gunaPanel);
            this.Name = "AddSchoolYear";
            this.Text = "AddSchoolYear";
            this.MemYearLevelTitle_gunaPanel.ResumeLayout(false);
            this.MemYearLevelTitle_gunaPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel MemYearLevelTitle_gunaPanel;
        private Guna.UI.WinForms.GunaLabel YearLevelTitle_gunaLabel;
        private Guna.UI.WinForms.GunaLabel EventNameText_gunaLabel;
        private Guna.UI.WinForms.GunaTextBox SchoolYear;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker3;
    }
}