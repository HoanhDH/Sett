using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopDoGiaDung.Models;

namespace ShopDoGiaDung.Configurations
{
    public class DanhMucSanPhamConfiguration : IEntityTypeConfiguration<DanhMucSanPham>
    {
        public void Configure(EntityTypeBuilder<DanhMucSanPham> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.MoTa).HasColumnType("nvarchar(500)").IsRequired();
            builder.Property(p => p.TrangThai).HasColumnType("int").IsRequired();
            builder.HasMany(p => p.vouchers).WithMany(q => q.danhMucSanPhams);
        }
    }
}
