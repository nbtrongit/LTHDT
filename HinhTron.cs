using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT
{
    class HinhTron: Hinh
    {
		public Diem Tam { get; set; }
		public double BanKinh { get; set; }
		public override void NhapHinh(string ghiChu)
		{
			base.NhapHinh(ghiChu);
			this.Tam.NhapDiem("Nhập Tâm");
			Console.WriteLine("Nhập bán kính");
			this.BanKinh = double.Parse(Console.ReadLine());
		}
		public override double ChuVi()
		{
			return this.BanKinh * this.BanKinh * Math.PI;
		}
	}
}
