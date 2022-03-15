using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT
{
    class NhanVien
    {
		public string MaNV { get; set; }
		public string Ten { get; set; }
		public string DiaChi { get; set; }
		//public void NNhapNhanVien(string ghiChu)
		public virtual void NhapNhanVien(string ghiChu)
		{
			Console.WriteLine(ghiChu);
			Console.WriteLine("Nhập mã NV");
			this.MaNV = Console.ReadLine();
			Console.WriteLine("Nhập tên");
			this.Ten = Console.ReadLine();
			Console.WriteLine("Nhập địa chỉ");
			this.DiaChi = Console.ReadLine();
		}
		public virtual double Luong()
        {
			return 0;
        }
	}
}
