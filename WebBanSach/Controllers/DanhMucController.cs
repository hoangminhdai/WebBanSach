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
        public ActionResult Index()
        {
            List<Chude> lstDanhMuc = new List<Chude>();
            lstDanhMuc.Add(new Chude()
            {
                Tenchude = "Sách giáo khoa"
            });
            lstDanhMuc.Add(new Chude()
            {
                Tenchude = "Sách thiếu nhi"
            });
            lstDanhMuc.Add(new Chude()
            {
                Tenchude = "Sách khoa học"
            });
            lstDanhMuc.Add(new Chude()
            {
                Tenchude = "Sách khác"
            });

            List<Sach> lstSach = new List<Sach>();
            Sach sach = new Sach()
            {
                Hinhminhhoa = "k.jpg",
                Tensach = "Thuật tư tưởng",
                Giakm = 690000,
                Dongia = 960000
            };
            lstSach.Add(sach);

            sach.Hinhminhhoa = "gk.jpg";
            lstSach.Add(sach);



            ViewBag.ListDanhMuc = lstDanhMuc;

            return View();
        }
    }
}