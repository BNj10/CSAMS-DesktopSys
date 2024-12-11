using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSAMS_WebSys.Forms;
using CSAMS_WebSys.Models;
using CSAMS_WebSys.Services.Dashboard;

namespace CSAMS_WebSys.UserControls
{
    public partial class UserControl_Dashboard : UserControl
    {
        private UpdatesService updatesService;
        public event Action<int> TotalMembersUpdated;
        public UserControl_Dashboard()
        {
            InitializeComponent();
            updatesService = new UpdatesService();
            updatesService.TotalMembersUpdated += UpdateMemberNumber;
            InitializeElements();
        }

        public void InitializeElements()
        {
            UpdateTotalNumberOfStudents();
            UpdateTotalNumberOfStudentsWithNoBiometrics();
            FirstUpdateTotalNumber();
            SecondUpdateTotalNumber();
            ThirdFirstUpdateTotalNumber();
            FourthFirstUpdateTotalNumber();
            FifthAboveFirstUpdateTotalNumber();
            MostRecentEvent();
        }

        private async void UpdateTotalNumberOfStudents()
        {
            int TotalNumberOfMembers = await updatesService.GetTotalMembersAsync();
            try
            {
                TotalMembersNumber_gunaLabel.Text = $" {TotalNumberOfMembers} members for the first \r\nsemester year 2024-2025.\r\n\r\n";
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error retrieving total number of students" + ex);
            }
        }

        private void UpdateMemberNumber(int TotalNumber)
        {

        }

        private async void UpdateTotalNumberOfStudentsWithNoBiometrics()
        {
            try
            {
                int totalNumberOfMembersWithNoFP = await updatesService.GetTotalMembersWithNoBiometrics();

                CurrentNoBioMem_gunaLabel.Text = $" {totalNumberOfMembersWithNoFP} members with no \r\nbiometrics currently added.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving total number of students" + ex);
            }
        }

        private async void FirstUpdateTotalNumber()
        {
            try
            {
                int firstYearCount = await updatesService.GetTotalMembersByYear("1");
                FirstYear_gunaLabel.Text = firstYearCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching first-year members: {ex.Message}");
            }
        }

        private async void SecondUpdateTotalNumber()
        {
            try
            {
                int secondYearCount = await updatesService.GetTotalMembersByYear("2");
                SecondYear_gunaLabel.Text = secondYearCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching second-year members: {ex.Message}");
            }
        }

        private async void ThirdFirstUpdateTotalNumber()
        {
            try
            {
                int thirdYearCount = await updatesService.GetTotalMembersByYear("3");
                ThirdYear_gunaLabel.Text = thirdYearCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching third-year members: {ex.Message}");
            }
        }

        private async void FourthFirstUpdateTotalNumber()
        {
            try
            {
                int fourthYearCount = await updatesService.GetTotalMembersByYear("4");
                FourthYear_gunaLabel.Text = fourthYearCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching fourth-year members: {ex.Message}");
            }
        }

        private async void FifthAboveFirstUpdateTotalNumber()
        {
            try
            {
                int fifthYearAndAboveCount = await updatesService.GetTotalMembersByYear("5th above");
                FifthYear_gunaLabel.Text = fifthYearAndAboveCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching fifth year and above members: {ex.Message}");
            }
        }

        private async void MostRecentEvent()
        {
            EventModel eventModel = new EventModel();
            try
            {
                eventModel = await updatesService.GetLatestEventOccured();

                if (eventModel != null)
                {
                    EventName_gunaLabel.Text = $" {eventModel.EventName.ToString() ?? "No event name specified"} : {eventModel.Status.ToString()}";
                    EventDescription_gunaLabel.Text = $"{eventModel.EventDescription?.ToString()} \n{eventModel.DateEnd?.ToString() ?? "No end date specified."} ";
                }
                else
                {
                    EventName_gunaLabel.Text = "No event available.";
                    EventDescription_gunaLabel.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching latest event: {ex.Message}");
            }
        }
    }
}
