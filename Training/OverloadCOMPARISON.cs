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
    class CPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    struct SPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            CPoint cp = new CPoint { X=10, Y=10 };
            CPoint cp1 = new CPoint { X=10, Y=10 };
            CPoint cp2 = cp1;
            WriteLine($"ReferenceEquals(cp, cp1)={ReferenceEquals(cp, cp1)}");
            WriteLine($"ReferenceEquals(cp2, cp1)={ReferenceEquals(cp2, cp1)}");

            SPoint sp =new SPoint { X=10,Y=10};
            WriteLine($"ReferenceEquals(sp,sp)={ReferenceEquals(sp,sp)}");

            WriteLine($"Equals(cp, cp1)={Equals(cp, cp1)}");
            WriteLine($"Equals(cp2, cp1)={Equals(cp2, cp1)}");

            SPoint sp1 = new SPoint { X=10,Y =10};
            WriteLine($"Equals(sp,sp1)={Equals(sp, sp1)}");
        }
    }
}
