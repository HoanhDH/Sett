using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopDoGiaDung.Models;

namespace ShopDoGiaDung.Configurations
{
    public class HoaDonChiTietConfiguration : IEntityTypeConfiguration<HoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.SoLuong).HasColumnType("int").IsRequired();
            builder.Property(p => p.Gia).HasColumnType("float").IsRequired();
            builder.HasOne(p => p.hoaDons).WithMany(q => q.hoaDonChiTiets).HasForeignKey(p => p.IDHoaDon);
            builder.HasOne(p => p.sanPhams).WithMany(q => q.hoaDonChiTiets).HasForeignKey(p => p.IDSanPham);
        }
    }
}
