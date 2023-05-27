using ShopDoGiaDung.Models;

namespace AppAPI.IServices
{
    public interface IHoaDonChiTiet
    {
     
            public bool AddHoaDonChiTiet(HoaDonChiTiet billDetail);
            public bool UpdateHoaDonChiTiet(HoaDonChiTiet billDetail);
            public bool DeleteHoaDonChiTiet(Guid id);
            public List<HoaDonChiTiet> GetAllHoaDonChiTiet();
            public HoaDonChiTiet GetHoaDonByIdChiTiet(Guid id);
       
    }
}
