using System;
using System.Threading;

namespace HelloWorld
{

    class Program
    {
        static void Main(string[] args)
        {
            //var stopwatch = new StopWatch();

            //for (int i=0; i<2; i++)
            //{
            //    stopwatch.Start();
            //    Thread.Sleep(1000);
            //    stopwatch.Stop();
            //    stopwatch.Duration();
            //    Console.ReadLine();
            //}


            var text = new Text();
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;

            Shape shape2 = new Text();
            Text text2 = (Text)shape2;
        }

    }
}
