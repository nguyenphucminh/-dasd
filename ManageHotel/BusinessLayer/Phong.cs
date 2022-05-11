using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
    public class Phong
    {
        Entities db;
        public Phong()
        {
            db = Entities.CreateEntities();
        }
        public tb_PHONG GetItem(int MaPhong)
        {
            return db.tb_PHONG.FirstOrDefault(x => x.IDPHONG == MaPhong);
        }
        public OBJ_PHONG GetAll(int MaPhong)
        {
            var listP = db.tb_PHONG.Where(x => x.IDPHONG == MaPhong).ToList();
            List<OBJ_PHONG> listOBJ_P = new List<OBJ_PHONG>();  // tạo list
            OBJ_PHONG p = new OBJ_PHONG();  // tạo đối tượng
            foreach (var item in listP)
            {
                p.IDPHONG = item.IDPHONG;
                p.IDLAU = item.IDLAU;
                p.IDLOAIPHONG = item.IDLOAIPHONG;
                p.TENLAU = item.TENLAU;
                p.TENLOAIPHONG = item.TENLOAIPHONG;
                p.TENPHONG = item.TENPHONG;
                p.TRANGTHAI = item.TRANGTHAI ;
                p.DISABLED = item.DISABLED;
                var dongia = db.tb_LOAIPHONG.FirstOrDefault(x => x.IDLOAIPHONG == item.IDLOAIPHONG);
                p.DONGIA = dongia.DONGIA;
                listOBJ_P.Add(p);
            }
            return p;
        }
        public List<tb_PHONG>GetAll()
        {
            return db.tb_PHONG.ToList();
        }
        public List<tb_PHONG>GetByTang(int IDTang)
        {
            return db.tb_PHONG.Where(x => x.IDLAU == IDTang).ToList();
        }
        public List<tb_PHONG> GetByLoaiPhong(int IDLoaiPhong)
        {
            return db.tb_PHONG.Where(x => x.IDLOAIPHONG ==  IDLoaiPhong).ToList();
        }
        public void UpdateStatus(int? IDphong, bool status)
        {
            tb_PHONG _p = db.tb_PHONG.FirstOrDefault(x => x.IDPHONG == IDphong);
            _p.TRANGTHAI = status;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Có lỗi xảy ra trong quá trình xữ lý dữ liệu" + ex.Message);
            }
        }
        public void UpdateStatusBy_IDDP(int iddp, bool status)
        {
            DatPhongChiTiet ct = new DatPhongChiTiet();
            Phong phong = new Phong();
            List<tb_DATPHONGCHITIET> lst_dpct = ct.GetAll(iddp);
            foreach (var p in lst_dpct)
            {
                phong.UpdateStatus( p.IDPHONG, status);
            }
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Có lỗi xảy ra trong quá trình xữ lý dữ liệu" + ex.Message);
            }
        }
        public void Add(tb_PHONG AddP)
        {
            try
            {
                db.tb_PHONG.Add(AddP);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
            }
        }
        public void Update(tb_PHONG UpdateP)
        {
            tb_PHONG _P = db.tb_PHONG.FirstOrDefault(x => x.IDPHONG == UpdateP.IDPHONG);
            _P.IDPHONG  = UpdateP.IDPHONG;
            _P.TENPHONG = UpdateP.TENPHONG;
            _P.TRANGTHAI = UpdateP.TRANGTHAI;
            _P.IDLAU = UpdateP.IDLAU ;
            _P.IDLOAIPHONG = UpdateP.IDLOAIPHONG;
            _P.DISABLED = UpdateP.DISABLED;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
            }
        }
        public void UpdateStatus(int IDphong, bool status)
        {
            tb_PHONG _P = db.tb_PHONG.FirstOrDefault(x => x.IDPHONG == IDphong);
            _P.TRANGTHAI = status ;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
            }
        }
        public void Delete(int MaPhong)
        {
            tb_PHONG _P = db.tb_PHONG.First
                (x => x.IDPHONG == MaPhong);
            db.tb_PHONG.Remove(_P);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
            }
        }
        public bool CheckEmpty(int IDPhong)
        {
            var p = db.tb_PHONG.FirstOrDefault(x => x.IDPHONG == IDPhong);
            if (p.TRANGTHAI == true)
            {
                return true;   //-> với điều kiện đã đặt rồi
            }    
            else
            {
                return false;   //-> chua dat
            }    
        }
        public List<OBJ_PHONG> GetListFull()
        {
            var listPhong = db.tb_PHONG.ToList();
            List<OBJ_PHONG> listPhongOBJ = new List<OBJ_PHONG>();
            OBJ_PHONG phong;
            foreach (var p in listPhong)
            {
                phong = new OBJ_PHONG();
                phong.IDPHONG = p.IDPHONG;
                phong.TENPHONG = p.TENPHONG;
                phong.TRANGTHAI = bool.Parse(p.TRANGTHAI.ToString());
                phong.IDLOAIPHONG = p.IDLOAIPHONG;
                phong.IDLAU = p.IDLAU;
                phong.DISABLED = bool.Parse(p.DISABLED.ToString());
                var tang = db.tb_TANGLAU.FirstOrDefault(t => t.IDLAU == p.IDLAU);
                phong.TENLAU = tang.TENLAU;
                var loaiphong = db.tb_LOAIPHONG.FirstOrDefault(lp => lp.IDLOAIPHONG == p.IDLOAIPHONG);
                phong.TENLOAIPHONG = loaiphong.TENLOAIPHONG;
                phong.DONGIA = double.Parse(loaiphong.DONGIA.ToString());

                listPhongOBJ.Add(phong);
            }
            return listPhongOBJ;
        }

        public List<OBJ_PHONG> GetPhongTrongFull()
        {
            var listPhong = db.tb_PHONG.Where(x => x.TRANGTHAI == false).ToList();
            List<OBJ_PHONG> listPhongOBJ = new List<OBJ_PHONG>();
            OBJ_PHONG phong;
            foreach (var p in listPhong)
            {
                phong = new OBJ_PHONG();
                phong.IDPHONG = p.IDPHONG;
                phong.TENPHONG = p.TENPHONG;
                phong.TRANGTHAI = bool.Parse(p.TRANGTHAI.ToString());
                phong.IDLOAIPHONG = p.IDLOAIPHONG;
                phong.IDLAU = p.IDLAU;
                phong.DISABLED = bool.Parse(p.DISABLED.ToString());
                var tang = db.tb_TANGLAU.FirstOrDefault(t => t.IDLAU == p.IDLAU);
                phong.TENLAU = tang.TENLAU;
                var loaiphong = db.tb_LOAIPHONG.FirstOrDefault(lp => lp.IDLOAIPHONG == p.IDLOAIPHONG);
                phong.TENLOAIPHONG = loaiphong.TENLOAIPHONG;
                phong.DONGIA = double.Parse(loaiphong.DONGIA.ToString());

                listPhongOBJ.Add(phong);
            }
            return listPhongOBJ;
        }
        public OBJ_PHONG GetItemFull(int ID)
        {
            var p = db.tb_PHONG.FirstOrDefault(x => x.IDPHONG == ID);
            OBJ_PHONG phong = new OBJ_PHONG();
            phong.IDPHONG = p.IDPHONG;
            phong.TENPHONG = p.TENPHONG;
            phong.TRANGTHAI = bool.Parse(p.TRANGTHAI.ToString());
            phong.IDLOAIPHONG = p.IDLOAIPHONG;
            phong.IDLAU = p.IDLAU;
            phong.DISABLED = bool.Parse(p.DISABLED.ToString());

            var tang = db.tb_TANGLAU.FirstOrDefault(t => t.IDLAU == p.IDLAU);
            phong.TENLAU = tang.TENLAU;
            var loaiphong = db.tb_LOAIPHONG.FirstOrDefault(lp => lp.IDLOAIPHONG == p.IDLOAIPHONG);
            phong.TENLOAIPHONG = loaiphong.TENLOAIPHONG;
            phong.DONGIA = double.Parse(loaiphong.DONGIA.ToString());
            return phong;
        }
        public List<tb_PHONG> GetPhongTrong(int IDTang)
        {
            return db.tb_PHONG.Where(x => x.TRANGTHAI == false && x.IDLAU == IDTang).ToList();
        }
    }
}
