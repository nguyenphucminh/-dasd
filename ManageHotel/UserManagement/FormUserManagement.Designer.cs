
namespace UserManagement
{
    partial class FormUserManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserManagement));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnGroup = new DevExpress.XtraBars.BarButtonItem();
            this.BtnUser = new DevExpress.XtraBars.BarButtonItem();
            this.BtnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.BtnFucntion = new DevExpress.XtraBars.BarButtonItem();
            this.BtnReport = new DevExpress.XtraBars.BarButtonItem();
            this.BtnExit = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.SysTem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDONVI = new DevExpress.XtraEditors.LabelControl();
            this.panelNhom = new System.Windows.Forms.Panel();
            this.gcUser = new DevExpress.XtraGrid.GridControl();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuAddGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuRole = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.gvUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DISABLED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDUSER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FULLNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MACTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MADVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ISGROUP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DELETE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUser)).BeginInit();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.BtnGroup,
            this.BtnUser,
            this.BtnUpdate,
            this.BtnFucntion,
            this.BtnReport,
            this.BtnExit,
            this.barStaticItem1,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbonControl1.Size = new System.Drawing.Size(1219, 219);
            // 
            // BtnGroup
            // 
            this.BtnGroup.Caption = "Nhóm Người Dùng";
            this.BtnGroup.Id = 1;
            this.BtnGroup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGroup.ImageOptions.Image")));
            this.BtnGroup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnGroup.ImageOptions.LargeImage")));
            this.BtnGroup.Name = "BtnGroup";
            this.BtnGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnGroup_ItemClick);
            // 
            // BtnUser
            // 
            this.BtnUser.Caption = "Người Dùng";
            this.BtnUser.Id = 2;
            this.BtnUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUser.ImageOptions.Image")));
            this.BtnUser.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnUser.ImageOptions.LargeImage")));
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnUser_ItemClick);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Caption = "Cập Nhật Thông Tin";
            this.BtnUpdate.Id = 3;
            this.BtnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.ImageOptions.Image")));
            this.BtnUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.ImageOptions.LargeImage")));
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnUpdate_ItemClick);
            // 
            // BtnFucntion
            // 
            this.BtnFucntion.Caption = "Phân Quyền Chức Năng";
            this.BtnFucntion.Id = 4;
            this.BtnFucntion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnFucntion.ImageOptions.Image")));
            this.BtnFucntion.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnFucntion.ImageOptions.LargeImage")));
            this.BtnFucntion.Name = "BtnFucntion";
            this.BtnFucntion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnFucntion_ItemClick);
            // 
            // BtnReport
            // 
            this.BtnReport.Caption = "Phân Quyền Báo Cáo";
            this.BtnReport.Id = 5;
            this.BtnReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnReport.ImageOptions.Image")));
            this.BtnReport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnReport.ImageOptions.LargeImage")));
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnReport_ItemClick);
            // 
            // BtnExit
            // 
            this.BtnExit.Caption = "Thoát Hệ Thống";
            this.BtnExit.Id = 6;
            this.BtnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.ImageOptions.Image")));
            this.BtnExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.ImageOptions.LargeImage")));
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExit_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 7;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thay Đổi Mật Khẩu";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.SysTem});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Chức Năng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnGroup);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnUser, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnUpdate, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tài Khoản";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnFucntion);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnReport, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Phân Quyền";
            // 
            // SysTem
            // 
            this.SysTem.ItemLinks.Add(this.BtnExit);
            this.SysTem.ItemLinks.Add(this.barButtonItem1, true);
            this.SysTem.Name = "SysTem";
            this.SysTem.Text = "Hệ Thống";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbDONVI);
            this.panel1.Controls.Add(this.panelNhom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 41);
            this.panel1.TabIndex = 1;
            // 
            // lbDONVI
            // 
            this.lbDONVI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDONVI.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbDONVI.LineVisible = true;
            this.lbDONVI.Location = new System.Drawing.Point(739, 14);
            this.lbDONVI.Name = "lbDONVI";
            this.lbDONVI.Size = new System.Drawing.Size(48, 19);
            this.lbDONVI.TabIndex = 1;
            this.lbDONVI.Text = "Đơn Vị";
            // 
            // panelNhom
            // 
            this.panelNhom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNhom.Location = new System.Drawing.Point(799, 10);
            this.panelNhom.Name = "panelNhom";
            this.panelNhom.Size = new System.Drawing.Size(408, 31);
            this.panelNhom.TabIndex = 0;
            // 
            // gcUser
            // 
            this.gcUser.ContextMenuStrip = this.MenuStrip;
            this.gcUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUser.Location = new System.Drawing.Point(0, 260);
            this.gcUser.MainView = this.gvUser;
            this.gcUser.MenuManager = this.ribbonControl1;
            this.gcUser.Name = "gcUser";
            this.gcUser.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.BtnDelete});
            this.gcUser.Size = new System.Drawing.Size(1219, 394);
            this.gcUser.TabIndex = 0;
            this.gcUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUser});
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAddGroup,
            this.toolStripSeparator1,
            this.MenuAddUser,
            this.toolStripSeparator2,
            this.MenuUpdate,
            this.toolStripSeparator3,
            this.MenuRole,
            this.toolStripSeparator4,
            this.MenuReport,
            this.toolStripSeparator5,
            this.MenuExit});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(274, 226);
            // 
            // MenuAddGroup
            // 
            this.MenuAddGroup.Name = "MenuAddGroup";
            this.MenuAddGroup.Size = new System.Drawing.Size(273, 32);
            this.MenuAddGroup.Text = "Thêm Nhóm";
            this.MenuAddGroup.Click += new System.EventHandler(this.MenuAddGroup_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(270, 6);
            // 
            // MenuAddUser
            // 
            this.MenuAddUser.Name = "MenuAddUser";
            this.MenuAddUser.Size = new System.Drawing.Size(273, 32);
            this.MenuAddUser.Text = "Thêm Người Dùng";
            this.MenuAddUser.Click += new System.EventHandler(this.MenuAddUser_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(270, 6);
            // 
            // MenuUpdate
            // 
            this.MenuUpdate.Name = "MenuUpdate";
            this.MenuUpdate.Size = new System.Drawing.Size(273, 32);
            this.MenuUpdate.Text = "Cập Nhật";
            this.MenuUpdate.Click += new System.EventHandler(this.MenuUpdate_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(270, 6);
            // 
            // MenuRole
            // 
            this.MenuRole.Name = "MenuRole";
            this.MenuRole.Size = new System.Drawing.Size(273, 32);
            this.MenuRole.Text = "Phân Quyền Chức Năng";
            this.MenuRole.Click += new System.EventHandler(this.MenuRole_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(270, 6);
            // 
            // MenuReport
            // 
            this.MenuReport.Name = "MenuReport";
            this.MenuReport.Size = new System.Drawing.Size(273, 32);
            this.MenuReport.Text = "Phân Quyền Báo Cáo";
            this.MenuReport.Click += new System.EventHandler(this.MenuReport_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(270, 6);
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(273, 32);
            this.MenuExit.Text = "Thoát";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // gvUser
            // 
            this.gvUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DISABLED,
            this.IDUSER,
            this.USERNAME,
            this.FULLNAME,
            this.MACTY,
            this.MADVI,
            this.ISGROUP,
            this.DELETE});
            this.gvUser.GridControl = this.gcUser;
            this.gvUser.Name = "gvUser";
            this.gvUser.OptionsView.ShowGroupPanel = false;
            this.gvUser.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvUser_CustomDrawCell);
            this.gvUser.DoubleClick += new System.EventHandler(this.gvUser_DoubleClick);
            // 
            // DISABLED
            // 
            this.DISABLED.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.DISABLED.AppearanceHeader.Options.UseFont = true;
            this.DISABLED.Caption = "DISABLED";
            this.DISABLED.FieldName = "DISABLED";
            this.DISABLED.MinWidth = 30;
            this.DISABLED.Name = "DISABLED";
            this.DISABLED.Visible = true;
            this.DISABLED.VisibleIndex = 0;
            this.DISABLED.Width = 112;
            // 
            // IDUSER
            // 
            this.IDUSER.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.IDUSER.AppearanceHeader.Options.UseFont = true;
            this.IDUSER.Caption = "IDUSER";
            this.IDUSER.FieldName = "IDUSER";
            this.IDUSER.MinWidth = 30;
            this.IDUSER.Name = "IDUSER";
            this.IDUSER.Visible = true;
            this.IDUSER.VisibleIndex = 1;
            this.IDUSER.Width = 112;
            // 
            // USERNAME
            // 
            this.USERNAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.USERNAME.AppearanceHeader.Options.UseFont = true;
            this.USERNAME.Caption = "USERNAME";
            this.USERNAME.FieldName = "USERNAME";
            this.USERNAME.MinWidth = 30;
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Visible = true;
            this.USERNAME.VisibleIndex = 3;
            this.USERNAME.Width = 112;
            // 
            // FULLNAME
            // 
            this.FULLNAME.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.FULLNAME.AppearanceHeader.Options.UseFont = true;
            this.FULLNAME.Caption = "FULLNAME";
            this.FULLNAME.FieldName = "FULLNAME";
            this.FULLNAME.MinWidth = 30;
            this.FULLNAME.Name = "FULLNAME";
            this.FULLNAME.Visible = true;
            this.FULLNAME.VisibleIndex = 4;
            this.FULLNAME.Width = 112;
            // 
            // MACTY
            // 
            this.MACTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.MACTY.AppearanceHeader.Options.UseFont = true;
            this.MACTY.Caption = "MACTY";
            this.MACTY.FieldName = "MACTY";
            this.MACTY.MinWidth = 30;
            this.MACTY.Name = "MACTY";
            this.MACTY.Visible = true;
            this.MACTY.VisibleIndex = 5;
            this.MACTY.Width = 112;
            // 
            // MADVI
            // 
            this.MADVI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.MADVI.AppearanceHeader.Options.UseFont = true;
            this.MADVI.Caption = "MADVI";
            this.MADVI.FieldName = "MADVI";
            this.MADVI.MinWidth = 30;
            this.MADVI.Name = "MADVI";
            this.MADVI.Visible = true;
            this.MADVI.VisibleIndex = 6;
            this.MADVI.Width = 112;
            // 
            // ISGROUP
            // 
            this.ISGROUP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.ISGROUP.AppearanceHeader.Options.UseFont = true;
            this.ISGROUP.Caption = "ISGROUP";
            this.ISGROUP.FieldName = "ISGROUP";
            this.ISGROUP.MinWidth = 30;
            this.ISGROUP.Name = "ISGROUP";
            this.ISGROUP.Visible = true;
            this.ISGROUP.VisibleIndex = 2;
            this.ISGROUP.Width = 112;
            // 
            // DELETE
            // 
            this.DELETE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.DELETE.AppearanceHeader.Options.UseFont = true;
            this.DELETE.Caption = "DELETE";
            this.DELETE.ColumnEdit = this.BtnDelete;
            this.DELETE.MinWidth = 30;
            this.DELETE.Name = "DELETE";
            this.DELETE.Visible = true;
            this.DELETE.VisibleIndex = 7;
            this.DELETE.Width = 112;
            // 
            // BtnDelete
            // 
            this.BtnDelete.AutoHeight = false;
            this.BtnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "userone.png");
            this.imageList1.Images.SetKeyName(1, "group.png");
            // 
            // FormUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 654);
            this.Controls.Add(this.gcUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FormUserManagement.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormUserManagement";
            this.Text = "Quản Lý Người Dùng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUser)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BtnGroup;
        private DevExpress.XtraBars.BarButtonItem BtnUser;
        private DevExpress.XtraBars.BarButtonItem BtnUpdate;
        private DevExpress.XtraBars.BarButtonItem BtnFucntion;
        private DevExpress.XtraBars.BarButtonItem BtnReport;
        private DevExpress.XtraBars.BarButtonItem BtnExit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup SysTem;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gcUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUser;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.Columns.GridColumn DISABLED;
        private DevExpress.XtraGrid.Columns.GridColumn IDUSER;
        private DevExpress.XtraGrid.Columns.GridColumn USERNAME;
        private DevExpress.XtraGrid.Columns.GridColumn FULLNAME;
        private DevExpress.XtraGrid.Columns.GridColumn MACTY;
        private DevExpress.XtraGrid.Columns.GridColumn MADVI;
        private DevExpress.XtraGrid.Columns.GridColumn ISGROUP;
        private DevExpress.XtraGrid.Columns.GridColumn DELETE;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit BtnDelete;
        private System.Windows.Forms.Panel panelNhom;
        private DevExpress.XtraEditors.LabelControl lbDONVI;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuAddGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuAddUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuRole;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MenuReport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem MenuUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
    }
}

