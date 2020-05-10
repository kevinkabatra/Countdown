namespace Kabatra.Countdown.Numbers.Game
{
    using Cecil;
    using SolutionGenerator;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var userGeneratedNumbers = new List<int>
            {
                1,
                3,
                //5,
                //10,
                //25,
                //100
            };

            var cecilGeneratedNumber = NumberGenerator.GetRandomNumber();
            DisplayStartTheClockMessage(userGeneratedNumbers, cecilGeneratedNumber);

            var possibleSolutions = SolutionGenerator.GetSolution(userGeneratedNumbers, cecilGeneratedNumber);
            DisplaySolutions(possibleSolutions);
        }

        private static void DisplayStartTheClockMessage(IEnumerable<int> userGeneratedNumbers, int cecilGeneratedNumber)
        {
            Console.WriteLine("Hello World and welcome to Countdown!");
            Console.WriteLine("The user has chosen: {0}.", string.Join(",", userGeneratedNumbers));
            Console.WriteLine("And the number is {0}.", cecilGeneratedNumber);
        }

        private static void DisplaySolutions(IEnumerable possibleSolutions)
        {
            var iteration = 1;
            foreach (var solution in possibleSolutions)
            {
                Console.WriteLine("Solution #{0}: {1}", iteration, solution);
                iteration++;
            }
        }
    }
}
