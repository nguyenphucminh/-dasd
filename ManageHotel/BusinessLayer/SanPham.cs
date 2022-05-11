using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
    public class SanPham
    {
        Entities db;
        public SanPham()
        {
            db = Entities.CreateEntities();
        }
        public tb_SANPHAM GetItem(int MaSanPham)
        {
            return db.tb_SANPHAM.FirstOrDefault(x => x.IDSP == MaSanPham);
        }
        public List<tb_SANPHAM> GetAll()
        {
            return db.tb_SANPHAM.ToList();
        }
        public void Add(tb_SANPHAM AddSP)
        {
            try
            {
                db.tb_SANPHAM.Add(AddSP);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
            }
        }
        public void Update(tb_SANPHAM UpdateSP)
        {
            tb_SANPHAM _SP = db.tb_SANPHAM.FirstOrDefault(x => x.IDSP == UpdateSP.IDSP);
            _SP.IDSP = UpdateSP.IDSP;
            _SP.TENSP = UpdateSP.TENSP;
            _SP.DISABLED = UpdateSP.DISABLED;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error encountered during data processing, please try again !" + ex.Message);
            }
        }
        public void Delete(int MaSanPham)
        {
            tb_SANPHAM _SP = db.tb_SANPHAM.First(x => x.IDSP == MaSanPham);
            db.tb_SANPHAM.Remove(_SP);
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
