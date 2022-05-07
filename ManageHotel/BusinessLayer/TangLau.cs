using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class TangLau
    {
        Entities db;
        public TangLau()
        {
            db = Entities.CreateEntities();
        }
        public tb_TANGLAU GetItem(int MaTangLau)
        {
            return db.tb_TANGLAU.FirstOrDefault(x => x.IDLAU == MaTangLau);
        }
        public List<tb_TANGLAU>GetAll()
        {
            return db.tb_TANGLAU.ToList();
        }
        public void Add(tb_TANGLAU AddTL)
        {
            try
            {
                db.tb_TANGLAU.Add(AddTL);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
            }
        }
        public void Update(tb_TANGLAU UpdateTL)
        {
            tb_TANGLAU _TL = db.tb_TANGLAU.FirstOrDefault(x => x.IDLAU== UpdateTL.IDLAU);
            _TL.IDLAU = UpdateTL.IDLAU;
            _TL.TENLAU = UpdateTL.TENLAU;
            _TL.DISABLED = UpdateTL.DISABLED;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
            }
        }
        public void Delete(int MaTangLau)
        {
            tb_TANGLAU _TL = db.tb_TANGLAU.FirstOrDefault(x => x.IDLAU  == MaTangLau);
            db.tb_TANGLAU.Remove(_TL);
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
