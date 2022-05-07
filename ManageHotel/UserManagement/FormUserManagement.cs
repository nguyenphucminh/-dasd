using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer;
using UserManagement.MyComponents;

namespace UserManagement
{
    public partial class FormUserManagement : DevExpress.XtraEditors.XtraForm
    {
        public FormUserManagement()
        {
            InitializeComponent();
        }
        MyTreeViewCBB _treeView;
        CongTy _congty;
        DonVi _donvi;
        string _macty;
        string _madvi;
        bool _isRoot;
        SYS_User sysUser;

        private void FormMain_Load(object sender, EventArgs e)
        {
            sysUser = new SYS_User();
            _congty = new CongTy();
            _donvi = new DonVi();
            _isRoot = true;
            LoadTreeView();
            loadUser("CTMINH", "PHUCMINH");
        }
        public void loadUser(string macty, string madvi)
        {
            sysUser = new SYS_User();
            gcUser.DataSource = sysUser.GetUserByDVI(macty, madvi);
            gvUser.OptionsBehavior.Editable = false;
        }

        //===============================================================================================================
        void LoadTreeView()
        {
            _treeView = new MyTreeViewCBB(panelNhom.Width, 300);
            //_treeView.Font = new Font("Tahoma", 10, FontStyle.Regular);
            var listCongTy = _congty.GetAll();

            foreach (var item in listCongTy)
            {
                TreeNode parentNode = new TreeNode();
                parentNode.NodeFont = new Font("Tahoma", 8, FontStyle.Bold);
                parentNode.Text = item.MACTY + " - " + item.TENCTY;
                parentNode.Tag = item.MACTY;
                parentNode.Name = item.MACTY;

                _treeView.TreeView.Nodes.Add(parentNode);
                foreach (var donvi in _donvi.GetAll(item.MACTY))
                {
                    TreeNode childNode = new TreeNode();
                    childNode.NodeFont = new Font("Tahoma", 8, FontStyle.Regular);
                    childNode.Text = donvi.MADVI + " - " + donvi.TENDVI;
                    childNode.Tag = donvi.MACTY + "." + donvi.MADVI;
                    childNode.Name = donvi.MACTY + "." + donvi.MADVI;

                    _treeView.TreeView.Nodes[parentNode.Name].Nodes.Add(childNode);
                }

            }

            _treeView.TreeView.ExpandAll();
            panelNhom.Controls.Add(_treeView);
            _treeView.Width = panelNhom.Width;
            _treeView.Height = panelNhom.Height;
            _treeView.TreeView.AfterSelect += TreeView_AfterSelect;
            _treeView.TreeView.Click += TreeView_Click;
        }

        private void TreeView_Click(object sender, EventArgs e)
        {
            _treeView.dropDown.Focus();
            _treeView.SelectAll();
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _treeView.Text = _treeView.TreeView.SelectedNode.Text;  
            if (_treeView.TreeView.SelectedNode.Parent == null)
            {
                _isRoot = true;
                _macty = _treeView.TreeView.SelectedNode.Tag.ToString();
                _madvi = "~";//cấp Hành Chánh - Đơn Vị
            }
            else
            {
                _isRoot = false;
                int position = _treeView.TreeView.SelectedNode.Name.IndexOf(".");
                _macty = _treeView.TreeView.SelectedNode.Name.Substring(0, position);
                _madvi = _treeView.TreeView.SelectedNode.Name.Substring(position + 1);
            }
            loadUser(_macty, _madvi);
            _treeView.dropDown.Close();
        }

        //===============================================================================================================
        private void BtnGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddGroup();
        }

