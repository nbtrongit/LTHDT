using System;
using ENTITIES;

namespace SERVICES
{
    public class XuLyPhanSo : IXuLyPhanSo
    {
        public PhanSo cong2PhanSo(int tu1, int mau1, int tu2, int mau2)
        {
            PhanSo a = new PhanSo(tu1, mau1);
            PhanSo b = new PhanSo(tu2, mau2);
            return a.Cong(b);
        }
    }
}
