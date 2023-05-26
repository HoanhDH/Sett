using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ShopDoGiaDung.Models
{
    public class ShoppingDBContext : DbContext
    {
        public ShoppingDBContext() { }
        public ShoppingDBContext(DbContextOptions options) : base(options) { }
        public DbSet<ChucVu> chucVus { get; set; }
        public DbSet<DanhMucSanPham> danhMucSanPhams { get; set; }
        public DbSet<Giohang> giohangs { get; set; }
        public DbSet<GioHangChiTIet> gioHangChiTIets { get; set; }
        public DbSet<HoaDon> hoaDons { get; set; }
        public DbSet<HoaDonChiTiet> hoaDonChiTiets { get; set; }
        public DbSet<KhuyenMai> khuyenMais { get; set; }
        public DbSet<NguoiDung> nguoiDungs { get; set; }
        public DbSet<PhanHoi> phanHois { get; set; }
        public DbSet<SanPham> sanPhams { get; set; }
        public DbSet<Voucher> vouchers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=HOANH;Initial Catalog=ShopDoGiaDung;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
