namespace CSAMS_WebSys.Forms
{
    partial class MainForm
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
            this.NavSideBar_gunaPanel = new Guna.UI.WinForms.GunaPanel();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.Logout_gunaAdvenceButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.Events_gunaAdvenceButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.Members_gunaAdvenceButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.Dashboard_gunaAdvenceButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.Logo_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.Welcome_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.UserName = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.checkInternet1 = new CSAMS_WebSys.UserControls.CheckInternet();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.userControl_Dashboard1 = new UserControls.UserControl_Dashboard();
            this.userControl_Events1 = new UserControls.UserControl_Events();
            this.userControl_Members1 = new UserControls.UserControl_Members();
            this.archiveEvents1 = new CSAMS_WebSys.UserControls.ArchiveEvents();
            this.NavSideBar_gunaPanel.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavSideBar_gunaPanel
            // 
            this.NavSideBar_gunaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            //this.NavSideBar_gunaPanel.Controls.Add(this.gunaAdvenceButton1);
            this.NavSideBar_gunaPanel.Controls.Add(this.Logout_gunaAdvenceButton);
            this.NavSideBar_gunaPanel.Controls.Add(this.Events_gunaAdvenceButton);
            this.NavSideBar_gunaPanel.Controls.Add(this.Members_gunaAdvenceButton);
            this.NavSideBar_gunaPanel.Controls.Add(this.Dashboard_gunaAdvenceButton);
            this.NavSideBar_gunaPanel.Controls.Add(this.Logo_gunaLabel);
            this.NavSideBar_gunaPanel.Location = new System.Drawing.Point(0, 0);
            this.NavSideBar_gunaPanel.Name = "NavSideBar_gunaPanel";
            this.NavSideBar_gunaPanel.Size = new System.Drawing.Size(350, 1080);
            this.NavSideBar_gunaPanel.TabIndex = 0;
            // 
            // gunaAdvenceButton1
            // 
            
