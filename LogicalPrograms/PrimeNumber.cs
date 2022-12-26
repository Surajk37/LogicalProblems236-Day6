using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public void ToCheckPrime()
        {
            int n, count = 0;
            Console.WriteLine("Enter a Number to Check Prime or Not");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("{0} is a Prime Number", n);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }

        }
    }
}
