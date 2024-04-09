using System;

namespace INCREDIBLE_Fibonacci_Number_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n\n> ");
            int n = Convert.ToInt32(Console.ReadLine());

            Fib(n - 1);
        }

        static long Fib(long n)
        {
            if (n == 0) return 0;

            int prev = 0;
            int next = 1;
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(prev);

                int sum = prev + next;
                prev = next;
                next = sum;
            }
            Console.WriteLine(next);

            return next;
        }
    }
}