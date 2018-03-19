namespace Test_19_03_18
{
    public class Driver
    {
        private string Name;
        private string Surname;
        private string PassportNum;

        public Driver(string name, string surname, string passportNum)
        {
            Name = name;
            Surname = surname;
            PassportNum = passportNum;
        }

        public string[] GetInfo()
        {
            return new string[] { Name, Surname, PassportNum };
        }
    }
}
