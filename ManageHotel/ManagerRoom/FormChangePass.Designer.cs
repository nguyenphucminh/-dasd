
namespace ManagerRoom
{
    partial class FormChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangePass));
            this.gcInfoData = new DevExpress.XtraEditors.GroupControl();
            this.btnEyeHide = new DevExpress.XtraEditors.SimpleButton();
            this.btnEyeShow = new DevExpress.XtraEditors.SimpleButton();
            this.btnEyeHide2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnEyeShow2 = new DevExpress.XtraEditors.SimpleButton();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.newPass = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnCheckData = new System.Windows.Forms.Button();
            this.cbbDatabase = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbservername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfoData)).BeginInit();
            this.gcInfoData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcInfoData
            // 
            this.gcInfoData.ContentImage = global::ManagerRoom.Properties.Resources.img;
            this.gcInfoData.Controls.Add(this.btnEyeHide);
            this.gcInfoData.Controls.Add(this.btnEyeShow);
            this.gcInfoData.Controls.Add(this.btnEyeHide2);
            this.gcInfoData.Controls.Add(this.btnEyeShow2);
            this.gcInfoData.Controls.Add(this.txtNewPass);
            this.gcInfoData.Controls.Add(this.newPass);
            this.gcInfoData.Controls.Add(this.txtPassword);
            this.gcInfoData.Controls.Add(this.txtUsername);
            this.gcInfoData.Controls.Add(this.txtServer);
            this.gcInfoData.Controls.Add(this.btnSaveData);
            this.gcInfoData.Controls.Add(this.btnCheckData);
            this.gcInfoData.Controls.Add(this.cbbDatabase);
            this.gcInfoData.Controls.Add(this.label1);
            this.gcInfoData.Controls.Add(this.lbPass);
            this.gcInfoData.Controls.Add(this.lbUser);
            this.gcInfoData.Controls.Add(this.lbservername);
            this.gcInfoData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcInfoData.Location = new System.Drawing.Point(0, 12);
            this.gcInfoData.Name = "gcInfoData";
            this.gcInfoData.Size = new System.Drawing.Size(639, 378);
            this.gcInfoData.TabIndex = 1;
            this.gcInfoData.Text = "Connection Information";
            // 
            // btnEyeHide
            // 
            this.btnEyeHide.ImageOptions.Image = global::ManagerRoom.Properties.Resources.eye_unpass;
            this.btnEyeHide.Location = new System.Drawing.Point(491, 154);
            this.btnEyeHide.Name = "btnEyeHide";
            this.btnEyeHide.Size = new System.Drawing.Size(42, 27);
            this.btnEyeHide.TabIndex = 22;
            this.btnEyeHide.Click += new System.EventHandler(this.btnEyeHide_Click);
            // 
            // btnEyeShow
            // 
            this.btnEyeShow.ImageOptions.Image = global::ManagerRoom.Properties.Resources.eye_pass;
            this.btnEyeShow.Location = new System.Drawing.Point(491, 153);
            this.btnEyeShow.Name = "btnEyeShow";
            this.btnEyeShow.Size = new System.Drawing.Size(42, 27);
            this.btnEyeShow.TabIndex = 21;
            this.btnEyeShow.Click += new System.EventHandler(this.btnEyeShow_Click);
            // 
            // btnEyeHide2
            // 
            this.btnEyeHide2.ImageOptions.Image = global::ManagerRoom.Properties.Resources.eye_unpass;
            this.btnEyeHide2.Location = new System.Drawing.Point(491, 198);
            this.btnEyeHide2.Name = "btnEyeHide2";
            this.btnEyeHide2.Size = new System.Drawing.Size(42, 27);
            this.btnEyeHide2.TabIndex = 20;
            this.btnEyeHide2.Click += new System.EventHandler(this.btnEyeHide2_Click);
            // 
            // btnEyeShow2
            // 
            this.btnEyeShow2.ImageOptions.Image = global::ManagerRoom.Properties.Resources.eye_pass;
            this.btnEyeShow2.Location = new System.Drawing.Point(491, 198);
            this.btnEyeShow2.Name = "btnEyeShow2";
            this.btnEyeShow2.Size = new System.Drawing.Size(42, 27);
            this.btnEyeShow2.TabIndex = 19;
            this.btnEyeShow2.Click += new System.EventHandler(this.btnEyeShow2_Click);
            // 
            // txtNewPass
            // 
            this.txtNewPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNewPass.Location = new System.Drawing.Point(194, 198);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(339, 27);
            this.txtNewPass.TabIndex = 18;
            // 
            // newPass
            // 
            this.newPass.AutoSize = true;
            this.newPass.BackColor = System.Drawing.Color.Transparent;
            this.newPass.Location = new System.Drawing.Point(31, 198);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(118, 19);
            this.newPass.TabIndex = 17;
            this.newPass.Text = "New Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPassword.Location = new System.Drawing.Point(194, 154);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(339, 27);
            this.txtPassword.TabIndex = 16;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(194, 113);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(339, 27);
            this.txtUsername.TabIndex = 15;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(194, 68);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(339, 27);
            this.txtServer.TabIndex = 14;
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(402, 296);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(131, 45);
            this.btnSaveData.TabIndex = 13;
            this.btnSaveData.Text = "Save";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnCheckData
            // 
            this.btnCheckData.Location = new System.Drawing.Point(194, 296);
            this.btnCheckData.Name = "btnCheckData";
            this.btnCheckData.Size = new System.Drawing.Size(131, 45);
            this.btnCheckData.TabIndex = 12;
            this.btnCheckData.Text = "Check";
            this.btnCheckData.UseVisualStyleBackColor = true;
            this.btnCheckData.Click += new System.EventHandler(this.btnCheckData_Click);
            // 
            // cbbDatabase
            // 
            this.cbbDatabase.FormattingEnabled = true;
            this.cbbDatabase.Location = new System.Drawing.Point(194, 246);
            this.cbbDatabase.Name = "cbbDatabase";
            this.cbbDatabase.Size = new System.Drawing.Size(339, 27);
            this.cbbDatabase.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(31, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Database:  ";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.BackColor = System.Drawing.Color.Transparent;
            this.lbPass.Location = new System.Drawing.Point(31, 154);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(112, 19);
            this.lbPass.TabIndex = 4;
            this.lbPass.Text = "Old Password:";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.Location = new System.Drawing.Point(31, 113);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(96, 19);
            this.lbUser.TabIndex = 3;
            this.lbUser.Text = "User name: ";
            // 
            // lbservername
            // 
            this.lbservername.AutoSize = true;
            this.lbservername.BackColor = System.Drawing.Color.Transparent;
            this.lbservername.Location = new System.Drawing.Point(31, 71);
            this.lbservername.Name = "lbservername";
            this.lbservername.Size = new System.Drawing.Size(109, 19);
            this.lbservername.TabIndex = 0;
            this.lbservername.Text = "Server name: ";
            // 
            // FormChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 390);
            this.Controls.Add(this.gcInfoData);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FormChangePass.IconOptions.LargeImage")));
            this.Name = "FormChangePass";
            this.Text = "Change PassWord";
            this.Load += new System.EventHandler(this.FormChangePass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcInfoData)).EndInit();
            this.gcInfoData.ResumeLayout(false);
            this.gcInfoData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcInfoData;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnCheckData;
        private System.Windows.Forms.ComboBox cbbDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbservername;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label newPass;
        private DevExpress.XtraEditors.SimpleButton btnEyeShow2;
        private DevExpress.XtraEditors.SimpleButton btnEyeHide2;
        private DevExpress.XtraEditors.SimpleButton btnEyeHide;
        private DevExpress.XtraEditors.SimpleButton btnEyeShow;
    }
}