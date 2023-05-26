using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopDoGiaDung.Migrations
{
    public partial class ShopDoGiaDung : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "chucVus",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chucVus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "danhMucSanPhams",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDVoucher = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ThuocTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_danhMucSanPhams", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "giohangs",
                columns: table => new
                {
                    IDNguoiDung = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_giohangs", x => x.IDNguoiDung);
                });

            migrationBuilder.CreateTable(
                name: "khuyenMais",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhanTramDuocGiam = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khuyenMais", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "vouchers",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenVocher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoTienGiam = table.Column<int>(type: "int", nullable: false),
                    NgayApDung = table.Column<DateTime>(type: "datetime", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vouchers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "nguoiDungs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDChucVu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DienThoai = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    TaiKhoan = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nguoiDungs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_nguoiDungs_chucVus_IDChucVu",
                        column: x => x.IDChucVu,
                        principalTable: "chucVus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sanPhams",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Anh = table.Column<string>(type: "varchar(200)", nullable: false),
                    NhaCungCap = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    NSX = table.Column<DateTime>(type: "datetime", nullable: false),
                    GiaBan = table.Column<double>(type: "float", nullable: false),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DanhMuc = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPhams", x => x.ID);
                    table.ForeignKey(
                        name: "FK_sanPhams_danhMucSanPhams_ID",
                        column: x => x.ID,
                        principalTable: "danhMucSanPhams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucSanPhamVoucher",
                columns: table => new
                {
                    danhMucSanPhamsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    vouchersID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucSanPhamVoucher", x => new { x.danhMucSanPhamsID, x.vouchersID });
                    table.ForeignKey(
                        name: "FK_DanhMucSanPhamVoucher_danhMucSanPhams_danhMucSanPhamsID",
                        column: x => x.danhMucSanPhamsID,
                        principalTable: "danhMucSanPhams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DanhMucSanPhamVoucher_vouchers_vouchersID",
                        column: x => x.vouchersID,
                        principalTable: "vouchers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDons",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDNguoiDung = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime", nullable: false),
                    NgayThanhToan = table.Column<DateTime>(type: "datetime", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_hoaDons_khuyenMais_ID",
                        column: x => x.ID,
                        principalTable: "khuyenMais",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDons_nguoiDungs_IDNguoiDung",
                        column: x => x.IDNguoiDung,
                        principalTable: "nguoiDungs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gioHangChiTIets",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDNguoiDung = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDGioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    ThanhTien = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gioHangChiTIets", x => x.ID);
                    table.ForeignKey(
                        name: "FK_gioHangChiTIets_giohangs_IDGioHang",
                        column: x => x.IDGioHang,
                        principalTable: "giohangs",
                        principalColumn: "IDNguoiDung",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_gioHangChiTIets_sanPhams_IDSanPham",
                        column: x => x.IDSanPham,
                        principalTable: "sanPhams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "phanHois",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDNguoiDung = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoiDungPhanHoi = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    LoaiPhanHoi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phanHois", x => x.ID);
                    table.ForeignKey(
                        name: "FK_phanHois_nguoiDungs_IDNguoiDung",
                        column: x => x.IDNguoiDung,
                        principalTable: "nguoiDungs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_phanHois_sanPhams_IDSanPham",
                        column: x => x.IDSanPham,
                        principalTable: "sanPhams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanPhamVoucher",
                columns: table => new
                {
                    sanPhamsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    vouchersID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhamVoucher", x => new { x.sanPhamsID, x.vouchersID });
                    table.ForeignKey(
                        name: "FK_SanPhamVoucher_sanPhams_sanPhamsID",
                        column: x => x.sanPhamsID,
                        principalTable: "sanPhams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhamVoucher_vouchers_vouchersID",
                        column: x => x.vouchersID,
                        principalTable: "vouchers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDonChiTiets",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Gia = table.Column<double>(type: "float", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDonChiTiets", x => x.ID);
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiets_hoaDons_IDHoaDon",
                        column: x => x.IDHoaDon,
                        principalTable: "hoaDons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiets_sanPhams_IDSanPham",
                        column: x => x.IDSanPham,
                        principalTable: "sanPhams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DanhMucSanPhamVoucher_vouchersID",
                table: "DanhMucSanPhamVoucher",
                column: "vouchersID");

            migrationBuilder.CreateIndex(
                name: "IX_gioHangChiTIets_IDGioHang",
                table: "gioHangChiTIets",
                column: "IDGioHang");

            migrationBuilder.CreateIndex(
                name: "IX_gioHangChiTIets_IDSanPham",
                table: "gioHangChiTIets",
                column: "IDSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiets_IDHoaDon",
                table: "hoaDonChiTiets",
                column: "IDHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiets_IDSanPham",
                table: "hoaDonChiTiets",
                column: "IDSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_IDNguoiDung",
                table: "hoaDons",
                column: "IDNguoiDung");

            migrationBuilder.CreateIndex(
                name: "IX_nguoiDungs_IDChucVu",
                table: "nguoiDungs",
                column: "IDChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_phanHois_IDNguoiDung",
                table: "phanHois",
                column: "IDNguoiDung");

            migrationBuilder.CreateIndex(
                name: "IX_phanHois_IDSanPham",
                table: "phanHois",
                column: "IDSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamVoucher_vouchersID",
                table: "SanPhamVoucher",
                column: "vouchersID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DanhMucSanPhamVoucher");

            migrationBuilder.DropTable(
                name: "gioHangChiTIets");

            migrationBuilder.DropTable(
                name: "hoaDonChiTiets");

            migrationBuilder.DropTable(
                name: "phanHois");

            migrationBuilder.DropTable(
                name: "SanPhamVoucher");

            migrationBuilder.DropTable(
                name: "giohangs");

            migrationBuilder.DropTable(
                name: "hoaDons");

            migrationBuilder.DropTable(
                name: "sanPhams");

            migrationBuilder.DropTable(
                name: "vouchers");

            migrationBuilder.DropTable(
                name: "khuyenMais");

            migrationBuilder.DropTable(
                name: "nguoiDungs");

            migrationBuilder.DropTable(
                name: "danhMucSanPhams");

            migrationBuilder.DropTable(
                name: "chucVus");
        }
    }
}
