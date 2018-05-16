using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing;
using System.Net;
using System.Reflection;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;

namespace SMCL_MIS
{
     

    public class Igni
    {

        SqlConnection Protein_pill;

        SqlDataAdapter Helmet;

        DataTable ds;

        SqlCommand cmd;

        public void engineon()
        {

            if (Protein_pill == null)
                if (LoginInfo.database == "LIVE")
                {
                    Protein_pill = new SqlConnection("Data Source=192.168.84.4;" +
                    "Initial Catalog=SMCL;" +
                    "User id=sa;" +
                    "Password=Sunluxe@123;");
                }
                else
                {
                    Protein_pill = new SqlConnection("Data Source=192.168.84.8;" +
                     "Initial Catalog=SMCL;" +
                     "User id=sa;" +
                     "Password=smcl2017;");
                }


            if (Protein_pill.State == ConnectionState.Closed)
            {
                try
                {

                    Protein_pill.Open();
                    //MessageBox.Show("Well done!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Cannot Connect To Database!" + ex.Message);
                }
            }

        }

        public void engineoff()
        {

            if ((Protein_pill != null) && (Protein_pill.State == ConnectionState.Open))

                Protein_pill.Close();

        }

        public DataTable Tincan(string sql)

        {
            ds = new DataTable();
            try {
                engineon();

                Helmet = new SqlDataAdapter(sql, Protein_pill);
                Helmet.Fill(ds);
                engineoff();

               
            }
            catch (Exception ext)
            {
                update_user_errlog(LoginInfo.username
                    , Extensions.activeform
                    , ext.Message.ToString()
                    , DateTime.Now.ToString());
                MessageBox.Show(ext.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ds;

        }

        public void ExeCuteNonQuery(string sql)
        {
            try
            {

                engineon();
                //Encoding tc = Encoding.GetEncoding("BIG5");
                //byte[] bytes = tc.GetBytes(sql);
                //sql = Encoding.Unicode.GetString(bytes);

                cmd = new SqlCommand(sql, Protein_pill);

                cmd.ExecuteNonQuery();

                engineoff();
            }
            catch (Exception ext)
            {
                update_user_errlog(LoginInfo.username
                    , Extensions.activeform
                    , ext.Message.ToString()
                    , DateTime.Now.ToString());
                MessageBox.Show(ext.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void update_last_login(string uname, string ip, string computername, DateTime date, string ver, string db)
        {
            string sql = "INSERT INTO[dbo].[smcl_login_log]" + Environment.NewLine;
            sql = sql + " ([userid]" + Environment.NewLine;
            sql = sql + ",[ipaddress]" + Environment.NewLine;
            sql = sql + ",[computername]" + Environment.NewLine;
            sql = sql + ",[lastlogin],[version],[db])" + Environment.NewLine;
            sql = sql + "VALUES" + Environment.NewLine;
            sql = sql + "('" + uname + "'" + Environment.NewLine;
            sql = sql + ",convert(varchar(50),(select CONNECTIONPROPERTY('client_net_address'))) " + Environment.NewLine;
            sql = sql + ",'" + computername + "'" + Environment.NewLine;
            sql = sql + ",'" + date + "'" + Environment.NewLine;
            sql = sql + ",'" + ver + "'" + Environment.NewLine;
            sql = sql + ",'" + db + "')" + Environment.NewLine;
            ExeCuteNonQuery(sql);
        }

        public DataTable check_user(string u, string p)
        {
            return Tincan("select * from [dbo].[com_User] where UserID='" + u + "' and password='" + p + "';");
        }

        public bool check_user_permission(string userid, string frm, string permission)
        {
            string sql = "select {0} from smcl_UserPermission" + Environment.NewLine;
            sql = sql + "where userid = '{1}'" + Environment.NewLine;
            sql = sql + "and system_form = '{2}'" + Environment.NewLine;
            sql = string.Format(sql, permission, userid, frm);
            DataTable dt = new DataTable();
            dt = Tincan(sql);
            if (dt.Rows.Count > 0) {
                if (dt.Rows[0][0].ToString() == "1")
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public void update_user_errlog(string err_user,string err_frm,string err_text,string err_date)
        {
            err_text = err_text.Replace("'", "");
            string sql = "";
            sql += "INSERT INTO [dbo].[smcl_error_log]" + Environment.NewLine;
            sql += "([err_user]" + Environment.NewLine;
            sql += ",[err_frm]" + Environment.NewLine;
            sql += ",[err_text]" + Environment.NewLine;
            sql += ",[err_date])" + Environment.NewLine;
            sql += " VALUES" + Environment.NewLine;
            sql += "('"+ err_user + "'" + Environment.NewLine;//<err_user, nvarchar(20),>
            sql += ",'" + err_frm + "'" + Environment.NewLine;//< err_frm, varchar(20),>
            sql += ",'" + err_text + "'" + Environment.NewLine;//< err_text, varchar(250),>
            sql += ",'" + err_date + "')" + Environment.NewLine;//< err_date, datetime,>
            ExeCuteNonQuery(sql);
        }

    }

    public static class LoginInfo
    {

        public static string username;
        public static string name;
        public static string dept;
        public static string database;
    }

    public static class Extensions
    {
        public static string activeform=null;
        public static string Engineer = null;
        public static string Planning = null;
        public static string Sales = null;
        public static string Purchasing = null;
        public static string Production = null;
        public static string warehouse = null;
        public static string Financial = null;
        public static string hr = null;
        public static string calendar = null; 
        public static string setting = null;

        public static int set_rp_row = 12;

        public static string warning_deleting = "Are You sure want to delete this?" + Environment.NewLine + "Bạn có chắc muốn xóa?";
        public static string warning_missingfield = "Missing Input or not in correct format!"+Environment.NewLine
            +"Nhập thiếu hoặc không đúng định dạng!";
        public static string warning_missingpermission = "You do not have permission to proceed !" + Environment.NewLine
            + "Bạn không có quyền thực hiện thao tác này!";
        public static string error_cannotsave = "Can not save, Please try again!" + Environment.NewLine
            + "Không thể lưu, Vui lòng thử lại!";
        public static string error_delete_approved = "Approved, Can not delete" + Environment.NewLine
            + "Đã Approve, Không thể xóa!";
        private static object openFileDialog1;

        public static int bool_to_int(bool in2)
        {
            if (in2)
                return 1;
            else
                return 0;
        }
        public static string get_mat_photo(string cate,string key)
        {
            string path = "";
            string rootfolder = "";

            switch (cate)
            {
                case "Materials":
                    rootfolder = @"\\192.168.84.2\bom\picture of BOM\picture\";
                    break;
                case "Equipment":
                    rootfolder = @"\\192.168.84.2\it\06_Documents\Equipmentphoto";
                    break;
            }
            //(System.Windows.Forms.Application.OpenForms["Main"] as Main).set_processbar(0);

            string[] filePaths = Directory.GetFiles(rootfolder, key + "*",
                                     SearchOption.AllDirectories);
            if (filePaths.Length == 0 || key == "")
            {
                path = @"\\192.168.84.2\Public\MyDriver\SMCL_MIS\picture\image-not-found.jpg";
            }
            else
            {
                path = filePaths[0];
            }

            return path;
        }

        public static void set_picture(string type, string key,PictureBox pictureBox1)
        {
            new Thread(delegate ()
            {
                try
                {

                    if (key == "")
                        return;
                    pictureBox1.Image = Image.FromFile(get_mat_photo(type, key));
                    var imageSize = pictureBox1.Image.Size;
                    var fitSize = pictureBox1.ClientSize;
                    pictureBox1.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                        PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
                }
                catch
                {
                    // Do nothing and let it try again until the attempts are exausted.
                    // Exceptions are thrown for normal ping failurs like address lookup
                    // failed.  For this reason we are supressing errors.
                }

            }).Start();
            //(System.Windows.Forms.Application.OpenForms["Main"] as Main).set_processbar(0);
        }
        public static void get_template(string path,SaveFileDialog saveFileDialog1)
        {
            try {
                saveFileDialog1.ShowDialog();
                //saveFileDialog1.FileName = "PO_import_template.xlsx";
                saveFileDialog1.Filter = "Data Files (*.xlsx)|*.xlsx";
                saveFileDialog1.DefaultExt = "xlsx";
                saveFileDialog1.AddExtension = true;
                string filepath = saveFileDialog1.FileName;
                WebClient webClient = new WebClient();
                webClient.DownloadFile(path, filepath);
                System.Diagnostics.Process.Start(@filepath);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message.ToString());
            }
            
        }
        public static DataTable from_excel(OpenFileDialog openFileDialog1)
        {
            DataTable data = new DataTable();
            String name = "Sheet1";
            DialogResult result = openFileDialog1.ShowDialog();
            try
            {
                String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                         openFileDialog1.FileName +
                          ";Extended Properties='Excel 12.0 XML;HDR=YES;';";

                OleDbConnection con = new OleDbConnection(constr);
                OleDbCommand oconn = new OleDbCommand("Select * From [" + name + "$]", con);
                con.Open();

                OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
                
                sda.Fill(data);
                
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message.ToString());
            }
            return data;

        }
        public static bool int_to_bool(int in2)
        {
            if (in2==1)
                return true;
            else
                return false;
        }
        public static float check_if_float(string s)
        {
            float ignoreMe;
            if (float.TryParse(s, out ignoreMe))
                return float.Parse(s);
            else
                return 0;
        }
        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }
        public static string RemoveSpecialCharacters(this string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '-' || c == '.' || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
        public static Color get_select_row_color()//Grid row highlight
        {
            return Color.FromArgb(255, 173, 51);
        }
        public static Color get_not_editable_col()//Grid row highlight
        {
            return Color.FromArgb(188, 188, 188);
        }
        public static void Export(DataTable tbl,string title = null,string excelFilePath = null)
        {
            try
            {
                if (tbl == null || tbl.Columns.Count == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");

                // load excel, and create a new workbook
                var excelApp = new Excel.Application();
                excelApp.Workbooks.Add();
                Excel._Worksheet workSheet = excelApp.ActiveSheet;
                // single worksheet

                //tao tieu de
                Microsoft.Office.Interop.Excel.Range head = workSheet.get_Range("A1:k1");

                head.MergeCells = true;

                head.Value2 = title;

                head.Font.Bold = true;

                head.Font.Name = "Tahoma";

                head.Font.Size = "14";


                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // column headings
                for (var i = 0; i < tbl.Columns.Count; i++)
                {
                    workSheet.Cells[3, i + 1] = tbl.Columns[i].ColumnName;
                }
                for (int Idx = 0; Idx < tbl.Rows.Count; Idx++)
                {
                    workSheet.Range["A4"].Offset[Idx].Resize[1, tbl.Columns.Count].Value =
                    tbl.Rows[Idx].ItemArray;
                }
                // rows
                //for (var i = 0; i < tbl.Rows.Count; i++)
                //{ 
                //    // to do: format datetime values before printing
                //    for (var j = 0; j < tbl.Columns.Count; j++)
                //    {
                //        workSheet.Cells[i + 4, j + 1] = tbl.Rows[i][j];

                //    }
                //} //Thiết lập vùng điền dữ liệu

                int rowStart = 4;

                int columnStart = 1;

                int rowEnd = rowStart + tbl.Rows.Count - 1;

                int columnEnd = tbl.Columns.Count;

                // Ô bắt đầu điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowStart, columnStart];

                // Ô kết thúc điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowEnd, columnEnd];

                // Lấy về vùng điền dữ liệu

                Microsoft.Office.Interop.Excel.Range range = workSheet.get_Range(c1, c2);



                // Kẻ viền

                range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Căn giữa cột STT

                Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowEnd, columnStart];

                Microsoft.Office.Interop.Excel.Range c4 = workSheet.get_Range(c1, c3);

                //workSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                //workSheet.UsedRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                // check file path

                workSheet.Rows[3].Interior.Color = System.Drawing.Color.LightGray;
                Microsoft.Office.Interop.Excel.Range c5 = (Microsoft.Office.Interop.Excel.Range)workSheet.Cells[3, columnEnd];

                Microsoft.Office.Interop.Excel.Range header = workSheet.get_Range("A3", c5);

                header.Font.Bold = true;

                header.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                header.Font.Name = "Tahoma";

                header.Font.Size = "10";
                // fit row
                range.Rows.AutoFit();

                if (!string.IsNullOrEmpty(excelFilePath))
                {
                    try
                    {
                        workSheet.SaveAs(excelFilePath);
                        excelApp.Quit();
                        MessageBox.Show("Excel file saved!");
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                                            + ex.Message);
                    }
                }
                else
                { // no file path is given
                    excelApp.Visible = true;
                    excelApp.Columns.AutoFit();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }
        }
        public static string EmptyIfNull(this object value)
        {
            if (value == null)
                return "";
            return value.ToString();
        }
        public static bool check_float(string value)
        {
            int intValue;
            float floatValue;
            return Int32.TryParse(value, out intValue) || float.TryParse(value, out floatValue);
        }
        public static bool check_date(string value)
        {
            DateTime value1;
            return DateTime.TryParse(value, out value1);
        }
        public static bool check_int(string i)
        {
            string x = i;
            int value;
            if (int.TryParse(x, out value))
                return true;
            else
                return false;
        } 
        public static void check_per_menu(MenuStrip m) //kiểm tra quyền truy cập
        {
            Igni i = new Igni();
            foreach (ToolStripMenuItem item in m.Items)
            {
                if (i.check_user_permission(LoginInfo.username, item.Name, "Fread"))
                {
                    item.Enabled = true;
                    item.Click += new EventHandler(MenuItemClickHandler);

                }
                else { item.Enabled = false; }
                foreach (ToolStripMenuItem children in item.DropDownItems)
                {
                    if (i.check_user_permission(LoginInfo.username, children.Name, "Fread"))
                    {
                        children.Enabled = true;
                        children.Click += new EventHandler(MenuItemClickHandler);
                    }
                    else { children.Enabled = false; }
                }
            }
        }
        public static void MenuItemClickHandler(object sender, EventArgs e)// tạo mới handle cho sự kiện click menu
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            (Application.OpenForms["Main"] as Main).openformbyname(clickedItem.Name);
        }

        public static void set_grid_style(DataGridView g)
        {
            //g.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //Gv_List.Columns[0].DefaultCellStyle.BackColor = Color.FromArgb(237, 237, 237);
            g.AllowUserToResizeColumns = true;
            
            g.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(237, 237, 237);
            g.ColumnHeadersDefaultCellStyle.Font= new Font("Camlibri", 8.75F);
            g.AlternatingRowsDefaultCellStyle.BackColor =    Color.FromArgb(255, 245, 230);

            if (g.Rows.Count > 0)
            {
                g.Columns[0].Frozen = true;
            }
            g.ColumnHeadersHeight = 30;
            //g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            g.EnableHeadersVisualStyles = false;
            g.RowsDefaultCellStyle.SelectionForeColor =
            g.DefaultCellStyle.SelectionForeColor = Color.Black;
            g.RowsDefaultCellStyle.SelectionBackColor =
            g.DefaultCellStyle.SelectionBackColor = Extensions.get_select_row_color();
        }
    }
    public class IniFile
    {
        public string path;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
            string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
                 string key, string def, StringBuilder retVal,
            int size, string filePath);

        /// <summary>
        /// INIFile Constructor.
        /// </summary>
        /// <PARAM name="INIPath"></PARAM>
        public IniFile(string INIPath)
        {
            path = INIPath;
        }
        /// <summary>
        /// Write Data to the INI File
        /// </summary>
        /// <PARAM name="Section"></PARAM>
        /// Section name
        /// <PARAM name="Key"></PARAM>
        /// Key Name
        /// <PARAM name="Value"></PARAM>
        /// Value Name
        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.path);
        }

        /// <summary>
        /// Read Data Value From the Ini File
        /// </summary>
        /// <PARAM name="Section"></PARAM>
        /// <PARAM name="Key"></PARAM>
        /// <PARAM name="Path"></PARAM>
        /// <returns></returns>
        public string IniReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp,
                                            255, this.path);
            return temp.ToString();

        }
    }

}
