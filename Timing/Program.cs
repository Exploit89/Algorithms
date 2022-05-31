using System;
using System.Diagnostics;

namespace Timing
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

            Timing objectTiming = new Timing();
            objectTiming.StartTime();
            // тестируемый код

            // ^ тестируемый код
            objectTiming.StopTime();
            Console.WriteLine($"Timing: {objectTiming.Result()}");
            Console.ReadLine();
        }
    }

    class Timing
    {
        TimeSpan duration;
        TimeSpan[] threads;

        public Timing()
        {
            duration = new TimeSpan(0);
            threads = new TimeSpan[Process.GetCurrentProcess().Threads.Count];
        }

        public void StartTime()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            for (int i = 0; i < threads.Length; i++)
                threads[i] = Process.GetCurrentProcess().Threads[i].UserProcessorTime;
        }

        public void StopTime()
        {
            TimeSpan tmp;

            for(int i = 0; i < threads.Length; i++)
            {
                tmp = Process.GetCurrentProcess().Threads[i].UserProcessorTime.Subtract(threads[i]);

                if (tmp > TimeSpan.Zero)
                    duration = tmp;
            }
        }

        public TimeSpan Result()
        {
            return duration;
        }
    }
}
