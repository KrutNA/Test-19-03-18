using System;

namespace Test_19_03_18
{
    class Program
    {
        // Автомобиль на стоянке с почасовой оплатой
        static void Main(string[] args)
        {
            Parking parking = new Parking();
            for (int i = 0; i < 5; i++)
                parking.AddCar();
            for (int i = 0; i < 5; i++)
                parking.DeleteCar();
        }
    }
}
