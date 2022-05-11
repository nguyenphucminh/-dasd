using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
    public class DatPhong
    {
        Entities db;
        public DatPhong()
        {
            db = Entities.CreateEntities();
        }
        public tb_DATPHONG GetItem(int MaDatPhong)
        {
            return db.tb_DATPHONG.FirstOrDefault(x => x.IDDP == MaDatPhong);
        }
        public List<tb_DATPHONG> GetAll()
        {
            return db.tb_DATPHONG.ToList();
        }
        public void UpdateStatus(int IDDP)
        {
            tb_DATPHONG dp = db.tb_DATPHONG.FirstOrDefault(x => x.IDDP == IDDP);
            dp.TRANGTHAI = true;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("có lỗi xảy ra trong quá trình sử lý dữ liệu." + ex.Message);
            }
        }

        public List<OBJ_DATPHONG> GetAll(DateTime tungay, DateTime denngay, string macongty, string madonvi)
        {
            var listDP = db.tb_DATPHONG.Where(x=> x.NGAYDAT >= tungay && x.NGAYTRA <= denngay &&x.MACTY == macongty && x.MADVI == madonvi).ToList();
            List<OBJ_DATPHONG> listOBJ_DP = new List<OBJ_DATPHONG>();  // tạo list
            OBJ_DATPHONG dp;  // tạo đối tượng
            foreach (var item in listDP)
            {
                dp = new OBJ_DATPHONG();
                dp.IDDP         = item.IDDP;
                dp.IDKHACH      = item.IDKHACH;
                var namekhach   = db.tb_KHACHHANG.FirstOrDefault(x => x.IDKHACH == item.IDKHACH);
                dp.NAMEKHACH    = namekhach.NAMEKHACH;
                dp.IDUSER       = item.IDUSER;
                dp.NGAYDAT      = item.NGAYDAT;
                dp.NGAYTRA      = item.NGAYTRA;
                dp.SONGUOI      = item.SONGUOI;
                dp.SOTIEN       = item.SOTIEN;
                dp.MACTY        = item.MACTY;
                dp.MADVI        = item.MADVI;
                dp.TRANGTHAI    = item.TRANGTHAI;
                dp.DOAN         = item.DOAN ;
                dp.GHICHU       = item.GHICHU;
                dp.DISABLED     = item.DISABLED;
                listOBJ_DP.Add(dp); 
            }
            return listOBJ_DP;
        }
        //public List<tb_DATPHONG> GetByTang(int IDTang)
        //{
        //    return db.tb_DATPHONG.Where(x => x.IDLAU == IDTang).ToList();
        //}
        //public List<tb_PHONG> GetByLoaiPhong(int IDLoaiPhong)
        //{
        //    return db.tb_PHONG.Where(x => x.IDLOAIPHONG == IDLoaiPhong).ToList();
        //}
        public tb_DATPHONG Add(tb_DATPHONG AddDP)
        {
            try
            {
                db.tb_DATPHONG.Add(AddDP);
                db.SaveChanges();
                return AddDP;
            }
            catch (Exception ex)
            {
                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
            }
        }
        public tb_DATPHONG Update(tb_DATPHONG UpdateDP)
        {
            tb_DATPHONG _DP = db.tb_DATPHONG.FirstOrDefault(x => x.IDDP == UpdateDP.IDDP);
            _DP.IDKHACH = UpdateDP.IDKHACH;
            _DP.NGAYDAT = UpdateDP.NGAYDAT;
            _DP.NGAYTRA = UpdateDP.NGAYTRA;
            _DP.SOTIEN  = UpdateDP.SOTIEN;
            _DP.SONGUOI = UpdateDP.SONGUOI;
            _DP.IDUSER  = UpdateDP.IDUSER;
            _DP.MACTY   = UpdateDP.MACTY;
            _DP.MADVI   = UpdateDP.MADVI;
            _DP.TRANGTHAI = UpdateDP.TRANGTHAI;
            _DP.DOAN    = UpdateDP.DOAN;
            _DP.GHICHU  = UpdateDP.GHICHU;
            _DP.CREATED_DATE = UpdateDP.CREATED_DATE;
            _DP.UPDATE_DATE = UpdateDP.UPDATE_DATE;
            _DP.UPDATE_BY = UpdateDP.UPDATE_BY;
            _DP.DISABLED = UpdateDP.DISABLED;
            try
            {
                db.SaveChanges();
                return UpdateDP;
            }
            catch (Exception ex)
            {
                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
            }
        }
        public void Delete(int MaDatPhong)
        {
            tb_DATPHONG _DP = db.tb_DATPHONG.FirstOrDefault(x => x.IDDP == MaDatPhong);
            db.tb_DATPHONG.Remove(_DP);
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
