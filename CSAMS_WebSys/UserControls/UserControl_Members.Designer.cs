namespace CSAMS_WebSys.UserControls
{
    partial class UserControl_Members
    {

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Members));
            this.Members_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.SearchMembers_gunaTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.FilterText_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.FilterMembers_gunaComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.MembersData_gunaDataGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.tabelLabels_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bulkAdd_gunaAdvenceButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SearchMembers_gunaAdvenceButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.AddMember_gunaAdvenceButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MembersData_gunaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Members_gunaLabel
            // 
            this.Members_gunaLabel.AutoSize = true;
            this.Members_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Members_gunaLabel.Location = new System.Drawing.Point(3, 10);
            this.Members_gunaLabel.Name = "Members_gunaLabel";
            this.Members_gunaLabel.Size = new System.Drawing.Size(201, 54);
            this.Members_gunaLabel.TabIndex = 2;
            this.Members_gunaLabel.Text = "Members";
            // 
            // SearchMembers_gunaTextBox
            // 
            this.SearchMembers_gunaTextBox.BaseColor = System.Drawing.Color.White;
            this.SearchMembers_gunaTextBox.BorderColor = System.Drawing.Color.Silver;
            this.SearchMembers_gunaTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchMembers_gunaTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.SearchMembers_gunaTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.SearchMembers_gunaTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchMembers_gunaTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMembers_gunaTextBox.Location = new System.Drawing.Point(511, 85);
            this.SearchMembers_gunaTextBox.Name = "SearchMembers_gunaTextBox";
            this.SearchMembers_gunaTextBox.PasswordChar = '\0';
            this.SearchMembers_gunaTextBox.Radius = 8;
            this.SearchMembers_gunaTextBox.Size = new System.Drawing.Size(320, 40);
            this.SearchMembers_gunaTextBox.TabIndex = 4;
            this.SearchMembers_gunaTextBox.TextChanged += new System.EventHandler(this.Typing);
            this.SearchMembers_gunaTextBox.Enter += new System.EventHandler(this.EnterText);
            this.SearchMembers_gunaTextBox.Leave += new System.EventHandler(this.LeaveText);
            // 
            // FilterText_gunaLabel
            // 
            this.FilterText_gunaLabel.AutoSize = true;
            this.FilterText_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterText_gunaLabel.Location = new System.Drawing.Point(878, 92);
            this.FilterText_gunaLabel.Name = "FilterText_gunaLabel";
            this.FilterText_gunaLabel.Size = new System.Drawing.Size(56, 28);
            this.FilterText_gunaLabel.TabIndex = 7;
            this.FilterText_gunaLabel.Text = "Filter";
            // 
            // FilterMembers_gunaComboBox
            // 
            this.FilterMembers_gunaComboBox.BackColor = System.Drawing.Color.Transparent;
            this.FilterMembers_gunaComboBox.BaseColor = System.Drawing.Color.White;
            this.FilterMembers_gunaComboBox.BorderColor = System.Drawing.Color.Silver;
            this.FilterMembers_gunaComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FilterMembers_gunaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterMembers_gunaComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FilterMembers_gunaComboBox.ForeColor = System.Drawing.Color.Black;
            this.FilterMembers_gunaComboBox.FormattingEnabled = true;
            this.FilterMembers_gunaComboBox.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5th above"});
            this.FilterMembers_gunaComboBox.Location = new System.Drawing.Point(949, 92);
            this.FilterMembers_gunaComboBox.Name = "FilterMembers_gunaComboBox";
            this.FilterMembers_gunaComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.FilterMembers_gunaComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.FilterMembers_gunaComboBox.Size = new System.Drawing.Size(280, 31);
            this.FilterMembers_gunaComboBox.TabIndex = 8;
            this.FilterMembers_gunaComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterYear);
            // 
            // MembersData_gunaDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.MembersData_gunaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MembersData_gunaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MembersData_gunaDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.MembersData_gunaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MembersData_gunaDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MembersData_gunaDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MembersData_gunaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MembersData_gunaDataGridView.ColumnHeadersHeight = 4;
            this.MembersData_gunaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MembersData_gunaDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.MembersData_gunaDataGridView.EnableHeadersVisualStyles = false;
            this.MembersData_gunaDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.MembersData_gunaDataGridView.Location = new System.Drawing.Point(52, 229);
            this.MembersData_gunaDataGridView.Name = "MembersData_gunaDataGridView";
            this.MembersData_gunaDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.MembersData_gunaDataGridView.RowHeadersVisible = false;
            this.MembersData_gunaDataGridView.RowHeadersWidth = 51;
            this.MembersData_gunaDataGridView.RowTemplate.Height = 24;
            this.MembersData_gunaDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MembersData_gunaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MembersData_gunaDataGridView.Size = new System.Drawing.Size(1480, 617);
            this.MembersData_gunaDataGridView.TabIndex = 26;
            this.MembersData_gunaDataGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Indigo;
            this.MembersData_gunaDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.MembersData_gunaDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MembersData_gunaDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MembersData_gunaDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MembersData_gunaDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MembersData_gunaDataGridView.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.MembersData_gunaDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.MembersData_gunaDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.MembersData_gunaDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.MembersData_gunaDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.MembersData_gunaDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MembersData_gunaDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.MembersData_gunaDataGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.MembersData_gunaDataGridView.ThemeStyle.ReadOnly = false;
            this.MembersData_gunaDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.MembersData_gunaDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MembersData_gunaDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.MembersData_gunaDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.MembersData_gunaDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.MembersData_gunaDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.MembersData_gunaDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.MembersData_gunaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MembersData_gunaDataGridView_CellClick);
            this.MembersData_gunaDataGridView.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HandlePagination);
            // 
            // tabelLabels_gunaLabel
            // 
            this.tabelLabels_gunaLabel.AutoSize = true;
            this.tabelLabels_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabelLabels_gunaLabel.Location = new System.Drawing.Point(47, 190);
            this.tabelLabels_gunaLabel.Name = "tabelLabels_gunaLabel";
            this.tabelLabels_gunaLabel.Size = new System.Drawing.Size(1236, 28);
            this.tabelLabels_gunaLabel.TabIndex = 27;
            this.tabelLabels_gunaLabel.Text = "Student ID             First Name          Last Name           Year              " +
    "       Biometrics          Status                   Date and Time added         " +
    "          Actions";
            // 
            // bulkAdd_gunaAdvenceButton
            // 
            this.bulkAdd_gunaAdvenceButton.AnimationHoverSpeed = 0.07F;
            this.bulkAdd_gunaAdvenceButton.AnimationSpeed = 0.03F;
            this.bulkAdd_gunaAdvenceButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.bulkAdd_gunaAdvenceButton.BorderColor = System.Drawing.Color.Black;
            this.bulkAdd_gunaAdvenceButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.bulkAdd_gunaAdvenceButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.bulkAdd_gunaAdvenceButton.CheckedForeColor = System.Drawing.Color.White;
            this.bulkAdd_gunaAdvenceButton.CheckedImage = global::CSAMS_WebSys.Properties.Resources.bulkAdd;
            this.bulkAdd_gunaAdvenceButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.bulkAdd_gunaAdvenceButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bulkAdd_gunaAdvenceButton.ForeColor = System.Drawing.Color.White;
            this.bulkAdd_gunaAdvenceButton.Image = global::CSAMS_WebSys.Properties.Resources.bulkAdd;
            this.bulkAdd_gunaAdvenceButton.ImageSize = new System.Drawing.Size(20, 20);
            this.bulkAdd_gunaAdvenceButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.bulkAdd_gunaAdvenceButton.Location = new System.Drawing.Point(268, 85);
            this.bulkAdd_gunaAdvenceButton.Name = "bulkAdd_gunaAdvenceButton";
            this.bulkAdd_gunaAdvenceButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.bulkAdd_gunaAdvenceButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bulkAdd_gunaAdvenceButton.OnHoverForeColor = System.Drawing.Color.White;
            this.bulkAdd_gunaAdvenceButton.OnHoverImage = null;
            this.bulkAdd_gunaAdvenceButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.bulkAdd_gunaAdvenceButton.OnPressedColor = System.Drawing.Color.Black;
            this.bulkAdd_gunaAdvenceButton.Radius = 8;
            this.bulkAdd_gunaAdvenceButton.Size = new System.Drawing.Size(237, 40);
            this.bulkAdd_gunaAdvenceButton.TabIndex = 28;
            this.bulkAdd_gunaAdvenceButton.Text = "Bulk Add Member";
            this.bulkAdd_gunaAdvenceButton.Click += new System.EventHandler(this.bulkAdd_gunaAdvenceButton_Click);
            // 
            // SearchMembers_gunaAdvenceButton
            // 
            this.SearchMembers_gunaAdvenceButton.AnimationHoverSpeed = 0.07F;
            this.SearchMembers_gunaAdvenceButton.AnimationSpeed = 0.03F;
            this.SearchMembers_gunaAdvenceButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchMembers_gunaAdvenceButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.SearchMembers_gunaAdvenceButton.BorderColor = System.Drawing.Color.Transparent;
            this.SearchMembers_gunaAdvenceButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.SearchMembers_gunaAdvenceButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.SearchMembers_gunaAdvenceButton.CheckedForeColor = System.Drawing.Color.White;
            this.SearchMembers_gunaAdvenceButton.CheckedImage = global::CSAMS_WebSys.Properties.Resources.search_img;
            this.SearchMembers_gunaAdvenceButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.SearchMembers_gunaAdvenceButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMembers_gunaAdvenceButton.ForeColor = System.Drawing.Color.White;
            this.SearchMembers_gunaAdvenceButton.Image = global::CSAMS_WebSys.Properties.Resources.search_img;
            this.SearchMembers_gunaAdvenceButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchMembers_gunaAdvenceButton.ImageSize = new System.Drawing.Size(20, 20);
            this.SearchMembers_gunaAdvenceButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SearchMembers_gunaAdvenceButton.Location = new System.Drawing.Point(822, 85);
            this.SearchMembers_gunaAdvenceButton.Name = "SearchMembers_gunaAdvenceButton";
            this.SearchMembers_gunaAdvenceButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.SearchMembers_gunaAdvenceButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SearchMembers_gunaAdvenceButton.OnHoverForeColor = System.Drawing.Color.White;
            this.SearchMembers_gunaAdvenceButton.OnHoverImage = null;
            this.SearchMembers_gunaAdvenceButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SearchMembers_gunaAdvenceButton.OnPressedColor = System.Drawing.Color.Black;
            this.SearchMembers_gunaAdvenceButton.Size = new System.Drawing.Size(45, 40);
            this.SearchMembers_gunaAdvenceButton.TabIndex = 5;
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
            this.AddMember_gunaAdvenceButton.CheckedImage = global::CSAMS_WebSys.Properties.Resources.addMember;
            this.AddMember_gunaAdvenceButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AddMember_gunaAdvenceButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMember_gunaAdvenceButton.ForeColor = System.Drawing.Color.White;
            this.AddMember_gunaAdvenceButton.Image = global::CSAMS_WebSys.Properties.Resources.addMember;
            this.AddMember_gunaAdvenceButton.ImageSize = new System.Drawing.Size(20, 20);
            this.AddMember_gunaAdvenceButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddMember_gunaAdvenceButton.Location = new System.Drawing.Point(52, 85);
            this.AddMember_gunaAdvenceButton.Name = "AddMember_gunaAdvenceButton";
            this.AddMember_gunaAdvenceButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.AddMember_gunaAdvenceButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddMember_gunaAdvenceButton.OnHoverForeColor = System.Drawing.Color.White;
            this.AddMember_gunaAdvenceButton.OnHoverImage = null;
            this.AddMember_gunaAdvenceButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddMember_gunaAdvenceButton.OnPressedColor = System.Drawing.Color.Black;
            this.AddMember_gunaAdvenceButton.Radius = 8;
            this.AddMember_gunaAdvenceButton.Size = new System.Drawing.Size(210, 40);
            this.AddMember_gunaAdvenceButton.TabIndex = 3;
            this.AddMember_gunaAdvenceButton.Text = "Add Member";
            this.AddMember_gunaAdvenceButton.Click += new System.EventHandler(this.AddMember_gunaAdvenceButton_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(1484, 190);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(33, 33);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 29;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "2024-2025"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(1347, 92);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(185, 36);
            this.guna2ComboBox1.TabIndex = 34;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1288, 87);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(40, 41);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 35;
            this.guna2PictureBox1.TabStop = false;
            // 
            // UserControl_Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.bulkAdd_gunaAdvenceButton);
            this.Controls.Add(this.tabelLabels_gunaLabel);
            this.Controls.Add(this.MembersData_gunaDataGridView);
            this.Controls.Add(this.FilterMembers_gunaComboBox);
            this.Controls.Add(this.FilterText_gunaLabel);
            this.Controls.Add(this.SearchMembers_gunaAdvenceButton);
            this.Controls.Add(this.SearchMembers_gunaTextBox);
            this.Controls.Add(this.AddMember_gunaAdvenceButton);
            this.Controls.Add(this.Members_gunaLabel);
            this.Name = "UserControl_Members";
            this.Size = new System.Drawing.Size(1570, 970);
            this.Load += new System.EventHandler(this.PageLoadMembers);
            ((System.ComponentModel.ISupportInitialize)(this.MembersData_gunaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel Members_gunaLabel;
        private Guna.UI.WinForms.GunaAdvenceButton AddMember_gunaAdvenceButton;
        private Guna.UI.WinForms.GunaTextBox SearchMembers_gunaTextBox;
        private Guna.UI.WinForms.GunaAdvenceButton SearchMembers_gunaAdvenceButton;
        private Guna.UI.WinForms.GunaLabel FilterText_gunaLabel;
        private Guna.UI.WinForms.GunaComboBox FilterMembers_gunaComboBox;
        private Guna.UI.WinForms.GunaDataGridView MembersData_gunaDataGridView;
        private Guna.UI.WinForms.GunaLabel tabelLabels_gunaLabel;
        private Guna.UI.WinForms.GunaAdvenceButton bulkAdd_gunaAdvenceButton;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.IContainer components;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
