using AppData.IRepositories;
using AppData.Repositories;
using Microsoft.AspNetCore.Mvc;
using ShopDoGiaDung.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChucVuController : ControllerBase
    {
        private readonly IAllRepositories<ChucVu> irepos;
        ShoppingDBContext context = new ShoppingDBContext();
        public ChucVuController()
        {
            irepos = new AllRepositories<ChucVu>(context, context.chucVus);
        }
        // GET: api/<ChucVuController>
        [HttpGet]
        public IEnumerable<ChucVu> GetAllChucVu()
        {
            return irepos.GetAll();
        }

        // POST api/<ChucVuController>
        [HttpPost("create-chucvu")]
        public bool CreateChucVu(string ten, string mota, bool trangthai)
        {
            ChucVu chucVu = new ChucVu();
            chucVu.Ten = ten;
            chucVu.MoTa = mota;
            chucVu.TrangThai = trangthai;
            return irepos.CreateItem(chucVu);
        }

        // PUT api/<ChucVuController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ChucVuController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
