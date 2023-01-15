namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<char> chars = new Stack<char>();

            foreach (char item in "elbek")
            {
                chars.Push(item);
            }

            while(chars.Count > 0)
            {
                Console.WriteLine(chars.Pop());
            }
        }
    }
}