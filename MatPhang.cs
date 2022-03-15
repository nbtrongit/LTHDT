using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT
{
    class MatPhang
    {
		public List<Hinh> dsHinh { get; set; }
		public MatPhang()
		{
			this.dsHinh = new List<Hinh>();
		}
		public void Nhap(string ghiChu)
		{
			Console.WriteLine(ghiChu);
			Console.WriteLine("Nhập số lượng hình");
			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine("Loai 1.Hình tròn, 2. Hình chữ nhật");
				int loai = int.Parse(Console.ReadLine());
				Hinh h;
				if (loai == 1)
                {
					h = new HinhTron();
                }
                else
                {
					h = new HinhChuNhat();
				}
				h.NhapHinh($"Nhập hình thứ {i + 1}");
				this.dsHinh.Add(h);
			}
		}
		public double TongChuVi()
		{
			double kq = 0;
			foreach (Hinh h in this.dsHinh)
			{
				kq = kq + h.ChuVi();
			}
			return kq;
		}
	}
}
