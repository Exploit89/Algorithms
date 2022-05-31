using System;

namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[] { 1, 5, 9, 15, 123, 32, 4, 7, 0, 33, 44, 2, 6 };

            SortSelection(ints);

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
        }

        static void SortSelection(int[] array)
        {
            int arrayLength = array.Length;
            int min = 0, iMin = 0, i;

            for (i = 0; i < arrayLength - 1; i++)
            {
                min = array[i];
                iMin = i;

                for (int j = i + 1; j < arrayLength; j++)
                {
                    min = array[j];
                    iMin = j;
                }

                if (i != iMin)
                {
                    array[iMin] = array[i];
                    array[i] = min;
                }
            }
        }
    }
}
