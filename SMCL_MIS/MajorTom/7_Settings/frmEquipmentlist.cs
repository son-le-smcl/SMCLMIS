using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMCL_MIS
{
    public partial class frmEquipmentlist : Form
    {
        DataTable result;
        GC_Setting st = new GC_Setting();
        public frmEquipmentlist()
        {
            InitializeComponent();
        }
        public void Ping_all()
        {
            string gate_ip = textBox1.Text = NetworkGateway();

            //Extracting and pinging all other ip's.
            string[] array = gate_ip.Split('.');

            for (int i = 1; i <= 254; i++)
            {
                //string ping_var = "192.168.84." + i;
                string ping_var = array[0] + "." + array[1] + "." + array[2] + "." + i;

                //time in milliseconds           
                Ping(ping_var, 1, 4000);

            }

        }

        public void Ping(string host, int attempts, int timeout)
        {
            for (int i = 0; i < attempts; i++)
            {
                new Thread(delegate ()
                {
                    try
                    {
                        System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();
                        ping.PingCompleted += new PingCompletedEventHandler(PingCompleted);
                        ping.SendAsync(host, timeout, host);
                    }
                    catch
                    {
                        // Do nothing and let it try again until the attempts are exausted.
                        // Exceptions are thrown for normal ping failurs like address lookup
                        // failed.  For this reason we are supressing errors.
                    }
                }).Start();
            }
        }
        private void PingCompleted(object sender, PingCompletedEventArgs e)
        {
            string ip = (string)e.UserState;
            if (e.Reply != null && e.Reply.Status == IPStatus.Success)
            {
                string hostname = GetHostName(ip);
                string macaddres = GetMacAddress(ip);
                string[] arr = new string[3];

                //store all three parameters to be shown on ListView
                arr[0] = ip;
                arr[1] = hostname;
                arr[2] = macaddres;

                // Logic for Ping Reply Success
                ListViewItem item;
                if (this.InvokeRequired)
                {

                    this.Invoke(new Action(() =>
                    {

                        item = new ListViewItem(arr);

                        //lstLocal.Items.Add(item);
                        lstLocal.Rows.Add(arr);


                    }));
                }


            }
            else
            {
                // MessageBox.Show(e.Reply.Status.ToString());
            }
        }
        public string GetHostName(string ipAddress)
        {
            try
            {
                IPHostEntry entry = Dns.GetHostEntry(ipAddress);
                if (entry != null)
                {
                    return entry.HostName;
                }
            }
            catch (SocketException)
            {
                // MessageBox.Show(e.Message.ToString());
            }

            return null;
        }


        //Get MAC address
        public string GetMacAddress(string ipAddress)
        {
            string macAddress = string.Empty;
            System.Diagnostics.Process Process = new System.Diagnostics.Process();
            Process.StartInfo.FileName = "arp";
            Process.StartInfo.Arguments = "-a " + ipAddress;
            Process.StartInfo.UseShellExecute = false;
            Process.StartInfo.RedirectStandardOutput = true;
            Process.StartInfo.CreateNoWindow = true;
            Process.Start();
            string strOutput = Process.StandardOutput.ReadToEnd();
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
                return "Your Machine";
            }
        }
        static string NetworkGateway()
        {
            string ip = null;

            foreach (NetworkInterface f in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (f.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (GatewayIPAddressInformation d in f.GetIPProperties().GatewayAddresses)
                    {
                        ip = d.Address.ToString();
                    }
                }
            }

            return "192.168.84.254";
        }
        private void Search_Click(object sender, EventArgs e)
        {

            //lstLocal.View = View.Details;
            //lstLocal.Clear();
            //lstLocal.GridLines = true;
            //lstLocal.FullRowSelect = true;
            //lstLocal.BackColor = System.Drawing.Color.Aquamarine;
            lstLocal.ColumnCount = 3;
            lstLocal.Columns[0].Name = "IP";
            lstLocal.Columns[1].Name = "HostName";
            lstLocal.Columns[2].Name = "MAC Address";
            //lstLocal.Sorting = SortOrder.Descending;
            Ping_all();   //Automate pending
            
        }

        private void frmEquipmentlist_Load(object sender, EventArgs e)
        {
            Extensions.set_grid_style(lstLocal);
        }

        private void lstLocal_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = lstLocal.DataSource as DataTable;

            (System.Windows.Forms.Application.OpenForms["Main"] as Main).set_processbar(dt.Rows.Count);
            Extensions.Export(dt, "SMCL EQUIPMENT LIST(" + DateTime.Now + ")");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            for(int i = 0; i < lstLocal.Rows.Count; i++)
            {
                if (Extensions.EmptyIfNull( lstLocal[2, i].Value)!= "Your Machine" &&
                    Extensions.EmptyIfNull(lstLocal[2, i].Value) != "")
                { 
                    if(!st.check_mac(Extensions.EmptyIfNull(lstLocal[2, i].Value))){
                        st.new_equipment_lis(Extensions.EmptyIfNull(lstLocal[1, i].Value)
                            , DateTime.Now.ToString("yyyy-MM-dd")
                            , Extensions.EmptyIfNull(lstLocal[2, i].Value)
                            , "Inuse"
                            ,Extensions.EmptyIfNull(lstLocal[0, i].Value));
                    }
                }
            }
            }
            catch (Exception exc)
            {
                Igni i = new Igni();
                i.update_user_errlog(LoginInfo.username
                    , this.Name
                    , exc.Message.ToString()
                    , DateTime.Now.ToString());
                MessageBox.Show(exc.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(result==null)
            result = lstLocal.DataSource as DataTable;

            if (txtSearch.Text.Trim() == "")
                lstLocal.DataSource = result;

            else
            {
                DataView dv = new DataView(result);
                string Filter = "1=1";
                if (txtSearch.Text != "")
                {
                    Filter = Filter + " And (IP like '%" + txtSearch.Text + "%')"; 
                }
                dv.RowFilter = Filter;
                lstLocal.DataSource = dv.ToTable();
            }

            (System.Windows.Forms.Application.OpenForms["Main"] as Main).set_processbar(0);
        }
    }
}
