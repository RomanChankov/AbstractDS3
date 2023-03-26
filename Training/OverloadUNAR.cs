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

    // Ctr+k+d  чтоб выстроились красиво коды!
    class Point
    {
       public int X{ get; set; }
       public int Y{ get; set; }
        public static Point operator ++(Point s)
        {
            s.X++;
            s.Y++;
            return s;
        }

        public static Point operator --(Point s)
        {
            s.X--;
            s.Y--;
            return s;
        }
        public static Point operator -(Point s)
        {
            return new Point { X = -s.X, Y = -s.Y };
           
        }
        public override string ToString()
        {
            return $"Point: X={X}, Y={Y}";
        }
    }
    class Program
    {


        static void Main(string[] args)
        {
            Point point = new Point { X = 10, Y = 10 };
            
            WriteLine($"Исходная точка\n{point}");
            WriteLine("Префиксная и постфиксная формы инкремента выполняются одинаково");            WriteLine(point++); 
            WriteLine(++point);
            WriteLine(-point);
            WriteLine(point);
        }
    }
}
