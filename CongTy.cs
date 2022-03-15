using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT
{
    class CongTy
    {
		public string TenCongTy { get; set; }
		//public List<NhanVienVanPhong> dsNhanVienVanPhong { get; set; }
		//public List<NhanVienSanXuat> dsNhanVienSanXuat { get; set; }
		public List<NhanVien> DanhSachNhanVien{ get; set; }
		public CongTy()
		{
			//this.dsNhanVienVanPhong = new List<NhanVienVanPhong>();
			//this.dsNhanVienSanXuat = new List<NhanVienSanXuat>();
			this.DanhSachNhanVien = new List<NhanVien>();
		}
		public void Nhap(string ghiChu)
		{
			Console.WriteLine(ghiChu);
			Console.WriteLine("Nhập tên công ty");
			this.TenCongTy = Console.ReadLine();
			//Console.WriteLine("Nhập số lượng nhân viên văn phòng");
			Console.WriteLine("Nhập số lượng nhân viên");
			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine("Nhập loại 1. VP, 2. SX");
				int loai = int.Parse(Console.ReadLine());
				//NhanVienVanPhong nv = new NhanVienVanPhong();
				NhanVien nv;
				if(loai == 1)
                {
					nv = new NhanVienVanPhong();
                }
                else
                {
					nv = new NhanVienSanXuat();
				}
				//nv.NhapNhanVien($"Nhập nhân viên văn phòng thứ {i}");
				//this.dsNhanVienVanPhong.Add(nv);
				nv.NhapNhanVien($"Nhập nhân viên thứ {i}");
				this.DanhSachNhanVien.Add(nv);
			}
		}
		public double TongLuong()
		{
			double kq = 0;
			foreach (NhanVien nv in this.DanhSachNhanVien)
			{
				kq = kq + nv.Luong();
			}
			return kq;
		}
	}
}
