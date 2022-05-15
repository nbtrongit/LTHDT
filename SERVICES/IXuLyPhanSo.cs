using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIES;

namespace SERVICES
{
    public interface IXuLyPhanSo
    {
        //PhanSo cong2PhanSo(int tu1, int mau1, int tu2, int mau2);
        //PhanSoServiceResult cong2PhanSo(int tu1, int mau1, int tu2, int mau2);
        ServiceResult<PhanSo> cong2PhanSo(int tu1, int mau1, int tu2, int mau2);
    }
}
