using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using DotNetEnv;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourNamespace;
using Google.Apis.Auth.OAuth2;
using FirebaseAdmin;
using CSAMS_WebSys.Models;
using CSAMS_WebSys.Services;
using CSAMS_WebSys.UserControls;
using System.Drawing.Printing;


namespace CSAMS_WebSys.Forms
{
    public partial class MainForm : Form
    {
       /* private bool isConnected = false;*/
        private ConnectivityService con;
        private bool hasShownDisconnectedMessage = false;
        private SchoolYearServices SchoolYearServices;
        //PARAMETER FOR THE MAIN FORM -> FirebaseAuthResponse auth
        public MainForm(FirebaseAuthResponse auth)
        {
            InitializeComponent();
            /*            this.con = con;*/
            //CheckConnectivity();
            string username = auth.Email.Split('@')[0];
            UserName.Text = username;
            checkInternet1.Visible = true;
            SchoolYearServices = new SchoolYearServices();
            UpdateSchoolYears();
            userControl_Dashboard1.BringToFront();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            this.timer1.Start();
        }
        private bool IsInternetAvailable()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingReply reply = myPing.Send(host, timeout, buffer);
                return reply.Status == IPStatus.Success;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private async void UpdateSchoolYears()
        {
            await SchoolYearServices.UpdateSchoolYearAsync();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool isConnected = IsInternetAvailable();

            if (isConnected)
            {
                checkInternet1.BackColor = Color.LightGreen; 
                checkInternet1.Text = "Connected";
                hasShownDisconnectedMessage = false;  
            }
            else
            {
                checkInternet1.BackColor = Color.Red;  
                checkInternet1.Text = "No Internet";

                if (!hasShownDisconnectedMessage)
                {
                    hasShownDisconnectedMessage = true; 
                }
            }
        }

        private void Logout_gunaAdvenceButton_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }

        private void Dashboard_gunaAdvenceButton_Click(object sender, EventArgs e)
        {
            Events_gunaAdvenceButton.Enabled = true;
            userControl_Dashboard1.BringToFront();
            userControl_Dashboard1.InitializeElements();
        }

        private void Members_gunaAdvenceButton_Click(object sender, EventArgs e)
        {
            Events_gunaAdvenceButton.Enabled = true;
            userControl_Members1.BringToFront();

        }

        private void Events_gunaAdvenceButton_Click(object sender, EventArgs e)
        {
            Events_gunaAdvenceButton.Enabled = false;
            userControl_Events1.BringToFront();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Events_gunaAdvenceButton.Enabled = true;
            archiveEvents1.BringToFront();
        }
    }
}
