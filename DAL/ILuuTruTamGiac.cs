using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIES;

namespace DAL
{
    public interface ILuuTruTamGiac
    {
        TamGiac Doc();
        void Luu(TamGiac t);
    }
}
