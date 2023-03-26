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

// синтаксис методов сравнения объектов
// сравнение ссылок
// public static ReferenceEquals(Object obj1,Object obj2) {}
//Сравнение значений
// public bool virtual Equals(Object obj) {}

namespace InterfacesWPU221
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        //Переопределение метода Equals
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public static bool operator ==(Point p1, Point p2)
        {
            return Equals(p1, p2);
        }
        public static bool operator !=(Point p1, Point p2)
        { 
            return !Equals(p1,p2);
        }

        public static bool operator >(Point p1, Point p2)
        {
            return Math.Sqrt(p1.X*p1.X+p1.Y*p1.Y)>(p2.X*p2.X+p2.Y*p2.Y);
        }
        public static bool operator <(Point p1, Point p2)
        {
            return Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y) < (p2.X * p2.X + p2.Y * p2.Y);
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
           Point point1 = new Point { X=20,Y=20};
           Point point2 = new Point { X=20,Y=20};
            WriteLine($"point1: {point1}");
            WriteLine($"point2: {point2}\n");

            WriteLine($"point1 == point2: { point1 == point2}"); 
            WriteLine($"point1 != point2: { point1 != point2}");

            WriteLine($"point1 > point2: {point1 > point2}");
            WriteLine($"point1 < point2: {point1 < point2}");

        }
    }
}
