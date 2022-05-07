
namespace UserManagement
{
    partial class FormGroupUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGroupUser));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.TabGroup = new DevExpress.XtraTab.XtraTabControl();
            this.PageGroup = new DevExpress.XtraTab.XtraTabPage();
            this.txtDescribe = new System.Windows.Forms.TextBox();
            this.labelMota = new System.Windows.Forms.Label();
            this.txtNameGroup = new System.Windows.Forms.TextBox();
            this.labelTenNhom = new System.Windows.Forms.Label();
            this.PageMember = new DevExpress.XtraTab.XtraTabPage();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gcMember = new DevExpress.XtraGrid.GridControl();
            this.gvMember = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDUSER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FULLNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TabGroup)).BeginInit();
            this.TabGroup.SuspendLayout();
            this.PageGroup.SuspendLayout();
            this.PageMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // TabGroup
            // 
            this.TabGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabGroup.Location = new System.Drawing.Point(0, 0);
            this.TabGroup.Name = "TabGroup";
            this.TabGroup.SelectedTabPage = this.PageGroup;
            this.TabGroup.Size = new System.Drawing.Size(632, 343);
            this.TabGroup.TabIndex = 0;
            this.TabGroup.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.PageGroup,
            this.PageMember});
            // 
            // PageGroup
            // 
            this.PageGroup.Controls.Add(this.txtDescribe);
            this.PageGroup.Controls.Add(this.labelMota);
            this.PageGroup.Controls.Add(this.txtNameGroup);
            this.PageGroup.Controls.Add(this.labelTenNhom);
            this.PageGroup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("PageGroup.ImageOptions.Image")));
            this.PageGroup.Name = "PageGroup";
            this.PageGroup.Size = new System.Drawing.Size(630, 294);
            this.PageGroup.Text = "Thông Tin Nhóm";
            // 
            // txtDescribe
            // 
            this.txtDescribe.Location = new System.Drawing.Point(180, 147);
            this.txtDescribe.Name = "txtDescribe";
            this.txtDescribe.Size = new System.Drawing.Size(381, 27);
            this.txtDescribe.TabIndex = 3;
            // 
            // labelMota
            // 
            this.labelMota.AutoSize = true;
            this.labelMota.Location = new System.Drawing.Point(75, 147);
            this.labelMota.Name = "labelMota";
            this.labelMota.Size = new System.Drawing.Size(64, 19);
            this.labelMota.TabIndex = 2;
            this.labelMota.Text = "Mô Tả: ";
            // 
            // txtNameGroup
            // 
            this.txtNameGroup.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNameGroup.Location = new System.Drawing.Point(180, 82);
            this.txtNameGroup.Name = "txtNameGroup";
            this.txtNameGroup.Size = new System.Drawing.Size(381, 27);
            this.txtNameGroup.TabIndex = 1;
            // 
            // labelTenNhom
            // 
            this.labelTenNhom.AutoSize = true;
            this.labelTenNhom.Location = new System.Drawing.Point(75, 85);
            this.labelTenNhom.Name = "labelTenNhom";
            this.labelTenNhom.Size = new System.Drawing.Size(90, 19);
            this.labelTenNhom.TabIndex = 0;
            this.labelTenNhom.Text = "Tên Nhóm:";
            // 
            // PageMember
            // 
            this.PageMember.Controls.Add(this.btnAdd);
            this.PageMember.Controls.Add(this.gcMember);
            this.PageMember.ImageOptions.Image = global::UserManagement.Properties.Resources.userone;
            this.PageMember.Name = "PageMember";
            this.PageMember.Size = new System.Drawing.Size(630, 294);
            this.PageMember.Text = "Thành Viên";
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(5, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAdd.Size = new System.Drawing.Size(29, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gcMember
            // 
            this.gcMember.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gcMember.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcMember.Location = new System.Drawing.Point(0, 0);
            this.gcMember.MainView = this.gvMember;
            this.gcMember.Name = "gcMember";
            this.gcMember.Size = new System.Drawing.Size(630, 294);
            this.gcMember.TabIndex = 0;
            this.gcMember.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMember});
            // 
            // gvMember
            // 
            this.gvMember.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDUSER,
            this.USERNAME,
            this.FULLNAME});
            this.gvMember.GridControl = this.gcMember;
            this.gvMember.Name = "gvMember";
            this.gvMember.OptionsView.ShowGroupPanel = false;
            // 
            // IDUSER
            // 
            this.IDUSER.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.IDUSER.AppearanceHeader.Options.UseFont = true;
            this.IDUSER.Caption = "IDUSER";
            this.IDUSER.FieldName = "IDUSER";
            this.IDUSER.MaxWidth = 100;
            this.IDUSER.MinWidth = 100;
            this.IDUSER.Name = "IDUSER";
            this.IDUSER.Visible = true;
            this.IDUSER.VisibleIndex = 0;
            this.IDUSER.Width = 100;
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
            this.USERNAME.VisibleIndex = 1;
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
            this.FULLNAME.VisibleIndex = 2;
            this.FULLNAME.Width = 112;
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(355, 351);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 44);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(492, 351);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 44);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Đóng";
            // 
            // btnRemove
            // 
            this.btnRemove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.ImageOptions.Image")));
            this.btnRemove.Location = new System.Drawing.Point(218, 351);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(131, 44);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // FormGroupUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 404);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.TabGroup);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FormGroupUser.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGroupUser";
            this.Text = "Nhóm Người Dùng";
            this.Load += new System.EventHandler(this.FormGroupUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabGroup)).EndInit();
            this.TabGroup.ResumeLayout(false);
            this.PageGroup.ResumeLayout(false);
            this.PageGroup.PerformLayout();
            this.PageMember.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl TabGroup;
        private DevExpress.XtraTab.XtraTabPage PageGroup;
        private System.Windows.Forms.TextBox txtDescribe;
        private System.Windows.Forms.Label labelMota;
        private System.Windows.Forms.TextBox txtNameGroup;
        private System.Windows.Forms.Label labelTenNhom;
        private DevExpress.XtraTab.XtraTabPage PageMember;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.GridControl gcMember;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMember;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraGrid.Columns.GridColumn IDUSER;
        private DevExpress.XtraGrid.Columns.GridColumn USERNAME;
        private DevExpress.XtraGrid.Columns.GridColumn FULLNAME;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
    }
}