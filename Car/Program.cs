using System;

namespace Car
{
    class Program
    {
        class Car
        {
            string name;
            string model;
            string registrationnumber;
            string color;
            int odometer;
            int fueltank;

            public Car(string _name, string _model, string _registrationumber, string _color)
            {
                name = _name;
                model = _model;
                registrationnumber = _registrationumber;
                color = _color;
                odometer = 0;
                fueltank = 60;
                Console.WriteLine($"the car {name} has been created.");
            }

            public string Name
            {
                get { return name; }
            }

            public string Model
            {
                get { return model; }
            }

            public string RegistrationNumber
            {
                 get { return registrationnumber; }
                set
                {
                    if(value.Length == 6)
                    {
                        RegistrationNumber = value;

                    }else
                    {
                        registrationnumber = "what is this garbage?";
                    }
                }
            }

            public string Color
            {
                get { return color; }
            }

            public int Odometer
            {
                get { return odometer; }
            }

            public int FuelTank
            {
                get { return fueltank; }
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Help me!");
            Car newCar = new Car("FerraMedez", "Universaal", "CBT382", "Blue" );
            Console.WriteLine(newCar.Name);
            Console.WriteLine(newCar.Model);
            Console.WriteLine(newCar.RegistrationNumber);
            Console.WriteLine(newCar.Color);
            Console.WriteLine(newCar.Odometer);
            Console.WriteLine(newCar.FuelTank);
            

        }
    }
}
