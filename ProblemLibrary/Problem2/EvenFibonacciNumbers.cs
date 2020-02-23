using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemLibrary
{
    public static class EvenFibonacciNumbers
    {
        public static int GetAnswer()
        {
            return GetSumOfSequence(GenerateFibonacciSequence(4000000));

        }

        public static int GetSumOfSequence(List<int> sequence)
        {
            int output = 0;
            foreach (var val in sequence)
            {
                if (val<=4000000 && val % 2 == 0)
                {
                    output += val;
                }

            }
            return output;
        }
        public static List<int> GenerateFibonacciSequence(int max)
        {

            int a = 1;
            int b = 2;
            int temp = 2;
            List<int> output = new List<int>();
            output.Add(a);
            output.Add(b);

            while(temp<max)
            {
                temp = a + b;
                a = b;
                b = temp;
                output.Add(a + b);
            }
            return output;
        }
    }
}
