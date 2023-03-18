
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;
using static System.Windows.Forms.AxHost;

namespace Training
{
    public abstract class Human
    {
        string _firstName;
        string _lastName;
        DateTime _birthDate;

        public Human(string firstName, string lastName, DateTime birthDate)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthDate = birthDate;
        }

        public abstract void Think();

        //public virtual void Print()
        //{
        //    WriteLine($"\nФамилия: {_lastName}\nИмя: {_firstName}\nДата рождения: {_birthDate.ToShortDateString()}");
        //}
        public override string ToString()
        {
            return $"\nФамилия: {_lastName}\nИмя: {_firstName}\nДата рождения: {_birthDate.ToShortDateString()}";
        }
        
    }
     abstract class Learner:Human
    {
        string _institution;
        public Learner (string firstName,string lastName,DateTime birthDate,string institution):base(firstName,lastName,birthDate)
        {
            _institution=institution;
        }
        public abstract void Study();
        //public override void Print()
        //{
        //    base.Print();
        //    WriteLine($"Учебное заведение: {_institution}");
        //}
        public override string ToString()
        {
            return base.ToString()+ $"\nУчебное заведение: {_institution}";
        }
    }
     class Student:Learner
    {
        string _groupName;

        public Student(string firstName, string lastName, DateTime birthDate, string institution,string groupName) : base(firstName, lastName, birthDate, institution)
        {
            _groupName=groupName;   
        }
        public override void Think()
        {
            WriteLine($"Я думаю как студент.");
        }
        public override void Study()
        {
            WriteLine("Я изучаю предметы в институте.");
        }
        //public override void Print()
        //{
        //    base.Print();
        //    WriteLine($"Учусь в {_groupName} группе.");
        //}
        public override string ToString()
        {
            return base.ToString()+ $"\nУчусь в {_groupName} группе.";
        }
    }
     class SchoolChild: Learner
    {
        string _className;
        public SchoolChild(string firstName, string lastName, DateTime birthDate, string institution, string className):base(firstName,lastName,birthDate,institution)
        {
            _className = className;
        }
        public override void Think()
        {
            WriteLine("Я думаю как школьник.");
        }
        public override void Study()
        {
            WriteLine("Я изучаю предметы в школе.");
        }
        //public override void Print()
        //{
        //    base.Print();
        //    WriteLine($"Учусь в {_className} классе.");
        //}
        public override string ToString()
        {
            return base.ToString()+ $"\nУчусь в {_className} классе.";
        }
    }

    internal class Program
    {


        static void Main(string[] args)
        {
            //Создаем массив ссылок на класс Learner
            Learner[] learners =
            {
                new Student("John","Doe",new DateTime(1990,6,12),"IT Step","WPU"),
                new SchoolChild("Jack","Smith",new DateTime(2008,4,18),"School#154","5-")
            };
            foreach(Learner i in learners)
            {
                //i.Print();
                WriteLine(i);
                i.Think();
                i.Study();
            }
        }
    }
}
