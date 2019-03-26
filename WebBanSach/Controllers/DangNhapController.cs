using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanSach.Models.EF;

namespace WebBanSach.Controllers
{
    public class DangNhapController : Controller
    {
        // GET: DangNhap
        public ActionResult Index()
        {
            if (Session["user"] != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
            
        }
        public ActionResult postLogin(string email, string password)
        {
            Khachhang kh = new Khachhang();
            kh.Email = "abc@gmail.com";
            kh.Matkhau = "123";
            if(email.Equals(kh.Email) && password.Equals(kh.Matkhau))
            {
                Session["user"] = kh;
            }
            return RedirectToAction("Index");
        }
    }
}