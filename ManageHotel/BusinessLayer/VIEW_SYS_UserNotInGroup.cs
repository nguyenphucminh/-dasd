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
    public class VIEW_SYS_UserNotInGroup
    {
        Entities db;
        public VIEW_SYS_UserNotInGroup()
        {
            db = Entities.CreateEntities();
        }
        public bool CheckGroupByUser(int idUser, int idgroup)
        {
            var gr = db.tb_SYS_GROUP.FirstOrDefault(x => x.GROUP == idgroup && x.MEMBER == idUser);
            if (gr == null)
                return false;

            return true;

        }
        public List<VIEW_SYS_USER_NOTIN_GROUP> GetUserNotinGroup(string macty, string madvi)
        {

            return db.VIEW_SYS_USER_NOTIN_GROUP.Where(x => x.MACTY == macty && x.MADVI == madvi && x.ISGROUP == false && x.DISABLED == false).ToList();
        }
    }
}
