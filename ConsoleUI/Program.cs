using ProblemLibrary;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Solution to Problem 1 is: { MultiplesOfThreeAndFive.GetSumOfMultiples()}" );
            Console.WriteLine($"Solution to Problem 2 is: { EvenFibonacciNumbers.GetAnswer()}");


            Console.ReadLine();
        }
    }
}
