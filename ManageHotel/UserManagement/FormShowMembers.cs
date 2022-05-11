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
using DataLayer;
namespace UserManagement
{
    public partial class FormShowMembers : DevExpress.XtraEditors.XtraForm
    {
        public FormShowMembers()
        {
            InitializeComponent();
        }
        public string _macty;
        public string _madvi;
        public int _idGroup;
        SYS_Group sysGroup;
        //VIEW_SYS_UserNotInGroup VS_UserNotInGroup;
        VIEW_SYS_UserInGroup VS_UserInGroup;
        FormGroupUser objGroup = (FormGroupUser)Application.OpenForms["FormGroupUser"];
        private void FormShowMembers_Load(object sender, EventArgs e)
        {

            sysGroup = new SYS_Group();
            VS_UserInGroup = new VIEW_SYS_UserInGroup();
            //VS_UserNotInGroup = new VIEW_SYS_UserNotInGroup();
            LoadUserNotInGroup();
        }
        //========================================================================================================================================================
        void LoadUserNotInGroup()
        {
            gcMember.DataSource = VS_UserInGroup.GetUserNotInGroup(_macty, _madvi, _idGroup);
            gvMember.OptionsBehavior.Editable = false;
        }
        //========================================================================================================================================================
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (gvMember.RowCount > 0)
            {
                tb_SYS_GROUP group = new tb_SYS_GROUP();
                group.GROUP = _idGroup;
                group.MEMBER = int.Parse(gvMember.GetFocusedRowCellValue("IDUSER").ToString());
                sysGroup.Add(group);
                objGroup.LoadUserInGroup(_idGroup);
                this.Close();
            }
            else
            {
                MessageBox.Show("Chưa có Nhóm người dùng trong Công Ty - Dơn vị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}