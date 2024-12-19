using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSAMS_WebSys.Services;
using CSAMS_WebSys.Models;
using System.Security.Policy;
using System.Threading;
using CSAMS_WebSys.Models.enums;
using Guna.UI.WinForms;

namespace CSAMS_WebSys.Forms
{
    public partial class EditEventsForm : Form
    {
        EventModel Event;
        EventService eventservice;
        AttendanceService attendance;
        public event Action<EventModel> EventChanged;
        public EditEventsForm(EventModel Event)
        {
            this.Event = Event;
            eventservice = new EventService();
            InitializeComponent();
        }

        private async void EditEvent_gunaAdvenceButton_Click(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            AttendanceService attendanceService = new AttendanceService();

            try
            {
                EventModel existingEvent = await eventService.GetEventByName(Event);
                AttendanceModel existingAttendance = await attendanceService.GetAttendanceForAnEvent(Event);

                if (existingEvent == null || existingAttendance == null)
                {
                    MessageBox.Show("The event or attendance record could not be found.");
                    return;
                }

                string eventName = string.IsNullOrWhiteSpace(EventName_gunaTextBox.Text)
                    ? existingEvent.EventName
                    : EventName_gunaTextBox.Text;

                DateTime? updatedStartDate = guna2DateTimePicker1.Value != null
                    ? (DateTime?)guna2DateTimePicker1.Value
                    : existingEvent.DateStart;

                DateTime? updatedStartTime = ParseTime(gunaTextBox2.Text, gunaComboBox2.Text);
                DateTime? updatedEndTime = ParseTime(gunaTextBox1.Text, gunaComboBox1.Text);

                if (updatedStartTime == null || updatedEndTime == null)
                {
                    MessageBox.Show("Please enter valid start and end times.");
                    return;
                }

                DateTime? newStartDateTime = CombineDateAndTime(updatedStartDate.Value, updatedStartTime.Value);
                DateTime? newEndDateTime = CombineDateAndTime(updatedStartDate.Value, updatedEndTime.Value);

                if(newStartDateTime == null || newEndDateTime == null)
                {
                    MessageBox.Show("Please enter valid start and end times.");
                    return;
                }


                if (newStartDateTime.HasValue && newEndDateTime.HasValue)
                {
                    existingEvent.DateStart = newStartDateTime.Value.ToUniversalTime();
                    existingEvent.DateEnd = newEndDateTime.Value.ToUniversalTime();
                    existingAttendance.DateStart = newStartDateTime.Value.ToUniversalTime();
                }

                existingEvent.EventName = eventName;
                existingAttendance.EventName = eventName;

                if (guna2CheckBox1.Checked)
                {
                    string timeInStart = GetValidInput(gunaTextBox5, "hh/mm");
                    string timeInEnd = GetValidInput(gunaTextBox3, "hh/mm");

                    DateTime? timeInStartParsed = ParseTime(gunaTextBox5.Text, gunaComboBox5.Text);
                    DateTime? timeInEndParsed = ParseTime(gunaTextBox3.Text, gunaComboBox3.Text);

                    if(timeInStartParsed == null || timeInEndParsed == null)
                    {
                        MessageBox.Show("Please enter valid time in start and end times.");
                        return;
                    }

                    DateTime? timeInStartCombined = CombineDateAndTime(updatedStartDate.Value, timeInStartParsed.Value);
                    DateTime? timeInEndCombined = CombineDateAndTime(updatedStartDate.Value, timeInEndParsed.Value);

                    if (timeInStartCombined.HasValue && timeInStartCombined.HasValue)
                    {
                        existingAttendance.TimeInStart = timeInStartCombined.Value.ToUniversalTime();
                        existingAttendance.TimeInEnd = timeInEndCombined.Value.ToUniversalTime();
                    }
                }

                if (guna2CheckBox2.Checked)
                {
                    string timeOutStart = GetValidInput(gunaTextBox4, "hh/mm");
                    string timeOutEnd = GetValidInput(gunaTextBox6, "hh/mm");

                    DateTime? timeOutStartParsed = ParseTime(gunaTextBox4.Text, gunaComboBox6.Text);
                    DateTime? timeOutEndParsed = ParseTime(gunaTextBox6.Text, gunaComboBox4.Text);

                    if(timeOutStartParsed == null || timeOutEndParsed == null)
                    {
                        MessageBox.Show("Please enter valid time out start and end times.");
                        return;
                    }

                    DateTime? timeOutStartCombined = CombineDateAndTime(updatedEndTime.Value, timeOutStartParsed.Value);
                    DateTime? timeOutEndCombined = CombineDateAndTime(updatedEndTime.Value, timeOutEndParsed.Value);

                    if (timeOutStartCombined.HasValue && timeOutStartCombined.HasValue)
                    {
                        existingAttendance.TimeOutStart = timeOutStartCombined.Value.ToUniversalTime();
                        existingAttendance.TimeOutEnd = timeOutEndCombined.Value.ToUniversalTime();
                    }
                }

                await eventService.EditEventDetails(existingEvent);
                await attendanceService.EditAttendance(existingAttendance);

                EventChanged?.Invoke(existingEvent);

                MessageBox.Show("Event updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private DateTime? ParseTime(string timeText, string periodText)
        {
            if (string.IsNullOrWhiteSpace(timeText) || string.IsNullOrWhiteSpace(periodText))
            {
                return null;
            }

            if (DateTime.TryParseExact(timeText + " " + periodText, "h:mm tt",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out DateTime parsedTime))
            {
                return parsedTime;
            }
            return null;
        }


        private string GetValidInput(GunaTextBox textBox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text) || textBox.Text == placeholder)
            {
                return null;
            }
            return textBox.Text;
        }

        private DateTime? CombineDateAndTime(DateTime? date, DateTime? time)
        {
            if (date.HasValue && time.HasValue)
            {
                return new DateTime(
                    date.Value.Year, date.Value.Month, date.Value.Day,
                    time.Value.Hour, time.Value.Minute, time.Value.Second
                );
            }
            return null; 
        }

        private async void archiveEvent_gunaAdvenceButton_Click(object sender, EventArgs e)
        {
            try
            {
                await eventservice.ArchiveEvents(Event);
                Event.Status = Models.enums.EventStatus.Archived;
                this.EventChanged?.Invoke(Event);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            this.Close();
        }

        private void TimeFromEnter(object sender, EventArgs e)
        {
            if (gunaTextBox2.Text == "hh/mm")
            {
                gunaTextBox2.Text = "";
                gunaTextBox2.ForeColor = Color.Black;
            }
        }

        private void TimeFromLeave(object sender, EventArgs e)
        {
            if (gunaTextBox2.Text == "")
            {
                gunaTextBox2.Text = "hh/mm";
                gunaTextBox2.ForeColor = Color.Silver;
            }
        }

        private void TimeTillEnter(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "hh/mm")
            {
                gunaTextBox1.Text = "";
                gunaTextBox1.ForeColor = Color.Black;
            }
        }

        private void TimeTillLeave(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "")
            {
                gunaTextBox1.Text = "hh/mm";
                gunaTextBox1.ForeColor = Color.Silver;
            }
        }

