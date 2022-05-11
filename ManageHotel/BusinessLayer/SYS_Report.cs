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
    public class SYS_REPORT
    {
        Entities db;
        public SYS_REPORT()
        {
            db = Entities.CreateEntities();
        }
        public tb_SYS_REPORT getItem(int rep_code)
        {
            return db.tb_SYS_REPORT.FirstOrDefault(x => x.REPORT_CODE == rep_code);
        }
        public List<tb_SYS_REPORT> getList()
        {
            return db.tb_SYS_REPORT.ToList();
        }
        public List<tb_SYS_REPORT> getlListByRight(List<tb_SYS_ROLE_REPORT> lst)
        {
            List<int> rep = lst.Select(ls => ls.REPORT_CODE).ToList();
            return db.tb_SYS_REPORT.Where(x => rep.Contains(x.REPORT_CODE)).OrderBy(x => x.REPORT_CODE).ToList();
        }
    }
}
