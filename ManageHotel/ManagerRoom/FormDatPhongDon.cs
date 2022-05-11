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
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace ManagerRoom
{
    public partial class FormDatPhongDon : DevExpress.XtraEditors.XtraForm
    {
        public FormDatPhongDon()
        {
            InitializeComponent();
        }
        FormMain ObjectMain = (FormMain)Application.OpenForms["FormMain"];
        public bool _Them;
        public int _IDphong; // lấy IDPhong từ formMain qua nên phải public
        int _IDDP=0;
        double _tongtien = 0;
        Phong _phong;
        DatPhong _datphong;
        DatPhongChiTiet _datphongchitiet;
        DatPhongSanPham _datphongsanpham;
        SanPham _sanpham;

        List<OBJ_DSSP> listDPSP;
        OBJ_PHONG _phonght;
        
        private void FormDatPhongDon_Load(object sender, EventArgs e)
        {
            _datphong = new DatPhong();
            _datphongchitiet = new DatPhongChiTiet();
            _datphongsanpham = new DatPhongSanPham();
            _phong = new Phong();
            _sanpham = new SanPham();
            listDPSP = new List<OBJ_DSSP>();

            _phonght = _phong.GetAll(_IDphong);
            lbKhachLe.Text = _phonght.TENPHONG + " - Đơn Giá: " + ((double)_phonght.DONGIA).ToString("N0") + " VND";

            dtNgayDat.Value = DateTime.Now;
            dtNgayTra.Value = DateTime.Now.AddDays(1);

            cbbStatus.DataSource = TrangThaiCBB.getList();
            cbbStatus.DisplayMember = "_display";
            cbbStatus.ValueMember = "_value";

            spinPeople.Text = "1";
            //var _param = _param.getParam();
            //_macty = _param.MACTY;
            //_madvi = _param.MADVI;
            LoadKH();
            LoadSP();
                
            var dpct = _datphongchitiet.getIDDPByPhong(_IDphong);
            if (!_Them && dpct != null)
            {
                _IDDP = (int)dpct.IDDP;
                var dp = _datphong.GetItem(_IDDP);
                searchKH.EditValue = dp.IDKHACH;
                if(dp.NGAYDAT.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
                {
                    dtNgayTra.Value = dp.NGAYDAT.Value.AddDays(1);
                }    
                else
                {
                    dtNgayTra.Value = DateTime.Now;
                }
                dtNgayDat.Value = dp.NGAYDAT.Value;
                cbbStatus.SelectedValue = dp.TRANGTHAI;
                spinPeople.Text = dp.SONGUOI.ToString();
                txtNote.Text = dp.GHICHU.ToString();
                txtThanhTien.Text = dp.SOTIEN.Value.ToString("N0");
            }
            loadSPDV();
        }
        //=======================================================================================================================================================================
        public void LoadKH()
        {
            KhachHang _khachhang = new KhachHang();
            searchKH.Properties.DataSource = _khachhang.GetAll();
            searchKH.Properties.DisplayMember = "NAMEKHACH";
            searchKH.Properties.ValueMember = "IDKHACH";
        }
        public void LoadSP()
        {
            gcSPDV.DataSource = _sanpham.GetAll();
            gvSPDV.OptionsBehavior.Editable = false;
        }
        public void SetKhach(int _IDkhach)
        {
            searchKH.EditValue = _IDkhach;
        }
        public void GetKhach(int _IDkhach)
        {
            KhachHang _khachhang = new KhachHang();
            var khach = _khachhang.GetItem(_IDkhach);
            searchKH.EditValue = khach.IDKHACH;
            searchKH.Text = khach.NAMEKHACH;
        }
          void LoadDPSP()
        {
            List<OBJ_DSSP> listDP = new List<OBJ_DSSP>();
            foreach (var item in listDPSP)
            {
                listDP.Add(item);
            }
            gcDatSPDV.DataSource = listDP; // this method sẽ làm nhiệm vụ add listDPSP ở trên và đưa vào datasource của gcDatSPDV
        }
        void loadSPDV()
        {
            gcDatSPDV.DataSource = _datphongsanpham.GetAllByDatPhong(_IDDP);
            listDPSP = _datphongsanpham.GetAllByDatPhong(_IDDP);
        }


        void SaveData()
        {
            if (_Them)
            {
                tb_DATPHONG _DP = new tb_DATPHONG();
                tb_DATPHONGCHITIET _DPCT;
                tb_DATPHONGSP _DPSP;

                _DP.NGAYDAT = dtNgayDat.Value;
                _DP.NGAYTRA = dtNgayTra.Value;
                _DP.SONGUOI = int.Parse(spinPeople.EditValue.ToString());
                _DP.TRANGTHAI = bool.Parse(cbbStatus.SelectedValue.ToString());
                _DP.DOAN = false;
                _DP.IDKHACH = int.Parse(searchKH.EditValue.ToString());
                _DP.SOTIEN = double.Parse(txtThanhTien.Text);
                _DP.GHICHU = txtNote.Text;
                _DP.IDUSER = 1;
                _DP.MACTY = /*_param.GetParam().MACTY*/ " ";
                _DP.MADVI = /*_param.GetParam().MADVI*/ " ";
                _DP.CREATED_DATE = DateTime.Now;
                _DP.DISABLED = false;

                //var _pr = _param.GetParam();
                //_macty = _pr.MACTY;
                //_madvi = _pr.MADVI;

                var _dp = _datphong.Add(_DP);  //khi thêm vào, method sẽ trả về ID cho những _DP vừa thêm (change void -> tb_DatPhong and return AddDP, UpdateDP)
                _IDDP = _dp.IDDP;


                 _DPCT = new tb_DATPHONGCHITIET();
                 _DPCT.IDDP = _dp.IDDP;
                 _DPCT.IDPHONG = _IDphong;
                 _DPCT.SONGAYO = dtNgayTra.Value.Day - dtNgayDat.Value.Day + 1;
                 _DPCT.DONGIA =  int.Parse(_phonght.DONGIA.ToString());
                 _DPCT.THANHTIEN = _DPCT.SONGAYO * _DPCT.DONGIA;
                 _DPCT.NGAY = DateTime.Now;

                 var _dpct = _datphongchitiet.Add(_DPCT);
                 _phong.UpdateStatus(int.Parse(_DPCT.IDPHONG.ToString()), true); //cập nhật cái IDphong đó đã tồn tại người ở

                 if (gvDatSPDV.RowCount > 0)
                 {
                     for (int j = 0; j < gvDatSPDV.RowCount; j++)
                     {
                         if (_DPCT.IDPHONG == int.Parse(gvDatSPDV.GetRowCellValue(j, "IDPHONG").ToString()))
                         {
                             _DPSP = new tb_DATPHONGSP();
                             _DPSP.IDDP = _dp.IDDP;
                             _DPSP.IDDPCT = _dpct.IDDPCT;
                             _DPSP.IDPHONG = int.Parse(gvDatSPDV.GetRowCellValue(j, "IDPHONG").ToString());
                             _DPSP.IDSP = int.Parse(gvDatSPDV.GetRowCellValue(j, "IDSP").ToString());
                             _DPSP.SOLUONG = int.Parse(gvDatSPDV.GetRowCellValue(j, "SOLUONG").ToString());
                             _DPSP.DONGIA = int.Parse(gvDatSPDV.GetRowCellValue(j, "DONGIA").ToString());
                             _DPSP.NGAY = DateTime.Now;
                             _DPSP.THANHTIEN = _DPSP.SOLUONG * _DPSP.DONGIA;

                             _datphongsanpham.Add(_DPSP);
                         }
                     }
                 }
                
            }
            else
            {
                //update
                tb_DATPHONG _DP = _datphong.GetItem(_IDDP);
                tb_DATPHONGCHITIET _DPCT;
                tb_DATPHONGSP _DPSP;
                _DP.NGAYDAT = dtNgayDat.Value;
                _DP.NGAYTRA = dtNgayTra.Value;
                _DP.SONGUOI = int.Parse(spinPeople.EditValue.ToString());
                _DP.TRANGTHAI = bool.Parse(cbbStatus.SelectedValue.ToString());
                _DP.IDKHACH = int.Parse(searchKH.EditValue.ToString());
                _DP.SOTIEN = double.Parse(txtThanhTien.Text);
                _DP.GHICHU = txtNote.Text;
                _DP.IDUSER = 1; //phân quyền người dùng
                _DP.UPDATE_BY = 1; //Update bởi user nào
                _DP.UPDATE_DATE = DateTime.Now;
                var _dp = _datphong.Update(_DP);
                _IDDP = _dp.IDDP;
                _datphongchitiet.DeleteAll(_DP.IDDP);
                _datphongsanpham.DeleteAll(_DP.IDDP);

                _DPCT = new tb_DATPHONGCHITIET();
                _DPCT.IDDP = _dp.IDDP;
                _DPCT.IDPHONG = _IDphong;
                _DPCT.SONGAYO = dtNgayTra.Value.Day - dtNgayDat.Value.Day;
                _DPCT.DONGIA = int.Parse(_phonght.DONGIA.ToString());
                _DPCT.THANHTIEN = _DPCT.SONGAYO * _DPCT.DONGIA;
                _DPCT.NGAY = DateTime.Now;

                var _dpct = _datphongchitiet.Add(_DPCT);
                _phong.UpdateStatus(int.Parse(_DPCT.IDPHONG.ToString()), true);

                if (gvDatSPDV.RowCount > 0)
                {
                    for (int j = 0; j < gvDatSPDV.RowCount; j++)
                    {
                        if (_DPCT.IDPHONG == int.Parse(gvDatSPDV.GetRowCellValue(j, "IDPHONG").ToString()))
                        {
                            _DPSP = new tb_DATPHONGSP();
                            _DPSP.IDDP = _dp.IDDP;
                            _DPSP.IDDPCT = _dpct.IDDPCT;
                            _DPSP.IDPHONG = int.Parse(gvDatSPDV.GetRowCellValue(j, "IDPHONG").ToString());
                            _DPSP.IDSP = int.Parse(gvDatSPDV.GetRowCellValue(j, "IDSP").ToString());
                            _DPSP.SOLUONG = int.Parse(gvDatSPDV.GetRowCellValue(j, "SOLUONG").ToString());
                            _DPSP.DONGIA = int.Parse(gvDatSPDV.GetRowCellValue(j, "DONGIA").ToString());
                            _DPSP.NGAY = DateTime.Now;
                            _DPSP.THANHTIEN = _DPSP.SOLUONG * _DPSP.DONGIA;

                            _datphongsanpham.Add(_DPSP);
                        }
                    }
                }
               
            }
        }
        //=======================================================================================================================================================================
        private void tsBtnSave_Click(object sender, EventArgs e)
        {
            if(searchKH.EditValue == null || searchKH .EditValue.ToString() == "")
            {
                MessageBox.Show("Vui Lòng Chọn Khách Hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Lưu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            //_phonght = _phong.GetAll(_IDphong);
            //_tongtien = double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + (double)(_phong.GetItemFull(_IDphong).DONGIA) * (dtNgayTra.Value.Day - dtNgayDat.Value.Day);
            //var dp = _datphong.GetItem(_IDDP);
            //dp.SOTIEN = _tongtien;
            //_datphong.Update(dp);
            SaveData();
            ObjectMain.gControl.Gallery.Groups.Clear();
            ObjectMain.ShowRoom();
        }

        private void tsBTNPrint_Click(object sender, EventArgs e)
        {
                
                //_tongtien = double.Parse(gvSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + (double)(_phong.GetItemFull(_IDphong).DONGIA) * (dtNgayTra.Value.Day - dtNgayDat.Value.Day);
                //var dp = _datphong.GetItem(_IDDP);
                //dp.SOTIEN = _tongtien;
                //_datphong.Update(dp);
                _datphong.UpdateStatus(_IDDP);
                _phong.UpdateStatus(_IDphong, false);
                XuatReport("PHIEU_DATPHONGDON", "chi tiết đặt phong");
                cbbStatus.SelectedValue = true;
                SaveData();
                ObjectMain.gControl.Gallery.Groups.Clear();
                ObjectMain.ShowRoom();

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

            if (_IDDP != 0)
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
                    doc.SetParameterValue("@IDDP", _IDDP.ToString());
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

        private void tsBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FormKhachHang frmKhach = new FormKhachHang();
            frmKhach._khachdatphong = "datphongdon";
            frmKhach.ShowDialog();
        }

        private void gvSPDV_DoubleClick(object sender, EventArgs e)
        {
            if (bool.Parse(cbbStatus.SelectedValue.ToString()) == true)
            {
                MessageBox.Show("phiếu đã hoàn tất không được chỉnh sửa.", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_IDphong == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (gvSPDV.GetFocusedRowCellValue("IDSP") != null)
            {
                OBJ_DSSP SP = new OBJ_DSSP();
                SP.IDSP = int.Parse(gvSPDV.GetFocusedRowCellValue("IDSP").ToString());
                SP.TENSP = gvSPDV.GetFocusedRowCellValue("TENSP").ToString();
                SP.IDPHONG = _IDphong;
                SP.TENPHONG = _phonght.TENPHONG;
                SP.DONGIA = float.Parse(gvSPDV.GetFocusedRowCellValue("DONGIA").ToString());
                SP.SOLUONG = 1;
                SP.THANHTIEN = SP.DONGIA * SP.SOLUONG;
                foreach (var item in listDPSP) //doubleclick lần thứ hai sẽ add thẳng vào listDPSP
                {
                    if (item.IDSP == SP.IDSP && item.IDPHONG == SP.IDPHONG)
                    {
                        item.SOLUONG = item.SOLUONG + 1; // nếu chọn cùng 1 sản phẩm nó sẽ tăng SOLUONG(vì cùng IDSP và IDPHONG)
                        item.THANHTIEN = item.SOLUONG * item.DONGIA; //nếu khác IDSP và IDPHONG nó sẽ thêm mới
                        LoadDPSP();
                        txtThanhTien.Text = (double.Parse(gvDatSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + double.Parse(_phonght.DONGIA.ToString()) * (dtNgayTra.Value.Day - dtNgayDat.Value.Day)).ToString("N0");
                        return;
                    }

                }
                listDPSP.Add(SP); //doubleclick lần thứ nhất sẽ add thẳng vào, chưa tồn tại listDPSP
            }
            LoadDPSP();
            txtThanhTien.Text = (double.Parse(gvDatSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + double.Parse(_phonght.DONGIA.ToString()) * (dtNgayTra.Value.Day - dtNgayDat.Value.Day + 1)).ToString("N0");
        }

        private void gvDatSPDV_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            if (e.Column.FieldName == "SOLUONG")
            {
                int soluong = int.Parse(e.Value.ToString());
                if (soluong != 0)
                {
                    double dongia = double.Parse(gvDatSPDV.GetRowCellValue(gvDatSPDV.FocusedRowHandle, "DONGIA").ToString());
                    gvDatSPDV.SetRowCellValue(gvDatSPDV.FocusedRowHandle, "THANHTIEN", soluong * dongia);
                }
                else
                {
                    gvDatSPDV.SetRowCellValue(gvDatSPDV.FocusedRowHandle, "THANHTIEN", 0);
                }
            }
            gvDatSPDV.UpdateTotalSummary();
            txtThanhTien.Text = (double.Parse(gvDatSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + double.Parse(_phonght.DONGIA.ToString()) * (dtNgayTra.Value.Day - dtNgayDat.Value.Day + 1)).ToString("N0");
        }

        private void gvDatSPDV_HiddenEditor(object sender, EventArgs e)
        {
            gvDatSPDV.UpdateCurrentRow();
        }

        private void dtNgayTra_ValueChanged(object sender, EventArgs e)
        {
            _phonght = _phong.GetAll(_IDphong);
            double tmp = 0;
            if (gvDatSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue == null)
            {
                tmp = 0;
            }
            else
            {
                tmp = double.Parse(gvDatSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString());
            }
            txtThanhTien.Text = (tmp + double.Parse(_phonght.DONGIA.ToString()) * (dtNgayTra.Value.Day - dtNgayDat.Value.Day + 1)).ToString("N0");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show($"Are You Sure Want To Delete ?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                gvDatSPDV.DeleteSelectedRows();
                listDPSP.Clear();
                txtThanhTien.Text = (double.Parse(gvDatSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + double.Parse(_phonght.DONGIA.ToString()) * (dtNgayTra.Value.Day - dtNgayDat.Value.Day + 1)).ToString("N0");
            }
        }
    }
}