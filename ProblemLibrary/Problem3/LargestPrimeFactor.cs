using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemLibrary
{
    public static class LargestPrimeFactor
    {
        private static long numberToSolve = 600851475143;
        public static long Solution()
        {
            long testNumber = numberToSolve;
            long highestPrime = 0;
            long counter = 1;
            long remains = testNumber;

            for (long i = 0; i < testNumber; i++)
            {
               
                if (counter > remains) return highestPrime;
                if (remains % counter == 0)
                {
                    remains /= counter;
                    highestPrime = counter;
                    counter = 2;
                }
                else
                {
                    counter++;
                }
                
            }
            return highestPrime;
        }
    }
}
