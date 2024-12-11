using CSAMS_WebSys.Forms;
using System;
using System.Windows.Forms;
using YourNamespace;
using System.IO;
using System.Text.RegularExpressions;
using FireSharp.Response;
using CSAMS_WebSys.Services;
using Google.Api.Gax;
using System.Drawing;
using Guna.UI2.WinForms;
using Guna.UI.WinForms;

namespace CSAMS_WebSys
{
    public partial class LoginForm : Form
    {
        private ConnectivityService con;
        public LoginForm()
        {
            InitializeComponent();
            con = new ConnectivityService();
            guna2WinProgressIndicator1.Hide();
        }
        private async void login_gunaAdvenceButton_Click(object sender, EventArgs e)
        {
  /*          MainForm mainform = new MainForm();
            mainform.Show();
            Visible = false;*/
            try
            {
                bool isConnected = await con.CheckNetworkAvailability();

                if (isConnected)
                {
                    guna2WinProgressIndicator1.Show();
                    guna2WinProgressIndicator1.Start();
                    string email = Email.Text;
                    string password = Password.Text;
                    string ErrorMessage = "";

                    if (string.IsNullOrEmpty(email))
                    {
                        guna2WinProgressIndicator1.Stop();
                        guna2WinProgressIndicator1.Hide();
                        ErrorMessage += "Email is required.";
                        Email.Focus();
                        guna2HtmlLabel1.Show();
                        if (string.IsNullOrEmpty(password))
                        {
                            guna2HtmlLabel2.Show();
                            ErrorMessage = "Please enter both email and password.";
                            MessageBox.Show(ErrorMessage, "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            return;
                        }
                        MessageBox.Show(ErrorMessage, "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!IsValidEmail(email))
                    {
                        guna2WinProgressIndicator1.Stop();
                        guna2WinProgressIndicator1.Hide();
                        MessageBox.Show("Invalid email format.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Email.Focus();
                        return;
                    }

                    if (password.Length < 8)
                    {
                        guna2WinProgressIndicator1.Stop();
                        guna2WinProgressIndicator1.Hide();
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

                    var authResponse = await firebaseAuthService.LoginAsync(email, password);

                    if(authResponse.IdToken == null)
                    {
                        guna2WinProgressIndicator1.Stop();
                        guna2WinProgressIndicator1.Hide();
                        throw new Exception();
                    }

                    MainForm mainform = new MainForm(authResponse);
                    mainform.Show();
                    Visible = false;

                }
                else
                {
                    MessageBox.Show("Unable to login. No internet connection detected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show($"Wrong email or password. Please try again.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                guna2WinProgressIndicator1.Stop();
                guna2WinProgressIndicator1.Hide();
            }
            
        }

        private void HighlightField1(GunaTextBox field, GunaTextBox field2, bool highlight)
        {
            if (highlight)
            {
                field.BorderColor = Color.Red;
                field2.BorderColor = Color.Red;
            }
        }

        private void HighlightField(GunaTextBox field, bool highlight)
        {
            if (highlight)
            {
                field.BorderColor = Color.Red; 
            }
        }

        private bool IsValidEmail(string email)
        {
            var emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Password.PasswordChar == '*')
            {
                UnHide.BringToFront();
                Password.PasswordChar = '\0';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Password.PasswordChar == '\0')
            {
                Hide.BringToFront();
                Password.PasswordChar = '*';
            }
        }

        private void onTypeEmail(object sender, EventArgs e)
        {
            guna2HtmlLabel1.Hide();
        }

        private void onTypePassword(object sender, EventArgs e)
        {
            guna2HtmlLabel2.Hide();
        }
    }
}
