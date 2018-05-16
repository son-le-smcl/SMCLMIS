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
    public partial class frmTransaction : Form
    {
        
        GC_Wh wh = new GC_Wh();
        public frmTransaction()
        {
            InitializeComponent();
        }

        private void get_location()
        {
            GC_Purchasing p = new GC_Purchasing();
            DataTable dt = p.get_loch();
            DataRow dr = dt.NewRow();
            dt.Rows.InsertAt(dr, 0);
            cb_loc.DataSource = dt;
            cb_loc.DisplayMember = "LOCNO";
            cb_loc.ValueMember = "LOCNO";
             
        }

        private void get_trn_type()
        {
            DataTable dt = wh.get_trn_type();
            DataRow dr = dt.NewRow();
            dt.Rows.InsertAt(dr, 0); 
            cb_trntype.DataSource = dt;
            cb_trntype.DisplayMember = "trn_name";
            cb_trntype.ValueMember = "trn_name"; 
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                (System.Windows.Forms.Application.OpenForms["Main"] as Main).set_processbar(0);

                dataGridView1.DataSource =
                wh.get_transaction_by_date(dp_podate1.Value, dp_podate2.Value);
                DataView bs = new DataView(dataGridView1.DataSource as DataTable);
                string Filter = "(1=1) ";
                if (cb_loc.Text != "")
                {
                    Filter = Filter + " And (LOCF='" + cb_loc.Text + "' or LOCT='" + cb_loc.Text + "')";
                }
                if (cb_trntype.Text != "")
                {
                    Filter = Filter + " And (Type='" + cb_trntype.Text + "')";
                }
                if (txt_search.Text != "")
                {
                    Filter = Filter + " And (Transaction_number like '%" + txt_search.Text + "%')";
                    Filter = Filter + " OR (Transaction_number like '%" + txt_search.Text + "%')";
                    Filter = Filter + " OR (Part_number like '%" + txt_search.Text + "%')";
                    Filter = Filter + " OR (PO_Number like '%" + txt_search.Text + "%')";
                    Filter = Filter + " OR (SO_Number like '%" + txt_search.Text + "%')";
                }
                bs.RowFilter = Filter;
                dataGridView1.DataSource = bs.ToTable();

                dataGridView1.Columns["Qty1"].DefaultCellStyle.Format =
                dataGridView1.Columns["Qty2"].DefaultCellStyle.Format = "N2";
            }
            catch (Exception ext)
            {
                Igni i = new Igni();
                i.update_user_errlog(LoginInfo.username
                    , this.Name
                    , ext.ToString()
                    , DateTime.Now.ToString());
                MessageBox.Show(Extensions.error_cannotsave, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            Extensions.set_grid_style(dataGridView1);
            dataGridView1.DoubleBuffered(true);
            get_location();
            get_trn_type();
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;

            (System.Windows.Forms.Application.OpenForms["Main"] as Main).set_processbar(dt.Rows.Count);
            Extensions.Export(dt, "SMCL TRANSACTIONS INFORMATION(" + DateTime.Now + ")");
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
