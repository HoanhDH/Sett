namespace ShopDoGiaDung.Models
{
    public class KhuyenMai
    {
        public Guid ID { get; set; }
        public Guid IDHoaDon { get; set; }
        public long PhanTramDuocGiam { get; set; }
        public bool TrangThai { get; set; }
        public ICollection<HoaDon> hoaDons { get; set;}
    }
}
