// ONP - Transform the Expression
// https://www.spoj.com/problems/ONP/

using System;

namespace ONP
{
    class Program
    {
        static void Main(string[] args)
        {
            Onp Onp = new Onp();
            int t = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string result = Onp.ConvertToOnp(Console.ReadLine());
                Console.WriteLine(result);
            }
        }
    }
}
