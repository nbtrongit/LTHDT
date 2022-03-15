using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT
{
    class DaGiac
    {
        public Diem[] dsDinh;
        public void NhapDaGiac(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhập số lượng đỉnh");
            int n = int.Parse(Console.ReadLine());
            this.dsDinh = new Diem[n];
            for(int i = 0; i < this.dsDinh.Length; i++)
            {
                this.dsDinh[i] = new Diem();
                this.dsDinh[i].NhapDiem($"Nhập đỉnh {i+1}");
            }
        }
        public double ChuVi()
        {
            double kq = 0;
            for (int i = 0; i < this.dsDinh.Length - 1; i++)
            {
                kq = kq + this.dsDinh[i].KhoangCach(this.dsDinh[i + 1]);
            }
            kq = kq + this.dsDinh[0].KhoangCach(this.dsDinh[this.dsDinh.Length - 1]);
            return kq;
        }
    }
}
