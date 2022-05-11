using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerRoom
{
    public class MyFunction
    {
        public static string _macty;
        public static string _madvi;
        public static string _server;
        public static string _username;
        public static string _passwword;
        public static string _database;
        //sqlConnection
        static SqlConnection con = new SqlConnection();
        public static void CreateConnect()
        {
            con.ConnectionString = Program.conn ;
            try
            {
                con.Open();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void CloseConnect()
        {
                con.Close();
        }
        public static DataTable GetData(string query)
        {
            CreateConnect();
            DataTable table = new DataTable();
            SqlDataAdapter DAP = new SqlDataAdapter();
            DAP.SelectCommand = new SqlCommand(query, con);
            DAP.Fill(table);
            CloseConnect();
            return table;
        }
        public static DateTime GetFirstDayInMonth(int year, int month)
        {
            return new DateTime(year, month, 1);
        }
        //public static void XuatReport(string _keyID, string _reportName, string _title)
        //{
        //    BinaryFormatter bf = new BinaryFormatter();  // tạo đối tượng chuyển đổi file
        //    FileStream fs = File.Open("connectdb.dba", FileMode.Open, FileAccess.Read);
        //    Connect cp = (Connect)bf.Deserialize(fs);    // đọc kết quả file thu được từ quá trình serialize bên connect.cs                             
        //    string servername = Encryptor.Decrypt(cp.servername, "qwertyuiop", true);
        //    string username = Encryptor.Decrypt(cp.username, "qwertyuiop", true);
        //    string pass = Encryptor.Decrypt(cp.passwd, "qwertyuiop", true);
        //    string database = Encryptor.Decrypt(cp.database, "qwertyuiop", true);

        //    if (_keyID != null)
        //    {
        //        Form frm = new Form();
        //        CrystalReportViewer Crv = new CrystalReportViewer();
        //        Crv.ShowGroupTreeButton = false;
        //        Crv.ShowParameterPanelButton = false;
        //        Crv.ToolPanelView = ToolPanelViewType.None;
        //        TableLogOnInfo Info;
        //        ReportDocument doc = new ReportDocument();
        //        doc.Load(System.Windows.Forms.Application.StartupPath + "\\Report\\" + _reportName + @".rpt");
        //        Info = doc.Database.Tables[0].LogOnInfo;
        //        Info.ConnectionInfo.ServerName = servername;
        //        Info.ConnectionInfo.DatabaseName = database;
        //        Info.ConnectionInfo.UserID = username;
        //        Info.ConnectionInfo.Password = pass;
        //        doc.Database.Tables[0].ApplyLogOnInfo(Info);
        //        try
        //        {
        //            doc.SetParameterValue("_keyID", _keyID.ToString());
        //            Crv.Dock = DockStyle.Fill;
        //            Crv.ReportSource = doc;
        //            frm.Controls.Add(Crv);
        //            Crv.Refresh();
        //            frm.Text = _title;
        //            frm.WindowState = FormWindowState.Maximized;
        //            frm.ShowDialog();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Lỗi: " + ex.ToString());
        //        }
        //        fs.Close();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Không Có Dữ Liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        //public static void XuatDanhSachReport(string _keyID, string _reportName, string _title)
        //{
        //    BinaryFormatter bf = new BinaryFormatter();  // tạo đối tượng chuyển đổi file
        //    FileStream fs = File.Open("connectdb.dba", FileMode.Open, FileAccess.Read);
        //    Connect cp = (Connect)bf.Deserialize(fs);    // đọc kết quả file thu được từ quá trình serialize bên connect.cs                             
        //    string servername = Encryptor.Decrypt(cp.servername, "qwertyuiop", true);
        //    string username = Encryptor.Decrypt(cp.username, "qwertyuiop", true);
        //    string pass = Encryptor.Decrypt(cp.passwd, "qwertyuiop", true);
        //    string database = Encryptor.Decrypt(cp.database, "qwertyuiop", true);

        //    if (_keyID != null)
        //    {
        //        Form frm = new Form();
        //        CrystalReportViewer Crv = new CrystalReportViewer();
        //        Crv.ShowGroupTreeButton = false;
        //        Crv.ShowParameterPanelButton = false;
        //        Crv.ToolPanelView = ToolPanelViewType.None;
        //        TableLogOnInfo Info;
        //        ReportDocument doc = new ReportDocument();
        //        doc.Load(System.Windows.Forms.Application.StartupPath + "\\Report\\" + _reportName + @".rpt");
        //        Info = doc.Database.Tables[0].LogOnInfo;
        //        Info.ConnectionInfo.ServerName = servername;
        //        Info.ConnectionInfo.DatabaseName = database;
        //        Info.ConnectionInfo.UserID = username;
        //        Info.ConnectionInfo.Password = pass;
        //        doc.Database.Tables[0].ApplyLogOnInfo(Info);
        //        try
        //        {
        //            Crv.Dock = DockStyle.Fill;
        //            Crv.ReportSource = doc;
        //            frm.Controls.Add(Crv);
        //            Crv.Refresh();
        //            frm.Text = _title;
        //            frm.WindowState = FormWindowState.Maximized;
        //            frm.ShowDialog();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Lỗi: " + ex.ToString());
        //        }
        //        fs.Close();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Không Có Dữ Liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
