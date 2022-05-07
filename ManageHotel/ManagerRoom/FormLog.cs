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
using System.Threading;
using System.IO;

namespace ManagerRoom
{
    public partial class FormLog : DevExpress.XtraEditors.XtraForm
    {
        public FormLog()
        {
            InitializeComponent();
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Chọn tập tin cần mã hóa";
            dialog.Filter = "Text files|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string file_path = dialog.FileName;
                file_path = new FileInfo(file_path).FullName;
                txtPath.Text = file_path;
            }
            txtLog.Text = File.ReadAllText(txtPath.Text);
        }
    }
}