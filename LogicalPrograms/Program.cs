namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome To Logical Programs\n");
            Console.WriteLine("\tChoose the program from the below option");
            Console.WriteLine("1] Factorial Numbers. \n2] PerfectNumber \n3] PrimeNumber \n4] Reverse A Number \n5] Coupon Numbers");
            Console.WriteLine("6] Stimulate Stop Watch \n7] Notes Vending Machine \n8] DayOfWeek \n9] Temperature Conversion \n10] Monthly Payment \n11] Square Root");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter a number to get Fibonacci Series");
                    int num = Convert.ToInt32(Console.ReadLine());
                    FebonacciSeries.Fibonacci(num);
                    break;

                case 2:
                    PerfectNumber.CheckPerfectNumber();
                    break;

                case 3:
                    PrimeNumber prime =  new PrimeNumber();
                    prime.ToCheckPrime();
                    break;

                case 4:
                    Console.WriteLine("\nEnter Number To Reverse It");
                    int n = Convert.ToInt32(Console.ReadLine());
                    ReverseANumber reverseA = new ReverseANumber();
                    reverseA.ToReverse(n);
                    break;

                case 5:
                    CouponNumber coupon = new CouponNumber();
                    coupon.DisplayCoupon();
                    break;

                case 6:
                    StimulateStopWatch.GetElapsedTime();
                    break;

                case 7:
                    NotesVendingMachine.GetNotes();
                    break;

                case 8:
                    DayofWeek.FindDayOfWeek();
                    break;

                case 9:
                    TemperatureConversion.ConvertTemp();
                    break;

                case 10:
                    MonthlyPayment.GetMonthlyPayment();
                    break;

                case 11:
                    Console.WriteLine("Enter a non negative number: ");
                    double c = Convert.ToDouble(Console.ReadLine());
                    double answer = SquareRoot.GetSqrtOfNonNegativeNum(c);
                    Console.WriteLine(answer);
                    break;

                default:
                    Console.WriteLine("Please enter Valid Option");
                    break;
            }
            Console.ReadLine();
        }
    }
}