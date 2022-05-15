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
    public class luuTamGiacModel : PageModel
    {
        private IXuLyTamGiac xuLy;
        [BindProperty]
        public int x1 { get; set; }
        [BindProperty]
        public int y1 { get; set; }
        [BindProperty]
        public int x2 { get; set; }
        [BindProperty]
        public int y2 { get; set; }
        [BindProperty]
        public int x3 { get; set; }
        [BindProperty]
        public int y3 { get; set; }
        public string ketQua { get; set; }
        public void OnGet()
        {
            ketQua = string.Empty;
        }
        public luuTamGiacModel()
        {
            xuLy = new XuLyTamGiac();
        }
        public void OnPost()
        {
            try
            {
                TamGiac t = new TamGiac(x1, y1, x2, y2, x3, y3);
                xuLy.LuuTruTamGiac(t);
                ketQua = "true";
            }
            catch(Exception ex)
            {
                ketQua = ex.Message;
            }
        }
    }
}
