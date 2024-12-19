namespace CSAMS_WebSys.UserControls
{
    partial class scanButtomEventDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ScanText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.ttAdded_gunaLabel = new System.Windows.Forms.Label();
            this.timeInText = new System.Windows.Forms.Label();
            this.numOfAtendeesText = new System.Windows.Forms.Label();
            this.numOfAtendees_value = new System.Windows.Forms.Label();
            this.AtendeesData_gunaDataGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.scanButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.scannedAtendeesText = new System.Windows.Forms.Label();
            this.FilterAtendees_gunaComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.FilterText_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.SearchAtendees_gunaAdvenceButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SearchAtendees_gunaTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.tabelText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AtendeesData_gunaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ScanText
            // 
            this.ScanText.AutoSize = true;
            this.ScanText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanText.Location = new System.Drawing.Point(46, 0);
            this.ScanText.Name = "ScanText";
            this.ScanText.Size = new System.Drawing.Size(110, 54);
            this.ScanText.TabIndex = 0;
            this.ScanText.Text = "Scan";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // ttAdded_gunaLabel
            // 
            this.ttAdded_gunaLabel.AutoSize = true;
            this.ttAdded_gunaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttAdded_gunaLabel.Location = new System.Drawing.Point(43, 181);
            this.ttAdded_gunaLabel.Name = "ttAdded_gunaLabel";
            this.ttAdded_gunaLabel.Size = new System.Drawing.Size(61, 28);
            this.ttAdded_gunaLabel.TabIndex = 4;
            this.ttAdded_gunaLabel.Text = "00:00";
            // 
            // timeInText
            // 
            this.timeInText.AutoSize = true;
            this.timeInText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeInText.Location = new System.Drawing.Point(44, 146);
            this.timeInText.Name = "timeInText";
            this.timeInText.Size = new System.Drawing.Size(72, 23);
            this.timeInText.TabIndex = 5;
            this.timeInText.Text = "Time-in:";
            // 
            // numOfAtendeesText
            // 
            this.numOfAtendeesText.AutoSize = true;
            this.numOfAtendeesText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfAtendeesText.Location = new System.Drawing.Point(19, 371);
            this.numOfAtendeesText.Name = "numOfAtendeesText";
            this.numOfAtendeesText.Size = new System.Drawing.Size(137, 23);
            this.numOfAtendeesText.TabIndex = 7;
            this.numOfAtendeesText.Text = "No. of Atendees:";
            // 
            // numOfAtendees_value
            // 
            this.numOfAtendees_value.AutoSize = true;
            this.numOfAtendees_value.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfAtendees_value.Location = new System.Drawing.Point(50, 429);
            this.numOfAtendees_value.Name = "numOfAtendees_value";
            this.numOfAtendees_value.Size = new System.Drawing.Size(45, 28);
            this.numOfAtendees_value.TabIndex = 6;
            this.numOfAtendees_value.Text = "999";
            // 
            // AtendeesData_gunaDataGridView
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.AtendeesData_gunaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.AtendeesData_gunaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AtendeesData_gunaDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.AtendeesData_gunaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AtendeesData_gunaDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AtendeesData_gunaDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AtendeesData_gunaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.AtendeesData_gunaDataGridView.ColumnHeadersHeight = 4;
            this.AtendeesData_gunaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AtendeesData_gunaDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.AtendeesData_gunaDataGridView.EnableHeadersVisualStyles = false;
            this.AtendeesData_gunaDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.AtendeesData_gunaDataGridView.Location = new System.Drawing.Point(293, 181);
            this.AtendeesData_gunaDataGridView.Name = "AtendeesData_gunaDataGridView";
            this.AtendeesData_gunaDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.AtendeesData_gunaDataGridView.RowHeadersVisible = false;
            this.AtendeesData_gunaDataGridView.RowHeadersWidth = 51;
            this.AtendeesData_gunaDataGridView.RowTemplate.Height = 24;
            this.AtendeesData_gunaDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AtendeesData_gunaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AtendeesData_gunaDataGridView.Size = new System.Drawing.Size(1123, 401);
            this.AtendeesData_gunaDataGridView.TabIndex = 27;
            this.AtendeesData_gunaDataGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Indigo;
            this.AtendeesData_gunaDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.AtendeesData_gunaDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AtendeesData_gunaDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AtendeesData_gunaDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AtendeesData_gunaDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AtendeesData_gunaDataGridView.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.AtendeesData_gunaDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.AtendeesData_gunaDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.AtendeesData_gunaDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.AtendeesData_gunaDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.AtendeesData_gunaDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AtendeesData_gunaDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AtendeesData_gunaDataGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.AtendeesData_gunaDataGridView.ThemeStyle.ReadOnly = false;
            this.AtendeesData_gunaDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.AtendeesData_gunaDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AtendeesData_gunaDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.AtendeesData_gunaDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.AtendeesData_gunaDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.AtendeesData_gunaDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.AtendeesData_gunaDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.AtendeesData_gunaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AtendeesData_gunaDataGridView_CellClick);
            // 
            // scanButton
            // 
            this.scanButton.AnimationHoverSpeed = 0.07F;
            this.scanButton.AnimationSpeed = 0.03F;
            this.scanButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.scanButton.BorderColor = System.Drawing.Color.Black;
            this.scanButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.scanButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.scanButton.CheckedForeColor = System.Drawing.Color.White;
            this.scanButton.CheckedImage = null;
            this.scanButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.scanButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanButton.ForeColor = System.Drawing.Color.White;
            this.scanButton.Image = null;
            this.scanButton.ImageSize = new System.Drawing.Size(20, 20);
            this.scanButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.scanButton.Location = new System.Drawing.Point(55, 57);
            this.scanButton.Name = "scanButton";
            this.scanButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.scanButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.scanButton.OnHoverForeColor = System.Drawing.Color.White;
            this.scanButton.OnHoverImage = null;
            this.scanButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.scanButton.OnPressedColor = System.Drawing.Color.Black;
            this.scanButton.Radius = 8;
            this.scanButton.Size = new System.Drawing.Size(210, 55);
            this.scanButton.TabIndex = 34;
            this.scanButton.Text = "Scan Fingerprint";
            this.scanButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // scannedAtendeesText
            // 
            this.scannedAtendeesText.AutoSize = true;
            this.scannedAtendeesText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scannedAtendeesText.Location = new System.Drawing.Point(284, 47);
            this.scannedAtendeesText.Name = "scannedAtendeesText";
            this.scannedAtendeesText.Size = new System.Drawing.Size(368, 54);
            this.scannedAtendeesText.TabIndex = 35;
            this.scannedAtendeesText.Text = "Scanned Atendees";
            // 
            // FilterAtendees_gunaComboBox
            // 
            this.FilterAtendees_gunaComboBox.BackColor = System.Drawing.Color.Transparent;
            this.FilterAtendees_gunaComboBox.BaseColor = System.Drawing.Color.White;
            this.FilterAtendees_gunaComboBox.BorderColor = System.Drawing.Color.Silver;
            this.FilterAtendees_gunaComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FilterAtendees_gunaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterAtendees_gunaComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FilterAtendees_gunaComboBox.ForeColor = System.Drawing.Color.Black;
            this.FilterAtendees_gunaComboBox.FormattingEnabled = true;
            this.FilterAtendees_gunaComboBox.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5th above"});
            this.FilterAtendees_gunaComboBox.Location = new System.Drawing.Point(1121, 68);
            this.FilterAtendees_gunaComboBox.Name = "FilterAtendees_gunaComboBox";
            this.FilterAtendees_gunaComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.FilterAtendees_gunaComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.FilterAtendees_gunaComboBox.Size = new System.Drawing.Size(280, 31);
            this.FilterAtendees_gunaComboBox.TabIndex = 39;
            // 
            // FilterText_gunaLabel
            // 
            this.FilterText_gunaLabel.AutoSize = true;
            this.FilterText_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterText_gunaLabel.Location = new System.Drawing.Point(1050, 68);
            this.FilterText_gunaLabel.Name = "FilterText_gunaLabel";
            this.FilterText_gunaLabel.Size = new System.Drawing.Size(56, 28);
            this.FilterText_gunaLabel.TabIndex = 38;
            this.FilterText_gunaLabel.Text = "Filter";
            // 
            // SearchAtendees_gunaAdvenceButton
            // 
            this.SearchAtendees_gunaAdvenceButton.AnimationHoverSpeed = 0.07F;
            this.SearchAtendees_gunaAdvenceButton.AnimationSpeed = 0.03F;
            this.SearchAtendees_gunaAdvenceButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchAtendees_gunaAdvenceButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.SearchAtendees_gunaAdvenceButton.BorderColor = System.Drawing.Color.Transparent;
            this.SearchAtendees_gunaAdvenceButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.SearchAtendees_gunaAdvenceButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.SearchAtendees_gunaAdvenceButton.CheckedForeColor = System.Drawing.Color.White;
            this.SearchAtendees_gunaAdvenceButton.CheckedImage = global::CSAMS_WebSys.Properties.Resources.search_img;
            this.SearchAtendees_gunaAdvenceButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.SearchAtendees_gunaAdvenceButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchAtendees_gunaAdvenceButton.ForeColor = System.Drawing.Color.White;
            this.SearchAtendees_gunaAdvenceButton.Image = global::CSAMS_WebSys.Properties.Resources.search_img;
            this.SearchAtendees_gunaAdvenceButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchAtendees_gunaAdvenceButton.ImageSize = new System.Drawing.Size(20, 20);
            this.SearchAtendees_gunaAdvenceButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SearchAtendees_gunaAdvenceButton.Location = new System.Drawing.Point(994, 61);
            this.SearchAtendees_gunaAdvenceButton.Name = "SearchAtendees_gunaAdvenceButton";
            this.SearchAtendees_gunaAdvenceButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.SearchAtendees_gunaAdvenceButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SearchAtendees_gunaAdvenceButton.OnHoverForeColor = System.Drawing.Color.White;
            this.SearchAtendees_gunaAdvenceButton.OnHoverImage = null;
            this.SearchAtendees_gunaAdvenceButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SearchAtendees_gunaAdvenceButton.OnPressedColor = System.Drawing.Color.Black;
            this.SearchAtendees_gunaAdvenceButton.Size = new System.Drawing.Size(45, 40);
            this.SearchAtendees_gunaAdvenceButton.TabIndex = 37;
            // 
            // SearchAtendees_gunaTextBox
            // 
            this.SearchAtendees_gunaTextBox.BaseColor = System.Drawing.Color.White;
            this.SearchAtendees_gunaTextBox.BorderColor = System.Drawing.Color.Silver;
            this.SearchAtendees_gunaTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchAtendees_gunaTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.SearchAtendees_gunaTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.SearchAtendees_gunaTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchAtendees_gunaTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchAtendees_gunaTextBox.Location = new System.Drawing.Point(683, 61);
            this.SearchAtendees_gunaTextBox.Name = "SearchAtendees_gunaTextBox";
            this.SearchAtendees_gunaTextBox.PasswordChar = '\0';
            this.SearchAtendees_gunaTextBox.Radius = 8;
            this.SearchAtendees_gunaTextBox.Size = new System.Drawing.Size(320, 40);
            this.SearchAtendees_gunaTextBox.TabIndex = 36;
            // 
            // tabelText
            // 
            this.tabelText.AutoSize = true;
            this.tabelText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabelText.Location = new System.Drawing.Point(288, 141);
            this.tabelText.Name = "tabelText";
            this.tabelText.Size = new System.Drawing.Size(1010, 28);
            this.tabelText.TabIndex = 40;
            this.tabelText.Text = "Student ID         First Name             Last Name              Year            " +
    "    Status           Date and Time added             Actions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 28);
            this.label1.TabIndex = 41;
            this.label1.Text = "00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "Time-out:";
            // 
            // scanButtomEventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabelText);
            this.Controls.Add(this.FilterAtendees_gunaComboBox);
            this.Controls.Add(this.FilterText_gunaLabel);
            this.Controls.Add(this.SearchAtendees_gunaAdvenceButton);
            this.Controls.Add(this.SearchAtendees_gunaTextBox);
            this.Controls.Add(this.scannedAtendeesText);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.AtendeesData_gunaDataGridView);
            this.Controls.Add(this.numOfAtendeesText);
            this.Controls.Add(this.numOfAtendees_value);
            this.Controls.Add(this.timeInText);
            this.Controls.Add(this.ttAdded_gunaLabel);
            this.Controls.Add(this.ScanText);
            this.Name = "scanButtomEventDetails";
            this.Size = new System.Drawing.Size(1462, 646);
            ((System.ComponentModel.ISupportInitialize)(this.AtendeesData_gunaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScanText;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label ttAdded_gunaLabel;
        private System.Windows.Forms.Label timeInText;
        private System.Windows.Forms.Label numOfAtendeesText;
        private System.Windows.Forms.Label numOfAtendees_value;
        private Guna.UI.WinForms.GunaDataGridView AtendeesData_gunaDataGridView;
        private System.Windows.Forms.Label scannedAtendeesText;
        private Guna.UI.WinForms.GunaAdvenceButton scanButton;
        private System.Windows.Forms.Label tabelText;
        private Guna.UI.WinForms.GunaComboBox FilterAtendees_gunaComboBox;
        private Guna.UI.WinForms.GunaLabel FilterText_gunaLabel;
        private Guna.UI.WinForms.GunaAdvenceButton SearchAtendees_gunaAdvenceButton;
        private Guna.UI.WinForms.GunaTextBox SearchAtendees_gunaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
