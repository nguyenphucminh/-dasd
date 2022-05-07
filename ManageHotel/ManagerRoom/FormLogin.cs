using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using DataLayer;
using System.Threading;

namespace ManagerRoom
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        SYS_Param sysparam;
        SYS_User sysUser;
        BinaryFormatter bf;
        FileStream fs;
        WriteLog wlg = new WriteLog();

        Task ProcessImport(List<string> data, IProgress<ProgressReport> progress)
        {
            var index = 0;
            var totalProgress = data.Count();
            var progressReport = new ProgressReport();
            return Task.Run(() =>
            {
                for (int i = 0; i <= totalProgress; i++)
                {
                    progressReport.PercentComplete = index++ * 100 / totalProgress;
                    progress.Report(progressReport);
                    Thread.Sleep(10);
                }
            });
        }



        private void FormLogin_Load(object sender, EventArgs e)
        {
            sysUser = new SYS_User();
            bf = new BinaryFormatter();
            fs = File.Open("sysparam.ini", FileMode.Open, FileAccess.Read);
            sysparam = bf.Deserialize(fs) as SYS_Param;
            if (sysparam.macty == null || sysparam.madvi == null)
                return;
            MyFunction._macty = sysparam.macty;
            MyFunction._madvi = sysparam.madvi;
            this.Text = sysparam.macty + " - " + sysparam.madvi;
            lbProgress.Visible = false;
            imgLoading.Visible = false;
            progressBarLogin.Visible = false;
            fs.Close();
        }
        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (sysparam.macty == null || sysparam.madvi == null)
            {
                return;
            }    
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("Tên Đăng nhập không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool us = sysUser.CheckUserExist(sysparam.macty, sysparam.madvi, txtUserName.Text);
            if (us == false)
            {
                MessageBox.Show("Tên Đăng nhập không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string pass = Encryptor.Encrypt(txtPassWord.Text, "qwert@123!poiuy", true);
            tb_SYS_USERS user = sysUser.GetItem(txtUserName.Text, sysparam.macty, sysparam.madvi);
            if (user.PASSWD.Equals(pass))
            {
                lbProgress.Visible = true;
                imgLoading.Visible = true;
                progressBarLogin.Visible = true;
                List<string> list = new List<string>();
                for (int i = 0; i <= 500; i++)
                {
                    list.Add(i.ToString());
                }
                lbProgress.Text = "Working . . . ";
                var progressReport = new Progress<ProgressReport>();
                progressReport.ProgressChanged += (x, report) =>
                {
                    lbProgress.Text = string.Format("Working . . . {0}%", report.PercentComplete);
                    progressBarLogin.Value = report.PercentComplete;
                    progressBarLogin.Update();
                };

                await ProcessImport(list, progressReport);
                this.Hide();
                FormMain frm = new FormMain(user);
                frm.ShowDialog();



                string path = (AppDomain.CurrentDomain.BaseDirectory + "LogFile.txt");
                if (!System.IO.File.Exists(path))
                {
                    System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + "LogFile.txt");

                }
                wlg.Fucntion_WriteLog(txtUserName.Text.ToString(), "Exit");
            }
            else
            {
                MessageBox.Show("Sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            ToolTip buttonToolTip = new ToolTip();
            buttonToolTip.ToolTipTitle = "Email";
            buttonToolTip.UseFading = true;
            buttonToolTip.UseAnimation = true;
            buttonToolTip.IsBalloon = true;
            buttonToolTip.ShowAlways = true;
            buttonToolTip.AutoPopDelay = 5000;
            buttonToolTip.InitialDelay = 1000;
            buttonToolTip.ReshowDelay = 500;
            buttonToolTip.SetToolTip(txtUserName, "admin");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(pictureBox3, "Enter UserName");
        }

        private void txtPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUserName.Text.Trim() == "")
                {
                    MessageBox.Show("Tên Đăng nhập không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtPassWord.Text.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                bool us = sysUser.CheckUserExist(sysparam.macty, sysparam.madvi, txtUserName.Text);
                if (us == false)
                {
                    MessageBox.Show("Tên Đăng nhập không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string pass = Encryptor.Encrypt(txtPassWord.Text, "qwert@123!poiuy", true);
                tb_SYS_USERS user = sysUser.GetItem(txtUserName.Text, sysparam.macty, sysparam.madvi);
                if (user.PASSWD.Equals(pass))
                {
                    FormMain frm = new FormMain(user);
                    frm.ShowDialog();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Sai mật khẩu vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }
    }
}