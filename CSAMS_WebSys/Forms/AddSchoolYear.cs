using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSAMS_WebSys.Models;
using CSAMS_WebSys.Services;
using System.Windows.Forms;

namespace CSAMS_WebSys.Forms
{
    public partial class AddSchoolYear : Form
    {
        private string schoolYearID;
        public event Action<string> AddedSY;

        public AddSchoolYear()
        {
            InitializeComponent();

        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onEnter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SchoolYear.Text))
            {
                SchoolYear.Text = "";
                SchoolYear.ForeColor = Color.Black;
            }
        }

        private void onLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SchoolYear.Text))
            {
                SchoolYear.Text = "e.g., 2023-2024";
                SchoolYear.ForeColor = Color.Silver;
            }
        }



        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            try
            {
                schoolYearID = SchoolYear.Text;
                if (string.IsNullOrEmpty(schoolYearID))
                {
                    MessageBox.Show("Please enter a school year");
                    return;
                }

                DateTime DateStart = guna2DateTimePicker1.Value.ToUniversalTime();
                DateTime DateEnd = guna2DateTimePicker3.Value.ToUniversalTime();

                if (DateStart > DateEnd)
                {
                    MessageBox.Show("Start date cannot be greater than end date");
                    return;
                }

                var schoolYear = new SchoolYearModel
                {
                    SchoolYearID = schoolYearID,
                    StartDate = DateStart,
                    EndDate = DateEnd,
                    isActive = false
                };

                SchoolYearServices schoolYearService = new SchoolYearServices();
                var result = schoolYearService.AddSchoolYearAsync(schoolYear);
                AddedSY?.Invoke(schoolYear.SchoolYearID);
                this.Close();
            }
            catch
            {
               MessageBox.Show("Error occured while adding school year");
            }
        }

        private void onLeaveDate(object sender, EventArgs e)
        {
            guna2DateTimePicker1.Enabled = true;
        }


        private void onClickDate(object sender, MouseEventArgs e)
        {
            guna2DateTimePicker1.Enabled = false;
        }
    }
}
