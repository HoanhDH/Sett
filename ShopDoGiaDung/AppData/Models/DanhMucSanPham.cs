namespace ShopDoGiaDung.Models
{
    public class DanhMucSanPham
    {
        public Guid ID { get; set; }
        public Guid IDSanPham { get; set; }
        public Guid IDVoucher { get; set; }
        public string ThuocTinh { get; set; }
        public string MoTa { get; set; }
        public bool TrangThai { get; set; }
        public ICollection<SanPham> sanPhams { get; set;}
        public ICollection<Voucher> vouchers { get; set; }
    }
}
