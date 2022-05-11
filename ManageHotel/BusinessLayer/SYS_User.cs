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
    public class SYS_User
    {
        Entities db;

        public SYS_User()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_SYS_USERS> getAll()
        {
            return db.tb_SYS_USERS.ToList();
        }
        public tb_SYS_USERS GetItem(int idUser)
        {
            return db.tb_SYS_USERS.FirstOrDefault(x => x.IDUSER == idUser);
        }
        public tb_SYS_USERS GetItem(string usernam, string macty, string madvi)

        {
            return db.tb_SYS_USERS.FirstOrDefault(x => x.DISABLED == false && x.MACTY == macty && x.MADVI == madvi && x.USERNAME == usernam);
        }
        public List<tb_SYS_USERS> GetUserByDVI(string macty, string madvi)
        {
            return db.tb_SYS_USERS.Where(x => x.MACTY == macty && x.MADVI == madvi).ToList();
        }
        public List<tb_SYS_USERS> GetUserByDVIFunction(string macty, string madvi)
        {
            return db.tb_SYS_USERS.Where(x => x.MACTY == macty && x.MADVI == madvi && x.DISABLED == false).OrderByDescending(x => x.ISGROUP).ToList();
        }
        public bool CheckUserExist(string macty, string madvi, string username)
        {
            var user = db.tb_SYS_USERS.FirstOrDefault(x => x.MACTY == macty && x.MADVI == madvi && x.USERNAME == username);
            if (user != null)
            {
                return true;
            }
            else return false;
        }
        public tb_SYS_USERS Add(tb_SYS_USERS user)
        {
            try
            {
                db.tb_SYS_USERS.Add(user);
                db.SaveChanges();
                return user;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi:" + ex.Message);
            }
        }
        public tb_SYS_USERS Update(tb_SYS_USERS us)
        {
            var _user = db.tb_SYS_USERS.FirstOrDefault(x => x.IDUSER == us.IDUSER);
            _user.USERNAME = us.USERNAME;
            _user.FULLNAME = us.FULLNAME;
            _user.ISGROUP = us.ISGROUP;
            _user.IDUSER = us.IDUSER;
            _user.MACTY = us.MACTY;
            _user.MADVI = us.MADVI;
            _user.PASSWD = us.PASSWD;

            _user.LAST_PWD_CHANGED = DateTime.Now;
            try
            {

                db.SaveChanges();
                return us;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi:" + ex.Message);
            }
        }
    }
}
