using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMCL_MIS
{
    public partial class crt_Settingsmenu : UserControl
    {
        public crt_Settingsmenu()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Form)this.Parent).Close();
        } 
        private void userSettupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsersettup s = new frmUsersettup();
            (Application.OpenForms["Main"] as Main).openform(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Form)this.Parent).Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void userListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserList s = new frmUserList();
            (Application.OpenForms["Main"] as Main).openform(s);
        }

        private void userErrorLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserError s = new frmUserError();
            (Application.OpenForms["Main"] as Main).openform(s);
        }

        private void addUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEquipment s = new frmEquipment();
            (Application.OpenForms["Main"] as Main).openform(s);
        }

        private void listEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEquipmentlist s = new frmEquipmentlist();
            (Application.OpenForms["Main"] as Main).openform(s);
        }
    }
}
