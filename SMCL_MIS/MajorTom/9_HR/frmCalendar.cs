using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMCL_MIS
{
    public partial class frmCalendar : Form
    {
        GC_HR hr = new GC_HR();
        public frmCalendar()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        private void load_year_cal()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            DataTable dt = new DataTable();
            for (int i = 1; i <= 12; i++)
            {
                DataTable t = new DataTable();
                t = hr.get_cal_by_month(i);
                dt.Merge(t);
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["month_"].DataPropertyName = "month_"; 
            dataGridView1.Columns["day_1"].DataPropertyName = "day_1";
            dataGridView1.Columns["day_2"].DataPropertyName = "day_2";
            dataGridView1.Columns["day_3"].DataPropertyName = "day_3";
            dataGridView1.Columns["day_4"].DataPropertyName = "day_4";
            dataGridView1.Columns["day_5"].DataPropertyName = "day_5";
            dataGridView1.Columns["day_6"].DataPropertyName = "day_6";
            dataGridView1.Columns["day_7"].DataPropertyName = "day_7";
            dataGridView1.Columns["day_8"].DataPropertyName = "day_8";
            dataGridView1.Columns["day_9"].DataPropertyName = "day_9";
            dataGridView1.Columns["day_10"].DataPropertyName = "day_10";
            dataGridView1.Columns["day_11"].DataPropertyName = "day_11";
            dataGridView1.Columns["day_12"].DataPropertyName = "day_12";
            dataGridView1.Columns["day_13"].DataPropertyName = "day_13";
            dataGridView1.Columns["day_14"].DataPropertyName = "day_14";
            dataGridView1.Columns["day_15"].DataPropertyName = "day_15";
            dataGridView1.Columns["day_16"].DataPropertyName = "day_16";
            dataGridView1.Columns["day_17"].DataPropertyName = "day_17";
            dataGridView1.Columns["day_18"].DataPropertyName = "day_18";
            dataGridView1.Columns["day_19"].DataPropertyName = "day_19";
            dataGridView1.Columns["day_20"].DataPropertyName = "day_20";
            dataGridView1.Columns["day_21"].DataPropertyName = "day_21";
            dataGridView1.Columns["day_22"].DataPropertyName = "day_22";
            dataGridView1.Columns["day_23"].DataPropertyName = "day_23";
            dataGridView1.Columns["day_24"].DataPropertyName = "day_24";
            dataGridView1.Columns["day_25"].DataPropertyName = "day_25";
            dataGridView1.Columns["day_26"].DataPropertyName = "day_26";
            dataGridView1.Columns["day_27"].DataPropertyName = "day_27";
            dataGridView1.Columns["day_28"].DataPropertyName = "day_28";
            dataGridView1.Columns["day_29"].DataPropertyName = "day_29";
            dataGridView1.Columns["day_30"].DataPropertyName = "day_30"; 
            dataGridView1.Columns["day_31"].DataPropertyName = "day_31";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
              dataGridView1.RowTemplate.Height = (dataGridView1.ClientRectangle.Height - dataGridView1.ColumnHeadersHeight) / dataGridView1.Rows.Count;
            } 
        }
        private void get_date_note(DateTime date)
        {
            DataTable dt=  hr.get_cal_date_by_date(date.ToString("yyyy-MM-dd"));
            cb_ot.Text= dt.Rows[0]["ot_code"].ToString();
            txtnote.Text= dt.Rows[0]["Day_name"].ToString();
        }
        private void frmCalendar_Load(object sender, EventArgs e)
        {
            dataGridView1.DoubleBuffered(true);
            load_year_cal();

            dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.FromArgb(237, 237, 237);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(237, 237, 237);
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.EnableHeadersVisualStyles = false;
        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            if(e.RowIndex>=0 && e.ColumnIndex>0 && dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString() != "")
            {
                txtdate.Text = DateTime.Now.Year + "-" + (e.RowIndex + 1).ToString("D2") + "-" + (e.ColumnIndex).ToString("D2");
                get_date_note(txtdate.Value); 
            }  
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex > 0 && dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString() != "")
            {
                string date = DateTime.Now.Year + "-" + (e.RowIndex + 1).ToString("D2") + "-" + (e.ColumnIndex).ToString("D2");

                DataTable tn = new DataTable();
                tn = hr.get_cal_date_by_date(date);
                if (tn.Rows[0]["ot_code"].ToString() == "2")
                    dataGridView1.Rows[e.RowIndex].Cells[(e.ColumnIndex)].Style.BackColor = Color.Orange;
                //dataGridView1.Rows[cell.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
                else if (tn.Rows[0]["ot_code"].ToString() == "3")
                    dataGridView1.Rows[e.RowIndex].Cells[(e.ColumnIndex)].Style.BackColor   = Color.Red;
            }
        }

        private void ctr_hrmenu1_Load(object sender, EventArgs e)
        {

        }
    }
}
