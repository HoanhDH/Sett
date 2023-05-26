namespace ShopDoGiaDung.Models
{
    public class NguoiDung
    {
        public Guid ID { get; set; }
        public Guid IDChucVu { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public bool TrangThai { get; set; }
        public virtual ChucVu chucVus { get; set; }
        public ICollection<HoaDon> hoaDons { get; set; }
        public ICollection<PhanHoi> phanHois { get; set; }

    }
}
