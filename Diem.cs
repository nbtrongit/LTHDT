using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT
{
    class Diem
    {
        public int X;
        public int Y;
        public void NhapDiem(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhập X");
            this.X = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập Y");
            this.Y = int.Parse(Console.ReadLine());
        }
        public double KhoangCach(Diem b)
        {
            return Math.Sqrt((this.X - b.X) * (this.X - b.X) + (this.Y - b.Y) * (this.Y - b.Y));
        }
    }
}
