namespace ShopDoGiaDung.Models
{
    public class HoaDon
    {
        public Guid ID { get; set; }
        public Guid IDNguoiDung { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public bool TrangThai { get; set; }
        public virtual NguoiDung nguoiDungs { get; set; }   
        public ICollection<HoaDonChiTiet> hoaDonChiTiets { get; set; }
        public virtual KhuyenMai khuyenMais { get; set; }
    }
}
