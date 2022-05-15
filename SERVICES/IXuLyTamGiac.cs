using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIES;

namespace SERVICES
{
    public interface IXuLyTamGiac
    {
        ServiceResult<double> tinhChuVi();
        ServiceResult<bool> LuuTruTamGiac(TamGiac t);
    }
}
