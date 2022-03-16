using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using Tuan4_NguyenTanTu.Models;

namespace Tuan4_NguyenTanTu.Models
{
    public class Giohang
    {
        MyDataDataContext data = new MyDataDataContext();
        [DisplayName("Mã sách : ")]
        public int masach { get; set; }
        [DisplayName("Tên sách : ")]
        public string tensach { get; set; }
        [DisplayName("Ảnh bìa : ")]
        public string hinh { get; set; }
        [DisplayName("Giá bán : ")]
        public Double giaban { get; set; }
        [DisplayName("Số lượng : ")]
        public int iSoluong { get; set; }
        [DisplayName("Thành tiền : ")]
        public Double dThanhtien { 
            get { return iSoluong * giaban; }
        }
        public Giohang(int id)
        {
            masach = id;
            Sach sach = data.Saches.Single(n => n.masach == masach);
            tensach = sach.tensach;
            hinh = sach.hinh;
            giaban = double.Parse(sach.giaban.ToString());
            iSoluong = 1;
        }
    }
}