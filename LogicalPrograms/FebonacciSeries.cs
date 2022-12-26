using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class FebonacciSeries
    {
        public static void Fibonacci(int n)
        {  //To Get Fibonacci Series
            int val1 = 0, val2 = 1, val3;
            Console.WriteLine("The Starting Point of Febonacci Series Are {0} And {1}",val1,val2+"\n");
            Console.Write(+val1 + " " + val2 + " ");
            for (int i = 2; i < n; i++)
            {
                val3 = val1 + val2;
                Console.Write(val3 + " ");
                val1 = val2;
                val2 = val3;
            }
        }
    }
}
