using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMCL_MIS
{
    public partial class frm_calendar_a : Form
    {
        GC_HR hr = new GC_HR();
        public frm_calendar_a()
        {
            InitializeComponent();
        }
        private void load_calendar()
        {
            int month = int.Parse(DateTime.Now.ToString("MM"));
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            
            DateTime date = DateTime.Now;
            var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            int firstweek = GetIso8601WeekOfYear(firstDayOfMonth);
            int lastweek = GetIso8601WeekOfYear(lastDayOfMonth);
            DataTable dt = new DataTable();
            for (int i = firstweek; i <= lastweek; i++)
            {
                DataTable t = new DataTable();
                t = hr.get_cal_by_week(month, i);
                dt.Merge(t);
            } dataGridView1.DataSource = dt;
            dataGridView1.Columns["w"].DataPropertyName = "w";
            dataGridView1.Columns["T2"].DataPropertyName = "T2";
            dataGridView1.Columns["T3"].DataPropertyName = "T3";
            dataGridView1.Columns["T4"].DataPropertyName = "T4";
            dataGridView1.Columns["T5"].DataPropertyName = "T5";
            dataGridView1.Columns["T6"].DataPropertyName = "T6";
            dataGridView1.Columns["T7"].DataPropertyName = "T7";
            dataGridView1.Columns["CN"].DataPropertyName = "CN";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.RowTemplate.Height = (dataGridView1.ClientRectangle.Height - dataGridView1.ColumnHeadersHeight) / dataGridView1.Rows.Count;
            }

        }
        private void frm_calendar_a_Load(object sender, EventArgs e)
        {
            dataGridView1.DoubleBuffered(true);
            load_calendar();
            DateTime date = DateTime.Now;
            label1.Text = date.ToString("MM/yyyy").ToUpper();
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.FromArgb(237, 237, 237);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(237, 237, 237);
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.EnableHeadersVisualStyles = false;
        
        }
        public static int GetIso8601WeekOfYear(DateTime time)
        {
            // Seriously cheat.  If its Monday, Tuesday or Wednesday, then it'll 
            // be the same week# as whatever Thursday, Friday or Saturday are,
            // and we always get those right
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            // Return the week of our adjusted day
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string des = "";
            if (dataGridView1.Rows[e.RowIndex].Cells[(e.ColumnIndex)].Value != null&& Extensions.EmptyIfNull(dataGridView1.Rows[e.RowIndex].Cells[(e.ColumnIndex)].Value )!="")
            {
                if (e.RowIndex >= 0 && e.ColumnIndex > 0 && dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString() != "")
                {
                    string[] tokens = dataGridView1.Rows[e.RowIndex].Cells[(e.ColumnIndex)].Value.ToString().Split(new char[] { '_' });
                    if (tokens.Length > 1)
                    {
                         des = tokens[2];
                        string date = tokens[1];

                        DataTable tn = new DataTable();
                        tn = hr.get_cal_date_by_date(date);
                        if (date == DateTime.Now.ToString("yyyy-MM-dd"))
                        {
                            dataGridView1.Rows[e.RowIndex].Cells[(e.ColumnIndex)].Style.ForeColor = Color.Red; 
                        }

                        if (tn.Rows[0]["ot_code"].ToString() == "2") { 
                            dataGridView1.Rows[e.RowIndex].Cells[(e.ColumnIndex)].Style.BackColor = Color.FromArgb(255, 214, 153);
                        }
                        else if (tn.Rows[0]["ot_code"].ToString() == "3")
                        {
                            dataGridView1.Rows[e.RowIndex].Cells[(e.ColumnIndex)].Style.BackColor = Color.FromArgb(255, 173, 153);

                        }
                        label2.Text=this.dataGridView1.Rows[e.RowIndex].Cells[(e.ColumnIndex)].ToolTipText = des;

                    }
                    dataGridView1.Rows[e.RowIndex].Cells[(e.ColumnIndex)].Value = tokens[0];
                    //dataGridView1.Rows[e.RowIndex].Cells[(e.ColumnIndex)].ToolTipText = Regex.Replace(
                    //dataGridView1.Rows[e.RowIndex].Cells[(e.ColumnIndex)].Value.ToString(), "_", Environment.NewLine); 
                } 
            }
            else
                dataGridView1.Rows[e.RowIndex].Cells[(e.ColumnIndex)].Style.BackColor = Color.LightGray;
            //}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex > 0 && dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString() != "")
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[(e.ColumnIndex)].Value != null && Extensions.EmptyIfNull(dataGridView1.Rows[e.RowIndex].Cells[(e.ColumnIndex)].Value) != "")
                {

                    label2.Text = this.dataGridView1.Rows[e.RowIndex].Cells[(e.ColumnIndex)].ToolTipText;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 