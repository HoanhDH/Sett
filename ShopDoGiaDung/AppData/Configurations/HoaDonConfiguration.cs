using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopDoGiaDung.Models;

namespace ShopDoGiaDung.Configurations
{
    public class HoaDonConfiguration : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.NgayTao).HasColumnType("datetime").IsRequired();
            builder.Property(p => p.NgayThanhToan).HasColumnType("datetime").IsRequired();
            builder.HasOne(p => p.nguoiDungs).WithMany(q => q.hoaDons).HasForeignKey(p => p.IDNguoiDung);
            builder.HasOne(p => p.khuyenMais).WithMany(q => q.hoaDons).HasForeignKey(p => p.ID);
        }
    }
}
