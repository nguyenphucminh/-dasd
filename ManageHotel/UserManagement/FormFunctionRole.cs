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
using DevExpress.XtraGrid.Views.Grid;

namespace UserManagement
{
    public partial class FormFunctionRole : DevExpress.XtraEditors.XtraForm
    {
        public FormFunctionRole()
        {
            InitializeComponent();
        }
        public int _idUser;
        public string _macty;
        public string _madvi;
        SYS_User sysUser;
        SYS_Role sysRole;
        private void FormFunctionRole_Load(object sender, EventArgs e)
        {
            sysRole = new SYS_Role();
            sysUser = new SYS_User();
            gvFunction.RowStyle += gvFunction_RowStyle;
            loadUser();
            loadFunctionByUser();
        }
        //====================================================================================================
        void loadUser()
        {
            if (_macty == null && _madvi == null)
            {
                gcUser.DataSource = sysUser.GetUserByDVIFunction("CTMINH", "PHUCMINH");
                gvUser.OptionsBehavior.Editable = false;
            }
            else
            {
                gcUser.DataSource = sysUser.GetUserByDVIFunction(_macty, _madvi);
                gvUser.OptionsBehavior.Editable = false;
            }
        }
        void loadFunctionByUser()
        {
            VIEW_SYS_FunctionRole VS_FunctionRole = new VIEW_SYS_FunctionRole();
            gcFunction.DataSource = VS_FunctionRole.GetFunctionByUser(_idUser);
            gvFunction.OptionsBehavior.Editable = false;

            for (int i = 0; i < gvUser.RowCount; i++)
            {
                if (int.Parse(gvUser.GetRowCellValue(i, "IDUSER").ToString()) == _idUser)
                {
                    gvUser.ClearSelection();
                    gvUser.FocusedRowHandle = i;
                }
            }
            gvFunction.ClearSelection();
        }
        //====================================================================================================
        private void gvFunction_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView view = sender as GridView;

            if (e.RowHandle >= 0)
            {
                bool isRed = Convert.ToBoolean(view.GetRowCellValue(e.RowHandle, view.Columns["ISGROUP"]));
                if (isRed)
                {

                    e.Appearance.BackColor = Color.DeepSkyBlue;
                    e.Appearance.ForeColor = Color.White;
                    e.Appearance.Font = new Font("Tahoma", 8, FontStyle.Bold);

                }
            }
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
        //====================================================================FUNCTION==============================================================
        private void MenuProhibit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvFunction.RowCount; i++)
            {
                if (gvFunction.IsRowSelected(i) && bool.Parse(gvFunction.GetRowCellValue(i, "ISGROUP").ToString()) == false)
                {
                    sysRole.update(_idUser, gvFunction.GetRowCellValue(i, "FUNC_CODE").ToString(), 0);
                }

            }
            loadFunctionByUser();
        }

        private void MenuReadOnly_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvFunction.RowCount; i++)
            {

                if (gvFunction.IsRowSelected(i) && bool.Parse(gvFunction.GetRowCellValue(i, "ISGROUP").ToString()) == false)
                {
                    sysRole.update(_idUser, gvFunction.GetRowCellValue(i, "FUNC_CODE").ToString(), 1);
                }

            }
            loadFunctionByUser();
        }

        private void MenuFullRole_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvFunction.RowCount; i++)
            {
                if (gvFunction.IsRowSelected(i) && bool.Parse(gvFunction.GetRowCellValue(i, "ISGROUP").ToString()) == false)
                {
                    sysRole.update(_idUser, gvFunction.GetRowCellValue(i, "FUNC_CODE").ToString(), 2);

                }
            }
            loadFunctionByUser();
        }

        private void gcUser_Click(object sender, EventArgs e)
        {
            _idUser = int.Parse(gvUser.GetFocusedRowCellValue("IDUSER").ToString());
            loadFunctionByUser();
        }
    }
}