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
    public partial class frm_Quoteinfo : Form
    {
        GC_Purchasing pur = new GC_Purchasing();
        public frm_Quoteinfo()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try {
                dataGridView1.DoubleBuffered(true);
                dataGridView1.DataSource = pur.get_Quoteinfo(dp_podate1.Value, dp_podate2.Value);
                (System.Windows.Forms.Application.OpenForms["Main"] as Main).set_processbar(0);
                DataView bs = new DataView(dataGridView1.DataSource as DataTable);
                string Filter = "";

                Filter = "(Quote_ID like '%" + txt_search.Text + "%') "
               + "OR (Create_User like '%" + txt_search.Text + "%') "
               + "OR (Part_number like '%" + txt_search.Text + "%') "
               + "OR (Supplier_ID like '%" + txt_search.Text + "%') "
                + "OR (Supplier_Name like '%" + txt_search.Text + "%') ";

                //bs.DataSource = dataGridView1.DataSource;
                bs.RowFilter = Filter;
                dataGridView1.DataSource = bs.ToTable();
                dataGridView1.Refresh();
                dataGridView1.Columns["Quote_ID"].Frozen = true;
            }
            catch(Exception ext) {
                Igni i = new Igni();
                i.update_user_errlog(LoginInfo.username
                    , this.Name
                    , ext.ToString()
                    , DateTime.Now.ToString());
                MessageBox.Show(Extensions.error_cannotsave, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
 

        private void exportToExcelToolStripMenuItem_Click_1(object sender, EventArgs e)
        { 
            DataTable dt = dataGridView1.DataSource as DataTable;
            (System.Windows.Forms.Application.OpenForms["Main"] as Main).set_processbar(dt.Rows.Count);
            Extensions.Export(dt, "SMCL Quotation(" + DateTime.Now + ")");
            //eport_excel excel = new eport_excel();
            //excel.Export2Excel(dt); 
        }

        private void frm_Quoteinfo_Paint(object sender, PaintEventArgs e)
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

        private void frm_Quoteinfo_Load(object sender, EventArgs e)
        {
            Extensions.set_grid_style(dataGridView1);
        }
    }
}
