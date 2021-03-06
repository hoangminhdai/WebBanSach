﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanSach.Models.EF;

namespace WebBanSach.Controllers
{
    public class DangKiController : Controller
    {
        QuanLyBanSachDbContext db = new QuanLyBanSachDbContext();
        // GET: DangKi
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult ThemTaiKhoan(Khachhang user)
        {
            try
            {
                user.Quyen = 2;
                db.Khachhangs.Add(user);
                db.SaveChanges();
                
                if (Session["USER_SESSION"] == null)
                {
                    Session.Add("USER_SESSION", user);
                }
                else
                {
                    Session["USER_SESSION"] = user;
                }
                return Json(new { status = true });
            }
            catch (Exception ex)
            {
                return Json(new { status = false });
            }
        }
    }
}