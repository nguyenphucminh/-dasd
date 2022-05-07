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
    public partial class FormUser : DevExpress.XtraEditors.XtraForm
    {
        public FormUser()
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
        private void FormUser_Load(object sender, EventArgs e)
        {
            sys_User = new SYS_User();
            sys_Group = new SYS_Group();
            if (!_them)
            {
                var user = sys_User.GetItem(_idUser);

                txtUserName.Text = user.USERNAME;
                txtUserName.ReadOnly = true;
                txtFullName.Text = user.FULLNAME;
                _macty = user.MACTY;
                _madvi = user.MADVI;
                checkBoxDisable.Checked = user.DISABLED.Value;
                txtPass.Text = Encryptor.Decrypt(user.PASSWD, "qwert@123!poiuy", true);
                txtResetPass.Text = Encryptor.Decrypt(user.PASSWD, "qwert@123!poiuy", true);
                LoadGroupByUser(_idUser);


            }
            else
            {
                txtFullName.Text = "";
                txtPass.Text = "";
                txtResetPass.Text = "";
                checkBoxDisable.Checked = false;
            }
        }
        //==================================================================================================
        public bool ContainsUnicodeCharacter(string input)
        {
            const int MaxAnsiCode = 255;

            return input.ToCharArray().Any(c => c > MaxAnsiCode);
        }
        void SaveData()
        {
            if (ContainsUnicodeCharacter(txtUserName.Text))
            {
                MessageBox.Show("Tên người dùng không được có dấu vui lòng nhập lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.SelectAll();
                txtUserName.Focus();
                return;
            }
            if (_them)
            {
                bool checkUser = sys_User.CheckUserExist(_macty, _madvi, txtUserName.Text.Trim());
                if (checkUser)
                {
                    MessageBox.Show("Tên người đã tồn tại.Vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserName.SelectAll();
                    txtUserName.Focus();
                    return;
                }
                _USER = new tb_SYS_USERS();
                _USER.USERNAME = txtUserName.Text.Trim();
                _USER.FULLNAME = txtFullName.Text;
                _USER.ISGROUP = false;
                _USER.DISABLED = false;
                _USER.MACTY = _macty;
                _USER.MADVI = _madvi;
                _USER.PASSWD = Encryptor.Encrypt(txtPass.Text.Trim(), "qwert@123!poiuy", true);
                sys_User.Add(_USER);
                MessageBox.Show("Lưu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                _USER = sys_User.GetItem(_idUser);
                _USER.FULLNAME = txtFullName.Text;
                _USER.ISGROUP = false;
                _USER.DISABLED = checkBoxDisable.Checked;
                _USER.MACTY = _macty;
                _USER.MADVI = _madvi;
                _USER.PASSWD = Encryptor.Encrypt(txtPass.Text.Trim(), "qwert@123!poiuy", true);
                sys_User.Update(_USER);
                MessageBox.Show("Lưu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            ObjectMain.loadUser(_macty, _madvi);
        }
        public void LoadGroupByUser(int idUser)
        {
            VS_UserInGroup = new VIEW_SYS_UserInGroup();
            gcMember.DataSource = VS_UserInGroup.GetGroupByUser(_macty, _madvi, idUser);
            gvMember.OptionsBehavior.Editable = false;
        }
        //==================================================================================================
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập tên người dùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.SelectAll();
                txtUserName.Focus();
                return;
            }
            if (txtResetPass.Text != txtPass.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khắp. Vui lòng nhập lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.SelectAll();
                txtUserName.Focus();
                return;
            }
            if (txtFullName.Text == "" || txtUserName.Text == "" || txtPass.Text == "" || txtResetPass.Text == "")
            {
                MessageBox.Show(" Vui lòng nhập nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.SelectAll();
                txtUserName.Focus();
                return;
            }
            SaveData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormShowGroups frm = new FormShowGroups();
            frm._idUser = _idUser;
            frm._macty = _macty;
            frm._madvi = _madvi;
            frm.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            sys_Group.DeleteGroup(_idUser,int.Parse(gvMember.GetFocusedRowCellValue("IDUSER").ToString()));
            LoadGroupByUser(_idUser);
        }

        private void btnEyeShow_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '\0')
            {
                btnEyeHide.BringToFront();
                txtPass.PasswordChar = '*';
            }
        }

        private void btnEyeHide_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
            {
                btnEyeShow.BringToFront();
                txtPass.PasswordChar = '\0';
            }
        }

        private void btnEyeShow2_Click(object sender, EventArgs e)
        {
            if (txtResetPass.PasswordChar == '\0')
            {
                btnEyeHide2.BringToFront();
                txtResetPass.PasswordChar = '*';
            }
        }

        private void btnEyeHide2_Click(object sender, EventArgs e)
        {
            if (txtResetPass.PasswordChar == '*')
            {
                btnEyeShow2.BringToFront();
                txtResetPass.PasswordChar = '\0';
            }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if(txtUserName.Text == "USERNAME")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.Black;
            }    
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "USERNAME";
                txtUserName.ForeColor = Color.Silver;
            }
        }

        private void txtFullName_Enter(object sender, EventArgs e)
        {
                if (txtFullName.Text == "FULLNAME")
                {
                    txtFullName.Text = "";
                    txtFullName.ForeColor = Color.Black;
                }
            }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            if (txtFullName.Text == "")
            {
                txtFullName.Text = "FULLNAME";
                txtFullName.ForeColor = Color.Silver;
            }
        }
    }
}