
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
    public class Human
    {
        string _firstName;
        string _lastName;
        DateTime _date;

        public Human(string fName, string lName, DateTime date)
        {
            _firstName = fName;
            _lastName = lName;
            _date = date;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Фамилия: {_lastName}\nИмя: {_firstName}\nДата рождения: {_date.ToShortDateString()}");
        }
    }
    public class Employee : Human
    {
        double _salary;
        public Employee(string fName, string lName, DateTime date, double salary) : base(fName, lName, date)
        {
            _salary = salary;
        }
        public override void Print()
        {
            base.Print();
            WriteLine($"Зарплата: {_salary} $\n");
        }
    }
    public class Manager : Employee
    {
        string _fieldActivity;
        public Manager(string fName, string lName, DateTime date, double Salary, string fieldActivity) : base(fName, lName, date, Salary)
        {
            _fieldActivity = fieldActivity;
        }
        public override void Print()
        {
            WriteLine($"Менеджер.Сфера деятельности: {_fieldActivity} ");
            base.Print();
        }
    }
    public class Scientist : Employee
    {
        string _scientificDirection;

        public Scientist(string fName, string lName, DateTime birthDate, double Salary, string direction) : base(fName, lName, birthDate, Salary)
        {
            _scientificDirection = direction;
        }
        public override void Print()
        {
            WriteLine($"Ученый.Научное направление: {_scientificDirection}");
            base.Print();
        }
    }
    public class Specialist : Employee
    {
        string _qualification;

        public Specialist(string fName, string lName, DateTime birthDate, double Salary, string qualification) : base(fName, lName, birthDate, Salary)
        {
            _qualification = qualification;
        }
        public override void Print()
        {
            WriteLine($"Специалист.Квалификация: {_qualification}");
            base.Print();
        }
        internal class Program
        {

            static void Main(string[] args)
            {
                //Human employee = new Employee("Jack", "Smith", DateTime.Now, 3587.43);
                //employee.Print();
                //Human manager = new Manager("John", "Doe", new DateTime(1955, 7, 23), 3587.43, "продукты питания");
                //manager.Print();

                Human[] people =
                    {
                        new Manager("John", "Doe", new DateTime(1995, 7, 23), 3500, "продукты питания"),
                        new Scientist("Jeam","Beam",new DateTime(1956,3,15),4253,"история"),
                        new Specialist("Jack","Smith",new DateTime(1996,11,5),2587.43,"физика")
                    };
                foreach (Human i in people)
                {
                    i.Print();

                }
            }
        }
    }
}
