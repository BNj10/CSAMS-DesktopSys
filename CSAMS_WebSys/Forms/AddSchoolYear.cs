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
    public partial class AddSchoolYear : Form
    {
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
                SchoolYear.Text = "2024-2025";
                SchoolYear.ForeColor = Color.Silver;
            }
        }

        
    }
}
