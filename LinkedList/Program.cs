namespace LinkedList
{
    public class Page
    {
        public string Content { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Page firstPage = new Page()
            {
                Content = "My name is Elbek"
            };
            Page secondPage = new Page()
            {
                Content = "I'm senior student at Tashkent university of information technologies Fergana branch"
            };
            Page thirdPage = new Page()
            {
                Content = "I'm studing for my bachelor's in Information security"
            };
            Page fourthPage = new Page()
            {
                Content = "Morover. I'm skilled in .NET development and creating various softwares using latest technologies."
            };

            LinkedList<Page> pages = new();
            pages.AddLast(secondPage);
            LinkedListNode<Page> firstNode = pages.AddFirst(firstPage);
            LinkedListNode<Page> thirdNode = pages.AddLast(thirdPage);
            LinkedListNode<Page> fourthNode = pages.AddAfter(thirdNode, fourthPage);

            LinkedListNode<Page> current = firstNode;
            while(current != null)
            {
                Console.Clear();
                Console.WriteLine(current.Value.Content);

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.N:
                        if (firstNode.Next != null)
                        {
                            current = current.Next;
                        }
                        break;

                    case ConsoleKey.P:
                        if (firstNode.Previous != null)
                        {
                            current = current.Previous;
                        }
                        break;

                    default:
                        return;
                }
            }
        }
    }
}