
namespace ManagerRoom
{
    partial class FormTangLau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTangLau));
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
            this.IDLAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControlCT = new DevExpress.XtraEditors.GroupControl();
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
            this.toolStrip1.Size = new System.Drawing.Size(576, 58);
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
            this.gridControlDS.Size = new System.Drawing.Size(576, 369);
            this.gridControlDS.TabIndex = 3;
            this.gridControlDS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDS});
            // 
            // gridViewDS
            // 
            this.gridViewDS.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DISABLED,
            this.IDLAU,
            this.TENLAU});
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
            // IDLAU
            // 
            this.IDLAU.Caption = "ID TẦNG";
            this.IDLAU.FieldName = "IDLAU";
            this.IDLAU.MinWidth = 50;
            this.IDLAU.Name = "IDLAU";
            this.IDLAU.Visible = true;
            this.IDLAU.VisibleIndex = 1;
            this.IDLAU.Width = 70;
            // 
            // TENLAU
            // 
            this.TENLAU.Caption = "TÊN TẦNG ";
            this.TENLAU.FieldName = "TENLAU";
            this.TENLAU.MinWidth = 250;
            this.TENLAU.Name = "TENLAU";
            this.TENLAU.Visible = true;
            this.TENLAU.VisibleIndex = 2;
            this.TENLAU.Width = 250;
            // 
            // groupControlCT
            // 
            this.groupControlCT.Controls.Add(this.txtName);
            this.groupControlCT.Controls.Add(this.lbName);
            this.groupControlCT.Controls.Add(this.checkBoxD);
            this.groupControlCT.Controls.Add(this.txtID);
            this.groupControlCT.Controls.Add(this.lbID);
            this.groupControlCT.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlCT.Location = new System.Drawing.Point(0, 427);
            this.groupControlCT.Name = "groupControlCT";
            this.groupControlCT.Size = new System.Drawing.Size(576, 216);
            this.groupControlCT.TabIndex = 4;
            this.groupControlCT.Text = "Thông Tin";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(69, 114);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(430, 27);
            this.txtName.TabIndex = 12;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(19, 118);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(36, 19);
            this.lbName.TabIndex = 11;
            this.lbName.Text = "Tên";
            // 
            // checkBoxD
            // 
            this.checkBoxD.AutoSize = true;
            this.checkBoxD.Location = new System.Drawing.Point(23, 181);
            this.checkBoxD.Name = "checkBoxD";
            this.checkBoxD.Size = new System.Drawing.Size(95, 23);
            this.checkBoxD.TabIndex = 10;
            this.checkBoxD.Text = "Disabled";
            this.checkBoxD.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(95, 53);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(430, 27);
            this.txtID.TabIndex = 1;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(19, 61);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(70, 19);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Mã Tầng";
            // 
            // FormTangLau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 643);
            this.Controls.Add(this.groupControlCT);
            this.Controls.Add(this.gridControlDS);
            this.Controls.Add(this.toolStrip1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FormTangLau.IconOptions.LargeImage")));
            this.Name = "FormTangLau";
            this.Text = "Quản Lý Tầng Lầu";
            this.Load += new System.EventHandler(this.FormTangLau_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn IDLAU;
        private DevExpress.XtraGrid.Columns.GridColumn TENLAU;
        private DevExpress.XtraEditors.GroupControl groupControlCT;
        private System.Windows.Forms.CheckBox checkBoxD;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
    }
}