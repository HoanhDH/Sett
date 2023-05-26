using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopDoGiaDung.Models;

namespace ShopDoGiaDung.Configurations
{
    public class ChucVuConfiguration : IEntityTypeConfiguration<ChucVu>
    {
        public void Configure(EntityTypeBuilder<ChucVu> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.Ten).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(p => p.MoTa).HasColumnType("nvarchar(500)").IsRequired();
            builder.Property(p => p.TrangThai).HasColumnType("int").IsRequired();
        }
    }
}
