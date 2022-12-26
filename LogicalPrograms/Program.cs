namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome To Logical Programs\n");
            Console.WriteLine("\tChoose the program from the below option");
            Console.WriteLine("1] Factorial Numbers.");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter a number to get Fibonacci Series");
                    int num = Convert.ToInt32(Console.ReadLine());
                    FebonacciSeries.Fibonacci(num);
                    break;

                default:
                    Console.WriteLine("Please enter Valid Option");
                    break;
            }
            Console.ReadLine();
        }
    }
}