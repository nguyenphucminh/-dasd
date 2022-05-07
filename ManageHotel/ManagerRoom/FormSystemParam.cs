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

namespace ManagerRoom
{
    public partial class FormSystemParam : DevExpress.XtraEditors.XtraForm
    {
        public FormSystemParam()
        {
            InitializeComponent();
        }
        CongTy _congty;
        DonVi _donvi;
        private void FormSystemParam_Load(object sender, EventArgs e)
        {
            _congty = new CongTy();
            _donvi = new DonVi();
            loadCongty();

            cbbCongTy.SelectedIndexChanged += cbbCongTy_SelectedIndexChanged;
            loadDonvi();
        }
        void loadCongty()
        {
            cbbCongTy.DataSource = _congty.GetAll();
            cbbCongTy.DisplayMember = "TENCTY";
            cbbCongTy.ValueMember = "MACTY";
        }
        void loadDonvi()
        {
            cbbDonVi.DataSource = _donvi.GetAll(cbbCongTy.SelectedValue.ToString());
            cbbDonVi.DisplayMember = "TENDVI";
            cbbDonVi.ValueMember = "MADVI";
            cbbDonVi.SelectedIndex = -1;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string macty = cbbCongTy.SelectedValue.ToString();
            string madvi = (cbbDonVi.Text.Trim() == "") ? "~" : cbbDonVi.SelectedValue.ToString();
            SYS_Param _sysparam = new SYS_Param(macty, madvi);
            _sysparam.SaveFile();
            MessageBox.Show("Xác nhận đơn vị sử dụng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BinaryFormatter bf = new BinaryFormatter();
            MessageBox.Show(_sysparam.macty + _sysparam.madvi);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void cbbCongTy_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDonvi();
        }
    }
}