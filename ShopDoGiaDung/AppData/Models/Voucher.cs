namespace ShopDoGiaDung.Models
{
    public class Voucher
    {
        public Guid ID { get; set; }
        public Guid IDSanPham { get; set; }
        public string TenVocher { get; set; }
        public double SoTienGiam { get; set; }
        public DateTime NgayApDung { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public bool TrangThai { get; set; }
        public ICollection<SanPham> sanPhams { get; set;}
        public ICollection<DanhMucSanPham> danhMucSanPhams { get; set; }
    }
}
