using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace WebBanSach.Models.ADO
{
    public class DataProvider
    {
        CN_WebEntities db = new CN_WebEntities();

        // lấy ra tất cả chủ đề trong database
        public List<Chude> LayTatCaChuDe()
        {
            return db.Chudes.ToList();
        }

        // lấy ra tất cả nxb trong database
        public List<Nhaxuatban> LayTatCaNXB()
        {
            return db.Nhaxuatbans.ToList();
        }

        // lấy ra tất cả tác giả trong database
        public List<Tacgia> LayTatCaTacGia()
        {
            return db.Tacgias.ToList();
        }

        // lấy tất cả sách theo chủ đề ID 
        public ICollection<Sach> LaySachTheoChuDe(int maCD)
        {
            Chude chuDe = db.Chudes.Where(cd => cd.Macd == maCD).Single();
            if (chuDe == null || chuDe.Macd <= 0)
            {
                return new List<Sach>();
            }

            return chuDe.Saches;
        }

        // lấy sách theo tác giả 
        public ICollection<Sach> LaySachTheoTacGia(int maTg)
        {
            Tacgia tacGia = db.Tacgias.Where(tg => tg.Matacgia == maTg).Single();
            if (tacGia == null || tacGia.Matacgia <= 0)
            {
                return new List<Sach>();
            }

            return tacGia.Saches;
        }

        // lấy sách theo nhà xuất bản
        public ICollection<Sach> LaySachTheoNXB(int maNXB)
        {
            Nhaxuatban nhaxuatban = db.Nhaxuatbans.Where(nbx => nbx.Manxb == maNXB).Single();
            if (nhaxuatban == null || nhaxuatban.Manxb <= 0)
            {
                return new List<Sach>();
            }

            return nhaxuatban.Saches;
        }

        // hàm mã hóa mật khẩu md5
        private string Encrypt(string matKhau)
        {
            string key = "chuoi_ma_hoa_cung_mat_khau!";
            bool useHashing = true;
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(matKhau);

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        // hàm thêm khách hàng
        // quyền khách hàng là 0
        // quyền admin là 99
        public bool ThemKhachHang(Khachhang kh)
        {
            // kiểm tra tên đăng nhập, email , sđt xem có tồn tại chưa ?
            Khachhang khachHang = db.Khachhangs.Where(
                khachhang => khachhang.Tendn == kh.Tendn ||
                khachhang.Email == kh.Email ||
                khachhang.Dienthoaikh == kh.Dienthoaikh
            ).Single();

            // nếu tồn tại thì return false
            if (khachHang != null && khachHang.Makh > 0)
            {
                return false;
            }

            // thêm lại quyền cho khách hàng = 0
            kh.Quyen = 0;
            // thêm mật khẩu đã mã hóa md5
            string matKhau_MD5 = Encrypt(kh.Matkhau);
            kh.Matkhau = matKhau_MD5;

            db.Khachhangs.Add(kh);
            return true;
        }

        // kiểm tra tài khoản admin
        // nếu có tài khoản và quyền là 99 => admin
        public bool KiemTraTaiKhoanAdmin(string tenDN, string matKhau)
        {
            Khachhang admin = db.Khachhangs.Where(kh => kh.Tendn == tenDN && kh.Matkhau == Encrypt(matKhau)).Single();
            if (admin != null && admin.Makh > 0 && admin.Quyen == 99)
            {
                return true;
            }
            return false;
        }

        // thêm sách 
        public bool ThemSach(Sach sach)
        {
            // kiểm tra chủ đề có tồn tại không ?
            Chude chude = db.Chudes.Where(cd => cd.Macd == sach.Chude.Macd).Single();
            if (chude == null || chude.Macd <= 0)
            {
                return false;
            }

            // kiểm tra tác giả có tồn tại không ?
            Tacgia tacGia = db.Tacgias.Where(tg => tg.Matacgia == sach.Tacgia.Matacgia).Single();
            if (tacGia == null || tacGia.Matacgia <= 0)
            {
                return false;

            }

            // kiểm tra xem nxb có tồn tại không ?
            Nhaxuatban nhaXuatBan = db.Nhaxuatbans.Where(nxb => nxb.Manxb == sach.Nhaxuatban.Manxb).Single();
            if (nhaXuatBan == null || nhaXuatBan.Manxb <= 0)
            {
                return false;
            }

            Sach result = db.Saches.Add(sach);
            if (result.Masach > 0)
                return true;
            return false;
        }

        // tính tiền giỏ hàng
        public int TinhTienGioHang(List<int> listMaSach)
        {
            return 0;
        }
    }
}
