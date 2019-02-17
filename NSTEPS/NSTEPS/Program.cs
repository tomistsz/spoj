// NSTEPS - Number Steps
// https://www.spoj.com/problems/NSTEPS/
using System;

namespace NSTEPS
{
    public struct Point
    {
        public int x;
        public int y;
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Nsteps nsteps = new Nsteps();

            int t = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                Point point = new Point();
                point = GetData(Console.ReadLine());

                Console.WriteLine(nsteps.SolveNstepsProblem(point.x, point.y));
            }
        }

        public static Point GetData(string line)
        {
            Point point = new Point();
            char separator = ' ';
            string[] parameters = line.Split(separator);

            point.x = Int32.Parse(parameters[0]);
            point.y = Int32.Parse(parameters[1]);

            return point;
        }
    }
}
