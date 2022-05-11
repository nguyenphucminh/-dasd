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
    public partial class FormChuyenPhong : DevExpress.XtraEditors.XtraForm
    {
        public FormChuyenPhong()
        {
            InitializeComponent();
        }
        FormMain ObjectMain = (FormMain)Application.OpenForms["FormMain"];
        public int IDPhong;
        Phong _phong;
        DatPhongChiTiet _datphongchitiet;
        DatPhongSanPham _datphongsanpham;
        DatPhong _datphong;
        void LoadPhongTrong()
        {
            searchPhong.Properties.DataSource = _phong.GetPhongTrongFull();
            searchPhong.Properties.ValueMember = "IDPHONG";
            searchPhong.Properties.DisplayMember = "TENPHONG";
        }

        private void FormChuyenPhong_Load(object sender, EventArgs e)
        {
            _phong = new Phong();
            _datphongchitiet = new DatPhongChiTiet();
            _datphongsanpham = new DatPhongSanPham();
            _datphong = new DatPhong();
            var p = _phong.GetAll(IDPhong);
            lbPhong.Text = p.TENPHONG + " - Đơn Giá: " + ((double)p.DONGIA).ToString("N0") + " VND";
            LoadPhongTrong();
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            if (searchPhong.EditValue == null || searchPhong.EditValue.ToString() == "")
            {
                MessageBox.Show(" Vui lòng chọn phòng chọn phòng muốn chuyển đến", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                int tongtien1 = 0;
                int tongtien2 = 0;
                var phonghientai = _datphongchitiet.getIDDPByPhong(IDPhong);
                var phongchuyenden = _phong.GetItemFull(int.Parse(searchPhong.EditValue.ToString()));

                List<tb_DATPHONGSP> listDPSP = _datphongsanpham.GetAllByPhong((int)phonghientai.IDDP, phonghientai.IDDPCT);
                foreach (var item in listDPSP)
                {
                    item.IDPHONG = int.Parse(searchPhong.EditValue.ToString());
                    tongtien1 = tongtien1 + int.Parse(item.DONGIA.ToString()) * int.Parse(item.SOLUONG.ToString());
                    _datphongsanpham.Update(item);
                }
                var dpct = _datphongchitiet.GetItem((int)phonghientai.IDDP, IDPhong);
                dpct.IDPHONG = phongchuyenden.IDPHONG;
                dpct.DONGIA = int.Parse(phongchuyenden.DONGIA.ToString());
                dpct.THANHTIEN = dpct.SONGAYO * int.Parse(phongchuyenden.DONGIA.ToString());
                tongtien2 = int.Parse(dpct.THANHTIEN.ToString());
                _datphongchitiet.Update(dpct);

                _phong.UpdateStatus(IDPhong, false);
                _phong.UpdateStatus(phongchuyenden.IDPHONG, true);

                var dp = _datphong.GetItem((int)phonghientai.IDDP);
                dp.SOTIEN = tongtien1 + tongtien2;
                _datphong.Update(dp);

                ObjectMain.gControl.Gallery.Groups.Clear();
                ObjectMain.ShowRoom();
                MessageBox.Show("Chuyển Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}