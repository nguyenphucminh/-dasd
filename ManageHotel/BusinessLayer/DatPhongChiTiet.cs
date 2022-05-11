using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
    public class DatPhongChiTiet
    {

        Entities db;
        public DatPhongChiTiet()
        {
            db = Entities.CreateEntities();
        }
        public tb_DATPHONGCHITIET GetItem(int MaDatPhongChiTiet)
        {
            return db.tb_DATPHONGCHITIET.FirstOrDefault(x => x.IDDPCT == MaDatPhongChiTiet);
        }
        public tb_DATPHONGCHITIET GetItem(int IDDP, int IDPhong)
        {
            return db.tb_DATPHONGCHITIET.FirstOrDefault(x => x.IDDP == IDDP && x.IDPHONG == IDPhong);
        }

        public List<tb_DATPHONGCHITIET> GetAll()
        {
            return db.tb_DATPHONGCHITIET.ToList();
        }
        public List<tb_DATPHONGCHITIET>GetAll(int iddp)
        {
            return db.tb_DATPHONGCHITIET.Where(x => x.IDDP == iddp).ToList();
        }
        public List<OBJ_DATPHONGCHITIET> GetAllByDatPhong(int IDDP)
        {
            var listget = db.tb_DATPHONGCHITIET.Where(x => x.IDDP == IDDP).ToList();
            List<OBJ_DATPHONGCHITIET> listDPCT = new List<OBJ_DATPHONGCHITIET>();
            OBJ_DATPHONGCHITIET DPCT;
            foreach (var item in listget)
            {
                DPCT = new OBJ_DATPHONGCHITIET();
                DPCT.IDDPCT = item.IDDPCT;
                DPCT.IDDP = item.IDDP;
                DPCT.IDPHONG = (int)item.IDPHONG;
                var phong = db.tb_PHONG.FirstOrDefault(x => x.IDPHONG == item.IDPHONG);
                DPCT.TENPHONG = phong.TENPHONG;
                DPCT.DONGIA = item.DONGIA;
                DPCT.THANHTIEN = item.THANHTIEN;
                listDPCT.Add(DPCT);
            }
            return listDPCT;
        }
        //public List<tb_DATPHONG> GetByTang(int IDTang)
        //{
        //    return db.tb_DATPHONG.Where(x => x.IDLAU == IDTang).ToList();
        //}
        //public List<tb_PHONG> GetByLoaiPhong(int IDLoaiPhong)
        //{
        //    return db.tb_PHONG.Where(x => x.IDLOAIPHONG == IDLoaiPhong).ToList();
        //}


        public tb_DATPHONGCHITIET getIDDPByPhong(int IDPhong)
        {
            return db.tb_DATPHONGCHITIET.OrderByDescending(x => x.NGAY).FirstOrDefault(x => x.IDPHONG == IDPhong);
            //Sắp xếp giảm dần theo ngày để lấy đơn đặt phòng mới nhất
        }
        public tb_DATPHONGCHITIET  Add(tb_DATPHONGCHITIET AddDPCT)
        {
            try
            {
                db.tb_DATPHONGCHITIET.Add(AddDPCT);
                db.SaveChanges();
                return AddDPCT;
            }
            catch (Exception ex)
            {
                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
            }
        }
        public void Update(tb_DATPHONGCHITIET UpdateDPCT)
        {
            tb_DATPHONGCHITIET _DPCT = db.tb_DATPHONGCHITIET.FirstOrDefault(x => x.IDDPCT == UpdateDPCT.IDDPCT);
            _DPCT.IDPHONG   = UpdateDPCT.IDPHONG;
            _DPCT.IDDPCT    = UpdateDPCT.IDDPCT;
            _DPCT.NGAY      = UpdateDPCT.NGAY;
            _DPCT.SONGAYO   = UpdateDPCT.SONGAYO;
            _DPCT.THANHTIEN = UpdateDPCT.THANHTIEN;
            _DPCT.IDDP      = UpdateDPCT.IDDP;
            _DPCT.DONGIA    = UpdateDPCT.DONGIA;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
            }
        }
        public void Delete(int MaDatPhong, int MaPhong)
        {
            tb_DATPHONGCHITIET _DPCT = db.tb_DATPHONGCHITIET.First(x => x.IDDP == MaDatPhong && x.IDPHONG ==MaPhong );
            db.tb_DATPHONGCHITIET.Remove(_DPCT);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
            }
        }
        public void DeleteAll(int IDdatphong)
        {
            List<tb_DATPHONGCHITIET> listCT = db.tb_DATPHONGCHITIET.Where(x => x.IDDP == IDdatphong).ToList();
            try
            {
                db.tb_DATPHONGCHITIET.RemoveRange(listCT);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
            }
        }
    }
}
