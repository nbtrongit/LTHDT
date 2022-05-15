using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SERVICES;

namespace WebApplication1.Pages
{
    public class tinhChuViTamGiacModel : PageModel
    {
        private IXuLyTamGiac xuLy;
        public string chuVi = string.Empty;
        public void OnGet()
        {
            var kq = xuLy.tinhChuVi();
            if (kq.IsSuccess)
            {
                chuVi = $"Chu vi: {kq.Data}";
            }
            else
            {
                //chuVi = kq.Message;
                chuVi = kq.ErrorMessage;
            }
        }
        public tinhChuViTamGiacModel()
        {
            xuLy = new XuLyTamGiac();
        }
    }
}
