using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT
{
    class NhanVienVanPhong: NhanVien
    {
		public int LuongCoBan { get; set; }
		public int PhuCap { get; set; }
		//public new void NhapNhanVien(string ghiChu)
		public override void NhapNhanVien(string ghiChu)
		{
			base.NhapNhanVien(ghiChu);
			Console.WriteLine("Nhập số lương cơ bản");
			this.LuongCoBan = int.Parse(Console.ReadLine());
			Console.WriteLine("Nhập số phụ cấp");
			this.PhuCap = int.Parse(Console.ReadLine());
		}
		public override double Luong()
		{
			return this.LuongCoBan * 10 + this.PhuCap;
		}
	}
}
