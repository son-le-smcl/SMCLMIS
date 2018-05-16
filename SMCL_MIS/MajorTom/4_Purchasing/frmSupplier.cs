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
    public partial class frmSupplier : Form
    {
        GC_Purchasing Pur = new GC_Purchasing();
        Igni igni = new Igni();
        public bool check_suplier()
        {
            if (!(System.Windows.Forms.Application.OpenForms["Main"] as Main).check_empty(txtSupno) ||
                !(System.Windows.Forms.Application.OpenForms["Main"] as Main).check_empty(txtSupname) ||
                !(System.Windows.Forms.Application.OpenForms["Main"] as Main).check_empty(txtSupadd) ||
                !(System.Windows.Forms.Application.OpenForms["Main"] as Main).check_empty(cb_currency) ||
                !(System.Windows.Forms.Application.OpenForms["Main"] as Main).check_empty(cb_deliverytype) ||
                !(System.Windows.Forms.Application.OpenForms["Main"] as Main).check_empty(cb_Gltype) ||
                !(System.Windows.Forms.Application.OpenForms["Main"] as Main).check_empty(cb_pmterm) ||
                !(System.Windows.Forms.Application.OpenForms["Main"] as Main).check_empty(cb_settlement) ||
                !(System.Windows.Forms.Application.OpenForms["Main"] as Main).check_empty(cb_tax))
            {
                MessageBox.Show("Please Input all Required fields!" + Environment.NewLine + "Xin Nhập tất cả trường bắt buộc!", "Missing Filed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;

            }
            else
                return true;
        }

        public frmSupplier()
        {
            InitializeComponent();
        }

        private void new_supplier()
        {
            if (check_suplier())
            {
                Pur.new_supplier(txtSupno.Text, txtSupname.Text, cb_currency.Text, cb_pmterm.Text, 0
                    , cb_tax.SelectedIndex, cb_class.Text, txtPhone.Text, txtFax.Text, txtContact.Text, txtEmail.Text, txtSupadd.Text
                    , 0, LoginInfo.username, DateTime.Now, 0, "", "", "", "", "", cb_deliverytype.Text, cb_buyer.Text
                    , txtBankname.Text, txtAccnumber.Text, "", "", "", "", "", "", "", "", "", cb_Gltype.Text, "", cb_settlement.Text
                    ,txtbrand.Text,txtVAT.Text);
                MessageBox.Show("Create Successful!", txtSupno.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                return;
        }

        private void update_suplier()
        {
            int T = 0;
                T = Extensions.bool_to_int(chk_deactive.Checked);
            if (check_suplier())
            { 
            Pur.update_supplier(txtSupno.Text, txtSupname.Text, cb_currency.Text, cb_pmterm.Text, Extensions.bool_to_int(chk_deactive.Checked)
                ,  cb_tax.SelectedIndex, cb_class.Text, txtPhone.Text, txtFax.Text, txtContact.Text, txtEmail.Text, txtSupadd.Text
                ,0, 0, "", "", "", "", "", cb_deliverytype.Text, cb_buyer.Text
                , txtBankname.Text, txtAccnumber.Text, "", "", "",txtSupname2.Text, txtSupadd2.Text,"", "", "", "", cb_Gltype.Text, "", cb_settlement.Text
                , txtbrand.Text, txtVAT.Text);
            MessageBox.Show("Update Successful!", txtSupno.Text , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                return;
        }

        public void get_supplier_by_supplierno(string supno)
        {
            DataTable dt = new DataTable();
            dt = Pur.get_supplier_by_supplierno(supno);
            if (dt.Rows.Count > 0)
            { 
                txtSupno.Text = dt.Rows[0]["VendID"].ToString();
                txtSupname.Text = dt.Rows[0]["VendName"].ToString();
                txtSupadd.Text = dt.Rows[0]["Address"].ToString();
                txtSupname2.Text = dt.Rows[0]["Supplier"].ToString();
                txtSupadd2.Text = dt.Rows[0]["Supaddr"].ToString();
                txtContact.Text = dt.Rows[0]["Contact"].ToString();
                txtPhone.Text= dt.Rows[0]["tel"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtFax.Text = dt.Rows[0]["Fax"].ToString();
                txtCreateuser.Text = dt.Rows[0]["cruser"].ToString();
                txtCreatedate.Text = dt.Rows[0]["crdate"].ToString();
                cb_buyer.Text = dt.Rows[0]["Buyer"].ToString();
                cb_class.Text = dt.Rows[0]["Purvalue"].ToString();
                cb_deliverytype.Text = dt.Rows[0]["wrType"].ToString();
                cb_Gltype.Text = dt.Rows[0]["gltype"].ToString();
                cb_pmterm.Text= dt.Rows[0]["termscode"].ToString();
                cb_settlement.Text = dt.Rows[0]["jsfs"].ToString();
                cb_tax.SelectedIndex = int.Parse(dt.Rows[0]["taxid"].ToString());
                cb_currency.Text = dt.Rows[0]["Hb"].ToString();
                txtBankname.Text= dt.Rows[0]["vendbank"].ToString();
                txtAccnumber.Text = dt.Rows[0]["vendaccountno"].ToString();
                txtbrand.Text = dt.Rows[0]["vendbankbrand"].ToString();
                txtVAT.Text = dt.Rows[0]["VendVATcode"].ToString();
                chk_deactive.Checked= Convert.ToBoolean(Convert.ToInt16((dt.Rows[0]["status"].ToString())));
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            frmBrowse b = new frmBrowse("SUP",this);
            if (!(System.Windows.Forms.Application.OpenForms["Main"] as Main).CheckOpened(b.Name))
            {
                b.Show();
            }
            else
            {
                b.BringToFront();
            }
            txtSupno.ReadOnly = true;
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            dataGridView1.DoubleBuffered(true);
            cb_buyer.DataSource = Pur.get_all_purchase_staff();
            cb_buyer.DisplayMember = "Userid";
            cb_settlement.DataSource = Pur.get_pmterm("settlement");
            cb_settlement.DisplayMember = "postvalue";
            cb_pmterm.DataSource= Pur.get_pmterm("pm term");
            cb_pmterm.DisplayMember = "postvalue";
            cb_deliverytype.DataSource = Pur.get_pmterm("delivery type");
            cb_deliverytype.DisplayMember = "postvalue";
            cb_currency.DataSource = Pur.get_pmterm("currency");
            cb_currency.DisplayMember = "postvalue";
            cb_Gltype.DataSource = Pur.get_pmterm("gl type");
            cb_Gltype.DisplayMember = "postvalue";
            cb_tax.DataSource = Pur.get_tax();
            cb_tax.DisplayMember = "taxid";
            cb_tax.DisplayMember = "GroupDesc";
            Extensions.set_grid_style(dataGridView1);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Pur.check_exist_supplier(txtSupno.Text.Trim()))
                {
                    if (igni.check_user_permission(LoginInfo.username, "frmSupplier", "Fcreate"))
                        new_supplier();
                    else
                        MessageBox.Show("You Do not have permission to proceed this action!" + Environment.NewLine + "Bạn không có quyền thực hiện thao tác này!", "Permission Required!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (igni.check_user_permission(LoginInfo.username, "frmSupplier", "Fupdate"))
                    {
                        update_suplier();
                        //MessageBox.Show("Save " + txtSupno.Text + " Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("You Do not have permission to proceed this action" + Environment.NewLine + "Bạn không có quyền thực hiện thao tác này!", "Permission Required!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                //string temp = txtSupno.Text;
                //btn_reset_Click(sender, e);
                Pur.get_supplier_by_supplierno(txtSupno.Text);
            }
            catch (Exception ext)
            {
                Igni i = new Igni();
                i.update_user_errlog(LoginInfo.username
                    , this.Name
                    , ext.Message.ToString()
                    , DateTime.Now.ToString());
                MessageBox.Show(ext.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Main.ResetAllControls(groupBox1);
            Main.ResetAllControls(groupBox2);
            Main.ResetAllControls(groupBox3);
            frmSupplier_Load(sender, e);
            txtSupno.ReadOnly = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to delete "+txtSupno.Text+"?", "Delete Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                if (igni.check_user_permission(LoginInfo.username, "frmSupplier", "Fdelete"))
                {
                    Pur.delete_supplier(txtSupno.Text.Trim());
                }
                else
                    MessageBox.Show("You Do not have permission to proceed this action" + Environment.NewLine + "Bạn không có quyền thực hiện thao tác này!", "Permission Required!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (txtSearch.Text.Trim() != "")
            //{
                dataGridView1.DataSource = Pur.search_supplier(txtSearch.Text.Trim());
            //}
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            Extensions.Export(dt, "SMCL SUPPLIERS LIST("+DateTime.Now+")");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmSupplier_Paint(object sender, PaintEventArgs e)
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

        private void txtSupno_TextChanged(object sender, EventArgs e)
        {
            if (txtSupno.Text.Trim() == "")
                return;
            get_supplier_by_supplierno(txtSupno.Text);
        }

        private void txtSupno_Leave(object sender, EventArgs e)
        {
            txtSupno.ReadOnly = true;

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
