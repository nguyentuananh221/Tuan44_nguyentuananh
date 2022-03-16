using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Tuan3_nguyentuananh.Models;

namespace Tuan3_nguyentuananh.Models
{
    public class Giohang
    {
        MydataDataContext data = new MydataDataContext();
        public int masach { get; set; }
        [Display(Name = " Tên Sách")]
        public string tensach { get; set; }
        [Display(Name = " Ảnh bìa")]
        public string hinh { get; set; }
        [Display(Name = " Giá Bán")]
        public double giaban { get; set; }
        [Display(Name = "Số Lượng")]
        public int isoluong { get; set; }
        [Display(Name = " Tên Sách")]
        public double dThanhtien { get { return isoluong * giaban; } }
        public Giohang(int id)
        {
            masach = id;
            Sach sach = data.Saches.Single(n => n.masach == masach);
            tensach = sach.tensach;
            hinh = sach.hinh;
            giaban = double.Parse(sach.giaban.ToString());
            isoluong = 1;
        }

       
    }
}