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
using DataLayer;
using BusinessLayer;
namespace ManagerRoom
{
    public partial class FormPhong : DevExpress.XtraEditors.XtraForm
    {
        public FormPhong()
        {
            InitializeComponent();
        }

        Phong _phong;
        TangLau _tanglau;
        LoaiPhong _loaiphong;
        bool _Them;
        int _IDPhong;
        private void FormPhong_Load(object sender, EventArgs e)
        {
            _phong = new Phong();
            _tanglau = new TangLau();
            _loaiphong = new LoaiPhong();

            LoadDataPhong();
            LoadDataLoaiPhong();
            LoadDataTang();

            ShowHideControl(true);
            Enable(false);
        }
        //===========================================================================================================================

        void LoadDataLoaiPhong()
        {
            cbbLoaiPhong.DataSource = _loaiphong.GetAll();
            cbbLoaiPhong.DisplayMember = "TENLOAIPHONG";
            cbbLoaiPhong.ValueMember = "IDLOAIPHONG";
        }
        //void LoadPhongByLoaiPhong()
        //{
        //    gridControlDS.DataSource = _phong.GetByLoaiPhong(int.Parse(cbbLoaiPhong.SelectedValue.ToString()));  //lấy những loại phòng thuộc phòng - tham số
        //    gridViewDS.OptionsBehavior.Editable = false;
        //}
        //===========================================================================================================================

        void LoadDataTang()
        {
            cbbTang.DataSource = _tanglau.GetAll();
            cbbTang.DisplayMember = "TENLAU";
            cbbTang.ValueMember = "IDLAU";
        }
        //void LoadPhongByTang()
        //{
        //    gridControlDS.DataSource = _phong.GetByTang(int.Parse(cbbTang.SelectedValue.ToString())); //lấy những đơn vị thuộc công ty như tham số
        //    gridViewDS.OptionsBehavior.Editable = false;
        //}
        //===========================================================================================================================
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
            cbbLoaiPhong.Enabled = t;
            cbbTang.Enabled = t;
            checkBoxStatus.Enabled = t;
            checkBoxD.Enabled = t;
            //không đưa combobox vì nó để dành xem,không thể ẩn
        }
        void Reset() // Reset các textbox để thêm mới DONVI mới
        {
            txtID.Text = "";
            txtName.Text = "";
            cbbLoaiPhong.Enabled = true;
            cbbTang.Enabled = true;
            checkBoxStatus.Enabled = true;
            checkBoxD.Enabled = true;
        }
        void LoadDataPhong()
        {
            gridControlDS.DataSource = _phong.GetAll();
            gridViewDS.OptionsBehavior.Editable = false;
        }
        //=============================================================================================================================
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
            if (MessageBox.Show("Are you sure to delete this item?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                if (_phong.GetItem(_IDPhong).DISABLED == true)
                {
                    _phong.Delete(_IDPhong);
                }
                else
                {
                    MessageBox.Show("DISABLED is unmarked", "Notification", MessageBoxButtons.OKCancel);
                }
            }
            LoadDataPhong();
        }

        private void tsBtnSave_Click(object sender, EventArgs e)
        {
            if (_Them == true)
            {
                tb_PHONG _P = new tb_PHONG();
                _P.IDPHONG  = int.Parse(txtID.Text);
                _P.TENPHONG = txtName.Text;
                _P.IDLOAIPHONG= int.Parse(cbbLoaiPhong.SelectedValue.ToString());
                _P.TENLAU = cbbTang.Text;
                _P.TENLOAIPHONG = cbbLoaiPhong.Text;
                _P.IDLAU = int.Parse(cbbTang.SelectedValue.ToString());
                _P.TRANGTHAI = checkBoxStatus.Checked;
                _P.DISABLED = checkBoxD.Checked;
                _phong.Add(_P);
            }
            else
            {
                tb_PHONG _P = _phong.GetItem(_IDPhong); // đưa tham số ID để so sánh với các mã ID trong db, và update cho đúng objectID
                //MACTY không được sửa
                _P.TENPHONG = txtName.Text;
                _P.IDLOAIPHONG = int.Parse(cbbLoaiPhong.SelectedValue.ToString());
                _P.IDLAU = int.Parse(cbbTang.SelectedValue.ToString());
                _P.TENLAU = cbbTang.Text;
                _P.TENLOAIPHONG = cbbLoaiPhong.Text;
                _P.TRANGTHAI = checkBoxStatus.Checked;
                _P.DISABLED = checkBoxD.Checked;
                _phong.Update(_P);
            }
            _Them = false; // phải false để đảm bảo lần sau quay về y như cũ
            LoadDataPhong();
            Enable(false);
            //void Enable(bool t) 
            //txtName.Enabled = t;
            //txtPhone.Enabled = t;
            //txtFax.Enabled = t;
            //txtEmail.Enabled = t;
            //txtAddress.Enabled = t;
            //checkBoxD.Enabled = t;           các textbox sẽ ẩn đi
            txtID.Enabled = false;
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
        private void gridViewDS_Click(object sender, EventArgs e)
        {
            if (gridViewDS.RowCount > 0)
            {
                _IDPhong = int.Parse(gridViewDS.GetFocusedRowCellValue("IDPHONG").ToString());
                txtID.Text = gridViewDS.GetFocusedRowCellValue("IDPHONG").ToString();
                txtName.Text = gridViewDS.GetFocusedRowCellValue("TENPHONG").ToString();
                cbbTang.Text = gridViewDS.GetFocusedRowCellValue("TENLAU").ToString();
                cbbLoaiPhong.Text = gridViewDS.GetFocusedRowCellValue("TENLOAIPHONG").ToString();
                //cbbLoaiPhong.SelectedValue = int.Parse(gridViewDS.GetFocusedRowCellValue("IDLOAIPHONG").ToString());
                //cbbTang.SelectedValue = int.Parse (gridViewDS.GetFocusedRowCellValue("IDLAU").ToString());
                checkBoxStatus.Checked = bool.Parse(gridViewDS.GetFocusedRowCellValue("TRANGTHAI").ToString());
                checkBoxD.Checked = bool.Parse(gridViewDS.GetFocusedRowCellValue("DISABLED").ToString());
            }
        }

        private void tsBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}