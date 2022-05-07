using DataLayer;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
namespace ManagerRoom
{

    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); //kích hoạt kiểu trực quan (màu sắc, yếu tố hình ảnh, hiệu ứng khác) tạo thành chủ đề cho các điều khiển và hệ điều ành
            Application.SetCompatibleTextRenderingDefault(false); // đặt phương thức Hiển thị Văn bản Tương thích
            if (File.Exists("connectdb.dba"))
            {
                BinaryFormatter bf = new BinaryFormatter();  // tạo đối tượng chuyển đổi file
                FileStream fs = File.Open("connectdb.dba", FileMode.Open, FileAccess.Read);
                Connect cp = (Connect)bf.Deserialize(fs);    // đọc kết quả file thu được từ quá trình serialize bên connect.cs                             
                string servername = Encryptor.Decrypt(cp.servername, "qwertyuiop", true);
                string username = Encryptor.Decrypt(cp.username, "qwertyuiop", true);
                string pass = Encryptor.Decrypt(cp.passwd, "qwertyuiop", true);
                string database = Encryptor.Decrypt(cp.database, "qwertyuiop", true);
                string conStr = "";
                conStr += "Data Source=" + servername + "; Initial Catalog=" + database + "; User ID=" + username + "; Password=" + pass + ";";
                conn = conStr; 
                SqlConnection con = new SqlConnection(conStr);
                try
                {
                    con.Open();
                }
                catch
                {
                    //MessageBox.Show("Connection Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fs.Close();
                    Application.Run(new FormChangePass());
                }
                con.Close();
                fs.Close();
                if (File.Exists("sysparam.ini"))
                {
                    Application.Run(new FormLogin());
                }
                else
                {
                    Application.Run(new FormSystemParam());
                }
            }    
            else
            {
                Application.Run(new FormDatabaseConnect());
            }

        }
        public static string conn = "";
    }
}
