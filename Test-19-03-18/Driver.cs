namespace Test_19_03_18
{
    public class Driver
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string PassportNum { get; private set; }

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
