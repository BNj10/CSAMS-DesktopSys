namespace CSAMS_WebSys.UserControls
{
    partial class ArchiveEvents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchiveEvents));
            this.ArchivedEvents_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.SearchArchivedEvents_gunaTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.SearchArchivedEvents_gunaAdvenceButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.FilterText_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.FilterArchivedEvents_gunaComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.ArchivedEventsData_gunaDataGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.tabelLabels_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ArchivedEventsData_gunaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ArchivedEvents_gunaLabel
            // 
            this.ArchivedEvents_gunaLabel.AutoSize = true;
            this.ArchivedEvents_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArchivedEvents_gunaLabel.Location = new System.Drawing.Point(3, 10);
            this.ArchivedEvents_gunaLabel.Name = "ArchivedEvents_gunaLabel";
            this.ArchivedEvents_gunaLabel.Size = new System.Drawing.Size(324, 54);
            this.ArchivedEvents_gunaLabel.TabIndex = 2;
            this.ArchivedEvents_gunaLabel.Text = "Archived Events";
            // 
            // SearchArchivedEvents_gunaTextBox
            // 
            this.SearchArchivedEvents_gunaTextBox.BaseColor = System.Drawing.Color.White;
            this.SearchArchivedEvents_gunaTextBox.BorderColor = System.Drawing.Color.Silver;
            this.SearchArchivedEvents_gunaTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchArchivedEvents_gunaTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.SearchArchivedEvents_gunaTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.SearchArchivedEvents_gunaTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchArchivedEvents_gunaTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchArchivedEvents_gunaTextBox.Location = new System.Drawing.Point(52, 85);
            this.SearchArchivedEvents_gunaTextBox.Name = "SearchArchivedEvents_gunaTextBox";
            this.SearchArchivedEvents_gunaTextBox.PasswordChar = '\0';
            this.SearchArchivedEvents_gunaTextBox.Radius = 8;
            this.SearchArchivedEvents_gunaTextBox.Size = new System.Drawing.Size(320, 40);
            this.SearchArchivedEvents_gunaTextBox.TabIndex = 4;
            this.SearchArchivedEvents_gunaTextBox.TextChanged += new System.EventHandler(this.onType);
            this.SearchArchivedEvents_gunaTextBox.Enter += new System.EventHandler(this.onTextEnter);
            this.SearchArchivedEvents_gunaTextBox.Leave += new System.EventHandler(this.onLeave);
            // 
            // SearchArchivedEvents_gunaAdvenceButton
            // 
            this.SearchArchivedEvents_gunaAdvenceButton.AnimationHoverSpeed = 0.07F;
            this.SearchArchivedEvents_gunaAdvenceButton.AnimationSpeed = 0.03F;
            this.SearchArchivedEvents_gunaAdvenceButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchArchivedEvents_gunaAdvenceButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.SearchArchivedEvents_gunaAdvenceButton.BorderColor = System.Drawing.Color.Transparent;
            this.SearchArchivedEvents_gunaAdvenceButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.SearchArchivedEvents_gunaAdvenceButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.SearchArchivedEvents_gunaAdvenceButton.CheckedForeColor = System.Drawing.Color.White;
            this.SearchArchivedEvents_gunaAdvenceButton.CheckedImage = global::CSAMS_WebSys.Properties.Resources.search_img;
            this.SearchArchivedEvents_gunaAdvenceButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.SearchArchivedEvents_gunaAdvenceButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchArchivedEvents_gunaAdvenceButton.ForeColor = System.Drawing.Color.White;
            this.SearchArchivedEvents_gunaAdvenceButton.Image = global::CSAMS_WebSys.Properties.Resources.search_img;
            this.SearchArchivedEvents_gunaAdvenceButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchArchivedEvents_gunaAdvenceButton.ImageSize = new System.Drawing.Size(20, 20);
            this.SearchArchivedEvents_gunaAdvenceButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SearchArchivedEvents_gunaAdvenceButton.Location = new System.Drawing.Point(363, 85);
            this.SearchArchivedEvents_gunaAdvenceButton.Name = "SearchArchivedEvents_gunaAdvenceButton";
            this.SearchArchivedEvents_gunaAdvenceButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.SearchArchivedEvents_gunaAdvenceButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SearchArchivedEvents_gunaAdvenceButton.OnHoverForeColor = System.Drawing.Color.White;
            this.SearchArchivedEvents_gunaAdvenceButton.OnHoverImage = null;
            this.SearchArchivedEvents_gunaAdvenceButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SearchArchivedEvents_gunaAdvenceButton.OnPressedColor = System.Drawing.Color.Black;
            this.SearchArchivedEvents_gunaAdvenceButton.Size = new System.Drawing.Size(45, 40);
            this.SearchArchivedEvents_gunaAdvenceButton.TabIndex = 5;
            // 
            // FilterText_gunaLabel
            // 
            this.FilterText_gunaLabel.AutoSize = true;
            this.FilterText_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterText_gunaLabel.Location = new System.Drawing.Point(423, 92);
            this.FilterText_gunaLabel.Name = "FilterText_gunaLabel";
            this.FilterText_gunaLabel.Size = new System.Drawing.Size(56, 28);
            this.FilterText_gunaLabel.TabIndex = 7;
            this.FilterText_gunaLabel.Text = "Filter";
            // 
            // FilterArchivedEvents_gunaComboBox
            // 
            this.FilterArchivedEvents_gunaComboBox.BackColor = System.Drawing.Color.Transparent;
            this.FilterArchivedEvents_gunaComboBox.BaseColor = System.Drawing.Color.White;
            this.FilterArchivedEvents_gunaComboBox.BorderColor = System.Drawing.Color.Silver;
            this.FilterArchivedEvents_gunaComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FilterArchivedEvents_gunaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterArchivedEvents_gunaComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FilterArchivedEvents_gunaComboBox.ForeColor = System.Drawing.Color.Black;
            this.FilterArchivedEvents_gunaComboBox.FormattingEnabled = true;
            this.FilterArchivedEvents_gunaComboBox.Location = new System.Drawing.Point(485, 92);
            this.FilterArchivedEvents_gunaComboBox.Name = "FilterArchivedEvents_gunaComboBox";
            this.FilterArchivedEvents_gunaComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.FilterArchivedEvents_gunaComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.FilterArchivedEvents_gunaComboBox.Size = new System.Drawing.Size(280, 31);
            this.FilterArchivedEvents_gunaComboBox.TabIndex = 8;
            // 
            // ArchivedEventsData_gunaDataGridView
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.ArchivedEventsData_gunaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.ArchivedEventsData_gunaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ArchivedEventsData_gunaDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.ArchivedEventsData_gunaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ArchivedEventsData_gunaDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ArchivedEventsData_gunaDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ArchivedEventsData_gunaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.ArchivedEventsData_gunaDataGridView.ColumnHeadersHeight = 4;
            this.ArchivedEventsData_gunaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ArchivedEventsData_gunaDataGridView.DefaultCellStyle = dataGridViewCellStyle18;
            this.ArchivedEventsData_gunaDataGridView.EnableHeadersVisualStyles = false;
            this.ArchivedEventsData_gunaDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.ArchivedEventsData_gunaDataGridView.Location = new System.Drawing.Point(52, 229);
            this.ArchivedEventsData_gunaDataGridView.Name = "ArchivedEventsData_gunaDataGridView";
            this.ArchivedEventsData_gunaDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ArchivedEventsData_gunaDataGridView.RowHeadersVisible = false;
            this.ArchivedEventsData_gunaDataGridView.RowHeadersWidth = 51;
            this.ArchivedEventsData_gunaDataGridView.RowTemplate.Height = 24;
            this.ArchivedEventsData_gunaDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ArchivedEventsData_gunaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ArchivedEventsData_gunaDataGridView.Size = new System.Drawing.Size(1480, 617);
            this.ArchivedEventsData_gunaDataGridView.TabIndex = 26;
            this.ArchivedEventsData_gunaDataGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Indigo;
            this.ArchivedEventsData_gunaDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.ArchivedEventsData_gunaDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ArchivedEventsData_gunaDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ArchivedEventsData_gunaDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ArchivedEventsData_gunaDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ArchivedEventsData_gunaDataGridView.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.ArchivedEventsData_gunaDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.ArchivedEventsData_gunaDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ArchivedEventsData_gunaDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ArchivedEventsData_gunaDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ArchivedEventsData_gunaDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ArchivedEventsData_gunaDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ArchivedEventsData_gunaDataGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.ArchivedEventsData_gunaDataGridView.ThemeStyle.ReadOnly = false;
            this.ArchivedEventsData_gunaDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ArchivedEventsData_gunaDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ArchivedEventsData_gunaDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ArchivedEventsData_gunaDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ArchivedEventsData_gunaDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.ArchivedEventsData_gunaDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.ArchivedEventsData_gunaDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // tabelLabels_gunaLabel
            // 
            this.tabelLabels_gunaLabel.AutoSize = true;
            this.tabelLabels_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabelLabels_gunaLabel.Location = new System.Drawing.Point(47, 190);
            this.tabelLabels_gunaLabel.Name = "tabelLabels_gunaLabel";
            this.tabelLabels_gunaLabel.Size = new System.Drawing.Size(1360, 28);
            this.tabelLabels_gunaLabel.TabIndex = 28;
            this.tabelLabels_gunaLabel.Text = resources.GetString("tabelLabels_gunaLabel.Text");
            // 
            // ArchiveEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabelLabels_gunaLabel);
            this.Controls.Add(this.ArchivedEventsData_gunaDataGridView);
            this.Controls.Add(this.FilterArchivedEvents_gunaComboBox);
            this.Controls.Add(this.FilterText_gunaLabel);
            this.Controls.Add(this.SearchArchivedEvents_gunaAdvenceButton);
            this.Controls.Add(this.SearchArchivedEvents_gunaTextBox);
            this.Controls.Add(this.ArchivedEvents_gunaLabel);
            this.Name = "ArchiveEvents";
            this.Size = new System.Drawing.Size(1570, 970);
            ((System.ComponentModel.ISupportInitialize)(this.ArchivedEventsData_gunaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel ArchivedEvents_gunaLabel;
        private Guna.UI.WinForms.GunaTextBox SearchArchivedEvents_gunaTextBox;
        private Guna.UI.WinForms.GunaAdvenceButton SearchArchivedEvents_gunaAdvenceButton;
        private Guna.UI.WinForms.GunaLabel FilterText_gunaLabel;
        private Guna.UI.WinForms.GunaComboBox FilterArchivedEvents_gunaComboBox;
        private Guna.UI.WinForms.GunaDataGridView ArchivedEventsData_gunaDataGridView;
        private Guna.UI.WinForms.GunaLabel tabelLabels_gunaLabel;
        private System.Windows.Forms.Timer timer1;
    }
}
