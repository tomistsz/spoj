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
                int n = Int32.Parse(Console.ReadLine());
                int zerosCount = 0;

                for (int j = 1; j <= n; j++)
                {
                    int tempJ = j;
                    while (tempJ % 5 == 0)
                    {
                        tempJ = tempJ / 5;
                        zerosCount++;
                    }

                }

                Console.WriteLine(zerosCount);
                // odejmuj do liczby podzielnej przez 5
                // dziel j / 5 tak długo > 0, % + % .... = wynik
            }
        }
    }
}