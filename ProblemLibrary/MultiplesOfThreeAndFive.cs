using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemLibrary
{
    //Given a list of all natural numbers from 1000
    //Find sum of all multiples of 3 or 5 below 1000
    //Example:
    //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

    public static class MultiplesOfThreeAndFive
    {
        private static List<int> _zeroToThousand = new List<int>();
        private static List<int> _multiplesOfThreeOrFive = new List<int>();
               
        private static List<int> ZeroToThousand { get => GetZeroToThousand(); }
        private static List<int> MultiplesOfThreeOrFive { get => GetListOfMultiplesOfThreeOrFive(); }



        private static List<int> GetZeroToThousand()
        {
            List<int> output = new List<int>();

            for (int i = 0; i < 1001; i++)
            {
                output.Add(i);
            }
            return output;
        }

        private static List<int> GetListOfMultiplesOfThreeOrFive()
        {
            List<int> output = new List<int>();

            foreach (var integer in ZeroToThousand)
            {
                if (integer % 3 == 0 || integer % 5 == 0)
                {
                    output.Add(integer);
                }
            }
            return output;
        }

        public static int GetSumOfMultiples()
        {
            int output = 0;
            foreach (var val in MultiplesOfThreeOrFive)
            {
                output += val;
            }
            return output;
        }

    }
}
