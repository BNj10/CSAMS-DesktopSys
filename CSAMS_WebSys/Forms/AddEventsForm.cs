using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSAMS_WebSys.Services;
using CSAMS_WebSys.Models;
using CSAMS_WebSys.Models.enums;
using System.Web.UI.WebControls;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;

namespace CSAMS_WebSys.Forms
{
    public partial class AddEventsForm : Form
    {
        public event Action<EventModel> EventAdded;
        private static Mutex _mutex = new Mutex(false, "MyUniqueMutexName");
        private string AMorPM;
        private MemberService memberService;
        private SchoolYearServices SchoolYearService;
        private SchoolYearModel SY;
        public AddEventsForm()
        {
            InitializeComponent();
            SchoolYearService = new SchoolYearServices();
            SY = new SchoolYearModel();
            GetLatestSchoolYear();
            if (!_mutex.WaitOne(0, false))
            {
                this.Show();
                this.BringToFront();
                return;
            }

            this.FormClosing += (sender, e) => { _mutex.ReleaseMutex(); };
        }
        private void TimeFrom_gunaTextBox_Leave(object sender, EventArgs e)
        {
            if (TimeFrom_gunaTextBox.Text == "")
            {
                TimeFrom_gunaTextBox.Text = "hh/mm";
                TimeFrom_gunaTextBox.ForeColor = Color.Silver;
            }
        }

        private void TimeFrom_gunaTextBox_Enter(object sender, EventArgs e)
        {
            if (TimeFrom_gunaTextBox.Text == "hh/mm")
            {
                TimeFrom_gunaTextBox.Text = "";
                TimeFrom_gunaTextBox.ForeColor = Color.Black;
            }
        }

        private void TimeTo_gunaTextBox_Enter(object sender, EventArgs e)
        {
            if (TimeTo_gunaTextBox.Text == "hh/mm")
            {
                TimeTo_gunaTextBox.Text = "";
                TimeTo_gunaTextBox.ForeColor = Color.Black;
            }
        }

        private void TimeTo_gunaTextBox_Leave(object sender, EventArgs e)
        {
            if (TimeTo_gunaTextBox.Text == "")
            {
                TimeTo_gunaTextBox.Text = "hh/mm";
                TimeTo_gunaTextBox.ForeColor = Color.Silver;
            }
        }

        private async void GetLatestSchoolYear()
        {
            this.SY = await SchoolYearService.GetActiveSchoolYearAsync();
        }

