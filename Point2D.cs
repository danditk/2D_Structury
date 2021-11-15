using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Structury
{
    struct Point2D
    {
        //public const int x = 5;

        public int x;
        public int y;

        public double DistansFromCenter()
        {
            return Math.Round(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)),1);
        }
    }
}
