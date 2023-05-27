using ShopDoGiaDung.Models;

namespace AppAPI.IServices
{
    public interface IHoaDon
    {
        public bool AddHoaDon(HoaDon hoadon);
        public bool UpdateHoaDon(HoaDon hoadon);
        public bool DeleteHoaDon(Guid id);
        public List<HoaDon> GetAllHoaDon();
        public HoaDon GetBillById(Guid id);
        //public List<Bill> GetBillByName(string name);
    }
}
