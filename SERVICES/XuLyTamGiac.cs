using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIES;
using DAL;

namespace SERVICES
{
    public class XuLyTamGiac:IXuLyTamGiac
    {
        public ILuuTruTamGiac luuTruTamGiac;
        public XuLyTamGiac()
        {
            luuTruTamGiac = new LuuTruTamGiac();
        }
        public ServiceResult<double> tinhChuVi()
        {
            /*
            var t = luuTruTamGiac.Doc();
            var kq = t.ChuVi();
            return new ServiceResult<double>(true, kq, string.Empty);
            */

            //dùng try catch
            try
            {
                var t = luuTruTamGiac.Doc();
                var kq = t.ChuVi();
                return new ServiceResult<double>(true, kq, string.Empty);
            }
            catch(Exception ngoaiLe)
            {
                return new ServiceResult<double>(false, 0, ngoaiLe.Message);
            }
        }
        public ServiceResult<bool> LuuTruTamGiac (TamGiac t)
        {
            try
            {
                luuTruTamGiac.Luu(t);
                return new ServiceResult<bool>(true, true, string.Empty);
            }
            catch(Exception ex)
            {
                return new ServiceResult<bool>(false, false, ex.Message);
            }
        }
    }
}