            // 
            // Logout_gunaAdvenceButton
            // 
            this.Logout_gunaAdvenceButton.AnimationHoverSpeed = 0.07F;
            this.Logout_gunaAdvenceButton.AnimationSpeed = 0.03F;
            this.Logout_gunaAdvenceButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.Logout_gunaAdvenceButton.BorderColor = System.Drawing.Color.White;
            this.Logout_gunaAdvenceButton.BorderSize = 1;
            this.Logout_gunaAdvenceButton.CheckedBaseColor = System.Drawing.Color.White;
            this.Logout_gunaAdvenceButton.CheckedBorderColor = System.Drawing.Color.White;
            this.Logout_gunaAdvenceButton.CheckedForeColor = System.Drawing.Color.Black;
            this.Logout_gunaAdvenceButton.CheckedImage = global::CSAMS_WebSys.Properties.Resources.logout;
            this.Logout_gunaAdvenceButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.Logout_gunaAdvenceButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_gunaAdvenceButton.ForeColor = System.Drawing.Color.White;
            this.Logout_gunaAdvenceButton.Image = global::CSAMS_WebSys.Properties.Resources.logout;
            this.Logout_gunaAdvenceButton.ImageSize = new System.Drawing.Size(20, 20);
            this.Logout_gunaAdvenceButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Logout_gunaAdvenceButton.Location = new System.Drawing.Point(33, 971);
            this.Logout_gunaAdvenceButton.Name = "Logout_gunaAdvenceButton";
            this.Logout_gunaAdvenceButton.OnHoverBaseColor = System.Drawing.Color.White;
            this.Logout_gunaAdvenceButton.OnHoverBorderColor = System.Drawing.Color.White;
            this.Logout_gunaAdvenceButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.Logout_gunaAdvenceButton.OnHoverImage = null;
            this.Logout_gunaAdvenceButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Logout_gunaAdvenceButton.OnPressedColor = System.Drawing.Color.Black;
            this.Logout_gunaAdvenceButton.Radius = 17;
            this.Logout_gunaAdvenceButton.Size = new System.Drawing.Size(282, 42);
            this.Logout_gunaAdvenceButton.TabIndex = 4;
            this.Logout_gunaAdvenceButton.Text = "Logout";
            this.Logout_gunaAdvenceButton.Click += new System.EventHandler(this.Logout_gunaAdvenceButton_Click);
            // 
            // Events_gunaAdvenceButton
            // 
            this.Events_gunaAdvenceButton.AnimationHoverSpeed = 0.07F;
            this.Events_gunaAdvenceButton.AnimationSpeed = 0.03F;
            this.Events_gunaAdvenceButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.Events_gunaAdvenceButton.BorderColor = System.Drawing.Color.White;
            this.Events_gunaAdvenceButton.BorderSize = 1;
            this.Events_gunaAdvenceButton.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.Events_gunaAdvenceButton.CheckedBaseColor = System.Drawing.Color.White;
            this.Events_gunaAdvenceButton.CheckedBorderColor = System.Drawing.Color.White;
            this.Events_gunaAdvenceButton.CheckedForeColor = System.Drawing.Color.Black;
            this.Events_gunaAdvenceButton.CheckedImage = global::CSAMS_WebSys.Properties.Resources.events;
            this.Events_gunaAdvenceButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.Events_gunaAdvenceButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Events_gunaAdvenceButton.ForeColor = System.Drawing.Color.White;
            this.Events_gunaAdvenceButton.Image = global::CSAMS_WebSys.Properties.Resources.events;
            this.Events_gunaAdvenceButton.ImageSize = new System.Drawing.Size(20, 20);
            this.Events_gunaAdvenceButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Events_gunaAdvenceButton.Location = new System.Drawing.Point(33, 410);
            this.Events_gunaAdvenceButton.Name = "Events_gunaAdvenceButton";
            this.Events_gunaAdvenceButton.OnHoverBaseColor = System.Drawing.Color.White;
            this.Events_gunaAdvenceButton.OnHoverBorderColor = System.Drawing.Color.White;
            this.Events_gunaAdvenceButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.Events_gunaAdvenceButton.OnHoverImage = null;
            this.Events_gunaAdvenceButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Events_gunaAdvenceButton.OnPressedColor = System.Drawing.Color.Black;
            this.Events_gunaAdvenceButton.Radius = 17;
            this.Events_gunaAdvenceButton.Size = new System.Drawing.Size(282, 42);
            this.Events_gunaAdvenceButton.TabIndex = 3;
            this.Events_gunaAdvenceButton.Text = "Events";
            this.Events_gunaAdvenceButton.Click += new System.EventHandler(this.Events_gunaAdvenceButton_Click);
            // 
            // Members_gunaAdvenceButton
            // 
            this.Members_gunaAdvenceButton.AnimationHoverSpeed = 0.07F;
            this.Members_gunaAdvenceButton.AnimationSpeed = 0.03F;
            this.Members_gunaAdvenceButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.Members_gunaAdvenceButton.BorderColor = System.Drawing.Color.White;
            this.Members_gunaAdvenceButton.BorderSize = 1;
            this.Members_gunaAdvenceButton.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.Members_gunaAdvenceButton.CheckedBaseColor = System.Drawing.Color.White;
            this.Members_gunaAdvenceButton.CheckedBorderColor = System.Drawing.Color.White;
            this.Members_gunaAdvenceButton.CheckedForeColor = System.Drawing.Color.Black;
            this.Members_gunaAdvenceButton.CheckedImage = global::CSAMS_WebSys.Properties.Resources.member;
            this.Members_gunaAdvenceButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.Members_gunaAdvenceButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Members_gunaAdvenceButton.ForeColor = System.Drawing.Color.White;
            this.Members_gunaAdvenceButton.Image = global::CSAMS_WebSys.Properties.Resources.member;
            this.Members_gunaAdvenceButton.ImageSize = new System.Drawing.Size(20, 20);
            this.Members_gunaAdvenceButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Members_gunaAdvenceButton.Location = new System.Drawing.Point(33, 353);
            this.Members_gunaAdvenceButton.Name = "Members_gunaAdvenceButton";
            this.Members_gunaAdvenceButton.OnHoverBaseColor = System.Drawing.Color.White;
            this.Members_gunaAdvenceButton.OnHoverBorderColor = System.Drawing.Color.White;
            this.Members_gunaAdvenceButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.Members_gunaAdvenceButton.OnHoverImage = null;
            this.Members_gunaAdvenceButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Members_gunaAdvenceButton.OnPressedColor = System.Drawing.Color.Black;
            this.Members_gunaAdvenceButton.Radius = 17;
            this.Members_gunaAdvenceButton.Size = new System.Drawing.Size(282, 42);
            this.Members_gunaAdvenceButton.TabIndex = 2;
            this.Members_gunaAdvenceButton.Text = "Members";
            this.Members_gunaAdvenceButton.Click += new System.EventHandler(this.Members_gunaAdvenceButton_Click);
            // 
            // Dashboard_gunaAdvenceButton
            // 
            this.Dashboard_gunaAdvenceButton.AnimationHoverSpeed = 0.07F;
            this.Dashboard_gunaAdvenceButton.AnimationSpeed = 0.03F;
            this.Dashboard_gunaAdvenceButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.Dashboard_gunaAdvenceButton.BorderColor = System.Drawing.Color.White;
            this.Dashboard_gunaAdvenceButton.BorderSize = 1;
            this.Dashboard_gunaAdvenceButton.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.Dashboard_gunaAdvenceButton.Checked = true;
            this.Dashboard_gunaAdvenceButton.CheckedBaseColor = System.Drawing.Color.White;
            this.Dashboard_gunaAdvenceButton.CheckedBorderColor = System.Drawing.Color.White;
            this.Dashboard_gunaAdvenceButton.CheckedForeColor = System.Drawing.Color.Black;
            this.Dashboard_gunaAdvenceButton.CheckedImage = global::CSAMS_WebSys.Properties.Resources.dashboard1;
            this.Dashboard_gunaAdvenceButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.Dashboard_gunaAdvenceButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard_gunaAdvenceButton.ForeColor = System.Drawing.Color.White;
            this.Dashboard_gunaAdvenceButton.Image = global::CSAMS_WebSys.Properties.Resources.dashboard1;
            this.Dashboard_gunaAdvenceButton.ImageSize = new System.Drawing.Size(20, 20);
            this.Dashboard_gunaAdvenceButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Dashboard_gunaAdvenceButton.Location = new System.Drawing.Point(33, 296);
            this.Dashboard_gunaAdvenceButton.Name = "Dashboard_gunaAdvenceButton";
            this.Dashboard_gunaAdvenceButton.OnHoverBaseColor = System.Drawing.Color.White;
            this.Dashboard_gunaAdvenceButton.OnHoverBorderColor = System.Drawing.Color.White;
            this.Dashboard_gunaAdvenceButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.Dashboard_gunaAdvenceButton.OnHoverImage = null;
            this.Dashboard_gunaAdvenceButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Dashboard_gunaAdvenceButton.OnPressedColor = System.Drawing.Color.Black;
            this.Dashboard_gunaAdvenceButton.Radius = 17;
            this.Dashboard_gunaAdvenceButton.Size = new System.Drawing.Size(282, 42);
            this.Dashboard_gunaAdvenceButton.TabIndex = 1;
            this.Dashboard_gunaAdvenceButton.Text = "Dashboard";
            this.Dashboard_gunaAdvenceButton.Click += new System.EventHandler(this.Dashboard_gunaAdvenceButton_Click);
            // 
            // Logo_gunaLabel
            // 
            this.Logo_gunaLabel.AutoSize = true;
            this.Logo_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.Logo_gunaLabel.ForeColor = System.Drawing.Color.White;
            this.Logo_gunaLabel.Location = new System.Drawing.Point(51, 27);
            this.Logo_gunaLabel.Name = "Logo_gunaLabel";
            this.Logo_gunaLabel.Size = new System.Drawing.Size(239, 81);
            this.Logo_gunaLabel.TabIndex = 0;
            this.Logo_gunaLabel.Text = "CSAMS";
            // 
            // Welcome_gunaLabel
            // 
            this.Welcome_gunaLabel.AutoSize = true;
            this.Welcome_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_gunaLabel.Location = new System.Drawing.Point(4, 27);
            this.Welcome_gunaLabel.Name = "Welcome_gunaLabel";
            this.Welcome_gunaLabel.Size = new System.Drawing.Size(172, 45);
            this.Welcome_gunaLabel.TabIndex = 1;
            this.Welcome_gunaLabel.Text = "Welcome,";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(191, 27);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(191, 45);
            this.UserName.TabIndex = 2;
            this.UserName.Text = "User Name";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.checkInternet1);
            this.gunaPanel1.Controls.Add(this.Welcome_gunaLabel);
            this.gunaPanel1.Controls.Add(this.UserName);
            this.gunaPanel1.Location = new System.Drawing.Point(350, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1570, 82);
            this.gunaPanel1.TabIndex = 3;
            // 
            // checkInternet1
            // 
            // 
            // userControl_Dashboard1
            // 
            this.userControl_Dashboard1.BackColor = System.Drawing.Color.White;
            this.userControl_Dashboard1.Location = new System.Drawing.Point(350, 110);
            this.userControl_Dashboard1.Name = "userControl_Dashboard1";
            this.userControl_Dashboard1.Size = new System.Drawing.Size(1570, 970);
            this.userControl_Dashboard1.TabIndex = 4;
            // 
            //
            //
            // archiveEvents1
            // 
            this.archiveEvents1.BackColor = System.Drawing.Color.White;
            this.archiveEvents1.Location = new System.Drawing.Point(350, 110);
            this.archiveEvents1.Name = "archiveEvents1";
            this.archiveEvents1.Size = new System.Drawing.Size(1570, 970);
            this.archiveEvents1.TabIndex = 7;
            //
            //
            //
            this.userControl_Events1.BackColor = System.Drawing.Color.White;
            this.userControl_Events1.Location = new System.Drawing.Point(350, 110);
            this.userControl_Events1.Name = "userControl_Events1";
            this.userControl_Events1.Size = new System.Drawing.Size(1570, 970);
            this.userControl_Events1.TabIndex = 5;
            // 
            // userControl_Members1
            // 
            this.userControl_Members1.BackColor = System.Drawing.Color.White;
            this.userControl_Members1.Location = new System.Drawing.Point(350, 110);
            this.userControl_Members1.Name = "userControl_Members1";
            this.userControl_Members1.Size = new System.Drawing.Size(1570, 970);
            this.userControl_Members1.TabIndex = 6;

            this.checkInternet1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkInternet1.Location = new System.Drawing.Point(1302, 12);
            this.checkInternet1.Name = "checkInternet1";
            this.checkInternet1.Size = new System.Drawing.Size(256, 60);
            this.checkInternet1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
        //    this.Controls.Add(this.archiveEvents1);
            this.Controls.Add(this.userControl_Members1);
            this.Controls.Add(this.userControl_Events1);
            this.Controls.Add(this.userControl_Dashboard1);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.NavSideBar_gunaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.NavSideBar_gunaPanel.ResumeLayout(false);
            this.NavSideBar_gunaPanel.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel NavSideBar_gunaPanel;
        private Guna.UI.WinForms.GunaLabel Logo_gunaLabel;
        private Guna.UI.WinForms.GunaAdvenceButton Dashboard_gunaAdvenceButton;
        private Guna.UI.WinForms.GunaAdvenceButton Events_gunaAdvenceButton;
        private Guna.UI.WinForms.GunaAdvenceButton Members_gunaAdvenceButton;
        private Guna.UI.WinForms.GunaAdvenceButton Logout_gunaAdvenceButton;
        private Guna.UI.WinForms.GunaLabel Welcome_gunaLabel;
        private Guna.UI.WinForms.GunaLabel UserName;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private UserControls.UserControl_Dashboard userControl_Dashboard1;
        private UserControls.UserControl_Events userControl_Events1;
        private UserControls.UserControl_Members userControl_Members1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private UserControls.ArchiveEvents archiveEvents1;
        private System.Windows.Forms.Timer timer1;
        private UserControls.CheckInternet checkInternet1;
    }
}