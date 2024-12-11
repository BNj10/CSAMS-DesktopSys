using CSAMS_WebSys.Forms;
using System;
using System.Windows.Forms;
using YourNamespace;
using System.IO;
using System.Text.RegularExpressions;
using FireSharp.Response;
using CSAMS_WebSys.Services;

namespace CSAMS_WebSys
{
    public partial class LoginForm : Form
    {
        private ConnectivityService con;
        public LoginForm()
        {
            InitializeComponent();
            con = new ConnectivityService();
        }
        //CHANGE LOGIN CLICK TO ASYNC
        private async void login_gunaAdvenceButton_Click(object sender, EventArgs e)
        {
/*            MainForm mainform = new MainForm();
            mainform.Show();
            Visible = false;*/
            bool isConnected = await con.CheckNetworkAvailability();

            if (isConnected)
            {
                string email = Email.Text;
                string password = Password.Text;
                string ErrorMessage = "";

                if (string.IsNullOrEmpty(email))
                {
                    ErrorMessage += "Email is required.";
                    if (string.IsNullOrEmpty(password))
                    {
                        ErrorMessage = "Please enter both email and password.";
                        MessageBox.Show(ErrorMessage, "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show(ErrorMessage, "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Invalid email format.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Email.Focus();
                    return;
                }

                if (password.Length < 8)
                {
                    MessageBox.Show("Password must be at least 8 characters long.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Password.Focus();
                    return;
                }

                string envPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ".env");
                if (File.Exists(envPath))
                {
                    DotNetEnv.Env.Load(envPath);
                }
                else
                {
                    throw new FileNotFoundException("Environment file (.env) not found.");
                }
                string credentialsPath = Environment.GetEnvironmentVariable("FIREBASE_API_KEY");

                var firebaseAuthService = new FirebaseAuthService(credentialsPath);
                try
                {
                    var authResponse = await firebaseAuthService.LoginAsync(email, password);
                    MainForm mainform = new MainForm(authResponse);
                    mainform.Show();
                    Visible = false;
                }
                catch
                {
                    MessageBox.Show($"Wrong email or password. Please try again!", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Unable to login. No internet connection detected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            var emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Password.PasswordChar == '*')
            {
                UnHide.BringToFront();
                Password.PasswordChar = '\0';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Password.PasswordChar == '\0')
            {
                Hide.BringToFront();
                Password.PasswordChar = '*';
            }
        }
    }
    
}
