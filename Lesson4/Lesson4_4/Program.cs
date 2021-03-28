using System;

namespace Lesson4_4
{
    /*
        Написать программу, вычисляющую число Фибоначчи для заданного значения
        рекурсивным способом.
    */
    class Program
    {
        private static ulong Fibonacci(ulong n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            ulong n = Convert.ToUInt64(Console.ReadLine());

            ulong f = Fibonacci(n);
            Console.WriteLine($"F({n}) = {f}");

            for (ulong i = 0; i <= n; i++)
            {
                Console.Write($"{Fibonacci(i)} ");
            }
            Console.WriteLine();
        }
    }
}
