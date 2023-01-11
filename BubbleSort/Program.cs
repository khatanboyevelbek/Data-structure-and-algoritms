using static ClassLibraries.HelperMethods;

namespace BubbleSort
{
    public static class BubbleSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for(int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].CompareTo(array[j+1]) > 0)
                    {
                        Swap(array, j, j+1);
                    }
                }
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 7, -4, 12, -23, 6 };
            BubbleSort.Sort(numbers);

            for(int i = 0; i < numbers.Length;i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}