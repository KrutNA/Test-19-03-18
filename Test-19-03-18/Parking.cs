using System;
using System.Collections.Generic;

namespace Test_19_03_18
{
    class Parking
    {
        private List<Car> Cars;

        public Parking()
        {
            Cars = new List<Car>();
        }

        public void AddCar()
        {
            Console.Write("Number: ");
            string number = Console.ReadLine();
            Console.Write("Car type: ");
            string type = Console.ReadLine();
            Console.Write("Driver name: ");
            string name = Console.ReadLine();
            Console.Write("Driver surname: ");
            string surname = Console.ReadLine();
            Console.Write("Driver passport number: ");
            string passportNum = Console.ReadLine();
            
            if (Convert.ToBoolean(Cars.Find(car => car.Number == number)))
            {
                Console.WriteLine("Car already added");
            }
            else
            {
                Cars.Add(new Car(type, number, name, surname, passportNum));
            }
        }

        public void DeleteCar()
        {
            Console.Write("Number: ");
            string number = Console.ReadLine();
            Cars.Remove(Cars.Find(car => car.Number == number));
        }
    }
}
