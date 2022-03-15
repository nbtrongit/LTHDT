using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT
{
    class TamGiac
    {
        public Diem A;
        public Diem B;
        public Diem C;
        public void NhapTamGiac(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            this.A = new Diem();
            this.A.NhapDiem("Nhập đỉnh A");
            this.B = new Diem();
            this.B.NhapDiem("Nhập đỉnh B");
            this.C = new Diem();
            this.C.NhapDiem("Nhập đỉnh C");
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
