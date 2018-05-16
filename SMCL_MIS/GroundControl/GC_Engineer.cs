using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCL_MIS
{
    class GC_Engineer
    {
        Igni ignition = new Igni();

        public void delete_mat(string st)
        {
            string sql = "DELETE FROM [dbo].[Com_STK01] where partno='"+st+"'";
            ignition.ExeCuteNonQuery(sql);
        }

        public DataTable get_mat_st(string st)
        {
            string sql = " select * from smcl_mat_st  where matsttype = '"+ st + "'";
            return ignition.Tincan(sql);
        }
        public bool check_mat_st(string st,string type)
        {
            string sql = " select count(*)count from smcl_mat_st  where matstvalue = '" + st + "' and matsttype = '" + type + "'";
            DataTable dt= ignition.Tincan(sql);
            if (dt.Rows[0]["count"].ToString() == "0")
                return false;
            else
            return true;
        }
        public bool check_exist_Loch(string loc)
        {
            string sql = "select count(*)count from Com_LocH where LocNO = '"+ loc + "'";
            DataTable dt = ignition.Tincan(sql);
            if (dt.Rows[0]["count"].ToString() == "0")
                return false;
            else
                return true;
        }
        public bool check_materials_exist(string mat)
        {
            string sql = "select count(*) count from COM_STK01 where Partno='"+mat+"'";
            DataTable dt = ignition.Tincan(sql);
            if (dt.Rows[0]["count"].ToString() == "0")
                return false;
            else
                return true;
        }

        public void update_material(string PartNo,
        string PartName,
        string REFNO,
        string CustNO,
        string UOFM,
        float Poxstk,
        string POUOFM, 
        float GS,
        float Weight,
        string CLASS,
        int LeadTime,
        float MinQty,
        string WlType,
        string WlAttr,
        string ProdWay,
        string ErpType,
        string GLID, 
        string PartLoc,
        string CGNO,
        string REMARK,
        int DEAD,
        string FRZ_DATE,
        string S_TYPE, 
        float SHRATE, 
        DateTime MdDate,
        string MdUser,
        string Buyer)
        {
            string sql = " UPDATE[dbo].[Com_STK01]" + Environment.NewLine;//dfd
            sql += "SET[PartNo] =N'"+ PartNo + "'" + Environment.NewLine;//dfd < PartNo, nvarchar(30),>
            sql += ",[PartName] =N'" + PartName + "'" + Environment.NewLine;//dfd <PartName, nvarchar(200),>
            sql += ",[REFNO] =N'" + REFNO + "'" + Environment.NewLine;//dfd <REFNO, nvarchar(50),>
            sql += ",[CustNO] =N'" + CustNO + "' " + Environment.NewLine;//dfd<CustNO, nvarchar(24),>
            sql += ",[UOFM] =N'" + UOFM + "'" + Environment.NewLine;//dfd <UOFM, nvarchar(10),>
            sql += ",[Poxstk] =" + Poxstk + "" + Environment.NewLine;//dfd <Poxstk, float,>
            sql += ",[POUOFM] =N'" + POUOFM + "'" + Environment.NewLine;//dfd <POUOFM, nvarchar(10),> 
            sql += ",[GS] =" + GS + "" + Environment.NewLine;//dfd <GS, float,>
            sql += ",[Weight] =" + Weight + "" + Environment.NewLine;//dfd <Weight, float,>
            sql += ",[CLASS] =N'" + CLASS + "'" + Environment.NewLine;//dfd <CLASS, nvarchar(200),>
            sql += ",[LeadTime] =" + LeadTime + "" + Environment.NewLine;//dfd <LeadTime, int,>
            sql += ",[MinQty] =" + MinQty + "" + Environment.NewLine;//dfd<MinQty, float,>
            sql += ",[WlType] =N'" + WlType + "'" + Environment.NewLine;//dfd <WlType, nvarchar(10),>
            sql += ",[WlAttr] =N'" + WlAttr + "'" + Environment.NewLine;//dfd <WlAttr, nvarchar(3),>
            sql += ",[ProdWay] =N'" + ProdWay + "'" + Environment.NewLine;//dfd <ProdWay, nvarchar(20),>
            sql += ",[ErpType] =N'" + ErpType + "'" + Environment.NewLine;//dfd <ErpType, nvarchar(10),>
            sql += ",[GLID] = '" + GLID + "'" + Environment.NewLine;//dfd<GLID, nvarchar(10),> 
            sql += ",[PartLoc] =N'" + PartLoc + "'" + Environment.NewLine;//dfd <PartLoc, nvarchar(15),>
            sql += ",[CGNO] =N'" + CGNO + "'" + Environment.NewLine;//dfd <CGNO, char (10),>
            sql += ",[REMARK] =N'" + REMARK + "'" + Environment.NewLine;//dfd <REMARK, nvarchar(50),>
            sql += ",[DEAD] =" + DEAD + " " + Environment.NewLine;//dfd<DEAD, int,>
            sql += ",[FRZ_DATE] = '" + FRZ_DATE + "'" + Environment.NewLine;//dfd<FRZ_DATE, datetime,>
            sql += ",[S_TYPE] = '" + S_TYPE + "'" + Environment.NewLine;//dfd<S_TYPE, nvarchar(15),> 
            sql += ",[SHRATE] =" + SHRATE + "" + Environment.NewLine;//dfd <SHRATE, float,> 
            sql += ",[MdDate] =N'" + MdDate + "'" + Environment.NewLine;//dfd <MdDate, datetime,>
            sql += ",[MdUser] = '" + MdUser + "'" + Environment.NewLine;//dfd<MdUser, nvarchar(20),>
            sql += ",[Buyer] =N'" + Buyer + "'" + Environment.NewLine;//dfd <Buyer, nvarchar(20),> 
            sql += " WHERE partno =N'" + PartNo + "';" + Environment.NewLine;//dfd
            ignition.ExeCuteNonQuery(sql);
        }

        public void new_material(string PartNo,
        string PartName,
        string REFNO,
        string CustNO,
        string UOFM,
        float Poxstk,
        string POUOFM,
        float Price,
        float Lprice,
        float Sprice,
        float stkqty,
        float AvQty,
        float AsQty,
        float BLQty,
        float DQty,
        float GS,
        float Weight,
        string CLASS,
        int LeadTime,
        float MinQty,
        string WlType,
        string WlAttr,
        string ProdWay,
        string ErpType,
        string GLID,
        float HH,
        float LL,
        string PartLoc,
        string CGNO,
        string REMARK,
        int DEAD,
        string FRZ_DATE,
        string S_TYPE,
        string BOMJJ,
        float SHRATE,
        DateTime CrDate,
        string CrUser,
        DateTime MdDate,
        string MdUser,
        string Buyer,
        float C_STD,
        string S_Name,
        string S_Desc,
        string Fld1,
        string Fld2,
        string Fld3,
        float Fld4,
        float Fld5,
        float Fld6,
        DateTime Fld7,
        DateTime Fld8,
        DateTime Fld9)
        {  
            string sql = "INSERT INTO[dbo].[Com_STK01]" + Environment.NewLine;
            sql += "([PartNo]" + Environment.NewLine;
            sql += ",N[PartName]" + Environment.NewLine;
            sql += ",[REFNO]" + Environment.NewLine;
            sql += ",[CustNO]" + Environment.NewLine;
            sql += ",[UOFM]" + Environment.NewLine;
            sql += ",[Poxstk]" + Environment.NewLine;
            sql += ",[POUOFM]" + Environment.NewLine;
            sql += ",[Price]" + Environment.NewLine;
            sql += ",[Lprice]" + Environment.NewLine;
            sql += ",[Sprice]" + Environment.NewLine;
            sql += ",[stkqty]" + Environment.NewLine;
            sql += ",[AvQty]" + Environment.NewLine;
            sql += ",[AsQty]" + Environment.NewLine;
            sql += ",[BLQty]" + Environment.NewLine;
            sql += ",[DQty]" + Environment.NewLine;
            sql += ",[GS]" + Environment.NewLine;
            sql += ",[Weight]" + Environment.NewLine;
            sql += ",N[CLASS]" + Environment.NewLine;
            sql += ",[LeadTime]" + Environment.NewLine;
            sql += ",[MinQty]" + Environment.NewLine;
            sql += ",[WlType]" + Environment.NewLine;
            sql += ",[WlAttr]" + Environment.NewLine;
            sql += ",[ProdWay]" + Environment.NewLine;
            sql += ",[ErpType]" + Environment.NewLine;
            sql += ",[GLID]" + Environment.NewLine;
            sql += ",[HH]" + Environment.NewLine;
            sql += ",[LL]" + Environment.NewLine;
            sql += ",[PartLoc]" + Environment.NewLine;
            sql += ",[CGNO]" + Environment.NewLine;
            sql += ",N[REMARK]" + Environment.NewLine;
            sql += ",[DEAD]" + Environment.NewLine;
            sql += ",[FRZ_DATE]" + Environment.NewLine;
            sql += ",[S_TYPE]" + Environment.NewLine;
            sql += ",[BOMJJ]" + Environment.NewLine;
            sql += ",[SHRATE]" + Environment.NewLine;
            sql += ",[CrDate]" + Environment.NewLine;
            sql += ",[CrUser]" + Environment.NewLine;
            sql += ",[MdDate]" + Environment.NewLine;
            sql += ",[MdUser]" + Environment.NewLine;
            sql += ",[Buyer]" + Environment.NewLine;
            sql += ",[C_STD]" + Environment.NewLine;
            sql += ",[S_Name]" + Environment.NewLine;
            sql += ",[S_Desc]" + Environment.NewLine;
            sql += ",[Fld1]" + Environment.NewLine;
            sql += ",[Fld2]" + Environment.NewLine;
            sql += ",[Fld3]" + Environment.NewLine;
            sql += ",[Fld4]" + Environment.NewLine;
            sql += ",[Fld5]" + Environment.NewLine;
            sql += ",[Fld6]" + Environment.NewLine;
            sql += ",[Fld7]" + Environment.NewLine;
            sql += ",[Fld8]" + Environment.NewLine;
            sql += ",[Fld9])" + Environment.NewLine;
            sql += "VALUES" + Environment.NewLine;
            sql += "('"+ PartNo + "'" + Environment.NewLine;//<PartNo, nvarchar(30),>
            sql += ",N'" + PartName + "'" + Environment.NewLine;//< PartName, nvarchar(200),>
            sql += ",N'" + REFNO + "'" + Environment.NewLine;//< REFNO;
            sql += ",N'" + CustNO + "'" + Environment.NewLine;//< CustNO, nvarchar(24),>
            sql += ",N'" + UOFM + "'" + Environment.NewLine;//< UOFM;
            sql += "," + Poxstk +  Environment.NewLine;//< Poxstk;
            sql += ",N'" + POUOFM + "'" + Environment.NewLine;//< POUOFM;
            sql += "," + Price + "" + Environment.NewLine;//< Price;
            sql += "," + Lprice + "" + Environment.NewLine;//< Lprice;
            sql += "," + Sprice + "" + Environment.NewLine;//< Sprice;
            sql += "," + stkqty + "" + Environment.NewLine;//< stkqty;
            sql += "," + AvQty + "" + Environment.NewLine;//< AvQty;
            sql += "," + AsQty + "" + Environment.NewLine;//< AsQty;
            sql += "," + BLQty + "" + Environment.NewLine;//< BLQty;
            sql += "," + DQty + "" + Environment.NewLine;//< DQty;
            sql += "," + GS + "" + Environment.NewLine;//< GS;
            sql += "," + Weight + "" + Environment.NewLine;//< Weight;
            sql += ",N'" + CLASS + "'" + Environment.NewLine;//< CLASS, nvarchar(200),>
            sql += "," + LeadTime + "" + Environment.NewLine;//< LeadTime;
            sql += "," + MinQty + "" + Environment.NewLine;//< MinQty;
            sql += ",N'" + WlType + "'" + Environment.NewLine;//< WlType;
            sql += ",N'" + WlAttr + "'" + Environment.NewLine;//< WlAttr;
            sql += ",N'" + ProdWay + "'" + Environment.NewLine;//< ProdWay;
            sql += ",N'" + ErpType + "'" + Environment.NewLine;//< ErpType;
            sql += ",N'" + GLID + "'" + Environment.NewLine;//< GLID;
            sql += "," + HH + "" + Environment.NewLine;//< HH;
            sql += "," + LL + "" + Environment.NewLine;//< LL;
            sql += ",N'" + PartLoc + "'" + Environment.NewLine;//< PartLoc;
            sql += ",N'" + CGNO + "'" + Environment.NewLine;//< CGNO, char (10),>
            sql += ",N'" + REMARK + "'" + Environment.NewLine;//< REMARK;
            sql += "," + DEAD + "" + Environment.NewLine;//< DEAD;
            sql += ",N'" + FRZ_DATE + "'" + Environment.NewLine;//< FRZ_DATE;
            sql += ",N'" + S_TYPE + "'" + Environment.NewLine;//< S_TYPE;
            sql += ",N'" + BOMJJ + "'" + Environment.NewLine;//< BOMJJ;
            sql += "," + SHRATE + "" + Environment.NewLine;//< SHRATE;
            sql += ",N'" + CrDate + "'" + Environment.NewLine;//< CrDate;
            sql += ",N'" + CrUser + "'" + Environment.NewLine;//< CrUser;
            sql += ",N'" + MdDate + "'" + Environment.NewLine;//< MdDate;
            sql += ",N'" + MdUser + "'" + Environment.NewLine;//< MdUser;
            sql += ",N'" + Buyer + "'" + Environment.NewLine;//< Buyer;
            sql += ",N'" + C_STD + "'" + Environment.NewLine;//< C_STD;
            sql += ",N'" + S_Name + "'" + Environment.NewLine;//< S_Name;
            sql += ",N'" + S_Desc + "'" + Environment.NewLine;//< S_Desc;
            sql += ",N'" + Fld1 + "'" + Environment.NewLine;//< Fld1;
            sql += ",N'" + Fld2 + "'" + Environment.NewLine;//< Fld2;
            sql += ",N'" + Fld3 + "'" + Environment.NewLine;//< Fld3;
            sql += "," + Fld4 + "" + Environment.NewLine;//< Fld4;
            sql += "," + Fld5 + "" + Environment.NewLine;//< Fld5;
            sql += "," + Fld6 + "" + Environment.NewLine;//< Fld6;
            sql += ",N'" + Fld7 + "'" + Environment.NewLine;//< Fld7;
            sql += ",N'" + Fld8 + "'" + Environment.NewLine;//< Fld8;
            sql += ",N'" + Fld9 + "')" + Environment.NewLine;//< Fld9;
            ignition.ExeCuteNonQuery(sql);
        }
        public DataTable get_bom_detail_by_partno(string mat, string parent)
        {
            string sql = "";
            //string sql = "select * from" + Environment.NewLine;
            //sql += "Com_STK01 p," + Environment.NewLine;
            //sql += "Com_BOMD b" + Environment.NewLine;
            //sql += "where p.PartNo = b.PartNo" + Environment.NewLine;
            //sql += "and p.PartNo = '" + mat + "'" + Environment.NewLine;
            //sql += "and b.Parent like '" + parent + "'" + Environment.NewLine;
            sql += "select p.*,(select qty from Com_BOMD b where p.PartNo = b.PartNo and b.Parent like '"+ parent + "' )QTY from" + Environment.NewLine;
            sql += "Com_STK01 p" + Environment.NewLine;
            sql += "where p.PartNo = '"+ mat + "'" + Environment.NewLine;
            return ignition.Tincan(sql);
        }
        public DataTable get_Bom_by_parent(string mat)
        {
            string sql = ""; 
            sql += "select " + Environment.NewLine;
            sql += "*" + Environment.NewLine;
            sql += "from Com_BOMD" + Environment.NewLine;
            //sql += "where Parent = '" + mat + "'" + Environment.NewLine;
            return ignition.Tincan(sql);
        }
        public DataTable get_materials_by_partno(string mat)
        {
            string sql = "select * from Com_STK01 where PartNo='" + mat + "'";
            return ignition.Tincan(sql);
        }
        public DataTable Get_material_onhand(string mat)
        {
            string sql = "select LocNO LOCATION,PartNo Part_Number, " + Environment.NewLine;
            sql = sql + "Qty," + Environment.NewLine;
            sql = sql + "(select UOFM from Com_STK01 where Com_STK01.PartNo = Com_LocD.PartNo) UOM," + Environment.NewLine;
            sql = sql + "(select Poxstk from Com_STK01 where Com_STK01.PartNo = Com_LocD.PartNo) Rate," + Environment.NewLine;
            sql = sql + "Qty / (select Poxstk from Com_STK01 where Com_STK01.PartNo = Com_LocD.PartNo) Qty2," + Environment.NewLine;
            sql = sql + "(select POUOFM from Com_STK01 where Com_STK01.PartNo = Com_LocD.PartNo) UOM2," + Environment.NewLine;
            sql = sql + "UDate Last_Update" + Environment.NewLine;
            sql = sql + "from Com_LocD" + Environment.NewLine;
            sql = sql + "where PartNo = '" + mat + "'" + Environment.NewLine;
            sql = sql + "and Qty> 0" + Environment.NewLine;
            return ignition.Tincan(sql);
        }
        public DataTable Get_material_transaction(string mat)
        {
            string sql = "SELECT TRN_DATE Date,TRN_NO No,TRN_TYPE Type,PART_NO Part_Number,TRN_QTY Qty,JOBNO,PONO,MARK Remark" + Environment.NewLine;
            sql = sql + "FROM Com_TRN01" + Environment.NewLine;
            sql = sql + "WHERE PART_NO = '" + mat + "'" + Environment.NewLine;
            sql = sql + "AND TRN_DATE = GETDATE()" + Environment.NewLine;

            return ignition.Tincan(sql);
        }

        public DataTable get_material_toplevel(string mat)
        {
            string sql = "EXEC Prod_gettoplevel '" + mat + "';";
            return ignition.Tincan(sql);
        }
        public DataTable get_material_parent(string mat)
        {
            string sql = "";
            sql = sql + "select Parent," + Environment.NewLine;
            sql = sql + "(select PartName from Com_STK01 where Com_STK01.PartNo = Com_BOMD.Parent) Description_," + Environment.NewLine;
            sql = sql + "QTY" + Environment.NewLine;
            sql = sql + "from Com_BOMD" + Environment.NewLine;
            sql = sql + "where PartNo = '" + mat + "'" + Environment.NewLine;
            return ignition.Tincan(sql);
        }
        public DataTable Get_material_po(string mat)
        { 
            string sql = "select " + Environment.NewLine;
            sql = sql + "h.PONO," + Environment.NewLine;
            sql = sql + "h.ODate," + Environment.NewLine;
            sql = sql + "h.CrUser," + Environment.NewLine;
            sql = sql + "h.PoType," + Environment.NewLine;
            sql = sql + "d.PartNO,p.PartName," + Environment.NewLine;
            sql = sql + "d.ORDERED,d.RECEIVED,p.POUOFM," + Environment.NewLine;
            sql = sql + "h.VendID,s.VendName," + Environment.NewLine;
            sql = sql + "d.JOBNO,so.CustXH,so.ShipDate,so.ShipLoc" + Environment.NewLine;
            sql = sql + "from" + Environment.NewLine;
            sql = sql + "COM_POH h," + Environment.NewLine;
            sql = sql + "COM_POD d left join Com_SOD so on d.JOBNO=so.SODNO," + Environment.NewLine;
            sql = sql + "COM_Apven s," + Environment.NewLine;
            sql = sql + "Com_STK01 p" + Environment.NewLine;
            sql = sql + "where h.PONO = d.PONO" + Environment.NewLine;
            sql = sql + "and d.PartNO = p.PartNo" + Environment.NewLine;
            sql = sql + "and s.VendID = h.VendID" + Environment.NewLine;
            sql = sql + "and d.PartNO = '" + mat + "'" + Environment.NewLine;
            sql = sql + "and h.STATUS = 'Approval'" + Environment.NewLine;
            sql = sql + "and d.ORDERED > d.RECEIVED" + Environment.NewLine;
            return ignition.Tincan(sql);
        }
        public DataTable Get_BOM_by_Partno(string mat)
        {
            string sql = "select TOP 20" + Environment.NewLine;
            sql = sql + "PartNO," + Environment.NewLine;
            sql = sql + "(select partname from Com_STK01 where Com_STK01.PartNo = Com_BOMH.PartNo) Part_Name," + Environment.NewLine;
            sql = sql + "CrUser Create_By," + Environment.NewLine;
            sql = sql + "CrDate Create_On," + Environment.NewLine;
            sql = sql + "MdUser Modify_By," + Environment.NewLine;
            sql = sql + "MdDate Modify_On," + Environment.NewLine;
            sql = sql + "remark" + Environment.NewLine;
            sql = sql + "from" + Environment.NewLine;
            sql = sql + "Com_BOMH where partno='" + mat + "'" + Environment.NewLine;
            sql = sql + "order by MdDate desc " + Environment.NewLine;
            return ignition.Tincan(sql);
        }
    }
}
