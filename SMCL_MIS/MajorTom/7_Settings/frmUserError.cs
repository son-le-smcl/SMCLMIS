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
    
    public partial class frmUserError : Form
    {
        GC_Setting st = new GC_Setting();
        public frmUserError()
        {
            InitializeComponent();
        }

        private void frmUserError_Load(object sender, EventArgs e)
        {
            Extensions.set_grid_style(Gv_log);
            Extensions.set_grid_style(Gv_mosterr);
            Extensions.set_grid_style(Gv_warning);
            btn_load_Click(sender, e);
           
        }
       
        private void btn_load_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["Main"] as Main).set_processbar(0);
            Gv_log.DataSource = st.get_user_err_bydate(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            Gv_mosterr.DataSource=st.get_top_err_user_bydate(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            Gv_log.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (!Extensions.check_int(txtminutes.Text))
                return;
            if (int.Parse(txtminutes.Text) > 0) { timer1.Enabled = true;
                timer1.Interval = (int.Parse(txtminutes.Text) * 60000);
            }
            else
                timer1.Enabled = false;

        }

        private void Gv_log_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        { 
            btn_load_Click(sender, e);
        }
    }
}
