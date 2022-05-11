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
    public partial class FormChangePass : DevExpress.XtraEditors.XtraForm
    {
        public FormChangePass()
        {
            InitializeComponent();
        }
        SqlConnection GetCon(string server, string username, string pass, string database)
        {
            return new SqlConnection("Data Source=" + server + "; Initial Catalog=" + database + "; User ID=" + username + "; Password=" + pass + ";"); // return chuỗi kết nối
        }
        private void btnCheckData_Click(object sender, EventArgs e)
        {
            try
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

                if (txtNewPass.Text == pass && txtServer.Text == servername && txtUsername.Text == username && cbbDatabase.Text == database)
                {
                    MessageBox.Show("Successful Connection");

                    string conn = "Server=" + txtServer.Text + "; User ID=" + txtUsername.Text + "; Password=" + txtNewPass.Text + ";"; //chuỗi kết nối kiểu string
                    SqlConnection con = new SqlConnection(conn); //tạo đối tượng kết nối đưa tham số kết nối kiểu string vào
                    con.Open(); //mở kết nối
                    string qr = " SELECT NAME FROM SYS.DATABASES";
                    SqlCommand cmd = new SqlCommand(qr, con); //khởi tạo đối tượng datacommand để truy vấn dữ liệu
                    IDataReader dr = cmd.ExecuteReader(); // khởi tạo đối tượng datareader để thi hành truy vấn
                    while (dr.Read())
                    {
                        cbbDatabase.Items.Add(dr[0].ToString()); //đọc các dữ liệu trả về từ các item dòng đầu tiên cho đến cuối
                    }
                }
                fs.Close();

            }
            catch (Exception)
            {
                    MessageBox.Show("Enter New Info", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);    
            }
    
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            string svEncrypt = Encryptor.Encrypt(txtServer.Text, "qwertyuiop", true);
            string usEncrypt = Encryptor.Encrypt(txtUsername.Text, "qwertyuiop", true);
            string passEncrypt = Encryptor.Encrypt(txtNewPass.Text, "qwertyuiop", true);
            string dbEncrypt = Encryptor.Encrypt(cbbDatabase.Text, "qwertyuiop", true);
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Choose where to save";
            sf.Filter = "Text File (*.dba|*.dba| AllFiles(*.*)|*.*"; // Structer Default để lưu trữ đuôi tệp
            if (sf.ShowDialog() == DialogResult.OK) //Submit
            {
                Connect cn = new Connect(svEncrypt, usEncrypt, passEncrypt, dbEncrypt); // khởi tạo class Connect.s
                cn.ConnectData(sf.FileName);                                            // gọi method's Connect.cs                
                MessageBox.Show("File saved successfully", "Notification");
            }
        }

        private void FormChangePass_Load(object sender, EventArgs e)
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

        private void btnEyeShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnEyeHide.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnEyeHide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnEyeShow.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnEyeShow2_Click(object sender, EventArgs e)
        {
            if (txtNewPass.PasswordChar == '\0')
            {
                btnEyeHide2.BringToFront();
                txtNewPass.PasswordChar = '*';
            }
        }

        private void btnEyeHide2_Click(object sender, EventArgs e)
        {
            if (txtNewPass.PasswordChar == '*')
            {
                btnEyeShow2.BringToFront();
                txtNewPass.PasswordChar = '\0';
            }
        }
    }
}