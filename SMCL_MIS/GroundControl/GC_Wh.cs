using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCL_MIS
{
    class GC_Wh
    {
        Igni ignition = new Igni();

        public DataTable get_trn_type()
        {
            return ignition.Tincan("select * from smcl_trn_type;");
        }
        public DataTable get_transaction_by_date(DateTime form, DateTime to)
        {
            string sql = ""; 
            sql = sql + "select TRN_DATE Date" + Environment.NewLine;
            sql = sql + ",TRN_NO Transaction_number" + Environment.NewLine;
            sql = sql + ", TRN_TYPE Type" + Environment.NewLine;
            sql = sql + ",line" + Environment.NewLine;
            sql = sql + ",PART_NO Part_number" + Environment.NewLine;
            sql = sql + ",(select PartName from Com_STK01 where Com_STK01.PartNo = Part_No)Name" + Environment.NewLine;
            sql = sql + ",TRN_QTY Qty1" + Environment.NewLine;
            sql = sql + ",(select UOFM from Com_STK01 where PartNo = Com_TRN01.Part_No)bom_Uom" + Environment.NewLine;
            sql = sql + ",TRN_QTY / (select POXSTK from Com_STK01 where PartNo = Com_TRN01.Part_No) Qty2" + Environment.NewLine;
            sql = sql + ",(select POUOFM from Com_STK01 where PartNo = Com_TRN01.Part_No)PO_Uom" + Environment.NewLine;
            sql = sql + ",(select POXSTK from Com_STK01 where PartNo = Com_TRN01.Part_No)Convert_Rate" + Environment.NewLine;
            sql = sql + ",TRN_BY" + Environment.NewLine;
            sql = sql + ",PONO PO_Number" + Environment.NewLine;
            sql = sql + ", JOBNO SO_Number" + Environment.NewLine;
            sql = sql + ",MARK" + Environment.NewLine;
            sql = sql + ",CrUser" + Environment.NewLine;
            sql = sql + ",ref_no LOCF" + Environment.NewLine;
            sql = sql + ", LOCT, POXSTK Rate" + Environment.NewLine;
            sql = sql + ",(select GLID from Com_STK01 where PartNo = Com_TRN01.Part_No)Bom_Type" + Environment.NewLine;
            sql = sql + "from Com_TRN01" + Environment.NewLine;
            sql = sql + "where LOCF = ''" + Environment.NewLine;
            sql = sql + "and CONVERT(date, TRN_DATE) between '"+form+"' and '"+to+"'" + Environment.NewLine;
            sql = sql + "Union" + Environment.NewLine;
            sql = sql + "select TRN_DATE,TRN_NO,TRN_TYPE,line,PART_NO" + Environment.NewLine;
            sql = sql + ",(select PartName from Com_STK01 where Com_STK01.PartNo = Part_No)partname,TRN_QTY Qty1" + Environment.NewLine;
            sql = sql + ",(select UOFM from Com_STK01 where PartNo = Com_TRN01.Part_No)bom_Uom" + Environment.NewLine;
            sql = sql + ",TRN_QTY / (select POXSTK from Com_STK01 where PartNo = Com_TRN01.Part_No) Qty2" + Environment.NewLine;
            sql = sql + ",(select POUOFM from Com_STK01 where PartNo = Com_TRN01.Part_No)PO_Uom" + Environment.NewLine;
            sql = sql + ",(select POXSTK from Com_STK01 where PartNo = Com_TRN01.Part_No)Convert_Rate" + Environment.NewLine;
            sql = sql + ",TRN_BY,PONO PO_Number, JOBNO SO_Number,MARK,CrUser,ref_no LOCF, LOCT, POXSTK Rate" + Environment.NewLine;
            sql = sql + ",(select GLID from Com_STK01 where PartNo = Com_TRN01.Part_No)Bom_Type from Com_TRN01" + Environment.NewLine;
            sql = sql + "where LOCT = ''" + Environment.NewLine;
            sql = sql + "and CONVERT(date, TRN_DATE) between '"+form+"' and '"+to+"'" + Environment.NewLine;
            sql = sql + "Union" + Environment.NewLine;
            sql = sql + "select TRN_DATE,TRN_NO,TRN_TYPE,line,PART_NO" + Environment.NewLine;
            sql = sql + ",(select PartName from Com_STK01 where Com_STK01.PartNo = Part_No)partname,TRN_QTY Qty1" + Environment.NewLine;
            sql = sql + ",(select UOFM from Com_STK01 where PartNo = Com_TRN01.Part_No)bom_Uom" + Environment.NewLine;
            sql = sql + ",TRN_QTY / (select POXSTK from Com_STK01 where PartNo = Com_TRN01.Part_No) Qty2" + Environment.NewLine;
            sql = sql + ",(select POUOFM from Com_STK01 where PartNo = Com_TRN01.Part_No)PO_Uom" + Environment.NewLine;
            sql = sql + ",(select POXSTK from Com_STK01 where PartNo = Com_TRN01.Part_No)Convert_Rate" + Environment.NewLine;
            sql = sql + ",TRN_BY,PONO PO_Number, JOBNO SO_Number,MARK,CrUser,ref_no LOCF, LOCT, POXSTK Rate" + Environment.NewLine;
            sql = sql + ",(select GLID from Com_STK01 where PartNo = Com_TRN01.Part_No)Bom_Type from Com_TRN01" + Environment.NewLine;
            sql = sql + "where LOCF != '' and LOCT != ''" + Environment.NewLine;
            sql = sql + "and CONVERT(date, TRN_DATE) between '"+form+ "' and '"+to+"'" + Environment.NewLine;

            return ignition.Tincan(sql);

        }
    }
}
