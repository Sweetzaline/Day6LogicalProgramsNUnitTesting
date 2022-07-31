using System;
using System.Diagnostics;
namespace StopWatch
{
    class Program
    {

        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // ... This takes 10 seconds to finish.
            for (int i = 0; i < 1000; i++)
            {
                System.Threading.Thread.Sleep(10);
            }

            // Stop.
            stopwatch.Stop();

            // Write hours, minutes and seconds.
            Console.WriteLine("Time passed is of: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }
    }
}