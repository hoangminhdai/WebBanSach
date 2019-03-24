using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanSach.Models.EF;

namespace WebBanSach.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Sach> lstSachMoi = new List<Sach>();
            lstSachMoi.Add(new Sach()
            {
                Tensach = "Những đứa con của bóng tối",
                Hinhminhhoa = "test.jpg"
            });
            lstSachMoi.Add(new Sach()
            {
                Tensach = "Truyện ngắn hay 2018",
                Hinhminhhoa = "-truyen-ngan-hay-2018_94009_1.jpg"
            });
            lstSachMoi.Add(new Sach()
            {
                Tensach = "3 phút thiền",
                Hinhminhhoa = "3-phut-thien_95889_1.jpg"
            });
            lstSachMoi.Add(new Sach()
            {
                Tensach = "365 ngày hoàng đạo Song Tử",
                Hinhminhhoa = "365-ngay-hoang-dao-song-tu-tai-ban-2018-_90680_1.jpg"
            });
            lstSachMoi.Add(new Sach()
            {
                Tensach = "Con nít con nôi",
                Hinhminhhoa = "76171_con-nit-con-noi-kiddie-kiddo-song-ngu-viet-anh-phien-ban-li-xi-tet_75993_1.jpg"
            });
            lstSachMoi.Add(new Sach()
            {
                Tensach = "Bí quyết kinh doanh của Shark Mark Cuban",
                Hinhminhhoa = "america-shark-tank-ren-luyen-y-chi-chien-thang-cung-shark-mark-cuban_93708_1.jpg"
            });

            List<Sach> lstSachNoiBat = new List<Sach>();
            lstSachNoiBat.Add(new Sach()
            {
                Hinhminhhoa = "test2.jpg",
                Tensach = "Những \"mẹo\" thích nghi tài tình blahhhhhhhhhhhhhhhhhhhhhhhhhhh",
                Dongia = 120000,
                Giakm = 100000,
            });
            lstSachNoiBat.Add(new Sach()
            {
                Hinhminhhoa = "ban-be-toi-van-ngom-ca-roi_91155_1.jpg",
                Tensach = "Bạn bè tôi vẫn ngỏm cả rồi",
                Dongia = 36000
            });
            lstSachNoiBat.Add(new Sach()
            {
                Hinhminhhoa = "chan-troi-cua-dien-anh_75167_2.jpg",
                Tensach = "Chân trời của hình ảnh",
                Dongia = 960000,
                Giakm = 690000,
            });
            lstSachNoiBat.Add(new Sach()
            {
                Hinhminhhoa = "cho-doi-thien-su-co-be-chim-go-kien_95941_1.jpg",
                Tensach = "Cô bé chim gõ kiến",
                Dongia = 66000
            });
            lstSachNoiBat.Add(new Sach()
            {
                Hinhminhhoa = "cho-doi-thien-su-the-gioi-cua-em-trai_95942_1.jpg",
                Tensach = "Thế giới của em trai",
                Dongia = 8000
            });
            lstSachNoiBat.Add(new Sach()
            {
                Hinhminhhoa = "chu-hai-cau-hanh-phuc_95946_1.jpg",
                Tensach = "Chú hải cẩu hạnh phúc",
                Dongia = 32000,
                Giakm = 28000,
            });
            ViewBag.ListSachMoi = lstSachMoi;
            ViewBag.ListSachNoiBat = lstSachNoiBat;
            return View();
        }
    }
}