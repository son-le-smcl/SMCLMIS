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
    public partial class ctr_Purchasemenu : UserControl
    {
        Igni i = new Igni();
        public ctr_Purchasemenu()
        {
            InitializeComponent();
            Extensions.check_per_menu(menuStrip1); 
        } 
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Form)this.Parent).Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Form)this.Parent).Close();
        }
    }
}
