using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Structury
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D point1 = new Point2D(9,4); // we can also init some variables create new object
            //point1.x = 5;
            //point1.y = 10;
            Point2D point2;
            //point2.x = 2;
            //point2.y = 4;

            point2 = point1;
            point2.x = 7;

            Point2D point3 = point2 + point1;

            Console.WriteLine(point1.x);
            Console.WriteLine(point1.y);
            Console.WriteLine(point1.DistansFromCenter());
            Console.WriteLine();
            Console.WriteLine(point3.x);
            Console.WriteLine(point3.y);

            Console.ReadKey();
        }
        
    }
}
