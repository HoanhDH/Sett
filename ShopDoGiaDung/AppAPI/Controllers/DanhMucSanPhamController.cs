using AppData.IRepositories;
using AppData.Repositories;
using Microsoft.AspNetCore.Mvc;
using ShopDoGiaDung.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DanhMucSanPhamController : ControllerBase
    {
        private readonly IAllRepositories<DanhMucSanPham> irepos;
        ShoppingDBContext context = new ShoppingDBContext();
        public DanhMucSanPhamController()
        {
            irepos = new AllRepositories<DanhMucSanPham>(context, context.danhMucSanPhams);
        }
        // GET: api/<DanhMucSanPhamController>
        [HttpGet]
        public IEnumerable<DanhMucSanPham> GetAllDanhMucsanPham()
        {
            return irepos.GetAll();
        }
        // POST api/<DanhMucSanPhamController>
        [HttpPost("create-danhmucsanpham")]
        public bool CreateDanhMucSanPham(string thuoctinh, string mota, bool trangthai)
        {
            DanhMucSanPham danhMucSanPham = new DanhMucSanPham();
            danhMucSanPham.ThuocTinh = thuoctinh;
            danhMucSanPham.MoTa = mota;
            danhMucSanPham.TrangThai = trangthai;
            return irepos.CreateItem(danhMucSanPham);
        }

        // PUT api/<DanhMucSanPhamController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DanhMucSanPhamController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
