using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT
{
    class NhanVienSanXuat: NhanVien
    {
		public int SoSanPham { get; set; }
		//public new void NhapNhanVien(string ghiChu)
		public override void NhapNhanVien(string ghiChu)
		{
			base.NhapNhanVien(ghiChu);
			Console.WriteLine("Nhập số SP");
			this.SoSanPham = int.Parse(Console.ReadLine());
		}
		public override double Luong()
		{
			return this.SoSanPham * 100;
		}
	}
}
