using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopDoGiaDung.Models;

namespace ShopDoGiaDung.Configurations
{
    public class NguoiDungConfiguration : IEntityTypeConfiguration<NguoiDung>
    {
        public void Configure(EntityTypeBuilder<NguoiDung> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.Ten).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(p => p.NgaySinh).HasColumnType("datetime").IsRequired();
            builder.Property(p => p.DiaChi).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(p => p.DienThoai).HasColumnType("nvarchar(15)").IsRequired();
            builder.Property(p => p.TaiKhoan).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(p => p.MatKhau).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(p => p.TrangThai).HasColumnType("int").IsRequired();
            builder.HasOne(p => p.chucVus).WithMany(q => q.nguoiDungs).HasForeignKey(p => p.IDChucVu);
        }
    }
}
