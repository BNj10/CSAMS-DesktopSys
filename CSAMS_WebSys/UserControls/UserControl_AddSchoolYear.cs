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
    public partial class UserControl_AddSchoolYear : UserControl
    {
        public UserControl_AddSchoolYear()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {

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
                SchoolYear.Text = "2024-2025";
                SchoolYear.ForeColor = Color.Silver;
            }
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
