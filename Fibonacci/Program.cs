using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeq
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Whatever number you put in the parameter below, the Fibonacci method below will 
            ///provide you with the value within the sequence. ie: 1 results 1, 10 results 55
            Console.WriteLine(Fibonacci(10));
            Console.ReadKey();
        }

        /// <summary>
        /// Returns a number from the Fibonacci sequence, starting at 1
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static ulong Fibonacci(int number)
        {
            if (number == 1) { return 1; }
            if (number == 2) { return 1; }

            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }

    }
}
