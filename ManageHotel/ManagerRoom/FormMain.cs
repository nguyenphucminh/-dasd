using BusinessLayer;
using DataLayer;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ManagerRoom
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        public FormMain(tb_SYS_USERS user)
        {
            InitializeComponent();
            this._user = user;
            this.Text = "PHẦN MỀN QUẢN LÝ KHÁCH SẠN - " + _user.FULLNAME + " - " + _user.USERNAME + " - " + MyFunction._macty + " - " + MyFunction._madvi;
        }
        tb_SYS_USERS _user;
        TangLau _tanglau;
        Phong _phong;
        SYS_Function _function;
        SYS_Group _sysGroup;
        SYS_Role _sysRole;
        GalleryItem item = null;
        WriteLog wlg = new WriteLog();
        private void FormMain_Load(object sender, EventArgs e)
        {
            
            _tanglau = new TangLau();
            _phong = new Phong();
            _function = new SYS_Function();
            _sysRole = new SYS_Role();
            _sysGroup = new SYS_Group();
            leftMenu();
            ShowRoom();
            string path = (AppDomain.CurrentDomain.BaseDirectory + "LogFile.txt");
            if (!System.IO.File.Exists(path))
            {
                System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + "LogFile.txt");

            }
            wlg.Fucntion_WriteLog(_user.USERNAME.ToString(), "Login");
        }
        void leftMenu()
        {
            int i = 0;
            var _lsParent = _function.GetParent();
            foreach (var itemP in _lsParent)
            {
                NavBarGroup navGroup = new NavBarGroup(itemP.DESCRIPTION);
                navGroup.Tag = itemP.FUNC_CODE; //spend for Tạo phân quyền và chức năng
                navGroup.Name = itemP.FUNC_CODE;//spend for Tạo phân quyền và chức năng
                navMain.Groups.Add(navGroup);
                navGroup.ImageOptions.LargeImageIndex = i; i++;
                var _lsChild = _function.GetChild(itemP.FUNC_CODE);
                foreach (var itemC in _lsChild)
                {
                    NavBarItem  navItem = new NavBarItem(itemC.DESCRIPTION);
                    navItem.Tag = itemC.FUNC_CODE; //spend for Tạo phân quyền và chức năng
                    navItem.Name = itemC.FUNC_CODE; //spend for Tạo phân quyền và chức năng
                    navGroup.ItemLinks.Add(navItem);
                    navItem.ImageOptions.SmallImageIndex = 0;
                }
                navMain.Groups[navGroup.Name].Expanded = true;
            } 
        }
        public void ShowRoom()
        {
            _tanglau = new TangLau();
            _phong = new Phong();
            gControl.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside;
            gControl.Gallery.ImageSize = new Size(64,64);
            gControl.Gallery.ShowItemText = true;
            gControl.Gallery.ShowGroupCaption = true;
            var _lsTangLau = _tanglau.GetAll();

            foreach (var t in _lsTangLau)
            {
                var galleryItemTANG = new GalleryItemGroup();
                galleryItemTANG.Caption = t.TENLAU;
                galleryItemTANG.CaptionAlignment = GalleryItemGroupCaptionAlignment.Stretch;

                var _lsPhong = _phong.GetByTang(t.IDLAU);
                foreach (var p in _lsPhong )
                {
                    var galleryItemPHONG = new GalleryItem();
                    galleryItemPHONG.Caption = p.TENPHONG;
                    galleryItemPHONG.Value= p.IDPHONG; 
                    if(p.TRANGTHAI==true)
                    {
                        galleryItemPHONG.ImageOptions.Image = imgHouse.Images[1];
                    }    
                    else
                    {
                        galleryItemPHONG.ImageOptions.Image = imgHouse.Images[0];
                    }
                    
                    galleryItemTANG.Items.Add(galleryItemPHONG);
                }
                gControl.Gallery.Groups.Add(galleryItemTANG);
            }
            
        }    
        private void navMain_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string func_code = e.Link.Item.Tag.ToString();

            var group = _sysGroup.GetGroupByMemBer(_user.IDUSER); //láy quyền user
            var role = _sysRole.getRight(_user.IDUSER, func_code);  
            if (group != null)
            {
                var _groupRight = _sysRole.getRight(group.GROUP, func_code);  //lấy quyền group
                if (role.USER_ROLE < _groupRight.USER_ROLE) // quyền user < quyền group
                {
                    role.USER_ROLE = _groupRight.USER_ROLE;
                }
            }
            if (role.USER_ROLE == 0)
            {
                MessageBox.Show("Không có quyền thao tác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                switch (func_code)
                {
                    case "CONGTY":
                        {
                            FormCongTy frmCT = new FormCongTy();
                            frmCT.ShowDialog();
                            break;
                        }
                    case "DONVI":
                        {
                            FormDonVi frmDV = new FormDonVi();
                            frmDV.ShowDialog();
                            break;
                        }
                    case "KHACHHANG":
                        {
                            FormKhachHang frmKH = new FormKhachHang();
                            frmKH.ShowDialog();
                            break;
                        }
                    case "LOAIPHONG":
                        {
                            FormLoaiPhong frmLP = new FormLoaiPhong();
                            frmLP.ShowDialog();
                            break;
                        }
                    case "PHONG":
                        {
                            FormPhong frmP = new FormPhong();
                            frmP.ShowDialog();
                            break;
                        }
                    case "TANG":
                        {
                            FormTangLau frmTL = new FormTangLau();
                            frmTL.ShowDialog();
                            break;
                        }
                    case "SANPHAM":
                        {
                            FormSanPham frmSP = new FormSanPham();
                            frmSP.ShowDialog();
                            break;
                        }
                    case "THIETBI":
                        {
                            FormThietBi frmTB = new FormThietBi();
                            frmTB.ShowDialog();
                            break;
                        }
                    case "DATPHONG":
                        {
                            FormDatPhong frmDP = new FormDatPhong(_user.USERNAME);
                            frmDP.ShowDialog();
                            break;
                        }
                    case "NGUOIDUNG":
                        {
                            UserManagement.FormUserManagement frmUserManagement = new UserManagement.FormUserManagement();
                            frmUserManagement.ShowDialog();
                            break;
                        }
                    case "BACKUP":
                        {
                            FormBackup frmBackup = new FormBackup();
                            frmBackup.ShowDialog();
                            break;
                        }
                        
                }    

            }    
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Do you really want to close the program? ", "Exit", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                Application.ExitThread();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to close the program? ", "Exit", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //=======================================================================================================================================================================
        private void popupMenu_Popup(object sender, EventArgs e)
        {
            Point point = gControl.PointToClient(Control.MousePosition);
            RibbonHitInfo hitInfo = gControl.CalcHitInfo(point);
            if (hitInfo.InGalleryItem || hitInfo.HitTest == RibbonHitTest.GalleryImage)
            {
                item = hitInfo.GalleryItem;
            } 
                
        }

        private void btnItemDP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_phong.CheckEmpty(int.Parse(item.Value.ToString())))
            {
                MessageBox.Show("Phòng đã được đặt .Vui lòng chọn phòng khác.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FormDatPhongDon frmDPD = new FormDatPhongDon();
                frmDPD._IDphong = int.Parse(item.Value.ToString());
                frmDPD._Them = true;
                frmDPD.ShowDialog();
        }
        private void btnItemChuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!_phong.CheckEmpty(int.Parse(item.Value.ToString())))
            {
                MessageBox.Show("Phòng chưa được đặt nên không được phép chuyển. Vui lòng chọn phòng đã được đặt.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FormChuyenPhong frmCP = new FormChuyenPhong();
            frmCP.IDPhong = int.Parse(item.Value.ToString());
            frmCP.ShowDialog();

        }

        private void btnItemUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!_phong.CheckEmpty(int.Parse(item.Value.ToString())))
            {
                MessageBox.Show("Phòng chưa được đặt nên không cập nhật sản phẩm dịch vụ được. Vui lòng chọn phòng đã được đặt.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FormDatPhongDon frmDPD = new FormDatPhongDon();
            frmDPD._IDphong = int.Parse(item.Value.ToString());
            frmDPD._Them = false;
            frmDPD.ShowDialog();
        }

        private void btnItemThanhToan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!_phong.CheckEmpty(int.Parse(item.Value.ToString())))
            {
                MessageBox.Show("Phòng chưa được đặt nên không thể thanh toán được. Vui lòng chọn phòng đã được đặt.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FormDatPhongDon frmDPD = new FormDatPhongDon();
            frmDPD._IDphong = int.Parse(item.Value.ToString());
            frmDPD._Them = false;
            frmDPD.ShowDialog();
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"D:\VS\ManageApp\ManageHotel\ManagerRoom\bin\Debug\GuideHelp.chm");
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            FormLog frmDP = new FormLog();
            frmDP.ShowDialog();
        }
    } 
}