using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCL_MIS
{
    class GC_Setting
    {
        Igni i = new Igni();

        public DataTable get_equipment(string e)
        {
            string sql = "select * from [smcl_equipment]a,[dbo].[smcl_equipment_config]b" + Environment.NewLine;
            sql += "where a.equipment_id = b.equipment_id" + Environment.NewLine;
            sql += "and a.equipment_id  like '"+ e + "%' order by a.equipment_id desc " + Environment.NewLine;
            return i.Tincan(sql);
        }

        public bool check_mac(string Mac)
        {
            string sql = " select count(*)count from smcl_equipment  where equipment_mac = '" + Mac + "'";
            DataTable dt = i.Tincan(sql);
            if (dt.Rows[0]["count"].ToString() == "0")
                return false;
            else
                return true;
        }
        public void new_equipment_lis(string equipment_description  
           , string equipment_create_date 
           , string equipment_mac 
           , string equiptment_status 
           , string config_ip   )
        {
            string sql = "";
            sql += "";
            sql = sql + "INSERT INTO[dbo].[smcl_equipment]" + Environment.NewLine;
            sql = sql + "([equipment_description]" + Environment.NewLine; 
            sql = sql + ",[equipment_create_date]" + Environment.NewLine;
            sql = sql + ",[equipment_warranty]" + Environment.NewLine;
            sql = sql + ",[equipment_mac]" + Environment.NewLine; 
            sql = sql + ",[equiptment_status])" + Environment.NewLine;
            sql = sql + "VALUES" + Environment.NewLine;
            sql = sql + "('" + equipment_description + "'" + Environment.NewLine;//<equipment_description, nvarchar(200),> 
            sql = sql + ",'" + equipment_create_date + "'" + Environment.NewLine;//< equipment_create_date, varchar(20),> 
            sql = sql + ",'" + equipment_mac + "',0" + Environment.NewLine;//< equipment_mac, varchar(20),> 
            sql = sql + ",'" + equiptment_status + "')" + Environment.NewLine;//< equiptment_status, nvarchar(50),> 
            i.ExeCuteNonQuery(sql);
            string sql1 = "";
            sql1 += "INSERT INTO[dbo].[smcl_equipment_config]" + Environment.NewLine;
            sql1 += "([equipment_id]" + Environment.NewLine;
            sql1 += ",[config_ip])" + Environment.NewLine; 
            sql1 += "VALUES" + Environment.NewLine;
            sql1 += "((select max(equipment_id) from smcl_equipment)" + Environment.NewLine;//<config_ip, varchar(20),>
            sql1 += ",'" + config_ip + "')" + Environment.NewLine;//<config_ip, varchar(20),>     

            i.ExeCuteNonQuery(sql1);
        }
        public void update_equipment_list(string equipment_id
            , string equipment_description    
            , string equipment_mac   
            , string config_ip   )
        {
            string sql = "UPDATE [dbo].[smcl_equipment]" + Environment.NewLine;
            sql += "SET[equipment_description] = '" + equipment_description + "'" + Environment.NewLine;
            sql += ",[equipment_mac] = '" + equipment_mac + "'" + Environment.NewLine;
            sql += "WHERE equipment_id='" + equipment_id + "';";
            i.ExeCuteNonQuery(sql);

            string sql1 = "";
            sql1 += "UPDATE [dbo].[smcl_equipment_config]" + Environment.NewLine;
            sql1 += "SET[config_ip] = '" + config_ip + "'" + Environment.NewLine;//< config_ip, varchar(20),>
            sql1 += "WHERE equipment_id='" + equipment_id + "';";
            i.ExeCuteNonQuery(sql1);
        }
        public void update_equipment(string equipment_id
            , string equipment_description
            , string equipment_date
            , string equipment_warranty
            , string equipment_create_date
            , string equipment_SN
            , string equipment_mac
            , string equipment_remark
            , string equiptment_status
            , string equipment_category
            , string config_ip
            , string config_li
            , string config_pw
            , string config_install_location
            , string config_user
            , string config_installed_date
            , string config_remark)
        {
            if (equipment_warranty == "")
                equipment_warranty = "0";

            string sql = "UPDATE [dbo].[smcl_equipment]" + Environment.NewLine;
            sql += "SET[equipment_description] = '"+equipment_description+"'" + Environment.NewLine;//< equipment_description, nvarchar(200),>
            sql += ",[equipment_date] = '" + equipment_date + "'" + Environment.NewLine;//<equipment_date, varchar(20),>
            sql += ",[equipment_warranty] = "+ equipment_warranty  + Environment.NewLine;//<equipment_warranty, int,>
            sql += ",[equipment_create_date] = '" + equipment_create_date + "'" + Environment.NewLine;//<equipment_create_date, varchar(20),>
            sql += ",[equipment_SN] ='" + equipment_SN + "'" + Environment.NewLine;// <equipment_SN, varchar(20),>
            sql += ",[equipment_mac] = '" + equipment_mac + "'" + Environment.NewLine;//<equipment_mac, varchar(20),>
            sql += ",[equipment_remark] = '" + equipment_remark + "'" + Environment.NewLine;//<equipment_remark, nvarchar(250),>
            sql += ",[equiptment_status] = '" + equiptment_status + "'" + Environment.NewLine;//<equiptment_status, nvarchar(50),>
            sql += ",[equipment_category] = '" + equipment_category + "'" + Environment.NewLine;//<equipment_category, nvarchar(20),>
            sql += "WHERE equipment_id='" + equipment_id + "';";
            i.ExeCuteNonQuery(sql);

            string sql1 = "";
            sql1 += "UPDATE [dbo].[smcl_equipment_config]" + Environment.NewLine;
            sql1 += "SET[config_ip] = '" + config_ip + "'" + Environment.NewLine;//< config_ip, varchar(20),>
            sql1 += ",[config_li] = '" + config_li + "'" + Environment.NewLine;//< config_li, nvarchar(20),>
            sql1 += ",[config_pw] = '" + config_pw + "'" + Environment.NewLine;//< config_pw, nvarchar(30),>
            sql1 += ",[config_install_location] = '" + config_install_location + "'" + Environment.NewLine;//< config_install_location, nvarchar(100),>
            sql1 += ",[config_user] = '" + config_user + "'" + Environment.NewLine;//< config_user, nvarchar(30),>
            sql1 += ",[config_installed_date] = '" + config_installed_date + "'" + Environment.NewLine;//< config_installed_date, nvarchar(20),>
            sql1 += ",[config_remark] = '" + config_remark + "'" + Environment.NewLine;//< config_remark, nvarchar(250),>
            sql1 += "WHERE equipment_id='" + equipment_id + "';";
            i.ExeCuteNonQuery(sql1);
        }

        public void new_equipment(string equipment_description
            , string equipment_date
            , string equipment_warranty
            , string equipment_create_date
            , string equipment_SN
            , string equipment_mac
            , string equipment_remark
            , string equiptment_status
            , string equipment_category
            , string config_ip
            , string config_li
            , string config_pw
            , string config_install_location
            , string config_user
            , string config_installed_date
            , string config_remark)
        {
            string sql = "";
            sql += "";
            sql = sql + "INSERT INTO[dbo].[smcl_equipment]" + Environment.NewLine;
            sql = sql + "([equipment_description]" + Environment.NewLine;
            sql = sql + ",[equipment_date]" + Environment.NewLine;
            sql = sql + ",[equipment_warranty]" + Environment.NewLine;
            sql = sql + ",[equipment_create_date]" + Environment.NewLine;
            sql = sql + ",[equipment_SN]" + Environment.NewLine;
            sql = sql + ",[equipment_mac]" + Environment.NewLine;
            sql = sql + ",[equipment_remark]" + Environment.NewLine;
            sql = sql + ",[equiptment_status]" + Environment.NewLine;
            sql = sql + ",[equipment_category])" + Environment.NewLine;
            sql = sql + "VALUES" + Environment.NewLine;
            sql = sql + "('"+ equipment_description + "'" + Environment.NewLine;//<equipment_description, nvarchar(200),>
            sql = sql + ",'" + equipment_date + "'" + Environment.NewLine;//< equipment_date, varchar(20),>
            sql = sql + "," + equipment_warranty + "" + Environment.NewLine;//< equipment_warranty, int,>
            sql = sql + ",'" + equipment_create_date + "'" + Environment.NewLine;//< equipment_create_date, varchar(20),>
            sql = sql + ",'" + equipment_SN + "'" + Environment.NewLine;//< equipment_SN, varchar(20),>
            sql = sql + ",'" + equipment_mac + "'" + Environment.NewLine;//< equipment_mac, varchar(20),>
            sql = sql + ",'" + equipment_remark + "'" + Environment.NewLine;//< equipment_remark, nvarchar(250),>
            sql = sql + ",'" + equiptment_status + "'" + Environment.NewLine;//< equiptment_status, nvarchar(50),>
            sql = sql + ",'" + equipment_category + "')";//< equipment_category, nvarchar(20),>
            i.ExeCuteNonQuery(sql);
            string sql1 = "";
            sql1+= "INSERT INTO[dbo].[smcl_equipment_config]" + Environment.NewLine;
            sql1 += "([equipment_id]" + Environment.NewLine;
            sql1 += ",[config_ip]" + Environment.NewLine;
            sql1 += ",[config_li]" + Environment.NewLine;
            sql1 += ",[config_pw]" + Environment.NewLine;
            sql1 += ",[config_install_location]" + Environment.NewLine;
            sql1 += ",[config_user]" + Environment.NewLine;
            sql1 += ",[config_installed_date]" + Environment.NewLine;
            sql1 += ",[config_remark])" + Environment.NewLine;
            sql1 += "VALUES" + Environment.NewLine;
            sql1 += "((select max(equipment_id) from smcl_equipment)" + Environment.NewLine;//<config_ip, varchar(20),>
            sql1 += ",'"+ config_ip + "'" + Environment.NewLine;//<config_ip, varchar(20),>
            sql1 += ",'" + config_li + "'" + Environment.NewLine;//< config_li, nvarchar(20),>
            sql1 += ",'" + config_pw + "'" + Environment.NewLine;//< config_pw, nvarchar(30),>
            sql1 += ",'" + config_install_location + "'" + Environment.NewLine;//< config_install_location, nvarchar(100),>
            sql1 += ",'" + config_user + "'" + Environment.NewLine;//< config_user, nvarchar(30),>
            sql1 += ",'" + config_installed_date + "'" + Environment.NewLine;//< config_installed_date, nvarchar(20),>
            sql1 += ",'"+ config_remark + "')" + Environment.NewLine;//< config_remark, nvarchar(250),>

            i.ExeCuteNonQuery(sql1);
        }

        public DataTable get_top_err_user_bydate(string date)
        {
            string sql = "";
            sql = sql + "select count(err_user) Count_, " + Environment.NewLine;
            sql = sql + "err_user User_," + Environment.NewLine;
            sql = sql + "(select UserName from com_User where com_User.UserID = smcl_error_log.err_user COLLATE DATABASE_DEFAULT) Full_name," + Environment.NewLine;
            sql = sql + "(select UserName from com_User where com_User.UserID = smcl_error_log.err_user COLLATE DATABASE_DEFAULT) Dept" + Environment.NewLine;
            sql = sql + "from smcl_error_log" + Environment.NewLine;
            sql = sql + "where err_date >= '"+ date + "'" + Environment.NewLine;
            sql = sql + "group by err_user" + Environment.NewLine;
            sql = sql + "order by count(err_user) desc" + Environment.NewLine;
            return i.Tincan(sql);
        }

        public DataTable get_user_err_bydate(string date)
        {
            string sql= "" + Environment.NewLine;
            sql = sql + "select " + Environment.NewLine;
            sql = sql + "err_date Date," + Environment.NewLine;
            sql = sql + "err_user User_," + Environment.NewLine;
            sql = sql + "err_frm Form," + Environment.NewLine;
            sql = sql + "err_text Description" + Environment.NewLine;
            sql = sql + "from smcl_error_log"+ Environment.NewLine;
            sql = sql + "where err_date >='" + date + "'  order by err_date desc;" + Environment.NewLine;
            return i.Tincan(sql);
        }

        public DataTable get_login_log_by_userid(string userid)
        {
            string sql = "select lastlogin, ipaddress, computername, db, version from smcl_login_log" + Environment.NewLine;
            sql = sql + "where userid = '"+ userid + "' order by lastlogin desc" + Environment.NewLine;
            return i.Tincan(sql);
        }
       
        public DataTable get_userlist() {
            string sql = " select u.UserID,u.UserName,u.DeptID,u.Email" + Environment.NewLine;
            sql = sql + ", max(l.lastlogin) lastlogin" + Environment.NewLine;
            sql = sql + ", max(l.db)db" + Environment.NewLine;
            sql = sql + ", max(l.computername)computername" + Environment.NewLine;
            sql = sql + ", max(l.ipaddress)ipaddress" + Environment.NewLine;
            sql = sql + ", max(l.version)version " + Environment.NewLine;
            sql = sql + "from com_User u" + Environment.NewLine;
            sql = sql + "left join smcl_login_log l " + Environment.NewLine;
            sql = sql + "on l.userid = u.UserID COLLATE DATABASE_DEFAULT" + Environment.NewLine;
            sql = sql + "group by u.UserID,u.UserName,u.DeptID,u.Email order by DeptID";
            return i.Tincan(sql);
        }

        public DataTable get_user_by_id(string id)
        {
            DataTable dt = new DataTable();
            string sql = "select * from com_User where UserId='" + id + "'";
            dt = i.Tincan(sql);
            return dt;
        }

        public DataTable get_all_module()
        {
            DataTable dt = new DataTable();
            string sql = "select distinct frm_module ";
            sql = sql + "from[dbo].[smcl_frm]";
            dt = i.Tincan(sql);
            return dt;
        }

        public void insert_new_permission()
        {
            string sql = "insert into [smcl_UserPermission]" + Environment.NewLine;
            sql = sql + "select U.UserID userid, f.frm system_form,0 r,0c,0u,0d,0a,0ad" + Environment.NewLine;
            sql = sql + "from com_User U,[smcl_frm] f" + Environment.NewLine;
            sql = sql + "where(select count(*) from[smcl_UserPermission] where[smcl_UserPermission].userid = U.UserID COLLATE DATABASE_DEFAULT) = 0" + Environment.NewLine;
            sql = sql + "or(select count(*) from[smcl_UserPermission] where[smcl_UserPermission].system_form = f.frm COLLATE DATABASE_DEFAULT) = 0" + Environment.NewLine;
            i.ExeCuteNonQuery(sql);
             sql = "delete smcl_UserPermission " + Environment.NewLine;
            sql = sql + "where system_form not in(select frm from smcl_frm)";
            i.ExeCuteNonQuery(sql);
        }

        public void update_userpermission(string userid,string frm, string read, string create, string update, string delete, string approve)
        {
            if (read.ToString().Trim()== "") { read = "0"; }
            if (create.ToString().Trim() == "") { create = "0"; }
            if (update.ToString().Trim() == "") { update = "0"; }
            if (delete.ToString().Trim() == "") { delete = "0"; }
            if (approve.ToString().Trim() == "") { approve = "0"; }

            string sql= "UPDATE [dbo].[smcl_UserPermission]" + Environment.NewLine;
            sql = sql + "SET [FCREATE] = {0}" + Environment.NewLine;
            sql = sql + ",[FREAD] = {1}" + Environment.NewLine;
            sql = sql + ",[FUPDATE] = {2}" + Environment.NewLine;
            sql = sql + ",[FDELETE] = {3}" + Environment.NewLine;
            sql = sql + ",[FAPPROVE] ={4}" + Environment.NewLine; 
            sql = sql + "WHERE userid='{5}' and system_form='{6}'" + Environment.NewLine;
            sql = string.Format(sql, int.Parse(create), int.Parse(read), int.Parse(update), int.Parse(delete), int.Parse(approve), userid, frm);
            i.ExeCuteNonQuery(sql);
        }

        public DataTable get_permission_by_userid(string userid, string module)
        {
            DataTable dt = new DataTable();
            string sql = "select *,(select frm_name from smcl_frm where smcl_frm.frm=smcl_UserPermission.system_form)frm_name " + Environment.NewLine;
            sql = sql + "from[dbo].[smcl_UserPermission]" + Environment.NewLine;
            sql = sql + "where userid ='" + userid + "' " + Environment.NewLine;
            sql = sql + "group by userid, system_form,FCREATE,FUPDATE,FREAD,FDELETE,FADMIN,FAPPROVE" + Environment.NewLine;
            sql = sql + "having   (select frm_module from[smcl_frm] where frm = system_form )='" + module + "'" + Environment.NewLine;
            dt = i.Tincan(sql);
            return dt;
        }

        public void delete_user(string userid)
        {
            string sql = "delete from com_User where userid='" + userid + "'";
            i.ExeCuteNonQuery(sql);
        }

        public void insert_user(string userid, string password, string username, string deptid, string email)
        {
            string sql = "" + Environment.NewLine;
            sql = sql + "INSERT INTO[dbo].[com_User]" + Environment.NewLine;
            sql = sql + "([UserID]" + Environment.NewLine;
            sql = sql + ",[Password]" + Environment.NewLine;
            sql = sql + ",[UserName]" + Environment.NewLine;
            sql = sql + ",[DeptID]" + Environment.NewLine;
            sql = sql + ",[Email])" + Environment.NewLine;
            sql = sql + "VALUES" + Environment.NewLine;
            sql = sql + "('{0}'" + Environment.NewLine;
            sql = sql + ",'{1}'" + Environment.NewLine;
            sql = sql + ",N'{2}'" + Environment.NewLine;
            sql = sql + ",'{3}'" + Environment.NewLine;
            sql = sql + ",'{4}')" + Environment.NewLine;
            sql = string.Format(sql, userid, password, username, deptid, email);
            i.ExeCuteNonQuery(sql);
        }

        public void update_user(string userid, string password, string username, string deptid, string email)
        {
            string sql= "UPDATE [dbo].[com_User]" + Environment.NewLine;
            sql = sql + "SET [Password] = '{0}'" + Environment.NewLine;
            sql = sql + ",[UserName] = N'{1}'" + Environment.NewLine;
            sql = sql + ",[DeptID] = '{2}'" + Environment.NewLine;
            sql = sql + ",[Email] ='{3}'" + Environment.NewLine;
            sql = sql + "WHERE UserID='{4}'" + Environment.NewLine;
            sql = string.Format(sql,  password, username, deptid, email,userid);
            i.ExeCuteNonQuery(sql);
        }
    }
}
