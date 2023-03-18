
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace Training
{
   
  
    internal class Program
    {
        static int [] GetRandomArray(uint lenght,int minv,int maxv )
        {
            int[] array = new int[lenght];
            Random rnd = new Random();
            for (int i = 0; i < lenght; i++)
            {
                array[i] = rnd.Next(minv,maxv);
            }
            return array;
        }
       
        static int IndexSearch(int[] arr ,int a)
        {
           
            int i = 0;

            while (i < arr.Length)
            {
                if (arr[i] == a)
                    return i;
                i++;
            }
            WriteLine("Нет значения");

            return -1;
        }

        static void Main(string[] args)
        {
            WriteLine("Введите размер массива: ");
            uint size=uint.Parse(ReadLine());
            WriteLine("Введите от : ");
            int a = int.Parse(ReadLine());
            WriteLine("Введите до: ");
            int b = int.Parse(ReadLine());
            // int[] Arr = new int[size];
            int[] Arr= GetRandomArray(size, a, b);
            
            WriteLine("Введите значение индекс которого хотите узнать");
            int c = int.Parse(ReadLine());
            WriteLine("Индекс=  "+IndexSearch(Arr,c));
        }
    }
}
