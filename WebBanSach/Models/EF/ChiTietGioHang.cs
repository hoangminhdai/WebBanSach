namespace WebBanSach.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietGioHang")]
    public partial class ChiTietGioHang
    {
        [Key]
        public int ChitiethiohangID { get; set; }

        public int? GiohangkhID { get; set; }

        public int? Masach { get; set; }

        public int? Soluong { get; set; }

        public int? Thanhtien { get; set; }

        public virtual Giohangkh Giohangkh { get; set; }

        public virtual Sach Sach { get; set; }
    }
}
