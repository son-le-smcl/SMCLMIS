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
    public partial class frmSosummary : Form
    {
        public frmSosummary()
        {
            InitializeComponent();
        }

        private void frmSosummary_Load(object sender, EventArgs e)
        {
            dp_from.Value = new DateTime(DateTime.Now.Year, 1, 1);
            Extensions.set_grid_style(dataGridView1);
            dataGridView1.DoubleBuffered(true);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GC_Sales s = new GC_Sales();
            dataGridView1.DataSource= s.So_sum(dp_from.Value, dp_to.Value);

            (System.Windows.Forms.Application.OpenForms["Main"] as Main).set_processbar(
                 dataGridView1.Rows.Count);

        } 
   
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string str = "";
            if (txt_search.Text.Trim() != "")
            {
               
                if (radioButton_ongoing.Checked) { str=str+ " and Delivery_Qty < Order_Qty "; }
                if (radioButton_Finished.Checked) { str = str + " and Delivery_Qty >= Order_Qty "; }
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("SONO LIKE '%{0}%' " +
                    "Or Created_User LIKE '%{0}%' " +
                    "Or Approve_User LIKE '%{0}%' " +
                    "Or Customer_Po LIKE '%{0}%' " +
                    "OR Customer LIKE '%{0}%'" +
                    str+
                    "OR Part_Number LIKE '%{0}%'", txt_search.Text); 
            }
            else {
                if (radioButton_ongoing.Checked) { str = str + " and Delivery_Qty < Order_Qty "; }
                if (radioButton_Finished.Checked) { str = str + " and Delivery_Qty >= Order_Qty "; }
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "1=1"+str;
            }
        }  

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            Extensions.Export(dt, "SMCL SALE ORDER(" + DateTime.Now + ")");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            txt_search_TextChanged(sender, e);
        }

        private void frmSosummary_Paint(object sender, PaintEventArgs e)
        {
            Extensions.Purchasing = this.Name;
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);

        }
    }
}
