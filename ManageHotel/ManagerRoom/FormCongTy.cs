using BusinessLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using DataLayer;
using System.Text.RegularExpressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ManagerRoom
{
    public partial class FormCongTy : DevExpress.XtraEditors.XtraForm
    {
        public FormCongTy()
        {
            InitializeComponent();
        }
        CongTy _congty ;
        bool _Them;
        string _IDcongty;
        private void FormCongTy_Load(object sender, EventArgs e)
        {
            _congty = new CongTy();
            LoadData();
            ShowHideControl(true);
            txtID.Enabled = false;
            Enable(false);
        }
        //================================================================================================================
        public bool IsValidEmail(string email)
        {

            if (string.IsNullOrEmpty(email))
            {
                return true;
            }    
            string sMailPattern = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            return Regex.IsMatch(email.Trim(), sMailPattern);

        }
        public bool IsValidVietNamPhoneNumber(string phoneNum)
        {

            if (string.IsNullOrEmpty(phoneNum))
            {
                return true;
            }
            string sMailPattern = @"^((09(\d){8})|(086(\d){7})|(088(\d){7})|(089(\d){7})|(01(\d){9}))$";
            return Regex.IsMatch(phoneNum.Trim(), sMailPattern);
        }
        void ShowHideControl(bool t) //Ẩn 2 btn Cancel và Save
        {
            tsBtnAdd.Visible = t;
            tsBtnExit.Visible = t;
            tsBtnDelete.Visible = t;
            tsBtnFix.Visible = t;
            tsBtnPrint.Visible = t;
            tsBtnPrints.Visible = t;

            tsBtnCancel.Visible = !t;
            tsBtnSave.Visible = !t;
        }
        void Enable(bool t) //Làm mờ các textbox, khi chọn sẽ hiện sáng lên
        {
            txtName.Enabled = t;
            txtPhone.Enabled = t;
            txtFax.Enabled = t;
            txtEmail.Enabled = t;
            txtAddress.Enabled = t;
            checkBoxD.Enabled = t;
        }
        void Reset() // Reset các textbox để thêm mới CONGTY mới
        {
            txtID.Text  = "";
            txtName.Text = "";
            txtPhone.Text  = "";
            txtFax.Text  = "";
            txtEmail.Text  = "";
            txtAddress.Text  = "";
            checkBoxD.Enabled = false;
        }
        void LoadData() // Load lại db và trả về db của CONGTY
        {
            gridControlDS.DataSource = _congty.GetAll();
            gridViewDS.OptionsBehavior.Editable = false; //không thể chỉnh sửa
        }
        //=========================================================================================================
        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            _Them = true;
            txtID.Enabled = true; //cho phép thêm mã ID khi ấn BtnAdd

            ShowHideControl(false);
            //tsBtnAdd.Visible = t;
            //tsBtnExit.Visible = t;
            //tsBtnDelete.Visible = t;
            //tsBtnFix.Visible = t;             các nút ở đây sẽ ẩn

            //tsBtnCancel.Visible = !t;         các nút ở đây sẽ hiện
            //tsBtnSave.Visible = !t;

            Enable(true);
            //void Enable(bool t) 
            //txtName.Enabled = t;
            //txtPhone.Enabled = t;
            //txtFax.Enabled = t;
            //txtEmail.Enabled = t;
            //txtAddress.Enabled = t;
            //checkBoxD.Enabled = t;           các textbox sẽ hiện sáng lên

            Reset();
            //void Reset()                     reset các textbox để thêm mới CONGTY mới
            //txtID.Text = "";
            //txtName.Text = "";
            //txtPhone.Text = "";
            //txtFax.Text = "";
            //txtEmail.Text = "";
            //txtAddress.Text = "";
            //checkBoxD.Enabled = false;
            }

        private void tsBtnFix_Click(object sender, EventArgs e)
        {
            _Them = false;
            txtID.Enabled = false; //không cho sửa mã ID khi ấn BtnFix

            ShowHideControl(false);
            //tsBtnAdd.Visible = t;
            //tsBtnExit.Visible = t;
            //tsBtnDelete.Visible = t;
            //tsBtnFix.Visible = t;             các nút ở đây sẽ ẩn

            //tsBtnCancel.Visible = !t;         các nút ở đây sẽ hiện
            //tsBtnSave.Visible = !t;

            Enable(true);
            //void Enable(bool t) 
            //txtName.Enabled = t;
            //txtPhone.Enabled = t;
            //txtFax.Enabled = t;
            //txtEmail.Enabled = t;
            //txtAddress.Enabled = t;
            //checkBoxD.Enabled = t;           các textbox sẽ hiện sáng lên
        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show ("Are you sure to delete this item?", "Notification",MessageBoxButtons.YesNo,MessageBoxIcon.Warning )==DialogResult.Yes)
            {
                if (_congty.GetItem(_IDcongty).DISABLED == true)
                {
                    _congty.Delete(_IDcongty);
                }
                else
                {
                    MessageBox.Show("DISABLED is unmarked", "Notification", MessageBoxButtons.OKCancel);
                }
            }
            LoadData();  
        }

        private void tsBtnSave_Click(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("E-mail không đúng định dạng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (!IsValidVietNamPhoneNumber(txtPhone.Text) && string.IsNullOrEmpty(txtFax.Text))
            {
                MessageBox.Show("Số điện thoại của bạn không đúng định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Mã Công Ty bắt buộc nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();
                return;
            }
            if (_Them==true)
            {
                tb_CONGTY _CT = new tb_CONGTY();
                _CT.MACTY = txtID.Text;
                _CT.TENCTY = txtName.Text;
                _CT.DIENTHOAI = txtPhone.Text;
                _CT.EMAIL = txtEmail.Text;
                _CT.FAX = txtFax.Text;
                _CT.DIACHI = txtAddress.Text;
                _CT.DISABLED = checkBoxD.Checked;
                _congty.Add(_CT);
            }
            else
            {
                tb_CONGTY _CT = _congty.GetItem(_IDcongty); // đưa tham số ID để so sánh với các mã ID trong db, và update cho đúng objectID
                //MACTY không được sửa
                _CT.TENCTY = txtName.Text;
                _CT.DIENTHOAI = txtPhone.Text;
                _CT.EMAIL = txtEmail.Text;
                _CT.FAX = txtFax.Text;
                _CT.DIACHI = txtAddress.Text;
                _CT.DISABLED = checkBoxD.Checked;
                _congty.Update(_CT); 
            }
            _Them = false; // phải false để đảm bảo lần sau quay về y như cũ
            LoadData();
            Enable(false);
            //void Enable(bool t) 
            //txtName.Enabled = t;
            //txtPhone.Enabled = t;
            //txtFax.Enabled = t;
            //txtEmail.Enabled = t;
            //txtAddress.Enabled = t;
            //checkBoxD.Enabled = t;           các textbox sẽ ẩn đi

            ShowHideControl(true);
            //tsBtnAdd.Visible = t;
            //tsBtnExit.Visible = t;
            //tsBtnDelete.Visible = t;
            //tsBtnFix.Visible = t;             các nút ở đây sẽ hiện

            //tsBtnCancel.Visible = !t;         các nút ở đây sẽ ẩn
            //tsBtnSave.Visible = !t;
        }

        private void tsBtnCancel_Click(object sender, EventArgs e)
        {
            _Them = false;
            ShowHideControl(true);
            //tsBtnAdd.Visible = t;
            //tsBtnExit.Visible = t;
            //tsBtnDelete.Visible = t;
            //tsBtnFix.Visible = t;             các nút ở đây sẽ hiện

            //tsBtnCancel.Visible = !t;         các nút ở đây sẽ ẩn
            //tsBtnSave.Visible = !t;
            txtID.Enabled = false;
            Enable(false);
            //void Enable(bool t) 
            //txtName.Enabled = t;
            //txtPhone.Enabled = t;
            //txtFax.Enabled = t;
            //txtEmail.Enabled = t;
            //txtAddress.Enabled = t;
            //checkBoxD.Enabled = t;           các textbox sẽ ẩn đi
        }

        private void tsBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridViewDS_Click(object sender, EventArgs e)
        {
            if (gridViewDS.RowCount >0)
            {
                _IDcongty = gridViewDS.GetFocusedRowCellValue("MACTY").ToString();
                txtID.Text = gridViewDS.GetFocusedRowCellValue("MACTY").ToString();
                txtName.Text = gridViewDS.GetFocusedRowCellValue("TENCTY").ToString();
                txtPhone.Text = gridViewDS.GetFocusedRowCellValue("DIENTHOAI").ToString();
                txtEmail.Text = gridViewDS.GetFocusedRowCellValue("EMAIL").ToString();
                txtFax.Text = gridViewDS.GetFocusedRowCellValue("FAX").ToString();
                txtAddress.Text = gridViewDS.GetFocusedRowCellValue("DIACHI").ToString();
                checkBoxD.Checked = bool.Parse(gridViewDS.GetFocusedRowCellValue("DISABLED").ToString());
            }
        }

        private void tsBtnPrint_Click(object sender, EventArgs e)
        {
            XuatReport("DM_CONGTY", "Danh Mục Công Ty");
        }
        private void XuatReport(string _reportName, string _title)
        {
            BinaryFormatter bf = new BinaryFormatter();  // tạo đối tượng chuyển đổi file
            FileStream fs = File.Open("connectdb.dba", FileMode.Open, FileAccess.Read);
            Connect cp = (Connect)bf.Deserialize(fs);    // đọc kết quả file thu được từ quá trình serialize bên connect.cs                             
            string servername = Encryptor.Decrypt(cp.servername, "qwertyuiop", true);
            string username = Encryptor.Decrypt(cp.username, "qwertyuiop", true);
            string pass = Encryptor.Decrypt(cp.passwd, "qwertyuiop", true);
            string database = Encryptor.Decrypt(cp.database, "qwertyuiop", true);

            if (_IDcongty != null)
            {
                Form frm = new Form();
                CrystalReportViewer Crv = new CrystalReportViewer();
                Crv.ShowGroupTreeButton = false;
                Crv.ShowParameterPanelButton = false;
                Crv.ToolPanelView = ToolPanelViewType.None;
                TableLogOnInfo Info;
                ReportDocument doc = new ReportDocument();
                doc.Load(System.Windows.Forms.Application.StartupPath + "\\Report\\" + _reportName + @".rpt");
                Info = doc.Database.Tables[0].LogOnInfo;
                Info.ConnectionInfo.ServerName = servername;
                Info.ConnectionInfo.DatabaseName = database;
                Info.ConnectionInfo.UserID = username;
                Info.ConnectionInfo.Password = pass;
                doc.Database.Tables[0].ApplyLogOnInfo(Info);
                try
                {
                    doc.SetParameterValue("MACTY", _IDcongty.ToString());
                    Crv.Dock = DockStyle.Fill;
                    Crv.ReportSource = doc;
                    frm.Controls.Add(Crv);
                    Crv.Refresh();
                    frm.Text = _title;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.ToString());
                }
                fs.Close();
            }  
            else
            {
                MessageBox.Show("Không Có Dữ Liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void XuatDanhSachReport(string _reportName, string _title)
        {
            BinaryFormatter bf = new BinaryFormatter();  // tạo đối tượng chuyển đổi file
            FileStream fs = File.Open("connectdb.dba", FileMode.Open, FileAccess.Read);
            Connect cp = (Connect)bf.Deserialize(fs);    // đọc kết quả file thu được từ quá trình serialize bên connect.cs                             
            string servername = Encryptor.Decrypt(cp.servername, "qwertyuiop", true);
            string username = Encryptor.Decrypt(cp.username, "qwertyuiop", true);
            string pass = Encryptor.Decrypt(cp.passwd, "qwertyuiop", true);
            string database = Encryptor.Decrypt(cp.database, "qwertyuiop", true);

            if (_IDcongty != null)
            {
                Form frm = new Form();
                CrystalReportViewer Crv = new CrystalReportViewer();
                Crv.ShowGroupTreeButton = false;
                Crv.ShowParameterPanelButton = false;
                Crv.ToolPanelView = ToolPanelViewType.None;
                TableLogOnInfo Info;
                ReportDocument doc = new ReportDocument();
                doc.Load(System.Windows.Forms.Application.StartupPath + "\\Report\\" + _reportName + @".rpt");
                Info = doc.Database.Tables[0].LogOnInfo;
                Info.ConnectionInfo.ServerName = servername;
                Info.ConnectionInfo.DatabaseName = database;
                Info.ConnectionInfo.UserID = username;
                Info.ConnectionInfo.Password = pass;
                doc.Database.Tables[0].ApplyLogOnInfo(Info);
                try
                {
                    Crv.Dock = DockStyle.Fill;
                    Crv.ReportSource = doc;
                    frm.Controls.Add(Crv);
                    Crv.Refresh();
                    frm.Text = _title;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.ToString());
                }
                fs.Close();
            }
            else
            {
                MessageBox.Show("Không Có Dữ Liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tsBtnPrints_Click(object sender, EventArgs e)
        {
            XuatDanhSachReport("DM_CONGTY_DS", "Danh Mục Công Ty");
        }
        //private void gridViewDS_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        // {
        //     if (e.Column.Name =="DISABLED" && bool.Parse(e.CellValue.ToString())==true)
        //     {
        //         Image img = Properties.Resources.delete16x16;
        //         e.Graphics.DrawImage(img, e.Bounds.X , e.Bounds.Y);
        //         e.Handled = true;
        //     }
        // }
    }
}