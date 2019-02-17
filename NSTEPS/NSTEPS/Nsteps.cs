using System;
using System.Collections.Generic;
using System.Text;

namespace NSTEPS
{
    public class Nsteps
    {

        public string SolveNstepsProblem(int x, int y)
        {
            string result = "";

            if (x==y || x-y==2)
            {
                if (x % 2 == 0)
                    result = (x + y).ToString();
                else
                    result = (x + y - 1).ToString();

            }
            else
            {
                result = "No Number";
            }

            return result;
        }

    }
}
