using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace SMCL_MIS
{
    class GC_Browse
    {
        public DataTable browse(string key, Form f)
        {
            string sql = "";
            switch (key)
            {
                case "SO":
                    sql = "select top 20 SONO,Odate,SOType,Status,CustPO,RecTerms,ShipFrom,ShipTOC,CrUser,CrDate from Com_SOH order by CrDate desc";
                    break;
                case "SOD":
                    sql = "select TOP 20 sodno SONO,partno Part_Number,CustXH Customer_PO,ShipDate,OrdQty Qty,ShipQty,Remark " + Environment.NewLine;
                    sql = sql + "from COM_SOD d,Com_SOH h" + Environment.NewLine;
                    sql = sql + "where h.Status = 'Approval'" + Environment.NewLine;
                    sql = sql + "and d.SONO = h.SONO" + Environment.NewLine;
                    sql = sql + "and OrdQty> ShipQty" + Environment.NewLine;
                    sql = sql + "order by sodno desc" + Environment.NewLine;
                    break;
                case "CUS":
                    sql = "select * FROM smcl_Customer";
                    break;
                case "PART":
                    if (f.Name == "frmMaterials")
                        sql = "select top 20 PartNo,PartName,S_TYPE Category,GLID Type,MdDate Modify_on from Com_STK01 order by mddate desc"; 
                    else
                        sql = "select top 20 PartNo,PartName,S_TYPE Category,GLID Type,MdDate Modify_on  from Com_STK01 where dead=0 order by mddate desc";

                    break;
                case "Quote":
                    sql = "select top 20 PartNo,PartName,S_TYPE,GLID,MdDate from Com_STK01 where GLID<> 'RM' order by mddate desc";
                    break;
                case "SUP":

                    if (f.Name == "frmSupplier")
                        sql = "select VendID,VendName,HB Currendcy,TermsCode,GLType from COM_Apven";
                    else
                        sql = "select VendID,VendName,HB Currendcy,TermsCode,GLType from COM_Apven where status=0";
                    break;
                case "QUOTE":
                    sql = "SELECT Top 20" + Environment.NewLine;
                    sql = sql + "[BJID] Quotation_Number" + Environment.NewLine;
                    sql = sql + ",[VendID] Supplier_number" + Environment.NewLine;
                    sql = sql + ",[BJDate] Quotation_Date" + Environment.NewLine;
                    sql = sql + ",[Status]" + Environment.NewLine;
                    sql = sql + ",[CrUser] Created_User" + Environment.NewLine;
                    sql = sql + ",[CrDate] Created_date" + Environment.NewLine;
                    sql = sql + ",[AppUser] Approve_User" + Environment.NewLine;
                    sql = sql + ",[AppDate] Approve_Date" + Environment.NewLine;
                    sql = sql + "FROM[dbo].[COM_POBJDH] order by [BJDate] desc";
                    break;
                case "PO":
                    sql ="select top 20" + Environment.NewLine;
                    sql = sql + "PONO," + Environment.NewLine;
                    sql = sql + "PoType PO_Type," + Environment.NewLine;
                    sql = sql + "STATUS," + Environment.NewLine;
                    sql = sql + "VendID Supplier_ID," + Environment.NewLine;
                    sql = sql + "ODate PO_DATE," + Environment.NewLine;
                    sql = sql + "CrUser Created_User," + Environment.NewLine;
                    sql = sql + "CrDate Created_Date" + Environment.NewLine;
                    sql = sql + "from COM_POH" + Environment.NewLine;
                    sql = sql + "order by CrDate desc,PONO desc" + Environment.NewLine; 
                    break;
                case "LOCH":
                    sql = "select LocNO Location,LocName Description from Com_LocH;" + Environment.NewLine;
                    break;
                case "BOM":
                    sql = "select TOP 20" + Environment.NewLine;
                    sql = sql + "PartNO," + Environment.NewLine;
                    sql = sql + "(select partname from Com_STK01 where Com_STK01.PartNo = Com_BOMH.PartNo) Part_Name," + Environment.NewLine;
                    sql = sql + "CrUser Create_By," + Environment.NewLine;
                    sql = sql + "CrDate Create_On," + Environment.NewLine;
                    sql = sql + "MdUser Modify_By," + Environment.NewLine;
                    sql = sql + "MdDate Modify_On" + Environment.NewLine;
                    sql = sql + "from" + Environment.NewLine;
                    sql = sql + "Com_BOMH" + Environment.NewLine;
                    sql = sql + "order by MdDate desc " + Environment.NewLine;
                    break;
            }
            GC_Sales s = new GC_Sales();
            return s.Get_Search(sql);
        }
        public DataTable filler(string key, string str, Form f)
        { 
            string sql = "";
            switch (key)
            {
                case "SO":
                    sql = "select TOP 20 SONO, Odate Sodate, SOType Type, Status, CustPO, RecTerms Term, ShipFrom, ShipTOC ShipTO, CrUser, CrDate from Com_SOH" + Environment.NewLine;
                    sql = sql + "where SONO Like '" + str + "%' OR" + Environment.NewLine;
                    sql = sql + "convert(varchar(25), Odate, 120) Like '%" + str + "%' OR" + Environment.NewLine;
                    sql = sql + "SOType Like '%" + str + "%' OR" + Environment.NewLine;
                    sql = sql + "Status Like '%" + str + "%' OR" + Environment.NewLine;
                    sql = sql + "CustPO Like '%" + str + "%' OR" + Environment.NewLine;
                    sql = sql + "RecTerms Like '%" + str + "%' OR" + Environment.NewLine;
                    sql = sql + "ShipFrom Like '%" + str + "%' OR" + Environment.NewLine;
                    sql = sql + "ShipTOC Like '%" + str + "%' OR" + Environment.NewLine;
                    sql = sql + "CrUser Like '%" + str + "%' OR" + Environment.NewLine;
                    sql = sql + "convert(varchar(25), CrDate, 120) Like '%" + str + "%'" + Environment.NewLine;
                    break;
                case "SOD":
                    sql = "select TOP 20 sodno SONO,partno Part_Number,CustXH Customer_PO,ShipDate,OrdQty Qty,ShipQty,Remark " + Environment.NewLine;
                    sql = sql + "from COM_SOD d,Com_SOH h" + Environment.NewLine;
                    sql = sql + "where h.Status = 'Approval'" + Environment.NewLine;
                    sql = sql + "and d.SONO = h.SONO" + Environment.NewLine;
                    sql = sql + "and OrdQty> ShipQty" + Environment.NewLine;
                    sql = sql + "and d.SONO like '%" + str + "%' OR" + Environment.NewLine; 
                    sql = sql + "order by sodno desc" + Environment.NewLine;
                    break;
                case "CUS":
                    sql = "select TOP 20 * FROM smcl_Customer" + Environment.NewLine;
                    sql = sql + "where Customer_name Like '%" + str + "%' OR" + Environment.NewLine;
                    sql = sql + " Customer_terms Like '%" + str + "%' OR" + Environment.NewLine;
                    sql = sql + " ShipFrom Like '%" + str + "%' OR" + Environment.NewLine;
                    sql = sql + " ShipTo Like '%" + str + "%' OR" + Environment.NewLine;
                    sql = sql + " Currendcy Like '%" + str + "%' " + Environment.NewLine; 
                    break;
                case "PART":
                    if (f.Name == "frmMaterials") {
                        sql = "select top 20 PartNo,PartName,S_TYPE Category,GLID Type,MdDate Modify_on  from Com_STK01 " + Environment.NewLine;
                        sql = sql + "where PartNo Like '%" + str + "%' OR" + Environment.NewLine;
                        sql = sql + " PartName Like '%" + str + "%' OR" + Environment.NewLine;
                        sql = sql + " S_TYPE Like '%" + str + "%' OR" + Environment.NewLine;
                        sql = sql + " GLID Like '%" + str + "%' OR" + Environment.NewLine;
                        sql = sql + " MdDate Like '%" + str + "%' " + Environment.NewLine;
                    }
                    else
                    {
                        sql = "select top 20 PartNo,PartName,S_TYPE Category,GLID Type,MdDate Modify_on  from Com_STK01 " + Environment.NewLine;
                        sql = sql + "where PartNo Like '%" + str + "%' OR" + Environment.NewLine;
                        sql = sql + " PartName Like '%" + str + "%' OR" + Environment.NewLine;
                        sql = sql + " S_TYPE Like '%" + str + "%' OR" + Environment.NewLine;
                        sql = sql + " GLID Like '%" + str + "%' OR" + Environment.NewLine;
                        sql = sql + " MdDate Like '%" + str + "%' " + Environment.NewLine;
                        sql = sql + " group by PartNo,PartName,S_TYPE ,GLID,MdDate,dead having  dead = 0" + Environment.NewLine;
                    }
                    
                    break;
                case "SUP":
                    if (f.Name == "frmSupplier") { 
                    sql = "select TOP 20 VendID,VendName,HB Currendcy,TermsCode,GLType from COM_Apven " + Environment.NewLine;
                    sql = sql + "where VendID Like '" + str + "%' OR" + Environment.NewLine;
                    sql = sql + " VendName Like '%" + str + "%' OR" + Environment.NewLine;
                    sql = sql + " HB Like '%" + str + "%' OR" + Environment.NewLine;
                    sql = sql + " TermsCode Like '%" + str + "%' OR" + Environment.NewLine;
                    sql = sql + " GLType Like '%" + str + "%' " + Environment.NewLine;
                    }
                    else
                    {
                        sql = "select TOP 20 VendID,VendName,HB Currendcy,TermsCode,GLType from COM_Apven " + Environment.NewLine;
                        sql = sql + "where VendID Like '" + str + "%' OR" + Environment.NewLine;
                        sql = sql + " VendName Like '%" + str + "%' OR" + Environment.NewLine;
                        sql = sql + " HB Like '%" + str + "%' OR" + Environment.NewLine;
                        sql = sql + " TermsCode Like '%" + str + "%' OR" + Environment.NewLine;
                        sql = sql + " GLType Like '%" + str + "%' " + Environment.NewLine;
                        sql = sql + " Group by VendID,VendName,HB,TermsCode,GLType,status" + Environment.NewLine;
                        sql = sql + " having status=0" + Environment.NewLine;
                    }
                    break;
                case "QUOTE":
                    sql = "SELECT TOP 20" + Environment.NewLine;
                    sql = sql + "[BJID] Quotation_Number" + Environment.NewLine;
                    sql = sql + ",[VendID] Supplier_number" + Environment.NewLine;
                    sql = sql + ",[BJDate] Quotation_Date" + Environment.NewLine;
                    sql = sql + ",[Status]" + Environment.NewLine;
                    sql = sql + ",[CrUser] Created_User" + Environment.NewLine;
                    sql = sql + ",[CrDate] Created_date" + Environment.NewLine;
                    sql = sql + ",[AppUser] Approve_User" + Environment.NewLine;
                    sql = sql + ",[AppDate] Approve_Date" + Environment.NewLine;
                    sql = sql + "FROM[dbo].[COM_POBJDH]"; 
                    sql = sql + "where BJID Like '%" + str + "%' OR" + Environment.NewLine; 
                    sql = sql + " Status Like '%" + str + "%' OR" + Environment.NewLine;
                    sql = sql + " CrUser Like '%" + str + "%' OR" + Environment.NewLine;
                    sql = sql + " AppUser Like '%" + str + "%' " + Environment.NewLine;
                    break;
                case "PO":
                    sql = "select top 20" + Environment.NewLine;
                    sql = sql + "PONO," + Environment.NewLine;
                    sql = sql + "PoType PO_Type," + Environment.NewLine;
                    sql = sql + "STATUS," + Environment.NewLine;
                    sql = sql + "VendID Supplier_ID," + Environment.NewLine;
                    sql = sql + "ODate PO_DATE," + Environment.NewLine;
                    sql = sql + "CrUser Created_User," + Environment.NewLine;
                    sql = sql + "CrDate Created_Date" + Environment.NewLine;
                    sql = sql + "from COM_POH" + Environment.NewLine; 
                    sql = sql + "where PONO LIKE '%"+str+"%' OR" + Environment.NewLine;
                    sql = sql + " VendID LIKE '%" + str + "%' OR" + Environment.NewLine;
                    sql = sql + " ODate LIKE '%" + str + "%' OR" + Environment.NewLine;
                    sql = sql + " PONO LIKE '%" + str + "%' OR" + Environment.NewLine;
                    sql = sql + " CrUser LIKE '%" + str + "%'" + Environment.NewLine;
                    sql = sql + "order by CrDate desc,PONO desc" + Environment.NewLine;
                    break;
                case "LOCH":
                    sql = "select LocNO Location,LocName Description from Com_LocH " + Environment.NewLine;
                    sql = sql + "where LocNO Like '%" + str + "%' " + Environment.NewLine;
                    sql = sql + "or LocName Like '%" + str + "%' " + Environment.NewLine;
                    break; 
                case "BOM":
                    sql = "select TOP 20" + Environment.NewLine;
                    sql = sql + "PartNO," + Environment.NewLine;
                    sql = sql + "(select partname from Com_STK01 where Com_STK01.PartNo = Com_BOMH.PartNo) Part_Name," + Environment.NewLine;
                    sql = sql + "CrUser Create_By," + Environment.NewLine;
                    sql = sql + "CrDate Create_On," + Environment.NewLine;
                    sql = sql + "MdUser Modify_By," + Environment.NewLine;
                    sql = sql + "MdDate Modify_On" + Environment.NewLine;
                    sql = sql + "from" + Environment.NewLine;
                    sql = sql + "Com_BOMH" + Environment.NewLine;
                    sql = sql + "where PartNO like'%" + str + "%'" + Environment.NewLine;
                    sql = sql + "OR CrUser like'%" + str + "%'" + Environment.NewLine;
                    sql = sql + "OR MdUser like'%" + str + "%'" + Environment.NewLine; 
                    sql = sql + "order by MdDate desc " + Environment.NewLine;
                    break; 
            }
            GC_Sales s = new GC_Sales();
            return s.Get_Search(sql);
        }
    }
}
