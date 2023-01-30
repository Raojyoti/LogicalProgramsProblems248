using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LogicalPrograms
{
    public class Time
    {
        public static int i;
        public static void FindElapsedTime()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            Thread.Sleep(5);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
        }
    }
}
