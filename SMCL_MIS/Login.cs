using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
namespace SMCL_MIS
{

    public partial class Login : Form
    {
        string u = "";
        string p = "";

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private bool check_login(string u, string p)
        {
            Igni i = new Igni();
            if (i.check_user(u, p).Rows.Count > 0)
            {
                
                LoginInfo.username = i.check_user(u, p).Rows[0]["UserID"].ToString();
                LoginInfo.name = i.check_user(u, p).Rows[0]["UserName"].ToString();
                LoginInfo.dept = i.check_user(u, p).Rows[0]["DeptID"].ToString();
                
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Igni i = new Igni();
            
            LoginInfo.database = comboBox1.Text;
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.a = txtusername.Text;
                Properties.Settings.Default.b = txtpwd.Text;
                Properties.Settings.Default.Save();
                txtusername.Text = Properties.Settings.Default.a;
                txtpwd.Text = Properties.Settings.Default.b;  
            }
            else
            {
                Properties.Settings.Default.a = null;
                Properties.Settings.Default.b = null;
                Properties.Settings.Default.Save();
            }

            if (check_login(txtusername.Text, txtpwd.Text))
            {
                Main m = new Main();
                m.Show();
                i.update_last_login(LoginInfo.username
                    , Dns.GetHostAddresses(Environment.MachineName)[1].ToString()
                    , Environment.MachineName
                    , DateTime.Now
                    , (Application.OpenForms["Main"] as Main).label2.Text
                    , LoginInfo.database); 
            }
            else
            {
                Properties.Settings.Default.a = "";
                Properties.Settings.Default.b = "";
                Properties.Settings.Default.Save();
                DialogResult dialogResult = MessageBox.Show("Incorrect Username Or Password", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            //txtpwd.Text = "mis@admin";
            //txtusername.Text = "admin"; 
            if (Properties.Settings.Default.a != null && Properties.Settings.Default.a.Trim()!="")
            {
                checkBox1.Checked = true;
                txtusername.Text = Properties.Settings.Default.a;
                txtpwd.Text = Properties.Settings.Default.b; 
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
         
    }
}
