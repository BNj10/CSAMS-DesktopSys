using CSAMS_WebSys.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSAMS_WebSys.Models;
using CSAMS_WebSys.Services;
using Google.Cloud.Firestore;
using System.Threading;
using CSAMS_WebSys.Models.enums;
using System.Windows.Forms.VisualStyles;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using DocumentFormat.OpenXml.Spreadsheet;

namespace CSAMS_WebSys.UserControls
{
    public partial class ScanEventDetails : UserControl
    {
        private FingerprintVerificationService verifier;
        private static List<MemberModel> members;
        private EventModel Event;
        private AttendanceModel attendance;
        private AttendanceService attendanceservice;
        private PopUpVerify popUp;
        private static int Count = 0;
        private Dictionary<string, (bool TimeInProcessed, bool TimeOutProcessed)> DisplayedMember;
        DataTable table = new DataTable();
        DataView view;
        private BindingSource _bindingSource = new BindingSource();
        private bool isLoaded = false;
        public ScanEventDetails()
        {
            InitializeComponent();
            Console.WriteLine("ScanEventDetails Initialized");
            members = new List<MemberModel>();
            verifier = new FingerprintVerificationService();
            DisplayedMember = new Dictionary<string, (bool, bool)>();
            attendanceservice = new AttendanceService();
            InitializeTable();
            verifier.UpdateAttendees += UpdateAttendees;
            verifier.Confirmation += ShowPopUp;
        }

        private void InitializeTable()
        {
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("year", typeof(string));
            table.Columns.Add("status", typeof(string));
            table.Columns.Add("date added", typeof(string));
            table.Columns.Add("Time In", typeof(string));
            table.Columns.Add("Time Out", typeof(string));

            ScannedAtendeesData_gunaDataGridView.DataSource = table;

            ScannedAtendeesData_gunaDataGridView.RowTemplate.Height = 50;
            ScannedAtendeesData_gunaDataGridView.Columns[0].Width = 120; 
            ScannedAtendeesData_gunaDataGridView.Columns[1].Width = 100; 
            ScannedAtendeesData_gunaDataGridView.Columns[2].Width = 100; 
            ScannedAtendeesData_gunaDataGridView.Columns[3].Width = 80;  
            ScannedAtendeesData_gunaDataGridView.Columns[4].Width = 80;  
            ScannedAtendeesData_gunaDataGridView.Columns[5].Width = 80;  

            ScannedAtendeesData_gunaDataGridView.AllowUserToResizeRows = false;
            ScannedAtendeesData_gunaDataGridView.AllowUserToResizeColumns = false;
            ScannedAtendeesData_gunaDataGridView.AllowUserToAddRows = false;

            ScannedAtendeesData_gunaDataGridView.ReadOnly = true;

            view = table.DefaultView;
        }

