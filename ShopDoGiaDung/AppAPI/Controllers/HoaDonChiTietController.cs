using AppData.IRepositories;
using AppData.Repositories;
using Microsoft.AspNetCore.Mvc;
using ShopDoGiaDung.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoaDonChiTietController : ControllerBase
    {
        private readonly IAllRepositories<HoaDonChiTiet> irepos;
        ShoppingDBContext context = new ShoppingDBContext();
        public HoaDonChiTietController()
        {
            irepos = new AllRepositories<HoaDonChiTiet>(context, context.hoaDonChiTiets);
        }
        // GET: api/<HoaDonChiTietController>
        [HttpGet]
        public IEnumerable<HoaDonChiTiet> GetAllHoaDonChiTiet()
        {
            return irepos.GetAll();
        }
        // POST api/<HoaDonChiTietController>
        [HttpPost("create-hoadonchitiet")]
        public bool CreateHoaDonChiTiet(Guid idhoadon, Guid idsanpham, double gia, int soluong)
        {
            HoaDonChiTiet hoaDonChiTiet = new HoaDonChiTiet();
            hoaDonChiTiet.IDHoaDon = idhoadon;
            hoaDonChiTiet.IDSanPham = idsanpham;
            hoaDonChiTiet.Gia = gia;
            hoaDonChiTiet.SoLuong = soluong;
            return irepos.CreateItem(hoaDonChiTiet);
        }

        // PUT api/<HoaDonChiTietController>/5
        [HttpPut("{id}")]
        public bool Put(Guid id, int soluong, bool trangthai)
        {
            HoaDonChiTiet hoaDonChiTiet = irepos.GetAll().First(p => p.ID == id);

            hoaDonChiTiet.SoLuong = soluong;
            // hoaDonChiTiet.IDSanPham = trangthai;
            // return irepos.UpdateItem(hoadonchitiet);\
            return irepos.UpdateItem(hoaDonChiTiet);
        }
        

        // DELETE api/<HoaDonChiTietController>/5
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            HoaDonChiTiet hoadon = irepos.GetAll().First(p => p.ID == id);
            return irepos.DeleteItem(hoadon);
        }
    }
}
