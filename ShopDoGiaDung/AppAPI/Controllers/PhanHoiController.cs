using AppData.IRepositories;
using AppData.Repositories;
using Microsoft.AspNetCore.Mvc;
using ShopDoGiaDung.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhanHoiController : ControllerBase
    {
        private readonly IAllRepositories<PhanHoi> irepos;
        ShoppingDBContext context = new ShoppingDBContext();
        public PhanHoiController()
        {
            irepos = new AllRepositories<PhanHoi>(context, context.phanHois);
        }
        // GET: api/<PhanHoiController>
        [HttpGet]
        public IEnumerable<PhanHoi> GetAllPhanHoi()
        {
            return irepos.GetAll();
        }
        // POST api/<PhanHoiController>
        [HttpPost]
        public bool CreatePhanHoi(Guid idnguoidung, Guid idsanpham, string noidungphanhoi, string loaiphanhoi, bool trangthai)
        {
            PhanHoi phanHoi = new PhanHoi();
            phanHoi.IDNguoiDung = idnguoidung;
            phanHoi.IDSanPham = idsanpham;
            phanHoi.NoiDungPhanHoi = noidungphanhoi;
            phanHoi.LoaiPhanHoi = loaiphanhoi;
            phanHoi.TrangThai = trangthai;
            return irepos.CreateItem(phanHoi);
        }

        // PUT api/<PhanHoiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PhanHoiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
