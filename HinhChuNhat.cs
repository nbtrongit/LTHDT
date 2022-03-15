using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT
{
    class HinhChuNhat: Hinh
    {
		public double Dai { get; set; }
		public double Rong { get; set; }
		public override void NhapHinh(string ghiChu)
		{
			base.NhapHinh(ghiChu);
			Console.WriteLine("Nhập chiều dài");
			this.Dai = double.Parse(Console.ReadLine());
			Console.WriteLine("Nhập chiều rộng");
			this.Rong = double.Parse(Console.ReadLine());
		}
		public override double ChuVi()
		{
			return 2 * (this.Dai + this.Rong);
		}
	}
}
