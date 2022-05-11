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
    public class VIEW_SYS_UserInGroup
    {
        Entities db;
        public VIEW_SYS_UserInGroup()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_SYS_USERS> GetGroupByUser(string macty, string madvi, int idUser)
        {
            List<tb_SYS_USERS> lstGroup = new List<tb_SYS_USERS>();

            List<VIEW_SYS_USER_IN_GROUP> lst = db.VIEW_SYS_USER_IN_GROUP.Where(x => x.MEMBER == idUser && x.MACTY == macty && x.MADVI == madvi).ToList();
            tb_SYS_USERS user;
            foreach (var item in lst)
            {
                user = new tb_SYS_USERS();
                user = db.tb_SYS_USERS.FirstOrDefault(x => x.IDUSER == item.GROUP);
                lstGroup.Add(user);    

            }
            return lstGroup;

        }
        public List<tb_SYS_USERS> GetGroupByDonVi(string macty, string madvi, int iduser)
        {
            List<tb_SYS_USERS> allGroup = db.tb_SYS_USERS.Where(x => x.ISGROUP == true && x.DISABLED == false && x.MACTY == macty && x.MADVI == madvi).ToList();

            List<tb_SYS_USERS> listGroup = new List<tb_SYS_USERS>();
            tb_SYS_USERS group;
            foreach (var item in allGroup)
            {
                if (!CheckGroupByUser(iduser, item.IDUSER))
                {
                    group = new tb_SYS_USERS();
                    group = db.tb_SYS_USERS.FirstOrDefault(x => x.IDUSER == item.IDUSER);
                    listGroup.Add(group);
                }
            }



            //  return db.tb_SYS_USER.Where(x => x.MACTY == macty && x.MADVI == madvi).ToList();
            return listGroup;

        }
        public List<tb_SYS_USERS> GetUserNotInGroup(string macty, string madvi, int idGroup)
        {
            List<tb_SYS_USERS> allUser = db.tb_SYS_USERS.Where(x => x.ISGROUP == false && x.DISABLED == false && x.MACTY == macty && x.MADVI == madvi).ToList();

            List<tb_SYS_USERS> listGroup = new List<tb_SYS_USERS>();
            tb_SYS_USERS group;
            foreach (var item in allUser)
            {
                if (!CheckGroupByUser(item.IDUSER, idGroup))
                {
                    group = new tb_SYS_USERS();
                    group = db.tb_SYS_USERS.FirstOrDefault(x => x.IDUSER == item.IDUSER);
                    listGroup.Add(group);
                }
            }



            //  return db.tb_SYS_USER.Where(x => x.MACTY == macty && x.MADVI == madvi).ToList();
            return listGroup;

        }
        public bool CheckGroupByUser(int idUser, int idgroup)
        {
            var group = db.tb_SYS_GROUP.FirstOrDefault(x => x.GROUP == idgroup && x.MEMBER == idUser);
            if (group == null)
            {
                return false;
            }    
            else
            {
                return true;
            }
        }
        public List<VIEW_SYS_USER_IN_GROUP> GetUserInGroup(string macty, string madvi, int _idGroup)
        {
            return db.VIEW_SYS_USER_IN_GROUP.Where(x => x.MADVI == madvi && x.MACTY == macty && x.DISABLED == false && x.ISGROUP == false && x.GROUP ==_idGroup).ToList();
        }
    }
}
