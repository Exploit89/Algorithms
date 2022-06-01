using System;

namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 8, 3, 2 };
            Quicksort(array, 0, 3);
            for(int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }

        static int Partition(int[] array, int start, int end)
        {
            int marker = start; // divides left and right subarrays
            for (int i = start; i < end; i++)
            {
                if (array[i] < array[end]) // array[end] is pivot
                {
                    (array[marker], array[i]) = (array[i], array[marker]);
                    marker += 1;
                }
            }
            // put pivot(array[end]) between left and right subarrays
            (array[marker], array[end]) = (array[end], array[marker]);
            return marker;
        }

        static void Quicksort(int[] array, int start, int end)
        {
            if (start >= end)
                return;

            int pivot = Partition(array, start, end);
            Quicksort(array, start, pivot - 1);
            Quicksort(array, pivot + 1, end);
        }
    }
}
