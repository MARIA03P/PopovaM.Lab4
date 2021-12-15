using System;

namespace Popova.Lab4.Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter x and y :");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            double z = Compare(x, y);
            double z1 = Compare('4', '6');
            Console.WriteLine(z);
        }
        static double Compare(int x, int y)
        {
            double a = Math.Pow(x, 2) + 3;
            double b = y / 5 + 1 / 3;
            return a > b ? a : b;



        }
        static double Compare(char x, char y)
        {
            double a = Math.Pow(x, 2) + 3;
            double b = y / 5 + 1 / 3;
            return a > b ? a : b;
        }
    }
}
