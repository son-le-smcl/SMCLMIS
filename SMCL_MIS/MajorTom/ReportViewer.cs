using CrystalDecisions.CrystalReports.Engine;
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
    public partial class ReportViewer : Form
    {
        public ReportViewer()
        {
            InitializeComponent();
        }

        public void set_report_datasource(DataTable dt)
        {
            GC_Purchasing p = new GC_Purchasing();
            ReportDocument cryRpt = new ReportDocument();
            string t = @"\\192.168.84.2\Public\MyDriver\SMCL_MIS\Print\rp_po.rpt";
            cryRpt.Load(t);
            //DataTable dt = p.get_po_line_by_pono("POCH17100003");
            int mimimum_row = Extensions.set_rp_row;
            if ((mimimum_row - (dt.Rows.Count)) > 0)
            {
                int add = mimimum_row - (dt.Rows.Count);
                for (int i = 0; i < add; i++)
                {
                    DataRow dr = dt.NewRow();
                    dt.Rows.Add(dr);
                }
            }
            else
            {
                int add = mimimum_row;
                for (int i = 0; i < add; i++)
                {
                    DataRow dr = dt.NewRow();
                    dt.Rows.Add(dr);
                }

            }
            int tc = dt.Rows.Count;
            cryRpt.SetDataSource(dt);
            cryRpt.SetDatabaseLogon("sa", "Sunluxe@123");
            rpViewer1.ReportSource = cryRpt;
            rpViewer1.Refresh();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
                
        }
    }
}
