using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using CSAMS_WebSys.Models;
using CSAMS_WebSys.Services;
using System.Diagnostics.Metrics;
using System.Drawing.Text;

namespace CSAMS_WebSys.Forms
{
    public partial class AddMemberForm : Form
    {
        private FingerprintEnrollService enroll; 
        private SchoolYearServices SchoolYearServices;
        private SchoolYearModel SYmodel;
        private static bool _isOpen = false;
        private bool IsConnected = false;
        private bool previousConnectionState = false;
        public event Action<MemberModel> MemberChanged;
        private DPFP.Capture.ReadersCollection readers;

        public AddMemberForm()
        {
            InitializeComponent();
            SchoolYearServices = new SchoolYearServices();
            SYmodel = new SchoolYearModel();
            GetActiveSY();
            if (_isOpen)
            {
                this.Show();
                this.BringToFront();
                return;
            }

            _isOpen = true;
            this.FormClosing += (sender, e) => { _isOpen = false; };

            enroll = new FingerprintEnrollService();
            enroll.LogInfo += UpdateStatus;
            timer1.Interval = 1000;
            timer1.Tick += (sender, args) => CheckConnectedReaders();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateAdded_gunaLabel.Text = DateTime.Now.ToString("MM/dd/yyyy");
            TimeAdded_gunaLabel.Text = DateTime.Now.ToString("hh:mm");
            ttAdded_gunaLabel.Text = DateTime.Now.ToString("tt");
        }

        private void AddMember_gunaAdvenceButton_Click(object sender, EventArgs e)
        {
            AddMember_gunaAdvenceButton.Enabled = false;
            guna2CheckBox1.Checked = false;
            try
            {
                if (IsConnected)
                    enroll.StartCapture();
                else
                {
                    enroll.StopCapture();
                    UpdateConnectedDevice("No device connected.");
                }   
            }
            catch
            {
                throw new Exception("Error occured during StartCapture");
            }
            finally
            {
                AddMember_gunaAdvenceButton.Enabled = true;
            }
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

        private void done_gunaAdvenceButton_Click(object sender, EventArgs e)
        {
            Close();
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
            if (label1.InvokeRequired)
            {
                label1.Invoke(new Action(() => label1.Text = message));
            }
            else
            {
                label1.Text = message;
            }
        }

        private async void GetActiveSY()
        {
            this.SYmodel = await SchoolYearServices.GetActiveSchoolYearAsync();
        }

        private async void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            AddMember_gunaAdvenceButton.Enabled = false;

            string studentID = StudentID_gunaTextBox.Text;
            string lastName = LastName_gunaTextBox.Text;
            string firstName = FirstName_gunaTextBox.Text;
            string yearLevel = YearLevel_gunaComboBox.Text;
            string status = Status_gunaComboBox.Text;
            string f1, f2;
            GetActiveSY();

            Console.WriteLine(SYmodel.SchoolYearID);

            if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(yearLevel) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            try
            {
                if (SYmodel.SchoolYearID == null)
                {
                    MessageBox.Show("No active school year found. Please create a school year to use the features.");
                    return;
                }

                if (guna2CheckBox1.Checked)
                {
                    SaveMemberWithoutFingerprint();
                }
                else
                {
                    (f1, f2) = enroll.GetFingerprintData();
                    if(string.IsNullOrEmpty(f1))
                    {
                        MessageBox.Show("You need to enroll two fingerprints");
                    }
                    if(string.IsNullOrEmpty(f1) || string.IsNullOrEmpty(f2))
                    {
                        MessageBox.Show("Please enroll fingerprint data.");
                        return;
                    }

                    MemberService service = new MemberService();
                    var memberData = new MemberModel
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        YearLevel = yearLevel,
                        Status = status,
                        StudentID = studentID,
                        FingerprintData = new List<string> { f1, f2 },
                        DateAdded = DateTime.UtcNow,
                        isArchived = false,
                        SchoolYearID = SYmodel.SchoolYearID,
                        BiometricsAdded = true
                    };
                    await service.SaveMemberToFirestore(memberData);
                    ResetFormFields();
                    MemberChanged?.Invoke(memberData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { 
                AddMember_gunaAdvenceButton.Enabled = true;
                enroll.StopCapture();
            }
        }
        private async void SaveMemberWithoutFingerprint()
            {
                try
                {
                    string studentID = StudentID_gunaTextBox.Text;
                    string lastName = LastName_gunaTextBox.Text;
                    string firstName = FirstName_gunaTextBox.Text;
                    string yearLevel = YearLevel_gunaComboBox.Text;
                    string status = Status_gunaComboBox.Text;

                    if (string.IsNullOrWhiteSpace(studentID) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(firstName))
                    {
                        MessageBox.Show("Please fill out all required fields.");
                        return;
                    }

                    MemberService service = new MemberService();
                var memberData = new MemberModel
                {
                    FirstName = firstName,
                    LastName = lastName,
                    YearLevel = yearLevel,
                    Status = status,
                    StudentID = studentID,
                    FingerprintData = new List<string>(),
                    DateAdded = DateTime.UtcNow,
                    isArchived = false,
                    SchoolYearID = SYmodel.SchoolYearID,
                    BiometricsAdded = false
                };
                    await service.SaveMemberToFirestore(memberData);
                    ResetFormFields();
                    MemberChanged?.Invoke(memberData);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Adding student failed! Please try again.\nError: {ex.Message}");
                }
            }
            public void ResetFormFields()
            {
                StudentID_gunaTextBox.Text = "";
                LastName_gunaTextBox.Text = "";
                FirstName_gunaTextBox.Text = "";
                YearLevel_gunaComboBox.SelectedIndex = -1;
                Status_gunaComboBox.SelectedIndex = -1;
                label1.Text = "No biometrics detected.";
            }

        private void AddMemberForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (null != timer1)
            {
                timer1.Stop();
                timer1.Dispose();
                timer1 = null;
            }
            enroll.StopCapture();
        }

        private void AddMemberForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
