
namespace ManagerRoom
{
    partial class FormThietBi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThietBi));
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
            this.IDTHIETBI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENTHIETBI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControlCT = new DevExpress.XtraEditors.GroupControl();
            this.lbMoney = new System.Windows.Forms.Label();
            this.spinMoney = new DevExpress.XtraEditors.SpinEdit();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.checkBoxD = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCT)).BeginInit();
            this.groupControlCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinMoney.Properties)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(849, 58);
            this.toolStrip1.TabIndex = 3;
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
            this.gridControlDS.Size = new System.Drawing.Size(849, 331);
            this.gridControlDS.TabIndex = 5;
            this.gridControlDS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDS});
            // 
            // gridViewDS
            // 
            this.gridViewDS.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DISABLED,
            this.IDTHIETBI,
            this.TENTHIETBI,
            this.DONGIA});
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
            // IDTHIETBI
            // 
            this.IDTHIETBI.Caption = "ID THIẾT BỊ";
            this.IDTHIETBI.FieldName = "IDTHIETBI";
            this.IDTHIETBI.MinWidth = 50;
            this.IDTHIETBI.Name = "IDTHIETBI";
            this.IDTHIETBI.Visible = true;
            this.IDTHIETBI.VisibleIndex = 1;
            this.IDTHIETBI.Width = 70;
            // 
            // TENTHIETBI
            // 
            this.TENTHIETBI.Caption = "TÊN THIẾT BỊ";
            this.TENTHIETBI.FieldName = "TENTHIETBI";
            this.TENTHIETBI.MinWidth = 30;
            this.TENTHIETBI.Name = "TENTHIETBI";
            this.TENTHIETBI.Visible = true;
            this.TENTHIETBI.VisibleIndex = 2;
            this.TENTHIETBI.Width = 112;
            // 
            // DONGIA
            // 
            this.DONGIA.Caption = "ĐƠN GIÁ";
            this.DONGIA.FieldName = "DONGIA";
            this.DONGIA.MinWidth = 250;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Visible = true;
            this.DONGIA.VisibleIndex = 3;
            this.DONGIA.Width = 250;
            // 
            // groupControlCT
            // 
            this.groupControlCT.Controls.Add(this.lbMoney);
            this.groupControlCT.Controls.Add(this.spinMoney);
            this.groupControlCT.Controls.Add(this.txtName);
            this.groupControlCT.Controls.Add(this.lbName);
            this.groupControlCT.Controls.Add(this.checkBoxD);
            this.groupControlCT.Controls.Add(this.txtID);
            this.groupControlCT.Controls.Add(this.lbID);
            this.groupControlCT.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlCT.Location = new System.Drawing.Point(0, 389);
            this.groupControlCT.Name = "groupControlCT";
            this.groupControlCT.Size = new System.Drawing.Size(849, 264);
            this.groupControlCT.TabIndex = 6;
            this.groupControlCT.Text = "Thông Tin";
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Location = new System.Drawing.Point(58, 130);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(66, 19);
            this.lbMoney.TabIndex = 17;
            this.lbMoney.Text = "Đơn Giá";
            // 
            // spinMoney
            // 
            this.spinMoney.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinMoney.Location = new System.Drawing.Point(140, 126);
            this.spinMoney.Name = "spinMoney";
            this.spinMoney.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinMoney.Size = new System.Drawing.Size(183, 28);
            this.spinMoney.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(457, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(330, 27);
            this.txtName.TabIndex = 12;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(387, 62);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(36, 19);
            this.lbName.TabIndex = 11;
            this.lbName.Text = "Tên";
            // 
            // checkBoxD
            // 
            this.checkBoxD.AutoSize = true;
            this.checkBoxD.Location = new System.Drawing.Point(391, 131);
            this.checkBoxD.Name = "checkBoxD";
            this.checkBoxD.Size = new System.Drawing.Size(95, 23);
            this.checkBoxD.TabIndex = 10;
            this.checkBoxD.Text = "Disabled";
            this.checkBoxD.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(140, 58);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(183, 27);
            this.txtID.TabIndex = 1;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(19, 62);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(88, 19);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Mã Thiết Bị";
            // 
            // FormThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 607);
            this.Controls.Add(this.groupControlCT);
            this.Controls.Add(this.gridControlDS);
            this.Controls.Add(this.toolStrip1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FormThietBi.IconOptions.Icon")));
            this.Name = "FormThietBi";
            this.Text = "Quản Lý Thiết Bị";
            this.Load += new System.EventHandler(this.FormThietBi_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCT)).EndInit();
            this.groupControlCT.ResumeLayout(false);
            this.groupControlCT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinMoney.Properties)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn IDTHIETBI;
        private DevExpress.XtraGrid.Columns.GridColumn TENTHIETBI;
        private DevExpress.XtraGrid.Columns.GridColumn DONGIA;
        private DevExpress.XtraEditors.GroupControl groupControlCT;
        private System.Windows.Forms.Label lbMoney;
        private DevExpress.XtraEditors.SpinEdit spinMoney;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.CheckBox checkBoxD;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
    }
}