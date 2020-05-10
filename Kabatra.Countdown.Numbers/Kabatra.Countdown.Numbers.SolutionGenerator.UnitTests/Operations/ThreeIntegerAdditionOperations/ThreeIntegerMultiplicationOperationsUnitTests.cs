namespace Kabatra.Countdown.Numbers.SolutionGenerator.UnitTests.Operations.ThreeIntegerAdditionOperations
{
    using Xunit;
    using ThreeIntegerOperations = Numbers.SolutionGenerator.Operations.ThreeIntegerOperations.ThreeIntegerOperations;

    public class ThreeIntegerMultiplicationOperationsUnitTests
    {
        [Fact]
        public void CanAdd()
        {
            const int multiplicand = 2;
            const int multiplier = 3;
            const int addend = 1;
            const int expectedSum = 7;

            var actualSum = ThreeIntegerOperations.MultiplyTwoIntegersThenAdd(multiplicand, multiplier, addend);

            Assert.Equal(expectedSum, actualSum);
        }

        [Fact]
        public void CanDivide()
        {
            const int multiplicand = 2;
            const int multiplier = 3;
            const int dividend = 6;
            const int expectedQuotient = 1;

            var actualQuotient = ThreeIntegerOperations.MultiplyTwoIntegersThenDivide(multiplicand, multiplier, dividend);

            Assert.Equal(expectedQuotient, actualQuotient);
        }

        [Fact]
        public void CanMultiply()
        {
            const int multiplicand = 2;
            const int multiplierOne = 3;
            const int multiplierTwo = 4;
            const int expectedProduct = 24;

            var actualProduct = ThreeIntegerOperations.Multiply(multiplicand, multiplierOne, multiplierTwo);

            Assert.Equal(expectedProduct, actualProduct);
        }

        [Fact]
        public void CanSubtract()
        {
            const int multiplicand = 2;
            const int multiplier = 3;
            const int subtrahend = 1;
            const int expectedDifference = 5;

            var actualDifference = ThreeIntegerOperations.MultiplyTwoIntegersThenSubtract(multiplicand, multiplier, subtrahend);

            Assert.Equal(expectedDifference, actualDifference);
        }
    }
}
