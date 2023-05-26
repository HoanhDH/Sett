using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopDoGiaDung.Models;

namespace ShopDoGiaDung.Configurations
{
    public class GioHangConfiguration : IEntityTypeConfiguration<Giohang>
    {
        public void Configure(EntityTypeBuilder<Giohang> builder)
        {
            builder.HasKey(p => p.IDNguoiDung);
            builder.Property(p => p.TrangThai).HasColumnType("int").IsRequired();
        }
    }
}
