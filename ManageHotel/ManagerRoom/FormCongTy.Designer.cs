
namespace ManagerRoom
{
    partial class FormCongTy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCongTy));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsBtnFix = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPrint = new System.Windows.Forms.ToolStripButton();
            this.tsBtnCancel = new System.Windows.Forms.ToolStripButton();
            this.tsBtnExit = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPrints = new System.Windows.Forms.ToolStripButton();
            this.gridControlDS = new DevExpress.XtraGrid.GridControl();
            this.gridViewDS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DISABLED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MACTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENCTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIENTHOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FAX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControlCT = new DevExpress.XtraEditors.GroupControl();
            this.lbID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.checkBoxD = new System.Windows.Forms.CheckBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbFax = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCT)).BeginInit();
            this.groupControlCT.SuspendLayout();
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
            this.tsBtnPrint,
            this.tsBtnPrints,
            this.tsBtnCancel,
            this.tsBtnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1048, 58);
            this.toolStrip1.TabIndex = 0;
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
            // tsBtnPrint
            // 
            this.tsBtnPrint.Image = global::ManagerRoom.Properties.Resources.printblack1;
            this.tsBtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPrint.Name = "tsBtnPrint";
            this.tsBtnPrint.Size = new System.Drawing.Size(46, 53);
            this.tsBtnPrint.Text = "  In ";
            this.tsBtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnPrint.Click += new System.EventHandler(this.tsBtnPrint_Click);
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
            // tsBtnPrints
            // 
            this.tsBtnPrints.Image = global::ManagerRoom.Properties.Resources.print1;
            this.tsBtnPrints.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPrints.Name = "tsBtnPrints";
            this.tsBtnPrints.Size = new System.Drawing.Size(59, 53);
            this.tsBtnPrints.Text = "In DS";
            this.tsBtnPrints.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnPrints.Click += new System.EventHandler(this.tsBtnPrints_Click);
            // 
            // gridControlDS
            // 
            this.gridControlDS.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlDS.Location = new System.Drawing.Point(0, 58);
            this.gridControlDS.MainView = this.gridViewDS;
            this.gridControlDS.Name = "gridControlDS";
            this.gridControlDS.Size = new System.Drawing.Size(1048, 369);
            this.gridControlDS.TabIndex = 2;
            this.gridControlDS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDS});
            // 
            // gridViewDS
            // 
            this.gridViewDS.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DISABLED,
            this.MACTY,
            this.TENCTY,
            this.DIENTHOAI,
            this.EMAIL,
            this.FAX,
            this.DIACHI});
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
            // MACTY
            // 
            this.MACTY.Caption = "ID CÔNG TY";
            this.MACTY.FieldName = "MACTY";
            this.MACTY.MinWidth = 50;
            this.MACTY.Name = "MACTY";
            this.MACTY.Visible = true;
            this.MACTY.VisibleIndex = 1;
            this.MACTY.Width = 70;
            // 
            // TENCTY
            // 
            this.TENCTY.Caption = "TÊN CÔNG TY";
            this.TENCTY.FieldName = "TENCTY";
            this.TENCTY.MinWidth = 250;
            this.TENCTY.Name = "TENCTY";
            this.TENCTY.Visible = true;
            this.TENCTY.VisibleIndex = 2;
            this.TENCTY.Width = 250;
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.Caption = "ĐIỆN THOẠI";
            this.DIENTHOAI.FieldName = "DIENTHOAI";
            this.DIENTHOAI.MinWidth = 80;
            this.DIENTHOAI.Name = "DIENTHOAI";
            this.DIENTHOAI.Visible = true;
            this.DIENTHOAI.VisibleIndex = 3;
            this.DIENTHOAI.Width = 100;
            // 
            // EMAIL
            // 
            this.EMAIL.Caption = "EMAIL";
            this.EMAIL.FieldName = "EMAIL";
            this.EMAIL.MinWidth = 50;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Visible = true;
            this.EMAIL.VisibleIndex = 4;
            this.EMAIL.Width = 112;
            // 
            // FAX
            // 
            this.FAX.Caption = "FAX";
            this.FAX.FieldName = "FAX";
            this.FAX.MinWidth = 30;
            this.FAX.Name = "FAX";
            this.FAX.Visible = true;
            this.FAX.VisibleIndex = 5;
            this.FAX.Width = 112;
            // 
            // DIACHI
            // 
            this.DIACHI.Caption = "ĐỊA CHỈ";
            this.DIACHI.FieldName = "DIACHI";
            this.DIACHI.MinWidth = 200;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Visible = true;
            this.DIACHI.VisibleIndex = 6;
            this.DIACHI.Width = 200;
            // 
            // groupControlCT
            // 
            this.groupControlCT.Controls.Add(this.lbID);
            this.groupControlCT.Controls.Add(this.txtID);
            this.groupControlCT.Controls.Add(this.checkBoxD);
            this.groupControlCT.Controls.Add(this.txtAddress);
            this.groupControlCT.Controls.Add(this.lbAddress);
            this.groupControlCT.Controls.Add(this.txtPhone);
            this.groupControlCT.Controls.Add(this.lbEmail);
            this.groupControlCT.Controls.Add(this.txtEmail);
            this.groupControlCT.Controls.Add(this.lbFax);
            this.groupControlCT.Controls.Add(this.txtFax);
            this.groupControlCT.Controls.Add(this.lbPhone);
            this.groupControlCT.Controls.Add(this.txtName);
            this.groupControlCT.Controls.Add(this.lbName);
            this.groupControlCT.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlCT.Location = new System.Drawing.Point(0, 427);
            this.groupControlCT.Name = "groupControlCT";
            this.groupControlCT.Size = new System.Drawing.Size(1048, 207);
            this.groupControlCT.TabIndex = 3;
            this.groupControlCT.Text = "Thông Tin";
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
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(146, 156);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(831, 27);
            this.txtAddress.TabIndex = 9;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(65, 160);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(60, 19);
            this.lbAddress.TabIndex = 8;
            this.lbAddress.Text = "Địa Chỉ";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(146, 108);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(195, 27);
            this.txtPhone.TabIndex = 7;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(659, 112);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(48, 19);
            this.lbEmail.TabIndex = 6;
            this.lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(726, 108);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(251, 27);
            this.txtEmail.TabIndex = 5;
            // 
            // lbFax
            // 
            this.lbFax.AutoSize = true;
            this.lbFax.Location = new System.Drawing.Point(361, 112);
            this.lbFax.Name = "lbFax";
            this.lbFax.Size = new System.Drawing.Size(33, 19);
            this.lbFax.TabIndex = 4;
            this.lbFax.Text = "Fax";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(411, 108);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(220, 27);
            this.txtFax.TabIndex = 3;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(39, 112);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(86, 19);
            this.lbPhone.TabIndex = 2;
            this.lbPhone.Text = "Điện Thoại";
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
            // FormCongTy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 633);
            this.Controls.Add(this.groupControlCT);
            this.Controls.Add(this.gridControlDS);
            this.Controls.Add(this.toolStrip1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FormCongTy.IconOptions.Icon")));
            this.Name = "FormCongTy";
            this.Text = "Danh Mục Công Ty";
            this.Load += new System.EventHandler(this.FormCongTy_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCT)).EndInit();
            this.groupControlCT.ResumeLayout(false);
            this.groupControlCT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnAdd;
        private System.Windows.Forms.ToolStripButton tsBtnFix;
        private System.Windows.Forms.ToolStripButton tsBtnDelete;
        private System.Windows.Forms.ToolStripButton tsBtnSave;
        private System.Windows.Forms.ToolStripButton tsBtnCancel;
        private System.Windows.Forms.ToolStripButton tsBtnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraGrid.GridControl gridControlDS;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDS;
        private DevExpress.XtraEditors.GroupControl groupControlCT;
        private System.Windows.Forms.CheckBox checkBoxD;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbFax;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private DevExpress.XtraGrid.Columns.GridColumn DISABLED;
        private DevExpress.XtraGrid.Columns.GridColumn MACTY;
        private DevExpress.XtraGrid.Columns.GridColumn TENCTY;
        private DevExpress.XtraGrid.Columns.GridColumn DIENTHOAI;
        private DevExpress.XtraGrid.Columns.GridColumn EMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn FAX;
        private DevExpress.XtraGrid.Columns.GridColumn DIACHI;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ToolStripButton tsBtnPrint;
        private System.Windows.Forms.ToolStripButton tsBtnPrints;
    }
}