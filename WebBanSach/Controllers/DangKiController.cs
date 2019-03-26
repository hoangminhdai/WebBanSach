using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanSach.Models.EF;

namespace WebBanSach.Controllers
{
    public class DangKiController : Controller
    {
        // GET: DangKi
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult postSignUp(string HoTen, string Email, string MatKhau)
        {
            List<Khachhang> DanhSachKhachHang = new List<Khachhang>();
            Khachhang kh = new Khachhang();
            kh.Hotenkh = HoTen;
            kh.Email = Email;
            kh.Matkhau = MatKhau;
            DanhSachKhachHang.Add(kh);
            Session["user"] = kh;
            return RedirectToAction("Index", "DangNhap");
        }
    }
}