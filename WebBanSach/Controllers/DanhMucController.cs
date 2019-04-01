using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanSach.Models.EF;

namespace WebBanSach.Controllers
{
    public class DanhMucController : Controller
    {
        // GET: DanhMuc
        QuanLyBanSachDbContext db = new QuanLyBanSachDbContext();
        public ActionResult Index()
        {
            var model = db.Saches.ToList();
            return View(model);
        }
        public ActionResult Detail(int Masach)
        {
            var model = db.Saches.Find(Masach);
            return View(model);
        }
        public ActionResult Add(int Masach)
        {
            var s = db.Saches.Find(Masach);
            return Json(s, JsonRequestBehavior.AllowGet);
        }
    }
}