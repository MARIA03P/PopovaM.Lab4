using System;

namespace Popova.Lab4.Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите переменную n");
            int n = Convert.ToInt32(Console.ReadLine());

            double r = MultiRec(n);

            Console.WriteLine($"R = {r}");
        }
        static double MultiRec(int n)
        { double func= (n - 11) / 3.0 ;
            if (n == 11)
            {
                return 1;
            }
            else
            {
                return func * MultiRec(n - 1);
            }
        }
    }
}
