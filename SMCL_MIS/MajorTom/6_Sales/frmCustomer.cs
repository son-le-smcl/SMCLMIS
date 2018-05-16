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
    public partial class frmCustomer : Form
    {
        DataTable to_delete = new DataTable();
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            GC_Sales s = new GC_Sales();
            Igni ig = new Igni();
            try
            {
                if (to_delete.Rows.Count > 0 || ig.check_user_permission(LoginInfo.username, "frmCustomer", "Fdelete"))
                {
                    s.delete_customer(to_delete);
                    to_delete.Columns.Remove("customer_id");
                }
                for (int i = 0; i < Dg_customer.Rows.Count; i++)
                {
                    if (Extensions.EmptyIfNull(Dg_customer[0, i].Value) == "" && Extensions.EmptyIfNull(Dg_customer[1, i].Value) != "")
                    {
                        if (!ig.check_user_permission(LoginInfo.username, "frmCustomer", "Fcreate"))
                        {
                            MessageBox.Show("You do not have Permission to Create new Customer!", "Can not Create Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        s.new_customer(
                            Extensions.EmptyIfNull(Dg_customer[1, i].Value),
                            Extensions.EmptyIfNull(Dg_customer[2, i].Value),
                            Extensions.EmptyIfNull(Dg_customer[3, i].Value),
                            Extensions.EmptyIfNull(Dg_customer[4, i].Value),
                            Extensions.EmptyIfNull(Dg_customer[5, i].Value),
                            Extensions.EmptyIfNull(Dg_customer[6, i].Value)
                            );
                    }
                    else
                    {
                        if (!ig.check_user_permission(LoginInfo.username, "frmCustomer", "Fupdate"))
                        {
                            MessageBox.Show("You do not have Permission to Update Customer!", "Can not Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        if (Extensions.EmptyIfNull(Dg_customer[1, i].Value) != "")
                        {
                            s.update_customer(
                               Extensions.EmptyIfNull(Dg_customer[0, i].Value),
                               Extensions.EmptyIfNull(Dg_customer[1, i].Value),
                               Extensions.EmptyIfNull(Dg_customer[2, i].Value),
                               Extensions.EmptyIfNull(Dg_customer[3, i].Value),
                               Extensions.EmptyIfNull(Dg_customer[4, i].Value),
                               Extensions.EmptyIfNull(Dg_customer[5, i].Value),
                               Extensions.EmptyIfNull(Dg_customer[6, i].Value)
                               );
                        }
                    }
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
            frmCustomer_Load(sender, e);
        } 
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            GC_Sales s = new GC_Sales();
            to_delete.Columns.Add("customer_id", typeof(string)); 
            Dg_customer.DataSource = s.get_ALLcustomer(); 
            Dg_customer.Columns[0].ReadOnly = true;
            Dg_customer.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;
        }

        private void Dg_customer_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            to_delete.Rows.Add(new Object[] { Dg_customer[0, e.Row.Index].Value });
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "") { }
            (Dg_customer.DataSource as DataTable).DefaultView.RowFilter = string.Format("Customer_name LIKE '%{0}%' " +
                    "Or customer_terms LIKE '%{0}%'", txtSearch.Text);
        }

        private void frmCustomer_Paint(object sender, PaintEventArgs e)
        {
            Extensions.Sales = this.Name;
        }
    } 
}
