using CSAMS_WebSys.Forms;
using CSAMS_WebSys.Models;
using CSAMS_WebSys.Models.enums;
using CSAMS_WebSys.Services;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.Admin.V1;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CSAMS_WebSys.UserControls
{
    public partial class UserControl_Events : UserControl
    {
        private EventService EventService;
        private AttendanceModel attendance;
        private AttendanceService attendanceService;
        private int pageNumber = 10;
        private int numAttendees = 0;
        private static string lastDocumentId = null;
        private static DocumentSnapshot lastdoc;    
        private static DocumentSnapshot firstdoc;
        private HashSet<string> displayedEvents = new HashSet<string>();
        private DataTable table = new DataTable();
        private DataView view;

        public UserControl_Events()
        {
            InitializeComponent();
            EventService = new EventService();
            attendanceService = new AttendanceService();
            attendance = new AttendanceModel();
            InitializeTable();
            FetchData();
        }

        private void InitializeTable()
        {
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("DateTime", typeof(string));
            table.Columns.Add("Attendees", typeof(int));
            table.Columns.Add("Progress", typeof(string));

            EventsData_gunaDataGridView.DataSource = table;

            DataGridViewButtonColumn dataGridViewButtonColumn_edit = new DataGridViewButtonColumn();
            DataGridViewButtonColumn dataGridViewButtonColumn_detials = new DataGridViewButtonColumn();
            DataGridViewButtonColumn dataGridViewButtonColumn_delete = new DataGridViewButtonColumn();
            
            dataGridViewButtonColumn_detials.Name = "Detail_button";
            dataGridViewButtonColumn_detials.HeaderText = "";
            dataGridViewButtonColumn_delete.Name = "Delete_button";
            dataGridViewButtonColumn_delete.HeaderText = "";
            dataGridViewButtonColumn_edit.Name = "Edit_button";
            dataGridViewButtonColumn_edit.HeaderText = "Action";;

            dataGridViewButtonColumn_detials.FlatStyle = FlatStyle.Popup;
            dataGridViewButtonColumn_edit.FlatStyle = FlatStyle.Popup;
            dataGridViewButtonColumn_delete.FlatStyle = FlatStyle.Popup;
            dataGridViewButtonColumn_delete.Text = " Delete";
            dataGridViewButtonColumn_detials.Text = " Details";
            dataGridViewButtonColumn_edit.Text = " Edit";

            dataGridViewButtonColumn_detials.UseColumnTextForButtonValue = true;
            dataGridViewButtonColumn_edit.UseColumnTextForButtonValue = true;
            dataGridViewButtonColumn_delete.UseColumnTextForButtonValue = true;

            EventsData_gunaDataGridView.Columns.Add(dataGridViewButtonColumn_edit);
            EventsData_gunaDataGridView.Columns.Add(dataGridViewButtonColumn_delete);
            EventsData_gunaDataGridView.Columns.Add(dataGridViewButtonColumn_detials);

            EventsData_gunaDataGridView.RowTemplate.Height = 50;

            EventsData_gunaDataGridView.Columns[0].Width = 500;
            EventsData_gunaDataGridView.Columns[1].Width = 150;
            EventsData_gunaDataGridView.Columns[2].Width = 80;
            EventsData_gunaDataGridView.Columns[3].Width = 80;
            EventsData_gunaDataGridView.Columns[4].Width = 80;
            EventsData_gunaDataGridView.Columns[5].Width = 80;
           EventsData_gunaDataGridView.Columns[6].Width = 80;

            EventsData_gunaDataGridView.AllowUserToResizeRows = false;
            EventsData_gunaDataGridView.AllowUserToResizeColumns = false;
            EventsData_gunaDataGridView.AllowUserToAddRows = false;

            EventsData_gunaDataGridView.ReadOnly = true;
            view = table.DefaultView;
        }

        private void AddEvents_gunaAdvenceButton_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "AddEventsForm")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isOpen == false)
            {
                AddEventsForm addbookn = new AddEventsForm();
                addbookn.Show();
                addbookn.EventAdded += AddEvent;
            }
        }


        private async void AddEvent(EventModel Event)
        {
            Console.WriteLine(Event.EventName + " " + Event.Status.ToString());
            Event.Status = EventService.GetCurrentStatus(Event);
            if (Event != null && displayedEvents.Add(Event.EventName))
            {
                numAttendees = await GetAttendees(Event);
                table.Rows.Add(Event.EventName, Event.DateStart?.ToString("MMMM dd, yyyy"), numAttendees,  Event.Status.ToString());
            }
        }

        private async void AddEvents(List<EventModel> Events)
        {
            foreach (var Event in Events)
            {
                Console.WriteLine(Event.EventName + " " + Event.Status.ToString());
                if (Event != null && displayedEvents.Add(Event.EventName))
                {
                    numAttendees = await GetAttendees(Event);
                    table.Rows.Add(Event.EventName, Event.DateStart?.ToString("MMMM dd, yyyy"), numAttendees, Event.Status.ToString());
                }
            }
        }

        private async Task<int> GetAttendees(EventModel Event)
        {
            try
            {
                attendance = await attendanceService.GetAttendanceForAnEventUsingName(Event);
                Console.WriteLine("Number of Attendees: ", attendance.TotalAttendees);
                return attendance.TotalAttendees;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error in GetAttendees: " + ex.Message);
                return 0;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void EventsData_gunaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == EventsData_gunaDataGridView.Columns["Detail_button"].Index)
                {
                    int rowIndex1 = e.RowIndex;
                    if (rowIndex1 >= 0)
                    {
                        DataGridViewRow selectedRow = EventsData_gunaDataGridView.Rows[rowIndex1];

                        string eventName = selectedRow.Cells["Name"].Value.ToString();
                        string eventStart = selectedRow.Cells["DateTime"].Value.ToString();
                        
                        string progressValue = selectedRow.Cells["Progress"].Value.ToString();
                        EventStatus eventStatus = (EventStatus)Enum.Parse(typeof(EventStatus), progressValue);

                        string format = "MMMM dd, yyyy";
                        CultureInfo provider = CultureInfo.InvariantCulture;
                        DateTime.TryParseExact(eventStart, format, provider, DateTimeStyles.None, out DateTime date);

                        EventModel Event = new EventModel
                        {
                            EventName = eventName,
                            DateStart = date.ToUniversalTime(),
                            Status = eventStatus
                        };

                        EventDetailsForm eventDetails = new EventDetailsForm(Event);
                        eventDetails.Show();
                        eventDetails.BringToFront();
                    }
                    
                }
                else if (e.ColumnIndex == EventsData_gunaDataGridView.Columns["Delete_button"].Index)
                {
                    int rowIndex3 = e.RowIndex;
                    if (rowIndex3 >= 0)
                    {
                        Console.WriteLine("Delete button clicked");
                        DataGridViewRow selectedRow = EventsData_gunaDataGridView.Rows[rowIndex3];
                        string EventName = selectedRow.Cells["Name"].Value.ToString();

                        var Event = new EventModel
                        {
                            EventName = EventName
                        };

                        DialogResult result = MessageBox.Show(
                            "Do you want to delete this event?",
                            "Choose Action",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                        if (result == DialogResult.Yes)
                        {
                            await EventService.DeleteEvent(Event);
                            table.Rows.RemoveAt(rowIndex3);
                            MessageBox.Show("Event deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Deletion canceled.", "Action Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else if (e.ColumnIndex == EventsData_gunaDataGridView.Columns["Edit_button"].Index)
                {
                    try
                    {
                        int rowIndex2 = e.RowIndex;
                        if (rowIndex2 >= 0)
                        {
                            DataGridViewRow selectedRow = EventsData_gunaDataGridView.Rows[rowIndex2];

                            var Event = new EventModel
                            {
                                EventName = selectedRow.Cells["Name"].Value.ToString()

                            };
                            EditEventsForm editevent = new EditEventsForm(Event);
                            editevent.EventChanged += EventChanged;
                            editevent.Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}\n{ex.StackTrace}");
                    }

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void EventChanged(EventModel Event)
        {
            int rowIndex = -1;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i]["Name"].ToString() == Event.EventName)
                {
                    rowIndex = i;
                    break;
                }
            }

            if (rowIndex >= 0)
            {
                DataRow rowToUpdate = table.Rows[rowIndex];
                rowToUpdate["Progress"] = Event.Status.ToString();
                EventsData_gunaDataGridView.Refresh();
            }
            EventsData_gunaDataGridView.Enabled = true;
        }

        private void SearchEvents_gunaAdvenceButton_Click(object sender, EventArgs e)
        {

        }

        public async void FetchData()
        {
            try
            {
                List<EventModel> events = new List<EventModel>();
                (events, firstdoc) = await EventService.GetAllEvents(pageNumber, lastdoc);
                if (events.Count > 0)
                {
                    AddEvents(events);
                }
                lastdoc = firstdoc;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AppendCurrentData(): {ex.Message}");
            }
        }

        private string FormatTextToTitleCase(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            var words = input.Split(' ');

            var formattedWords = words.Select(word =>
                char.ToUpper(word[0]) + word.Substring(1).ToLower());

            return string.Join(" ", formattedWords);
        }

        private void SearchedValues(object sender, EventArgs e)
        {
            string text = FormatTextToTitleCase(SearchEvents_gunaTextBox.Text);
            try
            {
                view.RowFilter = $"[Name] LIKE '%{text}%' OR [DateTime] LIKE '%{text}%' OR [Progress] LIKE '%{text}%'";

                EventsData_gunaDataGridView.DataSource = view;

                if (view.Count == 0)
                {
                    FetchData();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching for data: {ex.Message}", "Searching Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadScrollPagination(object sender, ScrollEventArgs e)
        {

            try
            {
                PropertyInfo property = typeof(DataGridView).GetProperty("VerticalScrollBar", BindingFlags.NonPublic | BindingFlags.Instance);
                ScrollBar verticalScrollBar = (ScrollBar)property.GetValue(EventsData_gunaDataGridView);

                if (verticalScrollBar.Value + verticalScrollBar.LargeChange >= verticalScrollBar.Maximum)
                {
                    Console.WriteLine("Scrolled to the bottom. Loading more data...");
                    FetchData();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error accessing VerticalScrollBar: " + ex.Message);
            }
        }

        private void TypingText(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
        }

        private void TextEnter(object sender, EventArgs e)
        {
            timer1.Interval = 300;
            timer1.Tick += SearchedValues;
        }

        private void LeaveText(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Tick -= SearchedValues;
        }

        private void onClickDashboard(object sender, EventArgs e)
        {
          
        }

        private void FilterEvents_gunaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string yearLevelFilter = FilterEvents_gunaComboBox.Text;
            try
            {
                switch (yearLevelFilter)
                {
                    case " ":
                        view.RowFilter = string.Empty;
                        break;
                    case "Ongoing":
                        view.RowFilter = "Progress = 'Ongoing'";
                        break;
                    case "Pending":
                        view.RowFilter = "Progress = 'Pending'";
                        break;
                    case "Done":
                        view.RowFilter = "Progress = 'Done'";
                        break;
                    case "Archived":
                        view.RowFilter = "Progress = 'Archived'";
                        break;
                    default:
                        view.RowFilter = string.Empty;
                        break;
                }

                EventsData_gunaDataGridView.DataSource = view;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering data: {ex.Message}", "Filter Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
