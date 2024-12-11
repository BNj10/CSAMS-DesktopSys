using CSAMS_WebSys.Models;
using CSAMS_WebSys.Services;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSAMS_WebSys.Forms
{
    public partial class EditMemberForm : Form
    {
        private DPFP.Capture.ReadersCollection readers;
        private FingerprintEnrollService enroll;
        public event Action<MemberModel> MemberEdited;
        public event Action CloseForm;
        private bool IsConnected = false;
        private bool isComplete = false;
        private string f1, f2;
        private bool previousConnectionState = false;
        private MemberService memberservice;
        private MemberModel member;
        private bool attempted = false;
        private bool capturing = false;
        private bool isCheckingDevice = false;
        public EditMemberForm(MemberModel member)
        {
            InitializeComponent();
            this.memberservice = new MemberService();
            this.member = member;
            enroll = new FingerprintEnrollService();
            enroll.LogInfo += UpdateStatus;
            enroll.Complete += WithFingerprint;
            InitializeTimers();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private async void EditMember_gunaAdvenceButton_Click(object sender, EventArgs e)
        {
            string lastName = LastName_gunaTextBox.Text;
            string firstName = FirstName_gunaTextBox.Text;
            string studentID = StudentID_gunaTextBox.Text;

            if (string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(studentID))
            {
                MessageBox.Show("Please fill up all fields");
                return;
            }

            Debug.WriteLine("Member Student ID: " + member.StudentID);
            try
            {
                member.FirstName = firstName;
                member.LastName = lastName;
                member.StudentID = studentID;
                member.DateAdded = DateTime.UtcNow;

                if (isComplete)
                {
                    (f1, f2) = enroll.GetFingerprintData();
                    member.FingerprintData = new List<string> { f1, f2 };
                    member.BiometricsAdded = true;
                }

                await memberservice.UpdateMember(member);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error updating member." + ex);
            }

            MemberEdited?.Invoke(this.member);
            this.Close();
        }

        private void WithFingerprint()
        {
            isComplete = true;
        }

        private void OnClose(object sender, EventArgs e)
        {
            LastName_gunaTextBox.Text = "";
            FirstName_gunaTextBox.Text = "";
            StudentID_gunaTextBox.Text = "";
            YearLevel_gunaComboBox.Text = "";
            Status_gunaComboBox.Text = "";
            CloseForm?.Invoke();

            if (null != timer1)
            {
                Debug.WriteLine("Stopping timer...");
                timer1.Stop();
                timer1.Dispose();
                timer1 = null;
            }
            attempted = false;
            capturing = false;
        }

        private void OnOpen(object sender, EventArgs e)
        {
            LastName_gunaTextBox.Text = member.LastName;
            FirstName_gunaTextBox.Text = member.FirstName;
            StudentID_gunaTextBox.Text = member.StudentID;
            YearLevel_gunaComboBox.Text = member.YearLevel;
            Status_gunaComboBox.Text = member.Status;
            StudentID_gunaTextBox.Enabled = false;
        }

        private void Status_gunaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.member.Status = Status_gunaComboBox.Text;
        }

        private void YearLevel_gunaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.member.YearLevel = YearLevel_gunaComboBox.Text;
        }

        private void CheckConnectedReaders()
        {
            try
            {
                readers = new DPFP.Capture.ReadersCollection();
                bool isCurrentlyConnected = readers.Count > 0;

                if (isCurrentlyConnected != previousConnectionState)
                {
                    IsConnected = isCurrentlyConnected;
                    previousConnectionState = isCurrentlyConnected;

                    UpdateConnectedDevice(isCurrentlyConnected ?
                        "Fingerprint Scanner Connected." :
                        "No device connected.");

                }
            }
            catch (Exception ex)
            {
                UpdateConnectedDevice($"Error in CheckConnectedReaders(): {ex.Message}");
            }
        }

        private void UpdateConnectedDevice(string message)
        {
            if (Status.InvokeRequired)
            {
                Status.Invoke(new Action(() => Status.Text = message));
            }
            else
            {
                Status.Text = message;
            }
        }


        private void UpdateStatus(string message)
        {
            if (Notification.InvokeRequired)
            {
                Notification.Invoke(new Action(() => Notification.Text = message));
            }
            else
            {
                Notification.Text = message;
            }
        }

        private void InitializeTimers()
        {
            timer1.Interval = 500;
            timer1.Tick -= Timer1_Tick; 
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        private void InitializeTimers2()
        {
            timer2.Interval = 500;
            timer2.Tick -= timer2_Tick;
            timer2.Tick += timer2_Tick;
            timer2.Start();
        }

        private void StartCapture()
        {
            try
            {
                if (capturing && !IsConnected)
                {
                    StopCapture();
                }
                else if (!capturing && IsConnected)
                {
                    StartCaptureProcess();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during StartCapture: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StopCapture()
        {
            Console.WriteLine("Stopping capture...");
            enroll.StopCapture();
            capturing = false;
        }

        private void StartCaptureProcess()
        {
            Console.WriteLine("Starting capture...");
            enroll.StartCapture();
            capturing = true;
        }

        private void onAddBiometrics(object sender, EventArgs e)
        {
            if (!attempted)
            {
                if (this.member.BiometricsAdded)
                {
                    DialogResult result = MessageBox.Show(
                        "Biometrics already added. Do you want to replace the existing fingerprint?",
                        "Fingerprint Data Found!",
                        MessageBoxButtons.YesNo
                    );

                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                attempted = true;
            }

            if(IsConnected)
            {
                StartCapture();
                MessageBox.Show("Scanning Started. Please do not remove the device during enrollment.");
            }
            else
            {
                MessageBox.Show("Scanning cannot be started. Please connect a fingerprint reader.");
            }
                
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Task.Run(() => CheckConnectedReaders());
        }
    }
}