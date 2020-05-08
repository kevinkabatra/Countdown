namespace Kabatra.Countdown.Numbers.SolutionGenerator.UnitTests.Operations
{
    using Numbers.SolutionGenerator.Operations;
    using Xunit;

    public class TwoIntegerOperationsTests
    {
        [Fact]
        public void CanAdd()
        {
            const int addendOne = 1;
            const int addendTwo = 2;
            const int expectedSum = 3;

            var actualSum = TwoIntegerOperations.Add(addendOne, addendTwo);

            Assert.Equal(expectedSum, actualSum);
        }

        [Fact]
        public void CanSubtract()
        {
            const int minuend = 3;
            const int subtrahend = 2;
            const int expectedDifference = 1;

            var actualDifference = TwoIntegerOperations.Subtract(minuend, subtrahend);

            Assert.Equal(expectedDifference, actualDifference);
        }

        [Fact]
        public void CanMultiply()
        {
            const int multiplicand = 2;
            const int multiplier = 3;
            const int expectedProduct = 6;

            var actualProduct = TwoIntegerOperations.Multiply(multiplicand, multiplier);

            Assert.Equal(expectedProduct, actualProduct);
        }

        [Fact]
        public void CanDivide()
        {
            const int divisor = 6;
            const int dividend = 2;
            const int expectedQuotient = 3;

            var actualQuotient = TwoIntegerOperations.Divide(divisor, dividend);

            Assert.Equal(expectedQuotient, actualQuotient);
        }
    }
}
