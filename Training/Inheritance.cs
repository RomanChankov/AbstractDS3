using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Console;

namespace Training
{
    public class Human
    {
        string _firstName;
        string _lastName;
        DateTime _birthDate;

        public Human()
        {
        }  
        public Human(string fName)
        {
            _firstName = fName;
        }
        public Human(string fName, string lName)
        {
            _firstName = fName;
            _lastName = lName;
        }
        public Human(string fName, string lName,DateTime birthDAte)
        {
            _firstName = fName;
            _lastName = lName;
            _birthDate = birthDAte;
        }
        public void Show()
        {
            WriteLine($"Фамилия: {_lastName}\nИмя: {_firstName}\nДата рождения: {_birthDate.ToShortDateString() }");
        }

    }
    public class Employee : Human
    {
        double _salary;

        public Employee():base()
        { 
        }
 public Employee(string fName) : base(fName)
        { 
        }
        public Employee(string fName, string lName):base(fName,lName)
        {
        }
        public Employee(string fName, string lName, double Salary):base(fName,lName)
        {
            _salary = Salary;
        }
        public Employee(string fName, string lName,DateTime birthDate, double Salary):base(fName, lName,birthDate)
        {
            _salary = Salary;

        }

        public void Print()
        {
           // base.Show(); //Писать Base не обяз-но!
                         //Просто конкретизируем что метод из класса родителя.
            WriteLine($"Зарплата:  {_salary}");
        }

        ///////////////////////////////////////////////////////////////////////////
        public class Manager :Employee
        {
            string _fieldActivity;
            public Manager(string fName,string lName,DateTime birthDate, double Salary ,string fieldActivity):base(fName,lName,birthDate,Salary)
            {
                _fieldActivity = fieldActivity;
            }
            public void ShowManager()
            {
                WriteLine($"Менеджер.Сфера деятельности: {_fieldActivity} \n");
            }
        }
        public class Scientist :Employee
        {
            string _scientificDirection;

            public Scientist(string fName, string lName, DateTime birthDate, double Salary, string direction) : base(fName, lName, birthDate, Salary)
            {
                _scientificDirection = direction;
            }
            public void ShowScientis()
            {
                WriteLine($"Ученый.Научное направление: {_scientificDirection}\n");
            }
        }
        public class Specialist : Employee
        {
            string _qualification;

            public Specialist(string fName, string lName, DateTime birthDate, double Salary, string qualification) : base(fName, lName, birthDate, Salary)
            {
                _qualification = qualification;
            }
            public void ShowSpecialist()
            {
                WriteLine($"Специалист.Квалификация: {_qualification}\n");
            }
        }
        internal class Program
        {

            static void Main(string[] args)
            {
                Employee manager=new Manager("John","Doe",new DateTime(1995,7,23),3500,"продукты питания");
                Employee[] employees =
                    {
                    manager, new Scientist("Jeam","Beam",new DateTime(1956,3,15),4253,"история"),
                       new Specialist("Jack","Smith",new DateTime(1996,11,5),2587.43,"физика")
                }; 
                foreach (Employee i in employees)
                {
                    i.Print();
                    try
                    {
                        ((Manager)i).ShowManager(); //1 способ
                    }
                    catch{}
                    Scientist scient=i as Scientist; //Запись i как объект нужного класса
                    if (scient != null)
                    {
                        scient.ShowScientis();     
                    }
                    if (i is Specialist)
                    {
                        (i as Specialist).ShowSpecialist();
                    }

                }

               //Employee employee =new Employee();
               //employee .Print();
               //employee=new Employee("Joe");
               //employee.Print();
               //employee = new Employee("Joe", "Doe");
               //employee.Print();
               //employee = new Employee("Joe", "Doe", 1000.55);
               //employee.Print();
               //employee = new Employee("Joe", "Doe",DateTime.Now, 2555.55);
               //employee.Print();

            }
        }
    }
}
