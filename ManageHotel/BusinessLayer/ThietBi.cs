using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
    public class ThietBi
    {
        Entities db;
        public ThietBi()
        {
            db = Entities.CreateEntities();
        }
        public tb_THIETBI GetItem(int MaThietBi)
        {
            return db.tb_THIETBI.FirstOrDefault(x => x.IDTHIETBI == MaThietBi);
        }
        public List<tb_THIETBI> GetAll()
        {
            return db.tb_THIETBI.ToList();
        }
        public void Add(tb_THIETBI AddTB)
        {
            try
            {
                db.tb_THIETBI.Add(AddTB);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
            }
        }
        public void Update(tb_THIETBI UpdateTB)
        {
            tb_THIETBI _TB = db.tb_THIETBI.FirstOrDefault(x => x.IDTHIETBI == UpdateTB.IDTHIETBI);
            _TB.IDTHIETBI = UpdateTB.IDTHIETBI;
            _TB.TENTHIETBI = UpdateTB.TENTHIETBI;
            _TB.DISABLED = UpdateTB.DISABLED;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
            }
        }
        public void Delete(int MaThietBi)
        {
            tb_THIETBI _TB = db.tb_THIETBI.First(x => x.IDTHIETBI == MaThietBi);
            db.tb_THIETBI.Remove(_TB);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
            }
        }
    }
}
