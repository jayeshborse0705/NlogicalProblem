using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    internal class StopWatch
    {
        public void StopwatchCal()
        {

            Stopwatch stopw = new Stopwatch();
            Console.WriteLine("Press START");
            Console.ReadLine();
            stopw.Start();
            Console.WriteLine("Press STOP");
            Console.ReadLine();
            stopw.Stop();
            Console.WriteLine(" Time elapsed: {0} ", stopw.Elapsed);
            Console.WriteLine("Elapsed Time is {0} sec", stopw.Elapsed.Seconds);
        }
    }
}
