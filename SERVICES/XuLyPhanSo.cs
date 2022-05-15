using System;
using ENTITIES;

namespace SERVICES
{
    public class XuLyPhanSo : IXuLyPhanSo
    {
        //public PhanSo cong2PhanSo(int tu1, int mau1, int tu2, int mau2)
        public PhanSoServiceResult cong2PhanSo(int tu1, int mau1, int tu2, int mau2)
        {
            //kiem tra tinh hop le cua du lieu
            if(mau1 == 0 || mau2 == 0)
            {
                return new PhanSoServiceResult(false, null, "Mẫu số bằng 0");
            }
            PhanSo a = new PhanSo(tu1, mau1);
            PhanSo b = new PhanSo(tu2, mau2);
            //return a.Cong(b);
            var tong = a.Cong(b);
            return new PhanSoServiceResult(true, tong, null);
        }
    }
}
