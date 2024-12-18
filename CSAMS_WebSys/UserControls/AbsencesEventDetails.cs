using CSAMS_WebSys.Models.enums;
using CSAMS_WebSys.Models;
using CSAMS_WebSys.Services;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Google.Cloud.Firestore.V1.StructuredAggregationQuery.Types.Aggregation.Types;

namespace CSAMS_WebSys.UserControls
{
    public partial class AbsencesEventDetails : UserControl
    {
        private DataTable table;
        private DataView view;
        private int pageSize = 30;
        private int Count;
        private AttendanceService attendanceservice;
        private AttendanceModel attendance;
        private HashSet<string> DisplayedMember = new HashSet<string>();
        private EventModel Event;
        private static DocumentSnapshot lastdoc;

        public AbsencesEventDetails()
        {
            InitializeComponent();
            attendanceservice = new AttendanceService();
            attendance = new AttendanceModel();
            Event = new EventModel();
            table = new DataTable();
            view = new DataView();
            InitializeDT();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void InitializeDT()
        {
            table.Columns.Add("StudentID", typeof(string));
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("YearLevel", typeof(string));
            table.Columns.Add("Status", typeof(string));
            table.Columns.Add("DateAdded", typeof(string));

            AbsentAtendeesData_gunaDataGridView.DataSource = table;

            DataGridViewButtonColumn dataGridViewButtonColumn_detials = new DataGridViewButtonColumn();
            dataGridViewButtonColumn_detials.Name = "Detail_button";
            dataGridViewButtonColumn_detials.HeaderText = "detail";

            dataGridViewButtonColumn_detials.FlatStyle = FlatStyle.Popup;

            dataGridViewButtonColumn_detials.Text = " Details";

            dataGridViewButtonColumn_detials.UseColumnTextForButtonValue = true;

            AbsentAtendeesData_gunaDataGridView.Columns.Add(dataGridViewButtonColumn_detials);

            AbsentAtendeesData_gunaDataGridView.Columns[0].Width = 90;
            AbsentAtendeesData_gunaDataGridView.Columns[3].Width = 80;
            AbsentAtendeesData_gunaDataGridView.Columns[4].Width = 80;
            AbsentAtendeesData_gunaDataGridView.Columns[6].Width = 120;

            AbsentAtendeesData_gunaDataGridView.AllowUserToResizeRows = false;
            AbsentAtendeesData_gunaDataGridView.AllowUserToResizeColumns = false;
            AbsentAtendeesData_gunaDataGridView.AllowUserToAddRows = false;

            AbsentAtendeesData_gunaDataGridView.ReadOnly = true;
            view = table.DefaultView;
        }

        private async void UpdateEventAbsences()
        {
            (var members, DocumentSnapshot firstdoc) = await attendanceservice.GetAbsentMembers(attendance, pageSize, lastdoc);
            AddMembers(members);
        }

        public void GetEventAndAbsencesDetailsFromForm(EventModel Event, AttendanceModel objAttendance)
        {
            this.Event = Event;
            this.attendance = objAttendance;
            UpdateEventAbsences();
        }
/*        private void UpdateAttendees()
        {
            if (noOfAbsences_gunaLabel.InvokeRequired)
            {
                noOfAbsences_gunaLabel.Invoke(new Action(() =>
                {
                    noOfAbsences_gunaLabel.Text = Count.ToString();
                }));
            }
            else
            {
                noOfAbsences_gunaLabel.Text = Count.ToString();
            }
        }*/

        private async void GetNumberOfAttendees()
        {
            Count = await attendanceservice.GetTotalAttendees(attendance);
    /*        UpdateAttendees();*/
        }

        private void AddMembers(List<MemberModel> members)
        {
            foreach (var member in members)
            {
                if (member != null && DisplayedMember.Add(member.StudentID))
                {
                    table.Rows.Add(member.StudentID, member.FirstName, member.LastName, member.YearLevel, member.Status, hasTimedIn(member)? member.TimeIn.ToString(): "Not available");
                }
            }
        }

        private bool hasTimedIn(MemberModel member)
        {
            return member.TimeIn != null;
        }

    }
}