        private void TimeInEnter(object sender, EventArgs e)
        {
            if (gunaTextBox5.Text == "hh/mm")
            {
                gunaTextBox5.Text = "";
                gunaTextBox5.ForeColor = Color.Black;
            }
        }

        private void TimeInLeave(object sender, EventArgs e)
        {
            if (gunaTextBox5.Text == "")
            {
                gunaTextBox5.Text = "hh/mm";
                gunaTextBox5.ForeColor = Color.Silver;
            }
        }

        private void TimeOutLeave(object sender, EventArgs e)
        {
            if (gunaTextBox4.Text == "")
            {
                gunaTextBox4.Text = "hh/mm";
                gunaTextBox4.ForeColor = Color.Silver;
            }
        }

        private void TimeInEndEnter(object sender, EventArgs e)
        {
            if (gunaTextBox3.Text == "hh/mm")
            {
                gunaTextBox3.Text = "";
                gunaTextBox3.ForeColor = Color.Black;
            }

        }

        private void TimeInEndLeave(object sender, EventArgs e)
        {
            if (gunaTextBox3.Text == "")
            {
                gunaTextBox3.Text = "hh/mm";
                gunaTextBox3.ForeColor = Color.Silver;
            }
        }

        private void TimeOutEndEnter(object sender, EventArgs e)
        {
            if (gunaTextBox6.Text == "hh/mm")
            {
                gunaTextBox6.Text = "";
                gunaTextBox6.ForeColor = Color.Black;
            }
        }

        private void TimeOutEndLeave(object sender, EventArgs e)
        {
            if (gunaTextBox6.Text == "")
            {
                gunaTextBox6.Text = "hh/mm";
                gunaTextBox6.ForeColor = Color.Silver;
            }
        }

        private void TimeOutEnter(object sender, EventArgs e)
        {
            if (gunaTextBox4.Text == "hh/mm")
            {
                gunaTextBox4.Text = "";
                gunaTextBox4.ForeColor = Color.Black;
            }
        }
    }
}
