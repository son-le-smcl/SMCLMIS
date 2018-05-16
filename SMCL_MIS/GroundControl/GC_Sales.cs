using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace SMCL_MIS
{
    class GC_Sales
    {
        Igni ignition = new Igni();
        public DataTable Get_Search(string Sql)
        {
            return ignition.Tincan(Sql);
        }
        public DataTable get_so_type()
        {
            return ignition.Tincan("select * from smcl_so_type");
        }
        public DataTable Get_so_head_by_sono(string sono)
        {
            string sql = "";
            sql = "select SONO,Odate,SOType,Status,CustPO,RecTerms,ShipFrom,ShipTOC,CrUser,CrDate,appUser,appDate,refno from Com_soh Where sono='" + sono + "'";
            return ignition.Tincan(sql);
        }
        public DataTable Get_so_line_by_sono(string sono)
        {
            string sql = "";
            sql = " select SONO,Class,LINE,SODNO,partno,(select partname from com_stk01 where com_stk01.partno=com_sod.partno)partname" +
                ",CustXH,sod_CustPO,OrdQty,Price,OrdQty*Price Amount,ShipDate,ShipQty,shiploc,Remark from Com_SOD Where sono='" + sono + "'";
            DataTable dt = new DataTable();
            dt =ignition.Tincan(sql);
            dt.Rows.Add();
            return dt;
        }
        public DataTable get_customer_by_customerno(string cusno)
        {
            string sql = "";
            sql = "select * from smcl_customer where customer_id='" + cusno + "'";
            return ignition.Tincan(sql);
        }
        public DataTable get_ALLcustomer()
        {
            string sql = "";
            sql = "select * from smcl_customer;";
            return ignition.Tincan(sql);
        }
        public void new_customer(string cus_name, string term, string shipfrom, string shipto, string cur,string remark)
        {
            string str = "INSERT INTO [dbo].[smcl_Customer]" + Environment.NewLine;
            str =str+ "([Customer_Name]" + Environment.NewLine;
            str = str + ",[Customer_terms]" + Environment.NewLine;
            str = str + ",[ShipFrom]" + Environment.NewLine;
            str = str + ",[ShipTo]" + Environment.NewLine;
            str = str + ",[Currendcy]" + Environment.NewLine;
            str = str + ",[Remark])" + Environment.NewLine;
            str = str + "VALUES" + Environment.NewLine;
            str = str + "(N'{0}'" + Environment.NewLine;
            str = str + ",'{1}'" + Environment.NewLine;
            str = str + ",'{2}'" + Environment.NewLine;
            str = str + ",'{3}'" + Environment.NewLine;
            str = str + ",'{4}'" + Environment.NewLine;
            str = str + ",N'{5}')" + Environment.NewLine;
            str = string.Format(str, cus_name, term, shipfrom, shipto, cur, remark);
            ignition.ExeCuteNonQuery(str);
        }
        public void update_customer(string cus_id,string cus_name, string term, string shipfrom, string shipto, string cur, string remark)
        {
            string str = "UPDATE[dbo].[smcl_Customer]" + Environment.NewLine;
            str = str + "SET[Customer_Name] = '{0}'" + Environment.NewLine;
            str = str + ",[Customer_terms] = '{1}'" + Environment.NewLine;
            str = str + ",[ShipFrom] ='{2}'" + Environment.NewLine;
            str = str + ",[ShipTo] = '{3}'" + Environment.NewLine;
            str = str + ",[Currendcy] = '{4}'" + Environment.NewLine;
            str = str + ",[Remark] = '{5}'" + Environment.NewLine;
            str = str + "WHERE customer_id='{6}'" + Environment.NewLine;
            
            str = string.Format(str, cus_name, term, shipfrom, shipto, cur, remark,cus_id);
            ignition.ExeCuteNonQuery(str);
        }
        public void delete_customer(DataTable dataTable)
        {
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    string str = "Delete from smcl_customer where customer_id='" + row[0] + "'";
                    ignition.ExeCuteNonQuery(str);
                }
            } 
             
        }
        public DataTable Get_shiploc_by_shiptype(string type)
        {
            string sql = "";
            sql = "select cuslocto from smcl_customerloc where cusloctype='" + type + "'";

            return ignition.Tincan(sql);
        }
        public bool check_exist_soh(string sono) {
            if (ignition.Tincan("Select sono from com_soh where sono='" + sono + "';").Rows.Count > 0)
                return true;
            else
                return false;
        }
        public bool check_exist_sod(string sodno) {
            if (ignition.Tincan("Select sono from com_sod where sodno='" + sodno + "';").Rows.Count > 0)
                return true;
            else
                return false;
        }
        public void update_soH(string sono, string sotype, string custpo, string encust, string recterm, string shipform, string shipto,string remark,DateTime odate)
        {
            string str = "UPDATE[dbo].[Com_SOH]";
            str = str + "SET[SOType] = '{0}'" + Environment.NewLine;
            str = str + ",[CustPO] = '{1}'" + Environment.NewLine;
            str = str + ",[EndCust] = '{2}'" + Environment.NewLine;
            str = str + ",[RecTerms] = '{3}'" + Environment.NewLine;
            str = str + ",[ShipFrom] = '{4}'" + Environment.NewLine;
            str = str + ",[ShipTOC] ='{5}'" + Environment.NewLine;
            str = str + ",[REFNO] ='{6}'" + Environment.NewLine;
            str = str + ",[Odate] ='{7}'" + Environment.NewLine; 
            str = str + "WHERE SONO='{8}'" + Environment.NewLine;
            str = string.Format(str, sotype, custpo, encust, recterm, shipform, shipto,remark,odate, sono);
            ignition.ExeCuteNonQuery(str);
        }
        public void delete_sod(DataTable t_del)
        {
            if (t_del.Rows.Count > 0)
            {
                foreach (DataRow row in t_del.Rows)
                {
                    string str = "Delete from com_sod where sodno='" + row[0] + "'";
                    ignition.ExeCuteNonQuery(str);
                } 
            }
        }
        public void update_soD(string sodno, string Class, string partno
            , string cust_po, int orderqty, float price, DateTime shipdate, string shiploc, string remark,string CUSTPO)
        {
            string str = "UPDATE [dbo].[COM_SOD]" + Environment.NewLine;
            str = str + "SET [Class] = N'{0}'" + Environment.NewLine;
            str = str + ",[partno] = '{1}'" + Environment.NewLine;
            str = str + ",[CustXH] = N'{2}'" + Environment.NewLine;
            str = str + ",[OrdQty] = {3}" + Environment.NewLine;
            str = str + ",[Price] ={4}" + Environment.NewLine;
            str = str + ",[ShipDate] ='{5}'" + Environment.NewLine;
            str = str + ",[ShipLoc] ='{6}'" + Environment.NewLine;
            str = str + ",[Remark] =N'{7}',[CUSTPO]='{8}'" + Environment.NewLine;
            str = str + "WHERE sodno='{9}';";
            str = string.Format(str, Class, partno, cust_po, orderqty, price, shipdate, shiploc, remark,CUSTPO,sodno);
            ignition.ExeCuteNonQuery(str);
        }
        public void delete_so(string sono)
        {
            string str = "DELETE FROM [dbo].[Com_SOH] WHERE Sono='"+ sono + "'";
            string str1 = "DELETE FROM [dbo].[Com_SOD] WHERE Sono='" + sono + "'";
            ignition.ExeCuteNonQuery(str);
            ignition.ExeCuteNonQuery(str1); 
        }
        public void new_soD(string SONO
           , int LINE
           , string SODNO
           , string Class
           , string partno
           , string CustXH
           , int OrdQty
           , float Price
           , DateTime ShipDate
           , string ShipLoc
           , string  Remark
           , string MT
           , int ShipQty
           , int RKQty
           , string Status
           , string MRPNO
           , string Filed1
           , string Filed2
           , string Filed3
           , int Filed4
           , int Filed5,string custpo)
        {
            string str = "";
            str = "INSERT INTO[dbo].[COM_SOD]" + Environment.NewLine;
            str = str + "([SONO]" + Environment.NewLine;
            str = str + ",[LINE]" + Environment.NewLine;
            str = str + ",[SODNO]" + Environment.NewLine;
            str = str + ",[Class]" + Environment.NewLine;
            str = str + ",[partno]" + Environment.NewLine;
            str = str + ",[CustXH]" + Environment.NewLine;
            str = str + ",[OrdQty]" + Environment.NewLine;
            str = str + ",[Price]" + Environment.NewLine;
            str =str+ ",[ShipDate]" + Environment.NewLine;
            str = str + ",[ShipLoc]" + Environment.NewLine;
            str = str + ",[Remark]" + Environment.NewLine;
            str = str + ",[MT]" + Environment.NewLine;
            str = str + ",[ShipQty]" + Environment.NewLine;
            str = str + ",[RKQty]" + Environment.NewLine;
            str = str + ",[Status]" + Environment.NewLine;
            str = str + ",[MRPNO]" + Environment.NewLine;
            str = str + ",[Filed1]" + Environment.NewLine;
            str = str + ",[Filed2]" + Environment.NewLine;
            str = str + ",[Filed3]" + Environment.NewLine;
            str = str + ",[Filed4]" + Environment.NewLine;
            str = str + ",[Filed5],[CUSTPO])" + Environment.NewLine;
            str = str + "VALUES('{0}',{1},'{2}','{3}','{4}','{5}',{6},{7},'{8}','{9}',N'{10}','{11}',{12},{13},'{14}','{15}','{16}','{17}','{18}',{19},{20},'{21}'";
            str = str + ")" + Environment.NewLine;
            str = string.Format(str, SONO,LINE,SODNO,Class, partno, CustXH, OrdQty, Price, ShipDate, ShipLoc,  Remark, MT, ShipQty, RKQty
           , Status, MRPNO, Filed1, Filed2, Filed3, Filed4,  Filed5, custpo);
            ignition.ExeCuteNonQuery(str);
        }
        public void new_soH(string sono,DateTime odate,string refno,string sotype,string status,string custPO,string endcust,string recterms,
            string shipfrom,string shipto,string locref, string dino, string damnify, string fld1,string fld2,string fld3,int fld4,
            int fld5, string cruser, DateTime crdate,string appuser,DateTime appdate)
        {
            status = "Draft";
            crdate = DateTime.Now;
            fld1 = "";
            fld2 = "";
            fld3 = "";
            fld4 = 0;
            fld5 = 0;
            string str = "INSERT INTO [dbo].[Com_SOH]" + Environment.NewLine;
            str=str+ "([SONO]" + Environment.NewLine;     //0
            str = str + ",[Odate]" + Environment.NewLine;//1
            str = str + ",[REFNO]" + Environment.NewLine;//2
            str = str + ",[SOType]" + Environment.NewLine;//3
            str = str + ",[Status]" + Environment.NewLine;//4
            str = str + ",[CustPO]" + Environment.NewLine;//5
            str = str + ",[EndCust]" + Environment.NewLine;//6
            str = str + ",[RecTerms]" + Environment.NewLine;//7
            str = str + ",[ShipFrom]" + Environment.NewLine;//8
            str = str + ",[ShipTOC]" + Environment.NewLine;//9
            str = str + ",[LOCRef]" + Environment.NewLine;//10
            str = str + ",[DINO]" + Environment.NewLine;//11
            str = str + ",[damnify]" + Environment.NewLine;//12
            str = str + ",[Filed1]" + Environment.NewLine;//13
            str = str + ",[Filed2]" + Environment.NewLine;//14
            str = str + ",[Filed3]" + Environment.NewLine;//15
            str = str + ",[Filed4]" + Environment.NewLine;//16
            str = str + ",[Filed5]" + Environment.NewLine;//17
            str = str + ",[CrUser]" + Environment.NewLine;//18
            str = str + ",[CrDate]" + Environment.NewLine;//19
            str = str + ",[AppUser]" + Environment.NewLine;//20
            str = str + ",[AppDate])" + Environment.NewLine;//21
            str = str + "VALUES" + Environment.NewLine;
            str = str + "('{0}','{1}',N'{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}',N'{10}','{11}','{12}','{13}','{14}','{15}',{16},{17},'{18}','{19}','{20}','{21}')";
            str = string.Format(str,  sono,  odate,  refno,  sotype,  status,  custPO,  endcust,  recterms,
             shipfrom,  shipto,  locref,  dino,  damnify,  fld1,  fld2,  fld3,  fld4,
             fld5,  LoginInfo.username,  crdate,  appuser, "1900-01-01 00:00:00.000");
            ignition.ExeCuteNonQuery(str);
        }
        public void approve_so(string sono,string sts,string appdateuser,DateTime appdate)
        {
            string str = "UPDATE[dbo].[Com_SOH]";
            str = str + "SET status = '{0}'" + Environment.NewLine;
            str = str + ",appuser = '{1}'" + Environment.NewLine;
            str = str + ",appdate = '{2}'" + Environment.NewLine; 
            str = str + "WHERE SONO='{3}'" + Environment.NewLine;
            str = string.Format(str, sts, appdateuser, appdate,sono);
            ignition.ExeCuteNonQuery(str);
        }
        public DataTable emptyline()
        {
            string sql;
            sql = " select top 1 " + Environment.NewLine;
            sql = sql + "null SODNO" + Environment.NewLine;
            sql = sql + ",null line" + Environment.NewLine;
            sql = sql + ",null partno" + Environment.NewLine;
            sql = sql + ",null CustXH" + Environment.NewLine;
            sql = sql + ",null OrdQty" + Environment.NewLine;
            sql = sql + ",null Amount" + Environment.NewLine;
            sql = sql + ",null Price" + Environment.NewLine;
            sql = sql + ",null ShipDate" + Environment.NewLine;
            sql = sql + ",null ShipQty" + Environment.NewLine;
            sql = sql + ",null Class" + Environment.NewLine;
            sql = sql + ",null remark" + Environment.NewLine;
            sql = sql + ",null shiploc from Com_SOD" + Environment.NewLine;
            return ignition.Tincan(sql);
        }
        public DataTable So_sum(DateTime from, DateTime to)
        {
            string sql;
            sql = "select" + Environment.NewLine;
            sql = sql + "H.SONO," + Environment.NewLine;
            sql = sql + "H.Odate Order_Date," + Environment.NewLine;
            sql = sql + "H.SOType So_Type," + Environment.NewLine;
            sql = sql + "H.Status," + Environment.NewLine;
            sql = sql + "H.AppDate Aprrov_Date," + Environment.NewLine;
            sql = sql + "H.AppUser Approve_User," + Environment.NewLine;
            sql = sql + "H.CrDate Created_Date," + Environment.NewLine;
            sql = sql + "H.CrUser Created_User," + Environment.NewLine;
            sql = sql + "H.CustPO Customer," + Environment.NewLine;
            sql = sql + "H.DINO," + Environment.NewLine;
            sql = sql + "D.Class," + Environment.NewLine;
            sql = sql + "D.SODNO," + Environment.NewLine;
            sql = sql + "D.LINE," + Environment.NewLine; 
            sql = sql + "D.partno Part_Number," + Environment.NewLine;
            sql = sql + "D.CustXH Customer_Po," + Environment.NewLine;
            sql = sql + "D.OrdQty Order_Qty," + Environment.NewLine;
            sql = sql + "D.ShipQty Delivery_Qty," + Environment.NewLine;
            sql = sql + "D.Price," + Environment.NewLine;
            sql = sql + "D.ShipDate Delivery_Date," + Environment.NewLine;
            sql = sql + "D.ShipLoc Delivery_Location," + Environment.NewLine;
            sql = sql + "D.Remark from" + Environment.NewLine;
            sql = sql + "Com_SOH H, COM_SOD D" + Environment.NewLine;
            sql = sql + "Where H.SONO = D.SONO" + Environment.NewLine;
            sql = sql + "and Odate between '"+from+ "' and '" + to + "'" + Environment.NewLine;
            return ignition.Tincan(sql);
        }
    }
}
