using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopDoGiaDung.Models;

namespace ShopDoGiaDung.Configurations
{
    public class KhuyenMaiConfiguration : IEntityTypeConfiguration<KhuyenMai>
    {
        public void Configure(EntityTypeBuilder<KhuyenMai> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.PhanTramDuocGiam).HasColumnType("int").IsRequired();
            builder.Property(p => p.TrangThai).HasColumnType("int").IsRequired();
        }
    }
}
