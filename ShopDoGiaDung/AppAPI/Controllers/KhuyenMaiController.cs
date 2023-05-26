using AppData.IRepositories;
using AppData.Repositories;
using Microsoft.AspNetCore.Mvc;
using ShopDoGiaDung.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhuyenMaiController : ControllerBase
    {
        private readonly IAllRepositories<KhuyenMai> irepos;
        ShoppingDBContext context = new ShoppingDBContext();
        public KhuyenMaiController()
        {
            irepos = new AllRepositories<KhuyenMai>(context, context.khuyenMais);
        }
        // GET: api/<KhuyenMaiController>
        [HttpGet]
        public IEnumerable<KhuyenMai> GetAllKhuyenMai()
        {
            return irepos.GetAll();
        }
        // POST api/<KhuyenMaiController>
        [HttpPost("create-khuyenmai")]
        public bool CreateKhuyenMai(Guid idhoadon, int phantramduocgiam, bool trangthai)
        {
            KhuyenMai khuyenMai = new KhuyenMai();
            khuyenMai.IDHoaDon = idhoadon;
            khuyenMai.PhanTramDuocGiam = phantramduocgiam;
            khuyenMai.TrangThai = trangthai;
            return irepos.CreateItem(khuyenMai);
        }

        // PUT api/<KhuyenMaiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<KhuyenMaiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
