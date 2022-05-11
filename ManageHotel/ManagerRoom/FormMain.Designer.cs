
namespace ManagerRoom
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnHeThong = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBaoCao = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnQuestion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLog = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.navMain = new DevExpress.XtraNavBar.NavBarControl();
            this.imgDanhMuc = new System.Windows.Forms.ImageList(this.components);
            this.imgIndex = new System.Windows.Forms.ImageList(this.components);
            this.gControl = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.imgHouse = new System.Windows.Forms.ImageList(this.components);
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnItemUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnItemDP = new DevExpress.XtraBars.BarButtonItem();
            this.btnItemChuyen = new DevExpress.XtraBars.BarButtonItem();
            this.btnItemThanhToan = new DevExpress.XtraBars.BarButtonItem();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gControl)).BeginInit();
            this.gControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHeThong,
            this.toolStripSeparator1,
            this.btnBaoCao,
            this.toolStripSeparator2,
            this.btnQuestion,
            this.toolStripSeparator4,
            this.btnLog,
            this.toolStripSeparator5,
            this.btnThoat,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1332, 66);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnHeThong
            // 
            this.btnHeThong.Image = global::ManagerRoom.Properties.Resources.pc;
            this.btnHeThong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(94, 61);
            this.btnHeThong.Text = "Hệ Thống";
            this.btnHeThong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 66);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Image = global::ManagerRoom.Properties.Resources.report;
            this.btnBaoCao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(82, 61);
            this.btnBaoCao.Text = "Báo Cáo";
            this.btnBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 66);
            // 
            // btnQuestion
            // 
            this.btnQuestion.Image = global::ManagerRoom.Properties.Resources.help;
            this.btnQuestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(82, 61);
            this.btnQuestion.Text = "Trợ Giúp";
            this.btnQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 66);
            // 
            // btnLog
            // 
            this.btnLog.Image = global::ManagerRoom.Properties.Resources.clock;
            this.btnLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(72, 61);
            this.btnLog.Text = "Lịch Sử";
            this.btnLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 66);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::ManagerRoom.Properties.Resources.logout32;
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5, 2, 5, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 61);
            this.btnThoat.Text = "Đăng Xuất";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 66);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 66);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.navMain);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1332, 627);
            this.splitContainerControl1.SplitterPosition = 289;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // navMain
            // 
            this.navMain.Appearance.Background.BackColor = System.Drawing.Color.White;
            this.navMain.Appearance.Background.Options.UseBackColor = true;
            this.navMain.Appearance.GroupBackground.BackColor = System.Drawing.Color.Transparent;
            this.navMain.Appearance.GroupBackground.Options.UseBackColor = true;
            this.navMain.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.navMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.navMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navMain.LargeImages = this.imgDanhMuc;
            this.navMain.Location = new System.Drawing.Point(0, 0);
            this.navMain.Name = "navMain";
            this.navMain.OptionsNavPane.ExpandedWidth = 289;
            this.navMain.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navMain.Size = new System.Drawing.Size(289, 627);
            this.navMain.SmallImages = this.imgIndex;
            this.navMain.TabIndex = 0;
            this.navMain.Text = "navBarControl1";
            this.navMain.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navMain_LinkClicked);
            // 
            // imgDanhMuc
            // 
            this.imgDanhMuc.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgDanhMuc.ImageStream")));
            this.imgDanhMuc.TransparentColor = System.Drawing.Color.Transparent;
            this.imgDanhMuc.Images.SetKeyName(0, "listblue.png");
            this.imgDanhMuc.Images.SetKeyName(1, "system32.png");
            // 
            // imgIndex
            // 
            this.imgIndex.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIndex.ImageStream")));
            this.imgIndex.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIndex.Images.SetKeyName(0, "index.png");
            // 
            // gControl
            // 
            this.gControl.Controls.Add(this.galleryControlClient1);
            this.gControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gControl.Location = new System.Drawing.Point(0, 0);
            this.gControl.Name = "gControl";
            this.barManager.SetPopupContextMenu(this.gControl, this.popupMenu);
            this.gControl.Size = new System.Drawing.Size(1028, 627);
            this.gControl.TabIndex = 0;
            this.gControl.Text = "galleryControl1";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.gControl;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(998, 623);
            // 
            // imgHouse
            // 
            this.imgHouse.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgHouse.ImageStream")));
            this.imgHouse.TransparentColor = System.Drawing.Color.Transparent;
            this.imgHouse.Images.SetKeyName(0, "No.png");
            this.imgHouse.Images.SetKeyName(1, "Yes.png");
            // 
            // popupMenu
            // 
            this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnItemUpdate),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnItemDP),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnItemChuyen),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnItemThanhToan)});
            this.popupMenu.Manager = this.barManager;
            this.popupMenu.Name = "popupMenu";
            this.popupMenu.Popup += new System.EventHandler(this.popupMenu_Popup);
            // 
            // btnItemUpdate
            // 
            this.btnItemUpdate.Caption = "Cập Nhật Sản Phẩm - Dịch Vụ";
            this.btnItemUpdate.Id = 1;
            this.btnItemUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemUpdate.ImageOptions.Image")));
            this.btnItemUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnItemUpdate.ImageOptions.LargeImage")));
            this.btnItemUpdate.Name = "btnItemUpdate";
            this.btnItemUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnItemUpdate_ItemClick);
            // 
            // btnItemDP
            // 
            this.btnItemDP.Caption = "Đặt Phòng";
            this.btnItemDP.Id = 4;
            this.btnItemDP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemDP.ImageOptions.Image")));
            this.btnItemDP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnItemDP.ImageOptions.LargeImage")));
            this.btnItemDP.Name = "btnItemDP";
            this.btnItemDP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnItemDP_ItemClick);
            // 
            // btnItemChuyen
            // 
            this.btnItemChuyen.Caption = "Chuyển Phòng";
            this.btnItemChuyen.Id = 5;
            this.btnItemChuyen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemChuyen.ImageOptions.Image")));
            this.btnItemChuyen.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnItemChuyen.ImageOptions.LargeImage")));
            this.btnItemChuyen.Name = "btnItemChuyen";
            this.btnItemChuyen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnItemChuyen_ItemClick);
            // 
            // btnItemThanhToan
            // 
            this.btnItemThanhToan.Caption = "Thanh Toán";
            this.btnItemThanhToan.Id = 2;
            this.btnItemThanhToan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemThanhToan.ImageOptions.Image")));
            this.btnItemThanhToan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnItemThanhToan.ImageOptions.LargeImage")));
            this.btnItemThanhToan.Name = "btnItemThanhToan";
            this.btnItemThanhToan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnItemThanhToan_ItemClick);
            // 
            // barManager
            // 
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnItemUpdate,
            this.btnItemThanhToan,
            this.btnItemDP,
            this.btnItemChuyen});
            this.barManager.MaxItemId = 6;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(1332, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 693);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(1332, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 693);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1332, 0);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 693);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 693);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FormMain.IconOptions.Icon")));
            this.Name = "FormMain";
            this.Text = "Quản Lý Khách Sạn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gControl)).EndInit();
            this.gControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnHeThong;
        private System.Windows.Forms.ToolStripButton btnBaoCao;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraNavBar.NavBarControl navMain;
        private System.Windows.Forms.ImageList imgDanhMuc;
        private System.Windows.Forms.ImageList imgIndex;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private System.Windows.Forms.ImageList imgHouse;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnItemUpdate;
        private DevExpress.XtraBars.BarButtonItem btnItemThanhToan;
        private DevExpress.XtraBars.PopupMenu popupMenu;
        public DevExpress.XtraBars.Ribbon.GalleryControl gControl;
        private DevExpress.XtraBars.BarButtonItem btnItemDP;
        private DevExpress.XtraBars.BarButtonItem btnItemChuyen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnQuestion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}