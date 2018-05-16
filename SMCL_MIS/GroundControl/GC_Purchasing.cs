using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCL_MIS
{
    class GC_Purchasing
    { 
        Igni ignition = new Igni();
        public void delete_po(string pono)
        {
            string sql = "DELETE FROM [dbo].[COM_POH]  WHERE PONO='"+ pono + "'";
            string sql2 = "DELETE FROM [dbo].[COM_POD]  WHERE PONO='" + pono + "'";
            ignition.ExeCuteNonQuery(sql);
            ignition.ExeCuteNonQuery(sql2);
        }
        public void update_mat(string partno,string POUOFM,float Poxstk, string Buyer,string WlType ,string ProdWay)
        {
            string sql = "";
            sql += "update Com_STK01" + Environment.NewLine;
            sql += "Set POUOFM = '"+ POUOFM + "'" + Environment.NewLine;
            sql += ", Poxstk = " + Poxstk + "" + Environment.NewLine;
            sql += ", Buyer = '" + Buyer + "'" + Environment.NewLine;
            sql += ", WlType = '" + WlType + "'" + Environment.NewLine;
            sql += ", ProdWay = '" + ProdWay + "'" + Environment.NewLine;
            sql += "where PartNo = '" + partno + "';" + Environment.NewLine;
            ignition.ExeCuteNonQuery(sql);
        }
        public DataTable get_buyer()
        {
            string sql = "";
            sql += "  select UserID from com_User" + Environment.NewLine;
            sql = sql + "where DeptID = 'PURCHASING'" + Environment.NewLine;
            return ignition.Tincan(sql);
        }

        public DataTable get_all_mat()
        {
            string sql = "";
            sql+= "select partno Part_Number,partname Description,UOFM INV_UOM,Poxstk Rate,POUOFM PO_UOM,S_TYPE Category,WlAttr Bom_Type,WlType Rank,ProdWay MakeOrBuy,Buyer,Partloc " + Environment.NewLine;
            sql = sql + "from Com_STK01" + Environment.NewLine;
            sql = sql + "where DEAD = 0" + Environment.NewLine;
            return ignition.Tincan(sql);
        }
        public DataTable get_Quoteinfo(DateTime from, DateTime to)
        {
            string sql = " select h.BJID Quote_ID,BJDate Quote_Date,h.VendID Supplier_ID,h.Status,h.CrUser Create_User,h.CrDate Create_date,h.AppUser Approve_User,h.AppDate Approve_Date," + Environment.NewLine;
            sql = sql+ "d.PartNO Part_number,p.PartName ,p.POUOFM Uom,d.Price* p.Poxstk Price, d.Lead,d.MaxSup,d.Remark," + Environment.NewLine;
            sql = sql + "v.VendName Supplier_Name,v.TaxId,v.TermsCode,v.WRType, v.HB Currendcy" + Environment.NewLine;
            sql = sql + "from" + Environment.NewLine;
            sql = sql + "COM_POBJDH h," + Environment.NewLine;
            sql = sql + "COM_POBJDD d," + Environment.NewLine;
            sql = sql + "Com_STK01 p," + Environment.NewLine;
            sql = sql + "COM_Apven v" + Environment.NewLine;
            sql = sql + "where h.BJID = d.BJID" + Environment.NewLine;
            sql = sql + "and d.PartNO = p.PartNo" + Environment.NewLine;
            sql = sql + "and h.VendID = v.VendID order by h.crdate desc,h.bjid desc" + Environment.NewLine;
             
            return ignition.Tincan(sql);
        }
        public DataTable get_poinfo(DateTime from, DateTime to)
        {
            string sql = "select " + Environment.NewLine;
            sql = sql + "'' Warning," + Environment.NewLine;
            sql =  sql+ "d.PONO," + Environment.NewLine;
            sql = sql + "h.ODate Po_Date," + Environment.NewLine;
            sql = sql + "h.PoType Po_Type," + Environment.NewLine;
            sql = sql + "h.STATUS," + Environment.NewLine;
            sql = sql + "h.CrDate Create_date," + Environment.NewLine;
            sql = sql + "h.CrUser Create_User," + Environment.NewLine;
            sql = sql + "h.AppUser Approve_User," + Environment.NewLine;
            sql = sql + "h.AppDate Approve_Date," + Environment.NewLine;
            sql = sql + "h.Remark," + Environment.NewLine;
            sql = sql + "h.JSFS Shipping_Type," + Environment.NewLine;
            sql = sql + "d.PartNO Part_number," + Environment.NewLine;
            sql = sql + "REPLACE(REPLACE(RTRIM(LTRIM(part.PartName )), CHAR(13), ''), CHAR(10), '')Name," + Environment.NewLine;
            sql = sql + "d.ORDERED/d.POXSTK ORDERED," + Environment.NewLine; 
            sql = sql + "d.RECEIVED/d.POXSTK RECEIVED," + Environment.NewLine;
            sql = sql + "part.POUOFM UOM," + Environment.NewLine; 
            sql = sql + "d.Price*d.POXSTK Price," + Environment.NewLine;
            sql = sql + "d.RecDate," + Environment.NewLine;
            sql = sql + "d.JOBNO So_No," + Environment.NewLine;
            sql = sql + "d.POXSTK Rate," + Environment.NewLine;
            sql = sql + "d.Loc," + Environment.NewLine;
            sql = sql + "d.Remark," + Environment.NewLine;
            sql = sql + "d.Filed1 Quote_Number," + Environment.NewLine;
            sql = sql + "sup.VendID Supplier_ID," + Environment.NewLine;
            sql = sql + "sup.VendName Supplier_Name," + Environment.NewLine;
            sql = sql + "sup.Address," + Environment.NewLine;
            sql = sql + "sup.TermsCode Payment_Terms," + Environment.NewLine;
            sql = sql + "sup.TaxId," + Environment.NewLine;
            sql = sql + "sup.GLType," + Environment.NewLine;
            sql = sql + "sup.HB Currency," + Environment.NewLine;
            sql = sql + "sup.PurValue Class," + Environment.NewLine;
            sql = sql + "sup.VendAccountNO Bank_Account," + Environment.NewLine;
            sql = sql + "sup.VendBank Bank_name," + Environment.NewLine;
            sql = sql + "sup.JSFS Supplier_Ship_Type," + Environment.NewLine;
            sql = sql + "sup.WRType" + Environment.NewLine;
            sql = sql + "from" + Environment.NewLine;
            sql = sql + "COM_POD d," + Environment.NewLine;
            sql = sql + "COM_POH h," + Environment.NewLine;
            sql = sql + "COM_Apven sup," + Environment.NewLine;
            sql = sql + "Com_STK01 part" + Environment.NewLine;
            sql = sql + "where" + Environment.NewLine;
            sql = sql + "d.PONO = h.PONO" + Environment.NewLine;
            sql = sql + "and d.PartNO = part.PartNo" + Environment.NewLine;
            sql = sql + "and d.ordered>0" + Environment.NewLine;
            sql = sql + "and h.VendID = sup.VendID" + Environment.NewLine;
            sql = sql + "and ODate between '"+ from + "' and '" + to + "'" + Environment.NewLine;
            sql = sql + "order by" + Environment.NewLine;
            sql = sql + "h.ODate desc, h.PONO desc";
            return ignition.Tincan(sql);
        }

        public void approve_po(string sono, string sts, string appdateuser, DateTime appdate)
        {
            string str = "UPDATE[dbo].[Com_POH]";
            str = str + "SET status = '{0}'" + Environment.NewLine;
            str = str + ",appuser = '{1}'" + Environment.NewLine;
            str = str + ",appdate = '{2}'" + Environment.NewLine;
            str = str + "WHERE PONO='{3}'" + Environment.NewLine;
            str = string.Format(str, sts, appdateuser, appdate, sono);
            ignition.ExeCuteNonQuery(str);
        }

        public void delete_pod(DataTable t_del,string pono)
        {
            if (t_del.Rows.Count > 0)
            {
                foreach (DataRow row in t_del.Rows)
                {
                    string str = "Delete from com_po where pono='"+ pono + "' and line =" + row[0] + "";
                    ignition.ExeCuteNonQuery(str);
                }
            }
        }

        public DataTable get_quote_by_partno(string partno,string vendno)
        {
            string sql = "select top 1 d.PartNO," + Environment.NewLine;
            sql = sql + "(select PartName from Com_STK01 where Com_STK01.PartNo = d.PartNO) _Description," + Environment.NewLine;
            sql = sql + "d.Price*(select POXSTK from Com_STK01 where Com_STK01.PartNo = d.PartNO) Price," + Environment.NewLine;
            sql = sql + "(select POUOFM from Com_STK01 where Com_STK01.PartNo = d.PartNO) UOM," + Environment.NewLine;
            sql = sql + "VendID,h.BJID," + Environment.NewLine;
            sql = sql + "(select POXSTK from Com_STK01 where Com_STK01.PartNo = d.PartNO) rate" + Environment.NewLine;
            sql = sql + "from COM_POBJDH h, COM_POBJDD d" + Environment.NewLine;
            sql = sql + "where h.BJID = d.BJID" + Environment.NewLine;
            sql = sql + "and VendID = '"+ vendno + "'" + Environment.NewLine;
            sql = sql + "and PartNO = '"+ partno + "'" + Environment.NewLine;
            sql = sql + "and h.Status = 'Approval'" + Environment.NewLine;
            sql = sql + "order by h.BJDate desc, h.BJID desc" + Environment.NewLine;
            return ignition.Tincan(sql);
        }

        public DataTable emptyline()
        {
            string sql;
            sql = " select top 1 " + Environment.NewLine;
            sql = sql + "'' PONO" + Environment.NewLine;
            sql = sql + ",null Line" + Environment.NewLine;
            sql = sql + ",'' PartNO" + Environment.NewLine;
            sql = sql + ",'' Description" + Environment.NewLine;
            sql = sql + ",null ORDERED" + Environment.NewLine;
            sql = sql + ",null RECEIVED" + Environment.NewLine;
            sql = sql + ",null Price" + Environment.NewLine;
            sql = sql + ",'' RecDate" + Environment.NewLine;
            sql = sql + ",null POXSTK" + Environment.NewLine;
            sql = sql + ",'' JOBNO" + Environment.NewLine;
            sql = sql + ",'' Remark" + Environment.NewLine;
            sql = sql + ",'' Quoteno" + Environment.NewLine;
            sql = sql + ",'' shiploc from Com_POD" + Environment.NewLine;
            return ignition.Tincan(sql);
        }

        public DataTable get_loch()
        {
            string sql = "select * from Com_LocH;";
            return ignition.Tincan(sql);
        }

        public DataTable get_transport_type()
        {
            string sql = "SELECT postvalue,name FROM smcl_po_st" + Environment.NewLine;
            sql = sql + "where posttype = 'transport_type'";
            return ignition.Tincan(sql);
        }

        public void update_pod(string pono, int line, string partno, float oderqty, DateTime recdate,
            int rate, string jobno, string remark, string loc, float price, string quote,string currency,string uom)
        {
            string sql = "";
            sql = sql + "UPDATE[dbo].[COM_POD]" + Environment.NewLine;
            sql = sql + "SET [PartNO] = '"+partno+"'" + Environment.NewLine;
            sql = sql + ",[ORDERED] = "+oderqty+"" + Environment.NewLine;  
            sql = sql + ",[Price] = "+price+"" + Environment.NewLine;
            sql = sql + ",[RecDate] = '"+recdate+"'" + Environment.NewLine;
            sql = sql + ",[EndRecDate] = '" + recdate + "'" + Environment.NewLine;
            sql = sql + ",[POXSTK] = " + rate + "" + Environment.NewLine;
            sql = sql + ",[JOBNO] = '" + jobno + "'" + Environment.NewLine; 
            sql = sql + ",[Remark] = N'" + remark + "'" + Environment.NewLine;
            sql = sql + ",[Loc] = '" + loc + "'" + Environment.NewLine;  
            sql = sql + ",[Quoteno] = '" + quote + "'" + Environment.NewLine;
            sql = sql + ",[currency] = '" + currency + "'" + Environment.NewLine;
            sql = sql + ",[UOM] = '" + uom + "'" + Environment.NewLine;
            sql = sql + "WHERE PONO='"+ pono + "' and line ="+line+"" + Environment.NewLine;
            ignition.ExeCuteNonQuery(sql);
        }

        public void new_pod(string pono, int line,string partno, float oderqty,DateTime recdate,
            int rate,string jobno, string remark, string loc, float price,string quote,string currency,string uom)
        {
            string sql = "";
            sql = sql + "INSERT INTO[dbo].[COM_POD]" + Environment.NewLine;
            sql = sql + "([PONO]" + Environment.NewLine;
            sql = sql + ",[Line]" + Environment.NewLine;
            sql = sql + ",[PartNO]" + Environment.NewLine;
            sql = sql + ",[ORDERED]" + Environment.NewLine;
            sql = sql + ",[tRece]" + Environment.NewLine;
            sql = sql + ",[RECEIVED]" + Environment.NewLine;
            sql = sql + ",[Price]" + Environment.NewLine;
            sql = sql + ",[RecDate]" + Environment.NewLine;
            sql = sql + ",[EndRecDate]" + Environment.NewLine;
            sql = sql + ",[POXSTK]" + Environment.NewLine;
            sql = sql + ",[JOBNO]" + Environment.NewLine;
            sql = sql + ",[FGNO]" + Environment.NewLine;
            sql = sql + ",[Remark]" + Environment.NewLine;
            sql = sql + ",[Loc]" + Environment.NewLine;
            sql = sql + ",[mono]" + Environment.NewLine;
            sql = sql + ",[RqType]" + Environment.NewLine;
            sql = sql + ",[Filed1]" + Environment.NewLine;
            sql = sql + ",[Filed2]" + Environment.NewLine;
            sql = sql + ",[Filed3]" + Environment.NewLine;
            sql = sql + ",[Filed4]" + Environment.NewLine;
            sql = sql + ",[currency]" + Environment.NewLine;
            sql = sql + ",[UOM]" + Environment.NewLine;
            sql = sql + ",[Quoteno]" + Environment.NewLine;
            sql = sql + ",[Filed5])" + Environment.NewLine;
            sql = sql + "VALUES" + Environment.NewLine;
            sql = sql + "('"+pono+"'" + Environment.NewLine;
            sql = sql + ","+line+"" + Environment.NewLine;//<Line, int,>
            sql = sql + ",N'" + partno + "'" + Environment.NewLine;//<PartNO, nvarchar(30),>
            sql = sql + "," + oderqty + "" + Environment.NewLine;//<ORDERED, float,>
            sql = sql + ",0" + Environment.NewLine;//<tRece, float,>
            sql = sql + ",0" + Environment.NewLine;//<RECEIVED, float,>
            sql = sql + "," + price + "" + Environment.NewLine;//<Price, float,>
            sql = sql + ",N'" + recdate + "'" + Environment.NewLine;//<RecDate, datetime,>
            sql = sql + ",N'" + recdate + "'" + Environment.NewLine;//<EndRecDate, datetime,>
            sql = sql + "," + rate + "" + Environment.NewLine;//<POXSTK, float,>
            sql = sql + ",N'" + jobno + "'" + Environment.NewLine;//<JOBNO, nvarchar(50),>
            sql = sql + ",N''" + Environment.NewLine;//<FGNO, nvarchar(24),>
            sql = sql + ",N'" + remark + "'" + Environment.NewLine;//<Remark, nvarchar(20),>
            sql = sql + ",N'" + loc + "'" + Environment.NewLine;//<Loc, nvarchar(10),>
            sql = sql + ",N''" + Environment.NewLine;//<mono, nvarchar(50),>
            sql = sql + ",N''" + Environment.NewLine;//<RqType, nvarchar(10),>
            sql = sql + ",N''" + Environment.NewLine;//<Filed1, nvarchar(20),>
            sql = sql + ",N''" + Environment.NewLine;//<Filed2, nvarchar(20),>
            sql = sql + ",N''" + Environment.NewLine;//<Filed3, nvarchar(10),>
            sql = sql + ",0" + Environment.NewLine;//<Filed4, float,>
            sql = sql + ",N''" + Environment.NewLine;//<curency, nvarchar(10),>
            sql = sql + ",N''" + Environment.NewLine;//uom
            sql = sql + ",N'" + quote + "'" + Environment.NewLine;//<quoteno
            sql = sql + ",N'" + DateTime.Now + "')" + Environment.NewLine;//<Filed5, datetime,>
            ignition.ExeCuteNonQuery(sql);
        }

        public void update_poh(string pono, string type, string vendid, int itemcnt, string buyer,
            string shipto, DateTime odate, int taxid, string remark, int rate,string filed1, string jsfs)
        {
            string sql = "";
            sql = sql + "UPDATE[dbo].[COM_POH]" + Environment.NewLine;
            sql = sql + "SET [PoType] = '"+type+"'" + Environment.NewLine;  
            sql = sql + ",[VendID] = '"+vendid+"'" + Environment.NewLine;
            sql = sql + ",[ITEM_CNT] ="+itemcnt+" " + Environment.NewLine;
            sql = sql + ",[BUYER] = '"+buyer+"'" + Environment.NewLine;
            sql = sql + ",[SIPTO1] = '"+shipto+"'" + Environment.NewLine; 
            sql = sql + ",[ODate] = '"+odate+"'" + Environment.NewLine;
            sql = sql + ",[TaxID] = "+taxid+"" + Environment.NewLine;
            sql = sql + ",[Remark] = 'N"+remark+"'" + Environment.NewLine;
            sql = sql + ",[Rate] = "+rate+"" + Environment.NewLine;   
            sql = sql + ",[JSFS] = '"+jsfs+"'" + Environment.NewLine;
            sql = sql + ",[Filed1] = '"+filed1+"'" + Environment.NewLine; 
            sql = sql + "WHERE PONO='"+pono+"'" + Environment.NewLine;
            ignition.ExeCuteNonQuery(sql);
        }

        public void new_Poh(string pono,string potype, string vendid,int itemcnt, string buyer,
            string shipto,string jhbatch,DateTime odate,int taxid, string remark, int rate,string cruser,
            DateTime crdate,string appuser, string appdate,string send,string filed1,string jsfs)
        {
            string status = "Draft";
            string pozd = "Manual";
            string sql = "";
            sql = sql + "INSERT INTO[dbo].[COM_POH]" + Environment.NewLine;
            sql = sql + "([PONO]" + Environment.NewLine;
            sql = sql + ",[PoType]" + Environment.NewLine;
            sql = sql + ",[POZD]" + Environment.NewLine;
            sql = sql + ",[STATUS]" + Environment.NewLine;
            sql = sql + ",[VendID]" + Environment.NewLine;
            sql = sql + ",[ITEM_CNT]" + Environment.NewLine;
            sql = sql + ",[BUYER]" + Environment.NewLine;
            sql = sql + ",[SIPTO1]" + Environment.NewLine;
            sql = sql + ",[JHBatch]" + Environment.NewLine;
            sql = sql + ",[ODate]" + Environment.NewLine;
            sql = sql + ",[TaxID]" + Environment.NewLine;
            sql = sql + ",[Remark]" + Environment.NewLine;
            sql = sql + ",[Rate]" + Environment.NewLine;
            sql = sql + ",[CrUser]" + Environment.NewLine;
            sql = sql + ",[CrDate]" + Environment.NewLine;
            sql = sql + ",[AppUser]" + Environment.NewLine;
            sql = sql + ",[AppDate]" + Environment.NewLine;
            sql = sql + ",[SEND]" + Environment.NewLine;
            sql = sql + ",[JSFS]" + Environment.NewLine;
            sql = sql + ",[Filed1]" + Environment.NewLine;
            sql = sql + ",[Filed2]" + Environment.NewLine;
            sql = sql + ",[Filed3]" + Environment.NewLine;
            sql = sql + " ,[Filed6]" + Environment.NewLine;
            sql = sql + ",[Filed4]" + Environment.NewLine;
            sql = sql + ",[Filed5])" + Environment.NewLine;
            sql = sql + "VALUES" + Environment.NewLine;
            sql = sql + "('"+pono+"'" + Environment.NewLine;//<PONO, nvarchar(30),>
            sql = sql + ",N'" + potype + "'" + Environment.NewLine;//< PoType, nvarchar(10),>
            sql = sql + ",N'" + pozd + "'" + Environment.NewLine;//< POZD, nvarchar(10),>
            sql = sql + ",N'" + status + "'" + Environment.NewLine;//< STATUS, nvarchar(10),>
            sql = sql + ",N'" + vendid + "'" + Environment.NewLine;//< VendID, nvarchar(20),>
            sql = sql + ",N'" + itemcnt + "'" + Environment.NewLine;//< ITEM_CNT, int,>
            sql = sql + ",N'" + buyer + "'" + Environment.NewLine;//< BUYER, nvarchar(40),>
            sql = sql + ",N'" + shipto + "'" + Environment.NewLine;//< SIPTO1, nvarchar(30),>
            sql = sql + ",N'" + jhbatch + "'" + Environment.NewLine;//< JHBatch, nvarchar(30),>
            sql = sql + ",N'" + odate + "'" + Environment.NewLine;//< ODate, datetime,>
            sql = sql + "," + taxid + "" + Environment.NewLine;//< TaxID, int,>
            sql = sql + ",N'" + remark + "'" + Environment.NewLine;//< Remark, nvarchar(70),>
            sql = sql + "," + rate + Environment.NewLine;//< Rate, float,>
            sql = sql + ",N'" + LoginInfo.username + "'" + Environment.NewLine;//< CrUser, nvarchar(20),>
            sql = sql + ",N'" + DateTime.Now + "'" + Environment.NewLine;//< CrDate, datetime,>
            sql = sql + ",N''" + Environment.NewLine;//< AppUser, nvarchar(20),>
            sql = sql + ",N'" + DateTime.Now + "'" + Environment.NewLine;//< AppDate, datetime,>
            sql = sql + ",N'" + send + "'" + Environment.NewLine;//< SEND, nvarchar(20),>
            sql = sql + ",N'" + jsfs + "'" + Environment.NewLine;//< JSFS, nvarchar(30),>
            sql = sql + ",N''" + Environment.NewLine;//< Filed1, nvarchar(20),>
            sql = sql + ",N''" + Environment.NewLine;//< Filed2, nvarchar(20),>
            sql = sql + ",N''" + Environment.NewLine;//< Filed3, nvarchar(20),>
            sql = sql + ",N''" + Environment.NewLine;//< Filed6, nvarchar(20),>
            sql = sql + ",0" + Environment.NewLine;//< Filed4, float,>
            sql = sql + ",N'"+DateTime.Now+"')" + Environment.NewLine;//< Filed5, datetime,>
            ignition.ExeCuteNonQuery(sql);
        }

        public DataTable get_po_head_by_pono(string pono)
        {
            string sql = "";
            sql = sql + "SELECT po.[PONO]" + Environment.NewLine;
            sql = sql + ",po.[PoType]" + Environment.NewLine;
            sql = sql + ",po.[POZD]" + Environment.NewLine;
            sql = sql + ",po.[STATUS]" + Environment.NewLine;
            sql = sql + ",po.[VendID]" + Environment.NewLine;
            sql = sql + ",[ITEM_CNT]" + Environment.NewLine;
            sql = sql + ",po.[BUYER]" + Environment.NewLine;
            sql = sql + ",po.[SIPTO1]" + Environment.NewLine;
            sql = sql + ",po.[JHBatch]" + Environment.NewLine;
            sql = sql + ",po.[ODate]" + Environment.NewLine;
            sql = sql + ",po.[TaxID]" + Environment.NewLine;
            sql = sql + ",po.[Remark]" + Environment.NewLine;
            sql = sql + ",po.[Rate]" + Environment.NewLine;
            sql = sql + ",po.[CrUser]" + Environment.NewLine;
            sql = sql + ",po.[CrDate]" + Environment.NewLine;
            sql = sql + ",po.[AppUser]" + Environment.NewLine;
            sql = sql + ",po.[AppDate]" + Environment.NewLine;
            sql = sql + ",po.[SEND]" + Environment.NewLine;
            sql = sql + ",po.[JSFS]" + Environment.NewLine;
            sql = sql + ",sup.VendName" + Environment.NewLine; 
            sql = sql + ",(select GroupDesc from Com_POTAX where TaxID=sup.TaxId) tax" + Environment.NewLine; 
            sql = sql + ",sup.HB" + Environment.NewLine; 
            sql = sql + ",sup.TermsCode" + Environment.NewLine; 
            sql = sql + ",sup.PurValue" + Environment.NewLine;
            sql = sql + " FROM[dbo].[COM_POH] po,COM_Apven sup" + Environment.NewLine;
            sql = sql + "where sup.VendID= po.VendID" + Environment.NewLine;
            sql = sql + "AND PONO ='"+ pono + "'" + Environment.NewLine; 
            return ignition.Tincan(sql); 
        }

        public DataTable get_po_line_by_pono(string pono)
        {
            string sql = "";
            sql = sql + " SELECT[PONO]" + Environment.NewLine;
            sql = sql + " ,[Line]" + Environment.NewLine;
            sql = sql + " ,[PartNO]" + Environment.NewLine;
            sql = sql + " ,(select POUOFM from Com_STK01 where com_stk01.partno=com_pod.partno)UOM" + Environment.NewLine;
            sql = sql + " ,(select PartName from Com_STK01 where com_stk01.partno=com_pod.partno)Description" + Environment.NewLine;
            sql = sql + " ,[ORDERED]/[POXSTK]ORDERED" + Environment.NewLine;
            sql = sql + " ,[tRece]" + Environment.NewLine;
            sql = sql + " ,[RECEIVED]/[POXSTK] RECEIVED" + Environment.NewLine;
            sql = sql + " ,[Price]*[POXSTK] Price" + Environment.NewLine;
            sql = sql + " ,([Price]*[POXSTK]) * ordered Amount" + Environment.NewLine;
            sql = sql + " ,[RecDate]" + Environment.NewLine;
            sql = sql + " ,[EndRecDate]" + Environment.NewLine;
            sql = sql + " ,[POXSTK]" + Environment.NewLine;
            sql = sql + " ,[JOBNO]" + Environment.NewLine;
            sql = sql + " ,[FGNO]" + Environment.NewLine;
            sql = sql + " ,[Remark]" + Environment.NewLine;
            sql = sql + " ,[Loc]" + Environment.NewLine;
            sql = sql + " ,[mono]" + Environment.NewLine;
            sql = sql + " ,[RqType]" + Environment.NewLine;
            sql = sql + " ,[Quoteno]" + Environment.NewLine;
            sql = sql + " FROM[dbo].[COM_POD]" + Environment.NewLine;
            sql = sql + " where [PONO]='"+ pono + "'" + Environment.NewLine;
            DataTable dt = new DataTable();
            dt = ignition.Tincan(sql);
            dt.Rows.Add();
            return dt;
        }

        public void approve_quote(string BJID, string status, string appuser,DateTime date)
        {
            string sql = "UPDATE [dbo].[COM_POBJDH]" + Environment.NewLine;
            sql = sql + "SET [Status] = '" + status + "'" + Environment.NewLine;
            sql = sql + ",[AppUser] = '" + appuser + "'" + Environment.NewLine;
            sql = sql + ",[AppDate] = '" + date + "'" + Environment.NewLine;
            sql = sql + "WHERE [BJID]='" + BJID + "'";
            ignition.ExeCuteNonQuery(sql);
        }

        public DataTable Quote_emptyline()
        {
            string sql="";
            sql = sql + "SELECT top 1 '' [BJID]" + Environment.NewLine;
            sql = sql + ",''  [PartNO]" + Environment.NewLine;
            sql = sql + ",null [Price]" + Environment.NewLine;
            sql = sql + ",null [Lead]" + Environment.NewLine;
            sql = sql + ",null [MaxSup]" + Environment.NewLine;
            sql = sql + ",'' [Remark]" + Environment.NewLine;
            sql = sql + ",'' [Filed1]" + Environment.NewLine;
            sql = sql +"FROM [dbo].[COM_POBJDD]" + Environment.NewLine; 
            return ignition.Tincan(sql);
        }

        public string get_mostrecent_quoteid()
        {
            string sql= "select top 1" + Environment.NewLine;
            sql = sql + "BJID from COM_POBJDH" + Environment.NewLine;
            sql = sql + "order by CrDate desc,BJID desc" + Environment.NewLine;
            return ignition.Tincan(sql).Rows[0][0].ToString();
        }

        public string get_mostrecent_PONO(string SUP)
        {
            string sql = "select top 1 pono from COM_POH" + Environment.NewLine;
            sql = sql + "WHERE PONO LIKE 'PO"+ SUP + "%'" + Environment.NewLine;
            sql = sql + "order by CrDate desc, PONO desc"; 
            return ignition.Tincan(sql).Rows[0][0].ToString();
        }

        public void new_quote_head(string BJID,string vendid,DateTime date,string status,string cruser, DateTime crdate,string appuser,DateTime appdate)
        {
            string sql = "INSERT INTO [dbo].[COM_POBJDH]" + Environment.NewLine;
           sql = sql+ "([BJID]" + Environment.NewLine;
            sql = sql + ",[VendID]" + Environment.NewLine;
            sql = sql + ",[BJDate]" + Environment.NewLine;
            sql = sql + ",[Status]" + Environment.NewLine;
            sql = sql + ",[CrUser]" + Environment.NewLine;
            sql = sql + ",[CrDate]" + Environment.NewLine;
            sql = sql + ",[AppUser]" + Environment.NewLine;
            sql = sql + ",[AppDate])" + Environment.NewLine;
            sql = sql + "VALUES" + Environment.NewLine;
            sql = sql + "('"+ BJID + "'" + Environment.NewLine;//< BJID, nvarchar(20),>
            sql = sql + ",'" + vendid + "'" + Environment.NewLine;//< VendID, nvarchar(20),>
            sql = sql + ",'" + date + "'" + Environment.NewLine;//< BJDate, datetime,>
            sql = sql + ",'" + status + "'" + Environment.NewLine;//< Status, nvarchar(10),>
            sql = sql + ",'" + cruser + "'" + Environment.NewLine;//< Status, nvarchar(10),>
            sql = sql + ",'" + crdate + "'" + Environment.NewLine;//< CrDate, datetime,>
            sql = sql + ",'" + appuser + "'" + Environment.NewLine;//< AppUser, nvarchar(20),>
            sql = sql + ",'" + appdate + "')" + Environment.NewLine;//< AppDate, datetime,>
            ignition.ExeCuteNonQuery(sql);
        }

        public bool check_exist_quote_line(string quoteno,string partno)
        { 
                if (ignition.Tincan("Select bjid from COM_POBJDD where bjid='" + quoteno + "' and partno='"+ partno + "';").Rows.Count > 0)
                    return true;
                else
                    return false; 
        }

        public void update_quote_head(string BJID, string vendid, DateTime date)
        {
            string sql = "UPDATE [dbo].[COM_POBJDH]" + Environment.NewLine;
            sql = sql + "SET [VendID] = '"+vendid+"'" + Environment.NewLine;
            sql = sql + ",[BJDate] = '"+date+"'" + Environment.NewLine;  
            sql = sql + "WHERE [BJID]='"+BJID+"'";
            ignition.ExeCuteNonQuery(sql);
        }

        public void new_quote_line(string BJID,string PartNO,float Price,int Lead,int maxsup,string Remark,string Filed1)
        {
            string sql = "INSERT INTO [dbo].[COM_POBJDD]" + Environment.NewLine;
            sql = sql + "([BJID]" + Environment.NewLine;
            sql = sql + ",[PartNO]" + Environment.NewLine;
            sql = sql + ",[Price]" + Environment.NewLine;
            sql = sql + ",[Lead]" + Environment.NewLine;
            sql = sql + ",[MaxSup]" + Environment.NewLine;
            sql = sql + ",[Remark]" + Environment.NewLine;
            sql = sql + ",[Filed1])" + Environment.NewLine; 
            sql = sql + "VALUES" + Environment.NewLine;
            sql = sql + "('"+BJID+"'" + Environment.NewLine;//< BJID, nvarchar(20),>
            sql = sql + ",'"+PartNO+"'" + Environment.NewLine;//< PartNO, nvarchar(30),>
            sql = sql + ","+Price+"" + Environment.NewLine;//< Price, float,>
            sql = sql + ","+Lead+"" + Environment.NewLine;//< Lead, int,>
            sql = sql + ","+maxsup+"" + Environment.NewLine;//< MaxSup, float,>
            sql = sql + ",N'"+Remark+"'" + Environment.NewLine;//< Remark, nvarchar(30),>
            sql = sql + ",'"+Filed1+"' )" + Environment.NewLine;//< Filed1, nvarchar(30),>  
            ignition.ExeCuteNonQuery(sql);

        }

        public void update_quote_line(string BJID, string PartNO, float Price, int Lead, int maxsup, string Remark, string Filed1)
        {
            string sql = "UPDATE [dbo].[COM_POBJDD]" + Environment.NewLine;
            sql = sql + "SET [Price] = "+ Price +  Environment.NewLine;
            sql = sql + ",[Lead] = " + Lead + Environment.NewLine;
            sql = sql + ",[MaxSup] = " + maxsup + Environment.NewLine;
            sql = sql + ",[Remark] = '"+ Remark + "'" + Environment.NewLine;
            sql = sql + ",[Filed1] = '" + Filed1 + "'" + Environment.NewLine; 
            sql = sql + "WHERE [BJID]='"+ BJID + "' And [PartNO]='"+ PartNO + "'" + Environment.NewLine;
            ignition.ExeCuteNonQuery(sql);
        }

        public void delete_quote(string BJID)
        {
            string sql = "DELETE FROM [dbo].[COM_POBJDD] WHERE [BJID]='"+ BJID + "';" + Environment.NewLine;
            sql = sql + "DELETE FROM[dbo].[COM_POBJDH] WHERE [BJID]='" + BJID + "';";
        }

        public void delete_quote_line(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string str = "Delete from COM_POBJDD where BJID='" + row[0] + "' AND partno='" + row[1] + "'";
                    //ignition.ExeCuteNonQuery(str);
                }
            }
        }

        public DataTable get_quote_head_by_quoteno(string quoteno)
        {
            string sql = "SELECT[BJID]" + Environment.NewLine;
            sql = sql + ", qh.[VendID]" + Environment.NewLine;
            sql = sql + ",qh.[BJDate]" + Environment.NewLine;
            sql = sql + ",qh.[Status]" + Environment.NewLine;
            sql = sql + ",qh.[CrUser]" + Environment.NewLine;
            sql = sql + ",qh.[CrDate]" + Environment.NewLine;
            sql = sql + ",qh.[AppUser]" + Environment.NewLine;
            sql = sql + ",qh.[AppDate]" + Environment.NewLine;
            sql = sql + ",sup.PurValue" + Environment.NewLine;
            sql = sql + ",sup.HB" + Environment.NewLine;
            sql = sql + ",sup.VendName" + Environment.NewLine; 
            sql = sql + ",(select GroupDesc from Com_POTAX where TaxID = sup.TaxId)tax" + Environment.NewLine;
            sql = sql + "FROM[dbo].[COM_POBJDH] qh," + Environment.NewLine;
            sql = sql + "[dbo].[COM_Apven] sup" + Environment.NewLine;
            sql = sql + "where qh.VendID= sup.VendID" + Environment.NewLine; 
            sql = sql + "AND [BJID]='"+ quoteno + "'" + Environment.NewLine;
            return ignition.Tincan(sql);
        }

        public DataTable get_quote_line_by_quoteno(string quoteno)
        {
            string sql = "SELECT[BJID]" + Environment.NewLine;
            sql = sql + ",[PartNO]" + Environment.NewLine;
            sql = sql + ",[Price]" + Environment.NewLine;
            sql = sql + ",[Lead]" + Environment.NewLine;
            sql = sql + ",[MaxSup]" + Environment.NewLine;
            sql = sql + ",[Remark]" + Environment.NewLine;
            sql = sql + ",[Filed1]" + Environment.NewLine;
            sql = sql + ",[Filed2]" + Environment.NewLine;
            sql = sql + ",[Filed3]" + Environment.NewLine;
            sql = sql + "FROM[dbo].[COM_POBJDD]" + Environment.NewLine; 
            sql = sql + "WHERE [BJID]='" + quoteno + "'" + Environment.NewLine;
            return ignition.Tincan(sql);
        }

        public DataTable search_supplier(string str)
        {
            string sql= "SELECT [VendID] Suppiler_ID" + Environment.NewLine;
            sql = sql + ",[VendName] Suppiler_Name" + Environment.NewLine;
            sql = sql + ",[HB] Currendcy" + Environment.NewLine;
            sql = sql + ",[TermsCode] PM_Terms" + Environment.NewLine; 
            sql = sql + ",[TaxId]" + Environment.NewLine;
            sql = sql + ",[PurValue] Class" + Environment.NewLine;
            sql = sql + ",[Tel]" + Environment.NewLine;
            sql = sql + ",[Fax]" + Environment.NewLine;
            sql = sql + ",[Contact]" + Environment.NewLine;
            sql = sql + ",[Email]" + Environment.NewLine;
            sql = sql + ",[Address]" + Environment.NewLine; 
            sql = sql + ",[CrUser]" + Environment.NewLine;
            sql = sql + ",[CrDate]" + Environment.NewLine;   
            sql = sql + ",[WRType] Delivery_Type" + Environment.NewLine;
            sql = sql + ",[Buyer] " + Environment.NewLine;
            sql = sql + ",[VendBank] Bank_Name" + Environment.NewLine;
            sql = sql + ",[VendAccountNO] Account_No" + Environment.NewLine;
            sql = sql + ",[VendBankbrand] Bank_Brand" + Environment.NewLine;
            sql = sql + ",[vendvatcode] VAT_Code" + Environment.NewLine;
            sql = sql + ",[GLType]" + Environment.NewLine; 
            sql = sql + ",[JSFS] Settlement" + Environment.NewLine;
            sql = sql + "FROM[dbo].[COM_Apven]" + Environment.NewLine;
            sql = sql + "where Vendid like '%"+str+"%'" + Environment.NewLine;
            sql = sql + "OR VendName like '%" + str + "%'" + Environment.NewLine;
            sql = sql + "OR HB like '%" + str + "%'" + Environment.NewLine;
            sql = sql + "OR TermsCode like '%" + str + "%'" + Environment.NewLine;
            sql = sql + "OR CrUser like '%" + str + "%'" + Environment.NewLine;
            return ignition.Tincan(sql);
        }

        public void delete_supplier(string supno)
        {
            ignition.ExeCuteNonQuery("delete COM_Apven where VendID='"+ supno + "'");
        }

        public DataTable get_supplier_by_supplierno(string supno)
        {
            string str = "";
            str = "select *,(SELECT GroupDesc FROM Com_POTAX WHERE Com_POTAX.TaxID=COM_Apven.TAXID)TAXNAME from COM_Apven" + Environment.NewLine;
            str = str + "where VendID ='" + supno + "' " + Environment.NewLine;
            return ignition.Tincan(str);
        }

        public DataTable get_all_purchasing_staff()
        {
            return ignition.Tincan("select UserID from com_User where DeptID='PURCHASING'");
        }

        public void new_supplier(string supid, string supname, string curency, string terms, int status,
            int taxid, string purvalue, string tel, string fax, string contact, string email, string address,
            float rate, string cruser, DateTime crdate, float discnt, string appuser, string appdate, string fld1, string fld2,
            string fld3, string deliverytype, string buyer, string vendbank, string bankacc, string bankfax,
            string VendBankTel, string Comment, string Supplier, string SupAddr, string SupTel, string SupFax,
            string SupCon, string SupNO, string GLType, string OLDTermsCode, string JSFS,string bankbrand,string vat)
        {
            string str = "";
            str = str + "INSERT INTO [dbo].[COM_Apven]" + Environment.NewLine;
            str = str + "([VendID]" + Environment.NewLine;
            str = str + ",[VendName]" + Environment.NewLine;
            str = str + ",[HB]" + Environment.NewLine;
            str = str + ",[TermsCode]" + Environment.NewLine;
            str = str + ",[Status]" + Environment.NewLine;
            str = str + ",[TaxId]" + Environment.NewLine;
            str = str + ",[PurValue]" + Environment.NewLine;
            str = str + ",[Tel]" + Environment.NewLine;
            str = str + ",[Fax]" + Environment.NewLine;
            str = str + ",[Contact]" + Environment.NewLine;
            str = str + ",[Email]" + Environment.NewLine;
            str = str + ",[Address]" + Environment.NewLine;
            str = str + ",[Rate]" + Environment.NewLine;
            str = str + ",[CrUser]" + Environment.NewLine;
            str = str + ",[CrDate]" + Environment.NewLine;
            str = str + ",[DISCNT]" + Environment.NewLine;
            str = str + ",[AppUser]" + Environment.NewLine;
            str = str + ",[AppDate]" + Environment.NewLine;
            str = str + ",[Filed1]" + Environment.NewLine;
            str = str + ",[Filed2]" + Environment.NewLine;
            str = str + " ,[Filed3]" + Environment.NewLine;
            str = str + ",[WRType]" + Environment.NewLine;
            str = str + ",[Buyer]" + Environment.NewLine;
            str = str + ",[VendBank]" + Environment.NewLine;
            str = str + ",[VendAccountNO]" + Environment.NewLine;
            str = str + ",[VendBankTel]" + Environment.NewLine;
            str = str + ",[VendBankFax]" + Environment.NewLine;
            str = str + ",[Comment]" + Environment.NewLine;
            str = str + ",[Supplier]" + Environment.NewLine;
            str = str + ",[SupAddr]" + Environment.NewLine;
            str = str + ",[SupTel]" + Environment.NewLine;
            str = str + ",[SupFax]" + Environment.NewLine;
            str = str + ",[SupCon]" + Environment.NewLine;
            str = str + ",[SupNO]" + Environment.NewLine;
            str = str + ",[GLType]" + Environment.NewLine;
            str = str + ",[OLDTermsCode]" + Environment.NewLine;
            str = str + ",[JSFS]" + Environment.NewLine;
            str = str + ",[VendBankBrand]" + Environment.NewLine;
            str = str + ",[Vendvatcode])" + Environment.NewLine;
            str = str + "VALUES" + Environment.NewLine;
            str = str + "('" + supid + "'" + Environment.NewLine;//<VendID, nvarchar(20),>
            str = str + ",N'" + supname + "'" + Environment.NewLine;//< VendName, nvarchar(200),>
            str = str + ",N'" + curency + "'" + Environment.NewLine;//< HB, nvarchar(3),>
            str = str + ",N'" + terms + "'" + Environment.NewLine;//< TermsCode, nvarchar(20),>
            str = str + "," + status + "" + Environment.NewLine;//< Status, int,>
            str = str + "," + taxid + "" + Environment.NewLine;//< TaxId, int,>
            str = str + ",N'" + purvalue + "'" + Environment.NewLine;//< PurValue, nvarchar(10),>
            str = str + ",N'" + tel + "'" + Environment.NewLine;//< Tel, nvarchar(40),>
            str = str + ",N'" + fax + "'" + Environment.NewLine;//< Fax, nvarchar(40),>
            str = str + ",N'" + contact + "'" + Environment.NewLine;//< Contact, nvarchar(50),>
            str = str + ",N'" + email + "'" + Environment.NewLine;//< Email, nvarchar(150),>
            str = str + ",N'" + address + "'" + Environment.NewLine;//< Address, nvarchar(200),>
            str = str + "," + rate + "" + Environment.NewLine;//< Rate, float,>
            str = str + ",N'" + cruser + "'" + Environment.NewLine;//< CrUser, nvarchar(20),>
            str = str + ",N'" + crdate + "'" + Environment.NewLine;//< CrDate, datetime,>
            str = str + "," + discnt + "" + Environment.NewLine;//< DISCNT, float,>
            str = str + ",N'" + appuser + "'" + Environment.NewLine;//< AppUser, nvarchar(20),>
            str = str + ",N'" + appdate + "'" + Environment.NewLine;//< AppDate, datetime,>
            str = str + ",N'" + fld1 + "'" + Environment.NewLine;//< Filed1, nvarchar(20),>
            str = str + ",N'" + fld2 + "'" + Environment.NewLine;//< Filed2, nvarchar(200),>
            str = str + ",N'" + fld3 + "'" + Environment.NewLine;//< Filed3, nvarchar(200),>
            str = str + ",N'" + deliverytype + "'" + Environment.NewLine;//< WRType, nvarchar(20),>
            str = str + ",N'" + buyer + "'" + Environment.NewLine;//< Buyer, nvarchar(20),>
            str = str + ",N'" + vendbank + "'" + Environment.NewLine;//< VendBank, nvarchar(100),>
            str = str + ",N'" + bankacc + "'" + Environment.NewLine;//< VendAccountNO, nvarchar(100),>
            str = str + ",N'" + VendBankTel + "'" + Environment.NewLine;//< VendBankTel, nvarchar(30),>
            str = str + ",N'" + bankfax + "'" + Environment.NewLine;//< VendBankFax, nvarchar(30),>
            str = str + ",N'" + Comment + "'" + Environment.NewLine;//< Comment, nvarchar(50),>
            str = str + ",N'" + Supplier + "'" + Environment.NewLine;//< Supplier, nvarchar(200),>
            str = str + ",N'" + SupAddr + "'" + Environment.NewLine;//< SupAddr, nvarchar(200),>
            str = str + ",N'" + SupTel + "'" + Environment.NewLine;//< SupTel, nvarchar(30),>
            str = str + ",N'" + SupFax + "'" + Environment.NewLine;//< SupFax, nvarchar(30),>
            str = str + ",N'" + SupCon + "'" + Environment.NewLine;//< SupCon, nvarchar(30),>
            str = str + ",N'" + SupNO + "'" + Environment.NewLine;//< SupNO, nvarchar(20),>
            str = str + ",N'" + supid + "'" + Environment.NewLine;//< GLType, nvarchar(20),>
            str = str + ",N'" + OLDTermsCode + "'" + Environment.NewLine;//< OLDTermsCode, nvarchar(20),>
            str = str + ",N'" + JSFS + "') " + Environment.NewLine;//< JSFS, nvarchar(30),> 
            str = str + ",N'" + bankbrand + "'" + Environment.NewLine;//
            str = str + ",N'" + vat + "') " + Environment.NewLine;//
            ignition.ExeCuteNonQuery(str);
        }

        public DataTable get_pmterm(string type)
        {
            return ignition.Tincan("select * from  [dbo].[smcl_po_st] where posttype='"+ type + "' order by postvalue");
        }

        public DataTable get_all_purchase_staff() {
            return ignition.Tincan("select UserID from com_User where DeptID='PURCHASING'");
        }

        public DataTable get_tax() {
            return ignition.Tincan("select taxid,GroupDesc from [dbo].[Com_POTAX];");
        }

        public bool check_exist_supplier(string supno)
        {
            string sql = "select* from COM_Apven where VendID = '"+ supno + "'";
            DataTable dt = new DataTable();
            dt = ignition.Tincan(sql);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public bool check_exist_POD(string Pono,int line)
        {
            string sql = "select * from COM_POD where PONO = '"+ Pono + "' and line ="+ line + "";
            DataTable dt = new DataTable();
            dt = ignition.Tincan(sql);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public void update_supplier(string supid, string supname, string curency, string terms, int status,
            int taxid, string purvalue, string tel, string fax, string contact, string email, string address,
            float rate,  float discnt, string appuser, string appdate, string fld1, string fld2,
            string fld3, string deliverytype, string buyer, string vendbank, string bankacc, string bankfax,
            string VendBankTel, string Comment, string Supplier, string SupAddr, string SupTel, string SupFax,
            string SupCon, string SupNO, string GLType, string OLDTermsCode, string JSFS, string bankbrand, string vat)
        {
            string str = "";
            str = str + " UPDATE[dbo].[COM_Apven]";
            str = str + "SET [VendName] =N'" + supname + "' " + Environment.NewLine;//<VendName, nvarchar(200),>
            str = str + ",[HB] =N'" + curency + "'" + Environment.NewLine;//<HB, nvarchar(3),>
            str = str + ",[TermsCode] =N'" + terms + "'" + Environment.NewLine;//<TermsCode, nvarchar(20),>
            str = str + ",[Status] =" + status + " " + Environment.NewLine;//<Status, int,>
            str = str + ",[TaxId] = " + taxid + "" + Environment.NewLine;//<TaxId, int,>
            str = str + ",[PurValue] =N'" + purvalue + "'" + Environment.NewLine;// <PurValue, nvarchar(10),>
            str = str + ",[Tel] =N'" + tel + "'" + Environment.NewLine;//<Tel, nvarchar(40),>
            str = str + ",[Fax] =N'" + fax + "'" + Environment.NewLine;//<Fax, nvarchar(40),>
            str = str + ",[Contact] =N'" + contact + "'" + Environment.NewLine;//<Contact, nvarchar(50),>
            str = str + ",[Email] =N'" + email + "'" + Environment.NewLine;//<Email, nvarchar(150),>
            str = str + ",[Address] =N'" + address + "'" + Environment.NewLine;//<Address, nvarchar(200),>
            str = str + ",[Rate] =" + rate + "" + Environment.NewLine;// <Rate, float,>  
            str = str + ",[DISCNT] = " + discnt + "" + Environment.NewLine;//<DISCNT, float,>
            str = str + ",[AppUser] =N'" + appuser + "'" + Environment.NewLine;//<AppUser, nvarchar(20),>
            str = str + ",[AppDate] =N'" + appdate + "'" + Environment.NewLine;//<AppDate, datetime,>
            str = str + ",[Filed1] =N'" + fld1 + "'" + Environment.NewLine;//<Filed1, nvarchar(20),>
            str = str + ",[Filed2] =N'" + fld2 + "'" + Environment.NewLine;//<Filed2, nvarchar(200),>
            str = str + ",[Filed3] =N'" + fld3 + "'" + Environment.NewLine;//<Filed3, nvarchar(200),>
            str = str + ",[WRType] =N'" + deliverytype + "'" + Environment.NewLine;//<WRType, nvarchar(20),>
            str = str + ",[Buyer] =N'" + buyer + "'" + Environment.NewLine;//<Buyer, nvarchar(20),>
            str = str + ",[VendBank] =N'" + vendbank + "'" + Environment.NewLine;//<VendBank, nvarchar(100),>
            str = str + ",[VendAccountNO] =N'" + bankacc + "'" + Environment.NewLine;//<VendAccountNO, nvarchar(100),>
            str = str + ",[VendBankTel] =N'" + VendBankTel + "'" + Environment.NewLine;//<VendBankTel, nvarchar(30),>
            str = str + ",[VendBankFax] =N'" + bankfax + "'" + Environment.NewLine;//<VendBankFax, nvarchar(30),>
            str = str + ",[Comment] =N'" + Comment + "'" + Environment.NewLine;//<Comment, nvarchar(50),>
            str = str + ",[Supplier] =N'" + Supplier + "'" + Environment.NewLine;// <Supplier, nvarchar(200),>
            str = str + ",[SupAddr] =N'" + SupAddr + "'" + Environment.NewLine;//<SupAddr, nvarchar(200),>
            str = str + ",[SupTel] =N'" + SupTel + "'" + Environment.NewLine;//<SupTel, nvarchar(30),>
            str = str + ",[SupFax] =N'" + SupFax + "'" + Environment.NewLine;//<SupFax, nvarchar(30),>
            str = str + ",[SupCon] =N'" + SupCon + "'" + Environment.NewLine;//<SupCon, nvarchar(30),>
            str = str + ",[SupNO] =N'" + SupNO + "'" + Environment.NewLine;//<SupNO, nvarchar(20),>
            str = str + ",[GLType] =N'" + GLType + "'" + Environment.NewLine;//<GLType, nvarchar(20),>
            str = str + ",[OLDTermsCode] =N'" + OLDTermsCode + "'" + Environment.NewLine;//<OLDTermsCode, nvarchar(20),>
            str = str + ",[JSFS] =N'" + JSFS + "'" + Environment.NewLine;//<JSFS, nvarchar(30),>
            str = str + ",[vendbankbrand] =N'" + bankbrand + "'" + Environment.NewLine;
            str = str + ",[vendvatcode] =N'" + vat + "'" + Environment.NewLine;
            str = str + "WHERE [VendID]=N'" + supid + "'" + Environment.NewLine;
            ignition.ExeCuteNonQuery(str);
        }
    }
}
