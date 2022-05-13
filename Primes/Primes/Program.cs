using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Timers;

namespace Primes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> primes = new List<int>();
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < 10000000; i++)
            {
                if (isPrime(i))
                {
                    primes.Add(i);
                }
            }

            timer.Stop();
            TimeSpan ts = timer.Elapsed;
            Console.WriteLine($"found {primes.Count} prime numbers it took a total of {ts.TotalSeconds} seconds to calculate");

        }

        static bool isPrime(int n)
        {
            // Corner case
            if (n <= 1)
                return false;

            // Check from 2 to sqrt(n)
            for (int i = 2; i < Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;

            return true;
        }
    }
}
