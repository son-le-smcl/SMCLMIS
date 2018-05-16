using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMCL_MIS
{
    public partial class frmMaterials : Form
    {
        public string smat = "";
        GC_Engineer en = new GC_Engineer();
        public frmMaterials()
        {
            InitializeComponent();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        { 
        }

        private void frmMaterials_Load(object sender, EventArgs e)
        { 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false; 
            dg_purchase.AutoGenerateColumns = false;
            set_combo();
        }

        private void get_mat_bom()
        {
            if (txtMat.Text.Trim() == "")
                return;
            dg_bom_usage.DataSource= en.get_material_parent(txtMat.Text);
            dg_finishgood.DataSource = en.get_material_toplevel(txtMat.Text);
        }

     
        private void set_combo()
        {
            GC_Purchasing p = new GC_Purchasing();
            cbWS.DataSource = p.get_loch();
            cbWS.DisplayMember = "LOCNO";
            cbWS.ValueMember = "LOCNO";
            cbbomtype.DataSource = en.get_mat_st("BomType");
            cbbomtype.DisplayMember = "NAME";
            cbbomtype.ValueMember = "matstvalue";
            cbCategory.DataSource = en.get_mat_st("MatCategory");
            cbCategory.DisplayMember = "NAME";
            cbCategory.ValueMember = "matstvalue";
            cbmakebuy.DataSource = en.get_mat_st("MakeOrBuy");
            cbmakebuy.DisplayMember = "NAME";
            cbmakebuy.ValueMember = "matstvalue";
            cbMRPtype.DataSource = en.get_mat_st("ErpType");
            cbMRPtype.DisplayMember = "NAME";
            cbMRPtype.ValueMember = "matstvalue";
            cbrank.DataSource = en.get_mat_st("MatRank");
            cbrank.DisplayMember = "NAME";
            cbrank.ValueMember = "matstvalue";
            cb_pouom.DataSource = en.get_mat_st("MatUOM");
            cb_pouom.DisplayMember = "NAME";
            cb_pouom.ValueMember = "matstvalue";
            cb_bomuom.DataSource = en.get_mat_st("MatUOM");
            cb_bomuom.DisplayMember = "NAME";
            cb_bomuom.ValueMember = "matstvalue";
        }
        private void get_mat_po()
        {
            if (txtMat.Text.Trim() == "")
                return; 
            dg_purchase.DataSource = en.Get_material_po(txtMat.Text.Trim());
            dg_purchase.Columns["p_pono"].DataPropertyName = "PONO";
            dg_purchase.Columns["p_odate"].DataPropertyName = "ODate";
            dg_purchase.Columns["p_potype"].DataPropertyName = "PoType";
            dg_purchase.Columns["p_partno"].DataPropertyName = "PartNO";
            dg_purchase.Columns["p_partname"].DataPropertyName = "PartName";
            dg_purchase.Columns["p_ordered"].DataPropertyName = "ORDERED";
            dg_purchase.Columns["p_received"].DataPropertyName = "RECEIVED";
            dg_purchase.Columns["p_pouom"].DataPropertyName = "POUOFM";
            dg_purchase.Columns["p_Cruser"].DataPropertyName = "CrUser";
            dg_purchase.Columns["p_venid"].DataPropertyName = "VendID";
            dg_purchase.Columns["p_vendname"].DataPropertyName = "VendName";
            dg_purchase.Columns["p_jobno"].DataPropertyName = "JOBNO";
            dg_purchase.Columns["p_soodate"].DataPropertyName = "CustXH";
            dg_purchase.Columns["p_custPo"].DataPropertyName = "ShipDate";
            dg_purchase.Columns["p_shiploc"].DataPropertyName = "ShipLoc";
        }

        private void get_mat_onhan()
        {
            if (txtMat.Text.Trim() == "")
                return;

            dataGridView1.DataSource = en.Get_material_onhand(txtMat.Text.Trim()); 
            dataGridView1.Columns["LOCATION"].DataPropertyName = "LOCATION";
            dataGridView1.Columns["Part_Number"].DataPropertyName = "Part_Number";
            dataGridView1.Columns["Qty"].DataPropertyName = "Qty";
            dataGridView1.Columns["UOM"].DataPropertyName = "UOM";
            dataGridView1.Columns["RATE"].DataPropertyName = "RATE";
            dataGridView1.Columns["Qty2"].DataPropertyName = "Qty2";
            dataGridView1.Columns["UOM2"].DataPropertyName = "UOM2";
            dataGridView1.Columns["LAST_UPDATE"].DataPropertyName = "LAST_UPDATE";
        }

        
        private void get_mat_trans()
        {
            if (txtMat.Text.Trim() == "")
                return;
            if (txtMat.Text.Trim() == "")
                return;

            dataGridView1.DataSource = en.Get_material_onhand(txtMat.Text.Trim()); 
            dataGridView2.Columns["Date"].DataPropertyName = "Date";
            dataGridView2.Columns["No"].DataPropertyName = "No";
            dataGridView2.Columns["Type"].DataPropertyName = "Type";
            dataGridView2.Columns["Part_no"].DataPropertyName = "Part_Number";
            dataGridView2.Columns["trn_qty"].DataPropertyName = "QTY";
            dataGridView2.Columns["SONO"].DataPropertyName = "JOBNO";
            dataGridView2.Columns["PONO"].DataPropertyName = "PONO";
            dataGridView2.Columns["Remark"].DataPropertyName = "Remark";
        }
        public void get_mat_by_partno(string mat)
        {
            smat = mat;
            DataTable dt = en.get_materials_by_partno(mat);
            if (dt.Rows.Count <= 0)
                return;

            txtMat.Text = dt.Rows[0]["Partno"].ToString();
            txtbuyer.Text = dt.Rows[0]["Buyer"].ToString();
            txtrefno.Text= dt.Rows[0]["refno"].ToString();
            txtcustno.Text = dt.Rows[0]["custno"].ToString();
            txtmoq.Text = dt.Rows[0]["MINQTY"].ToString();
            txtstandarLoss.Text = dt.Rows[0]["SHRATE"].ToString();
            txtcrdate.Text = dt.Rows[0]["CRDATE"].ToString();
            txtcruser.Text = dt.Rows[0]["CRUSER"].ToString();
            txtlabor.Text = dt.Rows[0]["GS"].ToString();
            txtleadtime.Text = dt.Rows[0]["LEADTIME"].ToString();
            txtmoddate.Text = dt.Rows[0]["MDDATE"].ToString();
            txtmoduser.Text = dt.Rows[0]["MDUSER"].ToString();
            txtpartname.Text = dt.Rows[0]["PARTNAME"].ToString();
            txtpartname2.Text = dt.Rows[0]["CLASS"].ToString();
            txtweight.Text = dt.Rows[0]["WEIGHT"].ToString();
            cbbomtype.Text = dt.Rows[0]["WLATTR"].ToString();
            cbCategory.Text = dt.Rows[0]["S_TYPE"].ToString();
            cbmakebuy.Text = dt.Rows[0]["PRODWAY"].ToString();
            cbMRPtype.Text = dt.Rows[0]["ERPTYPE"].ToString();
            cbrank.Text = dt.Rows[0]["WLTYPE"].ToString();
            cbWS.Text = dt.Rows[0]["PARTLOC"].ToString(); 
            cb_bomuom.Text = dt.Rows[0]["UOFM"].ToString();
            cb_pouom.Text = dt.Rows[0]["POUOFM"].ToString();
            txtrate.Text=  dt.Rows[0]["POXSTK"].ToString();
            chk_disable.Checked = Extensions.int_to_bool(int.Parse( dt.Rows[0]["DEAD"].ToString()));


            
            get_mat_trans();
            get_mat_onhan();
            pictureBox1.InitialImage = null;
            Extensions.set_picture("Materials",smat,pictureBox1);
        }

        //public string get_mat_photo(string mat)
        //{
        //    string path = "";

        //    //(System.Windows.Forms.Application.OpenForms["Main"] as Main).set_processbar(0);

        //    string[] filePaths = Directory.GetFiles(@"\\192.168.84.2\bom\picture of BOM\picture\", mat + "*",
        //                             SearchOption.AllDirectories);
        //    if (filePaths.Length == 0 || mat == "")
        //    {
        //        path = @"..\..\Res\img\image-not-found.jpg";
        //    }
        //    else
        //    {
        //        path = filePaths[0];
        //    }

        //    return path;
        //}


        private void btn_search_part_Click(object sender, EventArgs e)
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
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            
        } 
        //private void set_picture()
        //{
        //    //smat = txtMat.Text;
            
        //    new Thread(delegate ()
        //    {
        //        try
        //        {
                    
        //            if (smat == "")
        //                return;
        //            pictureBox1.Image = Image.FromFile(get_mat_photo(smat));
        //            var imageSize = pictureBox1.Image.Size;
        //            var fitSize = pictureBox1.ClientSize;
        //            pictureBox1.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
        //                PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
        //        }
        //        catch
        //        {
        //            // Do nothing and let it try again until the attempts are exausted.
        //            // Exceptions are thrown for normal ping failurs like address lookup
        //            // failed.  For this reason we are supressing errors.
        //        }

        //    }).Start();
        //    (System.Windows.Forms.Application.OpenForms["Main"] as Main).set_processbar(0);
        //}
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Extensions.set_picture("Materials", smat, pictureBox1);
            //if (txtMat.Text == "")
            //    return;
            //pictureBox1.Image = Image.FromFile(get_mat_photo(txtMat.Text));
            //var imageSize = pictureBox1.Image.Size;
            //var fitSize = pictureBox1.ClientSize;
            //pictureBox1.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
            //    PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage; 
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            { 
                case 1:
                    get_mat_bom();
                    break;
                case 2:
                    get_mat_po();
                    break;
            }
        } 
        private void button3_Click(object sender, EventArgs e)
        {
            Main.ResetAllControls(panel1);
            Main.ResetAllControls(tabPage2);
            Main.ResetAllControls(tabPage3);
        }

        private void txtMat_TextChanged(object sender, EventArgs e)
        {
            if (txtMat.Text.Trim() == "")
                panel1.Enabled = false;
            else
                panel1.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Igni i = new Igni();
            try
            {
                string frezedate = ""; ;
                if (chk_disable.Checked)
                {
                    frezedate = DateTime.Now.ToString();
                }
                if (txtMat.Text.Trim() == "")
                    return;

                if (en.check_materials_exist(txtMat.Text))
                {
                    if (!i.check_user_permission(LoginInfo.username, this.Name, "Fupdate"))
                    {
                        MessageBox.Show(Extensions.warning_missingpermission, txtMat.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    string glid;

                    if (cbbomtype.SelectedValue.ToString() == "RM")
                        glid = "RM";
                    else if (cbbomtype.SelectedValue.ToString() == "WIP" && cbCategory.SelectedValue.ToString() != "FG")
                        glid = "SIME-FG";
                    else
                        glid = "FG";

                    en.update_material(txtMat.Text,
                        txtpartname.Text, 
                        txtrefno.Text, 
                        txtcustno.Text,
                        cb_bomuom.SelectedValue.ToString(),
                        float.Parse(txtrate.Text.ToString()), 
                        cb_pouom.Text,
                        float.Parse(txtlabor.Text.ToString()),
                        float.Parse(txtweight.Text.ToString()),
                        txtpartname2.Text, 
                        int.Parse(txtleadtime.Text.ToString()),
                        float.Parse(txtmoq.Text.ToString()),
                        null,
                        cbbomtype.SelectedValue.ToString(), 
                        cbmakebuy.SelectedValue.ToString(), 
                        cbMRPtype.SelectedValue.ToString(),
                        glid,
                        cbWS.SelectedValue.ToString(), null, null, 
                        Extensions.bool_to_int(chk_disable.Checked),
                        frezedate, 
                        cbCategory.SelectedValue.ToString(), 
                        float.Parse(txtstandarLoss.Text.ToString()), 
                        DateTime.Now, LoginInfo.username, txtbuyer.Text);
                    //update
                }
                else
                {
                    if (!i.check_user_permission(LoginInfo.username, this.Name, "Fcreate"))
                    {
                        MessageBox.Show(Extensions.warning_missingpermission, txtMat.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    string glid;

                    if (cbbomtype.SelectedValue.ToString() == "RM")
                        glid = "RM";
                    else if (cbbomtype.SelectedValue.ToString() == "WIP"&& cbCategory.SelectedValue.ToString()!="FG")
                        glid = "SIME-FG";
                    else
                        glid = "FG";

                    en.new_material(txtMat.Text,
                        txtpartname.Text, 
                        txtrefno.Text, 
                        txtcustno.Text, 
                        cb_bomuom.SelectedValue.ToString(), 
                        float.Parse(txtrate.Text.ToString())
                        , cb_pouom.SelectedValue.ToString(), 0, 0, 0, 0, 0, 0, 0, 0, 
                        float.Parse(txtlabor.Text.ToString()), 
                        float.Parse(txtweight.Text.ToString()), 
                        txtpartname2.Text, 
                        int.Parse(txtleadtime.Text.ToString())
                        , float.Parse(txtmoq.Text.ToString()), 
                        cbrank.SelectedValue.ToString(), 
                        cbbomtype.SelectedValue.ToString(), 
                        cbmakebuy.SelectedValue.ToString(), 
                        cbMRPtype.SelectedValue.ToString(), glid, 0, 0, 
                        cbWS.SelectedValue.ToString(), null, null,
                        Extensions.bool_to_int(chk_disable.Checked), 
                        frezedate, null, null, 0,
                        DateTime.Now, 
                        LoginInfo.username, 
                        DateTime.Now,
                        null, txtbuyer.Text, 0, null, null, null, null, null, 0, 0, 0, DateTime.Now, DateTime.Now, DateTime.Now);
                    //addnew
                }
                MessageBox.Show("Successful", txtMat.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception exc)
            { 
                i.update_user_errlog(LoginInfo.username
                    , this.Name
                    , exc.Message.ToString()
                    , DateTime.Now.ToString());
                MessageBox.Show(exc.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void frmMaterials_Paint(object sender, PaintEventArgs e)
        {
            Extensions.Engineer = this.Name;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txtMat.Text.Trim() == "")
                return;

            Igni i = new Igni();
            DialogResult dialogResult = MessageBox.Show(this, "Are you sure want to Delete this Materials?", txtMat.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (i.check_user_permission(LoginInfo.username,
                    this.Name,
                    "Fdelete"))
                {
                    try
                    {
                        en.delete_mat(txtMat.Text.Trim());
                        MessageBox.Show("Successful", txtMat.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button3_Click(sender, e);
                    }
                    catch (Exception exc)
                    {
                        i.update_user_errlog(LoginInfo.username
                            , this.Name
                            , exc.Message.ToString()
                            , DateTime.Now.ToString());
                        MessageBox.Show(exc.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show(Extensions.warning_missingpermission, "Permission Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtMat_Leave(object sender, EventArgs e)
        {
            get_mat_by_partno(txtMat.Text);
            txtMat.ReadOnly = true;
        }

        private void txtMat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMat_Leave( sender,  e);
            }
        }
    }
}
