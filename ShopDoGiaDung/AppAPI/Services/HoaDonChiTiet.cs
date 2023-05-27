using AppAPI.IServices;
using ShopDoGiaDung.Models;

namespace AppAPI.Services
{
    public class HoaDonChiTiet : IHoaDonChiTiet
    {
        public ShoppingDBContext _dbContext;
        public HoaDonChiTiet()
        {
            _dbContext = new ShoppingDBContext();
        }

        public bool AddHoaDonChiTiet(ShopDoGiaDung.Models.HoaDonChiTiet billDetail)
        {
             try
            {
                _dbContext.hoaDonChiTiets.Add(billDetail);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteHoaDonChiTiet(Guid id)
        {
            try
            {
                var billDetailsId = _dbContext.hoaDonChiTiets.Find(id);
                _dbContext.hoaDonChiTiets.Remove(billDetailsId);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<ShopDoGiaDung.Models.HoaDonChiTiet> GetAllHoaDonChiTiet()
        {
            return _dbContext.hoaDonChiTiets.ToList();
        }

        public ShopDoGiaDung.Models.HoaDonChiTiet GetHoaDonByIdChiTiet(Guid id)
        {
            return _dbContext.hoaDonChiTiets.FirstOrDefault(c => c.ID == id);
        }

        public bool UpdateHoaDonChiTiet(ShopDoGiaDung.Models.HoaDonChiTiet billDetail)
        {
            try
            {
                var billDetailsId = _dbContext.hoaDonChiTiets.FirstOrDefault(c => c.ID == billDetail.ID);
                billDetailsId.IDHoaDon = billDetail.IDHoaDon;
                billDetailsId.IDSanPham = billDetail.IDSanPham;
                billDetailsId.Gia = billDetail.Gia;
                billDetailsId.SoLuong = billDetail.SoLuong;
                _dbContext.hoaDonChiTiets.Update(billDetailsId);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
