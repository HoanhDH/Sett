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
        [HttpPut]
        [Route("edit-khuyenmai")]
        public bool Put(Guid id, int phantramduocgiam, bool trangthai)
        {
            KhuyenMai khuyenmai = irepos.GetAll().First(p => p.ID == id);
       
            khuyenmai.PhanTramDuocGiam = phantramduocgiam;
            khuyenmai.TrangThai = trangthai;
            return irepos.UpdateItem(khuyenmai);
        }

        // DELETE api/<KhuyenMaiController>/5
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            KhuyenMai khuyenmai = irepos.GetAll().First(p => p.ID == id);
            return irepos.DeleteItem(khuyenmai);
        }
    }
}
