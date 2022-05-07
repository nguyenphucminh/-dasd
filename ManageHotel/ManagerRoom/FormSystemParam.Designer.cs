
namespace ManagerRoom
{
    partial class FormSystemParam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSystemParam));
            this.lbCty = new System.Windows.Forms.Label();
            this.lbDvi = new System.Windows.Forms.Label();
            this.cbbCongTy = new System.Windows.Forms.ComboBox();
            this.cbbDonVi = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // lbCty
            // 
            this.lbCty.AutoSize = true;
            this.lbCty.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lbCty.Location = new System.Drawing.Point(21, 23);
            this.lbCty.Name = "lbCty";
            this.lbCty.Size = new System.Drawing.Size(175, 19);
            this.lbCty.TabIndex = 0;
            this.lbCty.Text = "Công Ty - Chi Nhánh";
            // 
            // lbDvi
            // 
            this.lbDvi.AutoSize = true;
            this.lbDvi.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lbDvi.Location = new System.Drawing.Point(21, 111);
            this.lbDvi.Name = "lbDvi";
            this.lbDvi.Size = new System.Drawing.Size(158, 19);
            this.lbDvi.TabIndex = 1;
            this.lbDvi.Text = "Đơn Vị Trực Thuộc";
            // 
            // cbbCongTy
            // 
            this.cbbCongTy.FormattingEnabled = true;
            this.cbbCongTy.Location = new System.Drawing.Point(25, 60);
            this.cbbCongTy.Name = "cbbCongTy";
            this.cbbCongTy.Size = new System.Drawing.Size(414, 27);
            this.cbbCongTy.TabIndex = 2;
            this.cbbCongTy.SelectedIndexChanged += new System.EventHandler(this.cbbCongTy_SelectedIndexChanged);
            // 
            // cbbDonVi
            // 
            this.cbbDonVi.FormattingEnabled = true;
            this.cbbDonVi.Location = new System.Drawing.Point(25, 146);
            this.cbbDonVi.Name = "cbbDonVi";
            this.cbbDonVi.Size = new System.Drawing.Size(414, 27);
            this.cbbDonVi.TabIndex = 3;
            // 
            // btnConfirm
            // 
            this.btnConfirm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.ImageOptions.Image")));
            this.btnConfirm.Location = new System.Drawing.Point(84, 209);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(134, 46);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Xác Nhận";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnExit
            // 
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(259, 209);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 46);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormSystemParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 296);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cbbDonVi);
            this.Controls.Add(this.cbbCongTy);
            this.Controls.Add(this.lbDvi);
            this.Controls.Add(this.lbCty);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSystemParam";
            this.Text = "Xác Nhận Đơn Vị ";
            this.Load += new System.EventHandler(this.FormSystemParam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCty;
        private System.Windows.Forms.Label lbDvi;
        private System.Windows.Forms.ComboBox cbbCongTy;
        private System.Windows.Forms.ComboBox cbbDonVi;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraEditors.SimpleButton btnExit;
    }
}