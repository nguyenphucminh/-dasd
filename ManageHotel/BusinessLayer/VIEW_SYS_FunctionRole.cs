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
    public class VIEW_SYS_FunctionRole
    {
            Entities db;
            public VIEW_SYS_FunctionRole()
            {
                db = Entities.CreateEntities();
            }
            public List<VIEW_SYS_FUNCTION_ROLE> GetFunctionByUser(int idUser)
            {
                return db.VIEW_SYS_FUNCTION_ROLE.Where(x => x.IDUSER == idUser).OrderBy(x => x.SORT).ToList();
            }
    }
}
