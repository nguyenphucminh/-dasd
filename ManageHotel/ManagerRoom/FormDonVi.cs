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
namespace ManagerRoom
{
    public partial class FormDonVi : DevExpress.XtraEditors.XtraForm
    {
        public FormDonVi()
        {
            InitializeComponent();
        }
        DonVi _donvi;
        CongTy _congty;
        bool _Them;
        string _IDdonvi;
        private void FormDonVi_Load(object sender, EventArgs e)
        {
            _donvi = new DonVi();
            _congty = new CongTy();
            LoadDataCTY();

            ShowHideControl(true);
            Enable(false);
            txtIDDV.Enabled = false;

            cbbCT.SelectedIndexChanged += CbbCT_SelectedIndexChanged;
            LoadDVIByCTY();
        }

        private void CbbCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDVIByCTY();
        }

        void LoadDataCTY()
        {
            cbbCT.DataSource = _congty.GetAll();
            cbbCT.DisplayMember = "TENCTY";
            cbbCT.ValueMember = "MACTY";
        }
        void LoadDataDVI()
        {
            gridControlDS.DataSource = _donvi.GetAll();
            gridViewDS.OptionsBehavior.Editable = false;
        }
        void LoadDVIByCTY()
        {
            gridControlDS.DataSource = _donvi.GetAll(cbbCT.SelectedValue.ToString()); //lấy những đơn vị thuộc công ty như tham số
            gridViewDS.OptionsBehavior.Editable = false;
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
            txtPhone.Enabled = t;
            txtFax.Enabled = t;
            txtEmail.Enabled = t;
            txtAddress.Enabled = t;
            checkBoxD.Enabled = t;
            //không đưa combobox vì nó để dành xem,không thể ẩn
        }
        void Reset() // Reset các textbox để thêm mới DONVI mới
        {
            txtIDDV.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtFax.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            checkBoxD.Enabled = false;
        }
        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            _Them = true;
            txtIDDV.Enabled = true; //cho phép thêm mã ID khi ấn BtnAdd

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
            txtIDDV.Enabled = false; //không cho sửa mã ID khi ấn BtnFix

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
                
                if (_donvi.GetItem(_IDdonvi).DISABLED == true)
                {
                    _donvi.Delete(_IDdonvi);
                }
                else
                {
                    MessageBox.Show("DISABLED is unmarked", "Notification", MessageBoxButtons.OKCancel);
                }
            }
            LoadDataDVI();
        }
        private void tsBtnSave_Click(object sender, EventArgs e)
        {
            if (_Them == true)
            {
                tb_DONVI  _DV = new tb_DONVI();
                _DV.MADVI = txtIDDV.Text;
                _DV.MACTY = cbbCT.SelectedValue.ToString();
                _DV.TENDVI = txtName.Text;
                _DV.DIENTHOAI = txtPhone.Text;
                _DV.EMAIL = txtEmail.Text;
                _DV.FAX = txtFax.Text;
                _DV.DIACHI = txtAddress.Text;
                _DV.DISABLED = checkBoxD.Checked;
                _donvi.Add(_DV);
            }
            else
            {
                tb_DONVI _DV = _donvi.GetItem(_IDdonvi); // đưa tham số ID để so sánh với các mã ID trong db, và update cho đúng objectID
                //MACTY không được sửa
                _DV.MACTY = cbbCT.SelectedValue.ToString();
                _DV.TENDVI = txtName.Text;
                _DV.DIENTHOAI = txtPhone.Text;
                _DV.EMAIL = txtEmail.Text;
                _DV.FAX = txtFax.Text;
                _DV.DIACHI = txtAddress.Text;
                _DV.DISABLED = checkBoxD.Checked;
                _donvi.Update(_DV);
            }
            _Them = false; // phải false để đảm bảo lần sau quay về y như cũ
            LoadDataDVI();
            Enable(false);
            //void Enable(bool t) 
            //txtName.Enabled = t;
            //txtPhone.Enabled = t;
            //txtFax.Enabled = t;
            //txtEmail.Enabled = t;
            //txtAddress.Enabled = t;
            //checkBoxD.Enabled = t;           các textbox sẽ ẩn đi
            txtIDDV.Enabled = false;
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
            txtIDDV.Enabled = false;
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
                _IDdonvi  = gridViewDS.GetFocusedRowCellValue("MADVI").ToString();
                cbbCT.SelectedValue  = gridViewDS.GetFocusedRowCellValue("MACTY").ToString();
                txtIDDV.Text = gridViewDS.GetFocusedRowCellValue("MADVI").ToString();
                txtName.Text = gridViewDS.GetFocusedRowCellValue("TENDVI").ToString();
                txtPhone.Text = gridViewDS.GetFocusedRowCellValue("DIENTHOAI").ToString();
                txtEmail.Text = gridViewDS.GetFocusedRowCellValue("EMAIL").ToString();
                txtFax.Text = gridViewDS.GetFocusedRowCellValue("FAX").ToString();
                txtAddress.Text = gridViewDS.GetFocusedRowCellValue("DIACHI").ToString();
                checkBoxD.Checked = bool.Parse(gridViewDS.GetFocusedRowCellValue("DISABLED").ToString());
            }
        }
    }
}