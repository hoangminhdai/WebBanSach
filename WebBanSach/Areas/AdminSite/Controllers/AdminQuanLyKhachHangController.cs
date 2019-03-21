using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBanSach.Areas.AdminSite.Controllers
{
    public class AdminQuanLyKhachHangController : Controller
    {
        // GET: AdminSite/AdminQuanLyKhachHang
        public ActionResult TatCaKhachHang()
        {
            return View();
        }
        public ActionResult ThemKhachHang()
        {
            return View();
        }
        public ActionResult SuaKhachHang()
        {
            return View();
        }
    }
}