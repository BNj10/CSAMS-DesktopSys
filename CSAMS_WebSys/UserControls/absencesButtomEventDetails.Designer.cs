namespace CSAMS_WebSys.UserControls
{
    partial class absencesButtomEventDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabelText = new System.Windows.Forms.Label();
            this.FilterAbsences_gunaComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.FilterText_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.SearchAbsences_gunaTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.absentMembersText = new System.Windows.Forms.Label();
            this.AbsencesData_gunaDataGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.numOfAbsencesText = new System.Windows.Forms.Label();
            this.numOfAbsentMembers_value = new System.Windows.Forms.Label();
            this.SearchAbsences_gunaAdvenceButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AbsencesData_gunaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelText
            // 
            this.tabelText.AutoSize = true;
            this.tabelText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabelText.Location = new System.Drawing.Point(288, 141);
            this.tabelText.Name = "tabelText";
            this.tabelText.Size = new System.Drawing.Size(1010, 28);
            this.tabelText.TabIndex = 54;
            this.tabelText.Text = "Student ID         First Name             Last Name              Year            " +
    "    Status           Date and Time added             Actions";
            // 
            // FilterAbsences_gunaComboBox
            // 
            this.FilterAbsences_gunaComboBox.BackColor = System.Drawing.Color.Transparent;
            this.FilterAbsences_gunaComboBox.BaseColor = System.Drawing.Color.White;
            this.FilterAbsences_gunaComboBox.BorderColor = System.Drawing.Color.Silver;
            this.FilterAbsences_gunaComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FilterAbsences_gunaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterAbsences_gunaComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FilterAbsences_gunaComboBox.ForeColor = System.Drawing.Color.Black;
            this.FilterAbsences_gunaComboBox.FormattingEnabled = true;
            this.FilterAbsences_gunaComboBox.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5th above"});
            this.FilterAbsences_gunaComboBox.Location = new System.Drawing.Point(1121, 68);
            this.FilterAbsences_gunaComboBox.Name = "FilterAbsences_gunaComboBox";
            this.FilterAbsences_gunaComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.FilterAbsences_gunaComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.FilterAbsences_gunaComboBox.Size = new System.Drawing.Size(280, 31);
            this.FilterAbsences_gunaComboBox.TabIndex = 53;
            // 
            // FilterText_gunaLabel
            // 
            this.FilterText_gunaLabel.AutoSize = true;
            this.FilterText_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterText_gunaLabel.Location = new System.Drawing.Point(1050, 68);
            this.FilterText_gunaLabel.Name = "FilterText_gunaLabel";
            this.FilterText_gunaLabel.Size = new System.Drawing.Size(56, 28);
            this.FilterText_gunaLabel.TabIndex = 52;
            this.FilterText_gunaLabel.Text = "Filter";
            // 
            // SearchAbsences_gunaTextBox
            // 
            this.SearchAbsences_gunaTextBox.BaseColor = System.Drawing.Color.White;
            this.SearchAbsences_gunaTextBox.BorderColor = System.Drawing.Color.Silver;
            this.SearchAbsences_gunaTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchAbsences_gunaTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.SearchAbsences_gunaTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.SearchAbsences_gunaTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchAbsences_gunaTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchAbsences_gunaTextBox.Location = new System.Drawing.Point(683, 61);
            this.SearchAbsences_gunaTextBox.Name = "SearchAbsences_gunaTextBox";
            this.SearchAbsences_gunaTextBox.PasswordChar = '\0';
            this.SearchAbsences_gunaTextBox.Radius = 8;
            this.SearchAbsences_gunaTextBox.Size = new System.Drawing.Size(320, 40);
            this.SearchAbsences_gunaTextBox.TabIndex = 50;
            // 
            // absentMembersText
            // 
            this.absentMembersText.AutoSize = true;
            this.absentMembersText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absentMembersText.Location = new System.Drawing.Point(284, 47);
            this.absentMembersText.Name = "absentMembersText";
            this.absentMembersText.Size = new System.Drawing.Size(345, 54);
            this.absentMembersText.TabIndex = 49;
            this.absentMembersText.Text = "Absent Members";
            // 
            // AbsencesData_gunaDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.AbsencesData_gunaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AbsencesData_gunaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AbsencesData_gunaDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.AbsencesData_gunaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AbsencesData_gunaDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AbsencesData_gunaDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AbsencesData_gunaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AbsencesData_gunaDataGridView.ColumnHeadersHeight = 4;
            this.AbsencesData_gunaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AbsencesData_gunaDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.AbsencesData_gunaDataGridView.EnableHeadersVisualStyles = false;
            this.AbsencesData_gunaDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.AbsencesData_gunaDataGridView.Location = new System.Drawing.Point(292, 181);
            this.AbsencesData_gunaDataGridView.Name = "AbsencesData_gunaDataGridView";
            this.AbsencesData_gunaDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.AbsencesData_gunaDataGridView.RowHeadersVisible = false;
            this.AbsencesData_gunaDataGridView.RowHeadersWidth = 51;
            this.AbsencesData_gunaDataGridView.RowTemplate.Height = 24;
            this.AbsencesData_gunaDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AbsencesData_gunaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AbsencesData_gunaDataGridView.Size = new System.Drawing.Size(1123, 401);
            this.AbsencesData_gunaDataGridView.TabIndex = 47;
            this.AbsencesData_gunaDataGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Indigo;
            this.AbsencesData_gunaDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.AbsencesData_gunaDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AbsencesData_gunaDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AbsencesData_gunaDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AbsencesData_gunaDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AbsencesData_gunaDataGridView.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.AbsencesData_gunaDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.AbsencesData_gunaDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.AbsencesData_gunaDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.AbsencesData_gunaDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.AbsencesData_gunaDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AbsencesData_gunaDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AbsencesData_gunaDataGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.AbsencesData_gunaDataGridView.ThemeStyle.ReadOnly = false;
            this.AbsencesData_gunaDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.AbsencesData_gunaDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AbsencesData_gunaDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.AbsencesData_gunaDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.AbsencesData_gunaDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.AbsencesData_gunaDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.AbsencesData_gunaDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.AbsencesData_gunaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AbsencesData_gunaDataGridView_CellClick);
            // 
            // numOfAbsencesText
            // 
            this.numOfAbsencesText.AutoSize = true;
            this.numOfAbsencesText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfAbsencesText.Location = new System.Drawing.Point(51, 181);
            this.numOfAbsencesText.Name = "numOfAbsencesText";
            this.numOfAbsencesText.Size = new System.Drawing.Size(195, 23);
            this.numOfAbsencesText.TabIndex = 46;
            this.numOfAbsencesText.Text = "No. of Absent Members:";
            // 
            // numOfAbsentMembers_value
            // 
            this.numOfAbsentMembers_value.AutoSize = true;
            this.numOfAbsentMembers_value.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfAbsentMembers_value.Location = new System.Drawing.Point(55, 216);
            this.numOfAbsentMembers_value.Name = "numOfAbsentMembers_value";
            this.numOfAbsentMembers_value.Size = new System.Drawing.Size(45, 28);
            this.numOfAbsentMembers_value.TabIndex = 45;
            this.numOfAbsentMembers_value.Text = "999";
            // 
            // SearchAbsences_gunaAdvenceButton
            // 
            this.SearchAbsences_gunaAdvenceButton.AnimationHoverSpeed = 0.07F;
            this.SearchAbsences_gunaAdvenceButton.AnimationSpeed = 0.03F;
            this.SearchAbsences_gunaAdvenceButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchAbsences_gunaAdvenceButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.SearchAbsences_gunaAdvenceButton.BorderColor = System.Drawing.Color.Transparent;
            this.SearchAbsences_gunaAdvenceButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.SearchAbsences_gunaAdvenceButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.SearchAbsences_gunaAdvenceButton.CheckedForeColor = System.Drawing.Color.White;
            this.SearchAbsences_gunaAdvenceButton.CheckedImage = global::CSAMS_WebSys.Properties.Resources.search_img;
            this.SearchAbsences_gunaAdvenceButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.SearchAbsences_gunaAdvenceButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchAbsences_gunaAdvenceButton.ForeColor = System.Drawing.Color.White;
            this.SearchAbsences_gunaAdvenceButton.Image = global::CSAMS_WebSys.Properties.Resources.search_img;
            this.SearchAbsences_gunaAdvenceButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchAbsences_gunaAdvenceButton.ImageSize = new System.Drawing.Size(20, 20);
            this.SearchAbsences_gunaAdvenceButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SearchAbsences_gunaAdvenceButton.Location = new System.Drawing.Point(994, 61);
            this.SearchAbsences_gunaAdvenceButton.Name = "SearchAbsences_gunaAdvenceButton";
            this.SearchAbsences_gunaAdvenceButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.SearchAbsences_gunaAdvenceButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SearchAbsences_gunaAdvenceButton.OnHoverForeColor = System.Drawing.Color.White;
            this.SearchAbsences_gunaAdvenceButton.OnHoverImage = null;
            this.SearchAbsences_gunaAdvenceButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SearchAbsences_gunaAdvenceButton.OnPressedColor = System.Drawing.Color.Black;
            this.SearchAbsences_gunaAdvenceButton.Size = new System.Drawing.Size(45, 40);
            this.SearchAbsences_gunaAdvenceButton.TabIndex = 51;
            // 
            // absencesButtomEventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabelText);
            this.Controls.Add(this.FilterAbsences_gunaComboBox);
            this.Controls.Add(this.FilterText_gunaLabel);
            this.Controls.Add(this.SearchAbsences_gunaAdvenceButton);
            this.Controls.Add(this.SearchAbsences_gunaTextBox);
            this.Controls.Add(this.absentMembersText);
            this.Controls.Add(this.AbsencesData_gunaDataGridView);
            this.Controls.Add(this.numOfAbsencesText);
            this.Controls.Add(this.numOfAbsentMembers_value);
            this.Name = "absencesButtomEventDetails";
            this.Size = new System.Drawing.Size(1462, 646);
            ((System.ComponentModel.ISupportInitialize)(this.AbsencesData_gunaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tabelText;
        private Guna.UI.WinForms.GunaComboBox FilterAbsences_gunaComboBox;
        private Guna.UI.WinForms.GunaLabel FilterText_gunaLabel;
        private Guna.UI.WinForms.GunaAdvenceButton SearchAbsences_gunaAdvenceButton;
        private Guna.UI.WinForms.GunaTextBox SearchAbsences_gunaTextBox;
        private System.Windows.Forms.Label absentMembersText;
        private Guna.UI.WinForms.GunaDataGridView AbsencesData_gunaDataGridView;
        private System.Windows.Forms.Label numOfAbsencesText;
        private System.Windows.Forms.Label numOfAbsentMembers_value;
        private System.Windows.Forms.Timer timer1;
    }
}
