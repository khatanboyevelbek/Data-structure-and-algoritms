namespace SortedDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> definitions = new();

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Choose an option ([a] - add, [l] - list): ");
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

                if (consoleKeyInfo.Key == ConsoleKey.A)
                {
                    Console.WriteLine("Enter the name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter the explanation");
                    string explanation = Console.ReadLine();
                    definitions[name] = explanation;
                }
                else if (consoleKeyInfo.Key == ConsoleKey.L)
                {
                    foreach (KeyValuePair<string, string> definition in definitions)
                    {
                        Console.WriteLine($"- {definition.Key}: {definition.Value}");
                    }
                }
                else
                {
                    break;
                }
            }
            while (true);
        }
    }
}