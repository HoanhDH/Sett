using AppData.IRepositories;
using AppData.Repositories;
using Microsoft.AspNetCore.Mvc;
using ShopDoGiaDung.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoaDonController : ControllerBase
    {
        private readonly IAllRepositories<HoaDon> irepos;
        ShoppingDBContext context = new ShoppingDBContext();
        public HoaDonController()
        {
            irepos = new AllRepositories<HoaDon>(context, context.hoaDons);
        }
        // GET: api/<HoaDonController>
        [HttpGet]
        public IEnumerable<HoaDon> GetAllHoaDon()
        {
            return irepos.GetAll();
        }
        // POST api/<HoaDonController>
        [HttpPost("create-hoadon")]
        public bool CreateHoaDon(Guid idnguoidung, DateTime ngaytao, DateTime ngaythanhtoan, bool trangthai)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.ID = Guid.NewGuid();
            hoaDon.IDNguoiDung = idnguoidung;
            hoaDon.NgayTao = ngaytao;
            hoaDon.NgayThanhToan = ngaythanhtoan;
            hoaDon.TrangThai = trangthai;
            return irepos.CreateItem(hoaDon);
        }

        // PUT api/<HoaDonController>/5
        [HttpPut("{id}")]
        public bool Put(Guid id, Guid khuyenmai, bool trangthai)
        {
            HoaDon hoaDon = irepos.GetAll().First(p => p.ID == id);

            //hoaDon.khuyenMais = khuyenmai;
            return irepos.UpdateItem(hoaDon);
        }

        // DELETE api/<HoaDonController>/5
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            HoaDon hoadon = irepos.GetAll().First(p => p.ID == id);
            return irepos.DeleteItem(hoadon);
        }
    }
}
