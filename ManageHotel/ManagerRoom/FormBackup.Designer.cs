
namespace ManagerRoom
{
    partial class FormBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBackup));
            this.TabControlBackup = new DevExpress.XtraTab.XtraTabControl();
            this.PageBackup = new DevExpress.XtraTab.XtraTabPage();
            this.btnSaveDataBackup = new DevExpress.XtraEditors.SimpleButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupDB = new DevExpress.XtraEditors.GroupControl();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.cbbDatabase = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbservername = new System.Windows.Forms.Label();
            this.txtPathBackup = new System.Windows.Forms.TextBox();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.PageRestore = new DevExpress.XtraTab.XtraTabPage();
            this.btnRestore = new DevExpress.XtraEditors.SimpleButton();
            this.txtPathRestore = new System.Windows.Forms.TextBox();
            this.btnBrowser = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlBackup)).BeginInit();
            this.TabControlBackup.SuspendLayout();
            this.PageBackup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDB)).BeginInit();
            this.groupDB.SuspendLayout();
            this.PageRestore.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlBackup
            // 
            this.TabControlBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlBackup.Location = new System.Drawing.Point(0, 0);
            this.TabControlBackup.Name = "TabControlBackup";
            this.TabControlBackup.SelectedTabPage = this.PageBackup;
            this.TabControlBackup.Size = new System.Drawing.Size(625, 467);
            this.TabControlBackup.TabIndex = 0;
            this.TabControlBackup.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.PageBackup,
            this.PageRestore});
            // 
            // PageBackup
            // 
            this.PageBackup.Controls.Add(this.btnSaveDataBackup);
            this.PageBackup.Controls.Add(this.progressBar1);
            this.PageBackup.Controls.Add(this.groupDB);
            this.PageBackup.Controls.Add(this.txtPathBackup);
            this.PageBackup.Controls.Add(this.btnBrowse);
            this.PageBackup.Name = "PageBackup";
            this.PageBackup.Size = new System.Drawing.Size(623, 431);
            this.PageBackup.Text = "BackUp";
            // 
            // btnSaveDataBackup
            // 
            this.btnSaveDataBackup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveDataBackup.ImageOptions.Image")));
            this.btnSaveDataBackup.Location = new System.Drawing.Point(240, 368);
            this.btnSaveDataBackup.Name = "btnSaveDataBackup";
            this.btnSaveDataBackup.Size = new System.Drawing.Size(141, 49);
            this.btnSaveDataBackup.TabIndex = 49;
            this.btnSaveDataBackup.Text = "Back Up";
            this.btnSaveDataBackup.Click += new System.EventHandler(this.btnSaveDataBackup_Click_1);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(28, 342);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(562, 10);
            this.progressBar1.TabIndex = 48;
            // 
            // groupDB
            // 
            this.groupDB.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupDB.CaptionImageOptions.Image")));
            this.groupDB.Controls.Add(this.txtPassword);
            this.groupDB.Controls.Add(this.txtUsername);
            this.groupDB.Controls.Add(this.txtServer);
            this.groupDB.Controls.Add(this.cbbDatabase);
            this.groupDB.Controls.Add(this.label1);
            this.groupDB.Controls.Add(this.lbPass);
            this.groupDB.Controls.Add(this.lbUser);
            this.groupDB.Controls.Add(this.lbservername);
            this.groupDB.Location = new System.Drawing.Point(28, 101);
            this.groupDB.Name = "groupDB";
            this.groupDB.Size = new System.Drawing.Size(562, 245);
            this.groupDB.TabIndex = 41;
            this.groupDB.Text = "Informantion Database ";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(135, 141);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(339, 27);
            this.txtPassword.TabIndex = 47;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(135, 100);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(339, 27);
            this.txtUsername.TabIndex = 46;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(135, 55);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(339, 27);
            this.txtServer.TabIndex = 45;
            // 
            // cbbDatabase
            // 
            this.cbbDatabase.FormattingEnabled = true;
            this.cbbDatabase.Location = new System.Drawing.Point(135, 186);
            this.cbbDatabase.Name = "cbbDatabase";
            this.cbbDatabase.Size = new System.Drawing.Size(339, 27);
            this.cbbDatabase.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(22, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Database:  ";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.BackColor = System.Drawing.Color.Transparent;
            this.lbPass.Location = new System.Drawing.Point(22, 142);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(82, 19);
            this.lbPass.TabIndex = 41;
            this.lbPass.Text = "Password:";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.Location = new System.Drawing.Point(22, 101);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(96, 19);
            this.lbUser.TabIndex = 40;
            this.lbUser.Text = "User name: ";
            // 
            // lbservername
            // 
            this.lbservername.AutoSize = true;
            this.lbservername.BackColor = System.Drawing.Color.Transparent;
            this.lbservername.Location = new System.Drawing.Point(22, 59);
            this.lbservername.Name = "lbservername";
            this.lbservername.Size = new System.Drawing.Size(109, 19);
            this.lbservername.TabIndex = 39;
            this.lbservername.Text = "Server name: ";
            // 
            // txtPathBackup
            // 
            this.txtPathBackup.Location = new System.Drawing.Point(163, 39);
            this.txtPathBackup.Name = "txtPathBackup";
            this.txtPathBackup.Size = new System.Drawing.Size(427, 27);
            this.txtPathBackup.TabIndex = 40;
            // 
            // btnBrowse
            // 
            this.btnBrowse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.ImageOptions.Image")));
            this.btnBrowse.Location = new System.Drawing.Point(28, 26);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(129, 51);
            this.btnBrowse.TabIndex = 39;
            this.btnBrowse.Text = "Browser";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // PageRestore
            // 
            this.PageRestore.Controls.Add(this.btnRestore);
            this.PageRestore.Controls.Add(this.txtPathRestore);
            this.PageRestore.Controls.Add(this.btnBrowser);
            this.PageRestore.Name = "PageRestore";
            this.PageRestore.Size = new System.Drawing.Size(623, 431);
            this.PageRestore.Text = "Restore";
            // 
            // btnRestore
            // 
            this.btnRestore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.Image")));
            this.btnRestore.Location = new System.Drawing.Point(238, 241);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(146, 50);
            this.btnRestore.TabIndex = 2;
            this.btnRestore.Text = "Restore";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // txtPathRestore
            // 
            this.txtPathRestore.Location = new System.Drawing.Point(170, 165);
            this.txtPathRestore.Name = "txtPathRestore";
            this.txtPathRestore.Size = new System.Drawing.Size(428, 27);
            this.txtPathRestore.TabIndex = 1;
            // 
            // btnBrowser
            // 
            this.btnBrowser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowser.ImageOptions.Image")));
            this.btnBrowser.Location = new System.Drawing.Point(35, 151);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(129, 54);
            this.btnBrowser.TabIndex = 0;
            this.btnBrowser.Text = "Browser";
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // FormBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 467);
            this.Controls.Add(this.TabControlBackup);
            this.Name = "FormBackup";
            this.Text = "Hệ Thống Sao Lưu Dữ Liệu";
            this.Load += new System.EventHandler(this.FormBackup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabControlBackup)).EndInit();
            this.TabControlBackup.ResumeLayout(false);
            this.PageBackup.ResumeLayout(false);
            this.PageBackup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDB)).EndInit();
            this.groupDB.ResumeLayout(false);
            this.groupDB.PerformLayout();
            this.PageRestore.ResumeLayout(false);
            this.PageRestore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl TabControlBackup;
        private DevExpress.XtraTab.XtraTabPage PageBackup;
        private System.Windows.Forms.TextBox txtPathBackup;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private DevExpress.XtraTab.XtraTabPage PageRestore;
        private DevExpress.XtraEditors.GroupControl groupDB;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.ComboBox cbbDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbservername;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtPathRestore;
        private DevExpress.XtraEditors.SimpleButton btnBrowser;
        private DevExpress.XtraEditors.SimpleButton btnSaveDataBackup;
        private DevExpress.XtraEditors.SimpleButton btnRestore;
    }
}