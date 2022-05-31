using System;
using System.Diagnostics;

namespace StopWatch
{
    internal class Program
    {
        const int n = 10000;

        static void Main(string[] args)
        {
            int[] a = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
                a[i] = random.Next() % 500;

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            // тестируемый код

            // ^ тестируемый код
            stopWatch.Stop();
            Console.WriteLine($"StopWatch: {stopWatch.ElapsedMilliseconds}");
            Console.ReadLine();
        }
    }
}