        private async void AddMember_gunaAdvenceButton_Click(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            string eventName = EventName_gunaTextBox.Text;
            var dateTime = guna2DateTimePicker1.Value;

            if (string.IsNullOrWhiteSpace(eventName))
            {
                MessageBox.Show("Please enter an event name.");
                return;
            }

            string placeholder = "hh/mm";

            try
            {
                EventModel eventModel = new EventModel
                {
                    EventName = eventName,
                    DateStart = dateTime.ToUniversalTime(),
                    EventDescription = "",
                    DateAdded = DateTime.UtcNow
                };

                AttendanceModel attendanceModel = new AttendanceModel
                {
                    EventName = eventName,
                    DateStart = dateTime.ToUniversalTime(),
                    SchoolYearID = SY.SchoolYearID,
                    TotalAttendees = 0
                };

                bool isTimeInProcessed = false;
                bool isTimeOutProcessed = false;

                if (guna2CheckBox1.Checked)
                {
                    string timeIn = GetValidInput(TimeInStart, placeholder);
                    string timeInEnd = GetValidInput(TimeInEnd, placeholder);
                    string timeInS = TimeIn1.Text;
                    string timeInE = TimeIn2.Text;

                    if (timeIn == null || timeInEnd == null | timeInS == null || timeInE == null)
                    {
                        MessageBox.Show("Please enter valid Time In values. Check again");
                        return;
                    }

                    DateTime? timeInStartParsed = CombineDateTime(dateTime, $"{timeIn} {timeInS}");
                    DateTime? timeInEndParsed = CombineDateTime(dateTime, $"{timeInEnd} {timeInE}");
                    
                    if (timeInStartParsed.HasValue && timeInEndParsed.HasValue)
                    {
                        attendanceModel.TimeInStart = timeInStartParsed.Value.ToUniversalTime();
                        attendanceModel.TimeInEnd = timeInEndParsed.Value.ToUniversalTime();
                        isTimeInProcessed = true;
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid Time In values.");
                        return;
                    }
                }

                if (guna2CheckBox2.Checked)
                {
                    string timeOut = GetValidInput(TimeOutStart, placeholder);
                    string timeOutEnd = GetValidInput(TimeOutEnd, placeholder);
                    string timeOutS = TimeOut1.Text;
                    string timeOutE = TimeOut2.Text;

                    DateTime? timeOutStartParsed = CombineDateTime(dateTime, $"{timeOut} {timeOutS}");
                    DateTime? timeOutEndParsed = CombineDateTime(dateTime, $"{timeOutEnd} {timeOutE}");

                    if (timeOutStartParsed.HasValue && timeOutEndParsed.HasValue)
                    {
                        attendanceModel.TimeOutStart = timeOutStartParsed.Value.ToUniversalTime();
                        attendanceModel.TimeOutEnd = timeOutEndParsed.Value.ToUniversalTime();
                        isTimeOutProcessed = true;
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid Time Out values.");
                        return;
                    }
                }

                if (!isTimeInProcessed && !isTimeOutProcessed)
                {
                    MessageBox.Show("Please select at least one time range.");
                    return;
                }

                string timeFrom = GetValidInput(TimeFrom_gunaTextBox, placeholder);
                string timeTo = GetValidInput(TimeTo_gunaTextBox, placeholder);
                string AM = ttFrom_gunaComboBox.Text;
                string PM = ttTo_gunaComboBox.Text;

                DateTime? startTimeParsed = CombineDateTime(dateTime, $"{timeFrom} {AM}");
                DateTime? endTimeParsed = CombineDateTime(dateTime, $"{timeTo} {PM}");

                if (startTimeParsed.HasValue && endTimeParsed.HasValue)
                {
                    eventModel.DateStart = startTimeParsed.Value.ToUniversalTime();
                    eventModel.DateEnd = endTimeParsed.Value.ToUniversalTime();
                }
                else
                {
                    MessageBox.Show("Please enter valid event start and end times.");
                    return;
                }

                PresentModel present = new PresentModel();
                await eventService.SaveEvent(eventModel, attendanceModel, present);
                EventAdded?.Invoke(eventModel);

                MessageBox.Show("Event successfully added.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private string GetValidInput(GunaTextBox textBox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text) || textBox.Text == placeholder)
            {
                return null; 
            }
            return textBox.Text;
        }

        private DateTime? CombineDateTime(DateTime baseDate, string timeString)
        {
            DateTime parsedTime;
            if (DateTime.TryParseExact(timeString, "h:mm tt", null, System.Globalization.DateTimeStyles.None, out parsedTime))
            {
                return new DateTime(baseDate.Year, baseDate.Month, baseDate.Day, parsedTime.Hour, parsedTime.Minute, 0);
            }
            return null;
        }

        private void onLoad(object sender, EventArgs e)
        {

        }

        private void time_tick(object sender, EventArgs e)
        {
           
        }

        private void onClose(object sender, EventArgs e)
        {

        }

        private void onClick(object sender, EventArgs e)
        {

        }

        private void onClickTimeIn(object sender, EventArgs e)
        {

            if (TimeFrom_gunaTextBox.Text == "hh/mm")
            {
                TimeFrom_gunaTextBox.Text = "";
                TimeFrom_gunaTextBox.ForeColor = Color.Black;
            }
        }

        private void onClickTimeInEnd(object sender, EventArgs e)
        {
            if (TimeInEnd.Text == "hh/mm")
            {
                TimeInEnd.Text = "";
                TimeInEnd.ForeColor = Color.Black;
            }
        }

        private void onClickTimeOutStart(object sender, EventArgs e)
        {

        }

        private void onClickTimeOutEnd(object sender, EventArgs e)
        {
            if (TimeFrom_gunaTextBox.Text == "hh/mm")
            {
                TimeOutEnd.Text = "";
                TimeOutEnd.ForeColor = Color.Black;
            }
        }

        private void onLeaveTimeInStart(object sender, EventArgs e)
        {
            if (TimeInStart.Text == "")
            {
                TimeInStart.Text = "hh/mm";
                TimeInStart.ForeColor = Color.Silver;
            }
        }

        private void onLeaveTimeInEnd(object sender, EventArgs e)
        {
            if (TimeInEnd.Text == "")
            {
                TimeInEnd.Text = "hh/mm";
                TimeInEnd.ForeColor = Color.Silver;
            }
        }

        private void onLeaveTimeOutStart(object sender, EventArgs e)
        {
            if (TimeOutStart.Text == "")
            {
                TimeOutStart.Text = "hh/mm";
                TimeOutStart.ForeColor = Color.Silver;
            }
        }

        private void onLeaveTimeOutEnd(object sender, EventArgs e)
        {
            if (TimeOutEnd.Text == "")
            {
                TimeOutEnd.Text = "hh/mm";
                TimeOutEnd.ForeColor = Color.Silver;
            }
        }

        private void onEnterTimeInStart(object sender, EventArgs e)
        {
            if (TimeInStart.Text == "hh/mm")
            {
                TimeInStart.Text = "";
                TimeInStart.ForeColor = Color.Black;
            }
        }

        private void OnEnterTimeInEND(object sender, EventArgs e)
        {
            if (TimeInEnd.Text == "hh/mm")
            {
                TimeInEnd.Text = "";
                TimeInEnd.ForeColor = Color.Black;
            }
        }

        private void onEnterTimeOutStart(object sender, EventArgs e)
        {
            if (TimeOutStart.Text == "hh/mm")
            {
                TimeOutStart.Text = "";
                TimeOutStart.ForeColor = Color.Black;
            }
        }

        private void onEnterTimeOutEnd(object sender, EventArgs e)
        {
            if (TimeOutEnd.Text == "hh/mm")
            {
                TimeOutEnd.Text = "";
                TimeOutEnd.ForeColor = Color.Black;
            }
        }

    }
}
