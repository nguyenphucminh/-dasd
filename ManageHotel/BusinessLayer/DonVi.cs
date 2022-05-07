using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DonVi
    {
        Entities db;
        public DonVi()
        {
            db = Entities.CreateEntities();
        }
        public tb_DONVI GetItem(string MaDonVi)
        {
            return db.tb_DONVI.FirstOrDefault(x => x.MADVI == MaDonVi);
        }
        public List<tb_DONVI> GetAll() //lấy mã đơn vị
        {
            return db.tb_DONVI.ToList();
        }
        public List<tb_DONVI> GetAll(string MaCongTy) //lấy mã công ty trong db DONVI
        {
            return db.tb_DONVI.Where(x => x.MACTY == MaCongTy).ToList();
        }
        public void Add(tb_DONVI AddDV)
        {
            try
            {
                db.tb_DONVI.Add(AddDV);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
            }
        }
        public void Update(tb_DONVI UpdateDV)
        {
            tb_DONVI _DV = db.tb_DONVI.FirstOrDefault(x => x.MADVI == UpdateDV.MADVI);
            _DV.MACTY = UpdateDV.MACTY;
            _DV.TENDVI = UpdateDV.TENDVI;
            _DV.DIENTHOAI = UpdateDV.DIENTHOAI;
            _DV.EMAIL = UpdateDV.EMAIL;
            _DV.FAX = UpdateDV.FAX;
            _DV.DIACHI = UpdateDV.DIACHI;
            _DV.DISABLED = UpdateDV.DISABLED;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
            }
        }
        public void Delete(string MaDonVi)
        {
            tb_DONVI _DV = db.tb_DONVI.FirstOrDefault(x => x.MADVI == MaDonVi);
            _DV.DISABLED = true; //đánh dấu
            db.tb_DONVI.Remove(_DV);
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
