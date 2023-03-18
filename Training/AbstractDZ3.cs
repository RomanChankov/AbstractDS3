using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Struct1
{

    // Абстрактный класс Journal. От него наследуется абстрактный класс AutoWorld.
    // От AutoWorld наследуется 5 классов (Trucks, PassengerCar, ElectricCar, Motorsycles, SportCar).
    // 2 абстрактных метода (AboutCars(), CarClass()).
    public abstract class Journal
    {
        string _name;  // Название
        DateTime _founding; //Основание
        string _phone;        //телефон
        string _email;       //e-mail

        public Journal(string name, DateTime founding, string phone, string email)
        {
            _name = name;
            _founding = founding;
            _phone = phone;
            _email = email;
        }
        public abstract void AboutCars(); // Абстрактный метод о автомобилях
       
        public override string ToString()
        {
            return $"Название журнала: {_name}\nДата основания журнала: {_founding.ToShortDateString()}\nТелефон редакции: {_phone}\nEmail редакции: {_email}\n";
        }
    }
    abstract class AutoWorld : Journal   // класс Автомир
    {
        string _classification;  // классификация

        public AutoWorld(string name, DateTime founding, string phone, string email, string classification) : base(name, founding, phone, email)
        {
            _classification = classification;
        }
        public abstract void CarClass(); // Абстрактный метод Класс автомобиля
       
        public override string ToString()
        {
            return base.ToString() + $"Класс автомобиля: {_classification}\n";
        }
    }


    class Trucks : AutoWorld  // Грузовики
    {
        string _marka;
        public Trucks(string name, DateTime founding, string phone, string email, string classification, string marka) : base(name, founding, phone, email, classification)
        {
            _marka = marka;
        }
        public override void AboutCars()
        {
            WriteLine($"Мир грузовых автомобилей");
        }
        public override void CarClass()
        {
            WriteLine($"Все о грузовиках");
        }
       
        public override string ToString()
        {
            return base.ToString() + $"Автомобили марки << {_marka} >> производятся в России\n";
        }
    }



    class PassengerCar : AutoWorld  //Легковые авто
    {
        int _weight;
        public PassengerCar(string name, DateTime founding, string phone, string email, string classification, int weight) : base(name, founding, phone, email, classification)
        {
            _weight = weight;
        }
        public override void AboutCars()
        {
            WriteLine($"Мир легковых автомобилей");
        }
        public override void CarClass()
        {
            WriteLine($"Все о легковых автомобилях");
        }
       
        public override string ToString()
        {
            WriteLine($"Введите вес авто в кг:");
            _weight = int.Parse(ReadLine());
            if (_weight <= 3500)
            {
                return base.ToString() + $"Автомобиль считается легковым,так как его вес не превышает: 3500 кг\n";
            }
            else
            {
                return base.ToString() + $"Автомобиль не считается легковым,так как его вес превышает: 3500 кг\n";
            }

        }

    }

    class ElectricCars : AutoWorld  // Электроавтомобили
    {
        double _time;

        public ElectricCars(string name, DateTime founding, string phone, string email, string classification, double time) : base(name, founding, phone, email, classification)
        {
            _time = time;
        }
        public override void AboutCars()
        {
            WriteLine($"Мир электрических автомобилей");
        }
        public override void CarClass()
        {
            WriteLine($"Все о электрических автомобилях");
        }
       
        public override string ToString()
        {
            return base.ToString() + $"Tesla разгоняется до 100 км/ч за {_time} сек.\n";
        }
    }

    class Motorcycles : AutoWorld  // Мотоциклы
    {
        int _wheel;

        public Motorcycles(string name, DateTime founding, string phone, string email, string classification, int wheel) : base(name, founding, phone, email, classification)
        {
            _wheel = wheel;
        }
        public override void AboutCars()
        {
            WriteLine($"Мир мотоциклов");
        }
        public override void CarClass()
        {
            WriteLine($"Все о мотоциклах");
        }
       

        public override string ToString()
        {
            WriteLine("Введите скольки колесные мотоциклы вы хотите посмотреть (2 или 3):");
            _wheel = int.Parse(ReadLine());
            if (_wheel == 2)
            {
                return base.ToString() + $"Мотоциклы с {_wheel} колесами более быстрые\n";
            }
            else if (_wheel == 3)
            {
                return base.ToString() + $"Мотоциклы с {_wheel} колесами более безопасные и вместительные\n";
            }
            else if (_wheel == 4)
            {
                return base.ToString() + ($"Мотоциклов с количеством колес {_wheel} не бывает.\n" +
                               "Возможно вы ищите квадроциклы,но в нашем каталоге их нет.\n");
            }
            else
            {
                return base.ToString() + $"Мотоциклов с количеством колес {_wheel} не бывает.\n";
            }
        }
    }


        class SportCar : AutoWorld  // Мотоциклы
        {
            int _maxSpeed;

            public SportCar(string name, DateTime founding, string phone, string email, string classification, int maxSpeed) : base(name, founding, phone, email, classification)
            {

            }
            public override void AboutCars()
            {
                WriteLine($"Спорткары");
            }
            public override void CarClass()
            {
                WriteLine($"Все о спортивных автомобилях");
            }
           
            public override string ToString()
            {
                WriteLine("Введите максимальную скорость нужного авто:");
                _maxSpeed = int.Parse(ReadLine());
            if (_maxSpeed >= 200 && _maxSpeed < 300)
            {
                return base.ToString() + $"Автомобиль с максимальной  скоростью до 300 км/ч относится ккатегории -  СПОРТКАР\n";
            }
            else if (_maxSpeed >= 300 && _maxSpeed < 350)
            {
                return base.ToString() + $"Автомобиль с максимальной  скоростью от 300 км/ч до 350 км/ч относится ккатегории - СУПЕРКАР\n";
            }
            else if (_maxSpeed >= 350&&_maxSpeed<=450)
            {
                return base.ToString() + $"Автомобиль с максимальной  скоростью 350 км/ч и выше, относится к категории - ГИПЕРКАР\n";
            }
            else { return base.ToString() + $"Автомобилей с такой скоростью в этом разделе нет."; }
            }
        }

            internal class Struct1
            {
                static void Main(string[] args)
                {

                    AutoWorld[] autoWorld =
                    {
                        new Trucks("AutoJournal",new DateTime(2000,01,10),"555-55-55","Truck@mail.ru","Tracksauto","Камаз"),
                        new PassengerCar("AutoRevu",new DateTime(1995,10,05),"812-89-89","passengerCar@mail.ru","PassengerCarAuto",3500),
                        new ElectricCars ("Auto++",new DateTime(2005,06,05),"999-99-99","ElectricCars@mail.ru","ElectricCarsAuto",2.5),
                        new Motorcycles ("Moto+",new DateTime(2015,06,26),"495-77-77","Motorcycles@mail.ru","Motorcycles",0),
                        new SportCar ("Sport+",new DateTime(1960,08,12),"111-11-22","SportCar@mail.ru","SportCar",0)
                     };
                    foreach (AutoWorld i in autoWorld)
                    {
                        i.AboutCars();
                        i.CarClass();
                        WriteLine(i);

                    }
                }
            }
        }
