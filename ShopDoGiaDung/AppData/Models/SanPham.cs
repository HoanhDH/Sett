namespace ShopDoGiaDung.Models
{
    public class SanPham
    {
        public Guid ID { get; set; }
        public string Ten { get; set; }
        public string Anh { get; set; }
        public string NhaCungCap { get; set; }
        public DateTime NSX { get; set; }
        public Double GiaBan { get; set; }
        public long SoLuongTon { get; set; }
        public string MoTa { get; set; }
        public string DanhMuc { get; set; }
        public bool TrangThai { get; set; }
        public ICollection<HoaDonChiTiet> hoaDonChiTiets { get; set; }
        public ICollection<PhanHoi> phanHois { get; set; }
        public virtual DanhMucSanPham danhMucSanPhams { get; set; }
        public ICollection<Voucher> vouchers { get; set; }
        public ICollection<GioHangChiTIet> gioHangChiTIets { get; set; }
    }
}
