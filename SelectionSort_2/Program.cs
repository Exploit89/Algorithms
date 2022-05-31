using System;
using System.Linq;

namespace SelectionSort_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[] { 1, 5, 9, 15, 123, 32, 4, 7, 0, 33, 44, 2, 6 };
            SelectionSort(ints);
            foreach(var item in ints)
            {
                Console.WriteLine(item);
            }
        }

        static int FindSmallest(int[] array)
        {
            int smallest = array[0];
            int smallestIndex = 0;

            for(int i = 1; i < array.Length; i++)
            {
                if(array[i] < smallest)
                {
                    smallest = array[i];
                    smallestIndex = i;
                }
            }
            return smallestIndex;
        }

        static void SelectionSort(int[] array)
        {
            int[] newArray = new int[] { };
            for(int i = 0; i < array.Length; i++)
            {
                int smallest = FindSmallest(array);
                newArray.Append(array[smallest]);
            }
        }
    }
}
