using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
    public class LoaiPhong
    {
        Entities db;
        public LoaiPhong()
        {
            db = Entities.CreateEntities();
        }
        public tb_LOAIPHONG GetItem(int MaLoaiPhong)
        {
            return db.tb_LOAIPHONG.FirstOrDefault(x => x.IDLOAIPHONG == MaLoaiPhong);
        }
        public tb_LOAIPHONG GetItem(string TenLoaiPhong)
        {
            return db.tb_LOAIPHONG.FirstOrDefault(x => x.TENLOAIPHONG  == TenLoaiPhong);
        }
        public List<tb_LOAIPHONG> GetAll() //lấy mã đơn vị
        {
            return db.tb_LOAIPHONG.ToList();
        }
        public void Add(tb_LOAIPHONG AddLP)
        {
            try
            {
                db.tb_LOAIPHONG.Add(AddLP);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
            }
        }
        public void Update(tb_LOAIPHONG UpdateLP)
        {
            tb_LOAIPHONG _LP = db.tb_LOAIPHONG.FirstOrDefault(x => x.IDLOAIPHONG == UpdateLP.IDLOAIPHONG);
            _LP.IDLOAIPHONG = UpdateLP.IDLOAIPHONG;
            _LP.TENLOAIPHONG = UpdateLP.TENLOAIPHONG;
            _LP.DONGIA = UpdateLP.DONGIA;
            _LP.SONGUOI = UpdateLP.SONGUOI;
            _LP.SOGIUONG = UpdateLP.SOGIUONG;
            _LP.DISABLED = UpdateLP.DISABLED;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
            }
        }
        public void Delete(int MaLoaiPhong)
        {
            tb_LOAIPHONG _LP = db.tb_LOAIPHONG.FirstOrDefault(x => x.IDLOAIPHONG == MaLoaiPhong);
            db.tb_LOAIPHONG.Remove(_LP);
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
