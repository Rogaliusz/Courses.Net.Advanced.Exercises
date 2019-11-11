using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Roguszewski.Courses.Net.Advanced.Exercises.Exercises
{
    public class Text
    {
        // 1. Popraw wydajnosc danej metody.
        public void FixPerfomanceIssue()
        {
            var stopwatch = new Stopwatch();
            var text = "Only good vibes";
            var output = string.Empty;
            stopwatch.Start();

            for (int i = 0; i < 100000; i++)
            {
                output += text;
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}
