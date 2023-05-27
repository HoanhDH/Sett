using AppAPI.IServices;
using Microsoft.EntityFrameworkCore;
using ShopDoGiaDung.Models;

namespace AppAPI.Services
{
    public class HoaDon : IHoaDon
    {
        public ShoppingDBContext _dbContext;
        public HoaDon()
        {
            _dbContext = new ShoppingDBContext();
        }
        public bool AddHoaDon(ShopDoGiaDung.Models.HoaDon bill)
        {
            try
            {
                _dbContext.hoaDons.Add(bill);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteHoaDon(Guid id)
        {
            try
            {
                var billId = _dbContext.hoaDons.FirstOrDefault(c => c.ID == id);
                _dbContext.hoaDons.Remove(billId);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<ShopDoGiaDung.Models.HoaDon> GetAllHoaDon()
        {
            return _dbContext.hoaDons.ToList();
        }

        public ShopDoGiaDung.Models.HoaDon GetBillById(Guid id)
        {
            return _dbContext.hoaDons.FirstOrDefault(c => c.ID == id);
        }

        public bool UpdateHoaDon(ShopDoGiaDung.Models.HoaDon bill)
        {
            try
            {
                var billId = _dbContext.hoaDons.FirstOrDefault(c => c.ID == bill.ID);
                billId.NgayTao = bill.NgayTao;
                billId.IDNguoiDung = bill.IDNguoiDung;
                billId.TrangThai = bill.TrangThai;

                _dbContext.hoaDons.Update(billId);
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
