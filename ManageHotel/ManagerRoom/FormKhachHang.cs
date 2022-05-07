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
using BusinessLayer;
using DataLayer;
using System.Xml.Linq;

namespace ManagerRoom
{
    public partial class FormKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }
        KhachHang _khachhang;
        bool _Them;
        int _IDkhachhang;
        public string _khachdatphong;
        private string fileName = "";

        FormDatPhong objectDP = (FormDatPhong)Application.OpenForms["FormDatPhong"]; //Tạo đối tượng formDatPhong để formKhachHang có thể nhận mọi giá trị, method(public) từ fromDatPhong
        FormDatPhongDon objectDPD = (FormDatPhongDon)Application.OpenForms["FormDatPhongDon"];

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            _khachhang = new KhachHang();
            LoadData();
            ShowHideControl(true);
            txtID.Enabled = false;
            Enable(false);
        }
        void ShowHideControl(bool t) //Ẩn 2 btn Cancel và Save
        {
            tsBtnAdd.Visible = t;
            tsBtnExit.Visible = t;
            tsBtnDelete.Visible = t;
            tsBtnFix.Visible = t;

            tsBtnCancel.Visible = !t;
            tsBtnSave.Visible = !t;
        }
        void Enable(bool t) //Làm mờ các textbox, khi chọn sẽ hiện sáng lên
        {
            txtName.Enabled = t;
            txtCCCD.Enabled = t;
            txtPhone.Enabled = t;
            txtEmail.Enabled = t;
            txtAddress.Enabled = t;
            checkBoxD.Enabled = t;
            cbbSex.Enabled = t;
        }
        void Reset() // Reset các textbox để thêm mới KHACHHANG mới
        {
            txtID.Text = "";
            txtName.Text = "";
            txtCCCD.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            checkBoxD.Enabled = true;
            cbbSex.Enabled = true;
        }
        void LoadData() // Load lại db và trả về db của KHACHHANG
        {
            gridControlDS.DataSource = _khachhang.GetAll();
            gridViewDS.OptionsBehavior.Editable = false;//không thể chỉnh sửa
        }
        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            _Them = true;
            txtID.Enabled = true; //cho phép thêm mã ID khi ấn BtnAdd
            //checkBoxD.Enabled = true;

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
            //void Reset()                     reset các textbox để thêm mới KHACHHANG mới
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
            if (MessageBox.Show("Are you sure to delete this item?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if(_khachhang.GetItem(_IDkhachhang).DISABLED == true)
                {
                    _khachhang.Delete(_IDkhachhang);
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
            if (_Them == true)
            {
                tb_KHACHHANG _KH = new tb_KHACHHANG();
                _KH.IDKHACH = int.Parse(txtID.Text);
                _KH.NAMEKHACH = txtName.Text;
                _KH.DIENTHOAI = txtPhone.Text;
                _KH.EMAIl = txtEmail.Text;
                _KH.CCCD = txtCCCD.Text;
                _KH.DIACHI = txtAddress.Text;
                _KH.DISABLED = checkBoxD.Checked;
                _KH.GIOITINH = cbbSex.Text;
                _khachhang.Add(_KH);
            }
            else
            {
                tb_KHACHHANG  _KH = _khachhang.GetItem(_IDkhachhang); // đưa tham số ID để so sánh với các mã ID trong db, và update cho đúng objectID
                //MACTY không được sửa
                _KH.NAMEKHACH  = txtName.Text;
                _KH.DIENTHOAI = txtPhone.Text;
                _KH.EMAIl = txtEmail.Text;
                _KH.CCCD = txtCCCD.Text;
                _KH.DIACHI = txtAddress.Text;
                _KH.DISABLED = checkBoxD.Checked;
                _KH.GIOITINH = cbbSex.Text;
                _khachhang.Update(_KH);
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
            if (gridViewDS.RowCount > 0)
            {
                _IDkhachhang = int.Parse (gridViewDS.GetFocusedRowCellValue("IDKHACH").ToString());
                txtID.Text = gridViewDS.GetFocusedRowCellValue("IDKHACH").ToString();
                txtName.Text = gridViewDS.GetFocusedRowCellValue("NAMEKHACH").ToString();
                txtPhone.Text = gridViewDS.GetFocusedRowCellValue("DIENTHOAI").ToString();
                txtEmail.Text = gridViewDS.GetFocusedRowCellValue("EMAIl").ToString();
                txtCCCD.Text = gridViewDS.GetFocusedRowCellValue("CCCD").ToString();
                txtAddress.Text = gridViewDS.GetFocusedRowCellValue("DIACHI").ToString();
                checkBoxD.Checked = bool.Parse(gridViewDS.GetFocusedRowCellValue("DISABLED").ToString());
                cbbSex.Text = gridViewDS.GetFocusedRowCellValue("GIOITINH").ToString();
            }
        }
        //======================================================================================================================================
        //Sự Kiện Double Click Truyền Vào Data Vào FormDatPhong
        private void gridViewDS_DoubleClick(object sender, EventArgs e)
        {
            if(gridViewDS.GetFocusedRowCellValue("IDKHACH") != null)
            {
                if (_khachdatphong  == "datphongdon")
                {
                    objectDPD.LoadKH();
                    objectDPD.SetKhach(int.Parse(gridViewDS.GetFocusedRowCellValue("IDKHACH").ToString()));
                }
                else
                {
                    objectDP.LoadDataKhachHang();    //Load Lại để hiển thị trên cbbKhach
                    objectDP.SetKhachHang(int.Parse(gridViewDS.GetFocusedRowCellValue("IDKHACH").ToString()));
                    //Set khách mới vào method(public) SetKhachHang bên formDatPhong
                    //public void SetKhachHang(int IDKH)
                    //{
                    //    var _KH = _khachhang.GetItem(IDKH);
                    //    cbbKhach.SelectedValue = _KH.IDKHACH;
                    //    cbbKhach.Text = _KH.NAMEKHACH;
                    //}
                }
                this.Close();

            }    
        }

    }
}