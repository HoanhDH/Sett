using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopDoGiaDung.Models;

namespace ShopDoGiaDung.Configurations
{
    public class PhanHoiConfiguration : IEntityTypeConfiguration<PhanHoi>
    {
        public void Configure(EntityTypeBuilder<PhanHoi> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.NoiDungPhanHoi).HasColumnType("nvarchar(500)").IsRequired();
            builder.Property(p => p.LoaiPhanHoi).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(p => p.TrangThai).HasColumnType("int").IsRequired();
            builder.HasOne(p => p.nguoiDungs).WithMany(q => q.phanHois).HasForeignKey(p => p.IDNguoiDung);
            builder.HasOne(p => p.sanPhams).WithMany(q => q.phanHois).HasForeignKey(p => p.IDSanPham);
        }
    }
}
