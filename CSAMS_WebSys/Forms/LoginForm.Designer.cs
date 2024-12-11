using System.Windows.Forms;

namespace CSAMS_WebSys
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.TopPanel_gunaPanel = new Guna.UI.WinForms.GunaPanel();
            this.TopPanelText_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.loginPanel_gunaShadowPanel = new Guna.UI.WinForms.GunaShadowPanel();
            this.guna2WinProgressIndicator1 = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.Hide = new System.Windows.Forms.Button();
            this.UnHide = new System.Windows.Forms.Button();
            this.Login = new Guna.UI.WinForms.GunaAdvenceButton();
            this.passwordText_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.emailText_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.Password = new Guna.UI.WinForms.GunaTextBox();
            this.Email = new Guna.UI.WinForms.GunaTextBox();
            this.developText_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.logInText_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.welcomeText_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.loginTextPanel_gunaPanel = new Guna.UI.WinForms.GunaPanel();
            this.textTitle_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TopPanel_gunaPanel.SuspendLayout();
            this.loginPanel_gunaShadowPanel.SuspendLayout();
            this.loginTextPanel_gunaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel_gunaPanel
            // 
            this.TopPanel_gunaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.TopPanel_gunaPanel.Controls.Add(this.TopPanelText_gunaLabel);
            this.TopPanel_gunaPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel_gunaPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel_gunaPanel.Name = "TopPanel_gunaPanel";
            this.TopPanel_gunaPanel.Size = new System.Drawing.Size(1726, 82);
            this.TopPanel_gunaPanel.TabIndex = 4;
            // 
            // TopPanelText_gunaLabel
            // 
            this.TopPanelText_gunaLabel.AutoSize = true;
            this.TopPanelText_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPanelText_gunaLabel.ForeColor = System.Drawing.Color.White;
            this.TopPanelText_gunaLabel.Location = new System.Drawing.Point(693, 17);
            this.TopPanelText_gunaLabel.Name = "TopPanelText_gunaLabel";
            this.TopPanelText_gunaLabel.Size = new System.Drawing.Size(517, 41);
            this.TopPanelText_gunaLabel.TabIndex = 5;
            this.TopPanelText_gunaLabel.Text = "CS3 Attendance Management System";
            // 
            // loginPanel_gunaShadowPanel
            // 
            this.loginPanel_gunaShadowPanel.BaseColor = System.Drawing.Color.White;
            this.loginPanel_gunaShadowPanel.Controls.Add(this.guna2HtmlLabel2);
            this.loginPanel_gunaShadowPanel.Controls.Add(this.guna2HtmlLabel1);
            this.loginPanel_gunaShadowPanel.Controls.Add(this.guna2WinProgressIndicator1);
            this.loginPanel_gunaShadowPanel.Controls.Add(this.Hide);
            this.loginPanel_gunaShadowPanel.Controls.Add(this.UnHide);
            this.loginPanel_gunaShadowPanel.Controls.Add(this.Login);
            this.loginPanel_gunaShadowPanel.Controls.Add(this.passwordText_gunaLabel);
            this.loginPanel_gunaShadowPanel.Controls.Add(this.emailText_gunaLabel);
            this.loginPanel_gunaShadowPanel.Controls.Add(this.Password);
            this.loginPanel_gunaShadowPanel.Controls.Add(this.Email);
            this.loginPanel_gunaShadowPanel.Controls.Add(this.developText_gunaLabel);
            this.loginPanel_gunaShadowPanel.Controls.Add(this.logInText_gunaLabel);
            this.loginPanel_gunaShadowPanel.Controls.Add(this.welcomeText_gunaLabel);
            this.loginPanel_gunaShadowPanel.Location = new System.Drawing.Point(502, 231);
            this.loginPanel_gunaShadowPanel.Name = "loginPanel_gunaShadowPanel";
            this.loginPanel_gunaShadowPanel.ShadowColor = System.Drawing.Color.Black;
            this.loginPanel_gunaShadowPanel.ShadowShift = 9;
            this.loginPanel_gunaShadowPanel.Size = new System.Drawing.Size(945, 730);
            this.loginPanel_gunaShadowPanel.TabIndex = 5;
            // 
            // guna2WinProgressIndicator1
            // 
            this.guna2WinProgressIndicator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2WinProgressIndicator1.CircleSize = 4F;
            this.guna2WinProgressIndicator1.Location = new System.Drawing.Point(403, 231);
            this.guna2WinProgressIndicator1.Name = "guna2WinProgressIndicator1";
            this.guna2WinProgressIndicator1.Size = new System.Drawing.Size(130, 135);
            this.guna2WinProgressIndicator1.TabIndex = 25;
            this.guna2WinProgressIndicator1.UseTransparentBackground = true;
            // 
            // Hide
            // 
            this.Hide.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Hide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Hide.BackgroundImage")));
            this.Hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Hide.FlatAppearance.BorderSize = 0;
            this.Hide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Hide.Location = new System.Drawing.Point(821, 517);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(48, 48);
            this.Hide.TabIndex = 24;
            this.Hide.UseVisualStyleBackColor = false;
            this.Hide.Click += new System.EventHandler(this.button3_Click);
            // 
            // UnHide
            // 
            this.UnHide.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UnHide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UnHide.BackgroundImage")));
            this.UnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UnHide.FlatAppearance.BorderSize = 0;
            this.UnHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.UnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnHide.Location = new System.Drawing.Point(821, 517);
            this.UnHide.Name = "UnHide";
            this.UnHide.Size = new System.Drawing.Size(48, 48);
            this.UnHide.TabIndex = 23;
            this.UnHide.UseVisualStyleBackColor = false;
            this.UnHide.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.Login.AnimationHoverSpeed = 0.07F;
            this.Login.AnimationSpeed = 0.03F;
            this.Login.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.Login.BorderColor = System.Drawing.Color.Black;
            this.Login.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.Login.CheckedBorderColor = System.Drawing.Color.Black;
            this.Login.CheckedForeColor = System.Drawing.Color.White;
            this.Login.CheckedImage = null;
            this.Login.CheckedLineColor = System.Drawing.Color.DimGray;
            this.Login.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Image = null;
            this.Login.ImageSize = new System.Drawing.Size(20, 20);
            this.Login.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Login.Location = new System.Drawing.Point(220, 630);
            this.Login.Name = "Login";
            this.Login.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.Login.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Login.OnHoverForeColor = System.Drawing.Color.White;
            this.Login.OnHoverImage = null;
            this.Login.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Login.OnPressedColor = System.Drawing.Color.Black;
            this.Login.Radius = 8;
            this.Login.Size = new System.Drawing.Size(507, 58);
            this.Login.TabIndex = 20;
            this.Login.Text = "Login";
            this.Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Login.Click += new System.EventHandler(this.login_gunaAdvenceButton_Click);
            // 
            // passwordText_gunaLabel
            // 
            this.passwordText_gunaLabel.AutoSize = true;
            this.passwordText_gunaLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordText_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText_gunaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordText_gunaLabel.Location = new System.Drawing.Point(65, 465);
            this.passwordText_gunaLabel.Name = "passwordText_gunaLabel";
            this.passwordText_gunaLabel.Size = new System.Drawing.Size(132, 38);
            this.passwordText_gunaLabel.TabIndex = 10;
            this.passwordText_gunaLabel.Text = "Password";
            // 
            // emailText_gunaLabel
            // 
            this.emailText_gunaLabel.AutoSize = true;
            this.emailText_gunaLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailText_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailText_gunaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailText_gunaLabel.Location = new System.Drawing.Point(65, 345);
            this.emailText_gunaLabel.Name = "emailText_gunaLabel";
            this.emailText_gunaLabel.Size = new System.Drawing.Size(83, 38);
            this.emailText_gunaLabel.TabIndex = 9;
            this.emailText_gunaLabel.Text = "Email";
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.BaseColor = System.Drawing.Color.White;
            this.Password.BorderColor = System.Drawing.Color.Silver;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.FocusedBaseColor = System.Drawing.Color.White;
            this.Password.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.Password.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(60, 506);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Radius = 13;
            this.Password.Size = new System.Drawing.Size(833, 68);
            this.Password.TabIndex = 8;
            this.Password.TextChanged += new System.EventHandler(this.onTypePassword);
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.Transparent;
            this.Email.BaseColor = System.Drawing.Color.White;
            this.Email.BorderColor = System.Drawing.Color.Silver;
            this.Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email.FocusedBaseColor = System.Drawing.Color.White;
            this.Email.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(24)))), ((int)(((byte)(83)))));
            this.Email.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Email.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(60, 386);
            this.Email.Name = "Email";
            this.Email.PasswordChar = '\0';
            this.Email.Radius = 13;
            this.Email.Size = new System.Drawing.Size(833, 68);
            this.Email.TabIndex = 7;
            this.Email.TextChanged += new System.EventHandler(this.onTypeEmail);
            // 
            // developText_gunaLabel
            // 
            this.developText_gunaLabel.AutoSize = true;
            this.developText_gunaLabel.BackColor = System.Drawing.Color.Transparent;
            this.developText_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developText_gunaLabel.ForeColor = System.Drawing.Color.Gray;
            this.developText_gunaLabel.Location = new System.Drawing.Point(68, 280);
            this.developText_gunaLabel.Name = "developText_gunaLabel";
            this.developText_gunaLabel.Size = new System.Drawing.Size(329, 23);
            this.developText_gunaLabel.TabIndex = 2;
            this.developText_gunaLabel.Text = "Developed by Computer Science Students";
            // 
            // logInText_gunaLabel
            // 
            this.logInText_gunaLabel.AutoSize = true;
            this.logInText_gunaLabel.BackColor = System.Drawing.Color.Transparent;
            this.logInText_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInText_gunaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logInText_gunaLabel.Location = new System.Drawing.Point(65, 166);
            this.logInText_gunaLabel.Name = "logInText_gunaLabel";
            this.logInText_gunaLabel.Size = new System.Drawing.Size(643, 41);
            this.logInText_gunaLabel.TabIndex = 1;
            this.logInText_gunaLabel.Text = "Log in to CS3 Attendance Management System\r\n";
            // 
            // welcomeText_gunaLabel
            // 
            this.welcomeText_gunaLabel.AutoSize = true;
            this.welcomeText_gunaLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeText_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeText_gunaLabel.Location = new System.Drawing.Point(63, 94);
            this.welcomeText_gunaLabel.Name = "welcomeText_gunaLabel";
            this.welcomeText_gunaLabel.Size = new System.Drawing.Size(185, 54);
            this.welcomeText_gunaLabel.TabIndex = 0;
            this.welcomeText_gunaLabel.Text = "Welcome";
            // 
            // loginTextPanel_gunaPanel
            // 
            this.loginTextPanel_gunaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(36)))));
            this.loginTextPanel_gunaPanel.Controls.Add(this.textTitle_gunaLabel);
            this.loginTextPanel_gunaPanel.Location = new System.Drawing.Point(539, 177);
            this.loginTextPanel_gunaPanel.Name = "loginTextPanel_gunaPanel";
            this.loginTextPanel_gunaPanel.Size = new System.Drawing.Size(856, 114);
            this.loginTextPanel_gunaPanel.TabIndex = 6;
            // 
            // textTitle_gunaLabel
            // 
            this.textTitle_gunaLabel.AutoSize = true;
            this.textTitle_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitle_gunaLabel.ForeColor = System.Drawing.Color.White;
            this.textTitle_gunaLabel.Location = new System.Drawing.Point(261, 28);
            this.textTitle_gunaLabel.Name = "textTitle_gunaLabel";
            this.textTitle_gunaLabel.Size = new System.Drawing.Size(367, 50);
            this.textTitle_gunaLabel.TabIndex = 0;
            this.textTitle_gunaLabel.Text = "Welcome to CSAMS";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(140, 350);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(14, 33);
            this.guna2HtmlLabel1.TabIndex = 26;
            this.guna2HtmlLabel1.Text = "*";
            this.guna2HtmlLabel1.Visible = false;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(190, 470);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(14, 33);
            this.guna2HtmlLabel2.TabIndex = 27;
            this.guna2HtmlLabel2.Text = "*";
            this.guna2HtmlLabel2.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1726, 882);
            this.Controls.Add(this.loginTextPanel_gunaPanel);
            this.Controls.Add(this.loginPanel_gunaShadowPanel);
            this.Controls.Add(this.TopPanel_gunaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TopPanel_gunaPanel.ResumeLayout(false);
            this.TopPanel_gunaPanel.PerformLayout();
            this.loginPanel_gunaShadowPanel.ResumeLayout(false);
            this.loginPanel_gunaShadowPanel.PerformLayout();
            this.loginTextPanel_gunaPanel.ResumeLayout(false);
            this.loginTextPanel_gunaPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel TopPanel_gunaPanel;
        private Guna.UI.WinForms.GunaLabel TopPanelText_gunaLabel;
        private Guna.UI.WinForms.GunaShadowPanel loginPanel_gunaShadowPanel;
        private Guna.UI.WinForms.GunaPanel loginTextPanel_gunaPanel;
        private Guna.UI.WinForms.GunaLabel textTitle_gunaLabel;
        private Guna.UI.WinForms.GunaLabel developText_gunaLabel;
        private Guna.UI.WinForms.GunaLabel logInText_gunaLabel;
        private Guna.UI.WinForms.GunaLabel welcomeText_gunaLabel;
        private Guna.UI.WinForms.GunaLabel emailText_gunaLabel;
        private Guna.UI.WinForms.GunaTextBox Password;
        private Guna.UI.WinForms.GunaTextBox Email;
        private Guna.UI.WinForms.GunaLabel passwordText_gunaLabel;
        private Guna.UI.WinForms.GunaAdvenceButton Login;
        private System.Windows.Forms.Button UnHide;
        private Button Hide;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator guna2WinProgressIndicator1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}

