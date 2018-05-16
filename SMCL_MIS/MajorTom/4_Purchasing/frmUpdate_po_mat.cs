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
    public partial class frmUpdate_po_mat : Form
    {
        DataTable dt;
        GC_Purchasing p = new GC_Purchasing();
        public frmUpdate_po_mat()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void get_materials()
        {
            dataGridView1.DataSource = dt;
            (System.Windows.Forms.Application.OpenForms["Main"] as Main).set_processbar(
                dataGridView1.Rows.Count);
        }
        private void frmUpdate_po_mat_Load(object sender, EventArgs e)
        {
            dt = p.get_all_mat();
            get_materials();
            Extensions.set_grid_style(dataGridView1);

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (txtSearch.Text.Trim() == "")
                dataGridView1.DataSource = dt;

            else
            {
                DataView dv = new DataView(dt);
                string Filter = "1=1";
                if (txtSearch.Text != "")
                {
                    Filter = Filter + " And (Part_number like '%" + txtSearch.Text + "%')";
                    Filter = Filter + " OR (Description like '%" + txtSearch.Text + "%')";
                    Filter = Filter + " OR (Bom_type like '%" + txtSearch.Text + "%')";
                    Filter = Filter + " OR (Buyer like '%" + txtSearch.Text + "%')"; 
                }
                dv.RowFilter = Filter;
                dataGridView1.DataSource = dv.ToTable();
            }

        }
        private void get_mat(string mat)
        {
            GC_Engineer en = new GC_Engineer(); 
            cbmakebuy.DataSource = en.get_mat_st("MakeOrBuy");
            cbmakebuy.DisplayMember = "NAME";
            cbmakebuy.ValueMember = "matstvalue"; 
            cbrank.DataSource = en.get_mat_st("MatRank");
            cbrank.DisplayMember = "NAME";
            cbrank.ValueMember = "matstvalue";
            cb_pouom.DataSource = en.get_mat_st("MatUOM");
            cb_pouom.DisplayMember = "NAME";
            cb_pouom.ValueMember = "matstvalue";
            cb_bomuom.DataSource = en.get_mat_st("MatUOM");
            cb_bomuom.DisplayMember = "NAME";
            cb_bomuom.ValueMember = "matstvalue";
            cb_buyer.DataSource = p.get_buyer();
            cb_buyer.DisplayMember = "Userid";
            cb_buyer.ValueMember = "Userid";

            DataTable mat_dt = en.get_materials_by_partno(mat);
            txtPartno.Text = mat_dt.Rows[0]["partno"].ToString();
            txtDes.Text = mat_dt.Rows[0]["partname"].ToString();
            txtWs.Text = mat_dt.Rows[0]["Partloc"].ToString();
            txtrate.Text = mat_dt.Rows[0]["poxSTK"].ToString();
            cbmakebuy.Text = mat_dt.Rows[0]["prodway"].ToString();
            cbrank.Text = mat_dt.Rows[0]["Wltype"].ToString();
            txtbom.Text = mat_dt.Rows[0]["Wlattr"].ToString();
            txtcate.Text = mat_dt.Rows[0]["s_type"].ToString();
            cb_bomuom.Text = mat_dt.Rows[0]["UOFM"].ToString();
            cb_pouom.Text = mat_dt.Rows[0]["POUOFM"].ToString();
            cb_buyer.Text= mat_dt.Rows[0]["Buyer"].ToString();


            pictureBox1.InitialImage = null;
            Extensions.set_picture("Materials", txtPartno.Text, pictureBox1);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                get_mat(dataGridView1[0, e.RowIndex].Value.ToString());
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
            try
            {
                p.update_mat(
               txtPartno.Text,
               cb_pouom.Text,
               float.Parse(txtrate.Text),
               cb_buyer.Text,
               cbrank.Text,
               cbmakebuy.SelectedValue.ToString());
                MessageBox.Show("Update Completed"+Environment.NewLine+"Cập nhật hoàn tất","Successfull",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                Igni i = new Igni();
                i.update_user_errlog(LoginInfo.username
                    , this.Name
                    , exc.Message.ToString()
                    , DateTime.Now.ToString());
                MessageBox.Show(exc.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Main.ResetAllControls(groupBox1);
            frmUpdate_po_mat_Load(sender, e);
        }
    }
}
