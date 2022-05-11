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
    public class SYS_Group
    {
        Entities db;
        public SYS_Group()
        {
            db = Entities.CreateEntities();

        }
        public tb_SYS_GROUP GetGroupByMemBer(int idUser)
        {
            return db.tb_SYS_GROUP.FirstOrDefault(x => x.MEMBER == idUser);
        }
        public void Add(tb_SYS_GROUP gr)
        {
            try
            {
                db.tb_SYS_GROUP.Add(gr);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý" + ex.Message);
            }

        }
        public void DeleteGroup(int idUser, int idGroup)
        {
            var group = db.tb_SYS_GROUP.FirstOrDefault(x => x.MEMBER == idUser && x.GROUP == idGroup);
            if (group != null)
            {
                try
                {
                    db.tb_SYS_GROUP.Remove(group);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Có lỗi xảy ra trong quá trình xử lý" + ex.Message);
                }
            }
        }
    }
}
