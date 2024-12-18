using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSAMS_WebSys.UserControls
{
    public partial class absencesButtomEventDetails : UserControl
    {
        public absencesButtomEventDetails()
        {
            InitializeComponent();
            dummyData();
        }

        private void dummyData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("year", typeof(int));
            table.Columns.Add("status", typeof(string));
            table.Columns.Add("date added", typeof(string));

            table.Rows.Add("22-1-10082", "Benjie", "Saquin", 3, "Irregular", "20/11/2024 8:24 pm");

            AbsencesData_gunaDataGridView.DataSource = table;

            DataGridViewButtonColumn dataGridViewButtonColumn_detials = new DataGridViewButtonColumn();
            dataGridViewButtonColumn_detials.Name = "Detail_button";
            dataGridViewButtonColumn_detials.HeaderText = "detail";

            dataGridViewButtonColumn_detials.FlatStyle = FlatStyle.Popup;

            dataGridViewButtonColumn_detials.Text = " Details";

            dataGridViewButtonColumn_detials.UseColumnTextForButtonValue = true;

            AbsencesData_gunaDataGridView.Columns.Add(dataGridViewButtonColumn_detials);

            AbsencesData_gunaDataGridView.Columns[0].Width = 90;
            AbsencesData_gunaDataGridView.Columns[3].Width = 80;
            AbsencesData_gunaDataGridView.Columns[4].Width = 80;
            AbsencesData_gunaDataGridView.Columns[6].Width = 120;

            AbsencesData_gunaDataGridView.AllowUserToResizeRows = false;
            AbsencesData_gunaDataGridView.AllowUserToResizeColumns = false;
            AbsencesData_gunaDataGridView.AllowUserToAddRows = false;

            AbsencesData_gunaDataGridView.ReadOnly = true;
        }

        private void AbsencesData_gunaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == AbsencesData_gunaDataGridView.Columns["Detail_button"].Index) //DETAILS
                {
                    //open form for member details
                }
            }
            catch
            {
            }
        }
    }
}
