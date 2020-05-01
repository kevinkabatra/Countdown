using Xunit;

namespace Kabatra.Countdown.Numbers.SolutionGenerator.UnitTests
{
    public class TwoDigitOperationsTests
    {
        [Fact]
        public void CanAdd()
        {
            int addendOne = 1;
            int addendTwo = 2;
            int expectedSum = 3;

            int actualSum = TwoDigitOperations.Add(addendOne, addendTwo);

            Assert.Equal(expectedSum, actualSum);
        }

        [Fact]
        public void CanSubtract()
        {
            int minuend = 3;
            int subtrahend = 2;
            int expectedDifference = 1;

            int actualDifference = TwoDigitOperations.Subtract(minuend, subtrahend);

            Assert.Equal(expectedDifference, actualDifference);
        }

        [Fact]
        public void CanMultiply()
        {
            int multiplicand = 2;
            int multiplier = 3;
            int expectedProduct = 6;

            int actualProduct = TwoDigitOperations.Multiply(multiplicand, multiplier);

            Assert.Equal(expectedProduct, actualProduct);
        }

        [Fact]
        public void CanDivide()
        {
            int divisor = 6;
            int dividend = 2;
            int expectedQuotient = 3;

            int actualQuotient = TwoDigitOperations.Divide(divisor, dividend);

            Assert.Equal(expectedQuotient, actualQuotient);
        }
    }
}
