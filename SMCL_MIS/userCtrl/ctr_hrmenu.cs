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
    public partial class ctr_hrmenu : UserControl
    {
        public ctr_hrmenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Form)this.Parent).Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
          
        }

        private void tảiDữLiệuChấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaidulieuchamcong f = new frmTaidulieuchamcong();
            (Application.OpenForms["Main"] as Main).openformbyname(f.Name);
        }

        private void xemDưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXemdulieuchamcong f = new frmXemdulieuchamcong();
            (Application.OpenForms["Main"] as Main).openformbyname(f.Name);
        }

        private void tảiVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaidulieunhanvien f = new frmTaidulieunhanvien();
            (Application.OpenForms["Main"] as Main).openformbyname(f.Name);
        }

        private void tảiLênMáyCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanvienlenmcc f = new frmNhanvienlenmcc();
            (Application.OpenForms["Main"] as Main).openformbyname(f.Name); 
        }

        private void xemDanhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXemnhanvien f = new frmXemnhanvien();
            (Application.OpenForms["Main"] as Main).openformbyname(f.Name);
        }

        private void ngàyLàmViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalendar f = new frmCalendar();
            (Application.OpenForms["Main"] as Main).openformbyname(f.Name);
        }

        private void caLàmViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaidatcalamviec f = new frmCaidatcalamviec();
            (Application.OpenForms["Main"] as Main).openformbyname(f.Name);

        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaidatphongban f = new frmCaidatphongban();
            (Application.OpenForms["Main"] as Main).openformbyname(f.Name);

        }

        private void máyChấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmCaidatmcc f = new frmCaidatmcc();
            (Application.OpenForms["Main"] as Main).openformbyname(f.Name);

        }
    }
}
