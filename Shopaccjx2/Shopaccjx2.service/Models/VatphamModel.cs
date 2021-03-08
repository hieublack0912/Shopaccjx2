using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopaccjx2.service.Models
{
    public class VatphamModel
    {
        public int Ma_vatpham { get; set; }
        public string Tenvatpham { get; set; }
        public decimal? Giaban { get; set; }
        public string Mota { get; set; }
        public string Anhvatpham { get; set; }
        public bool? Trangthai { get; set; }
        public string Tendanhmuc { get; set; }
    }
}