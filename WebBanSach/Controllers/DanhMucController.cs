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
                Tenchude = "Sách giáo khoa",
                Key = "app"
            });
            lstDanhMuc.Add(new Chude()
            {
                Tenchude = "Sách thiếu nhi",
                Key = "web"
            });
            lstDanhMuc.Add(new Chude()
            {
                Tenchude = "Sách khoa học",
                Key = "logo"
            });
            lstDanhMuc.Add(new Chude()
            {
                Tenchude = "Sách khác",
                Key = "card"
            });

            List<Sach> lstSach = new List<Sach>();
            lstSach.Add(new Sach()
            {
                Hinhminhhoa = "k.jpg",
                Tensach = "Thuật tư tưởng",
                Giakm = 690000,
                Dongia = 960000,
                Chude = new Chude() { Key = "web" }
            });
            lstSach.Add(new Sach()
            {
                Hinhminhhoa = "gk.jpg",
                Tensach = "Đứa bé vẫn sống",
                Giakm = 690000,
                Dongia = 960000,
                Chude = new Chude() { Key = "app" }
            });
            lstSach.Add(new Sach()
            {
                Hinhminhhoa = "z.jpg",
                Tensach = "Sau màn đêm",
                Giakm = 690000,
                Dongia = 960000,
                Chude = new Chude() { Key = "logo" }
            });
            lstSach.Add(new Sach()
            {
                Hinhminhhoa = "t.jpg",
                Tensach = "Một bước yêu, vạn dặm đau",
                Giakm = 690000,
                Dongia = 960000,
                Chude = new Chude() { Key = "app" }
            });
            lstSach.Add(new Sach()
            {
                Hinhminhhoa = "tt.jpg",
                Tensach = "Một bước yêu, vạn dặm đau",
                Giakm = 690000,
                Dongia = 960000,
                Chude = new Chude() { Key = "card" }
            });
            lstSach.Add(new Sach()
            {
                Hinhminhhoa = "zz.jpg",
                Tensach = "Hồng nhan",
                Giakm = 690000,
                Dongia = 960000,
                Chude = new Chude() { Key = "logo" }
            });
            lstSach.Add(new Sach()
            {
                Hinhminhhoa = "gk6.jpg",
                Tensach = "Người từng quen",
                Giakm = 690000,
                Dongia = 960000,
                Chude = new Chude() { Key = "web" }
            });
            lstSach.Add(new Sach()
            {
                Hinhminhhoa = "ttt.jpg",
                Tensach = "Tôi đi code dạo",
                Giakm = 690000,
                Dongia = 960000,
                Chude = new Chude() { Key = "card" }
            });
            lstSach.Add(new Sach()
            {
                Hinhminhhoa = "gk3.jpg",
                Tensach = "From zero to hero",
                Giakm = 690000,
                Dongia = 960000,
                Chude = new Chude() { Key = "app" }
            });
            lstSach.Add(new Sach()
            {
                Hinhminhhoa = "tttt.jpg",
                Tensach = "Tâm lí học phụ nữ",
                Giakm = 690000,
                Dongia = 960000,
                Chude = new Chude() { Key = "logo" }
            });
            lstSach.Add(new Sach()
            {
                Hinhminhhoa = "gk4.jpg",
                Tensach = "Dế Mèn phiêu lưu kí",
                Giakm = 690000,
                Dongia = 960000,
                Chude = new Chude() { Key = "app" }
            });
            lstSach.Add(new Sach()
            {
                Hinhminhhoa = "ttttt.jpg",
                Tensach = "Tiếng gà trưa",
                Giakm = 690000,
                Dongia = 960000,
                Chude = new Chude() { Key = "web" }
            });
            lstSach.Add(new Sach()
            {
                Hinhminhhoa = "gk5.jpg",
                Tensach = "CCNA Sercurity",
                Giakm = 690000,
                Dongia = 960000,
                Chude = new Chude() { Key = "logo" }
            });
            lstSach.Add(new Sach()
            {
                Hinhminhhoa = "kk.jpg",
                Tensach = "Kinh thánh",
                Giakm = 690000,
                Dongia = 960000,
                Chude = new Chude() { Key = "card" }
            });
            lstSach.Add(new Sach()
            {
                Hinhminhhoa = "kkk.jpg",
                Tensach = "Những bài ca bất hủ",
                Giakm = 690000,
                Dongia = 960000,
                Chude = new Chude() { Key = "web" }
            });
            lstSach.Add(new Sach()
            {
                Hinhminhhoa = "kkkk.jpg",
                Tensach = "Tôi và em",
                Giakm = 690000,
                Dongia = 960000,
                Chude = new Chude() { Key = "logo" }
            });




            ViewBag.ListDanhMuc = lstDanhMuc;
            ViewBag.ListSach = lstSach;

            return View();
        }
    }
}