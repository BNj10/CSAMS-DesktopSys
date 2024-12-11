using CSAMS_WebSys.Models;
using DocumentFormat.OpenXml.Spreadsheet;
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
    public partial class PopUpVerify : UserControl
    {
        public event Action Confirmed;
        public event Action Cancelled;
        public PopUpVerify()
        {
            InitializeComponent();
        }

        public void DisplayMemberDetails(MemberModel member, string action)
        {
            guna2HtmlLabel2.Text = $"{member.FirstName} {member.LastName}";
            guna2HtmlLabel1.Text = member.StudentID;
            if(action == "Time In")
                guna2HtmlLabel4.Text = member.TimeIn.Value.ToString("hh:mm tt");
            else
                guna2HtmlLabel4.Text = member.TimeOut.Value.ToString("hh:mm tt");
            guna2HtmlLabel3.Text = action;
        }

        public void AddMember_gunaAdvenceButton_Click(object sender, EventArgs e)
        {
            this.Confirmed?.Invoke();   
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            this.Cancelled?.Invoke();
        }

        private void PopUpVerify_Load(object sender, EventArgs e)
        {

        }
    }
}
