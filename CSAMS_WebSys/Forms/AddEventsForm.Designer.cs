namespace CSAMS_WebSys.Forms
{
    partial class AddEventsForm
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
            this.AddEventsTitle_gunaPanel = new Guna.UI.WinForms.GunaPanel();
            this.AddEvents_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.EventName_gunaTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.EventNameText_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.DateText_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.TimeFrom_gunaTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.TimeFromText_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.TimeTo_gunaTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.AddEvent_gunaAdvenceButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ttFrom_gunaComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.ttTo_gunaComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimeOutEnd = new Guna.UI.WinForms.GunaTextBox();
            this.TimeInStart = new Guna.UI.WinForms.GunaTextBox();
            this.TimeOut1 = new Guna.UI.WinForms.GunaComboBox();
            this.TimeIn1 = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.TimeInEnd = new Guna.UI.WinForms.GunaTextBox();
            this.TimeOutStart = new Guna.UI.WinForms.GunaTextBox();
            this.TimeIn2 = new Guna.UI.WinForms.GunaComboBox();
            this.TimeOut2 = new Guna.UI.WinForms.GunaComboBox();
            this.AddEventsTitle_gunaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddEventsTitle_gunaPanel
            // 
            this.AddEventsTitle_gunaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.AddEventsTitle_gunaPanel.Controls.Add(this.AddEvents_gunaLabel);
            this.AddEventsTitle_gunaPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddEventsTitle_gunaPanel.Location = new System.Drawing.Point(0, 0);
            this.AddEventsTitle_gunaPanel.Name = "AddEventsTitle_gunaPanel";
            this.AddEventsTitle_gunaPanel.Size = new System.Drawing.Size(562, 91);
            this.AddEventsTitle_gunaPanel.TabIndex = 1;
            // 
            // AddEvents_gunaLabel
            // 
            this.AddEvents_gunaLabel.AutoSize = true;
            this.AddEvents_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.AddEvents_gunaLabel.ForeColor = System.Drawing.Color.White;
            this.AddEvents_gunaLabel.Location = new System.Drawing.Point(24, 16);
            this.AddEvents_gunaLabel.Name = "AddEvents_gunaLabel";
            this.AddEvents_gunaLabel.Size = new System.Drawing.Size(235, 54);
            this.AddEvents_gunaLabel.TabIndex = 1;
            this.AddEvents_gunaLabel.Text = "Add Events";
            // 
            // EventName_gunaTextBox
            // 
            this.EventName_gunaTextBox.BaseColor = System.Drawing.Color.White;
            this.EventName_gunaTextBox.BorderColor = System.Drawing.Color.Silver;
            this.EventName_gunaTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EventName_gunaTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.EventName_gunaTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.EventName_gunaTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.EventName_gunaTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventName_gunaTextBox.Location = new System.Drawing.Point(33, 139);
            this.EventName_gunaTextBox.Name = "EventName_gunaTextBox";
            this.EventName_gunaTextBox.PasswordChar = '\0';
            this.EventName_gunaTextBox.Radius = 8;
            this.EventName_gunaTextBox.Size = new System.Drawing.Size(359, 40);
            this.EventName_gunaTextBox.TabIndex = 5;
            // 
            // EventNameText_gunaLabel
            // 
            this.EventNameText_gunaLabel.AutoSize = true;
            this.EventNameText_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNameText_gunaLabel.Location = new System.Drawing.Point(29, 113);
            this.EventNameText_gunaLabel.Name = "EventNameText_gunaLabel";
            this.EventNameText_gunaLabel.Size = new System.Drawing.Size(103, 23);
            this.EventNameText_gunaLabel.TabIndex = 7;
            this.EventNameText_gunaLabel.Text = "Event Name";
            // 
            // DateText_gunaLabel
            // 
            this.DateText_gunaLabel.AutoSize = true;
            this.DateText_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateText_gunaLabel.Location = new System.Drawing.Point(29, 199);
            this.DateText_gunaLabel.Name = "DateText_gunaLabel";
            this.DateText_gunaLabel.Size = new System.Drawing.Size(86, 23);
            this.DateText_gunaLabel.TabIndex = 9;
            this.DateText_gunaLabel.Text = "Date Start";
            // 
            // TimeFrom_gunaTextBox
            // 
            this.TimeFrom_gunaTextBox.BaseColor = System.Drawing.Color.White;
            this.TimeFrom_gunaTextBox.BorderColor = System.Drawing.Color.Silver;
            this.TimeFrom_gunaTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TimeFrom_gunaTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.TimeFrom_gunaTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.TimeFrom_gunaTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TimeFrom_gunaTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeFrom_gunaTextBox.ForeColor = System.Drawing.Color.Silver;
            this.TimeFrom_gunaTextBox.Location = new System.Drawing.Point(33, 306);
            this.TimeFrom_gunaTextBox.Name = "TimeFrom_gunaTextBox";
            this.TimeFrom_gunaTextBox.PasswordChar = '\0';
            this.TimeFrom_gunaTextBox.Radius = 8;
            this.TimeFrom_gunaTextBox.Size = new System.Drawing.Size(99, 40);
            this.TimeFrom_gunaTextBox.TabIndex = 10;
            this.TimeFrom_gunaTextBox.Text = "hh/mm";
            this.TimeFrom_gunaTextBox.Click += new System.EventHandler(this.onClick);
            this.TimeFrom_gunaTextBox.Enter += new System.EventHandler(this.TimeFrom_gunaTextBox_Enter);
            this.TimeFrom_gunaTextBox.Leave += new System.EventHandler(this.TimeFrom_gunaTextBox_Leave);
            // 
            // TimeFromText_gunaLabel
            // 
            this.TimeFromText_gunaLabel.AutoSize = true;
            this.TimeFromText_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeFromText_gunaLabel.Location = new System.Drawing.Point(29, 280);
            this.TimeFromText_gunaLabel.Name = "TimeFromText_gunaLabel";
            this.TimeFromText_gunaLabel.Size = new System.Drawing.Size(91, 23);
            this.TimeFromText_gunaLabel.TabIndex = 11;
            this.TimeFromText_gunaLabel.Text = "Time From";
            // 
            // TimeTo_gunaTextBox
            // 
            this.TimeTo_gunaTextBox.BaseColor = System.Drawing.Color.White;
            this.TimeTo_gunaTextBox.BorderColor = System.Drawing.Color.Silver;
            this.TimeTo_gunaTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TimeTo_gunaTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.TimeTo_gunaTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.TimeTo_gunaTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TimeTo_gunaTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeTo_gunaTextBox.ForeColor = System.Drawing.Color.Silver;
            this.TimeTo_gunaTextBox.Location = new System.Drawing.Point(293, 306);
            this.TimeTo_gunaTextBox.Name = "TimeTo_gunaTextBox";
            this.TimeTo_gunaTextBox.PasswordChar = '\0';
            this.TimeTo_gunaTextBox.Radius = 8;
            this.TimeTo_gunaTextBox.Size = new System.Drawing.Size(99, 40);
            this.TimeTo_gunaTextBox.TabIndex = 12;
            this.TimeTo_gunaTextBox.Text = "hh/mm";
            this.TimeTo_gunaTextBox.Enter += new System.EventHandler(this.TimeTo_gunaTextBox_Enter);
            this.TimeTo_gunaTextBox.Leave += new System.EventHandler(this.TimeTo_gunaTextBox_Leave);
            // 
            // AddEvent_gunaAdvenceButton
            // 
            this.AddEvent_gunaAdvenceButton.AnimationHoverSpeed = 0.07F;
            this.AddEvent_gunaAdvenceButton.AnimationSpeed = 0.03F;
            this.AddEvent_gunaAdvenceButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.AddEvent_gunaAdvenceButton.BorderColor = System.Drawing.Color.Black;
            this.AddEvent_gunaAdvenceButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.AddEvent_gunaAdvenceButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.AddEvent_gunaAdvenceButton.CheckedForeColor = System.Drawing.Color.White;
            this.AddEvent_gunaAdvenceButton.CheckedImage = null;
            this.AddEvent_gunaAdvenceButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AddEvent_gunaAdvenceButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEvent_gunaAdvenceButton.ForeColor = System.Drawing.Color.White;
            this.AddEvent_gunaAdvenceButton.Image = null;
            this.AddEvent_gunaAdvenceButton.ImageSize = new System.Drawing.Size(20, 20);
            this.AddEvent_gunaAdvenceButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddEvent_gunaAdvenceButton.Location = new System.Drawing.Point(362, 563);
            this.AddEvent_gunaAdvenceButton.Name = "AddEvent_gunaAdvenceButton";
            this.AddEvent_gunaAdvenceButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.AddEvent_gunaAdvenceButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddEvent_gunaAdvenceButton.OnHoverForeColor = System.Drawing.Color.White;
            this.AddEvent_gunaAdvenceButton.OnHoverImage = null;
            this.AddEvent_gunaAdvenceButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddEvent_gunaAdvenceButton.OnPressedColor = System.Drawing.Color.Black;
            this.AddEvent_gunaAdvenceButton.Radius = 8;
            this.AddEvent_gunaAdvenceButton.Size = new System.Drawing.Size(179, 40);
            this.AddEvent_gunaAdvenceButton.TabIndex = 18;
            this.AddEvent_gunaAdvenceButton.Text = "Add Event";
            this.AddEvent_gunaAdvenceButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddEvent_gunaAdvenceButton.Click += new System.EventHandler(this.AddMember_gunaAdvenceButton_Click);
            // 
            // ttFrom_gunaComboBox
            // 
            this.ttFrom_gunaComboBox.BackColor = System.Drawing.Color.Transparent;
            this.ttFrom_gunaComboBox.BaseColor = System.Drawing.Color.White;
            this.ttFrom_gunaComboBox.BorderColor = System.Drawing.Color.Silver;
            this.ttFrom_gunaComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ttFrom_gunaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ttFrom_gunaComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ttFrom_gunaComboBox.ForeColor = System.Drawing.Color.Black;
            this.ttFrom_gunaComboBox.FormattingEnabled = true;
            this.ttFrom_gunaComboBox.Items.AddRange(new object[] {
            "am",
            "pm"});
            this.ttFrom_gunaComboBox.Location = new System.Drawing.Point(150, 315);
            this.ttFrom_gunaComboBox.Name = "ttFrom_gunaComboBox";
            this.ttFrom_gunaComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ttFrom_gunaComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ttFrom_gunaComboBox.Size = new System.Drawing.Size(75, 31);
            this.ttFrom_gunaComboBox.TabIndex = 19;
            // 
            // ttTo_gunaComboBox
            // 
            this.ttTo_gunaComboBox.BackColor = System.Drawing.Color.Transparent;
            this.ttTo_gunaComboBox.BaseColor = System.Drawing.Color.White;
            this.ttTo_gunaComboBox.BorderColor = System.Drawing.Color.Silver;
            this.ttTo_gunaComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ttTo_gunaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ttTo_gunaComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ttTo_gunaComboBox.ForeColor = System.Drawing.Color.Black;
            this.ttTo_gunaComboBox.FormattingEnabled = true;
            this.ttTo_gunaComboBox.Items.AddRange(new object[] {
            "am",
            "pm"});
            this.ttTo_gunaComboBox.Location = new System.Drawing.Point(410, 315);
            this.ttTo_gunaComboBox.Name = "ttTo_gunaComboBox";
            this.ttTo_gunaComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ttTo_gunaComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ttTo_gunaComboBox.Size = new System.Drawing.Size(75, 31);
            this.ttTo_gunaComboBox.TabIndex = 20;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(33, 225);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(257, 36);
            this.guna2DateTimePicker1.TabIndex = 21;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 11, 29, 8, 25, 5, 984);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.time_tick);
            // 
            // TimeOutEnd
            // 
            this.TimeOutEnd.BaseColor = System.Drawing.Color.White;
            this.TimeOutEnd.BorderColor = System.Drawing.Color.Silver;
            this.TimeOutEnd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TimeOutEnd.FocusedBaseColor = System.Drawing.Color.White;
            this.TimeOutEnd.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.TimeOutEnd.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TimeOutEnd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOutEnd.ForeColor = System.Drawing.Color.Silver;
            this.TimeOutEnd.Location = new System.Drawing.Point(293, 485);
            this.TimeOutEnd.Name = "TimeOutEnd";
            this.TimeOutEnd.PasswordChar = '\0';
            this.TimeOutEnd.Radius = 8;
            this.TimeOutEnd.Size = new System.Drawing.Size(99, 40);
            this.TimeOutEnd.TabIndex = 22;
            this.TimeOutEnd.Text = "hh/mm";
            this.TimeOutEnd.Click += new System.EventHandler(this.onClickTimeOutEnd);
            this.TimeOutEnd.Enter += new System.EventHandler(this.onEnterTimeOutEnd);
            this.TimeOutEnd.Leave += new System.EventHandler(this.onLeaveTimeOutEnd);
            // 
            // TimeInStart
            // 
            this.TimeInStart.BaseColor = System.Drawing.Color.White;
            this.TimeInStart.BorderColor = System.Drawing.Color.Silver;
            this.TimeInStart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TimeInStart.FocusedBaseColor = System.Drawing.Color.White;
            this.TimeInStart.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.TimeInStart.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TimeInStart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeInStart.ForeColor = System.Drawing.Color.Silver;
            this.TimeInStart.Location = new System.Drawing.Point(33, 422);
            this.TimeInStart.Name = "TimeInStart";
            this.TimeInStart.PasswordChar = '\0';
            this.TimeInStart.Radius = 8;
            this.TimeInStart.Size = new System.Drawing.Size(99, 40);
            this.TimeInStart.TabIndex = 23;
            this.TimeInStart.Text = "hh/mm";
            this.TimeInStart.Click += new System.EventHandler(this.onClickTimeIn);
            this.TimeInStart.Enter += new System.EventHandler(this.onEnterTimeInStart);
            this.TimeInStart.Leave += new System.EventHandler(this.onLeaveTimeInStart);
            // 
            // TimeOut1
            // 
            this.TimeOut1.BackColor = System.Drawing.Color.Transparent;
            this.TimeOut1.BaseColor = System.Drawing.Color.White;
            this.TimeOut1.BorderColor = System.Drawing.Color.Silver;
            this.TimeOut1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TimeOut1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeOut1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TimeOut1.ForeColor = System.Drawing.Color.Black;
            this.TimeOut1.FormattingEnabled = true;
            this.TimeOut1.Items.AddRange(new object[] {
            "am",
            "pm"});
            this.TimeOut1.Location = new System.Drawing.Point(410, 431);
            this.TimeOut1.Name = "TimeOut1";
            this.TimeOut1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TimeOut1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.TimeOut1.Size = new System.Drawing.Size(75, 31);
            this.TimeOut1.TabIndex = 24;
            // 
            // TimeIn1
            // 
            this.TimeIn1.BackColor = System.Drawing.Color.Transparent;
            this.TimeIn1.BaseColor = System.Drawing.Color.White;
            this.TimeIn1.BorderColor = System.Drawing.Color.Silver;
            this.TimeIn1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TimeIn1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeIn1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TimeIn1.ForeColor = System.Drawing.Color.Black;
            this.TimeIn1.FormattingEnabled = true;
            this.TimeIn1.Items.AddRange(new object[] {
            "am",
            "pm"});
            this.TimeIn1.Location = new System.Drawing.Point(150, 431);
            this.TimeIn1.Name = "TimeIn1";
            this.TimeIn1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TimeIn1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.TimeIn1.Size = new System.Drawing.Size(75, 31);
            this.TimeIn1.TabIndex = 25;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(289, 280);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(73, 23);
            this.gunaLabel1.TabIndex = 26;
            this.gunaLabel1.Text = "Time Till";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(29, 396);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(107, 23);
            this.gunaLabel2.TabIndex = 27;
            this.gunaLabel2.Text = "Time In Start";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(289, 396);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(121, 23);
            this.gunaLabel3.TabIndex = 28;
            this.gunaLabel3.Text = "Time Out Start";
            // 
            // TimeInEnd
            // 
            this.TimeInEnd.BaseColor = System.Drawing.Color.White;
            this.TimeInEnd.BorderColor = System.Drawing.Color.Silver;
            this.TimeInEnd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TimeInEnd.FocusedBaseColor = System.Drawing.Color.White;
            this.TimeInEnd.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.TimeInEnd.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TimeInEnd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeInEnd.ForeColor = System.Drawing.Color.Silver;
            this.TimeInEnd.Location = new System.Drawing.Point(33, 485);
            this.TimeInEnd.Name = "TimeInEnd";
            this.TimeInEnd.PasswordChar = '\0';
            this.TimeInEnd.Radius = 8;
            this.TimeInEnd.Size = new System.Drawing.Size(99, 40);
            this.TimeInEnd.TabIndex = 29;
            this.TimeInEnd.Text = "hh/mm";
            this.TimeInEnd.Click += new System.EventHandler(this.onClickTimeInEnd);
            this.TimeInEnd.Enter += new System.EventHandler(this.OnEnterTimeInEND);
            this.TimeInEnd.Leave += new System.EventHandler(this.onLeaveTimeInEnd);
            // 
            // TimeOutStart
            // 
            this.TimeOutStart.BaseColor = System.Drawing.Color.White;
            this.TimeOutStart.BorderColor = System.Drawing.Color.Silver;
            this.TimeOutStart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TimeOutStart.FocusedBaseColor = System.Drawing.Color.White;
            this.TimeOutStart.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.TimeOutStart.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TimeOutStart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOutStart.ForeColor = System.Drawing.Color.Silver;
            this.TimeOutStart.Location = new System.Drawing.Point(293, 422);
            this.TimeOutStart.Name = "TimeOutStart";
            this.TimeOutStart.PasswordChar = '\0';
            this.TimeOutStart.Radius = 8;
            this.TimeOutStart.Size = new System.Drawing.Size(99, 40);
            this.TimeOutStart.TabIndex = 30;
            this.TimeOutStart.Text = "hh/mm";
            this.TimeOutStart.Click += new System.EventHandler(this.onClickTimeOutStart);
            this.TimeOutStart.Enter += new System.EventHandler(this.onEnterTimeOutStart);
            this.TimeOutStart.Leave += new System.EventHandler(this.onLeaveTimeOutStart);
            // 
            // TimeIn2
            // 
            this.TimeIn2.BackColor = System.Drawing.Color.Transparent;
            this.TimeIn2.BaseColor = System.Drawing.Color.White;
            this.TimeIn2.BorderColor = System.Drawing.Color.Silver;
            this.TimeIn2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TimeIn2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeIn2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TimeIn2.ForeColor = System.Drawing.Color.Black;
            this.TimeIn2.FormattingEnabled = true;
            this.TimeIn2.Items.AddRange(new object[] {
            "am",
            "pm"});
            this.TimeIn2.Location = new System.Drawing.Point(150, 494);
            this.TimeIn2.Name = "TimeIn2";
            this.TimeIn2.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TimeIn2.OnHoverItemForeColor = System.Drawing.Color.White;
            this.TimeIn2.Size = new System.Drawing.Size(75, 31);
            this.TimeIn2.TabIndex = 31;
            // 
            // TimeOut2
            // 
            this.TimeOut2.BackColor = System.Drawing.Color.Transparent;
            this.TimeOut2.BaseColor = System.Drawing.Color.White;
            this.TimeOut2.BorderColor = System.Drawing.Color.Silver;
            this.TimeOut2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TimeOut2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeOut2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TimeOut2.ForeColor = System.Drawing.Color.Black;
            this.TimeOut2.FormattingEnabled = true;
            this.TimeOut2.Items.AddRange(new object[] {
            "am",
            "pm"});
            this.TimeOut2.Location = new System.Drawing.Point(410, 494);
            this.TimeOut2.Name = "TimeOut2";
            this.TimeOut2.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TimeOut2.OnHoverItemForeColor = System.Drawing.Color.White;
            this.TimeOut2.Size = new System.Drawing.Size(75, 31);
            this.TimeOut2.TabIndex = 32;
            // 
            // AddEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 615);
            this.Controls.Add(this.TimeOut2);
            this.Controls.Add(this.TimeIn2);
            this.Controls.Add(this.TimeOutStart);
            this.Controls.Add(this.TimeInEnd);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.TimeIn1);
            this.Controls.Add(this.TimeOut1);
            this.Controls.Add(this.TimeInStart);
            this.Controls.Add(this.TimeOutEnd);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.ttTo_gunaComboBox);
            this.Controls.Add(this.ttFrom_gunaComboBox);
            this.Controls.Add(this.AddEvent_gunaAdvenceButton);
            this.Controls.Add(this.TimeTo_gunaTextBox);
            this.Controls.Add(this.TimeFromText_gunaLabel);
            this.Controls.Add(this.TimeFrom_gunaTextBox);
            this.Controls.Add(this.DateText_gunaLabel);
            this.Controls.Add(this.EventNameText_gunaLabel);
            this.Controls.Add(this.EventName_gunaTextBox);
            this.Controls.Add(this.AddEventsTitle_gunaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEventsForm";
            this.AddEventsTitle_gunaPanel.ResumeLayout(false);
            this.AddEventsTitle_gunaPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel AddEventsTitle_gunaPanel;
        private Guna.UI.WinForms.GunaLabel AddEvents_gunaLabel;
        private Guna.UI.WinForms.GunaTextBox EventName_gunaTextBox;
        private Guna.UI.WinForms.GunaLabel EventNameText_gunaLabel;
        private Guna.UI.WinForms.GunaLabel DateText_gunaLabel;
        private Guna.UI.WinForms.GunaTextBox TimeFrom_gunaTextBox;
        private Guna.UI.WinForms.GunaLabel TimeFromText_gunaLabel;
        private Guna.UI.WinForms.GunaTextBox TimeTo_gunaTextBox;
        private Guna.UI.WinForms.GunaAdvenceButton AddEvent_gunaAdvenceButton;
        private Guna.UI.WinForms.GunaComboBox ttFrom_gunaComboBox;
        private Guna.UI.WinForms.GunaComboBox ttTo_gunaComboBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaTextBox TimeOutEnd;
        private Guna.UI.WinForms.GunaTextBox TimeInStart;
        private Guna.UI.WinForms.GunaComboBox TimeOut1;
        private Guna.UI.WinForms.GunaComboBox TimeIn1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox TimeInEnd;
        private Guna.UI.WinForms.GunaTextBox TimeOutStart;
        private Guna.UI.WinForms.GunaComboBox TimeIn2;
        private Guna.UI.WinForms.GunaComboBox TimeOut2;
    }
}