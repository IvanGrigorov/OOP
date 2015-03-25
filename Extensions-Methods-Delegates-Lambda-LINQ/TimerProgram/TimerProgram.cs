/* Using delegates write a class Timer that can execute certain method at each t seconds.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimerProgram
{
    class TimerProgram
    {
        public delegate void Delegate(string example);
        static Delegate delegateExample = Print;
        static Timer timer;
        static void Main(string[] args)
        {
            timer = new Timer(); // set timer for 3 seconds (3000 ms)
            timer.Interval = 3000;
            timer.Start();
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            Console.WriteLine("Wait a few seconds for the timer. :)");
            Console.ReadLine(); // There must be something in the main to start the countdown
            }
        public static void Print(string example)
        {
            Console.WriteLine(example);
        }
        static void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            delegateExample("This is an example for delegate called on every three seconds");
            timer.Interval = 3000; // I am making my own reset for the timer it's more
            timer.Start();        // convenient to use the timer.AutoReset property and
        }                        // enable it to true whwn you create the timer
    }
}
