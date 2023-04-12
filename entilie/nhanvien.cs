using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlivienkhoahoc.NewFolder1
{
    class nhanvien
    {
        public string hoten { get; set; }
        public DateTime namsinh { get; set; }
        public string bangcap { get; set; }
        public virtual void nhap()
        {
            Console.Write("ho ten :");
            hoten = Console.ReadLine();
            Console.Write("namsinh :");
            namsinh = DateTime.Parse( Console.ReadLine());
            Console.Write("bangcap :");
            bangcap = Console.ReadLine();
        }
        public virtual void xuat()
        {
            Console.WriteLine("\tho ten :{0}", hoten);
            Console.WriteLine("\tnamsinh :{0}", namsinh);
            Console.WriteLine("\tbangcap :{0}", bangcap);
        }
    }
}
