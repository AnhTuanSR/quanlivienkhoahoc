using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlivienkhoahoc.NewFolder1
{
    class nhakhoahoc : nhaquanli
    {
        public int sobaibao { get; set; }
        public override void nhap()
        {
            base.nhap();
            Console.Write("so bai bao :");
            sobaibao = int.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("\tsobaibao :{0}", sobaibao);
        }
    }
}
