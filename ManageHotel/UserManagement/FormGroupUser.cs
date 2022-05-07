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
using DataLayer;
using BusinessLayer; 
namespace UserManagement
{
    public partial class FormGroupUser : DevExpress.XtraEditors.XtraForm
    {
        public FormGroupUser()
        {
            InitializeComponent();
        }
        public string _macty;
        public string _madvi;
        public bool _them;
        public int _idUser;
        public string _username;
        public string _fullname;
        SYS_User sys_User;
        SYS_Group sys_Group;
        tb_SYS_USERS _USER;
        VIEW_SYS_UserInGroup VS_UserInGroup;
        FormUserManagement ObjectMain = (FormUserManagement)Application.OpenForms["FormUserManagement"];
        private void FormGroupUser_Load(object sender, EventArgs e)
        {
            sys_User = new SYS_User();
            sys_Group = new SYS_Group();  

            if (!_them)
            {
                var user = sys_User.GetItem(_idUser);
                txtNameGroup.Text = user.USERNAME;
                txtNameGroup.ReadOnly = true;
                txtDescribe.Text = user.FULLNAME;
                _macty = user.MACTY;
                _madvi = user.MADVI;
                LoadUserInGroup(_idUser);

            }
            else
            {
                txtDescribe.Text = "";
                txtNameGroup.Text = "";
            }
        }
        //===============================================================================================================
        public bool ContainsUnicodeCharacter(string input)
        {
            const int MaxAnsiCode = 255;

            return input.ToCharArray().Any(c => c > MaxAnsiCode);
        }
        void SaveData()
        {
            if (ContainsUnicodeCharacter(txtNameGroup.Text))
            {
                MessageBox.Show("Tên nhóm không được có dấu vui lòng nhập lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNameGroup.SelectAll();
                txtDescribe.Focus();
                return;
            }
            if (_them)
            {
                bool checkUser = sys_User.CheckUserExist(_macty, _madvi, txtNameGroup.Text.Trim());
                if (checkUser) 
                {
                    MessageBox.Show("Nhóm đã tồn tại, vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNameGroup.SelectAll();
                    txtNameGroup.Focus();
                    return;
                }
                _USER = new tb_SYS_USERS();
                _USER.USERNAME = txtNameGroup.Text.Trim();
                _USER.FULLNAME = txtDescribe.Text;
                _USER.ISGROUP = true;
                _USER.DISABLED = false;
                _USER.MACTY = _macty;
                _USER.MADVI = _madvi;
                sys_User.Add(_USER);
                MessageBox.Show("Lưu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                _USER = sys_User.GetItem(_idUser);
                _USER.FULLNAME = txtDescribe.Text;
                sys_User.Update(_USER);
                MessageBox.Show("Lưu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            ObjectMain.loadUser(_macty, _madvi);
        }
        public void LoadUserInGroup(int _idGroup) //Load những User có ISGROUP = true
        {
            VS_UserInGroup = new VIEW_SYS_UserInGroup();
            gcMember.DataSource = VS_UserInGroup.GetUserInGroup(_macty, _madvi, _idGroup);
            gvMember.OptionsBehavior.Editable = false;
        }
        //===============================================================================================================
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNameGroup.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập tên nhóm. Tên nhóm nhập không dấu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNameGroup.SelectAll();
                txtNameGroup.Focus();
                return;
            }
            SaveData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormShowMembers frm = new FormShowMembers();
            frm._idGroup = _idUser;
            frm._macty = _macty;
            frm._madvi = _madvi;

            frm.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show($"Are You Sure Want To Delete ?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sys_Group.DeleteGroup(int.Parse(gvMember.GetFocusedRowCellValue("IDUSER").ToString()), _idUser);
                LoadUserInGroup(_idUser);
            }
        }
    }
}