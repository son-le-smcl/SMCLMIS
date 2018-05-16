
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMCL_MIS
{
    public partial class frmPO : Form
    {
        DataTable to_delete = new DataTable();
        GC_Purchasing Pur = new GC_Purchasing();
        Igni igni = new Igni();
        DateTimePicker dtp = new DateTimePicker();
        Rectangle _Rectangle;
        DataTable part_with_quote = new DataTable();
        public frmPO()
        {
            InitializeComponent();
        }

        public bool check_input()
        {
            Main m = new Main();
            bool t = true;
            if (!m.check_empty(txtSuplierno))
            {
                MessageBox.Show("Please Input all required field", "Missing required field!", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                return false;
            }
            for (int i = 0; i < DG_poline.Rows.Count; i++)
            {
                string error = "";
                if (Extensions.EmptyIfNull(DG_poline.Rows[i].Cells["Line"].Value) != "")
                {
                    if (Extensions.EmptyIfNull((DG_poline.Rows[i].Cells["PartNO"].Value)) == "")
                    {
                        error += "Mã vật tư không được trống!" + Environment.NewLine; 
                    }
                    if (Extensions.check_if_float(DG_poline.Rows[i].Cells["ORDERED"].Value.ToString()) <= 0)
                    {
                        error += "Số lượng mua phải >0!" + Environment.NewLine;
                    }
                    if (Extensions.EmptyIfNull((DG_poline.Rows[i].Cells["Price"].Value)) == "")
                    {
                        error += "Giá không được trống!" + Environment.NewLine;
                    }
                    if (Extensions.EmptyIfNull((DG_poline.Rows[i].Cells["RecDate"].Value)) == "")
                    {
                        error += "Ngày nhận dự kiến không được trống!" + Environment.NewLine;
                    }
                    if (Extensions.EmptyIfNull((DG_poline.Rows[i].Cells["POXSTK"].Value)) == "")
                    {
                        error += "Giá trị qui đổi đơn vị tính không được trống!" + Environment.NewLine;
                    }
                    if (Extensions.EmptyIfNull((DG_poline.Rows[i].Cells["LOC"].Value)) == "")
                    {
                        error += "Kho không được trống!" + Environment.NewLine;
                    }
                    if (Extensions.EmptyIfNull((DG_poline.Rows[i].Cells["Quoteno"].Value)) == "")
                    {
                        error += "Mã báo giá không được trống!" + Environment.NewLine;
                    }
                    //if (Extensions.EmptyIfNull((DG_poline.Rows[i].Cells["PartNO"].Value)) == ""
                    //    || Extensions.check_if_float(DG_poline.Rows[i].Cells["ORDERED"].Value.ToString()) <=0
                    //    || Extensions.EmptyIfNull((DG_poline.Rows[i].Cells["Price"].Value)) == ""
                    //    || Extensions.EmptyIfNull((DG_poline.Rows[i].Cells["RecDate"].Value)) == ""
                    //    || Extensions.EmptyIfNull((DG_poline.Rows[i].Cells["POXSTK"].Value)) == ""
                    //    //|| Extensions.EmptyIfNull((DG_poline.Rows[i].Cells["JOBNO"].Value)) == ""
                    //    || Extensions.EmptyIfNull((DG_poline.Rows[i].Cells["LOC"].Value)) == ""
                    //    || Extensions.EmptyIfNull((DG_poline.Rows[i].Cells["Quoteno"].Value)) == "")
                    //{
                    //    DG_poline.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 209, 209);
                    //    t = false;
                    //}
                    if (error != "")
                    {

                        DG_poline.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 209, 209);
                        t = false;
                        DG_poline[1, i].ToolTipText = error;
                    }
                    else
                        DG_poline.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
            if (!t)
            {
                MessageBox.Show(Extensions.warning_missingfield
                    , "Missing required field!"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Hand);
            }
            return t;
        }

        private string generate_pono()
        {
            string currentid = "PO" + txtSuplierno.Text.Substring(0, 2) + DateTime.Now.ToString("yyMM");
            string newestid = Pur.get_mostrecent_PONO(txtSuplierno.Text.Substring(0, 2));
            if (currentid == newestid.Substring(0, newestid.Length - 4))// still in same year, month
            {
                return currentid + (int.Parse(newestid.Substring(newestid.Length - 3)) + 1).ToString("0000");//add 1
            }
            else
                return currentid + "0001";//start new sequence

        }

        private void update_po()
        {
            Pur.update_poh(txtPono.Text
                , cb_potype.SelectedValue.ToString()
                , txtSuplierno.Text
                , 0
                , "", txtWorkshop.Text
                , dp_podate.Value
                , int.Parse(txttaxid.Text.ToString())
                , txtRemark.Text
                , 0
                , ""
                , cbTptype.Text);
           
        }

        private void update_pod()
        {
            for (int i = 0; i < DG_poline.Rows.Count; i++)
            {
                if (Extensions.EmptyIfNull(DG_poline.Rows[i].Cells["Line"].Value) != "")
                {
                    if (!Pur.check_exist_POD(txtPono.Text, int.Parse(DG_poline["Line", i].Value.ToString())))
                    {
                        new_pod();
                    }
                    else
                    {
                        Pur.update_pod(txtPono.Text
                       , int.Parse(DG_poline["Line", i].Value.ToString())
                       , DG_poline["Partno", i].Value.ToString()
                       , float.Parse(DG_poline["ORDERED", i].Value.ToString())
                       , DateTime.Parse(DG_poline["RecDate", i].Value.ToString())
                       , int.Parse(DG_poline["POXSTK", i].Value.ToString())
                       , DG_poline["Jobno", i].Value.ToString()
                       , DG_poline["remark", i].Value.ToString()
                       , DG_poline["Loc", i].Value.ToString()
                       , float.Parse(DG_poline["Price", i].Value.ToString())
                       , DG_poline["Quoteno", i].Value.ToString()
                        , txtCurrency.Text
                        , Extensions.EmptyIfNull(DG_poline["UOM", i].Value));
                    }

                }
            }
        }

        private void new_pod()
        {
            for (int i = 0; i < DG_poline.Rows.Count; i++)
            {
                if (Extensions.EmptyIfNull(DG_poline.Rows[i].Cells["Line"].Value) != "")
                {
                    Pur.new_pod(txtPono.Text
                    , int.Parse(DG_poline["Line", i].Value.ToString())
                    , Extensions.EmptyIfNull(DG_poline["Partno", i].Value)
                    , float.Parse(DG_poline["ORDERED", i].Value.ToString())
                    , DateTime.Parse(DG_poline["RecDate", i].Value.ToString())
                    , int.Parse(DG_poline["POXSTK", i].Value.ToString())
                    , Extensions.EmptyIfNull(DG_poline["Jobno", i].Value)
                    , Extensions.EmptyIfNull(DG_poline["Remark", i].Value)
                    , Extensions.EmptyIfNull(DG_poline["Loc", i].Value)
                    , float.Parse(DG_poline["Price", i].Value.ToString())
                    , Extensions.EmptyIfNull(DG_poline["Quoteno", i].Value)
                    , txtCurrency.Text
                    , Extensions.EmptyIfNull(DG_poline["UOM", i].Value));
                }
            }
        }

        private void new_po()
        {
            txtPono.Text = generate_pono();

            Pur.new_Poh(txtPono.Text, cb_potype.SelectedValue.ToString(), txtSuplierno.Text, 0, "", txtWorkshop.ValueMember, ""
                , dp_podate.Value, int.Parse(txttaxid.Text.ToString()), txtRemark.Text, 0, LoginInfo.username,
                DateTime.Now, "", "1900-01-01",
                "", "",cbTptype.Text); 
        }

        public void get_supplier_by_supplierno(string supno)
        {
            DataTable dt = new DataTable();
            dt = Pur.get_supplier_by_supplierno(supno);
            txtSuplierno.Text = dt.Rows[0]["vendid"].ToString();
            txtsupname.Text = dt.Rows[0]["vendname"].ToString();
            txttax.Text = dt.Rows[0]["TAXNAME"].ToString();
            txtsupclass.Text = dt.Rows[0]["PURVALUE"].ToString();
            txtCurrency.Text = dt.Rows[0]["hb"].ToString();
            txtPmterm.Text = dt.Rows[0]["TERMSCODE"].ToString();
            txttaxid.Text = dt.Rows[0]["taxid"].ToString(); 
            txttype.Text = dt.Rows[0]["wrType"].ToString();
        }

        private void load_cb(string str)
        {
            cbTptype.DataSource = Pur.get_pmterm("transport_type");
            cbTptype.DisplayMember = "postvalue";
            cbTptype.ValueMember = "postvalue";

            cb_potype.DataSource = Pur.get_pmterm("po_type");
            cb_potype.DisplayMember = "name";
            cb_potype.ValueMember = "name";

            txtWorkshop.DataSource = Pur.get_loch();
            txtWorkshop.DisplayMember = "LOCNO" + ", " + "Locname";
            txtWorkshop.ValueMember = "LOCNO";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void get_po_by_pono(string pono)
        {
            
            DataTable head = new DataTable();
            DataTable line = new DataTable();
            if (pono == "Empty") { line = Pur.emptyline(); }
            else
            {
                line = Pur.get_po_line_by_pono(pono);
                head = Pur.get_po_head_by_pono(pono);
                txtPono.Text = head.Rows[0]["PONO"].ToString();
                txtStatus.Text = head.Rows[0]["status"].ToString();
                txtRemark.Text = head.Rows[0]["remark"].ToString();
                dp_podate.Text = head.Rows[0]["ODate"].ToString();
                txtSuplierno.Text = head.Rows[0]["VendID"].ToString();
                txtsupname.Text = head.Rows[0]["Vendname"].ToString();
                txttax.Text = head.Rows[0]["tax"].ToString();
                txttaxid.Text = head.Rows[0]["TaxID"].ToString();
                txtsupclass.Text = head.Rows[0]["purvalue"].ToString();
                txtPmterm.Text = head.Rows[0]["TermsCode"].ToString();
                txtappuser.Text = head.Rows[0]["appuser"].ToString();
                txtApproveDate.Text = head.Rows[0]["appdate"].ToString();
                txtCreatedDate.Text = head.Rows[0]["crdate"].ToString();
                txtCreateuser.Text = head.Rows[0]["cruser"].ToString();
                txtCurrency.Text = head.Rows[0]["HB"].ToString();
                txtTpDes.Text = head.Rows[0]["JSFS"].ToString();
                cbTptype.Text = head.Rows[0]["JSFS"].ToString();
                txtWorkshop.Text = head.Rows[0]["Sipto1"].ToString();
                txtWSname.Text = head.Rows[0]["Sipto1"].ToString();
                cb_potype.Text = head.Rows[0]["PoType"].ToString();
            }
            DG_poline.AutoGenerateColumns = false;
            DG_poline.DataSource = line;
            DG_poline.Columns["PONO"].DataPropertyName = "PONO";
            DG_poline.Columns["Line"].DataPropertyName = "Line";
            DG_poline.Columns["PartNO"].DataPropertyName = "PartNO";
            DG_poline.Columns["Description"].DataPropertyName = "Description";
            DG_poline.Columns["ORDERED"].DataPropertyName = "ORDERED";
            DG_poline.Columns["RECEIVED"].DataPropertyName = "RECEIVED";
            DG_poline.Columns["UOM"].DataPropertyName = "UOM";
            DG_poline.Columns["Price"].DataPropertyName = "Price";
            DG_poline.Columns["RecDate"].DataPropertyName = "RecDate";
            DG_poline.Columns["POXSTK"].DataPropertyName = "POXSTK";
            DG_poline.Columns["Quoteno"].DataPropertyName = "Quoteno";
            DG_poline.Columns["JOBNO"].DataPropertyName = "JOBNO";
            DG_poline.Columns["Remark"].DataPropertyName = "Remark";
            DG_poline.Columns["Loc"].DataPropertyName = "Loc";
            DG_poline.Columns["Amount"].DataPropertyName = "Amount";


            DG_poline.Columns["POXSTK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; 
            DG_poline.Columns["Line"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DG_poline.Columns["PartNO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DG_poline.Columns["JOBNO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            set_button();
            sum();
        }

        private void btn_searchPO_Click(object sender, EventArgs e)
        {
            frmBrowse b = new frmBrowse("PO", this);
            if (!(System.Windows.Forms.Application.OpenForms["Main"] as Main).CheckOpened(b.Name))
            {
                b.Show();
            }
            else
            {
                b.BringToFront();
            }
        }

        private void btn_search_supplier_Click(object sender, EventArgs e)
        { 
            frmBrowse b = new frmBrowse("SUP", this);
            if (!(System.Windows.Forms.Application.OpenForms["Main"] as Main).CheckOpened(b.Name))
            {
                b.Show();
            }
            else
            {
                b.BringToFront();
            }
            if (txtPono.Text != ""&& txtStatus.Text=="Draft")
            {
                DG_poline.DataSource = Pur.emptyline();
            }
            set_button();

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtPono.Text == "") 
                return; 
            ReportViewer rv = new ReportViewer();
            rv.Show();
            rv.set_report_datasource(Pur.get_po_line_by_pono(txtPono.Text));
           
        }

        private void frmPO_Load(object sender, EventArgs e)
        {
            load_cb("");
            DG_poline.DoubleBuffered(true);
            to_delete.Columns.Add("line", typeof(string));
            DG_poline.Controls.Add(dtp);
            dtp.Visible = false;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.TextChanged += new EventHandler(dtp_TextChange);
            get_po_by_pono("Empty"); set_default_col_color();
        }


        private void set_default_col_color()
        {
            DG_poline.RowsDefaultCellStyle.SelectionForeColor =
            DG_poline.DefaultCellStyle.SelectionForeColor = Color.Black;
            DG_poline.RowsDefaultCellStyle.SelectionBackColor =
            DG_poline.DefaultCellStyle.SelectionBackColor = Extensions.get_select_row_color();
             
            DG_poline.Columns["Line"].DefaultCellStyle.BackColor =
            DG_poline.Columns["Description"].DefaultCellStyle.BackColor =
            DG_poline.Columns["RECEIVED"].DefaultCellStyle.BackColor =
            DG_poline.Columns["Price"].DefaultCellStyle.BackColor =
            DG_poline.Columns["POXSTK"].DefaultCellStyle.BackColor =
            DG_poline.Columns["Amount"].DefaultCellStyle.BackColor = Extensions.get_not_editable_col();
            DG_poline.Refresh();
        }

        private void dtp_TextChange(object sender, EventArgs e)
        {
            DG_poline.CurrentCell.Value = dtp.Text.ToString();
        }

        private void set_button()
        {
            btnApprove.Enabled = false;
            btnSave.Enabled = false;
            if (txtStatus.Text == "Draft")// mới tạo
            {
                lbl_appdate.Text = "Unapprove Date";
                lbl_appuser.Text = "Unapprove by";
                btnApprove.Text = "Approve"; 
                btnSave.Enabled = true;
                DG_poline.Enabled = true;
                //btnApprove.Enabled = true;
            } 
            else if (txtStatus.Text == "")// tạo mới
            {
                btnSave.Enabled = true;
                DG_poline.Enabled = true;

            }
            else { //đã approve
                lbl_appdate.Text = "Approve Date";
                lbl_appuser.Text = "Approve by";
                btnApprove.Text = "UnApprove";
                btnSave.Enabled = false;
                DG_poline.Enabled = false;
            }

            if (igni.check_user_permission(LoginInfo.username, this.Name, "Fapprove"))
            {
                btnApprove.Enabled = true;
            }
        }
        private void sum()
        {
            if (Extensions.EmptyIfNull(DG_poline["Line", 0].Value) != "")
            {
                float amount = 0;
                int qty = 0;
                for (int i = 0; i < DG_poline.Rows.Count; ++i)
                {
                    if (Extensions.EmptyIfNull(DG_poline["Line", i].Value) != "")
                    { 
                        amount += float.Parse(Extensions.EmptyIfNull(DG_poline["Amount", i].Value));
                        qty += int.Parse(DG_poline.Rows[i].Cells["ORDERED"].Value.ToString());
                    }
                }
                if (txtCurrency.Text == "VND")
                {
                    txtTotalAmount.Text = amount.ToString("C", new CultureInfo("vi-VN"));
                }
                else { txtTotalAmount.Text = amount.ToString("C", new CultureInfo("en-US")); }

                txtTotalQty.Text = qty.ToString("N", new CultureInfo("en-US"));

                txtTotalAmount.BackColor = txtTotalQty.BackColor = Color.FromArgb(255, 238, 204);
                txtTotalAmount.Font = txtTotalQty.Font = new Font(txtTotalAmount.Font.Name, 10, FontStyle.Italic);
                DG_poline.Columns["Amount"].DefaultCellStyle.Format = "N2";
                DG_poline.Columns["ORDERED"].DefaultCellStyle.Format = "N2"; 
                DG_poline.Columns["RECEIVED"].DefaultCellStyle.Format = "N2";
                DG_poline.Columns["Price"].DefaultCellStyle.Format = "N4";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_input())
                {
                    if (txtPono.Text == "" &&
                        igni.check_user_permission(LoginInfo.username, this.Name, "Fcreate"))
                    {
                        new_po();
                        new_pod();
                    }
                    else if (igni.check_user_permission(LoginInfo.username, this.Name, "Fupdate"))
                    {
                        update_po();
                        update_pod();
                        if (to_delete.Rows.Count > 0)
                        {
                            Pur.delete_pod(to_delete, txtPono.Text);
                        }
                    }
                    else
                    {

                        MessageBox.Show(Extensions.warning_missingpermission
                            , "Permission Required"
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Hand);

                    }
                    get_po_by_pono(txtPono.Text);
                    MessageBox.Show("Save Successful"
                        , txtPono.Text
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                }
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

        private void DG_poline_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                switch (DG_poline.Columns[e.ColumnIndex].Name)
                {
                    case "RecDate":

                        _Rectangle = DG_poline.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //  
                        dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height); //  
                        dtp.Location = new Point(_Rectangle.X, _Rectangle.Y); //  
                        dtp.Visible = true;
                        DG_poline.CurrentCell.Value = dtp.Value.ToString("yyyy-MM-dd");
                        break;
                    default:
                        dtp.Visible = false;
                        break;
                }

            }
        }

        private void DG_poline_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            dtp.Visible = false;
        }

        private void DG_poline_Scroll(object sender, ScrollEventArgs e)
        {
            dtp.Visible = false;
        }

        private bool get_quote_by_partno(string partno)
        {
            DataTable dt = new DataTable();
            dt = Pur.get_quote_by_partno(partno, txtSuplierno.Text);
            if (dt.Rows.Count > 0)
            {
                DG_poline["Price", DG_poline.CurrentRow.Index].Value = dt.Rows[0]["Price"].ToString(); 
                DG_poline["Quoteno", DG_poline.CurrentRow.Index].Value = dt.Rows[0]["BJID"].ToString();
                DG_poline["POXSTK", DG_poline.CurrentRow.Index].Value = dt.Rows[0]["rate"].ToString();
                DG_poline["UOM", DG_poline.CurrentRow.Index].Value = dt.Rows[0]["UOM"].ToString();
                return true;
            }
            else
            {
                MessageBox.Show("Cannot find Quotation for this PartNumber!" + Environment.NewLine +
                    "Không tìm được báo giá của Vật liệu này!", partno, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        public void part_no_togv(string part_no)
        {
            if (get_quote_by_partno(part_no))
            {
                DG_poline["PartNO", DG_poline.CurrentRow.Index].Value = part_no;
                DataTable dt = DG_poline.DataSource as DataTable;
                DataRow dr = dt.NewRow();
                if (DG_poline.CurrentRow.Index + 1 == DG_poline.Rows.Count)
                    dt.Rows.Add(dr);
            }
        }

        public void sod_to_grv(string sodno)
        {
            DG_poline["POXSTK", DG_poline.CurrentRow.Index].Value = sodno;
        }

        public void LOCH_to_grv(string loc)
        {
            DG_poline["Loc", DG_poline.CurrentRow.Index].Value = loc;
        }

        private void DG_poline_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                frmBrowse b;
                DG_poline.BeginEdit(true);
                switch (DG_poline.Columns[e.ColumnIndex].Name)
                { 
                    case "PartNO":
                        b = new frmBrowse("PART", this);
                        if (e.RowIndex == DG_poline.NewRowIndex && e.RowIndex > 0 || Extensions.EmptyIfNull(DG_poline["Line", e.RowIndex].Value) == "" && e.RowIndex > 0)
                        {
                            DG_poline["Line", e.RowIndex].Value = int.Parse(DG_poline["Line", e.RowIndex - 1].Value.ToString()) + 1;
                        }
                        else if (e.RowIndex == 0)
                        {
                            DG_poline["Line", e.RowIndex].Value = 1;
                        }
                        if (!(System.Windows.Forms.Application.OpenForms["Main"] as Main).CheckOpened(b.Name))
                        {
                            b.Show();
                        }
                        else
                        {
                            b.BringToFront();
                        }
                        break;
                    case "JOBNO":
                        b = new frmBrowse("SOD", this);
                        if (!(System.Windows.Forms.Application.OpenForms["Main"] as Main).CheckOpened(b.Name))
                        {
                            b.Show();
                        }
                        else
                        {
                            b.BringToFront();
                        }
                        break;
                    case "Loc":
                        b = new frmBrowse("LOCH", this);
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

        private void btn_reset_Click(object sender, EventArgs e)
        {
            to_delete.Columns.Remove("line");
            Main.ResetAllControls(groupBox1);
            Main.ResetAllControls(groupBox2);
            Main.ResetAllControls(groupBox3);
            frmPO_Load(sender,e);
        }

        private void DG_poline_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            to_delete.Rows.Add(new Object[] { DG_poline["Line", e.Row.Index].Value });
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to " + btnApprove.Text + " PO:" + txtPono.Text + "?", "Approve SO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes &&
                    igni.check_user_permission(LoginInfo.username, this.Name, "Fapprove"))
            {
                if (txtStatus.Text == "Draft")
                {
                    Pur.approve_po(txtPono.Text, "Approval", LoginInfo.username, DateTime.Now);
                }
                else if (txtStatus.Text == "Approval")
                {
                    Pur.approve_po(txtPono.Text, "Draft", LoginInfo.username, DateTime.Now);
                }
            }
            else
            {
                MessageBox.Show(Extensions.warning_missingpermission,txtPono.Text
                    ,MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }

            get_po_by_pono(txtPono.Text.Trim());
        }

        private void selectFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtSuplierno.Text == ""||txtStatus.Text!="Draft"&& txtStatus.Text != "")
            {
                MessageBox.Show("Please select Supplier!"+Environment.NewLine+"Vui Lòng Chọn Nhà Cung Cấp");
                return;
            }
           
            DG_poline.DataSource = Extensions.from_excel(openFileDialog1);

            DG_poline.Columns["Partno"].DataPropertyName = "PART NUMBER";
            DG_poline.Columns["ORDERED"].DataPropertyName = "ORDER QTY";
            DG_poline.Columns["RecDate"].DataPropertyName = "DELIVERY DATE";
            DG_poline.Columns["JOBNO"].DataPropertyName = "SO NUMBER";
            DG_poline.Columns["LOC"].DataPropertyName = "RECEIVED WH";
            add_poline_number();
            check_input();
        }

        private void downloadTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Extensions.get_template(@"\\192.168.84.2\Public\MyDriver\SMCL_MIS\import_template\PO_import_template.xlsx", saveFileDialog1);
        }

        private void add_poline_number()
        { 
            for(int i = 0; i < DG_poline.Rows.Count; i++)
            {
                string part_no = DG_poline["Partno", i].Value.ToString();
                //DateTime date= DateTime.Parse( DG_poline["RecDate", i].Value.ToString());
                //string jobno = DG_poline["Rate", i].Value.ToString();
                //string locno = DG_poline["Jobno", i].Value.ToString(); 
                if (!Extensions.check_date(DG_poline["RecDate", i].Value.ToString()))
                { DG_poline["RecDate", i].Value = ""; } 
                if (get_quote_by_partno(part_no))
                { DG_poline["Line", i].Value = i + 1; } 
            }
        }
         

        public void delete_po()
        {
            if (txtPono.Text.Trim() != "" && txtStatus.Text != "Approval")
            {
                if (MessageBox.Show(Extensions.warning_deleting, txtPono.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Pur.delete_po(txtPono.Text);
                    Main.ResetAllControls(groupBox1);
                    Main.ResetAllControls(groupBox2);
                    Main.ResetAllControls(groupBox3);
                    Main.ResetAllControls(this);
                    set_button();
                }
            }
            else
            {
                MessageBox.Show("Cannot Delete this Po", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private void frmPO_Paint(object sender, PaintEventArgs e)
        {
            Extensions.Purchasing = this.Name;
        }
    }
}
