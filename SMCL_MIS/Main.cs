using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.Threading;

namespace SMCL_MIS
{
    public partial class Main : Form
    {
        public Main()
        {
           
            InitializeComponent();
        }
        private const int HT_CAPTION = 0x2;
        private const int WM_NCLBUTTONDOWN = 0x00A1;

        public object SystemCommands { get; private set; }

        [DllImport("user32", CharSet = CharSet.Auto)]
        private static extern bool ReleaseCapture();
        [DllImport("user32", CharSet = CharSet.Auto)]
        private static extern int SendMessage(
        IntPtr hwnd,
        int wMsg,
        int wParam,
        int lParam);
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                Rectangle rct = DisplayRectangle;
                if (rct.Contains(e.Location))
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        { 
            this.FormBorderStyle = FormBorderStyle.None;                        //
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;  // Dont fuck with these setting
            this.WindowState = FormWindowState.Maximized;                       //

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                this.label2.Text = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4);
            }
            if (LoginInfo.name == null)
            { this.Close(); }
            else
            {
                (System.Windows.Forms.Application.OpenForms["Login"] as Login).Hide();
            }

            lbluname.Text = LoginInfo.name;
            lbl_Dept.Text = LoginInfo.dept;
            lbl_database.Text = "⦿ " + LoginInfo.database + "_DB";
            lbl_database.Font = new Font(lbl_database.Font.Name, 10, FontStyle.Bold);
            if (LoginInfo.database == "LIVE")
                lbl_database.ForeColor = Color.Green;
            else
                lbl_database.ForeColor = Color.Red;

            check_permission_mainmenu();

        }
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BringToFront();
            DialogResult dialogResult = MessageBox.Show(this,"Are you sure want to close this Application?", "Close SMCL System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            { 
                (System.Windows.Forms.Application.OpenForms["Login"] as Login).Close();
                this.Close();

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void tableLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            OnMouseDown(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; ;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DigiClockTextBox.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Sales s = new Sales();
            //openform(s);
        }
        public void openformbyname(string name)
        { 
            if (name.Substring(0, 3) != "frm")
                return;
            string formToCall = name;
            var type = Type.GetType("SMCL_MIS." + formToCall); 
            var form = Activator.CreateInstance(type) as Form;
            openform(form);

        }
        public void openform(Form f)
        {
            lblfrmname.Text = f.Text;
            f.MdiParent = this;
            //f.TopLevel = false;
            //f.AutoScroll = true; 
            this.tableLayoutPanel4.Controls.Add(f);
            if (!CheckOpened(f.Name))
            {
                if (f.Name.Substring(0, 3) == "frm") { 
                f.Show();
                }
            }
            else
            {

            }
        }

        public bool CheckOpened(string name)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == name)
                {
                    frm.BringToFront();
                    return true;
                }
            }
            return false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Extensions.Engineer==null || Extensions.EmptyIfNull(Extensions.Engineer) == "")
            {
                frmMaterials t = new frmMaterials();
                openform(t);
                //Extensions.Engineer = t.Name;
            } 
            else
            { openformbyname(Extensions.Engineer); }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (Extensions.Sales == null || Extensions.EmptyIfNull(Extensions.Sales) == "")
            {
                frmSales s = new frmSales();
                openform(s);
            }
            else
            { openformbyname(Extensions.Sales); }
           
        }

        private void importNowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public bool check_empty(Control textBox)
        {
            if (textBox.Text == "")
            {
                textBox.BackColor = Color.FromArgb(255, 209, 209);
                return false;
            }
            else { textBox.BackColor = Color.White; return true; }

        }

        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }
                if (control is RichTextBox)
                {
                    RichTextBox textBox = (RichTextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }
                if (control is DataGridView)
                {
                    DataGridView gr = (DataGridView)control;
                    gr.DataSource = null;
                    gr.Rows.Clear();
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Extensions.setting == null || Extensions.EmptyIfNull(Extensions.setting) == "")
            {
                frm_Settings s = new frm_Settings();
                openform(s);
            }
            else
            { openformbyname(Extensions.setting); }
          
        }

        private void check_permission_mainmenu()
        {
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            //button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button14.Enabled = false;
            Igni i = new Igni();
            if (i.check_user_permission(LoginInfo.username.ToString(), "frmBOM", "Fread"))
            {
                button3.Enabled = true;
            }
            if (i.check_user_permission(LoginInfo.username.ToString(), "frmPlanning", "Fread"))
            {
                button4.Enabled = true;
            }
            if (i.check_user_permission(LoginInfo.username.ToString(), "frmSales", "Fread"))
            {
                button5.Enabled = true;
            }
            if (i.check_user_permission(LoginInfo.username.ToString(), "frmPOmain", "Fread"))
            {
                button6.Enabled = true;
            }
            if (i.check_user_permission(LoginInfo.username.ToString(), "frmProduction", "Fread"))
            {
                button7.Enabled = true;
            }
            if (i.check_user_permission(LoginInfo.username.ToString(), "frmWH", "Fread"))
            {
                button8.Enabled = true;
            }
            if (i.check_user_permission(LoginInfo.username.ToString(), "frmCalendar", "Fread"))
            {
                button9.Enabled = true;
            }
            if (i.check_user_permission(LoginInfo.username.ToString(), "frmNotification", "Fread"))
            {
                button10.Enabled = true;
            }
            if (i.check_user_permission(LoginInfo.username.ToString(), "frm_Settings", "Fread"))
            {
                button11.Enabled = true;
            }
        }

        private void exportFromExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Extensions.Purchasing == null || Extensions.EmptyIfNull(Extensions.Purchasing) == "")
            {
                frmPomain po = new frmPomain();
                openform(po);
            }
            else
            { openformbyname(Extensions.Purchasing); }
          
        }
        public void set_processbar(int max)
        {
            Cursor.Current = Cursors.WaitCursor; 
            //if (max > 0) {
            //}
            //else
            //{
                toolStripProgressBar1.Maximum = 100;
                toolStripProgressBar1.Step = 1;
                toolStripProgressBar1.Increment(1);
                backgroundWorker1.RunWorkerAsync();
            lbl_process_label.Text = max+" Rows";
            //}
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmWH f = new frmWH();

            openform(f);
        }

        private void Calculate(int i)
        {
            double pow = Math.Pow(i, i);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var backgroundWorker = sender as BackgroundWorker;
            for (int j = 0; j < 100000; j++)
            {
                Calculate(j);
                backgroundWorker.ReportProgress((j * 100) / 100000);
            }
            backgroundWorker.ReportProgress(0);

            Cursor.Current = Cursors.Default;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Value = e.ProgressPercentage;
            //lbl_process_label.Text = "Progress: " + e.ProgressPercentage.ToString() + "%";

        }

        private void btn_hr_Click(object sender, EventArgs e)
        {
            if (Extensions.calendar == null || Extensions.EmptyIfNull(Extensions.calendar) == "")
            {
                frmCalendar f = new frmCalendar();
                openform(f);
            }
            else
            { openformbyname(Extensions.calendar); }
          
        }

        private void button10_Click(object sender, EventArgs e)
        { 
            frm_calendar_a f = new frm_calendar_a();
            openform(f);
        }
    }
}
