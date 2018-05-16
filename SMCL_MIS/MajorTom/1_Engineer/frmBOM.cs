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
    public partial class frmBOM : Form
    {
        GC_Engineer en = new GC_Engineer();
        DataTable trv = new DataTable();
        frmMaterials mat = new frmMaterials();
        public frmBOM()
        {
            InitializeComponent();
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void PopulateTreeView(string parent_, TreeNode parentNode)

        { 
            TreeNode childNode;  
            foreach (DataRow dr in trv.Select("[Parent]='"+ parent_ + "'")) 
            { 
                TreeNode t = new TreeNode();
                t.Text = dr["PartNo"].ToString();
                t.Name = dr["PartNo"].ToString();
                t.Tag = trv.Rows.IndexOf(dr);
                if (parentNode == null)
                {
                    treeView1.Nodes.Add(t);
                    childNode = t;
                }
                else
                { 
                    parentNode.Nodes.Add(t); 
                    childNode = t; 
                } 
                PopulateTreeView(dr["PartNo"].ToString(), childNode); 
            }

        }
        public void get_bom_by_partno(string mat)
        {
            treeView1.Nodes.Clear();
            DataTable dt = en.Get_BOM_by_Partno(mat);
            if (dt.Rows.Count <= 0)
                return;
            txtBom.Text = dt.Rows[0]["PartNO"].ToString();
            txtbomCreateby.Text = dt.Rows[0]["Create_By"].ToString();
            txtbomCreateDate.Text = dt.Rows[0]["Create_On"].ToString();
            txtbomname.Text = dt.Rows[0]["Part_Name"].ToString();
            txtbomUpdateby.Text = dt.Rows[0]["Modify_By"].ToString();
            txtbomUpdatedate.Text = dt.Rows[0]["Modify_ON"].ToString();
            txtbomRemark.Text = dt.Rows[0]["remark"].ToString();
            trv = en.get_Bom_by_parent(mat);

            PopulateTreeView(txtBom.Text, null);
            BOM_pictureBox.InitialImage = null;

            txtBom.ReadOnly = true;
        }

        private void btn_searchbom_Click(object sender, EventArgs e)
        {
            frmBrowse b = new frmBrowse("BOM", this);
            if (!(System.Windows.Forms.Application.OpenForms["Main"] as Main).CheckOpened(b.Name))
            {
                b.Show();
            }
            else
            {
                b.BringToFront();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void frmBOM_Load(object sender, EventArgs e)
        { 
        }
       
        private void frmBOM_Activated(object sender, System.EventArgs e)
        {
            Extensions.Engineer = this.Name;
        }
        private void treeView1_Click(object sender, EventArgs e)
        {
            //    TreeViewHitTestInfo info = treeView1.HitTest(treeView1.PointToClient(Cursor.Position));
            //    if (info != null)
            //        MessageBox.Show(info.Node.Text);
        }

        private void get_bom_detail_by_partno(string mat, string parent)
        {
            BOM_pictureBox.InitialImage = null;
            DataTable dt = new DataTable();
            dt=en.get_bom_detail_by_partno(mat, parent); 
            txtpartno.Text = dt.Rows[0]["Partno"].ToString();
            txtClass.Text = dt.Rows[0]["wltype"].ToString();
            txtweight.Text = dt.Rows[0]["Weight"].ToString();
            txtCreateBy.Text = dt.Rows[0]["cruser"].ToString();
            txtCreateDate.Text = dt.Rows[0]["crdate"].ToString();
            txtErpType.Text = dt.Rows[0]["erptype"].ToString();
            txtlabor.Text = dt.Rows[0]["GS"].ToString();
            txtLeadTime.Text = dt.Rows[0]["leadtime"].ToString();
            txtLossrate.Text = dt.Rows[0]["SHRATE"].ToString();
            txtMakeBuy.Text = dt.Rows[0]["prodway"].ToString();
            txtMatType.Text = dt.Rows[0]["WLATTR"].ToString();
            txtMOQ.Text = dt.Rows[0]["MINQTY"].ToString();
            txtPartname.Text = dt.Rows[0]["Partname"].ToString();
            txtQty.Text = dt.Rows[0]["qty"].ToString();
            txtUom.Text = dt.Rows[0]["uofm"].ToString();
            txtUpateBy.Text = dt.Rows[0]["mduser"].ToString();
            txtUpdateDate.Text = dt.Rows[0]["mddate"].ToString();
            txtWorkShop.Text = dt.Rows[0]["partloc"].ToString();
            Extensions.set_picture("Materials", txtpartno.Text, BOM_pictureBox);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string parent = "";
            if (e.Node.Parent == null)
                parent = txtBom.Text;
            else parent = e.Node.Parent.Name;
            get_bom_detail_by_partno(e.Node.Text, parent);

            BOM_pictureBox.Image = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Extensions.set_picture("Materials",txtpartno.Text, BOM_pictureBox);
            //if (Partnumber.Text == "")
            //    return;
            //BOM_pictureBox.Image = Image.FromFile(mat.get_mat_photo(txtpartno.Text));
            //var imageSize = BOM_pictureBox.Image.Size;
            //var fitSize = BOM_pictureBox.ClientSize;
            //BOM_pictureBox.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
            //    PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
        }

        private void frmBOM_Activated_1(object sender, EventArgs e)
        {
            Extensions.Engineer = this.Name;
        }

        private void frmBOM_Paint(object sender, PaintEventArgs e)
        {
            Extensions.Engineer = this.Name;
        }

        public void add_to_bom(string mat) {
            if (treeView1.SelectedNode != null)
                treeView1.SelectedNode.Nodes.Add(mat);
            else
                treeView1.Nodes.Add(mat);
        }

        private void bom_add_Click(object sender, EventArgs e)
        {
            frmBrowse b = new frmBrowse("PART", this);
            if (!(System.Windows.Forms.Application.OpenForms["Main"] as Main).CheckOpened(b.Name))
            {
                b.Show();
            }
            else
            {
                b.BringToFront();
            }
        }
    }
}
