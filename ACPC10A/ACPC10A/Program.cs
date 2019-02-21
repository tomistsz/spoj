using System;

namespace ACPC10A
{
    class Program
    {
        static void Main(string[] args)
        {
            ACPC10A acpc10a = new ACPC10A();

            string inputLine = Console.ReadLine();
            while (inputLine != "0 0 0")
            {
                string result = "";
                string[] inputLineArr = inputLine.Split(' ');
                int a = Int32.Parse(inputLineArr[0]);
                int b = Int32.Parse(inputLineArr[1]);
                int c = Int32.Parse(inputLineArr[2]);
                result = acpc10a.SolveAcpc10a(a, b, c);

                Console.WriteLine(result);
                inputLine = Console.ReadLine();
            }
        }
    }
}
