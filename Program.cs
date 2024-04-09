using System;

namespace INCREDIBLE_Fibonacci_Number_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n\n> ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Вывод: {Fib(n)}");
        }

        static long Fib(long n)
        {
            if (n <= 1)
            {
                return n;
            }

            return Fib(n - 1) + Fib(n - 2);
        }
    }
}