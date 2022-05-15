using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ENTITIES;
using SERVICES;

namespace WebApplication1.Pages
{
    public class tinhTongPhanSoModel : PageModel
    {
        private IXuLyPhanSo xuLy;
        public string ketQua;
        [BindProperty]
        public int tu1 { get; set; }
        [BindProperty]
        public int mau1 { get; set; }
        [BindProperty]
        public int tu2 { get; set; }
        [BindProperty]
        public int mau2 { get; set; }
        public void OnGet()
        {

        }
        public tinhTongPhanSoModel()
        {
            xuLy = new XuLyPhanSo();
        }
        public void OnPost()
        {
            //phụ thuộc khá nhiều vào XuLyPhanSo mà cái cần chỉ là hàm cộng => tạo interface trong services
            //XuLyPhanSo xuLy = new XuLyPhanSo();
            var kq = xuLy.cong2PhanSo(tu1, mau1, tu2, mau2);
            if (kq.IsSuccess)
            {
                ketQua = kq.Data.xuatPhanSo();
            }
            else
            {
                ketQua = kq.Message;
            }
        }
    }
}
