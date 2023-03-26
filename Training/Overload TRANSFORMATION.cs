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
   abstract class Figure
    {
        public abstract void Draw();
    }
    abstract class Quadrangle : Figure { }

    class Rectangle :Quadrangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public static implicit operator Rectangle(Square s)
        {
            return new Rectangle{ Width=s.Length*2,Height= s.Length};
        }
        public override void Draw()
        {
            for (int i = 0; i < Height; i++, WriteLine())
            {
                for (int j = 0; j < Width; j++)
                {
                    Write("*");
                }
            }
            WriteLine();
        }
        public override string ToString()
        {
            return $"Rectangle: Width = {Width}, Height = { Height}";
        }
    }
    class Square :Quadrangle
    { 
        public int Lenght { get; set; }
    }
    public static explicit operator Square(Rectangle rect)
    {
        return new Square { Length = rect.Height };
    }
    public static explicit operator int(Square s)
    {
        return s.Length;
    }
    public static implicit operator Square(int number)
    {
        return new Square { Length = number };
    }
    public override void Draw()
    {
        for (int i = 0; i < Length; i++, WriteLine())
        {
            for (int j = 0; j < Length; j++)
            {
                Write("*");
            }
        }
        WriteLine();
    }
    
    class Program
    {

        static void Main(string[] args)
        {
           
        }
    }
}