        private void BtnUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddUser();
        }

        private void BtnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateInfor();
        }

        private void BtnFucntion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FunctionRole();
        }

        private void BtnReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void BtnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gvUser_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        { 
            if (e.Column.Name == "ISGROUP" && bool.Parse(e.CellValue.ToString()) == true)
            {
                e.Graphics.DrawImage(imageList1.Images[1], e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
            else if (e.Column.Name == "ISGROUP" && bool.Parse(e.CellValue.ToString()) == false)
            {
                e.Graphics.DrawImage(imageList1.Images[0], e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }

        private void gvUser_DoubleClick(object sender, EventArgs e)
        {
            if (gvUser.RowCount > 0 && gvUser.GetFocusedRowCellValue("ISGROUP").Equals(true))
            {
                FormGroupUser frm = new FormGroupUser();
                frm._them = false;
                frm._idUser = int.Parse(gvUser.GetFocusedRowCellValue("IDUSER").ToString());
                frm.ShowDialog();
            }
            else
            {
                FormUser frm = new FormUser();
                frm._them = false;
                frm._idUser = int.Parse(gvUser.GetFocusedRowCellValue("IDUSER").ToString());
                frm.ShowDialog();
            }
        }
        //========================================================MENUSTRIP=================================================================================
        private void MenuAddGroup_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvUser.RowCount; i++)
            {
                if (gvUser.IsRowSelected(i))
                {
                    AddGroup();
                }
            }
        }

        private void MenuAddUser_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvUser.RowCount; i++)
            {
                if (gvUser.IsRowSelected(i))
                {
                    AddUser();
                }
            }
        }

        private void MenuReport_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvUser.RowCount; i++)
            {
                if (gvUser.IsRowSelected(i))
                {
                    ReportRole();
                }
            }
        }
        private void MenuRole_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvUser.RowCount; i++)
            {
                if (gvUser.IsRowSelected(i))
                {
                    FunctionRole();
                }
            }
        }
        private void MenuUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvUser.RowCount; i++)
            {
                if (gvUser.IsRowSelected(i))
                {
                    UpdateInfor();
                }

            }
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //==============================================================HÀM CHỨC NĂNG=======================================================================
        private void AddGroup()
        {
            if (_treeView.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đơn vị.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FormGroupUser frmGoupUser = new FormGroupUser();
            frmGoupUser._them = true;
            frmGoupUser._macty = _macty;
            frmGoupUser._madvi = _madvi;
            frmGoupUser.ShowDialog();
        }
        private void AddUser()
        {
            if (_treeView.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đơn vị.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            FormUser frm = new FormUser();
            frm._them = true;
            frm._macty = _macty;
            frm._madvi = _madvi;



            frm.ShowDialog();
        }
        private void UpdateInfor()
        {
            if (gvUser.RowCount > 0 && gvUser.GetFocusedRowCellValue("ISGROUP").Equals(true))
            {
                if (gvUser.GetFocusedRowCellValue("DISABLED").Equals(true))
                {
                    if (MessageBox.Show("Nhóm người Dùng đã bị vô hiệu hóa bạn có muốn tiếp tục", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        FormGroupUser frm = new FormGroupUser();
                        frm._them = false;
                        frm._idUser = int.Parse(gvUser.GetFocusedRowCellValue("IDUSER").ToString());
                        frm.ShowDialog();
                    }
                }
                else
                {
                    FormGroupUser frm = new FormGroupUser();
                    frm._them = false;
                    frm._idUser = int.Parse(gvUser.GetFocusedRowCellValue("IDUSER").ToString());
                    frm.ShowDialog();
                }

            }
            else if (gvUser.RowCount > 0 && gvUser.GetFocusedRowCellValue("ISGROUP").Equals(false))
            {
                if (gvUser.GetFocusedRowCellValue("DISABLED").Equals(true))
                {
                    if (MessageBox.Show("Người Dùng đã bị vô hiệu hóa bạn có muốn tiếp tục", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        FormUser frm = new FormUser();
                        frm._them = false;
                        frm._idUser = int.Parse(gvUser.GetFocusedRowCellValue("IDUSER").ToString());
                        frm.ShowDialog();
                    }
                }
                else
                {
                    FormUser frm = new FormUser();
                    frm._them = false;
                    frm._idUser = int.Parse(gvUser.GetFocusedRowCellValue("IDUSER").ToString());
                    frm.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Hiện tại không có người dùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FunctionRole()
        {
            if (gvUser.RowCount > 0)
            {
                tb_SYS_USERS i = sysUser.GetItem(int.Parse(gvUser.GetFocusedRowCellValue("IDUSER").ToString()));
                if (i.DISABLED == true)
                {
                    MessageBox.Show("Vui lòng chọn Người Dùng khác. Người Dùng đã bị vô hiệu hóa!.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                FormFunctionRole frm = new FormFunctionRole();
                frm._idUser = int.Parse(gvUser.GetFocusedRowCellValue("IDUSER").ToString());
                frm._macty = _macty;
                frm._madvi = _madvi;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hiện tại không có người dùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ReportRole()
        {
            //if (gvUser.RowCount > 0)
            //{
            //    tb_SYS_USER i = _sysUser.getItem(int.Parse(gvUser.GetFocusedRowCellValue("IDUSER").ToString()));
            //    if (i.DISABLED == true)
            //    {
            //        MessageBox.Show("Vui lòng chọn Người Dùng khác. Người Dùng đã bị vô hiệu hóa!.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        return;
            //    }
            //    frmPhanQuyenBaoCao frm = new frmPhanQuyenBaoCao();
            //    frm._idUser = int.Parse(gvUser.GetFocusedRowCellValue("IDUSER").ToString());
            //    frm._macty = _macty;
            //    frm._madvi = _madvi;
            //    frm.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Hiện tại không có người dùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }


    }
}
