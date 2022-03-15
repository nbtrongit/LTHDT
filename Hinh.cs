using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT
{
    class Hinh
    {
		public string MauSac { get; set; }
		public virtual void NhapHinh(string ghiChu)
		{
			Console.WriteLine(ghiChu);
			Console.WriteLine("Nhập màu của hình");
			this.MauSac = Console.ReadLine();
		}
		public virtual double ChuVi()
        {
			return 0;
        }
	}
}
