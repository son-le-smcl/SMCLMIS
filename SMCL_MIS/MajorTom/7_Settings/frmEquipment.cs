using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace SMCL_MIS
{
    public partial class frmEquipment : Form
    {
        DataTable result;
        GC_Setting st = new GC_Setting();
       
        public frmEquipment()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void get_equipment(string e)
        {
            DataTable dt = st.get_equipment(e);
            txtEId.Text= dt.Rows[0]["equipment_id"].ToString();
            txtEname.Text = dt.Rows[0]["equipment_description"].ToString();
            dp_eBuydate.Text = dt.Rows[0]["equipment_date"].ToString();
            txtWarranty.Text = dt.Rows[0]["equipment_warranty"].ToString();
            txtEcreatedate.Text = dt.Rows[0]["equipment_create_date"].ToString();
            txtEsn.Text = dt.Rows[0]["equipment_SN"].ToString();
            txteMac.Text = dt.Rows[0]["equipment_mac"].ToString();
            txtEremark.Text = dt.Rows[0]["equipment_remark"].ToString();
            cb_eStatus.Text = dt.Rows[0]["equiptment_status"].ToString();
            cbEcategory.Text = dt.Rows[0]["equipment_category"].ToString();
            txteIp.Text = dt.Rows[0]["config_ip"].ToString();
            txteli.Text = dt.Rows[0]["config_li"].ToString();
            txteTxt.Text = dt.Rows[0]["config_pw"].ToString();
            txteLocation.Text = dt.Rows[0]["config_install_location"].ToString();
            txteUser.Text = dt.Rows[0]["config_user"].ToString();
            txteInstalldate.Text = dt.Rows[0]["config_installed_date"].ToString();
            txteRark.Text = dt.Rows[0]["config_remark"].ToString();

            pictureBox1.InitialImage = null;
            Extensions.set_picture("Equipment", txtEId.Text, pictureBox1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEname.Text.Trim() == "")
            {
                MessageBox.Show("Please give this device a name!");
                return;
            }
               

            if (txtEId.Text == "")
            {
                st.new_equipment(txtEname.Text,
                    dp_eBuydate.Text,
                    txtWarranty.Text,
                    txtEcreatedate.Text,
                    txtEsn.Text,
                    txteMac.Text,
                    txtEremark.Text,
                    cb_eStatus.Text,
                    cbEcategory.Text,
                    txteIp.Text,
                    txteli.Text,
                    txteTxt.Text,
                    txteLocation.Text,
                    txteUser.Text,
                    txteInstalldate.Text
                    , txteRark.Text);
            }
            else
            {
                st.update_equipment(txtEId.Text, 
                    txtEname.Text,
                   dp_eBuydate.Text,
                   txtWarranty.Text,
                   txtEcreatedate.Text,
                   txtEsn.Text,
                   txteMac.Text,
                   txtEremark.Text,
                   cb_eStatus.Text,
                   cbEcategory.Text,
                   txteIp.Text,
                   txteli.Text,
                   txteTxt.Text,
                   txteLocation.Text,
                   txteUser.Text,
                   txteInstalldate.Text
                   , txteRark.Text);
            }

            Gv_EquipList.DataSource=result= st.get_equipment(null);
        }

        private void frmEquipment_Load(object sender, EventArgs e)
        {
            Gv_EquipList.DoubleBuffered(true);
            Gv_EquipList.AutoGenerateColumns = false;
            Gv_EquipList.DataSource = st.get_equipment(null);
            Extensions.set_grid_style(Gv_EquipList);
            result = st.get_equipment(null);
        }

        private void Gv_EquipList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0 && e.ColumnIndex>=0)
            get_equipment(Gv_EquipList[0,e.RowIndex].Value.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            
        }
        private string ping(string address)
        {
            System.Net.NetworkInformation.Ping p = new System.Net.NetworkInformation.Ping();
            PingReply reply = p.Send(address);
            return reply.Status.ToString();
        }
        private string Get_hostname(string address)
        {
            try
            {
                IPHostEntry host;
                host = Dns.GetHostEntry(address);
                return host.HostName;
            }
            catch (Exception ext)
            {
                return "";
            }
          
        }
        public string GetMacAddress(string ipAddress)
        {
            string macAddress = string.Empty;
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
            pProcess.StartInfo.FileName = "arp";
            pProcess.StartInfo.Arguments = "-a " + ipAddress;
            pProcess.StartInfo.UseShellExecute = false;
            pProcess.StartInfo.RedirectStandardOutput = true;
            pProcess.StartInfo.CreateNoWindow = true;
            pProcess.Start();
            string strOutput = pProcess.StandardOutput.ReadToEnd();
            string[] substrings = strOutput.Split('-');
            if (substrings.Length >= 8)
            {
                macAddress = substrings[3].Substring(Math.Max(0, substrings[3].Length - 2))
                         + "-" + substrings[4] + "-" + substrings[5] + "-" + substrings[6]
                         + "-" + substrings[7] + "-"
                         + substrings[8].Substring(0, 2);
                return macAddress;
            }

            else
            {
                return "not found";
            }
        }
        private static List<IPAndMac> list;

        private static StreamReader ExecuteCommandLine(String file, String arguments = "")
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = file;
            startInfo.Arguments = arguments;

            Process process = Process.Start(startInfo);

            return process.StandardOutput;
        }

        private static void InitializeGetIPsAndMac()
        {
            if (list != null)
                return;

            var arpStream = ExecuteCommandLine("arp", "-a");
            List<string> result = new List<string>();
            while (!arpStream.EndOfStream)
            {
                var line = arpStream.ReadLine().Trim();
                result.Add(line);
            }

            list = result.Where(x => !string.IsNullOrEmpty(x) && (x.Contains("dynamic") || x.Contains("static")))
                .Select(x =>
                {
                    string[] parts = x.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    return new IPAndMac { IP = parts[0].Trim(), MAC = parts[1].Trim() };
                }).ToList();
        }

        public static string FindIPFromMacAddress(string macAddress)
        {
            try
            {
                InitializeGetIPsAndMac();
                return list.SingleOrDefault(x => x.MAC == macAddress).IP;
            }
            catch (Exception ext)
            {
                return "";
            }
        }

        public static string FindMacFromIPAddress(string ip)
        {
            try
            {
                InitializeGetIPsAndMac();
                return list.SingleOrDefault(x => x.IP == ip).MAC;
            }
            catch (Exception ext)
            {
                return "";
            }
        }

        private class IPAndMac
        {
            public string IP { get; set; }
            public string MAC { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
                new Thread(delegate ()
                {
                    try
                    {
                        for (int i = 0; i < Gv_EquipList.Rows.Count; i++)
                        {
                            string mac = Extensions.EmptyIfNull(Gv_EquipList.Rows[i].Cells["equipment_mac"].Value);
                            string ip = Extensions.EmptyIfNull(Gv_EquipList.Rows[i].Cells["config_ip"].Value);
                            if (Extensions.EmptyIfNull(Gv_EquipList[0, i].Value) != "")
                            {
                                if (mac != "")
                                {
                                    ip = FindIPFromMacAddress(mac);
                                    if (ping(ip) == "Success")
                                    {
                                        if (Get_hostname(ip) != "")
                                        {
                                            Gv_EquipList.Rows[i].Cells["equipment_description"].Value = Get_hostname(ip);
                                        }

                                        Gv_EquipList.Rows[i].Cells["config_ip"].Value = ip;
                                        Gv_EquipList.Rows[i].Cells["ping_"].Value = ping(ip);

                                    }
                                }
                                else if (ip != "")
                                {
                                    if (ping(ip) == "Success")
                                    {
                                        if (Get_hostname(ip) != "")
                                        {
                                            Gv_EquipList.Rows[i].Cells["equipment_description"].Value = Get_hostname(ip);
                                        }
                                        Gv_EquipList.Rows[i].Cells["equipment_mac"].Value =
                                            FindMacFromIPAddress(ip);
                                        Gv_EquipList.Rows[i].Cells["ping_"].Value = ping(ip);
                                    }

                                }
                                else { }
                                if (Gv_EquipList.Rows[i].Cells["ping_"].Value.ToString() != "Success")
                                {
                                    Gv_EquipList.Rows[i].Cells["ping_"].Style.ForeColor = Color.Red;
                                }
                                else

                                    Gv_EquipList.Rows[i].Cells["ping_"].Style.ForeColor = Color.Green;
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
                (System.Windows.Forms.Application.OpenForms["Main"] as Main).set_processbar(0);
            
           
            Cursor.Current = Cursors.Default;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
            if (txtSearch.Text.Trim() == "")
                Gv_EquipList.DataSource = result;

            else
            {
                DataView dv = new DataView(result);
                string Filter = "1=1";
                if (txtSearch.Text != "")
                {
                    Filter = Filter + " And (equipment_mac like '%" + txtSearch.Text + "%')";
                    Filter = Filter + " OR (equiptment_status like '%" + txtSearch.Text + "%')";
                    Filter = Filter + " OR (equipment_category like '%" + txtSearch.Text + "%')";
                    Filter = Filter + " OR (equipment_description like '%" + txtSearch.Text + "%')";
                    Filter = Filter + " OR (Config_ip like '%" + txtSearch.Text + "%')";
                }
                dv.RowFilter = Filter;
                Gv_EquipList.DataSource = dv.ToTable();
            }

            //(System.Windows.Forms.Application.OpenForms["Main"] as Main).set_processbar(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Main"] as Main).set_processbar(0);
            for (int i = 0; i < Gv_EquipList.Rows.Count; i++)
            {
                if (Gv_EquipList.Rows[i].Cells["equipment_id"].Value != null) {
                    st.update_equipment_list(Gv_EquipList.Rows[i].Cells["equipment_id"].Value.ToString(),
                        Gv_EquipList.Rows[i].Cells["equipment_description"].Value.ToString(),
                         Gv_EquipList.Rows[i].Cells["equipment_mac"].Value.ToString(),
                          Gv_EquipList.Rows[i].Cells["config_ip"].Value.ToString()
                   );
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Main.ResetAllControls(groupBox1);
            Main.ResetAllControls(groupBox2);
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = Gv_EquipList.DataSource as DataTable;

            (System.Windows.Forms.Application.OpenForms["Main"] as Main).set_processbar(dt.Rows.Count);
            Extensions.Export(dt, "SMCL EQUIPMENT LIST(" + DateTime.Now + ")");
        }

        private void Gv_EquipList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
