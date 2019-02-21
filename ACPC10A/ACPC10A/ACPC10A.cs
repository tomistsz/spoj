using System;
using System.Collections.Generic;
using System.Text;

namespace ACPC10A
{
    public class ACPC10A
    {
        public string SolveAcpc10a(int a, int b, int c)
        {
            string result = "";
            
            if(b-a == c-b)
            {
                result = "AP " + (c + (b - a)).ToString();
            }
            else
            {
                result = "GP " + (c * (b / a)).ToString();
            }

            return result;
        }
    }
}
