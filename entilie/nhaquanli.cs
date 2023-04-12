using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlivienkhoahoc.NewFolder1
{
    class nhaquanli : nhanvien
    {
        public string chucvu { get; set; }
        public int songaycong { get; set; }
        public float bacluong { get; set; }
        public override void nhap()
        {
            base.nhap();
            Console.Write("chucvu :");
            chucvu = Console.ReadLine();
            Console.Write("so ngay cong :");
            songaycong = int.Parse(Console.ReadLine());
            Console.Write("bangcap :");
            bangcap = Console.ReadLine();
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("\tchucvu :{0}", chucvu);
            Console.WriteLine("\tsongaycong :{0}", songaycong);
            Console.WriteLine("\tbacluong :{0}", bacluong);
        }
    }
}
