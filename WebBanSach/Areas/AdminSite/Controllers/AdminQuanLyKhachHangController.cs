using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanSach.Models.Common;
using WebBanSach.Models.EF;
using PagedList;

namespace WebBanSach.Areas.AdminSite.Controllers
{
    public class AdminQuanLyKhachHangController : Controller
    {
        QuanLyBanSachDbContext db = new QuanLyBanSachDbContext();
        // GET: AdminSite/AdminQuanLyKhachHang
        [HasCredential(Quyen = 1)]
        public ActionResult TatCaKhachHang(int trang = 1)
        {
            var TatCaKhachHang = db.Khachhangs
                                 .OrderByDescending(kh => kh.Hotenkh)
                                 .ToPagedList(trang, 10);
            return View(TatCaKhachHang);
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