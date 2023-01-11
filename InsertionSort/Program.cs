using static ClassLibraries.HelperMethods;

namespace InsertionSort
{
    public static class InsertionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                
                while (j > 0 && array[j].CompareTo(array[j-1]) < 0)
                {
                    Swap(array, j, j-1);
                    j--;
                }
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, -5, 7, 2, -2, -8, -9, -10, -11, };
            InsertionSort.Sort(numbers);

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}