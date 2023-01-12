namespace GenericList
{
    public class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public CountryEnum Country { get; set; }
        }

        public enum CountryEnum
        {
            UZ,
            UK,
            US
        }

        static void Main(string[] args)
        {
            List<Person> listOfPeople = new()
            {
                new Person { Name = "Elbek", Age = 21, Country = CountryEnum.UZ},
                new Person { Name = "Paulo", Age = 23, Country = CountryEnum.UK}
            };

            List<string> listOfNames = (from p in listOfPeople
                                        where p.Age <= 30
                                        orderby p.Name
                                        select p.Name).ToList();

            foreach(string name in listOfNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}