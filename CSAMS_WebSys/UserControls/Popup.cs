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
    public partial class PopUp : UserControl
    {
        public event EventHandler Confirmation;
        public PopUp()
        {
            InitializeComponent();
        }

        private void AddMembersTitle_gunaPanel_Paint(object sender, PaintEventArgs e)
        {
            this.Confirmation?.Invoke(this, EventArgs.Empty);
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
