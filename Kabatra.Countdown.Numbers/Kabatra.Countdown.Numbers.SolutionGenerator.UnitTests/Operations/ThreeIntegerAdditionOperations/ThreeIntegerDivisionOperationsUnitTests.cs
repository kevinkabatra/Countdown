namespace Kabatra.Countdown.Numbers.SolutionGenerator.UnitTests.Operations.ThreeIntegerAdditionOperations
{
    using Xunit;
    using ThreeIntegerOperations = Numbers.SolutionGenerator.Operations.ThreeIntegerOperations.ThreeIntegerOperations;

    public class ThreeIntegerDivisionOperationsUnitTests
    {
        [Fact]
        public void CanAdd()
        {
            const int divisor = 6;
            const int dividend = 2;
            const int addend = 1;
            const int expectedSum = 4;

            var actualSum = ThreeIntegerOperations.DivideTwoIntegersThenAdd(divisor, dividend, addend);

            Assert.Equal(expectedSum, actualSum);
        }

        [Fact]
        public void CanDivide()
        {
            const int divisor = 20;
            const int dividendOne = 10;
            const int dividendTwo = 2;
            const int expectedQuotient = 1;

            var actualQuotient = ThreeIntegerOperations.Divide(divisor, dividendOne, dividendTwo);

            Assert.Equal(expectedQuotient, actualQuotient);
        }

        [Fact]
        public void CanMultiply()
        {
            const int divisor = 6;
            const int dividend = 2;
            const int multiplier = 4;
            const int expectedProduct = 12;

            var actualProduct = ThreeIntegerOperations.DivideTwoIntegersThenMultiply(divisor, dividend, multiplier);

            Assert.Equal(expectedProduct, actualProduct);
        }

        [Fact]
        public void CanSubtract()
        {
            const int divisor = 10;
            const int dividend = 2;
            const int subtrahend = 4;
            const int expectedDifference = 1;

            var actualDifference = ThreeIntegerOperations.DivideTwoIntegersThenSubtract(divisor, dividend, subtrahend);

            Assert.Equal(expectedDifference, actualDifference);
        }
    }
}
