
namespace ManagerRoom
{
    partial class FormLoaiPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoaiPhong));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsBtnFix = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsBtnCancel = new System.Windows.Forms.ToolStripButton();
            this.tsBtnExit = new System.Windows.Forms.ToolStripButton();
            this.gridControlDS = new DevExpress.XtraGrid.GridControl();
            this.gridViewDS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DISABLED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDLOAIPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLOAIPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SONGUOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOGIUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControlCT = new DevExpress.XtraEditors.GroupControl();
            this.spinMoney = new DevExpress.XtraEditors.SpinEdit();
            this.spinBed = new DevExpress.XtraEditors.SpinEdit();
            this.spinPeople = new DevExpress.XtraEditors.SpinEdit();
            this.lbID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.checkBoxD = new System.Windows.Forms.CheckBox();
            this.lbMoney = new System.Windows.Forms.Label();
            this.lbBed = new System.Windows.Forms.Label();
            this.lbPeople = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCT)).BeginInit();
            this.groupControlCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinMoney.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinPeople.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tsBtnAdd,
            this.tsBtnFix,
            this.tsBtnDelete,
            this.tsBtnSave,
            this.tsBtnCancel,
            this.tsBtnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1043, 58);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // tsBtnAdd
            // 
            this.tsBtnAdd.Image = global::ManagerRoom.Properties.Resources.add;
            this.tsBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAdd.Name = "tsBtnAdd";
            this.tsBtnAdd.Size = new System.Drawing.Size(60, 53);
            this.tsBtnAdd.Text = "Thêm";
            this.tsBtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnAdd.Click += new System.EventHandler(this.tsBtnAdd_Click);
            // 
            // tsBtnFix
            // 
            this.tsBtnFix.Image = global::ManagerRoom.Properties.Resources.edit;
            this.tsBtnFix.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFix.Name = "tsBtnFix";
            this.tsBtnFix.Size = new System.Drawing.Size(46, 53);
            this.tsBtnFix.Text = "Sửa";
            this.tsBtnFix.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnFix.Click += new System.EventHandler(this.tsBtnFix_Click);
            // 
            // tsBtnDelete
            // 
            this.tsBtnDelete.Image = global::ManagerRoom.Properties.Resources.delete32;
            this.tsBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDelete.Name = "tsBtnDelete";
            this.tsBtnDelete.Size = new System.Drawing.Size(47, 53);
            this.tsBtnDelete.Text = "Xóa";
            this.tsBtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnDelete.Click += new System.EventHandler(this.tsBtnDelete_Click);
            // 
            // tsBtnSave
            // 
            this.tsBtnSave.Image = global::ManagerRoom.Properties.Resources.save32;
            this.tsBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSave.Name = "tsBtnSave";
            this.tsBtnSave.Size = new System.Drawing.Size(45, 53);
            this.tsBtnSave.Text = "Lưu";
            this.tsBtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnSave.Click += new System.EventHandler(this.tsBtnSave_Click);
            // 
            // tsBtnCancel
            // 
            this.tsBtnCancel.Image = global::ManagerRoom.Properties.Resources.cancel;
            this.tsBtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCancel.Name = "tsBtnCancel";
            this.tsBtnCancel.Size = new System.Drawing.Size(48, 53);
            this.tsBtnCancel.Text = "Hủy";
            this.tsBtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnCancel.Click += new System.EventHandler(this.tsBtnCancel_Click);
            // 
            // tsBtnExit
            // 
            this.tsBtnExit.Image = global::ManagerRoom.Properties.Resources.exit32;
            this.tsBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnExit.Name = "tsBtnExit";
            this.tsBtnExit.Size = new System.Drawing.Size(66, 53);
            this.tsBtnExit.Text = " Thoát";
            this.tsBtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnExit.Click += new System.EventHandler(this.tsBtnExit_Click);
            // 
            // gridControlDS
            // 
            this.gridControlDS.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlDS.Location = new System.Drawing.Point(0, 58);
            this.gridControlDS.MainView = this.gridViewDS;
            this.gridControlDS.Name = "gridControlDS";
            this.gridControlDS.Size = new System.Drawing.Size(1043, 369);
            this.gridControlDS.TabIndex = 3;
            this.gridControlDS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDS});
            // 
            // gridViewDS
            // 
            this.gridViewDS.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DISABLED,
            this.IDLOAIPHONG,
            this.TENLOAIPHONG,
            this.DONGIA,
            this.SONGUOI,
            this.SOGIUONG});
            this.gridViewDS.GridControl = this.gridControlDS;
            this.gridViewDS.Name = "gridViewDS";
            this.gridViewDS.OptionsView.ShowGroupPanel = false;
            this.gridViewDS.Click += new System.EventHandler(this.gridViewDS_Click);
            // 
            // DISABLED
            // 
            this.DISABLED.Caption = "ACT";
            this.DISABLED.FieldName = "DISABLED";
            this.DISABLED.MinWidth = 30;
            this.DISABLED.Name = "DISABLED";
            this.DISABLED.Visible = true;
            this.DISABLED.VisibleIndex = 0;
            this.DISABLED.Width = 40;
            // 
            // IDLOAIPHONG
            // 
            this.IDLOAIPHONG.Caption = "ID LOẠI PHÒNG";
            this.IDLOAIPHONG.FieldName = "IDLOAIPHONG";
            this.IDLOAIPHONG.MinWidth = 50;
            this.IDLOAIPHONG.Name = "IDLOAIPHONG";
            this.IDLOAIPHONG.Visible = true;
            this.IDLOAIPHONG.VisibleIndex = 1;
            this.IDLOAIPHONG.Width = 70;
            // 
            // TENLOAIPHONG
            // 
            this.TENLOAIPHONG.Caption = "TÊN LOẠI PHÒNG";
            this.TENLOAIPHONG.FieldName = "TENLOAIPHONG";
            this.TENLOAIPHONG.MinWidth = 250;
            this.TENLOAIPHONG.Name = "TENLOAIPHONG";
            this.TENLOAIPHONG.Visible = true;
            this.TENLOAIPHONG.VisibleIndex = 2;
            this.TENLOAIPHONG.Width = 250;
            // 
            // DONGIA
            // 
            this.DONGIA.Caption = "ĐƠN GIÁ";
            this.DONGIA.FieldName = "DONGIA";
            this.DONGIA.MinWidth = 80;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Visible = true;
            this.DONGIA.VisibleIndex = 3;
            this.DONGIA.Width = 100;
            // 
            // SONGUOI
            // 
            this.SONGUOI.Caption = "SỐ NGƯỜI";
            this.SONGUOI.FieldName = "SONGUOI";
            this.SONGUOI.MinWidth = 50;
            this.SONGUOI.Name = "SONGUOI";
            this.SONGUOI.Visible = true;
            this.SONGUOI.VisibleIndex = 4;
            this.SONGUOI.Width = 112;
            // 
            // SOGIUONG
            // 
            this.SOGIUONG.Caption = "SỐ GIƯỜNG";
            this.SOGIUONG.FieldName = "SOGIUONG";
            this.SOGIUONG.MinWidth = 30;
            this.SOGIUONG.Name = "SOGIUONG";
            this.SOGIUONG.Visible = true;
            this.SOGIUONG.VisibleIndex = 5;
            this.SOGIUONG.Width = 112;
            // 
            // groupControlCT
            // 
            this.groupControlCT.Controls.Add(this.spinMoney);
            this.groupControlCT.Controls.Add(this.spinBed);
            this.groupControlCT.Controls.Add(this.spinPeople);
            this.groupControlCT.Controls.Add(this.lbID);
            this.groupControlCT.Controls.Add(this.txtID);
            this.groupControlCT.Controls.Add(this.checkBoxD);
            this.groupControlCT.Controls.Add(this.lbMoney);
            this.groupControlCT.Controls.Add(this.lbBed);
            this.groupControlCT.Controls.Add(this.lbPeople);
            this.groupControlCT.Controls.Add(this.txtName);
            this.groupControlCT.Controls.Add(this.lbName);
            this.groupControlCT.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlCT.Location = new System.Drawing.Point(0, 427);
            this.groupControlCT.Name = "groupControlCT";
            this.groupControlCT.Size = new System.Drawing.Size(1043, 175);
            this.groupControlCT.TabIndex = 4;
            this.groupControlCT.Text = "Thông Tin";
            // 
            // spinMoney
            // 
            this.spinMoney.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinMoney.Location = new System.Drawing.Point(782, 116);
            this.spinMoney.Name = "spinMoney";
            this.spinMoney.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinMoney.Size = new System.Drawing.Size(195, 28);
            this.spinMoney.TabIndex = 15;
            // 
            // spinBed
            // 
            this.spinBed.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinBed.Location = new System.Drawing.Point(462, 116);
            this.spinBed.Name = "spinBed";
            this.spinBed.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinBed.Size = new System.Drawing.Size(195, 28);
            this.spinBed.TabIndex = 14;
            // 
            // spinPeople
            // 
            this.spinPeople.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinPeople.Location = new System.Drawing.Point(146, 116);
            this.spinPeople.Name = "spinPeople";
            this.spinPeople.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinPeople.Size = new System.Drawing.Size(195, 28);
            this.spinPeople.TabIndex = 13;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(34, 65);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(91, 19);
            this.lbID.TabIndex = 12;
            this.lbID.Text = "ID Công Ty";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(146, 61);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(195, 27);
            this.txtID.TabIndex = 11;
            // 
            // checkBoxD
            // 
            this.checkBoxD.AutoSize = true;
            this.checkBoxD.Location = new System.Drawing.Point(882, 63);
            this.checkBoxD.Name = "checkBoxD";
            this.checkBoxD.Size = new System.Drawing.Size(95, 23);
            this.checkBoxD.TabIndex = 10;
            this.checkBoxD.Text = "Disabled";
            this.checkBoxD.UseVisualStyleBackColor = true;
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Location = new System.Drawing.Point(688, 121);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(66, 19);
            this.lbMoney.TabIndex = 6;
            this.lbMoney.Text = "Đơn Giá";
            // 
            // lbBed
            // 
            this.lbBed.AutoSize = true;
            this.lbBed.Location = new System.Drawing.Point(361, 121);
            this.lbBed.Name = "lbBed";
            this.lbBed.Size = new System.Drawing.Size(84, 19);
            this.lbBed.TabIndex = 4;
            this.lbBed.Text = "Số Giường";
            // 
            // lbPeople
            // 
            this.lbPeople.AutoSize = true;
            this.lbPeople.Location = new System.Drawing.Point(39, 121);
            this.lbPeople.Name = "lbPeople";
            this.lbPeople.Size = new System.Drawing.Size(75, 19);
            this.lbPeople.TabIndex = 2;
            this.lbPeople.Text = "Số Người";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(411, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(430, 27);
            this.txtName.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(361, 65);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(36, 19);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Tên";
            // 
            // FormLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 601);
            this.Controls.Add(this.groupControlCT);
            this.Controls.Add(this.gridControlDS);
            this.Controls.Add(this.toolStrip1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FormLoaiPhong.IconOptions.Icon")));
            this.Name = "FormLoaiPhong";
            this.Text = "Quản Lý Loại Phòng";
            this.Load += new System.EventHandler(this.FormLoaiPhong_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCT)).EndInit();
            this.groupControlCT.ResumeLayout(false);
            this.groupControlCT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinMoney.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinPeople.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnAdd;
        private System.Windows.Forms.ToolStripButton tsBtnFix;
        private System.Windows.Forms.ToolStripButton tsBtnDelete;
        private System.Windows.Forms.ToolStripButton tsBtnSave;
        private System.Windows.Forms.ToolStripButton tsBtnCancel;
        private System.Windows.Forms.ToolStripButton tsBtnExit;
        private DevExpress.XtraGrid.GridControl gridControlDS;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDS;
        private DevExpress.XtraGrid.Columns.GridColumn DISABLED;
        private DevExpress.XtraGrid.Columns.GridColumn IDLOAIPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn TENLOAIPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn DONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn SONGUOI;
        private DevExpress.XtraGrid.Columns.GridColumn SOGIUONG;
        private DevExpress.XtraEditors.GroupControl groupControlCT;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox checkBoxD;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.Label lbBed;
        private System.Windows.Forms.Label lbPeople;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private DevExpress.XtraEditors.SpinEdit spinMoney;
        private DevExpress.XtraEditors.SpinEdit spinBed;
        private DevExpress.XtraEditors.SpinEdit spinPeople;
    }
}