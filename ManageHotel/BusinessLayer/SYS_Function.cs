using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
    public class SYS_Function
    {
        Entities db;
        public SYS_Function()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_SYS_FUNCTION>GetParent()
        {
            return db.tb_SYS_FUNCTION.Where(x => x.ISGROUP == true && x.MENU == true).OrderBy(s => s.SORT).ToList();
        }
        public List<tb_SYS_FUNCTION>GetChild(string parent)
        {
            return db.tb_SYS_FUNCTION.Where(x => x.ISGROUP == false && x.MENU == true && x.PARENT  == parent).OrderBy(s => s.SORT).ToList();    
        }
    }
}
