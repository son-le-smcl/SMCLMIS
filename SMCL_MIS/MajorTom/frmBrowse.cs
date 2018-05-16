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
    public partial class frmBrowse : Form
    {
        GC_Browse b = new GC_Browse();
        string frm_;
        Form f_;
        public Form Sf { get; set; }
        public frmBrowse(Form parent)
        {
            Sf = parent;
          
        }
        public frmBrowse(string frm, Form f)
        {
            frm_ = frm;
            f_ = f;
            InitializeComponent();
            switch (frm)
            {
                case "SO": 
                    label1.Text = label1.Text + frm;
                    break;
                case "LOCH":
                    label1.Text = label1.Text + "LOCATION"; ;
                    break;
                case "CUS":
                    label1.Text = label1.Text + "CUSTOMER";
                    break;
                case "PART":
                    label1.Text = label1.Text + "Part Number";
                    break;
                case "SUP":
                    label1.Text = label1.Text + "Supllier Number";
                    break;
                case "QUOTE":
                    label1.Text = label1.Text + "Quotation Number";
                    break;
                case "PO":
                    label1.Text = label1.Text + "PO Number";
                    break;
                case "SOD":
                    label1.Text = label1.Text + "SO Number";
                    break;
                case "BOM":
                    label1.Text = label1.Text + "BOM";
                    break;
            }
            dg_Search.DataSource = b.browse(frm,this);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmBrowse_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtsearch;
            dg_Search.DefaultCellStyle.SelectionForeColor = Color.Black;
            dg_Search.DefaultCellStyle.SelectionBackColor = Extensions.get_select_row_color();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            dg_Search.DataSource = b.filler(frm_, Extensions.RemoveSpecialCharacters(txtsearch.Text), f_); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            if (frm_ == "SO") {
                string sono = dg_Search.Rows[dg_Search.CurrentRow.Index].Cells[0].Value.ToString();
                (System.Windows.Forms.Application.OpenForms["frmSO"] as frmSO).get_so_by_sono(sono);
            }
            if (frm_ == "SOD")
            {
                string sono = dg_Search.Rows[dg_Search.CurrentRow.Index].Cells[0].Value.ToString();
                (System.Windows.Forms.Application.OpenForms["frmPO"] as frmPO).sod_to_grv(sono);
            }
            if (frm_ == "LOCH")
            {
                string LOCH = dg_Search.Rows[dg_Search.CurrentRow.Index].Cells[0].Value.ToString();
                (System.Windows.Forms.Application.OpenForms["frmPO"] as frmPO).LOCH_to_grv(LOCH);
            }
            if (frm_ == "SOD")
            {
                string sono = dg_Search.Rows[dg_Search.CurrentRow.Index].Cells[0].Value.ToString();
                (System.Windows.Forms.Application.OpenForms["frmPO"] as frmPO).sod_to_grv(sono);
            }
            if (frm_ == "CUS")
            {
                string cusno = dg_Search.Rows[dg_Search.CurrentRow.Index].Cells[0].Value.ToString();
                (System.Windows.Forms.Application.OpenForms["frmSO"] as frmSO).get_customer_by_customerno(cusno);
            }
            if (frm_ == "PART")
            {

                string partno = dg_Search.Rows[dg_Search.CurrentRow.Index].Cells[0].Value.ToString();
                if (f_.Name == "frmQuotation")
                {
                    (System.Windows.Forms.Application.OpenForms["frmQuotation"] as frmQuotation).part_no_togv(partno);
                }
                else if (f_.Name == "frmPO")
                {
                    (System.Windows.Forms.Application.OpenForms["frmPO"] as frmPO).part_no_togv(partno);
                }
                else if (f_.Name == "frmMaterials")
                {
                    (System.Windows.Forms.Application.OpenForms["frmMaterials"] as frmMaterials).get_mat_by_partno(partno);
                }
                else if (f_.Name == "frmBOM")
                {
                    (System.Windows.Forms.Application.OpenForms["frmBOM"] as frmBOM).add_to_bom(partno);
                }
                else
                {
                    (System.Windows.Forms.Application.OpenForms["frmSO"] as frmSO).part_no_togv(partno);
                }
                    
            }
            if (frm_ == "SUP")
            {
                string supno = dg_Search.Rows[dg_Search.CurrentRow.Index].Cells[0].Value.ToString();
                if (f_.Name == "frmSupplier")
                {
                    (System.Windows.Forms.Application.OpenForms["frmSupplier"] as frmSupplier).get_supplier_by_supplierno(supno);
                }
                else if (f_.Name == "frmPO")
                {
                    (System.Windows.Forms.Application.OpenForms["frmPO"] as frmPO).get_supplier_by_supplierno(supno);
                }
                else
                {
                    (System.Windows.Forms.Application.OpenForms["frmQuotation"] as frmQuotation).get_sup_by_supno(supno);
                }

            }
            if (frm_ == "QUOTE")
            {
                string quotno = dg_Search.Rows[dg_Search.CurrentRow.Index].Cells[0].Value.ToString();
                (System.Windows.Forms.Application.OpenForms["frmQuotation"] as frmQuotation).get_quote_by_quoteno(quotno);

            }
            if (frm_ == "PO")
            {
                string pono = dg_Search.Rows[dg_Search.CurrentRow.Index].Cells[0].Value.ToString();
                (System.Windows.Forms.Application.OpenForms["frmPO"] as frmPO).get_po_by_pono(pono);

            }
            if (frm_ == "BOM")
            {
                string BOM = dg_Search.Rows[dg_Search.CurrentRow.Index].Cells[0].Value.ToString();
                (System.Windows.Forms.Application.OpenForms["frmBOM"] as frmBOM).get_bom_by_partno(BOM);

            }
            
            this.Close();
        } 
    

        private void dg_Search_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button1_Click(sender, e);
        }

        private void dg_Search_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_Search_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                dg_Search.Rows[e.RowIndex].DefaultCellStyle.BackColor = Extensions.get_select_row_color();
        }

        private void dg_Search_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                dg_Search.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
        }
    }
}
