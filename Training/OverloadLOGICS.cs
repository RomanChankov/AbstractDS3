using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.GC;
using static System.Exception;
using static System.Console;
using System.Drawing;



namespace InterfacesWPU221
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static bool operator true(Point p)
        {
            return p.X != 0 || p.Y != 0 ? true : false;
        }
        public static bool operator false(Point p)
        {
            return p.X == 0 && p.Y == 0 ? true : false;
        }
        public static Point operator |(Point p1, Point P2)
        {
            if ((p1.X != 0 || p1.Y != 0) || (P2.X != 0 || P2.Y != 0))
                return P2;
            return new Point();
        }
        public static Point operator &(Point p1, Point P2)
        {
            if ((p1.X != 0 && p1.Y != 0) && (P2.X != 0 && P2.Y != 0))
                return P2;
            return new Point();
        }
        public override string ToString()
        {
            return $"X= {X}  Y={Y}";
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Point point1 = new Point { X = 10, Y = 10 };
            Point point2 = new Point { X = 0, Y = 0 };

            WriteLine($"point1: {point1}");
            WriteLine($"point2: {point2}\n");
            Write("point1 && point2: ");

            if (point1 && point2)
            {
                WriteLine("true");
            }
            else
            {
                WriteLine("false");
            }
        }
    }
}
