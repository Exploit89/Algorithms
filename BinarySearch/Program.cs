using System;
using System.Collections.Generic;

namespace BinarySearch
{
    internal class Program
    {


        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 3, 5, 7, 9 };
            int result = BinarySearch(list, 3);
            Console.WriteLine(result);
            result = BinarySearch(list, -1);
            Console.WriteLine(result);
        }

        static int BinarySearch(List<int> somelist, int number)
        {
            int lowNumber = 0;
            int highNumber = somelist.Count - 1;

            while (lowNumber <= highNumber)
            {
                int middleNumber = (lowNumber + highNumber) / 2;
                int guess = somelist[middleNumber];

                if (guess == number)
                    return middleNumber;

                if (guess > number)
                    highNumber = middleNumber - 1;
                else
                    lowNumber = middleNumber + 1;
            }
            return -1;
        }
    }
}
