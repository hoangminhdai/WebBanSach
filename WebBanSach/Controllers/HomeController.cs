using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanSach.Models.EF;

namespace WebBanSach.Controllers
{
    public class HomeController : Controller
    {
        QuanLyBanSachDbContext db = new QuanLyBanSachDbContext();
        public ActionResult Index()
        {
            List<Sach> lstSachMoi = db.Saches.Where(item => item.Ngaycapnhat == new DateTime(2019, 04, 02)).ToList();
            List<Sach> lstSachNoiBat = db.Saches.Where(item => item.Ngaycapnhat == new DateTime(2019, 04, 03)).ToList();

            ViewBag.ListSachMoi = lstSachMoi;
            ViewBag.ListSachNoiBat = lstSachNoiBat;
            return View();
        }
    }
}