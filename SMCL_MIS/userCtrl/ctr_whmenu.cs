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
    public partial class ctr_whmenu : UserControl
    {
        Igni i = new Igni();
        public ctr_whmenu()
        {
            InitializeComponent();
            Extensions.check_per_menu(menuStrip1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Form)this.Parent).Close();
        } 
    }
}
