using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class StimulateStopWatch
    {
        public static void GetElapsedTime()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            CouponNumber couponNumber = new CouponNumber();
            couponNumber.DisplayCoupon();
            stopwatch.Stop();
            Console.WriteLine("\n Elapsed time to get distinct coupons is: " + stopwatch.ElapsedMilliseconds);
        }
    }
}
