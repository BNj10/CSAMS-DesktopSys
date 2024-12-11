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

namespace CSAMS_WebSys.Forms
{
    public partial class EditEventsForm : Form
    {
        EventModel Event;
        EventService eventservice;
        public event Action<EventModel> EventChanged;
        public EditEventsForm(EventModel Event)
        {
            this.Event = Event;
            eventservice = new EventService();
            InitializeComponent();
        }

        private void EditEvent_gunaAdvenceButton_Click(object sender, EventArgs e)
        {

            this.Close();
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
    }
}
