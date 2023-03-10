using static ClassLibraries.HelperMethods;

namespace SelectionSort
{
    public static class SelectionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length - 1; i++) 
            { 
                int minIndex = i;
                T minValue = array[i];

                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(minValue) < 0)
                    {
                        minIndex = j;
                        minValue = array[j];
                    }
                }

                Swap(array, i, minIndex);
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 4, -7, 5, -12 , -3};
            SelectionSort.Sort(numbers);

            for(int i = 0; i < numbers.Length;i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}