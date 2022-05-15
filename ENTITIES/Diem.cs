using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class Diem
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Diem()
        {
            this.X = 0;
            this.Y = 0;
        }
        public Diem(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public double KhoangCach(Diem b)
        {
            return Math.Sqrt((this.X - b.X) * (this.X - b.X) + (this.Y - b.Y) * (this.Y - b.Y));
        }
    }
}
