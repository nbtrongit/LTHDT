using System;

namespace LTHDT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CongTy t = new CongTy();
            t.Nhap("Nhập thông tin công ty");
        }
    }
}
