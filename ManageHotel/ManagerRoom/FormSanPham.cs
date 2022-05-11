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
    public partial class FormSanPham : DevExpress.XtraEditors.XtraForm
    {
        public FormSanPham()
        {
            InitializeComponent();
        }
        SanPham _sanpham;
        bool _Them;
        int _IDsanpham;
        private void FormSanPham_Load(object sender, EventArgs e)
        {
            _sanpham = new SanPham();
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
            spinMoney.Enabled = t;
            checkBoxD.Enabled = t;
        }
        void Reset() // Reset các textbox để thêm mới KHACHHANG mới
        {
            txtID.Text = "";
            txtName.Text = "";
            spinMoney.Enabled = true;
            checkBoxD.Enabled = true;
        }
        void LoadData() // Load lại db và trả về db của KHACHHANG
        {
            gridControlDS.DataSource = _sanpham.GetAll();
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
                if (_sanpham.GetItem(_IDsanpham).DISABLED == true)
                {
                    _sanpham.Delete(_IDsanpham);
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
                tb_SANPHAM _SP = new tb_SANPHAM();
                _SP.IDSP = int.Parse(txtID.Text);
                _SP.TENSP = txtName.Text;
                _SP.DONGIA = float.Parse(spinMoney.Text);
                _SP.DISABLED = checkBoxD.Checked;
               _sanpham.Add(_SP);
            }
            else
            {
                tb_SANPHAM _SP = _sanpham.GetItem(_IDsanpham); // đưa tham số ID để so sánh với các mã ID trong db, và update cho đúng objectID
                //MACTY không được sửa
                _SP.TENSP = txtName.Text;
                _SP.DONGIA = float.Parse(spinMoney.Text);
                _SP.DISABLED = checkBoxD.Checked;
                _sanpham.Update(_SP);
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

        private void gridViewDS_Click(object sender, EventArgs e)
        {
            if (gridViewDS.RowCount > 0)
            {
                _IDsanpham = int.Parse(gridViewDS.GetFocusedRowCellValue("IDSP").ToString());
                txtID.Text = gridViewDS.GetFocusedRowCellValue("IDSP").ToString();
                txtName.Text = gridViewDS.GetFocusedRowCellValue("TENSP").ToString();
                spinMoney.Text = gridViewDS.GetFocusedRowCellValue("DONGIA").ToString();
                checkBoxD.Checked = bool.Parse(gridViewDS.GetFocusedRowCellValue("DISABLED").ToString());
            }
        }

        private void tsBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}