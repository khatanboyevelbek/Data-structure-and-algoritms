namespace SortedList
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
        DE
    }

    public class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, Person> listOfPeople = new()
            {
                { "Elbek", new Person { Name = "Elbek", Age = 21, Country = CountryEnum.UZ } },
                { "Alen", new Person { Name = "Alen", Age = 24, Country = CountryEnum.DE } }
            };

            foreach(KeyValuePair<string, Person> person in listOfPeople)
            {
                Console.WriteLine($"{person.Value.Name} is {person.Value.Age} from {person.Value.Country}");
            }
        }
    }
}