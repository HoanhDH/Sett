using AppData.IRepositories;
using AppData.Repositories;
using Microsoft.AspNetCore.Mvc;
using ShopDoGiaDung.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherController : ControllerBase
    {
        private readonly IAllRepositories<Voucher> irepos;
        ShoppingDBContext context = new ShoppingDBContext();
        public VoucherController()
        {
            irepos = new AllRepositories<Voucher>(context, context.vouchers);
        }
        // GET: api/<VoucherController>
        [HttpGet]
        public IEnumerable<Voucher> GetAllVoucher()
        {
            return irepos.GetAll();
        }
        // POST api/<VoucherController>
        [HttpPost("create-voucher")]
        public bool CreateVoucher(string tenvoucher, int sotiengiam, DateTime ngayapdung, DateTime ngayketthuc, bool trangthai)
        {
            Voucher voucher = new Voucher();
            voucher.TenVocher = tenvoucher;
            voucher.SoTienGiam = sotiengiam;
            voucher.NgayApDung = ngayapdung;
            voucher.NgayKetThuc = ngayketthuc;
            voucher.TrangThai = trangthai;
            return irepos.CreateItem(voucher);
        }

        // PUT api/<VoucherController>/5
        [HttpPut]
        [Route ("edit-voucher")]
        public bool UpdateVoucher(Guid id ,string tenvoucher, int sotiengiam, DateTime ngayapdung, DateTime ngayketthuc, bool trangthai)
        {
            Voucher voucher = irepos.GetAll().First(p => p.ID == id);
            voucher.TenVocher = tenvoucher;
            voucher.SoTienGiam = sotiengiam;
            voucher.NgayApDung = ngayapdung;
            voucher.NgayKetThuc = ngayketthuc;
            voucher.TrangThai = trangthai;
            return irepos.UpdateItem(voucher);
        }

        // DELETE api/<VoucherController>/5
        [HttpDelete("{id}")]
        public bool DeleteVoucher(Guid id)
        {
            Voucher voucher = irepos.GetAll().First(p => p.ID == id);

            return irepos.DeleteItem(voucher);
        }
    }
}
