using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
    public class DatPhongSanPham
    {
        Entities db;
        public DatPhongSanPham ()
        {
            db = Entities.CreateEntities();
        }
        public List<OBJ_DSSP> GetAllByDatPhong(int IDDP)
        {
            var listget = db.tb_DATPHONGSP.Where(x => x.IDDP == IDDP).ToList();
            List<OBJ_DSSP> listDPSP = new List<OBJ_DSSP>();
            OBJ_DSSP SP;
            foreach (var item in listget)
            {
                SP = new OBJ_DSSP();
                SP.IDDPSP = item.IDDPSP;
                SP.IDDP = item.IDDP;
                SP.IDPHONG = item.IDPHONG;
                var phong = db.tb_PHONG.FirstOrDefault(x => x.IDPHONG == item.IDPHONG);
                SP.TENPHONG = phong.TENPHONG;
                SP.IDSP = item.IDDPSP;
                var sanpham = db.tb_SANPHAM.FirstOrDefault(x => x.IDSP == item.IDSP);
                SP.TENSP = sanpham.TENSP;
                SP.SOLUONG = item.SOLUONG;
                SP.DONGIA = item.DONGIA;
                SP.THANHTIEN = item.THANHTIEN;
                listDPSP.Add(SP);
            }
            return listDPSP; 
        }

        public List<tb_DATPHONGSP> GetAllByPhong(int IDDP, int IDDPCT)
        {
            return db.tb_DATPHONGSP.Where(x => x.IDDP == IDDP && x.IDDPCT == IDDPCT).ToList();
        }



        public void Add(tb_DATPHONGSP AddDPSP)
        {
            try
            {
                db.tb_DATPHONGSP.Add(AddDPSP);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
            }
        }

        public void Update(tb_DATPHONGSP DPSP)
        {
            tb_DATPHONGSP sp = db.tb_DATPHONGSP.FirstOrDefault(x => x.IDDPSP == DPSP.IDDPSP);
            sp.IDDP = DPSP.IDDP;
            sp.IDPHONG = DPSP.IDPHONG;
            sp.SOLUONG = DPSP.SOLUONG;
            sp.NGAY = DPSP.NGAY;
            sp.DONGIA = DPSP.DONGIA;
            sp.THANHTIEN = DPSP.THANHTIEN;
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteAll(int IDdatphong)
        {
            List<tb_DATPHONGSP> listSP = db.tb_DATPHONGSP.Where(x => x.IDDP == IDdatphong).ToList();
            try
            {
                db.tb_DATPHONGSP.RemoveRange(listSP);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
            }
        }
        public void DeleteAllByPhong(int IDdatphong, int IDPhong)
        {
            List<tb_DATPHONGSP> listSP = db.tb_DATPHONGSP.Where(x => x.IDDP == IDdatphong && x.IDPHONG == IDPhong).ToList();
            try
            {
                db.tb_DATPHONGSP.RemoveRange(listSP);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
            }
        }
    }
}
