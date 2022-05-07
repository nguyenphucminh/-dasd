using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
    public class KhachHang
    {
        Entities db;
        public KhachHang()
        {
            db = Entities.CreateEntities();
        }
        public tb_KHACHHANG GetItem(int MaKhachHang)
        {
            return db.tb_KHACHHANG.FirstOrDefault(x => x.IDKHACH == MaKhachHang);
        }
        public List<tb_KHACHHANG> GetAll() //lấy mã đơn vị
        {
            return db.tb_KHACHHANG.ToList();
        }
        public void Add(tb_KHACHHANG AddKH)
        {
            try
            {
                db.tb_KHACHHANG.Add(AddKH);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
            }
        }
        public void Update(tb_KHACHHANG UpdateKH)
        {
            tb_KHACHHANG _KH = db.tb_KHACHHANG.FirstOrDefault(x => x.IDKHACH == UpdateKH.IDKHACH);
            _KH.IDKHACH = UpdateKH.IDKHACH;
            _KH.NAMEKHACH = UpdateKH.NAMEKHACH;
            _KH.CCCD = UpdateKH.CCCD;
            _KH.GIOITINH = UpdateKH.GIOITINH;
            _KH.EMAIl = UpdateKH.EMAIl;
            _KH.DIACHI = UpdateKH.DIACHI;
            _KH.DISABLED = UpdateKH.DISABLED;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
            }
        }
        public void Delete(int MaKhachHang)
        {
            tb_KHACHHANG _KH = db.tb_KHACHHANG.FirstOrDefault(x => x.IDKHACH == MaKhachHang);
            db.tb_KHACHHANG.Remove(_KH); 
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
