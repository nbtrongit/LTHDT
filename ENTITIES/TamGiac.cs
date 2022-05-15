using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class TamGiac
    {
        public Diem A { get; set; }
        public Diem B { get; set; }
        public Diem C { get; set; }
        public TamGiac()
        {
            this.A = new Diem(0, 0);
            this.B = new Diem(1, 0);
            this.C = new Diem(0, 1);
        }
        public TamGiac(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            var dinhA = new Diem(x1, y1);
            var dinhB = new Diem(x2, y2);
            var dinhC = new Diem(x3, y3);
            if(kiemTraTamGiac(dinhA, dinhB, dinhC))
            {
                this.A = dinhA;
                this.B = dinhB;
                this.C = dinhC;
            }
            else
            {
                throw new Exception("Tam giác không hợp lệ");
            }
        }
        public TamGiac(Diem a, Diem b, Diem c)
        {
            if (kiemTraTamGiac(a, b, c))
            {
                this.A = a;
                this.B = b;
                this.C = c;
            }
            else
            {
                this.A = new Diem(0, 0);
                this.B = new Diem(1, 0);
                this.C = new Diem(0, 1);
            }
        }
        public bool kiemTraTamGiac(Diem p1, Diem p2, Diem p3)
        {
            double a, b, c;
            a = p1.KhoangCach(p2);
            b = p1.KhoangCach(p3);
            c = p2.KhoangCach(p3);
            return a + b > c && a + c > b && b + c > a;
        }
        public double ChuVi()
        {
            double a, b, c;
            a = this.A.KhoangCach(this.B);
            b = this.A.KhoangCach(this.C);
            c = this.B.KhoangCach(this.C);
            return a + b + c;
        }
    }
}
