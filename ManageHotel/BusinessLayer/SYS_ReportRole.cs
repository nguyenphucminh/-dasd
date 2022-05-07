using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
    [Serializable]
    public class SYS_ReportRole
    {
        Entities db;
        public SYS_ReportRole()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_SYS_ROLE_REPORT> getListByUser(int idUser)
        {
            SYS_Group sGROUP = new SYS_Group();
            var group = sGROUP.GetGroupByMemBer(idUser);
            if (group == null)
                return db.tb_SYS_ROLE_REPORT.Where(x => x.IDUSER == idUser && x.USER_ROLE == true).ToList();
            else//lấy theo group 
            {
                List<tb_SYS_ROLE_REPORT> lstByGroup = db.tb_SYS_ROLE_REPORT.Where(x => x.IDUSER == group.GROUP && x.USER_ROLE == true).ToList();
                List<tb_SYS_ROLE_REPORT> lstByUser = db.tb_SYS_ROLE_REPORT.Where(x => x.IDUSER == idUser && x.USER_ROLE == true).ToList();
                List<tb_SYS_ROLE_REPORT> lstAll = lstByUser.Concat(lstByGroup).ToList();
                return lstAll;
            }
        }
        public void update(int idUser, int rep_code, bool right)
        {
            tb_SYS_ROLE_REPORT sRight = db.tb_SYS_ROLE_REPORT.FirstOrDefault(x => x.IDUSER == idUser && x.REPORT_CODE == rep_code);
            try
            {
                sRight.USER_ROLE = right;
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("lỗi" + ex.Message);
            }
        }
    }
}
