using System;

namespace Popova.Lab4.Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите переменную n");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"f(n) = {Func(n)}");

        }

        static double Func(int n)
        {
            if (n < 1)
                return 0;

            return ((3 * Math.Sqrt(n)) / 2) + Func(n - 1);

            Console.WriteLine($"f(n) = {Func(n)}");
        }
    }
}
