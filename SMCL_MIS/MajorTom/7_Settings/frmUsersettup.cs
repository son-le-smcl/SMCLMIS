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
    public partial class frmUsersettup : Form
    {
        bool new_user;
        GC_Setting st = new GC_Setting();
        public frmUsersettup()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtuserid.Text.Trim() == "")
                return;

            st.insert_new_permission();
            DataTable dt = new DataTable();
            dt = st.get_user_by_id(txtuserid.Text.Trim());
            if (dt.Rows.Count > 0)
            {
                txtuserid.Text = dt.Rows[0]["Userid"].ToString();
                txtpwd.Text = dt.Rows[0]["Password"].ToString();
                txtrepwd.Text = dt.Rows[0]["Password"].ToString();
                txtfullname.Text = dt.Rows[0]["username"].ToString();
                cbDept.Text = dt.Rows[0]["deptid"].ToString();
                groupBox3.Enabled = true;
                get_permission_by_id();

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Not Found, Do you want to add this User: " + txtuserid.Text + "", "Do you Want to add new", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    //insert new user
                    new_user = true;
                }
                else
                {
                    button2_Click(sender, e);
                }
            }
        }
        private void load_module()
        {
            DataTable dt = new DataTable();
            dt = st.get_all_module();
            cb_module.DataSource = dt;
            cb_module.DisplayMember = "frm_module";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                st.insert_new_permission();
                if (new_user)
                {//add new
                    if (txtpwd.Text.Trim() == txtrepwd.Text.Trim() && txtpwd.Text.Trim() != "" && txtuserid.Text.Trim() != "")
                    {
                        st.insert_user(txtuserid.Text.Trim()
                            , txtpwd.Text.Trim()
                            , txtfullname.Text.Trim()
                            , cbDept.Text.Trim()
                            , "");
                        MessageBox.Show("User :" + txtuserid.Text + " Created Successful!");
                    }

                    else
                        MessageBox.Show("Password do not match! Or incorrect infomation");
                }
                else
                {//update
                    if (txtpwd.Text.Trim() == txtrepwd.Text.Trim() && txtpwd.Text.Trim() != "" && txtuserid.Text.Trim() != "")
                    {
                        st.update_user(txtuserid.Text.Trim(), txtpwd.Text.Trim(), txtfullname.Text.Trim(), cbDept.Text.Trim(), "");
                        for (int i = 0; i < DG_userright.Rows.Count; i++)
                        {
                            st.update_userpermission(txtuserid.Text.Trim()
                                , Extensions.EmptyIfNull(DG_userright["frmCol", i].Value)
                                , Extensions.EmptyIfNull(DG_userright["readCol", i].Value)
                                , Extensions.EmptyIfNull(DG_userright["createCol", i].Value)
                                , Extensions.EmptyIfNull(DG_userright["updateCol", i].Value)
                                , Extensions.EmptyIfNull(DG_userright["deleteCol", i].Value)
                                , Extensions.EmptyIfNull(DG_userright["approveCol", i].Value));
                        }
                        MessageBox.Show("User :" + txtuserid.Text + " Updated Successful!");
                    }
                }
                button3_Click(sender, e);
            }
            catch (Exception ext)
            {
                Igni i = new Igni();
                i.update_user_errlog(LoginInfo.username
                    , this.Name
                    , ext.ToString()
                    , DateTime.Now.ToString());
                MessageBox.Show(ext.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmUsersettup_Load(object sender, EventArgs e)
        {
            new_user = false;
            load_module();
            groupBox3.Enabled = false;
        }
        private void get_permission_by_id()
        {
            DataTable dt = new DataTable();
            dt = st.get_permission_by_userid(txtuserid.Text, cb_module.Text);
            if (dt.Rows.Count > 0)
            {
                DG_userright.AutoGenerateColumns = false;
                DG_userright.DataSource = dt;
                DG_userright.Columns["useridCol"].DataPropertyName = "userid";
                DG_userright.Columns["frmCol"].DataPropertyName = "system_form";
                DG_userright.Columns["Description"].DataPropertyName = "frm_name";
                DG_userright.Columns["readCol"].DataPropertyName = "Fread";
                DG_userright.Columns["createCol"].DataPropertyName = "FCREATE";
                DG_userright.Columns["updateCol"].DataPropertyName = "Fupdate";
                DG_userright.Columns["approveCol"].DataPropertyName = "Fapprove";
                DG_userright.Columns["deleteCol"].DataPropertyName = "Fdelete";

            }

        }
        private void cb_module_TextChanged(object sender, EventArgs e)
        {
            get_permission_by_id();
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            string buttonid = radioButton.Name;
            switch (buttonid)
            {
                case "radio_none": // do something; break
                    for (int i = 0; i < DG_userright.Rows.Count; i++)
                    {
                        DG_userright.Rows[i].Cells["readCol"].Value = 0;
                        DG_userright.Rows[i].Cells["createCol"].Value = 0;
                        DG_userright.Rows[i].Cells["updateCol"].Value = 0;
                        DG_userright.Rows[i].Cells["approveCol"].Value = 0;
                        DG_userright.Rows[i].Cells["deleteCol"].Value = 0;
                    }
                    break;
                case "radio_crud":
                    for (int i = 0; i < DG_userright.Rows.Count; i++)
                    {

                        DG_userright.Rows[i].Cells["readCol"].Value = 1;
                        DG_userright.Rows[i].Cells["createCol"].Value = 1;
                        DG_userright.Rows[i].Cells["updateCol"].Value = 1;
                        DG_userright.Rows[i].Cells["approveCol"].Value = 0;
                        DG_userright.Rows[i].Cells["deleteCol"].Value = 1;
                    }
                    break;
                case "radio_readonly":
                    for (int i = 0; i < DG_userright.Rows.Count; i++)
                    {

                        DG_userright.Rows[i].Cells["readCol"].Value = 1;
                        DG_userright.Rows[i].Cells["createCol"].Value = 0;
                        DG_userright.Rows[i].Cells["updateCol"].Value = 0;
                        DG_userright.Rows[i].Cells["approveCol"].Value = 0;
                        DG_userright.Rows[i].Cells["deleteCol"].Value = 0;
                    }
                    break;
                case "radio_manager":
                    for (int i = 0; i < DG_userright.Rows.Count; i++)
                    {
                        DG_userright.Rows[i].Cells["readCol"].Value = 1;
                        DG_userright.Rows[i].Cells["createCol"].Value = 1;
                        DG_userright.Rows[i].Cells["updateCol"].Value = 1;
                        DG_userright.Rows[i].Cells["approveCol"].Value = 1;
                        DG_userright.Rows[i].Cells["deleteCol"].Value = 1;
                    }
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main.ResetAllControls(groupBox1);
            Main.ResetAllControls(groupBox2);
            Main.ResetAllControls(groupBox3);
            Main.ResetAllControls(DG_userright);
            frmUsersettup_Load(sender, e);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to delete: " + txtuserid.Text + "", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                st.delete_user(txtuserid.Text.Trim());
                MessageBox.Show("Deleted");
                button2_Click(sender, e);
            }


        }
    }
}
