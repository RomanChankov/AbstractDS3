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
    }
    class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector() { }
        public Vector(Point begin, Point end)
        {
            X = end.X - begin.X;
            Y = end.Y - begin.Y;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector { X = v1.X + v2.X, Y = v1.Y + v2.Y };
        }
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector { X = v1.X - v2.X, Y = v1.Y - v2.Y };
        }
        public static Vector operator *(Vector v, int n)
        {
            //return new Vector
            //{
            //    X = v.X * n,
            //    Y = v.Y * n
            //};
            
            v.X *= n;
            v.Y *= n;
            return v;
        }

        public override string ToString()
        {
            return $" X = {X},Y = {Y} ";
        }
    }
    class Program
    {


        static void Main(string[] args)
        {
            Point point1 = new Point { X = 2, Y = 3 };
            Point point2 = new Point { X = 3, Y = 1 };

            Vector vector1 = new Vector(point1, point2);
            Vector vector2 = new Vector { X = 2, Y = 3 };

            WriteLine($"Вектор1: {vector1}  Вектор2: {vector2}\n");
            WriteLine($"Сложение векторов\n{vector1 + vector2}\n");
            WriteLine($"Разность векторов\n{vector1 - vector2}\n");
            WriteLine("Введите целое число: ");
            int n = int.Parse(ReadLine());
            WriteLine($"{vector1 * n}");
            WriteLine($"{vector2 * n}");
        }
    }
}
