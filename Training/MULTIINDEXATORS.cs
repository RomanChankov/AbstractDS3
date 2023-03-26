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
    public class MultArray
    {
        private int[,] array;
        public int Rows { get; set; }
        public int Cols { get; set; }
        public MultArray(int rows, int cols)
        {
            Rows = rows; Cols = cols;
            array = new int[rows, cols];
        }
        public int this[int r, int c]
        {
            get { return array[r, c]; }
            set
            {
                array[r, c] = value;
            }
        }
        class Program
        {

            static void Main(string[] args)
            {
               MultArray mArray=new MultArray(2, 3);
                for (int i = 0; i < mArray.Rows; i++)
                {
                    for (int j = 0; j < mArray.Cols; j++)
                    {
                        mArray[i, j] = i + j;
                        Write($"{mArray[i, j]} ");
                    }
                    WriteLine();
                }
            }
        }
    }
}
