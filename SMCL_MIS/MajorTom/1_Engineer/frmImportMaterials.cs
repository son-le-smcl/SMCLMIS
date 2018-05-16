using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMCL_MIS
{
    public partial class frmImportMaterials : Form
    {
        GC_Engineer en = new GC_Engineer();
        public frmImportMaterials()
        {
            InitializeComponent();
        }

        private void downloadTeamplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Extensions.get_template(@"\\192.168.84.2\Public\MyDriver\SMCL_MIS\import_template\Materials_import_template.xlsx", saveFileDialog1);
        }

        private void selectFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Extensions.from_excel(openFileDialog1);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            check_input_data();
        }
        private void check_input_data()
        {
            new Thread(delegate ()
            {
                try
                {

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        string error = "";
                        string mat = dataGridView1.Rows[i].Cells["part_number"].Value.ToString();
                        string Category = dataGridView1.Rows[i].Cells["Category"].Value.ToString();
                        string Bom_UOM = dataGridView1.Rows[i].Cells["Bom_UOM"].Value.ToString();
                        string Po_UOM = dataGridView1.Rows[i].Cells["Po_UOM"].Value.ToString();
                        string Part_Rank = dataGridView1.Rows[i].Cells["Part_Rank"].Value.ToString();
                        string BOM_type = dataGridView1.Rows[i].Cells["BOM_type"].Value.ToString();
                        string MakeOrBuy = dataGridView1.Rows[i].Cells["MakeOrBuy"].Value.ToString();
                        string ErpType = dataGridView1.Rows[i].Cells["ErpType"].Value.ToString();
                        string Part_Location = dataGridView1.Rows[i].Cells["Part_Location"].Value.ToString();
                        string Part_Description = dataGridView1.Rows[i].Cells["Part_Location"].Value.ToString();
                        string Rate = dataGridView1.Rows[i].Cells["Rate"].Value.ToString();
                        string LeadTime = dataGridView1.Rows[i].Cells["LeadTime"].Value.ToString();
                        string MinQty = dataGridView1.Rows[i].Cells["MinQty"].Value.ToString();
                        string Reference_number = dataGridView1.Rows[i].Cells["Reference_number"].Value.ToString();
                        string Customer_number = dataGridView1.Rows[i].Cells["Customer_number"].Value.ToString();


                        if (en.check_materials_exist(mat))
                        {
                            error += "Đã Tồn tại Mã Vật tư này" + Environment.NewLine;
                        }
                        if (!en.check_mat_st(Bom_UOM, "MatUOM"))
                        {
                            error += "Bom_UOM không tồn tại" + Environment.NewLine;
                        }
                        if (!en.check_mat_st(Po_UOM, "MatUOM"))
                        {
                            error += "Po_UOM không tồn tại" + Environment.NewLine;
                        }
                        if (!en.check_mat_st(Part_Rank, "MatRank"))
                        {
                            error += "Part_Rank Vật tư không tồn tại" + Environment.NewLine;
                        }
                        if (!en.check_mat_st(BOM_type, "BomType"))
                        {
                            error += "BOM_type không tồn tại" + Environment.NewLine;
                        }
                        if (!en.check_mat_st(MakeOrBuy, "MakeOrBuy"))
                        {
                            error += "MakeOrBuy không tồn tại" + Environment.NewLine;
                        }
                        if (!en.check_exist_Loch(Part_Location))
                        {
                            error += "Part_Location không tồn tại" + Environment.NewLine;
                        }
                        if (!Extensions.check_int(MinQty) ||
                            !Extensions.check_int(LeadTime) ||
                            !Extensions.check_int(Rate))
                        {
                            error += "MinQty/ leadtime /Rate không đúng định dạng" + Environment.NewLine;
                        }
                        if (Extensions.check_int(Rate))
                        {
                            if (int.Parse(Rate) <= 0)
                            {
                                error += "Rate>=1" + Environment.NewLine;
                            }
                        }

                        if (error != "")
                            set_status(false, error, i);
                        else
                        {
                            set_status(true, error, i);

                        }
                    }
                }
                catch
                {
                    // Do nothing and let it try again until the attempts are exausted.
                    // Exceptions are thrown for normal ping failurs like address lookup
                    // failed.  For this reason we are supressing errors.
                }

            }).Start();
        }
        private void new_mat()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string error = "";
               
                if (dataGridView1.Rows[i].Cells["status"].Value.ToString() == "Ok")
                {
                    try {
                        string mat = dataGridView1.Rows[i].Cells["part_number"].Value.ToString();
                        string Category = dataGridView1.Rows[i].Cells["Category"].Value.ToString();
                        string Bom_UOM = dataGridView1.Rows[i].Cells["Bom_UOM"].Value.ToString();
                        string Po_UOM = dataGridView1.Rows[i].Cells["Po_UOM"].Value.ToString();
                        string Part_Rank = dataGridView1.Rows[i].Cells["Part_Rank"].Value.ToString();
                        string BOM_type = dataGridView1.Rows[i].Cells["BOM_type"].Value.ToString();
                        string MakeOrBuy = dataGridView1.Rows[i].Cells["MakeOrBuy"].Value.ToString();
                        string ErpType = dataGridView1.Rows[i].Cells["ErpType"].Value.ToString();
                        string Part_Location = dataGridView1.Rows[i].Cells["Part_Location"].Value.ToString();
                        string Part_Description = dataGridView1.Rows[i].Cells["Part_Description"].Value.ToString();
                        string Part_Description2 = dataGridView1.Rows[i].Cells["Part_Description2"].Value.ToString();
                        string Rate = dataGridView1.Rows[i].Cells["Rate"].Value.ToString();
                        string LeadTime = dataGridView1.Rows[i].Cells["LeadTime"].Value.ToString();
                        string MinQty = dataGridView1.Rows[i].Cells["MinQty"].Value.ToString();
                        string Reference_number = dataGridView1.Rows[i].Cells["Reference_number"].Value.ToString();
                        string Customer_number = dataGridView1.Rows[i].Cells["Customer_number"].Value.ToString(); 
                        en.new_material(mat, Part_Description, Reference_number, Customer_number, Bom_UOM,
                            int.Parse(Rate), Po_UOM, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, Part_Description2,
                            int.Parse(LeadTime), int.Parse(MinQty), Part_Rank, BOM_type, MakeOrBuy, ErpType, "",
                            0, 0, Part_Location,
                            "", "", 0, "", Category, "", 0, DateTime.Now, LoginInfo.username, DateTime.Now,
                            "", "", 0, "", "", "", "", "", 0, 0, 0, DateTime.Now, DateTime.Now, DateTime.Now);
                        //MessageBox.Show("Successful!", mat, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new Thread(delegate ()
                        {
                            try
                            {
                                dataGridView1.Rows[i].Cells["status"].Value = "Imported";
                            }
                            catch
                            {
                                // Do nothing and let it try again until the attempts are exausted.
                                // Exceptions are thrown for normal ping failurs like address lookup
                                // failed.  For this reason we are supressing errors.
                            }

                        }).Start();
                    }
                    catch (Exception exc)
                    {
                        Igni i_ = new Igni();
                        i_.update_user_errlog(LoginInfo.username
                            , this.Name
                            , exc.Message.ToString()
                            , DateTime.Now.ToString());
                        MessageBox.Show(exc.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                     
                }
               
            }
            MessageBox.Show("Import Finished!", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void set_status(bool t, string sts, int row)
        {
            if (t)
            {
                dataGridView1.Rows[row].Cells["status"].Value = "Ok";
                dataGridView1.Rows[row].DefaultCellStyle.BackColor = Color.White;

                dataGridView1.Rows[row].Cells["status"].Style.ForeColor = Color.Green;
            }
            else
            {
                dataGridView1.Rows[row].Cells["status"].Value = "Error";
                dataGridView1.Rows[row].DefaultCellStyle.BackColor = Color.FromArgb(255, 221, 221);
                dataGridView1.Rows[row].Cells["status"].Style.ForeColor = Color.Red;
            }
            dataGridView1.Rows[row].Cells["status"].ToolTipText = sts;
        }

        private void frmImportMaterials_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            set_grid_combo(); 
        }
        private void set_grid_combo()
        {
            //DataGridViewComboBoxColumn Category = (DataGridViewComboBoxColumn)dataGridView1.Columns["Category"];
            //DataGridViewComboBoxColumn Bom_UOM = (DataGridViewComboBoxColumn)dataGridView1.Columns["Bom_UOM"];
            //DataGridViewComboBoxColumn Po_UOM = (DataGridViewComboBoxColumn)dataGridView1.Columns["Po_UOM"];
            //DataGridViewComboBoxColumn Part_Rank = (DataGridViewComboBoxColumn)dataGridView1.Columns["Part_Rank"];
            //DataGridViewComboBoxColumn BOM_type = (DataGridViewComboBoxColumn)dataGridView1.Columns["BOM_type"];
            //DataGridViewComboBoxColumn MakeOrBuy = (DataGridViewComboBoxColumn)dataGridView1.Columns["MakeOrBuy"];
            //DataGridViewComboBoxColumn ErpType = (DataGridViewComboBoxColumn)dataGridView1.Columns["ErpType"];
            //DataGridViewComboBoxColumn Part_Location = (DataGridViewComboBoxColumn)dataGridView1.Columns["Part_Location"];

            //Category = en.get_mat_st("MatCategory");
            //UOM = en.get_mat_st("MatUOM");
            //Part_Rank = en.get_mat_st("MatRank");
            //BOM_type = en.get_mat_st("BomType");
            //MakeOrBuy = en.get_mat_st("MakeOrBuy");
            //ErpType = en.get_mat_st("ErpType");
            //GC_Purchasing p = new GC_Purchasing();
            //DataTable Part_Location = p.get_loch();

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //dataGridView1[e.ColumnIndex, e.RowIndex].Value = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            new_mat();
        }

        private void frmImportMaterials_Shown(object sender, EventArgs e)
        {
          
        }

        private void frmImportMaterials_Activated(object sender, EventArgs e)
        {
            Extensions.Engineer = this.Name;
        }

        private void frmImportMaterials_Paint(object sender, PaintEventArgs e)
        {
            Extensions.Engineer = this.Name;
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
    }
}
