using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanSach.Models.EF;

namespace WebBanSach.Areas.AdminSite.Controllers
{
    public class AdminQuanLySachController : Controller
    {
        QuanLyBanSachDbContext db = new QuanLyBanSachDbContext();

        // GET: AdminSite/AdminQuanLySach
        public ActionResult TatCaSach()
        {
            var TatCaSach = db.Saches.Join(db.Nhaxuatbans, sach => sach.Manxb, nxb => nxb.Manxb, (sach, nxb) => sach)
                                      .Join(db.Chudes, sach => sach.Macd, chude => chude.Macd, (sach, chude) => sach)
                                      .Join(db.Tacgias, sach => sach.Matacgia, tacgia => tacgia.Matacgia, (sach, tacgia) => sach)
                                      .ToList();
            ViewBag.TatCaSach = TatCaSach;
            return View();
        }
        public ActionResult ViewThemSach()
        {
            var TatCaChuDe = db.Chudes.ToList();
            var TatCaTacGia = db.Tacgias.ToList();
            var TatCaNXB = db.Nhaxuatbans.ToList();
            ViewBag.TatCaChuDe = TatCaChuDe;
            ViewBag.TatCaTacGia = TatCaTacGia;
            ViewBag.TatCaNXB = TatCaNXB;
            return View();
        }
        [HttpPost]
        public ActionResult ThemSach()
        {
            Sach sach = new Sach();
            return RedirectToAction("TatCaSach");
            
        }
        public ActionResult SuaSach()
        {
            return View();
        }
    }
}