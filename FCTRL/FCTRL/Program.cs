// FCTRL - Factorial
// https://www.spoj.com/problems/FCTRL/
using System;

namespace FCTRL
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                long n = Int32.Parse(Console.ReadLine());
                long zerosCount = 0;


                while (n%5 != 0)
                {
                    n--;
                }

                long divider = 5;
                while (n / divider >= 1)
                {
                    divider = divider * divider;
                }

                while (divider >=5)
                {
                    long tempN = n;
                    zerosCount = zerosCount + tempN / divider;
                    divider = divider / 5;
                }

                Console.WriteLine(zerosCount);
            }
        }
    }
}