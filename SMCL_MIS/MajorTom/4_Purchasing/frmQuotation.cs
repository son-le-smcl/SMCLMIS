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
    public partial class frmQuotation : Form
    {
        DataTable to_delete = new DataTable();
        GC_Purchasing Pur = new GC_Purchasing();
        Igni igni = new Igni();
        Main m = new Main();
        public frmQuotation()
        {
            InitializeComponent();
        }
        public void set_button()
        {
            if (txtStatus.Text == "Draft") {
                btn_approve.Text = "Approve";
                lbl_approvedate.Text = "UnApprove Date";
                lbl_approveuser.Text = "UnApprove By";
                   
            }
            else if (txtStatus.Text == "Approval")
            {
                btn_approve.Text = "UnApprove"; 
                lbl_approvedate.Text = "Approve Date";
                lbl_approveuser.Text = "Approve By";
            }
            if (igni.check_user_permission(LoginInfo.username, this.Name, "Fapprove"))
            {
                btn_approve.Enabled = true;
            }
            else { btn_approve.Enabled = false; }
            if (igni.check_user_permission(LoginInfo.username, this.Name, "Fcreate") && txtStatus.Text == "Draft" ||
                igni.check_user_permission(LoginInfo.username, this.Name, "FUpdate") && txtStatus.Text == "Draft")
            { 
                btn_save.Enabled = true;
            }
            else
                btn_save.Enabled = true;
        }

        public void get_quote_by_quoteno(string quoteno)
        {
            DataTable head = new DataTable();
            DataTable line = new DataTable();
            if (quoteno == "empty")
            {
                line = Pur.Quote_emptyline();
            }
            else
            {
                line = Pur.get_quote_line_by_quoteno(quoteno);
                line.Rows.Add();
            }
            DG_Quote.AutoGenerateColumns = false;
            head = Pur.get_quote_head_by_quoteno(quoteno);

            if (head.Rows.Count > 0)
            {
                txtquoteno.Text = head.Rows[0]["BJID"].ToString();
                dp_quotedate.Text = head.Rows[0]["BJDate"].ToString();
                txtStatus.Text = head.Rows[0]["Status"].ToString();
                txtApproveDate.Text = head.Rows[0]["AppDate"].ToString();
                txtApproveUser.Text = head.Rows[0]["AppUser"].ToString();
                txtClass.Text = head.Rows[0]["PurValue"].ToString();
                txtCreateDate.Text = head.Rows[0]["CrDate"].ToString();
                txtCreateUser.Text = head.Rows[0]["CrUser"].ToString();
                txtCurrendcy.Text = head.Rows[0]["HB"].ToString();
                txtSupno.Text = head.Rows[0]["VendID"].ToString();
                txtsupname.Text = head.Rows[0]["VendName"].ToString();
                txtTax.Text = head.Rows[0]["TAX"].ToString();
            }
            if (line.Rows.Count > 0)
            {
                DG_Quote.DataSource = line;
                DG_Quote.Columns["BJID"].DataPropertyName = "BJID";
                DG_Quote.Columns["PartNO"].DataPropertyName = "PartNO";
                DG_Quote.Columns["Price"].DataPropertyName = "Price";
                DG_Quote.Columns["Lead"].DataPropertyName = "Lead";
                DG_Quote.Columns["MaxSup"].DataPropertyName = "MaxSup";
                DG_Quote.Columns["Remark"].DataPropertyName = "Remark";
                DG_Quote.Columns["Filed1"].DataPropertyName = "Filed1";
            }
            DG_Quote.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            set_button();
        }

        private void btn_search_quote_Click(object sender, EventArgs e)
        {
            frmBrowse b = new frmBrowse("QUOTE", this);
            if (!(System.Windows.Forms.Application.OpenForms["Main"] as Main).CheckOpened(b.Name))
            {
                b.Show();
            }
            else
            {
                b.BringToFront();
            }
        }

        private void DG_Quote_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        public void get_sup_by_supno(string supno)
        {
            DataTable dt = new DataTable();
            dt = Pur.get_supplier_by_supplierno(supno);
            txtsupname.Text = dt.Rows[0]["vendname"].ToString();
            txtSupno.Text = dt.Rows[0]["vendid"].ToString();
            txtCurrendcy.Text = dt.Rows[0]["HB"].ToString();
            txtClass.Text = dt.Rows[0]["Purvalue"].ToString();
        }

        private void btn_search_sup_Click(object sender, EventArgs e)
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
        }

        private bool check_quote_head_input()
        {
            if (!m.check_empty(txtSupno))
                return false;
            else
                return true;
        }

        private bool check_quote_line_input()
        {
            bool result = true;
            for (int i = 0; i < DG_Quote.Rows.Count; i++)
            {
                if (Extensions.EmptyIfNull(DG_Quote[0, i].Value) != "")
                {
                    if (Extensions.EmptyIfNull(DG_Quote[1, i].Value) == "" ||
                    Extensions.EmptyIfNull(DG_Quote[2, i].Value) == "" ||
                    Extensions.EmptyIfNull(DG_Quote[3, i].Value) == "")
                    {
                        DG_Quote.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 209, 209);
                        result = false;
                    }
                    else
                        DG_Quote.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check_quote_head_input() && check_quote_line_input())
            {
                try
                {
                    if (txtquoteno.Text == "" && igni.check_user_permission(LoginInfo.username, this.Name, "Fcreate"))// add new
                    {
                        txtquoteno.Text = generating_quote_id(Pur.get_mostrecent_quoteid());
                        Pur.new_quote_head(txtquoteno.Text
                            , txtSupno.Text
                            , dp_quotedate.Value
                            , "Draft"
                            , LoginInfo.username
                            , DateTime.Now
                            , ""
                            , DateTime.Now);

                        for (int i = 0; i < DG_Quote.Rows.Count; i++)
                        {
                            if (Extensions.EmptyIfNull(DG_Quote[1, i].Value) != "")
                            {
                                Pur.new_quote_line(txtquoteno.Text
                                    , Extensions.EmptyIfNull(DG_Quote[1, i].Value)
                                    , float.Parse(DG_Quote[2, i].Value.ToString())
                                    , int.Parse(DG_Quote[3, i].Value.ToString())
                                    , int.Parse(DG_Quote[4, i].Value.ToString())
                                    , Extensions.EmptyIfNull(DG_Quote[5, i].Value.ToString())
                                    , DG_Quote[6, i].Value.ToString()
                                    );
                            }
                        }
                    }

                    else if (igni.check_user_permission(LoginInfo.username, this.Name, "Fupdate"))
                    {
                        Pur.update_quote_head(txtquoteno.Text,
                            txtSupno.Text,
                            dp_quotedate.Value);
                        for (int i = 0; i < DG_Quote.Rows.Count; i++)
                        {
                            if (Extensions.EmptyIfNull(DG_Quote[1, i].Value) != "" &&
                                !Pur.check_exist_quote_line(txtquoteno.Text,
                                Extensions.EmptyIfNull(DG_Quote[1, i].Value))
                                )
                            {
                                Pur.new_quote_line(txtquoteno.Text
                                  , Extensions.EmptyIfNull(DG_Quote[1, i].Value)
                                  , float.Parse(DG_Quote[2, i].Value.ToString())
                                  , int.Parse(DG_Quote[3, i].Value.ToString())
                                  , int.Parse(DG_Quote[4, i].Value.ToString())
                                  , Extensions.EmptyIfNull(DG_Quote[5, i].Value.ToString())
                                  , DG_Quote[6, i].Value.ToString()
                                  );
                            }
                            else if (Extensions.EmptyIfNull(DG_Quote[1, i].Value) != "" &&
                                Pur.check_exist_quote_line(txtquoteno.Text,
                                Extensions.EmptyIfNull(DG_Quote[1, i].Value)))
                            {
                                Pur.update_quote_line(txtquoteno.Text
                                  , Extensions.EmptyIfNull(DG_Quote[1, i].Value)
                                  , float.Parse(DG_Quote[2, i].Value.ToString())
                                  , int.Parse(DG_Quote[3, i].Value.ToString())
                                  , int.Parse(DG_Quote[4, i].Value.ToString())
                                  , Extensions.EmptyIfNull(DG_Quote[5, i].Value.ToString())
                                  , DG_Quote[6, i].Value.ToString()
                                  );
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(Extensions.warning_missingpermission, "Permission Required!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        get_quote_by_quoteno(txtquoteno.Text);
                        return;
                    }
                    MessageBox.Show("Saved Quotation " + txtquoteno.Text, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    get_quote_by_quoteno(txtquoteno.Text);
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
            else
            {
                MessageBox.Show("Please input all required field!" + Environment.NewLine + "Vui lòng nhập tất cả trường bắt buộc!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DG_Quote_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            to_delete.Rows.Add(new Object[] { DG_Quote[0, e.Row.Index].Value, DG_Quote[1, e.Row.Index].Value });
        }

        private void frmQuotation_Load(object sender, EventArgs e)
        {
            set_datagridview_combo();
            //txtquoteno.Text = generating_quote_id(Pur.get_mostrecent_quoteid());
            to_delete.Columns.Add("BJID", typeof(string));
            to_delete.Columns.Add("PartNo", typeof(string));
            get_quote_by_quoteno("empty");
            set_default_col_color();
        }
        private void set_default_col_color()
        {
            DG_Quote.RowsDefaultCellStyle.SelectionForeColor =
            DG_Quote.DefaultCellStyle.SelectionForeColor = Color.Black;
            DG_Quote.RowsDefaultCellStyle.SelectionBackColor =
            DG_Quote.DefaultCellStyle.SelectionBackColor = Extensions.get_select_row_color();

            DG_Quote.Columns[0].DefaultCellStyle.BackColor   = Extensions.get_not_editable_col();
            DG_Quote.Refresh();
        }
        private void set_datagridview_combo()
        {
            DataGridViewComboBoxColumn dcombo = (DataGridViewComboBoxColumn)DG_Quote.Columns["Filed1"];
            dcombo.DisplayMember = "Text";
            dcombo.ValueMember = "Value";
            dcombo.Items.Add(new { Text = "Normal", Value = "normal" });
            dcombo.Items.Add(new { Text = "Out Sourcing", Value = "outward" });
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Main.ResetAllControls(g3);
            Main.ResetAllControls(g2);
            Main.ResetAllControls(g1); 
            to_delete.Columns.Remove("BJID");
            to_delete.Columns.Remove("PartNo");
            frmQuotation_Load(sender, e); 
            //txtquoteno.Text= generating_quote_id(Pur.get_mostrecent_quoteid());
        }

        private string generating_quote_id(string newestid)
        {
            string currentid = "VBJD" + DateTime.Now.ToString("yyMM");//VBJD1710062
            if (currentid == newestid.Substring(0, newestid.Length - 3))// still in same year, month
            {
                return currentid + (int.Parse(newestid.Substring(newestid.Length - 3)) + 1).ToString("000");//add 1
            }
            else
                return currentid + "001";//start new sequence
        }

        private void DG_Quote_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //DG_Quote.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
        }

        private void DG_Quote_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {

                switch (DG_Quote.Columns[e.ColumnIndex].Name)
                {
                    case "PartNO":
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

        private void DG_Quote_Click(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            //{
            //    DG_Quote.Rows[e.RowIndex].DefaultCellStyle.BackColor = Extensions.get_select_row_color();
            //}
        }

        public void part_no_togv(string part_no)
        {
            bool t = false;
            
            for(int i=0; i< DG_Quote.Rows.Count; i++)
            {
                if (DG_Quote[1, i].Value.ToString() == part_no)
                {
                    t = true;
                    break;
                }
            }
            if (!t)
            {
                DG_Quote[1, DG_Quote.CurrentRow.Index].Value = part_no;
                DG_Quote[0, DG_Quote.CurrentRow.Index].Value = txtquoteno.Text;
                DataTable dt = DG_Quote.DataSource as DataTable;
                DataRow dr = dt.NewRow();
                if (DG_Quote.CurrentRow.Index + 1 == DG_Quote.Rows.Count)
                    dt.Rows.Add(dr);
            }
            else
                MessageBox.Show("This Part Number Already in this Quotation!","Dupplicated Part Number",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
          

        }

        public void delete_quote()
        {
            if (txtquoteno.Text.Trim() != "" && txtStatus.Text != "Approval")
            {
                if (MessageBox.Show(Extensions.warning_deleting,txtquoteno.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                { 
                    Pur.delete_quote(txtquoteno.Text);
                    Main.ResetAllControls(g1);
                    Main.ResetAllControls(g2);
                    Main.ResetAllControls(g3);
                    Main.ResetAllControls(this);
                    set_button();
                }
            }
            else
            {
                MessageBox.Show("Cannot Delete this Quotation", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_approve_Click(object sender, EventArgs e)
        {
            if(txtquoteno.Text!="" && igni.check_user_permission(LoginInfo.username,this.Name,"FApprove"))
            {
                if (txtStatus.Text == "Approval") { Pur.approve_quote(txtquoteno.Text, "Draft", LoginInfo.username, DateTime.Now); }
                else if (txtStatus.Text == "Draft")
                {
                    Pur.approve_quote(txtquoteno.Text, "Approval", LoginInfo.username, DateTime.Now);
                }
                
            }
            else
            {
                MessageBox.Show("You donot have permission to proceed this action!","Permission Required!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            get_quote_by_quoteno(txtquoteno.Text);
            MessageBox.Show("Approve Successful!");
        }

        private void frmQuotation_Paint(object sender, PaintEventArgs e)
        {
            Extensions.Purchasing = this.Name;
        }
    }
}
