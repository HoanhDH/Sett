namespace ShopDoGiaDung.Models
{
    public class ChucVu
    {
        public Guid ID { get; set; }
        public string Ten { get; set; }
        public string MoTa { get; set; }
        public bool TrangThai { get; set; }
        public ICollection<NguoiDung> nguoiDungs { get; set; }
    }
}
