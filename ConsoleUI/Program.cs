using ProblemLibrary;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"Solution to Problem 1 is: { MultiplesOfThreeAndFive.GetSumOfMultiples()}" );
            //Console.WriteLine($"Solution to Problem 2 is: { EvenFibonacciNumbers.GetAnswer()}");
            //Console.WriteLine(LargestPrimeFactor.Solution());

            DateTime startTime = DateTime.Now;
            
            //Insert problem here:
            
            Console.WriteLine($"The operation took {(DateTime.Now -startTime).TotalMilliseconds} ms.");

            Console.ReadLine();
        }
    }
}
