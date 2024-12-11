using CSAMS_WebSys.Models;
using CSAMS_WebSys.Services;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSAMS_WebSys.UserControls
{
    public partial class ArchiveEvents : UserControl
    {
        private static DocumentSnapshot _firstDocumentSnapshot;
        private static DocumentSnapshot _lastDocumentSnapshot;
        EventService eventservice;
        private int pageSize = 10;
        private HashSet<string> DisplayedEvents = new HashSet<string>();
        private DataTable table = new DataTable();
        DataGridViewButtonColumn dataGridViewButtonColumn_detials = new DataGridViewButtonColumn();

        public ArchiveEvents()
        {
            InitializeComponent();
            InitializeTable();
            eventservice = new EventService();
            AppendCurrentData();
        }
        private void InitializeTable()
        {
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("DateTime", typeof(string));
            /*table.Columns.Add("Attendees", typeof(int));*/
            table.Columns.Add("Progress", typeof(string));

            ArchivedEventsData_gunaDataGridView.DataSource = table;

            dataGridViewButtonColumn_detials.Name = "Detail_button";
            dataGridViewButtonColumn_detials.HeaderText = "Action";

            dataGridViewButtonColumn_detials.FlatStyle = FlatStyle.Popup;
            dataGridViewButtonColumn_detials.Text = " Details";

            dataGridViewButtonColumn_detials.UseColumnTextForButtonValue = true;

            ArchivedEventsData_gunaDataGridView.Columns.Add(dataGridViewButtonColumn_detials);

            ArchivedEventsData_gunaDataGridView.Columns[0].Width = 500;
            ArchivedEventsData_gunaDataGridView.Columns[1].Width = 150;
            ArchivedEventsData_gunaDataGridView.Columns[2].Width = 80;
            ArchivedEventsData_gunaDataGridView.Columns[3].Width = 80;
            /*ArchivedEventsData_gunaDataGridView.Columns[4].Width = 80;*/

            ArchivedEventsData_gunaDataGridView.AllowUserToResizeRows = false;
            ArchivedEventsData_gunaDataGridView.AllowUserToResizeColumns = false;
            ArchivedEventsData_gunaDataGridView.AllowUserToAddRows = false;

            ArchivedEventsData_gunaDataGridView.ReadOnly = true;
        }

        public async void AppendCurrentData()
        {
            try
            {
                List<EventModel> events = new List<EventModel>();
                (events, _firstDocumentSnapshot) = await eventservice.GetArchivedEvents(pageSize, _lastDocumentSnapshot);

                if (events.Count > 0)
                {
                    Console.WriteLine("Fetched: " + events.Count);
                    AddEvents(events);
                    _lastDocumentSnapshot = _firstDocumentSnapshot;
                }
                else
                {
                    Console.WriteLine("No more data to fetch");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AppendCurrentData(): {ex.Message}");
            }
        }

        private void AddAttendees(EventModel Event)
        {

        }

        private void AddEvents(List<EventModel> events)
        {
            foreach (var Event in events)
            {
                if (Event != null && DisplayedEvents.Add(Event.EventName))
                {
                    table.Rows.Add(Event.EventName, Event.DateAdded?.ToString("MMMM dd, yyyy"), Event.Status.ToString());
                }
            }
        }

        private void DynamicSearch()
        {

        }
        
    }
}
