using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopDoGiaDung.Models;

namespace ShopDoGiaDung.Configurations
{
    public class GioHangChiTietConfiguration : IEntityTypeConfiguration<GioHangChiTIet>
    {
        public void Configure(EntityTypeBuilder<GioHangChiTIet> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.SoLuong).HasColumnType("int").IsRequired();
            builder.Property(p => p.ThanhTien).HasColumnType("float").IsRequired();
            builder.HasOne(p => p.gioHangs).WithMany(q => q.gioHangChiTIets).HasForeignKey(p => p.IDGioHang);
            builder.HasOne(p => p.sanPhams).WithMany(q => q.gioHangChiTIets).HasForeignKey(p => p.IDSanPham);
        }
    }
}
