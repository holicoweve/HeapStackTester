using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapStackTester
{
    class Program
    {
        static void Main(string[] args)
        {
            const int repeat = 100000000;
            TimeSpan stackInterval, heapInterval;

            Console.WriteLine("Press any key to start...");
            Console.ReadKey();

            DateTime startTime = DateTime.Now;
            Console.WriteLine("\nCurrent Time: {0}", startTime.ToLongTimeString());
            Console.WriteLine("Testing Stack");
            StackTest(repeat);
            stackInterval = DateTime.Now - startTime;
            Console.WriteLine("Time Spent {0} miliseconds.\n", stackInterval.TotalMilliseconds.ToString());

            startTime = DateTime.Now;
            Console.WriteLine("Testing Heap");
            HeapTest(repeat);
            heapInterval = DateTime.Now - startTime;
            Console.WriteLine("Time Spent {0} miliseconds.\n", heapInterval.TotalMilliseconds.ToString());

            Console.WriteLine("Stack takes {0}% of Heap's time.\n",  Math.Round(100*stackInterval.TotalMilliseconds / heapInterval.TotalMilliseconds,2).ToString());
            // Exit gracefully
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        static void StackTest(int repeat)
        {
            for (int count = 0; count <= repeat; count++)
            {
                int i = 4;
                int j = i;
            }
        }

        static void HeapTest(int repeat)
        {
            for (int count = 0; count <= repeat; count++)
            {
                int i = 4;
                object o = i;
            }
        }
    }
}
