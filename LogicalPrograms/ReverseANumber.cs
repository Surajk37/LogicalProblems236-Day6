using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseANumber
    {
        public void ToReverse(int n)
        {
            int reminder,reverse = 0;

            while(n > 0)
            {
                reminder = n % 10;
                reverse = (reverse * 10) + reminder;
                n = n / 10;
            }
              Console.WriteLine(reverse+  " Is Reversed Number");
        }
    }
}
