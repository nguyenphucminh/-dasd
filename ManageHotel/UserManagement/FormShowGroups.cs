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
    public partial class FormShowGroups : DevExpress.XtraEditors.XtraForm
    {
        public FormShowGroups()
        {
            InitializeComponent();
        }
        public string _macty;
        public string _madvi;
        public int _idUser;
        SYS_Group sysGroup;
        VIEW_SYS_UserInGroup VS_UserInGroup;
        FormUser objUser = (FormUser)Application.OpenForms["FormUser"];
        private void FormShowGroups_Load(object sender, EventArgs e)
        {
            sysGroup = new SYS_Group();
            VS_UserInGroup = new VIEW_SYS_UserInGroup();
            LoadGroup();
        }
        void LoadGroup()
        {
            gcGroup.DataSource = VS_UserInGroup.GetGroupByDonVi(_macty, _madvi, _idUser);
            gvGroup.OptionsBehavior.Editable = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (gvGroup.RowCount > 0)
            {
                if (VS_UserInGroup.CheckGroupByUser(_idUser, int.Parse(gvGroup.GetFocusedRowCellValue("IDUSER").ToString())))
                {
                    MessageBox.Show("Người dùng đã tồn tại trong Nhóm. Vui lòng chọn nhóm khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                tb_SYS_GROUP group = new tb_SYS_GROUP();
                group.GROUP = int.Parse(gvGroup.GetFocusedRowCellValue("IDUSER").ToString());
                group.MEMBER = _idUser;
                sysGroup.Add(group);
                objUser.LoadGroupByUser(_idUser);
                this.Close();
            }
            else
            {
                MessageBox.Show("Chưa có Nhóm người dùng trong Công Ty - Dơn vị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}