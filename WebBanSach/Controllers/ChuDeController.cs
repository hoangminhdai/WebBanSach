using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanSach.Models.EF;

namespace WebBanSach.Controllers
{
    public class ChuDeController : Controller
    {
        QuanLyBanSachDbContext db = new QuanLyBanSachDbContext();
        // GET: ChuDe
        public ActionResult chude()
        {
            return PartialView(db.Chudes.Take(5).ToList());
        }
       // Sách theo chủ đề
       public ViewResult SachTheoChuDe(int MaChuDe=0)
        {
            //Kiểm tra chủ đề tồn  tại hay không
            Chude cd = db.Chudes.SingleOrDefault(n => n.Macd == MaChuDe);
            {
                Response.StatusCode = 404;
                return null;
            }
            //Truy xuất danh sách các quyển sách theo chủ đề
           
        }
    }
}