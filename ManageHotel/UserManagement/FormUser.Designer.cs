
namespace UserManagement
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.TabUser = new DevExpress.XtraTab.XtraTabControl();
            this.PageUsers = new DevExpress.XtraTab.XtraTabPage();
            this.btnEyeHide2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnEyeShow2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnEyeHide = new DevExpress.XtraEditors.SimpleButton();
            this.btnEyeShow = new DevExpress.XtraEditors.SimpleButton();
            this.lbDisable = new System.Windows.Forms.Label();
            this.checkBoxDisable = new System.Windows.Forms.CheckBox();
            this.txtResetPass = new System.Windows.Forms.TextBox();
            this.lbPassReset = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.labelDangNhap = new System.Windows.Forms.Label();
            this.PageGroup = new DevExpress.XtraTab.XtraTabPage();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gcMember = new DevExpress.XtraGrid.GridControl();
            this.gvMember = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDUSER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FULLNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TabUser)).BeginInit();
            this.TabUser.SuspendLayout();
            this.PageUsers.SuspendLayout();
            this.PageGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // TabUser
            // 
            this.TabUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabUser.Location = new System.Drawing.Point(0, 0);
            this.TabUser.Name = "TabUser";
            this.TabUser.SelectedTabPage = this.PageUsers;
            this.TabUser.Size = new System.Drawing.Size(638, 343);
            this.TabUser.TabIndex = 1;
            this.TabUser.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.PageUsers,
            this.PageGroup});
            // 
            // PageUsers
            // 
            this.PageUsers.Controls.Add(this.btnEyeHide2);
            this.PageUsers.Controls.Add(this.btnEyeShow2);
            this.PageUsers.Controls.Add(this.btnEyeHide);
            this.PageUsers.Controls.Add(this.btnEyeShow);
            this.PageUsers.Controls.Add(this.lbDisable);
            this.PageUsers.Controls.Add(this.checkBoxDisable);
            this.PageUsers.Controls.Add(this.txtResetPass);
            this.PageUsers.Controls.Add(this.lbPassReset);
            this.PageUsers.Controls.Add(this.txtPass);
            this.PageUsers.Controls.Add(this.lbPass);
            this.PageUsers.Controls.Add(this.txtFullName);
            this.PageUsers.Controls.Add(this.lbHoTen);
            this.PageUsers.Controls.Add(this.txtUserName);
            this.PageUsers.Controls.Add(this.labelDangNhap);
            this.PageUsers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("PageUsers.ImageOptions.Image")));
            this.PageUsers.Name = "PageUsers";
            this.PageUsers.Size = new System.Drawing.Size(636, 294);
            this.PageUsers.Text = "Thông Tin User";
            // 
            // btnEyeHide2
            // 
            this.btnEyeHide2.ImageOptions.Image = global::UserManagement.Properties.Resources.eye_unpass;
            this.btnEyeHide2.Location = new System.Drawing.Point(536, 183);
            this.btnEyeHide2.Name = "btnEyeHide2";
            this.btnEyeHide2.Size = new System.Drawing.Size(42, 27);
            this.btnEyeHide2.TabIndex = 12;
            this.btnEyeHide2.Click += new System.EventHandler(this.btnEyeHide2_Click);
            // 
            // btnEyeShow2
            // 
            this.btnEyeShow2.ImageOptions.Image = global::UserManagement.Properties.Resources.eye_pass;
            this.btnEyeShow2.Location = new System.Drawing.Point(536, 183);
            this.btnEyeShow2.Name = "btnEyeShow2";
            this.btnEyeShow2.Size = new System.Drawing.Size(42, 27);
            this.btnEyeShow2.TabIndex = 11;
            this.btnEyeShow2.Click += new System.EventHandler(this.btnEyeShow2_Click);
            // 
            // btnEyeHide
            // 
            this.btnEyeHide.ImageOptions.Image = global::UserManagement.Properties.Resources.eye_unpass;
            this.btnEyeHide.Location = new System.Drawing.Point(536, 128);
            this.btnEyeHide.Name = "btnEyeHide";
            this.btnEyeHide.Size = new System.Drawing.Size(42, 27);
            this.btnEyeHide.TabIndex = 10;
            this.btnEyeHide.Click += new System.EventHandler(this.btnEyeHide_Click);
            // 
            // btnEyeShow
            // 
            this.btnEyeShow.ImageOptions.Image = global::UserManagement.Properties.Resources.eye_pass;
            this.btnEyeShow.Location = new System.Drawing.Point(536, 128);
            this.btnEyeShow.Name = "btnEyeShow";
            this.btnEyeShow.Size = new System.Drawing.Size(42, 27);
            this.btnEyeShow.TabIndex = 9;
            this.btnEyeShow.Click += new System.EventHandler(this.btnEyeShow_Click);
            // 
            // lbDisable
            // 
            this.lbDisable.AutoSize = true;
            this.lbDisable.Location = new System.Drawing.Point(46, 239);
            this.lbDisable.Name = "lbDisable";
            this.lbDisable.Size = new System.Drawing.Size(114, 19);
            this.lbDisable.TabIndex = 8;
            this.lbDisable.Text = "Vô Hiệu Hóa : ";
            // 
            // checkBoxDisable
            // 
            this.checkBoxDisable.AutoSize = true;
            this.checkBoxDisable.Location = new System.Drawing.Point(197, 237);
            this.checkBoxDisable.Name = "checkBoxDisable";
            this.checkBoxDisable.Size = new System.Drawing.Size(22, 21);
            this.checkBoxDisable.TabIndex = 6;
            this.checkBoxDisable.UseVisualStyleBackColor = true;
            // 
            // txtResetPass
            // 
            this.txtResetPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtResetPass.Location = new System.Drawing.Point(197, 183);
            this.txtResetPass.Name = "txtResetPass";
            this.txtResetPass.PasswordChar = '*';
            this.txtResetPass.Size = new System.Drawing.Size(381, 27);
            this.txtResetPass.TabIndex = 7;
            // 
            // lbPassReset
            // 
            this.lbPassReset.AutoSize = true;
            this.lbPassReset.Location = new System.Drawing.Point(46, 186);
            this.lbPassReset.Name = "lbPassReset";
            this.lbPassReset.Size = new System.Drawing.Size(120, 19);
            this.lbPassReset.TabIndex = 6;
            this.lbPassReset.Text = "Mật Khẩu Mới : ";
            // 
            // txtPass
            // 
            this.txtPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPass.Location = new System.Drawing.Point(197, 128);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(381, 27);
            this.txtPass.TabIndex = 5;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(46, 128);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(85, 19);
            this.lbPass.TabIndex = 4;
            this.lbPass.Text = "Mật Khẩu :";
            // 
            // txtFullName
            // 
            this.txtFullName.ForeColor = System.Drawing.Color.Silver;
            this.txtFullName.Location = new System.Drawing.Point(197, 76);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(381, 27);
            this.txtFullName.TabIndex = 3;
            this.txtFullName.Text = "FULLNAME";
            this.txtFullName.Enter += new System.EventHandler(this.txtFullName_Enter);
            this.txtFullName.Leave += new System.EventHandler(this.txtFullName_Leave);
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(46, 76);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(72, 19);
            this.lbHoTen.TabIndex = 2;
            this.lbHoTen.Text = "Họ Tên :";
            // 
            // txtUserName
            // 
            this.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUserName.ForeColor = System.Drawing.Color.Silver;
            this.txtUserName.Location = new System.Drawing.Point(197, 23);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(381, 27);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "USERNAME";
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // labelDangNhap
            // 
            this.labelDangNhap.AutoSize = true;
            this.labelDangNhap.Location = new System.Drawing.Point(46, 26);
            this.labelDangNhap.Name = "labelDangNhap";
            this.labelDangNhap.Size = new System.Drawing.Size(131, 19);
            this.labelDangNhap.TabIndex = 0;
            this.labelDangNhap.Text = "Tên Đăng Nhập :";
            // 
            // PageGroup
            // 
            this.PageGroup.Controls.Add(this.btnAdd);
            this.PageGroup.Controls.Add(this.gcMember);
            this.PageGroup.ImageOptions.Image = global::UserManagement.Properties.Resources.group;
            this.PageGroup.Name = "PageGroup";
            this.PageGroup.Size = new System.Drawing.Size(636, 294);
            this.PageGroup.Text = "Nhóm";
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(6, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAdd.Size = new System.Drawing.Size(22, 30);
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
            this.gcMember.Size = new System.Drawing.Size(636, 294);
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
            // btnExit
            // 
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(500, 351);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 44);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Đóng";
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(363, 351);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 44);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.ImageOptions.Image")));
            this.btnRemove.Location = new System.Drawing.Point(226, 351);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(131, 44);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 402);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.TabUser);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FormUser.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUser";
            this.Text = "Thông Tin Người Dùng";
            this.Load += new System.EventHandler(this.FormUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabUser)).EndInit();
            this.TabUser.ResumeLayout(false);
            this.PageUsers.ResumeLayout(false);
            this.PageUsers.PerformLayout();
            this.PageGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl TabUser;
        private DevExpress.XtraTab.XtraTabPage PageUsers;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label labelDangNhap;
        private DevExpress.XtraTab.XtraTabPage PageGroup;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.GridControl gcMember;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMember;
        private DevExpress.XtraGrid.Columns.GridColumn IDUSER;
        private DevExpress.XtraGrid.Columns.GridColumn USERNAME;
        private DevExpress.XtraGrid.Columns.GridColumn FULLNAME;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.TextBox txtResetPass;
        private System.Windows.Forms.Label lbPassReset;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbDisable;
        private System.Windows.Forms.CheckBox checkBoxDisable;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.SimpleButton btnEyeHide;
        private DevExpress.XtraEditors.SimpleButton btnEyeShow;
        private DevExpress.XtraEditors.SimpleButton btnEyeHide2;
        private DevExpress.XtraEditors.SimpleButton btnEyeShow2;
    }
}