        private void ShowPopUp(MemberModel member)
        {

            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ShowPopUp(member)));
                return;
            }

            string timeAction = isTimeIn(member) ? "Time In" : "Time Out";

            PopUpVerify confirm = new PopUpVerify();
            confirm.Location = new Point(300, 30);
            confirm.Size = new Size(400, 429);
            confirm.Visible = true;

            if (!this.Controls.Contains(confirm))
            {
                this.Controls.Add(confirm);
            }
            confirm.BringToFront();

            confirm.DisplayMemberDetails(member, timeAction);

            confirm.Confirmed += () =>
            {
                AddMember(member);
                UpdateAttendees();
                ClosePopUp(confirm);
            };

            confirm.Cancelled += () =>
            {
                ClosePopUp(confirm);
            };
        }

        private DateTime GetCurrentTime()
        {
            DateTime time = DateTime.Now;
            return time;
        }

        public void GetEventAndAttendanceDetailsFromForm(EventModel Event, AttendanceModel attendance)
        {
            this.Event = Event;
            this.attendance = attendance;
            LoadMemberPresent();
            GetNumberOfAttendees();
        }

        private void ClosePopUp(PopUpVerify confirm)
        {
            if (this.Controls.Contains(confirm))
            {
                this.Controls.Remove(confirm);
                confirm.Dispose();
            }
        }

        private bool isTimeIn(MemberModel member)
        {
            DateTime time = GetCurrentTime();
            if (attendance.TimeInStart.HasValue && attendance.TimeInEnd.HasValue &&
                        IsWithinTimeRange(time, attendance.TimeInStart.Value, attendance.TimeInEnd.Value))
            {
                member.TimeIn = time;
                return true;
            }
            else if (attendance.TimeOutStart.HasValue && attendance.TimeOutEnd.HasValue &&
                             IsWithinTimeRange(time, attendance.TimeOutStart.Value, attendance.TimeOutEnd.Value))
            {
                member.TimeOut = time;
                return false;
            }
            else
            {
                return false;
            }
        }
            private bool IsWithinTimeRange(DateTime currentTime, DateTime startTime, DateTime endTime)
            {
                return currentTime >= startTime && currentTime <= endTime;
            }

        private async void AddMember(MemberModel member)
        {
            DateTime currentTime = GetCurrentTime();

            try
            {
                if (member == null)
                    return;

                if (!DisplayedMember.ContainsKey(member.StudentID))
                {
                    DisplayedMember[member.StudentID] = (false, false);
                    table.Rows.Add(member.StudentID, member.FirstName, member.LastName, member.YearLevel,
                                   member.Status, " ", "No data", "No data");
                }

                var processedState = DisplayedMember[member.StudentID];
                bool timeInProcessed = processedState.TimeInProcessed;
                bool timeOutProcessed = processedState.TimeOutProcessed;

                DataRow memberRow = table.Rows
                    .Cast<DataRow>()
                    .FirstOrDefault(r => r[0].ToString() == member.StudentID);

                if (!processedState.TimeInProcessed && attendance.TimeInStart.HasValue && attendance.TimeInEnd.HasValue &&
                    IsWithinTimeRange(currentTime, attendance.TimeInStart.Value, attendance.TimeInEnd.Value))
                {
                    await attendanceservice.StoreMemberPresentTimeIn(member, attendance, currentTime);
                    memberRow["Time In"] = currentTime.ToLocalTime().ToString("hh:mm tt");
                    timeInProcessed = true;
                    Count++;
                }
                else if (timeInProcessed)
                {
                    MessageBox.Show("Member has already been processed for Time In.");
                }

                if (!processedState.TimeOutProcessed && attendance.TimeOutStart.HasValue && attendance.TimeOutEnd.HasValue &&
                    IsWithinTimeRange(currentTime, attendance.TimeOutStart.Value, attendance.TimeOutEnd.Value))
                {
                    await attendanceservice.StoreMemberPresentTimeOut(member, attendance, currentTime);
                    memberRow["Time Out"] = currentTime.ToLocalTime().ToString("hh:mm tt");
                    timeOutProcessed = true;
                    Count++;
                }
                else if (timeOutProcessed)
                {
                    MessageBox.Show("Member has already been processed for Time Out.");
                }

                DisplayedMember[member.StudentID] = (timeInProcessed, timeOutProcessed);

                if (!timeInProcessed && !timeOutProcessed)
                {
                    MessageBox.Show("Current time is not within any valid Time In or Time Out range, or the member has already been processed.");
                }

                if (timeInProcessed || timeOutProcessed)
                {
                    UpdateAttendees();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding member: " + ex.Message);
                MessageBox.Show("An error occurred while adding the member: " + ex.Message);
            }
        }



        private void AddMembers(List<MemberModel> members)
        {
            foreach (var member in members)
            {
                if (member == null) continue;

                if (!DisplayedMember.ContainsKey(member.StudentID))
                {
                    DisplayedMember.Add(member.StudentID, (member.TimeIn == null ? false : true , member.TimeOut == null ? false : true));

                    table.Rows.Add(
                        member.StudentID,
                        member.FirstName,
                        member.LastName,
                        member.YearLevel,
                        member.Status,
                        " ",
                        member.TimeIn?.ToLocalTime().ToString("hh:mm tt") ?? "No data",
                        member.TimeOut?.ToLocalTime().ToString("hh:mm tt") ?? "No data"
                    );
                }
            }
        }

        private async void GetNumberOfAttendees()
        {
            Count = await attendanceservice.GetTotalAttendees(attendance);
            UpdateAttendees();
        }

        private void UpdateAttendees()
        {
            if (guna2HtmlLabel3.InvokeRequired)
            {
                guna2HtmlLabel3.Invoke(new Action(() =>
                {
                    guna2HtmlLabel3.Text = Count.ToString();
                }));
            }
            else
            {
                guna2HtmlLabel3.Text = Count.ToString();
            }
        }
        public async void LoadMemberPresent()
        {
            try
            {
                members = await attendanceservice.CurrentlyPresent(attendance);
                if (members == null)
                {
                    return;
                }
                AddMembers(members);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading member student" + ex.Message);
            }
        }

        public void UpdateTimeLabels()
        {
            string timeInStart, timeInEnd, timeOutStart, timeOutEnd;
            timeInStart = attendance.TimeInStart.HasValue ? attendance.TimeInStart.Value.ToString("hh:mm tt") : "Not set";
            timeInEnd = attendance.TimeInStart.HasValue ? attendance.TimeInEnd.Value.ToString("hh:mm tt") : "Not set";
            timeOutStart = attendance.TimeOutStart.HasValue ? attendance.TimeOutStart.Value.ToString("hh:mm tt") : "Not set";
            timeOutEnd = attendance.TimeOutEnd.HasValue ? attendance.TimeOutEnd.Value.ToString("hh:mm tt") : "Not set";

            if (guna2HtmlLabel1.InvokeRequired && guna2HtmlLabel2.InvokeRequired)
            {
                guna2HtmlLabel1.Invoke(new Action(() =>
                {
                    guna2HtmlLabel1.Text = attendance.TimeInStart.HasValue ? $"{timeInStart} - {timeInEnd}" : "Not set";
                }));
                gunaLabel2.Invoke(new Action(() =>
                {
                    gunaLabel2.Text = attendance.TimeOutStart.HasValue
                ? $"{timeOutStart} - {timeOutEnd}"
                : "Not set";
                }));
            }
            else
            {
                guna2HtmlLabel1.Text = attendance.TimeInStart.HasValue
          ? $"{timeInStart} - {timeInEnd}" : "Not set";
                guna2HtmlLabel2.Text = attendance.TimeOutStart.HasValue
                ? $"{timeOutStart} - {timeOutEnd}" : "Not set";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadMemberPresent();
            timer1.Stop();
        }

        private void scanBiometrics_gunaAdvenceButton_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            try
            {
                if (this.Event.Status.ToString() == "Pending")
                {
                    MessageBox.Show("Event is still pending. Please wait for the event to start.", "Event is still pending", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (this.Event.Status.ToString() == "Archived")
                {
                    MessageBox.Show("This event is archived", "Event archived", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (this.Event.Status.ToString() == "Done")
                {
                    MessageBox.Show("Event has already ended. Click for the event that is ongoing", "Event done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if(guna2HtmlLabel1.Text == "Not set" && time < attendance.TimeOutStart.Value)
                {
                    MessageBox.Show($"Time out will be available exactly at {attendance.TimeOutStart.Value.ToString("hh: mm tt")}" , "Time in ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (guna2HtmlLabel2.Text == "Not set" && time > attendance.TimeInEnd.Value)
                {
                    MessageBox.Show($"Time out is not set", "Time out unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (!IsWithinTimeRange(time, attendance.TimeOutStart.Value, attendance.TimeOutEnd.Value) && attendance.TimeOutEnd.Value < time)
                {
                    MessageBox.Show($"Attendance Checking is unavailable right now. Time out has ended.", "Time out ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (!IsWithinTimeRange(time, attendance.TimeInStart.Value, attendance.TimeInEnd.Value) && time < attendance.TimeOutStart.Value)
                {
                    MessageBox.Show($"Attendance Checking is unavailable right now. Time out will be available exactly at {attendance.TimeOutStart.Value.ToString("hh:mm tt")} ", "Time in ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (!IsWithinTimeRange(time, attendance.TimeInStart.Value, attendance.TimeInEnd.Value) && attendance.TimeInStart.HasValue && attendance.TimeInEnd.HasValue && time < attendance.TimeInStart.Value)
                {
                    MessageBox.Show($"Attendance Checking is unavailable right now. Time in will be available exactly at {attendance.TimeInStart.Value.ToString("hh:mm tt")} ", "Time in not yet started", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            scanBiometrics_gunaAdvenceButton.Enabled = false;
            verifier.StartCapture();
            FingerPrintScan scan = new FingerPrintScan(verifier);
            scan.BringToFront();
            scan.Show();
            try
            {
                scan.FormClosed += (s, args) =>
                {
                    Console.WriteLine("Stopping Capture: ");
                    verifier.StopCapture();
                    scanBiometrics_gunaAdvenceButton.Enabled = true;
                };
            }
            catch
            {
                Console.WriteLine("Error occured");
            }
        }
    }
}
