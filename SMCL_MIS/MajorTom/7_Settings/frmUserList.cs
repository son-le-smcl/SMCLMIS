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
    public partial class frmUserList : Form
    {
        GC_Setting st = new GC_Setting();
        public frmUserList()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Gv_List.DataSource = st.get_userlist();
        }

        private void frmUserList_Load(object sender, EventArgs e)
        {
            Gv_List.DoubleBuffered(true);
            Gv_Log.DoubleBuffered(true);
            Extensions.set_grid_style(Gv_List);
            Extensions.set_grid_style(Gv_Log);
        }

        private void Gv_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            Gv_Log.DataSource = st.get_login_log_by_userid(Gv_List[0, e.RowIndex].Value.ToString());
        }

        private void Gv_List_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
