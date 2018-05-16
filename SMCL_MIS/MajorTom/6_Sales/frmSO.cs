using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMCL_MIS
{
    public partial class frmSO : Form
    {
        DataTable to_delete = new DataTable();
        GC_Sales s = new GC_Sales();
        Igni i = new Igni();
        DateTimePicker dtp = new DateTimePicker();
        Rectangle _Rectangle;

        public frmSO()
        {
            InitializeComponent(); 
        }
        private void dtp_Click(object sender, EventArgs e)
        {
            dg_SoLine.CurrentCell.Value = dtp.Value.ToString("yyyy-MM-dd");
        }
        private void dtp_TextChange(object sender, EventArgs e)
        {
            //dg_SoLine.CurrentCell.Value = dtp.Value.ToString("yyyy-MM-dd");
        } 

        public void get_customer_by_customerno(string cusno)
        {
            DataTable dt;
            cbShipto.DataSource = s.Get_shiploc_by_shiptype("shipto");
            cbShipto.DisplayMember = "cuslocto";
            cbShipFrom.DataSource = s.Get_shiploc_by_shiptype("shipfrom");
            cbShipFrom.DisplayMember = "cuslocto";
            dt = s.get_customer_by_customerno(cusno);
            if (dt.Rows.Count > 0)
            {
                txtCustomerId.Text = dt.Rows[0]["Customer_id"].ToString();
                txtCustomername.Text = dt.Rows[0]["Customer_Name"].ToString();
                txtCurrency.Text = dt.Rows[0]["Currendcy"].ToString();
                txtPmterm.Text = dt.Rows[0]["Customer_terms"].ToString();
                cbShipFrom.Text = dt.Rows[0]["ShipFrom"].ToString();
                cbShipto.Text = dt.Rows[0]["ShipTO"].ToString();
            }
        }

        public void sum()
        {
            if (Extensions.EmptyIfNull(dg_SoLine[1, 0].Value) != "")
            {
                float amount = 0;
                int qty = 0;
                for (int i = 0; i < dg_SoLine.Rows.Count; ++i)
                {
                    if (Extensions.EmptyIfNull(dg_SoLine[1, i].Value) != "")
                    {
                        amount += float.Parse(Extensions.EmptyIfNull(dg_SoLine[6, i].Value));
                        qty += int.Parse(dg_SoLine.Rows[i].Cells["oqtyCol"].Value.ToString());
                    }
                }
                txtTotalAmount.Text = amount.ToString("C", new CultureInfo("en-US"));
                txtTotalQty.Text = qty.ToString("N", new CultureInfo("en-US"));
                txtTotalAmount.BackColor = txtTotalQty.BackColor = Color.FromArgb(255, 238, 204);
                txtTotalAmount.Font = txtTotalQty.Font = new Font(txtTotalAmount.Font.Name, 10, FontStyle.Italic);
            }
        }

        public void get_so_by_sono(string sono)
        {
            DataTable head;
            dg_SoLine.AutoGenerateColumns = false;

            if (sono == "Empty") { dg_SoLine.DataSource = s.emptyline(); }
            else
            {
                dg_SoLine.DataSource = s.Get_so_line_by_sono(sono);
                head = s.Get_so_head_by_sono(sono);

                if (head.Rows.Count > 0)
                {
                    txtSoNo.Text = head.Rows[0]["sono"].ToString();
                    cbSotype.Text = head.Rows[0]["SOType"].ToString();
                    dSoDate.Text = head.Rows[0]["Odate"].ToString();
                    txtRemark.Text = head.Rows[0]["Refno"].ToString();
                    txtCustomername.Text = head.Rows[0]["CustPO"].ToString();
                    txtCurrency.Text = "";
                    txtPmterm.Text = head.Rows[0]["RecTerms"].ToString();
                    cbShipFrom.Text = head.Rows[0]["ShipFrom"].ToString();
                    cbShipto.Text = head.Rows[0]["ShipTOC"].ToString();
                    txtStatus.Text = head.Rows[0]["Status"].ToString();
                    txtCreatedDate.Text = head.Rows[0]["CrDate"].ToString();
                    txtCreateUser.Text = head.Rows[0]["CrUser"].ToString();
                    txtApproveDate.Text = head.Rows[0]["AppDate"].ToString();
                    txtApproveUser.Text = head.Rows[0]["Appuser"].ToString();
                }

                dg_SoLine.Columns["soCol"].DataPropertyName = "SODNO";
                dg_SoLine.Columns["lineCol"].DataPropertyName = "line";
                dg_SoLine.Columns["partCol"].DataPropertyName = "partno";
                dg_SoLine.Columns["partname"].DataPropertyName = "partname";
                dg_SoLine.Columns["modelCol"].DataPropertyName = "CustXH";
                dg_SoLine.Columns["oqtyCol"].DataPropertyName = "OrdQty";
                dg_SoLine.Columns["amountCol"].DataPropertyName = "Amount";
                dg_SoLine.Columns["priceCol"].DataPropertyName = "Price";
                dg_SoLine.Columns["shipdateCol"].DataPropertyName = "ShipDate";
                dg_SoLine.Columns["shippedCol"].DataPropertyName = "ShipQty";
                dg_SoLine.Columns["shiplocCol"].DataPropertyName = "Class";
                dg_SoLine.Columns["remarkCol"].DataPropertyName = "remark";
                dg_SoLine.Columns["dicusCol"].DataPropertyName = "shiploc";
                dg_SoLine.Columns["CustPO"].DataPropertyName = "sod_CustPO";
                dg_SoLine.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dg_SoLine.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                sum();
            }
            set_button();

        }

        private void set_button()
        {
            btnApprove.Enabled = false;
            btnSave.Enabled = false;
            if (txtStatus.Text == "Draft")
            {
                btnApprove.Text = "Approve";
                lbl_approveuser.Text = "UnApprove By";
                lbl_approvedate.Text = "UnApprove Date";
            }
            else if (txtStatus.Text == "Approval")
            {
                lbl_approveuser.Text = "Approve By";
                lbl_approvedate.Text = "Approve Date";
                btnApprove.Text = "UnApprove";
            }

            //approve
            if (i.check_user_permission(LoginInfo.username, "frmSO", "Fapprove"))
            {
                btnApprove.Enabled = true;
            }

            if (i.check_user_permission(LoginInfo.username, "frmSO", "Fcreate") &&
                btnApprove.Text != "UnApprove" ||
                i.check_user_permission(LoginInfo.username, "frmSO", "Fupdate") &&
                btnApprove.Text != "UnApprove")
            {
                btnSave.Enabled = true;
            }
        }

        private void btnSearchSO_Click(object sender, EventArgs e)
        {
            frmBrowse b = new frmBrowse("SO", this);
            if (!(System.Windows.Forms.Application.OpenForms["Main"] as Main).CheckOpened(b.Name))
            {
                b.Show();
            }
            else
            {
                b.BringToFront();
            }
            txtSoNo.ReadOnly = true;
        }

        private void dg_SoLine_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            dtp.Visible = false;

        }

        private void dg_SoLine_Scroll(object sender, ScrollEventArgs e)
        {

            dtp.Visible = false;
        }

        private void dg_SoLine_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (txtSoNo.Text.Trim() == "")
            {
                DialogResult dialogResult = MessageBox.Show("Please Input SONO", "SONO IS EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                txtSoNo.ReadOnly = true;
            }
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                // i.update_user_errlog(LoginInfo.username =
                //Extensions.get_select_row_color();
                switch (dg_SoLine.Columns[e.ColumnIndex].Name)
                {
                    case "ShipdateCol":

                        _Rectangle = dg_SoLine.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //  
                        dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height); //  
                        dtp.Location = new Point(_Rectangle.X, _Rectangle.Y); //  
                        dtp.Visible = true;

                        dg_SoLine.CurrentCell.Value = dtp.Value.ToString("yyyy-MM-dd");
                        break;
                    default:
                        dtp.Visible = false;
                        break;
                }

            }
        }

        public void part_no_togv(string part_no)
        {
            dg_SoLine[2, dg_SoLine.CurrentRow.Index].Value = part_no;
            DataTable dt = dg_SoLine.DataSource as DataTable;

            DataRow dr = dt.NewRow();
            if (dg_SoLine.CurrentRow.Index + 1 == dg_SoLine.Rows.Count)
                dt.Rows.Add(dr);
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            frmBrowse b = new frmBrowse("CUS", this);
            if (!(System.Windows.Forms.Application.OpenForms["Main"] as Main).CheckOpened(b.Name))
            {
                b.Show();
            }
            else
            {
                b.BringToFront();
            }
        }

        private bool check_input_line()
        {
            bool t = true;
            for (int i = 0; i < dg_SoLine.Rows.Count; i++)
            {
                if (Extensions.EmptyIfNull(dg_SoLine.Rows[i].Cells["LineCol"].Value) != "")
                {

                    if (!Extensions.check_int(dg_SoLine.Rows[i].Cells["oqtyCol"].Value.ToString()) || // if orderqty not int
                        !Extensions.check_float(dg_SoLine.Rows[i].Cells["priceCol"].Value.ToString()) || // if price not float
                        dg_SoLine.Rows[i].Cells["partCol"].Value == null ||
                     dg_SoLine.Rows[i].Cells["oqtyCol"].Value == null ||
                     dg_SoLine.Rows[i].Cells["priceCol"].Value == null ||
                     dg_SoLine.Rows[i].Cells["shipdateCol"].Value == null)
                    {
                        dg_SoLine.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 209, 209);
                        t = false;
                    }
                    else
                        dg_SoLine.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
            return t;
        }

        private bool check_input_head()
        {
            if (dg_SoLine.Rows.Count > 0)
            {
                if ((System.Windows.Forms.Application.OpenForms["Main"] as Main).check_empty(txtSoNo) &&
                (System.Windows.Forms.Application.OpenForms["Main"] as Main).check_empty(cbSotype) &&
                (System.Windows.Forms.Application.OpenForms["Main"] as Main).check_empty(txtCustomername))
                {
                    return true;
                }
                else
                {
                    return false;

                }

            }
            else
                return false;

        }

        private bool check_exist_line_number(int number)
        {
            for (int i = 0; i < dg_SoLine.Rows.Count; i++)
            {
                if (int.Parse(dg_SoLine[1, i].Value.ToString()) == number)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (check_input_head() && check_input_line())
            {
                try
                {
                    if (!s.check_exist_soh(txtSoNo.Text))
                    {
                        s.new_soH(txtSoNo.Text, dSoDate.Value, "", cbSotype.Text, "",
                                  txtCustomername.Text, "", txtPmterm.Text, cbShipFrom.Text, cbShipto.Text,
                                  "", "", "", "", "", "", 0, 0, "", DateTime.Now, "", DateTime.Now);
                    }
                    else
                    {
                        s.update_soH(txtSoNo.Text
                            , Extensions.EmptyIfNull(cbSotype.Text)
                            , txtCustomername.Text
                            , ""
                            , Extensions.EmptyIfNull(txtPmterm.Text)
                            , Extensions.EmptyIfNull(cbShipFrom.Text)
                            , Extensions.EmptyIfNull(cbShipto.Text)
                            , Extensions.EmptyIfNull(txtRemark.Text)
                            , DateTime.Parse(dSoDate.Text));

                    }
                    for (int i = 0; i < dg_SoLine.Rows.Count; i++)
                    {

                        if (Extensions.EmptyIfNull(dg_SoLine.Rows[i].Cells["LineCol"].Value) != "")
                        {
                            string sod = txtSoNo.Text + "-" + int.Parse(dg_SoLine.Rows[i].Cells["LineCol"].Value.ToString()).ToString("D2");
                            if (!s.check_exist_sod(sod) && s.check_exist_soh(txtSoNo.Text))// if not exist soline and exsist soh
                            {
                                s.new_soD(txtSoNo.Text,
                            int.Parse(dg_SoLine.Rows[i].Cells["LineCol"].Value.ToString()),
                            sod,
                            Extensions.EmptyIfNull(dg_SoLine.Rows[i].Cells["shiplocCol"].Value),
                            Extensions.EmptyIfNull(dg_SoLine.Rows[i].Cells["partCol"].Value),
                            Extensions.EmptyIfNull(dg_SoLine.Rows[i].Cells["modelCol"].Value),
                            int.Parse(dg_SoLine.Rows[i].Cells["oqtyCol"].Value.ToString()),
                            float.Parse(dg_SoLine.Rows[i].Cells["priceCol"].Value.ToString()),
                            DateTime.Parse(dg_SoLine.Rows[i].Cells["shipdateCol"].Value.ToString()),
                            Extensions.EmptyIfNull(dg_SoLine.Rows[i].Cells["dicusCol"].Value),
                            Extensions.EmptyIfNull(dg_SoLine.Rows[i].Cells["remarkCol"].Value),
                            "", 0, 0, "", "", "", "", "", 0, 0
                            , Extensions.EmptyIfNull(dg_SoLine.Rows[i].Cells["CustPO"].Value));
                            }
                            if (s.check_exist_sod(sod) && s.check_exist_soh(txtSoNo.Text)) // if exsist soline and soh
                            {
                                s.update_soD(sod, Extensions.EmptyIfNull(dg_SoLine.Rows[i].Cells["shiplocCol"].Value)
                                    , Extensions.EmptyIfNull(dg_SoLine.Rows[i].Cells["partCol"].Value)
                                    , Extensions.EmptyIfNull(dg_SoLine.Rows[i].Cells["modelCol"].Value)
                                    , int.Parse(dg_SoLine.Rows[i].Cells["oqtyCol"].Value.ToString())
                                    , float.Parse(dg_SoLine.Rows[i].Cells["priceCol"].Value.ToString())
                                    , DateTime.Parse(dg_SoLine.Rows[i].Cells["shipdateCol"].Value.ToString())
                                    , Extensions.EmptyIfNull(dg_SoLine.Rows[i].Cells["dicusCol"].Value)
                                    , Extensions.EmptyIfNull(dg_SoLine.Rows[i].Cells["remarkCol"].Value)
                                    , Extensions.EmptyIfNull(dg_SoLine.Rows[i].Cells["CustPO"].Value));
                            }
                        }
                    }
                    if (to_delete.Rows.Count > 0)
                    {
                        s.delete_sod(to_delete);
                    }
                    get_so_by_sono(txtSoNo.Text);
                    MessageBox.Show("Saved SO:" + txtSoNo.Text, "Completed Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else { MessageBox.Show(Extensions.warning_missingfield); }
        }

        private void get_so_type()
        {
            cbSotype.DataSource = s.get_so_type();
            cbSotype.DisplayMember = "sotype_name";
            cbSotype.SelectedIndex = 0;
        }

        private void dg_SoLine_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                dg_SoLine.BeginEdit(true);
                switch (dg_SoLine.Columns[e.ColumnIndex].Name)
                {
                    case "partCol":

                        if (e.RowIndex == dg_SoLine.NewRowIndex || Extensions.EmptyIfNull(dg_SoLine[1, e.RowIndex].Value) == "" && e.RowIndex > 0)
                        {
                            dg_SoLine[1, e.RowIndex].Value = int.Parse(dg_SoLine[1, e.RowIndex - 1].Value.ToString()) + 1;
                        }
                        else if (e.RowIndex == 0)
                        {
                            dg_SoLine[1, e.RowIndex].Value = 1;
                        }
                        frmBrowse b = new frmBrowse("PART", this);
                        if (!(System.Windows.Forms.Application.OpenForms["Main"] as Main).CheckOpened(b.Name))
                        {
                            b.Show();
                        }
                        else
                        {
                            b.BringToFront();
                        }
                        break;
                }
            }
        }

        private void set_datagridview_combo()
        {
            DataGridViewComboBoxColumn dcombo = (DataGridViewComboBoxColumn)dg_SoLine.Columns["shiplocCol"];
            dcombo.DataSource = s.Get_shiploc_by_shiptype("shipto");
            dcombo.DisplayMember = "cuslocto";
        }
        private void set_default_col_color()
        {
            dg_SoLine.RowsDefaultCellStyle.SelectionForeColor =
            dg_SoLine.DefaultCellStyle.SelectionForeColor = Color.Black;
            dg_SoLine.RowsDefaultCellStyle.SelectionBackColor =
            dg_SoLine.DefaultCellStyle.SelectionBackColor = Extensions.get_select_row_color(); 

            dg_SoLine.Columns["lineCol"].DefaultCellStyle.BackColor =
            dg_SoLine.Columns["partname"].DefaultCellStyle.BackColor =
            dg_SoLine.Columns["amountCol"].DefaultCellStyle.BackColor = Extensions.get_not_editable_col();
            dg_SoLine.Refresh();
        }
        private void frmSO_Load(object sender, EventArgs e)
        {
            dg_SoLine.Controls.Add(dtp);
            dtp.Visible = false;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.TextChanged += new EventHandler(dtp_TextChange);

            dtp.TextChanged += new EventHandler(dtp_Click);
            dtp.CustomFormat = "yyyy-MM-dd";
            set_datagridview_combo();//set datagridview combo 
            get_so_by_sono("empty");// add empty line to datagridview
            to_delete.Columns.Add("sodno", typeof(string));
            get_so_type();
            set_button();
            set_default_col_color();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            to_delete.Columns.Remove("sodno");
            Main.ResetAllControls(groupBox1);
            Main.ResetAllControls(groupBox2);
            Main.ResetAllControls(groupBox3);
            Main.ResetAllControls(this);
            txtSoNo.ReadOnly = false;
            frmSO_Load(sender, e);
        }

        private void dg_SoLine_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            //to_delete.Columns.Add("sodno", typeof(string));
            to_delete.Rows.Add(new Object[] { dg_SoLine[0, e.Row.Index].Value });
        }

        public void delete_so()
        {
            if (txtSoNo.Text.Trim() != "" && btnApprove.Text != "Unapprove")
            {
                if (MessageBox.Show("Are you sure want to delete:" + txtSoNo.Text, "DELETE SO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    s.delete_so(txtSoNo.Text);
                    Main.ResetAllControls(groupBox1);
                    Main.ResetAllControls(groupBox2);
                    Main.ResetAllControls(groupBox3);
                    Main.ResetAllControls(this);
                    txtSoNo.ReadOnly = false;
                }
            }
            else
            {
                MessageBox.Show("Cannot Delete Approved SO", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cbShipto_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dg_SoLine.Rows.Count; i++)
            {
                dg_SoLine["shiplocCol", i].Value = cbShipto.Text;
            }
        }

        private void dg_SoLine_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dg_SoLine_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            // i.update_user_errlog(LoginInfo.username = Color.White;
            //set_default_col_color();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to " + btnApprove.Text + " SO:" + txtSoNo.Text + "?", "Approve SO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (txtStatus.Text == "Draft")
                {
                    s.approve_so(txtSoNo.Text, "Approval", LoginInfo.username, DateTime.Now);
                }
                else if (txtStatus.Text == "Approval")
                {
                    s.approve_so(txtSoNo.Text, "Draft", LoginInfo.username, DateTime.Now);
                }
            }

            get_so_by_sono(txtSoNo.Text.Trim());
        }

        private void txtSoNo_MouseLeave(object sender, EventArgs e)
        {


        }

        private void txtSoNo_Leave(object sender, EventArgs e)
        {
            if (txtSoNo.Text.Trim() == "")
                return;
            else
            {
                get_so_by_sono(txtSoNo.Text.Trim());
            }

        }
    }
}
