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
    public class SYS_Role
    {
        Entities db;
        public SYS_Role()
        {
            db = Entities.CreateEntities();

        }
        public tb_SYS_ROLE getRight(int idUser, string func_code)
        {
            return db.tb_SYS_ROLE.FirstOrDefault(x => x.IDUSER == idUser && x.FUNC_CODE == func_code);
        }
        public void update(int idUser, string func_code, int right)
        {
            tb_SYS_ROLE role = db.tb_SYS_ROLE.FirstOrDefault(x => x.IDUSER == idUser && x.FUNC_CODE == func_code);
            try
            {
                role.USER_ROLE = right;
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("lỗi" + ex.Message);
            }
        }
    }
}
