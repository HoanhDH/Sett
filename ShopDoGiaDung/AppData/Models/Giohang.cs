namespace ShopDoGiaDung.Models
{
    public class Giohang
    {
        public Guid IDNguoiDung { get; set; }
        public bool TrangThai { get; set; }
        public ICollection<GioHangChiTIet> gioHangChiTIets { get; set; }
    }
}
