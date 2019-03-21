using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBanSach.Areas.AdminSite.Controllers
{
    public class AdminQuanLySachController : Controller
    {
        // GET: AdminSite/AdminQuanLySach
        public ActionResult TatCaSach()
        {
            return View();
        }
        public ActionResult ThemSach()
        {
            return View();
        }
        public ActionResult SuaSach()
        {
            return View();
        }
    }
}