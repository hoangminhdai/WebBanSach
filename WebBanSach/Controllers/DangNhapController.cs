using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanSach.Models.Common;
using WebBanSach.Models.EF;

namespace WebBanSach.Controllers
{
    public class DangNhapController : Controller
    {
        // GET: DangNhap
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(UserLogin user)
        {
            if (ModelState.IsValid)
            {
                if (user.Username == "admin" && user.Password == "123456")
                {
                    var kh = new Khachhang() { Tendn = user.Username, Matkhau = user.Password };
                    Session.Add("USER_SESSION", kh);
                    return RedirectToAction("Index", "Home");
                } else
                {
                    ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng. Xin kiểm tra lại!");
                }
            }
            return View("Index");
        }

        public ActionResult DangXuat()
        {
            Session.Remove("USER_SESSION");
            return RedirectToAction("Index", "Home");
        }
    }
}