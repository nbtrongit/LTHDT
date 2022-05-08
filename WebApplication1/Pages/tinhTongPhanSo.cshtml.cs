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
        private IXuLyPhanSo xuLyPhanSo;
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
            xuLyPhanSo = new XuLyPhanSo();
        }
        public void OnPost()
        {
            //phụ thuộc khá nhiều vào XuLyPhanSo mà cái cần chỉ là hàm cong => tạo interface trong services
            //XuLyPhanSo xuLy = new XuLyPhanSo();
            var kq = xuLyPhanSo.cong2PhanSo(tu1, mau1, tu2, mau2);
            ketQua = kq.xuatPhanSo();
        }
    }
}
