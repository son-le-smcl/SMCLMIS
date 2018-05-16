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
    public partial class frmPOinfo : Form
    {
        GC_Purchasing pur = new GC_Purchasing();
        public frmPOinfo()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DoubleBuffered(true);
                dataGridView1.DataSource = pur.get_poinfo(dp_podate1.Value, dp_podate2.Value);
                (System.Windows.Forms.Application.OpenForms["Main"] as Main).set_processbar(dataGridView1.Rows.Count);
                color_gridview();
                DataView bs = new DataView(dataGridView1.DataSource as DataTable);
                string Filter = "";
                if (radioButton_ontheway.Checked)
                {

                    Filter = "(warning ='On The Way')";
                }
                else if (radioButton_late.Checked)
                {
                    Filter = "(warning ='Late')";
                }
                else if (radioButton_finished.Checked)
                {
                    Filter = "(warning ='Finished')";
                }
                else
                {
                    if (txt_search.Text != "")
                    {
                        Filter = "(PONO like '%" + txt_search.Text + "%') "
                       + "OR (Create_User like '%" + txt_search.Text + "%') "
                       + "OR (Part_number like '%" + txt_search.Text + "%') "
                       + "OR (Supplier_ID like '%" + txt_search.Text + "%') ";
                    }

                }

                //bs.DataSource = dataGridView1.DataSource;
                bs.RowFilter = Filter;
                dataGridView1.DataSource = bs.ToTable();
                dataGridView1.Refresh();
                dataGridView1.Columns["PONO"].Frozen = true;
                color_gridview();
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
        private void color_gridview()
        { 
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {  
                //if (dataGridView1.CurrentRow.Index == -1) return;

                if (dataGridView1[1, i].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells["ORDERED"].Value.ToString() == dataGridView1.Rows[i].Cells["RECEIVED"].Value.ToString() ||
                        dataGridView1.Rows[i].Cells["STATUS"].Value.ToString() == "Close")
                    {
                        dataGridView1[0, i].Value = "Finished";
                        dataGridView1[0, i].Style.ForeColor = Color.Gray;
                    }
                    if (float.Parse(Extensions.EmptyIfNull(dataGridView1.Rows[i].Cells["ORDERED"].Value.ToString())) >
                        float.Parse(Extensions.EmptyIfNull(dataGridView1.Rows[i].Cells["RECEIVED"].Value.ToString())) &&
                        Extensions.EmptyIfNull(dataGridView1.Rows[i].Cells["STATUS"].Value.ToString()) == "Approval")
                    {
                        dataGridView1[0, i].Value = "On The Way";
                        dataGridView1[0, i].Style.ForeColor = Color.Green;
                    }
                    if (float.Parse(Extensions.EmptyIfNull(dataGridView1.Rows[i].Cells["ORDERED"].Value.ToString())) >
                       float.Parse(Extensions.EmptyIfNull(dataGridView1.Rows[i].Cells["RECEIVED"].Value.ToString())) &&
                      Convert.ToDateTime(Extensions.EmptyIfNull(dataGridView1.Rows[i].Cells["RecDate"].Value.ToString())) < DateTime.Now)
                    {
                        dataGridView1[0, i].Value = "Late";
                        dataGridView1[0, i].Style.ForeColor = Color.Red;
                    }
                    if (Extensions.EmptyIfNull(dataGridView1.Rows[i].Cells["STATUS"].Value.ToString()) == "Draft")
                    {
                        dataGridView1[0, i].Value = "Draft Po";
                        dataGridView1[0, i].Style.ForeColor = Color.Orange;
                    }
                }
            }
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            DataTable dt = dataGridView1.DataSource as DataTable;

            (System.Windows.Forms.Application.OpenForms["Main"] as Main).set_processbar(dt.Rows.Count);
            Extensions.Export(dt, "SMCL PURCHASE ORDER("+DateTime.Now+")");
            //eport_excel excel = new eport_excel();
            //excel.Export2Excel(dt);
        }

        private void frmPOinfo_Paint(object sender, PaintEventArgs e)
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

        private void frmPOinfo_Load(object sender, EventArgs e)
        {
            Extensions.set_grid_style(dataGridView1);
        }
    }
}
