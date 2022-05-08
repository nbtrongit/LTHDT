using System;

namespace ENTITIES
{
    public class PhanSo
    {
        //thuộc tính nên là private
        public int TuSo { get; set; }
        private int MauSo;

        //phương thức nên là public
        public PhanSo()
        {
            this.TuSo = 0;
            this.MauSo = 1;
        }
        public PhanSo(int t)
        {
            this.TuSo = t;
            this.MauSo = 1;
        }
        public PhanSo(int t, int m)
        {
            this.khoiTao(t, m);
        }
        public void khoiTao(int t, int m)
        {
            this.TuSo = t;
            if(m != 0)
            {
                this.MauSo = m;
            }
            else
            {
                this.MauSo = 1;
            }
        }
        public PhanSo Cong(PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.TuSo = this.TuSo + b.MauSo + this.MauSo + b.TuSo;
            kq.MauSo = this.MauSo * b.MauSo;
            return kq;
        }
        public string xuatPhanSo()
        {
            return $"{this.TuSo}/{this.MauSo}";
        }
        public int MAUSO
        {
            get { return this.TuSo; }
            set
            {
                if(value != 0)
                {
                    this.MauSo = value;
                }
            }
        }
    }
}
