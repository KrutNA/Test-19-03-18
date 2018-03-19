using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("Driver name; ");
            string name = Console.ReadLine();
            Console.WriteLine("Driver surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Driver passport number: ");
            string passportNum = Console.ReadLine();
            
            if (Convert.ToBoolean(Cars.FindIndex(car => car.Number == number)))
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
            Console.WriteLine("Number: ");
            string number = Console.ReadLine();
            Cars.Remove(Cars.Find(car => car.Number == number));
        }
    }
}
