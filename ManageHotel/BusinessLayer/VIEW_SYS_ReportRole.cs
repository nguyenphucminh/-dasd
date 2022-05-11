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
    public class VIEW_SYS_ReportRole
    {
        Entities db;
        public VIEW_SYS_ReportRole()
        {
            db = Entities.CreateEntities();
        }
        //public List<V_REP_SYS_RIGHT_REP> getRep()
        //{
        //    return db.V_REP_SYS_RIGHT_REP.ToList();
        //}
        //public List<V_REP_SYS_RIGHT_REP> getRepByUserp(int idUser)
        //{
        //    return db.V_REP_SYS_RIGHT_REP.Where(x => x.IDUSER == idUser).ToList();
        //}
    }
}
