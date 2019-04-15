using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanSach.Models.Common;
using WebBanSach.Models.EF;

namespace WebBanSach.Areas.AdminSite.Controllers
{
    public class AdminDangNhapController : Controller
    {
        QuanLyBanSachDbContext db = new QuanLyBanSachDbContext();
        // GET: AdminSite/AdminDangNhap
        public ActionResult Index(string returnUrl)
        {
<<<<<<< HEAD
            if (string.IsNullOrEmpty(returnUrl) && Request.UrlReferrer != null)
                returnUrl = Server.UrlEncode(Request.UrlReferrer.PathAndQuery);

            if (Url.IsLocalUrl(returnUrl) && !string.IsNullOrEmpty(returnUrl))
            {
                ViewBag.ReturnURL = returnUrl;
            }
=======
            ViewBag.ReturnUrl = returnUrl;
>>>>>>> 06c00e65d6b5c922b5e25db1c8fb3e6c32ac9cf8
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserLogin user, string returnUrl)
        {
<<<<<<< HEAD
            string decodedUrl = "";
            if (ModelState.IsValid)
            {
                Khachhang khachang = db.Khachhangs.SingleOrDefault(kh => kh.Email == user.Username && kh.Matkhau == user.Password);
                if (khachang != null && khachang.Quyen == 1)
                {
                    Session.Add("ADMIN_SESSION", khachang);
                    if (!string.IsNullOrEmpty(returnUrl))
                    {
                        decodedUrl = Server.UrlDecode(returnUrl);
                        if (Url.IsLocalUrl(decodedUrl))
                        {
                            return Redirect(decodedUrl);
                        }
                    }
=======
            if (ModelState.IsValid)
            {
                Khachhang khachang = db.Khachhangs.SingleOrDefault(kh => kh.Tendn == user.Username && kh.Matkhau == user.Password);
                if (khachang != null && khachang.Quyen == 1)
                {
                    Session.Add("ADMIN_SESSION", khachang);
>>>>>>> 06c00e65d6b5c922b5e25db1c8fb3e6c32ac9cf8
                    return RedirectToAction("TatCaSach", "AdminQuanLySach");
                }
            }
            return RedirectToAction("Index");

        }
        [HttpPost]
        public ActionResult Logout()
        {
            Session.Remove("ADMIN_SESSION");
            return RedirectToAction("Index");
        }
    }
}