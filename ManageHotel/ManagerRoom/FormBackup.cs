using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerRoom
{
    public partial class FormBackup : DevExpress.XtraEditors.XtraForm
    {
        public FormBackup()
        {
            InitializeComponent();
        }
        SqlConnection GetCon(string server, string username, string pass, string database)
        {
            return new SqlConnection("Data Source=" + server + "; Initial Catalog=" + database + "; User ID=" + username + "; Password=" + pass + ";"); // return chuỗi kết nối
        }
        private void FormBackup_Load(object sender, EventArgs e)
        {
            //Đọc file connectdb.dba đã lưu trong bin/Debug - Read the connect file 
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.Open("connectdb.dba", FileMode.Open, FileAccess.Read);
            Connect cp = (Connect)bf.Deserialize(fs);
            //Giải mã nội dung bên file Encryptor.cs - Decrypt Content
            string servername = Encryptor.Decrypt(cp.servername, "qwertyuiop", true);
            string username = Encryptor.Decrypt(cp.username, "qwertyuiop", true);
            string pass = Encryptor.Decrypt(cp.passwd, "qwertyuiop", true);
            string database = Encryptor.Decrypt(cp.database, "qwertyuiop", true);

            txtServer.Text = servername;
            txtUsername.Text = username;
            cbbDatabase.Text = database;
            txtPassword.Text = pass;

            fs.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                txtPathBackup.Text = dlg.SelectedPath;
                btnSaveDataBackup.Enabled = true;
            }    

        }
        private void btnSaveDataBackup_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = GetCon(txtServer.Text, txtUsername.Text, txtPassword.Text, cbbDatabase.Text);
            string db = con.Database.ToString();
            if (txtPathBackup.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng điền địa chỉ đường dẫn");
            }
            else
            {
                string cmd = "BACKUP DATABASE [" + db + "] TO DISK='" + txtPathBackup.Text + "\\" + "DatabaseHotel" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
                con.Open();
                SqlCommand commanda = new SqlCommand(cmd, con);
                commanda.ExecuteNonQuery();
                MessageBox.Show("Lưu thành công");
                con.Close();
                btnSaveDataBackup.Enabled = false;
            }
        }
        




        //=========================================RESTORE=================================================
        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|.bak";
            dlg.Title = "Database Restore";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                txtPathRestore.Text = dlg.FileName;
                btnRestore.Enabled = true;
            }    
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            SqlConnection con = GetCon(txtServer.Text, txtUsername.Text, txtPassword.Text, cbbDatabase.Text);
            string db = con.Database.ToString();
            con.Open();

            try
            {
                string format1 = string.Format("ALTER DATABASE [" + db + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(format1, con);
                cmd1.ExecuteNonQuery();

                string format2 = "USE MASTER RESTORE DATABASE [" + db + "] FROM DISK ='"+txtPathRestore.Text+"' WITH REPLACE;";
                SqlCommand cmd2 = new SqlCommand(format2, con);
                cmd2.ExecuteNonQuery();

                string format3 = string.Format("ALTER DATABASE [" + db + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(format3, con);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Lưu thành công");
                con.Close();
                btnSaveDataBackup.Enabled = false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
