namespace ShopDoGiaDung.Models
{
    public class GioHangChiTIet
    {
        public Guid ID { get; set; }
        public Guid IDSanPham { get; set; }
        public Guid IDNguoiDung { get; set; }
        public Guid IDGioHang { get; set; }
        public long SoLuong { get; set; }
        public Double ThanhTien { get; set; }
        public virtual Giohang gioHangs { get; set; }
        public virtual SanPham sanPhams { get; set; }
    }
}
