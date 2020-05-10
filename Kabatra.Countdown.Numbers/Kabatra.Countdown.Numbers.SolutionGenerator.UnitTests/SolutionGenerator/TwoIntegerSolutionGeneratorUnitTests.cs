namespace Kabatra.Countdown.Numbers.SolutionGenerator.UnitTests.SolutionGenerator
{
    using SolutionGenerator = Numbers.SolutionGenerator.SolutionGenerator;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    public class TwoIntegerSolutionGeneratorUnitTests
    {
        [Fact]
        public void CanFindMultipleSolution()
        {
            var userGeneratedNumbers = new List<int>
            {
                8,
                2
            };
            const int targetNumber = 11;
            const int expectedReturnedSolutions = 4;

            var generatedSolutions = SolutionGenerator.GetSolution(userGeneratedNumbers, targetNumber).ToList();
            Assert.Equal(expectedReturnedSolutions, generatedSolutions.Count);

            const int expectedSum = 10;
            Assert.Contains(expectedSum, generatedSolutions);

            const int expectedQuotient = 4;
            Assert.Contains(expectedQuotient, generatedSolutions);

            const int expectedProduct = 16;
            Assert.Contains(expectedProduct, generatedSolutions);

            const int expectedDifference = 6;
            Assert.Contains(expectedDifference, generatedSolutions);
        }

        [Fact]
        public void CanFindSingleAdditionSolution()
        {
            var userGeneratedNumbers = new List<int>
            {
                30,
                10
            };
            const int expectedSum = 40;

            var generatedSolutions = SolutionGenerator.GetSolution(userGeneratedNumbers, expectedSum).ToList();
            Assert.Single(generatedSolutions);

            var actualSum = generatedSolutions.First();
            Assert.Equal(expectedSum, actualSum);
        }

        [Fact]
        public void CanFindSingleDivisionSolution()
        {
            var userGeneratedNumbers = new List<int>
            {
                30,
                10
            };
            const int expectedQuotient = 3;

            var generatedSolutions = SolutionGenerator.GetSolution(userGeneratedNumbers, expectedQuotient).ToList();
            Assert.Single(generatedSolutions);

            var actualQuotient = generatedSolutions.First();
            Assert.Equal(expectedQuotient, actualQuotient);
        }

        [Fact]
        public void CanFindSingleMultiplicationSolution()
        {
            var userGeneratedNumbers = new List<int>
            {
                30,
                10
            };
            const int expectedProduct = 300;

            var generatedSolutions = SolutionGenerator.GetSolution(userGeneratedNumbers, expectedProduct).ToList();
            Assert.Single(generatedSolutions);

            var actualProduct = generatedSolutions.First();
            Assert.Equal(expectedProduct, actualProduct);
        }

        [Fact]
        public void CanFindSingleSubtractionSolution()
        {
            var userGeneratedNumbers = new List<int>
            {
                30,
                10
            };
            const int expectedDifference = 20;

            var generatedSolutions = SolutionGenerator.GetSolution(userGeneratedNumbers, expectedDifference).ToList();
            Assert.Single(generatedSolutions);

            var actualDifference = generatedSolutions.First();
            Assert.Equal(expectedDifference, actualDifference);
        }

        [Fact]
        public void CanFindSolutionWithinTenAdded()
        {
            var userGeneratedNumbers = new List<int>
            {
                30,
                10
            };
            const int targetNumber = 49;
            
            var generatedSolutions = SolutionGenerator.GetSolution(userGeneratedNumbers, targetNumber).ToList();
            Assert.Single(generatedSolutions);
        }

        [Fact]
        public void CanFindSolutionWithinTenSubtracted()
        {
            var userGeneratedNumbers = new List<int>
            {
                30,
                10
            };
            const int targetNumber = 31;

            var generatedSolutions = SolutionGenerator.GetSolution(userGeneratedNumbers, targetNumber).ToList();
            Assert.Single(generatedSolutions);
        }

        [Fact]
        public void CannotFindSolution()
        {
            var userGeneratedNumbers = new List<int>
            {
                1,
                2
            };

            const int impossibleSum = 100;
            
            Assert.Empty(SolutionGenerator.GetSolution(userGeneratedNumbers, impossibleSum));
        }
    }
}
