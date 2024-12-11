namespace CSAMS_WebSys.Forms
{
    partial class AddMemberForm
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
            this.AddMembersTitle_gunaPanel = new Guna.UI.WinForms.GunaPanel();
            this.AddMembers_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.LastName_gunaTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.FirstName_gunaTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.LastNameText_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.FirstNameText_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.YearLevel_gunaComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.Status_gunaComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.YearLevelText_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.Status_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.StudentID_gunaTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.StudentIDText_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.DateTimeText_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.DateAdded_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimeAdded_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.ttAdded_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.AddMember_gunaAdvenceButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Status = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AddMembersTitle_gunaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddMembersTitle_gunaPanel
            // 
            this.AddMembersTitle_gunaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.AddMembersTitle_gunaPanel.Controls.Add(this.AddMembers_gunaLabel);
            this.AddMembersTitle_gunaPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddMembersTitle_gunaPanel.Location = new System.Drawing.Point(0, 0);
            this.AddMembersTitle_gunaPanel.Name = "AddMembersTitle_gunaPanel";
            this.AddMembersTitle_gunaPanel.Size = new System.Drawing.Size(640, 91);
            this.AddMembersTitle_gunaPanel.TabIndex = 0;
            // 
            // AddMembers_gunaLabel
            // 
            this.AddMembers_gunaLabel.AutoSize = true;
            this.AddMembers_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.AddMembers_gunaLabel.ForeColor = System.Drawing.Color.White;
            this.AddMembers_gunaLabel.Location = new System.Drawing.Point(24, 16);
            this.AddMembers_gunaLabel.Name = "AddMembers_gunaLabel";
            this.AddMembers_gunaLabel.Size = new System.Drawing.Size(290, 54);
            this.AddMembers_gunaLabel.TabIndex = 1;
            this.AddMembers_gunaLabel.Text = "Add Members";
            // 
            // LastName_gunaTextBox
            // 
            this.LastName_gunaTextBox.BaseColor = System.Drawing.Color.White;
            this.LastName_gunaTextBox.BorderColor = System.Drawing.Color.Silver;
            this.LastName_gunaTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LastName_gunaTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.LastName_gunaTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.LastName_gunaTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.LastName_gunaTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName_gunaTextBox.Location = new System.Drawing.Point(33, 139);
            this.LastName_gunaTextBox.Name = "LastName_gunaTextBox";
            this.LastName_gunaTextBox.PasswordChar = '\0';
            this.LastName_gunaTextBox.Radius = 8;
            this.LastName_gunaTextBox.Size = new System.Drawing.Size(359, 40);
            this.LastName_gunaTextBox.TabIndex = 4;
            // 
            // FirstName_gunaTextBox
            // 
            this.FirstName_gunaTextBox.BaseColor = System.Drawing.Color.White;
            this.FirstName_gunaTextBox.BorderColor = System.Drawing.Color.Silver;
            this.FirstName_gunaTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FirstName_gunaTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.FirstName_gunaTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.FirstName_gunaTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.FirstName_gunaTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName_gunaTextBox.Location = new System.Drawing.Point(33, 225);
            this.FirstName_gunaTextBox.Name = "FirstName_gunaTextBox";
            this.FirstName_gunaTextBox.PasswordChar = '\0';
            this.FirstName_gunaTextBox.Radius = 8;
            this.FirstName_gunaTextBox.Size = new System.Drawing.Size(359, 40);
            this.FirstName_gunaTextBox.TabIndex = 5;
            // 
            // LastNameText_gunaLabel
            // 
            this.LastNameText_gunaLabel.AutoSize = true;
            this.LastNameText_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameText_gunaLabel.Location = new System.Drawing.Point(29, 113);
            this.LastNameText_gunaLabel.Name = "LastNameText_gunaLabel";
            this.LastNameText_gunaLabel.Size = new System.Drawing.Size(91, 23);
            this.LastNameText_gunaLabel.TabIndex = 6;
            this.LastNameText_gunaLabel.Text = "Last Name";
            // 
            // FirstNameText_gunaLabel
            // 
            this.FirstNameText_gunaLabel.AutoSize = true;
            this.FirstNameText_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameText_gunaLabel.Location = new System.Drawing.Point(29, 199);
            this.FirstNameText_gunaLabel.Name = "FirstNameText_gunaLabel";
            this.FirstNameText_gunaLabel.Size = new System.Drawing.Size(92, 23);
            this.FirstNameText_gunaLabel.TabIndex = 7;
            this.FirstNameText_gunaLabel.Text = "First Name";
            // 
            // YearLevel_gunaComboBox
            // 
            this.YearLevel_gunaComboBox.BackColor = System.Drawing.Color.Transparent;
            this.YearLevel_gunaComboBox.BaseColor = System.Drawing.Color.White;
            this.YearLevel_gunaComboBox.BorderColor = System.Drawing.Color.Silver;
            this.YearLevel_gunaComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.YearLevel_gunaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearLevel_gunaComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLevel_gunaComboBox.ForeColor = System.Drawing.Color.Black;
            this.YearLevel_gunaComboBox.FormattingEnabled = true;
            this.YearLevel_gunaComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5th above"});
            this.YearLevel_gunaComboBox.Location = new System.Drawing.Point(449, 139);
            this.YearLevel_gunaComboBox.Name = "YearLevel_gunaComboBox";
            this.YearLevel_gunaComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.YearLevel_gunaComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.YearLevel_gunaComboBox.Size = new System.Drawing.Size(145, 31);
            this.YearLevel_gunaComboBox.TabIndex = 8;
            // 
            // Status_gunaComboBox
            // 
            this.Status_gunaComboBox.BackColor = System.Drawing.Color.Transparent;
            this.Status_gunaComboBox.BaseColor = System.Drawing.Color.White;
            this.Status_gunaComboBox.BorderColor = System.Drawing.Color.Silver;
            this.Status_gunaComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Status_gunaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status_gunaComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_gunaComboBox.ForeColor = System.Drawing.Color.Black;
            this.Status_gunaComboBox.FormattingEnabled = true;
            this.Status_gunaComboBox.Items.AddRange(new object[] {
            "Regular",
            "Irregular"});
            this.Status_gunaComboBox.Location = new System.Drawing.Point(449, 231);
            this.Status_gunaComboBox.Name = "Status_gunaComboBox";
            this.Status_gunaComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Status_gunaComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.Status_gunaComboBox.Size = new System.Drawing.Size(145, 31);
            this.Status_gunaComboBox.TabIndex = 9;
            // 
            // YearLevelText_gunaLabel
            // 
            this.YearLevelText_gunaLabel.AutoSize = true;
            this.YearLevelText_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLevelText_gunaLabel.Location = new System.Drawing.Point(445, 113);
            this.YearLevelText_gunaLabel.Name = "YearLevelText_gunaLabel";
            this.YearLevelText_gunaLabel.Size = new System.Drawing.Size(85, 23);
            this.YearLevelText_gunaLabel.TabIndex = 10;
            this.YearLevelText_gunaLabel.Text = "Year Level";
            // 
            // Status_gunaLabel
            // 
            this.Status_gunaLabel.AutoSize = true;
            this.Status_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_gunaLabel.Location = new System.Drawing.Point(445, 205);
            this.Status_gunaLabel.Name = "Status_gunaLabel";
            this.Status_gunaLabel.Size = new System.Drawing.Size(120, 23);
            this.Status_gunaLabel.TabIndex = 11;
            this.Status_gunaLabel.Text = "Student Status";
            // 
            // StudentID_gunaTextBox
            // 
            this.StudentID_gunaTextBox.BaseColor = System.Drawing.Color.White;
            this.StudentID_gunaTextBox.BorderColor = System.Drawing.Color.Silver;
            this.StudentID_gunaTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StudentID_gunaTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.StudentID_gunaTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.StudentID_gunaTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.StudentID_gunaTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentID_gunaTextBox.Location = new System.Drawing.Point(33, 312);
            this.StudentID_gunaTextBox.Name = "StudentID_gunaTextBox";
            this.StudentID_gunaTextBox.PasswordChar = '\0';
            this.StudentID_gunaTextBox.Radius = 8;
            this.StudentID_gunaTextBox.Size = new System.Drawing.Size(232, 40);
            this.StudentID_gunaTextBox.TabIndex = 12;
            // 
            // StudentIDText_gunaLabel
            // 
            this.StudentIDText_gunaLabel.AutoSize = true;
            this.StudentIDText_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIDText_gunaLabel.Location = new System.Drawing.Point(29, 286);
            this.StudentIDText_gunaLabel.Name = "StudentIDText_gunaLabel";
            this.StudentIDText_gunaLabel.Size = new System.Drawing.Size(91, 23);
            this.StudentIDText_gunaLabel.TabIndex = 13;
            this.StudentIDText_gunaLabel.Text = "Student ID";
            // 
            // DateTimeText_gunaLabel
            // 
            this.DateTimeText_gunaLabel.AutoSize = true;
            this.DateTimeText_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeText_gunaLabel.Location = new System.Drawing.Point(30, 369);
            this.DateTimeText_gunaLabel.Name = "DateTimeText_gunaLabel";
            this.DateTimeText_gunaLabel.Size = new System.Drawing.Size(175, 23);
            this.DateTimeText_gunaLabel.TabIndex = 15;
            this.DateTimeText_gunaLabel.Text = "Date and Time added";
            // 
            // DateAdded_gunaLabel
            // 
            this.DateAdded_gunaLabel.AutoSize = true;
            this.DateAdded_gunaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateAdded_gunaLabel.Location = new System.Drawing.Point(30, 392);
            this.DateAdded_gunaLabel.Name = "DateAdded_gunaLabel";
            this.DateAdded_gunaLabel.Size = new System.Drawing.Size(85, 28);
            this.DateAdded_gunaLabel.TabIndex = 16;
            this.DateAdded_gunaLabel.Text = "12/12/12";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimeAdded_gunaLabel
            // 
            this.TimeAdded_gunaLabel.AutoSize = true;
            this.TimeAdded_gunaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeAdded_gunaLabel.Location = new System.Drawing.Point(153, 392);
            this.TimeAdded_gunaLabel.Name = "TimeAdded_gunaLabel";
            this.TimeAdded_gunaLabel.Size = new System.Drawing.Size(61, 28);
            this.TimeAdded_gunaLabel.TabIndex = 18;
            this.TimeAdded_gunaLabel.Text = "09:09";
            // 
            // ttAdded_gunaLabel
            // 
            this.ttAdded_gunaLabel.AutoSize = true;
            this.ttAdded_gunaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttAdded_gunaLabel.Location = new System.Drawing.Point(211, 392);
            this.ttAdded_gunaLabel.Name = "ttAdded_gunaLabel";
            this.ttAdded_gunaLabel.Size = new System.Drawing.Size(42, 28);
            this.ttAdded_gunaLabel.TabIndex = 19;
            this.ttAdded_gunaLabel.Text = "pm";
            // 
            // AddMember_gunaAdvenceButton
            // 
            this.AddMember_gunaAdvenceButton.AnimationHoverSpeed = 0.07F;
            this.AddMember_gunaAdvenceButton.AnimationSpeed = 0.03F;
            this.AddMember_gunaAdvenceButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.AddMember_gunaAdvenceButton.BorderColor = System.Drawing.Color.Black;
            this.AddMember_gunaAdvenceButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.AddMember_gunaAdvenceButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.AddMember_gunaAdvenceButton.CheckedForeColor = System.Drawing.Color.White;
            this.AddMember_gunaAdvenceButton.CheckedImage = null;
            this.AddMember_gunaAdvenceButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AddMember_gunaAdvenceButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMember_gunaAdvenceButton.ForeColor = System.Drawing.Color.White;
            this.AddMember_gunaAdvenceButton.Image = null;
            this.AddMember_gunaAdvenceButton.ImageSize = new System.Drawing.Size(20, 20);
            this.AddMember_gunaAdvenceButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddMember_gunaAdvenceButton.Location = new System.Drawing.Point(406, 483);
            this.AddMember_gunaAdvenceButton.Name = "AddMember_gunaAdvenceButton";
            this.AddMember_gunaAdvenceButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.AddMember_gunaAdvenceButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddMember_gunaAdvenceButton.OnHoverForeColor = System.Drawing.Color.White;
            this.AddMember_gunaAdvenceButton.OnHoverImage = null;
            this.AddMember_gunaAdvenceButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddMember_gunaAdvenceButton.OnPressedColor = System.Drawing.Color.Black;
            this.AddMember_gunaAdvenceButton.Radius = 8;
            this.AddMember_gunaAdvenceButton.Size = new System.Drawing.Size(179, 40);
            this.AddMember_gunaAdvenceButton.TabIndex = 17;
            this.AddMember_gunaAdvenceButton.Text = "Scan Biometrics";
            this.AddMember_gunaAdvenceButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddMember_gunaAdvenceButton.Click += new System.EventHandler(this.AddMember_gunaAdvenceButton_Click);
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
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(35, 483);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 8;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(179, 40);
            this.gunaAdvenceButton1.TabIndex = 21;
            this.gunaAdvenceButton1.Text = "Add Member";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(406, 357);
            this.label1.Multiline = true;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 108);
            this.label1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 22;
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 0;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.Location = new System.Drawing.Point(35, 445);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(158, 20);
            this.guna2CheckBox1.TabIndex = 24;
            this.guna2CheckBox1.Text = "Add without fingerprint";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.Transparent;
            this.Status.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Status.Location = new System.Drawing.Point(406, 333);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(6, 19);
            this.Status.TabIndex = 25;
            this.Status.Text = ".";
            // 
            // AddMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 535);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.guna2CheckBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.ttAdded_gunaLabel);
            this.Controls.Add(this.TimeAdded_gunaLabel);
            this.Controls.Add(this.AddMember_gunaAdvenceButton);
            this.Controls.Add(this.DateAdded_gunaLabel);
            this.Controls.Add(this.DateTimeText_gunaLabel);
            this.Controls.Add(this.StudentIDText_gunaLabel);
            this.Controls.Add(this.StudentID_gunaTextBox);
            this.Controls.Add(this.Status_gunaLabel);
            this.Controls.Add(this.YearLevelText_gunaLabel);
            this.Controls.Add(this.Status_gunaComboBox);
            this.Controls.Add(this.YearLevel_gunaComboBox);
            this.Controls.Add(this.FirstNameText_gunaLabel);
            this.Controls.Add(this.LastNameText_gunaLabel);
            this.Controls.Add(this.FirstName_gunaTextBox);
            this.Controls.Add(this.LastName_gunaTextBox);
            this.Controls.Add(this.AddMembersTitle_gunaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddMemberForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddMemberForm_FormClosing);
            this.Load += new System.EventHandler(this.AddMemberForm_Load);
            this.AddMembersTitle_gunaPanel.ResumeLayout(false);
            this.AddMembersTitle_gunaPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel AddMembersTitle_gunaPanel;
        private Guna.UI.WinForms.GunaLabel AddMembers_gunaLabel;
        private Guna.UI.WinForms.GunaTextBox LastName_gunaTextBox;
        private Guna.UI.WinForms.GunaTextBox FirstName_gunaTextBox;
        private Guna.UI.WinForms.GunaLabel LastNameText_gunaLabel;
        private Guna.UI.WinForms.GunaLabel FirstNameText_gunaLabel;
        private Guna.UI.WinForms.GunaComboBox YearLevel_gunaComboBox;
        private Guna.UI.WinForms.GunaComboBox Status_gunaComboBox;
        private Guna.UI.WinForms.GunaLabel YearLevelText_gunaLabel;
        private Guna.UI.WinForms.GunaLabel Status_gunaLabel;
        private Guna.UI.WinForms.GunaTextBox StudentID_gunaTextBox;
        private Guna.UI.WinForms.GunaLabel StudentIDText_gunaLabel;
        private Guna.UI.WinForms.GunaLabel DateTimeText_gunaLabel;
        private Guna.UI.WinForms.GunaLabel DateAdded_gunaLabel;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaLabel TimeAdded_gunaLabel;
        private Guna.UI.WinForms.GunaLabel ttAdded_gunaLabel;
        private Guna.UI.WinForms.GunaAdvenceButton AddMember_gunaAdvenceButton;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Status;
    }
}