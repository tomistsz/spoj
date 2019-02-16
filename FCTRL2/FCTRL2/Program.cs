// FCTRL2 - Small factorials
// https://www.spoj.com/problems/FCTRL2/
using System;
using System.Collections.Generic;

namespace FCTRL2
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int maxElementValue = (int)Math.Pow(10,3);
                List<int> resultList = new List<int>();

                int n = Int32.Parse(Console.ReadLine());
                resultList.Add(1);

                for (int j = 1; j <= n; j++)
                {
                    int overflow = 0;
                    for (int k = 0; k < resultList.Count; k++)
                    {
                        int partResult = resultList[k] * j + overflow;
                        if (partResult < maxElementValue)
                        {
                            resultList[k] = partResult;
                            overflow = 0;
                        }
                        else
                        {
                            resultList[k] = partResult % maxElementValue;
                            overflow = partResult / maxElementValue;
                        }
                    }
                    if (overflow > 0)
                    {
                        resultList.Add(overflow);
                    }

                }

                for (int z = resultList.Count - 1; z >= 0; z--)
                {
                    if (z == resultList.Count - 1)
                        Console.Write(resultList[z]);
                    else
                        Console.Write(String.Format("{0:000}", resultList[z]));
                }
                Console.WriteLine();

            }
        }
    }
}
