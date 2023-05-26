using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopDoGiaDung.Models;

namespace ShopDoGiaDung.Configurations
{
    public class SanPhamConfiguration : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.Ten).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(p => p.Anh).HasColumnType("varchar(200)").IsRequired();
            builder.Property(p => p.NhaCungCap).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(p => p.NSX).HasColumnType("datetime").IsRequired();
            builder.Property(p => p.GiaBan).HasColumnType("float").IsRequired();
            builder.Property(p => p.SoLuongTon).HasColumnType("int").IsRequired();
            builder.Property(p => p.MoTa).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(p => p.DanhMuc).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(p => p.TrangThai).HasColumnType("int").IsRequired();
            builder.HasOne(p => p.danhMucSanPhams).WithMany(q => q.sanPhams).HasForeignKey(p => p.ID);
            builder.HasMany(p => p.vouchers).WithMany(q => q.sanPhams);
        }
    }
}
