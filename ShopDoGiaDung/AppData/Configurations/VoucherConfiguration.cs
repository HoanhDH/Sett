using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopDoGiaDung.Models;

namespace ShopDoGiaDung.Configurations
{
    public class VoucherConfiguration : IEntityTypeConfiguration<Voucher>
    {
        public void Configure(EntityTypeBuilder<Voucher> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.SoTienGiam).HasColumnType("int").IsRequired();
            builder.Property(p => p.NgayApDung).HasColumnType("datetime").IsRequired();
            builder.Property(p => p.NgayKetThuc).HasColumnType("datetime").IsRequired();
            builder.Property(p => p.TrangThai).HasColumnType("int").IsRequired();
        }
    }
}
