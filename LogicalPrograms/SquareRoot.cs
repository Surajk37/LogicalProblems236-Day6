using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class SquareRoot
    {
        public static double GetSqrtOfNonNegativeNum(double c)
        {
            double epsilon = 1e-15, t, sqRt;

            if (c < 0)
            {
                Console.WriteLine("Number should be Non negative ");
                return 0;
            }
            else
            {
                t = c;
                while (Math.Abs(t - c / t) > epsilon * t)
                {
                    t = (c / t + t) / 2;
                }
                sqRt = Math.Round(t, 2);
                return sqRt;
            }

        }
    }
}
