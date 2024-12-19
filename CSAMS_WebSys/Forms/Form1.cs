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
using CSAMS_WebSys.UserControls;

namespace CSAMS_WebSys.Forms
{
    public partial class Form1 : Form
    {
        private EventModel Event;
        private EventService eventservice;
        private AttendanceService attendance;
        private AttendanceModel objAttendance;

        public Form1(EventModel Event)
        {
            this.Event = Event;
            attendance = new AttendanceService();

            InitializeComponent();
            /*          scanEventDetails1.BringToFront();
                        this.Event = Event;
                        attendance = new AttendanceService();

                        SetLabels();
                        ShowAndClickButton();*/
            LoadData();
            SetLabels();
            scanButtomEventDetails1.BringToFront();
        }

        private void SetLabels()
        {
            eventName.Text = this.Event.EventName;
        }

        public async void LoadData()
        {
            try
            {
                
                if (Event == null || Event.EventName == "")
                {
                    Console.WriteLine("Event is Null");
                    return;
                }
                else
                {
                    Console.WriteLine("Event is not Null" + Event.EventName);
                }

                if (Event == null)
                {
                    Console.WriteLine("Event is null");
                    return;
                }
                if (objAttendance == null && Event != null)
                {
                    this.objAttendance = await attendance.GetAttendanceForAnEvent(Event);
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

        public void GetEvent(EventModel Event)
        {
            this.Event = Event; 
        }
        private void AddEvents_gunaAdvenceButton_Click(object sender, EventArgs e)
        {
            scanButtomEventDetails1.BringToFront();
            scanButtomEventDetails1.GetEventAndAttendanceDetailsFromForm(Event, objAttendance);
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            absencesButtomEventDetails1.BringToFront();
        }
    }
}
