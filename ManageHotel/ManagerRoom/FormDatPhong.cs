using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace ManagerRoom
{
    public partial class FormDatPhong : DevExpress.XtraEditors.XtraForm
    {
        public FormDatPhong(string userName)
        {
            InitializeComponent();
            //Tạo DataTable lấy danh sách các phòng trống. 
            //Sau đó gán các DataSource vào gcPhongEmpty.
            //Muốn kéo thả giữa 2 bảng thì 2 bảng phải có cùng cấu trúc nên gcDatPhong phải có table.clone
            DataTable table = MyFunction.GetData("SELECT A.IDPHONG, A.TENPHONG, A.IDLAU, B.TENLAU, C.DONGIA FROM tb_PHONG A, tb_TANGLAU B, tb_LOAIPHONG C WHERE A.IDLAU = B.IDLAU AND A.TRANGTHAI=0 AND A.IDLOAIPHONG = C.IDLOAIPHONG");
            gcPhongEmpty.DataSource = table;
            gcDatPhong.DataSource = table.Clone();
            ////sẽ copy cấu trúc của Datable nhưng không có dữ liệu
            this.User = userName;
        }
        FormMain ObjectMain = (FormMain)Application.OpenForms["FormMain"];
        bool _Them;
        int _IDphong=0;
        int _IDdatphong = 0;
        string _tenphong;
        int _rowcountDP=0;
        string User;
        //string _macty;
        //string _madvi;
        List<OBJ_DSSP> listDPSP;
        WriteLog wlog = new WriteLog();

        //Param _param;
        Phong _phong;
        DatPhong _datphong;
        DatPhongChiTiet _datphongchitiet;
        DatPhongSanPham _datphongsanpham;
        KhachHang _khachhang;
        SanPham _sanpham;
        GridHitInfo downhitinfo = null; //lưu các dòng khi mình nhấn chuột
        private void FormDatPhong_Load(object sender, EventArgs e)
        {
            //Define Param
            _phong = new Phong();
            _datphong = new DatPhong();
            _datphongchitiet = new DatPhongChiTiet();
            _datphongsanpham = new DatPhongSanPham();
            _khachhang = new KhachHang();
            _sanpham = new SanPham();
            //_param = new Param();
            listDPSP = new List<OBJ_DSSP>();


            //// Bất kì giá trị ngày tháng nào của bạn
            DateTime myDate = DateTime.Today;
            //// Lấy ra ngày đầu tiên của tháng hiện tại. Đó luôn là ngày 1
            DateTime firstDayOfMonth = new DateTime(myDate.Year, myDate.Month, 1);
            //// Lấy ra ngày đầu tiên của tháng tiếp theo bằng cách sử dụng hàm AddMonth
            DateTime firstDayOfNextMonth = firstDayOfMonth.AddMonths(1);
            //// Ngày cuối cùng của tháng là ngày trước đó
            DateTime lastDayOfMonth = firstDayOfNextMonth.AddDays(-1);

            //GetFirstDayMonth Show List To Today
            dtTuNgay.Value = MyFunction.GetFirstDayInMonth(DateTime.Now.Year, DateTime.Now.Month);
            dtDenNgay.Value = lastDayOfMonth;
            txtThanhTien.ReadOnly = true;

            gvPhongEmpty.ExpandAllGroups(); // sổ tất cả các dòng ra hết
            wlog.Fucntion_WriteLog(User.ToString(), "Đặt Phòng", "Xem", "FormDatPhong");

            //LoadData
            LoadDataSanPham();
            LoadDataKhachHang();
            LoadData();

            //Load CBBTrangThai
            cbbStatus.DataSource = TrangThaiCBB.getList();
            cbbStatus.DisplayMember = "_display";
            cbbStatus.ValueMember = "_value"; 

            ShowHideControl(true);
            Enable(false);
            TabControl.SelectedTabPage = PageDanhSach;
        }
        //======================================================================================================================================
        public void LoadDataKhachHang()
        {
            _khachhang = new KhachHang();
            cbbKhach.DataSource = _khachhang.GetAll();
            cbbKhach.DisplayMember = "NAMEKHACH";
            cbbKhach.ValueMember = "IDKHACH";
        }
        void LoadDataSanPham()
        {
            gcSPDV.DataSource = _sanpham.GetAll();
            gvDatPhong.OptionsBehavior.Editable = false;
        }
        void ShowHideControl(bool t)
        {
            tsBtnAdd.Visible = t;
            tsBtnExit.Visible = t;
            tsBtnDelete.Visible = t;
            tsBtnFix.Visible = t;
            tsBTNPrint.Visible = t;

            tsBtnCancel.Visible = !t;
            tsBtnSave.Visible = !t;
        }
        void Enable(bool t)
        {
            cbbKhach.Enabled = t;
            btnAddNew.Enabled = t;
            dtNgayDat.Enabled = t;
            dtNgayTra.Enabled = t;
            cbbStatus.Enabled = t;
            spinPeople.Enabled = t;
            txtNote.Enabled = t;
            checkBoxG.Enabled = t;
            txtThanhTien.Enabled = t;
            gcPhongEmpty.Enabled = t;
            gcSPDV.Enabled = t;
            gcDatPhong.Enabled = t;
            gcDatSPDV.Enabled = t;
        }
        void Reset()
        {
            dtNgayDat.Value = DateTime.Now;
            dtNgayTra.Value = DateTime.Now.AddDays(1);
            spinPeople.Text = "1";
            checkBoxG.Checked = false;
            cbbStatus.SelectedValue = false;
            txtNote.Text = "";
            txtThanhTien.Text = "0";
        }
        void LoadData()
        {
            gridControlDS.DataSource = _datphong.GetAll(dtTuNgay.Value, dtDenNgay.Value.AddDays(1), " ", " ");
            gridViewDS.OptionsBehavior.Editable = false;
            _datphong = new DatPhong();
        }
        //======================================================================================================================================
        void AddReset()
        {
            DataTable table = MyFunction.GetData("SELECT A.IDPHONG, A.TENPHONG, A.IDLAU, B.TENLAU, C.DONGIA FROM tb_PHONG A, tb_TANGLAU B, tb_LOAIPHONG C WHERE A.IDLAU = B.IDLAU AND A.TRANGTHAI=0 AND A.IDLOAIPHONG = C.IDLOAIPHONG");
            gcPhongEmpty.DataSource = table;
            gcDatPhong.DataSource = table.Clone(); //nhân bảng
            gvPhongEmpty.ExpandAllGroups();
            gcDatSPDV.DataSource = _datphongsanpham.GetAllByDatPhong(0);
            txtThanhTien.Text = "0";
        }
        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            _Them = true;
            ShowHideControl(false);
            Enable(true);
            Reset();
            AddReset();
            TabControl.SelectedTabPage = PageChiTiet;
        }
       
        private void tsBtnFix_Click(object sender, EventArgs e)
        {
            if (_IDdatphong == 0)
            {

                MessageBox.Show("Vui long chọn Hóa Đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            else
            {
                _Them = false;
                ShowHideControl(false);
                Enable(true);
                _IDdatphong = int.Parse(gridViewDS.GetFocusedRowCellValue("IDDP").ToString());
                var dp = _datphong.GetItem(_IDdatphong); //Khi click để sửa sẽ hiện các thông tin của IDdatphong đó bên chi tiết
                cbbKhach.SelectedValue = dp.IDKHACH;
                dtNgayDat.Value = dp.NGAYDAT.Value;
                dtNgayTra.Value = dp.NGAYTRA.Value;
                spinPeople.Text = dp.SONGUOI.ToString();
                cbbStatus.SelectedValue = dp.TRANGTHAI;
                txtNote.Text = dp.GHICHU;
                checkBoxG.Checked = dp.DOAN.Value;
                txtThanhTien.Text = dp.SOTIEN.Value.ToString("N0");
                LoadgvDP();
                LoadgvDatSPDV();
                TabControl.SelectedTabPage = PageChiTiet;
            }

        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            if (_IDdatphong == 0)
            {

                MessageBox.Show("Vui long chọn Hóa Đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            else
            {
                if (MessageBox.Show("Are you sure to delete this item?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _datphong.Delete(_IDdatphong);
                    var listDPCT = _datphongchitiet.GetAllByDatPhong(_IDdatphong);
                    foreach (var item in listDPCT)
                    {
                        _phong.UpdateStatus(item.IDPHONG, false);
                    }
                }

                LoadData();
                ObjectMain.gControl.Gallery.Groups.Clear();
                ObjectMain.ShowRoom();
            }

        }

        private void tsBtnSave_Click(object sender, EventArgs e)
        {
            SaveData();
            ObjectMain.gControl.Gallery.Groups.Clear();
            ObjectMain.ShowRoom();
            _Them = false;
            Enable(false);
            ShowHideControl(true);
            LoadData();
            TabControl.SelectedTabPage = PageDanhSach;
        }
        void SaveData()
        {
            if (_Them)
            {
                tb_DATPHONG _DP = new tb_DATPHONG();
                tb_DATPHONGCHITIET _DPCT;
                tb_DATPHONGSP _DPSP;

                _DP.NGAYDAT      = dtNgayDat.Value;
                _DP.NGAYTRA      = dtNgayTra.Value;
                _DP.SONGUOI      = int.Parse(spinPeople.EditValue.ToString());
                _DP.TRANGTHAI    = bool.Parse(cbbStatus.SelectedValue.ToString());
                _DP.DOAN         = true;
                _DP.IDKHACH      = int.Parse(cbbKhach.SelectedValue.ToString());
                _DP.SOTIEN       = double.Parse(txtThanhTien.Text);
                _DP.GHICHU       = txtNote.Text;
                _DP.IDUSER       = 1;
                _DP.MACTY        = /*_param.GetParam().MACTY*/ " " ;
                _DP.MADVI        = /*_param.GetParam().MADVI*/ " ";
                _DP.CREATED_DATE = DateTime.Now;
                _DP.DISABLED     = false;

                //var _pr = _param.GetParam();
                //_macty = _pr.MACTY;
                //_madvi = _pr.MADVI;

                var _dp = _datphong.Add(_DP);  //khi thêm vào, method sẽ trả về ID cho những _DP vừa thêm (change void -> tb_DatPhong and return AddDP, UpdateDP)
                _IDdatphong = _dp.IDDP;
                for (int i = 0; i < gvDatPhong.RowCount ; i++)
                {

                    _DPCT = new tb_DATPHONGCHITIET();
                    _DPCT.IDDP = _dp.IDDP;
                    _DPCT.IDPHONG = int.Parse(gvDatPhong.GetRowCellValue(i,"IDPHONG").ToString());
                    _DPCT.SONGAYO = dtNgayTra.Value.Day - dtNgayDat.Value.Day + 1;
                    _DPCT.DONGIA  = int.Parse(gvDatPhong.GetRowCellValue(i,"DONGIA").ToString());
                    _DPCT.THANHTIEN = _DPCT.SONGAYO * _DPCT.DONGIA;
                    _DPCT.NGAY = DateTime.Now;

                    var _dpct = _datphongchitiet.Add(_DPCT);
                    _phong.UpdateStatus(int.Parse(_DPCT.IDPHONG.ToString()), true); //cập nhật cái IDphong đó đã tồn tại người ở

                    if(gvDatSPDV.RowCount > 0)
                    {
                        for (int j = 0; j < gvDatSPDV.RowCount; j++)
                        {
                            if (_DPCT.IDPHONG == int.Parse(gvDatSPDV.GetRowCellValue(j, "IDPHONG").ToString()))
                            {
                                _DPSP = new tb_DATPHONGSP();
                                _DPSP.IDDP = _dp.IDDP;
                                _DPSP.IDDPCT = _dpct.IDDPCT;
                                _DPSP.IDPHONG = int.Parse(gvDatSPDV.GetRowCellValue(j, "IDPHONG").ToString());
                                _DPSP.IDSP  = int.Parse(gvDatSPDV.GetRowCellValue(j, "IDSP").ToString());
                                _DPSP.SOLUONG = int.Parse(gvDatSPDV.GetRowCellValue(j, "SOLUONG").ToString());
                                _DPSP.DONGIA  = int.Parse(gvDatSPDV.GetRowCellValue(j, "DONGIA").ToString());
                                _DPSP.NGAY = DateTime.Now;
                                _DPSP.THANHTIEN = _DPSP.SOLUONG * _DPSP.DONGIA;

                                _datphongsanpham.Add(_DPSP);
                            }   
                        }
                    }
                }
            wlog.Fucntion_WriteLog(User.ToString(), "Đặt Phòng", "Thêm", _IDdatphong.ToString());
            }
            else
            {
                //update
                tb_DATPHONG _DP = _datphong.GetItem(_IDdatphong);
                tb_DATPHONGCHITIET _DPCT;
                tb_DATPHONGSP _DPSP;
                _DP.NGAYDAT = dtNgayDat.Value;
                _DP.NGAYTRA = dtNgayTra.Value;
                _DP.SONGUOI = int.Parse(spinPeople.EditValue.ToString());
                _DP.TRANGTHAI = bool.Parse(cbbStatus.SelectedValue.ToString());
                _DP.IDKHACH = int.Parse(cbbKhach.SelectedValue.ToString());
                _DP.SOTIEN = double.Parse(txtThanhTien.Text);
                _DP.GHICHU = txtNote.Text;
                _DP.IDUSER = 1; //phân quyền người dùng
                _DP.UPDATE_BY = 1; //Update bởi user nào
                _DP.UPDATE_DATE = DateTime.Now;
                var _dp = _datphong.Update(_DP);
                _IDdatphong = _dp.IDDP;
                _datphongchitiet.DeleteAll(_DP.IDDP);
                _datphongsanpham.DeleteAll(_DP.IDDP);

                for (int i = 0; i < gvDatPhong.RowCount; i++)
                {
                    _DPCT = new tb_DATPHONGCHITIET();
                    _DPCT.IDDP = _dp.IDDP;
                    _DPCT.IDPHONG = int.Parse(gvDatPhong.GetRowCellValue(i, "IDPHONG").ToString());
                    _DPCT.SONGAYO = dtNgayTra.Value.Day - dtNgayDat.Value.Day + 1;
                    _DPCT.DONGIA = int.Parse(gvDatPhong.GetRowCellValue(i, "DONGIA").ToString());
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
             wlog.Fucntion_WriteLog(User.ToString(), "Đặt Phòng", "Sửa", _IDdatphong.ToString());
            }
        } 
        private void tsBTNPrint_Click(object sender, EventArgs e)
        {
            if (_IDdatphong == 0)
            {

                MessageBox.Show("Vui long chọn Hóa Đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }

            if (_datphong.GetItem(_IDdatphong).TRANGTHAI == true && _Them == false)
            {
                XuatReport("@IDDP", _IDdatphong.ToString(), "PHIEU_DATPHONG", "Phiếu đặt phòng chi tiết");
            }
            if (!_Them)
            {
                if (DateTime.Now > _datphong.GetItem(_IDdatphong).NGAYTRA)
                {
                    if (MessageBox.Show("Hóa đơn có ngày trả nhỏ hơn ngày hiện tại. Bạn có muốn tiếp tục", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        XuatReport("@IDDP", _IDdatphong.ToString(), "PHIEU_DATPHONG", "Phiếu đặt phòng chi tiết");
                        _datphong.UpdateStatus(_IDdatphong);

                        _phong.UpdateStatusBy_IDDP(_IDdatphong, false);
                        cbbStatus.SelectedValue = true;
                        ObjectMain.gControl.Gallery.Groups.Clear();
                        ObjectMain.ShowRoom();
                    }

                }
                else if (DateTime.Now < _datphong.GetItem(_IDdatphong).NGAYTRA)
                {
                    if (MessageBox.Show("Hóa đơn có ngày trả lớn hơn ngày hiện tại. Bạn có muốn tiếp tục", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        XuatReport("@IDDP", _IDdatphong.ToString(), "PHIEU_DATPHONG", "Phiếu đặt phòng chi tiết");
                        _datphong.UpdateStatus(_IDdatphong);

                        _phong.UpdateStatusBy_IDDP(_IDdatphong, false);
                        cbbStatus.SelectedValue = true;
                        ObjectMain.gControl.Gallery.Groups.Clear();
                        ObjectMain.ShowRoom();
                    }
                }
                else
                {
                    XuatReport("@IDDP", _IDdatphong.ToString(), "PHIEU_DATPHONG", "Phiếu đặt phòng chi tiết");
                    _datphong.UpdateStatus(_IDdatphong);

                    _phong.UpdateStatusBy_IDDP(_IDdatphong, false);
                    cbbStatus.SelectedValue = true;
                    ObjectMain.gControl.Gallery.Groups.Clear();
                    ObjectMain.ShowRoom();
                }




            }
        }
        private void XuatReport(string _param, string _value, string _reportName, string _title)
        {
            BinaryFormatter bf = new BinaryFormatter();  // tạo đối tượng chuyển đổi file
            FileStream fs = File.Open("connectdb.dba", FileMode.Open, FileAccess.Read);
            Connect cp = (Connect)bf.Deserialize(fs);    // đọc kết quả file thu được từ quá trình serialize bên connect.cs                             
            string servername = Encryptor.Decrypt(cp.servername, "qwertyuiop", true);
            string username = Encryptor.Decrypt(cp.username, "qwertyuiop", true);
            string pass = Encryptor.Decrypt(cp.passwd, "qwertyuiop", true);
            string database = Encryptor.Decrypt(cp.database, "qwertyuiop", true);

            if (_IDdatphong != 0)
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
                    doc.SetParameterValue(_param, _value.ToString());
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
            wlog.Fucntion_WriteLog(User.ToString(), "Đặt Phòng", "In", _IDdatphong.ToString());
        }
        private void tsBtnCancel_Click(object sender, EventArgs e)
        {
            _Them = false;
            ShowHideControl(true);
            Enable(false);
            TabControl.SelectedTabPage = PageDanhSach;
            wlog.Fucntion_WriteLog(User.ToString(), "Đặt Phòng", "Cancel", "");
        }

        private void tsBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //======================================================================================================================================
        //Sự Kiện Di Chuyển Chuột Ở GridView DatPhong
        private void gvDatPhong_MouseDown(object sender, MouseEventArgs e)
        {
            if (gvDatPhong.GetFocusedRowCellValue("IDPHONG") != null)
            {
                _IDphong = int.Parse(gvDatPhong.GetFocusedRowCellValue("IDPHONG").ToString());
                _tenphong = gvDatPhong.GetFocusedRowCellValue("TENPHONG").ToString();
            }
            GridView view = sender as GridView; //hiển thị data vào dưới dạng lưới
            downhitinfo = null;                // các dòng được lưu sẽ về null      GridHitInfo downhitinfo = null -> lưu các dòng khi mình nhấn chuột 
            GridHitInfo hitinfo = view.CalcHitInfo(new Point(e.X, e.Y)); // tạo điểm chỉ định mới ở vị trí nhấp chuột hiện tại
            if (Control.ModifierKeys != Keys.None) return;               //nếu các phím CTRL SHIFT ALT được ấn cùng với chuột thì sẽ bỏ kết quả 
            if (e.Button == MouseButtons.Left && hitinfo.RowHandle >= 0)  //nếu ấn chuột trái và lấy hoặc đặt tay cầm của hàng nằm dưới điểm kiểm tra nhiều hơn 0 thì lưu điểm
            {
                downhitinfo = hitinfo;
            }
        }

        private void gvDatPhong_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && downhitinfo != null)  //nếu ấn chuột trái và lấy hoặc đặt tay cầm của hàng nằm dưới điểm kiểm tra không có gì thì lưu điểm
            {
                Size dragsize = SystemInformation.DragSize; //Lấy chiều rộng và chiều cao của hình chữ nhật được đánh dấu ở điểm nhấn chuột.
                Rectangle dragrect = new Rectangle(new Point(downhitinfo.HitPoint.X - dragsize.Width / 2, downhitinfo.HitPoint.Y - dragsize.Height / 2), dragsize); 
                //khởi tạo một phiên bản mới của lớp hình chữ nhật với vị trí và kích thước cụ thể. một kích thước đại diện cho chiều rộng và chiều cao của vùng hình chữ nhật
                if (!dragrect.Contains(new Point(e.X, e.Y))) // xác định xem điểm chỉ định có nằm trong cấu trúc hình chữ nhật không
                    // phương thức trả về true nếu điểm chỉ định nằm trong cấu trúc hình chữ nhật.
                {
                    DataRow row = view.GetDataRow(downhitinfo.RowHandle);
                    view.GridControl.DoDragDrop(row, DragDropEffects.Move); //thực hiện việc kéo thả
                    downhitinfo = null;
                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;  //sự kiện đã được xử lý
                }
            }
        }
        //======================================================================================================================================
        //Sự Kiện Di Chuyển Chuột Ở GridView PhongEmpty
        private void gvPhongEmpty_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView; //hiển thị data vào dưới dạng lưới
            downhitinfo = null;                // các dòng được lưu sẽ về null      GridHitInfo downhitinfo = null -> lưu các dòng khi mình nhấn chuột 
            GridHitInfo hitinfo = view.CalcHitInfo(new Point(e.X, e.Y)); // tạo điểm lưu mới ở vị trí nhấp chuột hiện tại
            if (Control.ModifierKeys != Keys.None) return;               //nếu các phím CTRL SHIFT ALT được ấn thì sẽ trả kết quả
            if (e.Button == MouseButtons.Left && hitinfo.RowHandle >= 0)  //nếu ấn chuột trái và lấy hoặc đặt tay cầm của hàng nằm dưới điểm kiểm tra nhiều hơn 0 thì lưu điểm
            {
                downhitinfo = hitinfo;
            }

        }

        private void gvPhongEmpty_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && downhitinfo != null)  //nếu ấn chuột trái và lấy hoặc đặt tay cầm của hàng nằm dưới điểm kiểm tra không có gì thì lưu điểm
            {
                Size dragsize = SystemInformation.DragSize;
                Rectangle dragrect = new Rectangle(new Point(downhitinfo.HitPoint.X - dragsize.Width / 2, downhitinfo.HitPoint.Y - dragsize.Height / 2), dragsize); //khởi tạo một phiên bản mới của lớp hình chữ nhật với vị trí và kích thước cụ thể. một kích thước đại diện cho chiều rộng và chiều cao của vùng hình chữ nhật
                if (!dragrect.Contains(new Point(e.X, e.Y))) //khác hình chữ nhật
                {
                    DataRow row = view.GetDataRow(downhitinfo.RowHandle);
                    view.GridControl.DoDragDrop(row, DragDropEffects.Move);
                    downhitinfo = null;
                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
            }
        }
        //======================================================================================================================================
        //Sự Kiện Kéo Thả Giữa 2 Vùng GridView
        private void gcPhongEmpty_DragDrop(object sender, DragEventArgs e)
        {
            GridControl grid = sender as GridControl; //hiển thị data vào dưới dạng lưới
            DataTable table = grid.DataSource as DataTable;
            DataRow row = e.Data.GetData(typeof(DataRow)) as DataRow;
            if (row != null && table != null && row.Table != table)
            {
                table.ImportRow(row);
                row.Delete();
            }
        }

        private void gcPhongEmpty_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataRow)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        //======================================================================================================================================
        //Sựu Kiện Cột Thứ Tự
        bool STT(Int32 _width, GridView _view)
        {
            _view.IndicatorWidth = _view.IndicatorWidth < _width ? _width : _view.IndicatorWidth;
            return true;
            //gvPhongEmpty : CustomDrawRowIndicator
            //Hàm để tăng kích thước của Indicator khi có thay đổi về giá trị của RowHandle
        }
        private void gvPhongEmpty_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gvPhongEmpty.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
            {
                if (e.Info.IsRowIndicator) //Nếu là dòng Indicator
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1; //không hiển thị hình
                        e.Info.DisplayText = (e.RowHandle + 1).ToString(); //STT tăng dần
                    }
                    SizeF _size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //Lấy kích thước vùng hiển thị text
                    Int32 _width = Convert.ToInt32(_size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { STT(_width, gvPhongEmpty); })); //tăng kích thước lên nếu vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * (-1))); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //Lấy kích thước vùng hiển thị text
                Int32 _width = Convert.ToInt32(_size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { STT(_width, gvPhongEmpty); })); //tăng kích thước lên nếu vượt quá
            }
        }
        //======================================================================================================================================
        //Sự Kiện Hiển Thị Phòng Trống
        private void gvPhongEmpty_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            GridGroupRowInfo info = e.Info as GridGroupRowInfo; //thông tin của hàng
            string caption = info.Column.Caption;
            if (info.Column.Caption == string.Empty)            // nếu tiêu đề không có gì thì gán cho nó tiêu đề là cột
            {
                caption = info.Column.ToString();
            }
            info.GroupText = string.Format("{0}: {1} ({2} phòng trống )", caption, info.GroupValueText, view.GetChildRowCount(e.RowHandle)); //0. tiêu đề cột, 1.tiêu đề group, 2. số dòng đếm được trong group
        }
        //======================================================================================================================================
        //Sự Kiện Double Click Chọn Sản Phẩm Dịch Vụ
        private void gcSPDV_DoubleClick(object sender, EventArgs e)
        {
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
                SP.TENPHONG = _tenphong;
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
                        txtThanhTien.Text = (double.Parse(gvDatSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + double.Parse(gvDatPhong.Columns["DONGIA"].SummaryItem.SummaryValue.ToString()) * (dtNgayTra.Value.Day - dtNgayDat.Value.Day + 1)).ToString("N0");
                        return;    
                    }


                }
                listDPSP.Add(SP); //doubleclick lần thứ nhất sẽ add thẳng vào, chưa tồn tại listDPSP
            }
            LoadDPSP();
            txtThanhTien.Text = (double.Parse(gvDatSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString())+double.Parse(gvDatPhong.Columns["DONGIA"].SummaryItem.SummaryValue.ToString()) * (dtNgayTra.Value.Day - dtNgayDat.Value.Day + 1)).ToString("N0");
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
        //======================================================================================================================================
        //Sự Kiện Thay Đổi Giá Trị Ở Ô SOLUONG
        private void gvDatSPDV_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName =="SOLUONG")
            {
                int soluong = int.Parse(e.Value.ToString());
                if (soluong!=0)
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
            txtThanhTien.Text = (double.Parse (gvDatSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString())+ double.Parse(gvDatPhong.Columns["DONGIA"].SummaryItem.SummaryValue.ToString()) * (dtNgayTra.Value.Day - dtNgayDat.Value.Day + 1)).ToString("N0");
        }
        //======================================================================================================================================
        //Sự Kiện (Update) Khi Thay Đổi Dòng
        private void gvDatPhong_RowCountChanged(object sender, EventArgs e)
        {

            if (gvDatPhong.RowCount < _rowcountDP  && _Them == false )
            {
                _phong.UpdateStatus(_IDphong, false);
                _datphongchitiet.Delete(_IDdatphong, _IDphong);
                _datphongsanpham.DeleteAllByPhong(_IDdatphong, _IDphong);
                ObjectMain.gControl.Gallery.Groups.Clear();
                ObjectMain.ShowRoom();
            }
            double tmp = 0;
            if (gvDatSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue == null)
            {
                tmp = 0;
            }
            else
            {
                tmp = double.Parse(gvDatSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString());
            }
            txtThanhTien.Text = ( tmp + double.Parse(gvDatPhong.Columns["DONGIA"].SummaryItem.SummaryValue.ToString())* (dtNgayTra.Value.Day - dtNgayDat.Value.Day + 1)).ToString("N0");
        }
        //======================================================================================================================================
        //Sự Kiện Số Thứ Tự Cho 3 gridview
        private void gvSPDV_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gvSPDV.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
            {
                if (e.Info.IsRowIndicator) //Nếu không phải là dòng Indicator
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1; //không hiển thị hình
                        e.Info.DisplayText = (e.RowHandle + 1).ToString(); //STT tăng dần
                    }
                    SizeF _size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //Lấy kích thước vùng hiển thị text
                    Int32 _width = Convert.ToInt32(_size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { STT(_width, gvSPDV); })); //tăng kích thước lên nếu vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * (-1))); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //Lấy kích thước vùng hiển thị text
                Int32 _width = Convert.ToInt32(_size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { STT(_width, gvSPDV); })); //tăng kích thước lên nếu vượt quá
            }
        }

        private void gvDatPhong_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gvDatPhong.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
            {
                if (e.Info.IsRowIndicator) //Nếu không phải là dòng Indicator
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1; //không hiển thị hình
                        e.Info.DisplayText = (e.RowHandle + 1).ToString(); //STT tăng dần
                    }
                    SizeF _size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //Lấy kích thước vùng hiển thị text
                    Int32 _width = Convert.ToInt32(_size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { STT(_width, gvDatPhong); })); //tăng kích thước lên nếu vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * (-1))); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //Lấy kích thước vùng hiển thị text
                Int32 _width = Convert.ToInt32(_size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { STT(_width, gvDatPhong); })); //tăng kích thước lên nếu vượt quá
            }
        }

        private void gvDatSPDV_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gvDatSPDV.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
            {
                if (e.Info.IsRowIndicator) //Nếu không phải là dòng Indicator
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1; //không hiển thị hình
                        e.Info.DisplayText = (e.RowHandle + 1).ToString(); //STT tăng dần
                    }
                    SizeF _size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //Lấy kích thước vùng hiển thị text
                    Int32 _width = Convert.ToInt32(_size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { STT(_width, gvDatSPDV); })); //tăng kích thước lên nếu vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * (-1))); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //Lấy kích thước vùng hiển thị text
                Int32 _width = Convert.ToInt32(_size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { STT(_width, gvDatSPDV); })); //tăng kích thước lên nếu vượt quá
            }
        }

        //Sự Kiện STT Bên Page Danh Sách
        private void gridViewDS_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gridViewDS.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
            {
                if (e.Info.IsRowIndicator) //Nếu không phải là dòng Indicator
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1; //không hiển thị hình
                        e.Info.DisplayText = (e.RowHandle + 1).ToString(); //STT tăng dần
                    }
                    SizeF _size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //Lấy kích thước vùng hiển thị text
                    Int32 _width = Convert.ToInt32(_size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { STT(_width, gridViewDS); })); //tăng kích thước lên nếu vượt quá
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * (-1))); //Nhân -1 để đánh lại số thứ tự tăng dần
                SizeF _size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //Lấy kích thước vùng hiển thị text
                Int32 _width = Convert.ToInt32(_size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { STT(_width, gridViewDS); })); //tăng kích thước lên nếu vượt quá
            }
        }

        //======================================================================================================================================
        //Sự Kiện Thêm Khách Hàng Mới
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FormKhachHang formKH = new FormKhachHang();
            formKH.ShowDialog();
        }
        public void SetKhachHang(int IDKH)
        {
            var _KH = _khachhang.GetItem(IDKH);
            cbbKhach.SelectedValue = _KH.IDKHACH;
            cbbKhach.Text = _KH.NAMEKHACH;
        }

        //======================================================================================================================================
        //Sự Kiện Chọn Ngày Không Hợp Lệ
        private void dtTuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtTuNgay.Value > dtDenNgay.Value )
            {
                MessageBox.Show("Ngày Không Hợp Lệ","Thông Báo",MessageBoxButtons.OK ,MessageBoxIcon.Error );
                return;
            }
            else
            {
                LoadData();
            }
        }

        private void dtTuNgay_Leave(object sender, EventArgs e)
        {
            if (dtTuNgay.Value > dtDenNgay.Value)
            {
                MessageBox.Show("Ngày Không Hợp Lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            else
            {
                LoadData();
            }
        }

        private void dtDenNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtTuNgay.Value > dtDenNgay.Value)
            {
                MessageBox.Show("Ngày Không Hợp Lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                LoadData();
            }
        }

        private void dtDenNgay_Leave(object sender, EventArgs e)
        {
            if (dtTuNgay.Value > dtDenNgay.Value)
            {
                MessageBox.Show("Ngày Không Hợp Lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                LoadData();
            }
        }
        //======================================================================================================================================

        // Sự Kiện Click pageDANHSACH
        private void gridViewDS_Click(object sender, EventArgs e)
        {
            if (gridViewDS.RowCount > 0)
            {
                _IDdatphong = int.Parse(gridViewDS.GetFocusedRowCellValue("IDDP").ToString());
                var dp = _datphong.GetItem(_IDdatphong); //Khi click để sửa sẽ hiện các thông tin của IDdatphong đó bên chi tiết
                cbbKhach.SelectedValue = dp.IDKHACH;
                dtNgayDat.Value = dp.NGAYDAT.Value;
                dtNgayTra.Value = dp.NGAYTRA.Value;
                spinPeople.Text = dp.SONGUOI.ToString();
                cbbStatus.SelectedValue = dp.TRANGTHAI;
                txtNote.Text = dp.GHICHU;
                checkBoxG.Checked = dp.DOAN.Value;
                txtThanhTien.Text = dp.SOTIEN.Value.ToString("N0");
                LoadgvDP();
                LoadgvDatSPDV();
            }
        }

        //Sự Kiện Double Click pageDANHSACH để sửa data bên pageCHITIET
        private void gridViewDS_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewDS.RowCount > 0) 
            {
                _IDdatphong = int.Parse(gridViewDS.GetFocusedRowCellValue("IDDP").ToString());
                var dp = _datphong.GetItem(_IDdatphong); //Khi click để sửa sẽ hiện các thông tin của IDdatphong đó bên chi tiết
                cbbKhach.SelectedValue = dp.IDKHACH;
                dtNgayDat.Value = dp.NGAYDAT.Value;
                dtNgayTra.Value = dp.NGAYTRA.Value;
                spinPeople.Text = dp.SONGUOI.ToString();
                cbbStatus.SelectedValue = dp.TRANGTHAI;
                txtNote.Text = dp.GHICHU;
                checkBoxG.Checked = dp.DOAN.Value;
                txtThanhTien.Text = dp.SOTIEN.Value.ToString("N0");
                LoadgvDP();
                LoadgvDatSPDV();
            }
            TabControl.SelectedTabPage = PageChiTiet;
        }
        //đồng bộ hóa data với showroom khi tương tác
        void LoadgvDP()
        {
            _rowcountDP = 0; //reset rowcount về 0, khi LoadgvDP nó sẽ gán _rowcountDP = gvDatPhong.RowCount; 
            gcDatPhong.DataSource = MyFunction.GetData("SELECT A.IDPHONG, A.TENPHONG, A.IDLAU, B.TENLAU, C.DONGIA FROM tb_PHONG A, tb_TANGLAU B, tb_LOAIPHONG C, tb_DATPHONGCHITIET D WHERE A.IDLAU = B.IDLAU AND A.IDLOAIPHONG = C.IDLOAIPHONG AND A.IDPHONG = D.IDPHONG AND D.IDDP = '" + _IDdatphong + "'");
            _rowcountDP = gvDatPhong.RowCount; 
        }
        void LoadgvDatSPDV()
        {
            gcDatSPDV.DataSource = _datphongsanpham.GetAllByDatPhong(_IDdatphong);
        }
        //======================================================================================================================================

        private void gvDatPhong_Click(object sender, EventArgs e)
        {
            if (gvDatPhong.GetFocusedRowCellValue("IDPHONG") != null)
            {
                _IDphong = int.Parse(gvDatPhong.GetFocusedRowCellValue("IDPHONG").ToString());
                _tenphong = gvDatPhong.GetFocusedRowCellValue("TENPHONG").ToString();
            }
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            if(XtraMessageBox.Show($"Are You Sure Want To Delete ?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                gvDatSPDV.DeleteSelectedRows();
                listDPSP.Clear();
                txtThanhTien.Text = (double.Parse(gvDatSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()) + double.Parse(gvDatPhong.Columns["DONGIA"].SummaryItem.SummaryValue.ToString()) * (dtNgayTra.Value.Day - dtNgayDat.Value.Day + 1)).ToString("N0");
            }
        }

        private void dtNgayTra_ValueChanged(object sender, EventArgs e)
        {
            double tmp = 0;
            if (gvDatSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue == null)
            {
                tmp = 0;
            }
            else
            {
                tmp = double.Parse(gvDatSPDV.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString());
            }
            txtThanhTien.Text = (tmp + double.Parse(gvDatPhong.Columns["DONGIA"].SummaryItem.SummaryValue.ToString()) * (dtNgayTra.Value.Day - dtNgayDat.Value.Day + 1)).ToString("N0");
        }

        //======================================================================================================================================


        //======================================================================================================================================
    }
}