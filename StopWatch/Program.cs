using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            sw.Stop();
            sw.Start();
            sw.Stop();
            sw.Start();
            sw.Stop();
            sw.Start();
            sw.Stop();
            TimeSpan duration = sw.Duration();
            Console.WriteLine("{0}",duration);
        }
    }
}
