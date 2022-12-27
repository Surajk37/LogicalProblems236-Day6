namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome To Logical Programs\n");
            Console.WriteLine("\tChoose the program from the below option");
            Console.WriteLine("1] Factorial Numbers. \n2] PerfectNumber \n3] PrimeNumber \n4] Reverse A Number \n5] Coupon Numbers");
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
               
                default:
                    Console.WriteLine("Please enter Valid Option");
                    break;
            }
            Console.ReadLine();
        }
    }
}