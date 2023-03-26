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
    public class Laptop
    {
        public string Brand { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"{Brand},  {Price}$\n";
        }
    }

    class Shop
    {
        Laptop[] laptopArr;

        public Shop(int size)
        {
            laptopArr = new Laptop[size];

        }
        public int Lenght
        {
            get { return laptopArr.Length; }
        }
        public Laptop this[int index]
        {
            get
            {
                if (index >= 0 && index < laptopArr.Length)
                {
                    return laptopArr[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                laptopArr[index] = value;
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Shop laptops=new Shop(3);

            laptops[0] = new Laptop
            {
                Brand = "Mac",
                Price = 1300
            };


            laptops[1] = new Laptop
            {
                Brand = "Asus",
                Price = 1000
            };


            laptops[2] = new Laptop
            {
                Brand = "Honor",
                Price = 900
            };
            try
            {
                for (int i = 0; i < laptops.Lenght; i++)
                {
                    WriteLine(laptops[i]);
                }
            }
            catch(Exception e) 
            {
                WriteLine(e.ToString());
            }
        }
    }
}
