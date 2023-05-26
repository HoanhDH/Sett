namespace ShopDoGiaDung.Models
{
    public class HoaDonChiTiet
    {
        public Guid ID { get; set; }
        public Guid IDHoaDon { get; set; }
        public Guid IDSanPham { get; set; }
        public double Gia { get; set; }
        public long SoLuong { get; set; }
        public virtual HoaDon hoaDons { get; set; }
        public virtual SanPham sanPhams { get; set; }
    }
}
