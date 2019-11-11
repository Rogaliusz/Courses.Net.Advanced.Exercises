using System;
using System.Diagnostics;
using System.Threading;

namespace Courses.Roguszewski.Advanced.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();

            for (var i = 0; i < 1000; i++)
            {
                var thread = new Thread(x =>
                {
                    Console.WriteLine(x);

                    Thread.Sleep(1000 * 10);

                    Console.WriteLine($"Finished: {x}");
                });

                thread.Start(i);
            }

            sw.Stop();
            Console.WriteLine($"Finished at {sw.ElapsedMilliseconds} ");
            Console.ReadKey();
        }
    }
}
