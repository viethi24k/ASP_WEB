using baitap06ltwed.Models;
using Microsoft.AspNetCore.Mvc;

namespace baitap06ltwed.Controllers
{
    public class taikhoancontroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DangKi(TaiKhoanViewModel taikhoan)
        {
            if (taikhoan != null && taikhoan.Password != null && taikhoan.Password.Length > 0)
            {
                taikhoan.Password = taikhoan.Password + "_da_ma_hoa";
            }
            return View(taikhoan);
        }
    }
}
