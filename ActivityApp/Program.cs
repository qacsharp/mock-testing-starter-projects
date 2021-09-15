using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeDependencyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ActivityDecider decider = new ActivityDecider();

            string activity = decider.PickActivity();
            Console.WriteLine($"It's time to: {activity}");

            Console.WriteLine("Hit any key to exit...");
            Console.Read();
        }
    }
}
