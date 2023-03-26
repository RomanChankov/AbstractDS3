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
    public class Journal
    {
        //string _name;
        public string Name { get; set; }

       // string _phone;       
        public string Phone { get; set; }

        //int _numbersOfEmployees;
        public int NumberOfEmployees { get; set; }

        public static Journal operator +(Journal journal,int col)
        {
            journal.NumberOfEmployees += col;
            return journal;
        }
        public static Journal operator -(Journal journal ,int col)
        {
            journal.NumberOfEmployees -= col;
            return journal;

        }

        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public static bool operator ==(Journal journal,Journal journal1)
        {
            if (journal.NumberOfEmployees == journal1.NumberOfEmployees) return true;    
            return false;
        }
        public static bool operator !=(Journal journal, Journal journal1)
        {
            if (journal.NumberOfEmployees != journal1.NumberOfEmployees) return false;
            return true;
        }

        public static bool operator >(Journal journal,Journal journal1)
        {
            if(journal.NumberOfEmployees>journal1.NumberOfEmployees) return true; return false;
        }
        public static bool operator <(Journal journal, Journal journal1)
        {
            if(journal.NumberOfEmployees < journal1.NumberOfEmployees) return false; return true;
        }

        public override string ToString()
        {
            return $"Название журнала: {Name}\nНомер телефона: {Phone}\nКоличество сотрудников: {NumberOfEmployees}\n";
        }

    }
        class Program
    {

        static void Main(string[] args)
        {
           Journal journal = new Journal {Name="Avto+",Phone="555-55-55", NumberOfEmployees=40 };
           Journal journal1 = new Journal {Name="Sport",Phone="812-00-99", NumberOfEmployees=90 };
            WriteLine(journal);
            WriteLine(journal1);
            WriteLine($"Введите число, на которое хотите увеличить количество сотрудников для журнала Avto+");
            int colOfEmpl = int.Parse(ReadLine());
            WriteLine($"{journal + colOfEmpl}");
            WriteLine($"Введите число, на которое хотите уменьшить количество сотрудников для журналаSport");
            int colOfEmpl1 = int.Parse(ReadLine());
            WriteLine($"{journal1 - colOfEmpl1}");

            WriteLine($" {(journal == journal1)}");
            if ((journal == journal1) == false)
            {
                WriteLine("Количество сотрудников в этих журналах не равно");
            }
            else
                WriteLine("Количество сотрудников в этих журналах  равно");

            WriteLine($" {(journal > journal1)}");
            if ((journal > journal1) == true)
            {
                WriteLine("Количество сотрудников в журнале Avto+ больше чем в журнале Sport");
            }
            else
                WriteLine("Количество сотрудников в журнале Avto+ меньше чем в журнале Sport");

        }
    }
}
