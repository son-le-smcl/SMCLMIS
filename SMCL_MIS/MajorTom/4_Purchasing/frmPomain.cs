using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMCL_MIS 
{
    public partial class frmPomain : Form
    {
        public frmPomain()
        {
            InitializeComponent();
        }

        private void frmPomain_Paint(object sender, PaintEventArgs e)
        {
            Extensions.Purchasing = this.Name;
        }
    }
}
