namespace ShopDoGiaDung.Models
{
    public class PhanHoi
    {
        public Guid ID { get; set; }
        public Guid IDNguoiDung { get; set; }
        public Guid IDSanPham { get; set; }
        public string NoiDungPhanHoi { get; set; }
        public string LoaiPhanHoi { get; set; }
        public bool TrangThai { get; set; }
        public virtual NguoiDung nguoiDungs { get; set; }
        public virtual SanPham sanPhams { get; set; }
    }
}
