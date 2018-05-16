using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCL_MIS
{
    class GC_HR
    {
        Igni ignition = new Igni();
        public DataTable get_cal_date_by_date(string date)
        {
            string sql = "select * from smcl_hr_workday" + Environment.NewLine;
            sql += "where dateid = '"+ date + "'";
            return ignition.Tincan(sql);
        }
        public DataTable get_cal_by_month(int month)
        {
            return ignition.Tincan("exec Prod_get_calendar_by_month " + month + "");
        }
        public DataTable get_cal_by_week(int month,int week)
        {
            return ignition.Tincan("exec prod_get_calendar_by_week " + month + ","+week+"");
        }
    }
}
