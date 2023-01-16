namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> products = new()
            {
                { "5900000000000", "A1" },
                { "5901111111111", "B5" },
                { "5902222222222", "C9" }
            };
            products["5903333333333"] = "D7";

            Console.WriteLine("All products...");
            
            if(products.Count == 0)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                foreach (KeyValuePair<string, string> product in products)
                {
                    Console.WriteLine($"- {product.Key}: {product.Value}");
                }
            }

            Console.Write("Search by barcode: ");
            string barcode = Console.ReadLine();
            
            if(products.TryGetValue(barcode, out string location))
            {
                Console.WriteLine($"The product is in the area {location}.");
            }
            else
            {
                Console.WriteLine("The product does not exist.");
            }
        }
    }
}