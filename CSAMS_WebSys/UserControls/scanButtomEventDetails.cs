using CSAMS_WebSys.Forms;
using CSAMS_WebSys.Models.enums;
using CSAMS_WebSys.Models;
using CSAMS_WebSys.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace CSAMS_WebSys.UserControls
{
    public partial class scanButtomEventDetails : UserControl
    {
        private FingerprintVerificationService verifier;
        private static List<MemberModel> members;
        private EventModel Event;
        private AttendanceModel attendance;
        private AttendanceService attendanceservice;
        private PopUpVerify popUp;
        private static int Count = 0;
        private HashSet<string> DisplayedMember;
        DataTable table = new DataTable();
        DataView view;
        private BindingSource _bindingSource = new BindingSource();
        private bool isLoaded = false;

        public scanButtomEventDetails()
        {
            InitializeComponent();
            Console.WriteLine("scanButtomEventDetails is initialized");
            verifier = new FingerprintVerificationService();
            DisplayedMember = new HashSet<string>();
            attendanceservice = new AttendanceService();
            this.Event = new EventModel();
            this.attendance = new AttendanceModel();
            InitializeTable();
            /*          verifier.MemberVerified += LoadData;*/
            verifier.UpdateAttendees += UpdateAttendees;
            verifier.Confirmation += ShowPopUp;
            /*            timer1.Interval = 2000;
                        timer1.Start();
                        timer1.Tick += timer1_Tick;
                        timer1.Tick -= timer1_Tick;
            */
            //UpdateTimeLabels();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ttAdded_gunaLabel.Text = DateTime.Now.ToString("hh:mm");
            //timeAdded_gunaLabel.Text = DateTime.Now.ToString("tt");
            
        }

        private void InitializeTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("year", typeof(int));
            table.Columns.Add("status", typeof(string));
            table.Columns.Add("date added", typeof(string));

            AtendeesData_gunaDataGridView.DataSource = table;

            DataGridViewButtonColumn dataGridViewButtonColumn_detials = new DataGridViewButtonColumn();
            dataGridViewButtonColumn_detials.Name = "Detail_button";
            dataGridViewButtonColumn_detials.HeaderText = "detail";

            dataGridViewButtonColumn_detials.FlatStyle = FlatStyle.Popup;

            dataGridViewButtonColumn_detials.Text = " Details";

            dataGridViewButtonColumn_detials.UseColumnTextForButtonValue = true;

            AtendeesData_gunaDataGridView.Columns.Add(dataGridViewButtonColumn_detials);

            AtendeesData_gunaDataGridView.Columns[0].Width = 90;
            AtendeesData_gunaDataGridView.Columns[3].Width = 80;
            AtendeesData_gunaDataGridView.Columns[4].Width = 80;
            AtendeesData_gunaDataGridView.Columns[6].Width = 120;

            AtendeesData_gunaDataGridView.AllowUserToResizeRows = false;
            AtendeesData_gunaDataGridView.AllowUserToResizeColumns = false;
            AtendeesData_gunaDataGridView.AllowUserToAddRows = false;

            AtendeesData_gunaDataGridView.ReadOnly = true;

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

        private void ClosePopUp(PopUpVerify confirm)
        {
            if (this.Controls.Contains(confirm))
            {
                this.Controls.Remove(confirm);
                confirm.Dispose();
            }
        }

        private DateTime GetCurrentTime()
        {
            DateTime time = DateTime.Now;
            return time;
        }

        private bool IsWithinTimeRange(DateTime currentTime, DateTime startTime, DateTime endTime)
        {
            return currentTime >= startTime && currentTime <= endTime;
        }

        private void AddMembers(List<MemberModel> members)
        {
            foreach (var member in members)
            {
                if (member != null && DisplayedMember.Add(member.StudentID))
                {
                    table.Rows.Add(member.StudentID, member.FirstName, member.LastName, member.YearLevel, member.TimeIn, member.TimeOut);
                }
            }
        }
        private async void AddMember(MemberModel member)
        {
            DateTime time = GetCurrentTime();
            try
            {
                if (member != null && DisplayedMember.Add(member.StudentID))
                {
                    Console.WriteLine($"Current time: {time}");
                    Console.WriteLine($"TimeInStart: {attendance.TimeInStart}, TimeInEnd: {attendance.TimeInEnd}");
                    Console.WriteLine($"TimeOutStart: {attendance.TimeOutStart}, TimeOutEnd: {attendance.TimeOutEnd}");
                    Console.WriteLine($"TimeOutStart: {attendance.TimeOutStart}, TimeOutEnd: {attendance.TimeOutEnd}");

                    if (attendance.TimeInStart.HasValue && attendance.TimeInEnd.HasValue &&
                        IsWithinTimeRange(time, attendance.TimeInStart.Value, attendance.TimeInEnd.Value))
                    {

                        await attendanceservice.StoreMemberPresentTimeIn(member, attendance, time);
                        table.Rows.Add(member.StudentID, member.FirstName, member.YearLevel, time.ToLocalTime(), "");
                        Count++;
                        UpdateAttendees();
                    }
                    else if (attendance.TimeOutStart.HasValue && attendance.TimeOutEnd.HasValue &&
                             IsWithinTimeRange(time, attendance.TimeOutStart.Value, attendance.TimeOutEnd.Value))
                    {
                        await attendanceservice.StoreMemberPresentTimeOut(member, attendance, time);
                        table.Rows.Add(member.StudentID, member.FirstName, member.LastName, member.YearLevel, "", time.ToLocalTime());
                        Count++;
                        UpdateAttendees();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding member: " + ex.Message);
            }
        }
        
        public void GetEventAndAttendanceDetailsFromForm(EventModel Event, AttendanceModel attendance)
        {
            this.Event = Event;
            this.attendance = attendance;
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

        private void UpdateAttendees()
        {
            if (numOfAtendees_value.InvokeRequired)
            {
                numOfAtendees_value.Invoke(new Action(() =>
                {
                    numOfAtendees_value.Text = Count.ToString();
                }));
            }
            else
            {
                numOfAtendees_value.Text = Count.ToString();
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

            if (ttAdded_gunaLabel.InvokeRequired && label1.InvokeRequired)
            {
                ttAdded_gunaLabel.Invoke(new Action(() =>
                {
                    ttAdded_gunaLabel.Text = $"{timeInStart} - {timeInEnd}";
                }));
                label1.Invoke(new Action(() =>
                {
                    label1.Text = attendance.TimeOutStart.HasValue
                ? attendance.TimeOutStart.Value.ToString("hh:mm tt")
                : "Not set";
                }));
            }
            else
            {
                ttAdded_gunaLabel.Text = attendance.TimeInStart.HasValue
          ? attendance.TimeInStart.Value.ToString("hh:mm tt") : "Not set";
                label1.Text = attendance.TimeOutStart.HasValue
                ? attendance.TimeOutStart.Value.ToString("hh:mm tt")
                : "Not set";
            }
        }



        private void AtendeesData_gunaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == AtendeesData_gunaDataGridView.Columns["Detail_button"].Index) 
                {
                    
                }
            }
            catch
            {
            }
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            Console.WriteLine("Current time: " + time);
            if (this.Event.Status.ToString() == "Pending")
            {
                MessageBox.Show("Event is still pending. Please wait for the event to start.", "Event is still pending", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (this.Event.Status.ToString() == "Done")
            {
                MessageBox.Show("Event has already ended. Click for the event that is ongoing", "Event done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!IsWithinTimeRange(time, attendance.TimeInStart.Value, attendance.TimeInEnd.Value) && !IsWithinTimeRange(time, attendance.TimeOutStart.Value, attendance.TimeOutEnd.Value))
            {
                MessageBox.Show($"Attendance Checking is unavailable right now. Time out will be available exactly at {attendance.TimeOutStart.Value.ToString("hh:mm tt")} ", "Time in ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            scanButton.Enabled = false;
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
                    scanButton.Enabled = true;
                };
            }
            catch
            {
                Console.WriteLine("Error occured");
            }

        }
    }
}
