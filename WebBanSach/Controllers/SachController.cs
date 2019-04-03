using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanSach.Models.EF;

namespace WebBanSach.Controllers
{
    public class SachController : Controller
    {
        // GET: Sach
       
        QuanLyBanSachDbContext db = new QuanLyBanSachDbContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult SachMoi()
        {
            var IsSachMoi = db.Saches.Where(s=> s.Soluong == 12).Take(3).ToList();
            return PartialView(IsSachMoi);
        }
        //Xem chi tiết
        public ViewResult XemChiTiet(int Masach=0)
        {
            Sach sach = db.Saches.SingleOrDefault(n=>n.Masach==Masach);
            if (sach == null)
            { // Trả về trang báo lỗi
                Response.StatusCode=404;
                return null;
            }
            return View(sach);
        }
    }
}

