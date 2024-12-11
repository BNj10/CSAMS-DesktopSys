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

namespace CSAMS_WebSys.Forms
{
    public partial class AddEventsForm : Form
    {
        public event Action<EventModel> EventAdded;
        private static Mutex _mutex = new Mutex(false, "MyUniqueMutexName");
        private string AMorPM;
        private MemberService memberService;

        public AddEventsForm()
        {
            InitializeComponent();

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

        private async void AddMember_gunaAdvenceButton_Click(object sender, EventArgs e)
        {

            EventService eventService = new EventService();
            string eventName = EventName_gunaTextBox.Text;
            var dateTime = guna2DateTimePicker1.Value;
            string timePart1 = TimeFrom_gunaTextBox.Text;
            string timePart2 = TimeTo_gunaTextBox.Text; 
            string AM = ttFrom_gunaComboBox.Text; 
            string PM = ttTo_gunaComboBox.Text;

            string TimeIn = TimeInStart.Text;
            string TimeOut = TimeOutStart.Text;

            string TimeInend = TimeInEnd.Text;
            string TimeOutend = TimeOutEnd.Text;

            string TimeInS = TimeIn1.Text;
            string TimeInE = TimeIn2.Text;
            
            string TimeOutS = TimeOut1.Text;
            string TimeOutE = TimeOut2.Text;

            try
            {
                string fullTime1 = $"{timePart1} {AM}";
                string fullTime2 = $"{timePart2} {PM}";
                string FullTimeIn = $"{TimeIn} {TimeInS}";
                string FullTimeOut = $"{TimeOut} {TimeOutS}";

                string FullTimeInEnd = $"{TimeInend} {TimeInE}";
                string FullTimeOutEnd = $"{TimeOutend} {TimeOutE}";

                DateTime parsedTime3, parsedTime4, parsedTime5, parsedTime6;

                DateTime parsedTime1, parsedTime2;

                bool isTime1Parsed = DateTime.TryParseExact(fullTime1, "h:mm tt", null, System.Globalization.DateTimeStyles.None, out parsedTime1);
                bool isTime2Parsed = DateTime.TryParseExact(fullTime2, "h:mm tt", null, System.Globalization.DateTimeStyles.None, out parsedTime2);
                bool isTime3Parsed = DateTime.TryParseExact(FullTimeIn, "h:mm tt", null, System.Globalization.DateTimeStyles.None, out parsedTime3);
                bool isTime4Parsed = DateTime.TryParseExact(FullTimeOut, "h:mm tt", null, System.Globalization.DateTimeStyles.None, out parsedTime4);
                bool isTime5Parsed = DateTime.TryParseExact(FullTimeInEnd, "h:mm tt", null, System.Globalization.DateTimeStyles.None, out parsedTime5);
                bool isTime6Parsed = DateTime.TryParseExact(FullTimeOutEnd, "h:mm tt", null, System.Globalization.DateTimeStyles.None, out parsedTime6);

                if (isTime1Parsed && isTime2Parsed && isTime3Parsed && isTime4Parsed && isTime5Parsed && isTime6Parsed)
                {
                    DateTime updatedStartTime = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, parsedTime1.Hour, parsedTime1.Minute, parsedTime1.Second);
                    DateTime updatedEndTime = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, parsedTime2.Hour, parsedTime2.Minute, parsedTime2.Second);

                    EventModel Event = new EventModel
                    {
                        EventName = EventName_gunaTextBox.Text,
                        EventDescription = "",
                        DateAdded = DateTime.UtcNow,
                        DateStart = updatedStartTime.ToUniversalTime(),
                        DateEnd = updatedEndTime.ToUniversalTime(),
                    };

                    DateTime updatedStartTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, parsedTime3.Hour, parsedTime3.Minute, parsedTime3.Second);
                    DateTime updatedEndTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, parsedTime4.Hour, parsedTime4.Minute, parsedTime4.Second);

                    DateTime updatedTimeIn = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, parsedTime3.Hour, parsedTime3.Minute, parsedTime3.Second);
                    DateTime updatedTimeOut = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, parsedTime4.Hour, parsedTime4.Minute, parsedTime4.Second);

                    DateTime updatedTimeInEnd = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, parsedTime5.Hour, parsedTime5.Minute, parsedTime5.Second);
                    DateTime updatedTimeOutEnd = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, parsedTime6.Hour, parsedTime6.Minute, parsedTime6.Second);

                    AttendanceModel attenddance = new AttendanceModel
                    {
                        TotalAttendees = 0,
                        TimeInStart = updatedTimeIn.ToUniversalTime(),
                        TimeInEnd = updatedTimeInEnd.ToUniversalTime(),
                        TimeOutStart = updatedTimeOut.ToUniversalTime(),
                        TimeOutEnd = updatedTimeOutEnd.ToUniversalTime(),

                    };

                    PresentModel present = new PresentModel();
                    await eventService.SaveEvent(Event, attenddance, present);
                    EventAdded?.Invoke(Event);
                }
                else
                {
                    MessageBox.Show("Please enter a valid time.");
                    return;
                }
            }     
            catch (Exception ex)
            {
                MessageBox.Show("Please fill out all fields." + ex);
                return;
            }

            this.Close();
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
