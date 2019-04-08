using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanSach.Models.EF;

namespace WebBanSach.Areas.AdminSite.Controllers
{
    public class AdminQuanLySachController : Controller
    {
        QuanLyBanSachDbContext db = new QuanLyBanSachDbContext();

        // GET: AdminSite/AdminQuanLySach
        public ActionResult TatCaSach()
        {
            var TatCaSach = db.Saches.Join(db.Nhaxuatbans, sach => sach.Manxb, nxb => nxb.Manxb, (sach, nxb) => sach)
                                      .Join(db.Chudes, sach => sach.Macd, chude => chude.Macd, (sach, chude) => sach)
                                      .Join(db.Tacgias, sach => sach.Matacgia, tacgia => tacgia.Matacgia, (sach, tacgia) => sach)
                                      .ToList();
            ViewBag.TatCaSach = TatCaSach;
            return View();
        }
        public ActionResult ViewThemSach()
        {
            var TatCaChuDe = db.Chudes.ToList();
            var TatCaTacGia = db.Tacgias.ToList();
            var TatCaNXB = db.Nhaxuatbans.ToList();
            ViewBag.TatCaChuDe = TatCaChuDe;
            ViewBag.TatCaTacGia = TatCaTacGia;
            ViewBag.TatCaNXB = TatCaNXB;
            return View();
        }
        [HttpPost]
        public ActionResult ThemSach(string TenSach, int TacGia, int ChuDe, int NXB, int Gia, int GiamGia, int SoLuong, string MoTa, string MoTaNganGon, HttpPostedFileBase AnhminhHoa)
        {
            Sach sach = new Sach();
            sach.Tensach = TenSach;
            sach.Matacgia = TacGia;
            sach.Macd = ChuDe;
            sach.Manxb = NXB;
            sach.Dongia = Gia;
            sach.Giakm = GiamGia;
            sach.Soluong = SoLuong;
            sach.Mota = MoTa;
            sach.Motangangon = MoTaNganGon;
            sach.Donvitinh = "VNĐ";
            if (AnhminhHoa.ContentLength > 0)
            {
                var TenAnh = Path.GetFileName(AnhminhHoa.FileName);
                var DuongDan = Path.Combine(Server.MapPath("~/Assets/images/"), TenAnh);
                sach.Hinhminhhoa = TenAnh;
                AnhminhHoa.SaveAs(DuongDan);
            } else
            {
                sach.Hinhminhhoa = "http://placehold.it/400x400";
            }
            db.Saches.Add(sach);
            db.SaveChanges();
            return RedirectToAction("TatCaSach");
            
        }
        public ActionResult ViewSuaSach(int MaSach)
        {
            var TatCaChuDe = db.Chudes.ToList();
            var TatCaTacGia = db.Tacgias.ToList();
            var TatCaNXB = db.Nhaxuatbans.ToList();
            ViewBag.TatCaChuDe = TatCaChuDe;
            ViewBag.TatCaTacGia = TatCaTacGia;
            ViewBag.TatCaNXB = TatCaNXB;

            //var sach = db.Saches.Join(db.Nhaxuatbans, s => s.Manxb, nxb => nxb.Manxb, (s, nxb) => s)
            //                          .Join(db.Chudes, s => s.Macd, chude => chude.Macd, (s, chude) => s)
            //                          .Join(db.Tacgias, s => s.Matacgia, tacgia => tacgia.Matacgia, (s, tacgia) => s)
            //                          .Where(s => s.Masach == MaSach)
            //                          .First();
            Sach sach = db.Saches.Find(MaSach);
            sach.Dongia = sach.Dongia != null ? sach.Dongia : 0;
            sach.Giakm = sach.Giakm != null ? sach.Giakm : 0;
            sach.Mota = sach.Mota != null ? sach.Mota : "không có mô tả";
            sach.Motangangon = sach.Motangangon != null ? sach.Motangangon : "không có mô tả";
            ViewBag.sach = sach;
            return View();
        }
        public ActionResult SuaSach(int Masach, string TenSach, int TacGia, int ChuDe, int NXB, int Gia, int GiamGia, int SoLuong, string MoTa, string MoTaNganGon, HttpPostedFileBase AnhminhHoa)
        {

            Sach sach = db.Saches.Find(Masach);
            sach.Tensach = TenSach;
            sach.Matacgia = TacGia;
            sach.Macd = ChuDe;
            sach.Manxb = NXB;
            sach.Dongia = Gia;
            sach.Giakm = GiamGia;
            sach.Soluong = SoLuong;
            sach.Mota = MoTa;
            sach.Motangangon = MoTaNganGon;
            if (AnhminhHoa.ContentLength > 0)
            {
                var TenAnh = Path.GetFileName(AnhminhHoa.FileName);
                var DuongDan = Path.Combine(Server.MapPath("~/Assets/images/"), TenAnh);
                sach.Hinhminhhoa = TenAnh;
                AnhminhHoa.SaveAs(DuongDan);
            }
            else
            {
                sach.Hinhminhhoa = "http://placehold.it/400x400";
            }
            sach.Donvitinh = "VNĐ";
            db.Entry(sach).CurrentValues.SetValues(sach);
            db.SaveChanges();
            return RedirectToAction("TatCaSach");

        }
        [HttpPost]
        public JsonResult XoaSach(int MaSach)
        {
            try
            {
                Sach sach = db.Saches.Find(MaSach);
                db.Saches.Remove(sach);
                db.SaveChanges();
                return Json(new { status = true });
            }
            catch (Exception ex)
            {
                return Json(new { status = false });
            }

        }
    }
}