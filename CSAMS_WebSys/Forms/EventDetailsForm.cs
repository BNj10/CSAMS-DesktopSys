using CSAMS_WebSys.Models;
using CSAMS_WebSys.Models.enums;
using CSAMS_WebSys.Services;
using CSAMS_WebSys.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CSAMS_WebSys.Forms
{
    public partial class EventDetailsForm : Form
    {
        private EventModel Event;
        private EventService eventservice;
        private AttendanceService attendance;
        private AttendanceModel objAttendance;
        public EventDetailsForm(EventModel Event)
        {
            InitializeComponent();
            scanEventDetails1.BringToFront();
            this.Event = Event;
            attendance = new AttendanceService();
            LoadData();
            SetLabels();
        }
        private void SetLabels()
        {
            eventName_gunaLabel.Text = this.Event.EventName;
        }

        public async void LoadData()
        {
            try
            {
                EventModel Event = this.Event;
                if (Event == null)
                {
                    Console.WriteLine("Event is null");
                }
                if (objAttendance == null && Event != null)
                {
                    this.objAttendance = await attendance.GetAttendanceForAnEvent(Event);
                    Console.WriteLine("ObjAttendance was retrieved");
                    InitScanDetails();
                }
                else
                {

                    Console.WriteLine("ObjAttendance IS not NULL");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void InitScanDetails()
        {
            scanEventDetails1.GetEventAndAttendanceDetailsFromForm(Event, objAttendance);
            scanEventDetails1.UpdateTimeLabels();
        }
        private void scan_gunaAdvenceButton_Click(object sender, EventArgs e)
        {
            scanEventDetails1.BringToFront();
            if(objAttendance == null)
            {
                Console.WriteLine("objAttendance was null");
                return;
            }
            scanEventDetails1.GetEventAndAttendanceDetailsFromForm(Event, objAttendance);
            scanEventDetails1.UpdateTimeLabels();
        }

        private void absences_gunaAdvenceButton_Click(object sender, EventArgs e)
        {
            absencesEventDetails1.BringToFront();
            absencesEventDetails1.GetEventAndAbsencesDetailsFromForm(Event, objAttendance);
        }
        private void onload(object sender, EventArgs e)
        {

        }
    }
}
