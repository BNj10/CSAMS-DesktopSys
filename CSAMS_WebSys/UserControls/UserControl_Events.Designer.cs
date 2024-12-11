namespace CSAMS_WebSys.UserControls
{
    partial class UserControl_Events
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
            this.Events_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.SearchEvents_gunaTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.FilterEvents_gunaComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.FilterText_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.EventsData_gunaDataGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.SearchEvents_gunaAdvenceButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.AddEvents_gunaAdvenceButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.tabelLabels_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EventsData_gunaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Events_gunaLabel
            // 
            this.Events_gunaLabel.AutoSize = true;
            this.Events_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Events_gunaLabel.Location = new System.Drawing.Point(3, 10);
            this.Events_gunaLabel.Name = "Events_gunaLabel";
            this.Events_gunaLabel.Size = new System.Drawing.Size(146, 54);
            this.Events_gunaLabel.TabIndex = 1;
            this.Events_gunaLabel.Text = "Events";
            // 
            // SearchEvents_gunaTextBox
            // 
            this.SearchEvents_gunaTextBox.BaseColor = System.Drawing.Color.White;
            this.SearchEvents_gunaTextBox.BorderColor = System.Drawing.Color.Silver;
            this.SearchEvents_gunaTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchEvents_gunaTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.SearchEvents_gunaTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.SearchEvents_gunaTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchEvents_gunaTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEvents_gunaTextBox.Location = new System.Drawing.Point(285, 85);
            this.SearchEvents_gunaTextBox.Name = "SearchEvents_gunaTextBox";
            this.SearchEvents_gunaTextBox.PasswordChar = '\0';
            this.SearchEvents_gunaTextBox.Radius = 8;
            this.SearchEvents_gunaTextBox.Size = new System.Drawing.Size(320, 40);
            this.SearchEvents_gunaTextBox.TabIndex = 3;
            this.SearchEvents_gunaTextBox.TextChanged += new System.EventHandler(this.TypingText);
            this.SearchEvents_gunaTextBox.Enter += new System.EventHandler(this.TextEnter);
            this.SearchEvents_gunaTextBox.Leave += new System.EventHandler(this.LeaveText);
            // 
            // FilterEvents_gunaComboBox
            // 
            this.FilterEvents_gunaComboBox.BackColor = System.Drawing.Color.Transparent;
            this.FilterEvents_gunaComboBox.BaseColor = System.Drawing.Color.White;
            this.FilterEvents_gunaComboBox.BorderColor = System.Drawing.Color.Silver;
            this.FilterEvents_gunaComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FilterEvents_gunaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterEvents_gunaComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FilterEvents_gunaComboBox.ForeColor = System.Drawing.Color.Black;
            this.FilterEvents_gunaComboBox.FormattingEnabled = true;
            this.FilterEvents_gunaComboBox.Items.AddRange(new object[] {
            "",
            "Ongoing",
            "Done",
            "Pending",
            "Archived"});
            this.FilterEvents_gunaComboBox.Location = new System.Drawing.Point(714, 92);
            this.FilterEvents_gunaComboBox.Name = "FilterEvents_gunaComboBox";
            this.FilterEvents_gunaComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.FilterEvents_gunaComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.FilterEvents_gunaComboBox.Size = new System.Drawing.Size(280, 31);
            this.FilterEvents_gunaComboBox.TabIndex = 5;
            this.FilterEvents_gunaComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterEvents_gunaComboBox_SelectedIndexChanged);
            // 
            // FilterText_gunaLabel
            // 
            this.FilterText_gunaLabel.AutoSize = true;
            this.FilterText_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterText_gunaLabel.Location = new System.Drawing.Point(652, 92);
            this.FilterText_gunaLabel.Name = "FilterText_gunaLabel";
            this.FilterText_gunaLabel.Size = new System.Drawing.Size(56, 28);
            this.FilterText_gunaLabel.TabIndex = 6;
            this.FilterText_gunaLabel.Text = "Filter";
            // 
            // EventsData_gunaDataGridView
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.EventsData_gunaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.EventsData_gunaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EventsData_gunaDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.EventsData_gunaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EventsData_gunaDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EventsData_gunaDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EventsData_gunaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.EventsData_gunaDataGridView.ColumnHeadersHeight = 4;
            this.EventsData_gunaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EventsData_gunaDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.EventsData_gunaDataGridView.EnableHeadersVisualStyles = false;
            this.EventsData_gunaDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.EventsData_gunaDataGridView.Location = new System.Drawing.Point(52, 229);
            this.EventsData_gunaDataGridView.Name = "EventsData_gunaDataGridView";
            this.EventsData_gunaDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.EventsData_gunaDataGridView.RowHeadersVisible = false;
            this.EventsData_gunaDataGridView.RowHeadersWidth = 51;
            this.EventsData_gunaDataGridView.RowTemplate.Height = 24;
            this.EventsData_gunaDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EventsData_gunaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EventsData_gunaDataGridView.Size = new System.Drawing.Size(1480, 617);
            this.EventsData_gunaDataGridView.TabIndex = 25;
            this.EventsData_gunaDataGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Indigo;
            this.EventsData_gunaDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.EventsData_gunaDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EventsData_gunaDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EventsData_gunaDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EventsData_gunaDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EventsData_gunaDataGridView.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.EventsData_gunaDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.EventsData_gunaDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.EventsData_gunaDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.EventsData_gunaDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.EventsData_gunaDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EventsData_gunaDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.EventsData_gunaDataGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.EventsData_gunaDataGridView.ThemeStyle.ReadOnly = false;
            this.EventsData_gunaDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.EventsData_gunaDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EventsData_gunaDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.EventsData_gunaDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.EventsData_gunaDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.EventsData_gunaDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.EventsData_gunaDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.EventsData_gunaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventsData_gunaDataGridView_CellClick);
            // 
            // SearchEvents_gunaAdvenceButton
            // 
            this.SearchEvents_gunaAdvenceButton.AnimationHoverSpeed = 0.07F;
            this.SearchEvents_gunaAdvenceButton.AnimationSpeed = 0.03F;
            this.SearchEvents_gunaAdvenceButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchEvents_gunaAdvenceButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.SearchEvents_gunaAdvenceButton.BorderColor = System.Drawing.Color.Transparent;
            this.SearchEvents_gunaAdvenceButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.SearchEvents_gunaAdvenceButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.SearchEvents_gunaAdvenceButton.CheckedForeColor = System.Drawing.Color.White;
            this.SearchEvents_gunaAdvenceButton.CheckedImage = global::CSAMS_WebSys.Properties.Resources.search_img;
            this.SearchEvents_gunaAdvenceButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.SearchEvents_gunaAdvenceButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEvents_gunaAdvenceButton.ForeColor = System.Drawing.Color.White;
            this.SearchEvents_gunaAdvenceButton.Image = global::CSAMS_WebSys.Properties.Resources.search_img;
            this.SearchEvents_gunaAdvenceButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchEvents_gunaAdvenceButton.ImageSize = new System.Drawing.Size(20, 20);
            this.SearchEvents_gunaAdvenceButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SearchEvents_gunaAdvenceButton.Location = new System.Drawing.Point(596, 85);
            this.SearchEvents_gunaAdvenceButton.Name = "SearchEvents_gunaAdvenceButton";
            this.SearchEvents_gunaAdvenceButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.SearchEvents_gunaAdvenceButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SearchEvents_gunaAdvenceButton.OnHoverForeColor = System.Drawing.Color.White;
            this.SearchEvents_gunaAdvenceButton.OnHoverImage = null;
            this.SearchEvents_gunaAdvenceButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SearchEvents_gunaAdvenceButton.OnPressedColor = System.Drawing.Color.Black;
            this.SearchEvents_gunaAdvenceButton.Size = new System.Drawing.Size(45, 40);
            this.SearchEvents_gunaAdvenceButton.TabIndex = 4;
            // 
            // AddEvents_gunaAdvenceButton
            // 
            this.AddEvents_gunaAdvenceButton.AnimationHoverSpeed = 0.07F;
            this.AddEvents_gunaAdvenceButton.AnimationSpeed = 0.03F;
            this.AddEvents_gunaAdvenceButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.AddEvents_gunaAdvenceButton.BorderColor = System.Drawing.Color.Black;
            this.AddEvents_gunaAdvenceButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.AddEvents_gunaAdvenceButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.AddEvents_gunaAdvenceButton.CheckedForeColor = System.Drawing.Color.White;
            this.AddEvents_gunaAdvenceButton.CheckedImage = global::CSAMS_WebSys.Properties.Resources.addEvents;
            this.AddEvents_gunaAdvenceButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AddEvents_gunaAdvenceButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEvents_gunaAdvenceButton.ForeColor = System.Drawing.Color.White;
            this.AddEvents_gunaAdvenceButton.Image = global::CSAMS_WebSys.Properties.Resources.addEvents;
            this.AddEvents_gunaAdvenceButton.ImageSize = new System.Drawing.Size(20, 20);
            this.AddEvents_gunaAdvenceButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddEvents_gunaAdvenceButton.Location = new System.Drawing.Point(52, 85);
            this.AddEvents_gunaAdvenceButton.Name = "AddEvents_gunaAdvenceButton";
            this.AddEvents_gunaAdvenceButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.AddEvents_gunaAdvenceButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddEvents_gunaAdvenceButton.OnHoverForeColor = System.Drawing.Color.White;
            this.AddEvents_gunaAdvenceButton.OnHoverImage = null;
            this.AddEvents_gunaAdvenceButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddEvents_gunaAdvenceButton.OnPressedColor = System.Drawing.Color.Black;
            this.AddEvents_gunaAdvenceButton.Radius = 8;
            this.AddEvents_gunaAdvenceButton.Size = new System.Drawing.Size(210, 40);
            this.AddEvents_gunaAdvenceButton.TabIndex = 2;
            this.AddEvents_gunaAdvenceButton.Text = "Add Events";
            this.AddEvents_gunaAdvenceButton.Click += new System.EventHandler(this.AddEvents_gunaAdvenceButton_Click);
            // 
            // tabelLabels_gunaLabel
            // 
            this.tabelLabels_gunaLabel.AutoSize = true;
            this.tabelLabels_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabelLabels_gunaLabel.Location = new System.Drawing.Point(47, 190);
            this.tabelLabels_gunaLabel.Name = "tabelLabels_gunaLabel";
            this.tabelLabels_gunaLabel.Size = new System.Drawing.Size(1235, 28);
            this.tabelLabels_gunaLabel.TabIndex = 28;
            this.tabelLabels_gunaLabel.Text = "Event Name                                                                       " +
    "                                         Date and Time added   Atendees   Progre" +
    "ss                        Actions";
            // 
            // UserControl_Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabelLabels_gunaLabel);
            this.Controls.Add(this.EventsData_gunaDataGridView);
            this.Controls.Add(this.FilterText_gunaLabel);
            this.Controls.Add(this.FilterEvents_gunaComboBox);
            this.Controls.Add(this.SearchEvents_gunaAdvenceButton);
            this.Controls.Add(this.SearchEvents_gunaTextBox);
            this.Controls.Add(this.AddEvents_gunaAdvenceButton);
            this.Controls.Add(this.Events_gunaLabel);
            this.Name = "UserControl_Events";
            this.Size = new System.Drawing.Size(1570, 970);
            this.Click += new System.EventHandler(this.onClickDashboard);
            ((System.ComponentModel.ISupportInitialize)(this.EventsData_gunaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel Events_gunaLabel;
        private Guna.UI.WinForms.GunaAdvenceButton AddEvents_gunaAdvenceButton;
        private Guna.UI.WinForms.GunaTextBox SearchEvents_gunaTextBox;
        private Guna.UI.WinForms.GunaAdvenceButton SearchEvents_gunaAdvenceButton;
        private Guna.UI.WinForms.GunaComboBox FilterEvents_gunaComboBox;
        private Guna.UI.WinForms.GunaLabel FilterText_gunaLabel;
        private Guna.UI.WinForms.GunaDataGridView EventsData_gunaDataGridView;
        private Guna.UI.WinForms.GunaLabel tabelLabels_gunaLabel;
        private System.Windows.Forms.Timer timer1;
    }
}
