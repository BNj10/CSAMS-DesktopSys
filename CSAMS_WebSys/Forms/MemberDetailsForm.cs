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

namespace CSAMS_WebSys.Forms
{
    public partial class MemberDetailsForm : Form
    {
        private MemberModel member;
        private EventService eventservice;
        private List<EventModel> eventObj;
        private HashSet<string> DisplayedMember;
        private DataTable table;
        public MemberDetailsForm(MemberModel member)
        {
            InitializeComponent();
            this.member = member;
            eventservice = new EventService();
            eventObj = new List<EventModel>();
            table = new DataTable();
            DisplayedMember = new HashSet<string>();
            InitializeTables();
        }

        private void InitializeTables()
        {

            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("DateTime", typeof(string));
            table.Columns.Add("Attendees", typeof(int));
            table.Columns.Add("Progress", typeof(string));

            EventsData_gunaDataGridView.DataSource = table;

            DataGridViewButtonColumn dataGridViewButtonColumn_detials = new DataGridViewButtonColumn();
            dataGridViewButtonColumn_detials.Name = "Detail_button";
            dataGridViewButtonColumn_detials.HeaderText = "";

            dataGridViewButtonColumn_detials.FlatStyle = FlatStyle.Popup;

            dataGridViewButtonColumn_detials.Text = " Details";

            dataGridViewButtonColumn_detials.UseColumnTextForButtonValue = true;

            EventsData_gunaDataGridView.Columns.Add(dataGridViewButtonColumn_detials);

            EventsData_gunaDataGridView.RowTemplate.Height = 50;

            EventsData_gunaDataGridView.Columns[0].Width = 500;
            EventsData_gunaDataGridView.Columns[1].Width = 150;
            EventsData_gunaDataGridView.Columns[2].Width = 80;
            EventsData_gunaDataGridView.Columns[3].Width = 80;
            EventsData_gunaDataGridView.Columns[4].Width = 130;


            EventsData_gunaDataGridView.AllowUserToResizeRows = false;
            EventsData_gunaDataGridView.AllowUserToResizeColumns = false;
            EventsData_gunaDataGridView.AllowUserToAddRows = false;

            EventsData_gunaDataGridView.ReadOnly = true;
        }
        private async void MemberDetailsLoad(object sender, EventArgs e)
        {
            try
            {
                guna2WinProgressIndicator1.Show();
                guna2WinProgressIndicator1.Start();
                
                nameChange_gunaLabel.Text = member.FirstName + " " + member.LastName;
                if (member.BiometricsAdded)
                {
                    c.Text = "Added";
                    bioStatusChange_gunaPanel.BackColor = Color.Aquamarine;
                }
                else
                {
                    c.Text = "Not Added";
                    bioStatusChange_gunaPanel.BackColor = Color.Red;
                }
                List<string> attended = new List<string>();
                yearChange_gunaLabel.Text = member.YearLevel;
                IDChange_gunaLabel.Text = member.StudentID;
                statusChange_gunaLabel.Text = member.Status;
                eventObj = await eventservice.GetMissedEventsAsync(member.StudentID);

                foreach (var eve in eventObj)
                {
                    Console.WriteLine("Event Name id: " + eve.EventName);
                }

                AddEvents(eventObj);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                guna2WinProgressIndicator1.Stop();
                guna2WinProgressIndicator1.Hide();
            }
            
        }

        private void AddEvents(List<EventModel> Events)
        {
            foreach (var Event in Events)
            {
                if (member != null && DisplayedMember.Add(Event.EventName))
                {
                    table.Rows.Add(Event.EventName, Event.DateAdded?.ToString("MMMM dd, yyyy"), 1, Event.Status.ToString());
                }
            }
        }
    }
}
