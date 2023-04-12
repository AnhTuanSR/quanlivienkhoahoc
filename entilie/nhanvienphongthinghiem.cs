using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlivienkhoahoc.NewFolder1
{
    class nhanvienphongthinghiem : nhanvien
    {
        public double luongtrongthang { get; set; }
        public override void nhap()
        {
            base.nhap();
            Console.Write("luong :");
            luongtrongthang = double.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("\tluong trong thang :{0}", luongtrongthang);
        }
    }
}
