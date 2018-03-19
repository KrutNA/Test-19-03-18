using System;

namespace Test_19_03_18
{
    public class Car
    {
        private string type;
        private DateTime startDate;
        public string Number { get; private set; }
        private Driver driver;
        
        public Car(string type, string number, string name, string surname, string passportNum)
        {
            this.type = type;
            this.startDate = DateTime.Now;
            this.Number = number;
            this.driver = new Driver(name, surname, passportNum);
        }
        
        public int CostByCurrentTime(int CostPerHour)
        {
            return Convert.ToInt32(DateTime.Now - startDate)/3600 * CostPerHour;
        }
    }
}
