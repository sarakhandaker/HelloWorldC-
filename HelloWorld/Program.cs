using System;
using System.Threading;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopWatch();

            for (int i=0; i<2; i++)
            {
                stopwatch.Start();
                Thread.Sleep(1000);
                stopwatch.Stop();
                stopwatch.Duration();
                Console.ReadLine();
            }
        }

    }
}
