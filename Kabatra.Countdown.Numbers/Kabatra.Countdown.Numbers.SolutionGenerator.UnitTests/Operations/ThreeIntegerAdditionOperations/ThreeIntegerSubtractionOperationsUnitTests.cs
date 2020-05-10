namespace Kabatra.Countdown.Numbers.SolutionGenerator.UnitTests.Operations.ThreeIntegerAdditionOperations
{
    using Xunit;
    using ThreeIntegerOperations = Numbers.SolutionGenerator.Operations.ThreeIntegerOperations.ThreeIntegerOperations;

    public class ThreeIntegerSubtractionOperationsUnitTests
    {
        [Fact]
        public void CanAdd()
        {
            const int minuend = 4;
            const int subtrahend = 3;
            const int addend = 1;
            const int expectedSum = 2;

            var actualSum = ThreeIntegerOperations.SubtractTwoIntegersThenAdd(minuend, subtrahend, addend);

            Assert.Equal(expectedSum, actualSum);
        }

        [Fact]
        public void CanDivide()
        {
            const int minuend = 11;
            const int subtrahend = 5;
            const int dividend = 2;
            const int expectedQuotient = 3;

            var actualQuotient = ThreeIntegerOperations.SubtractTwoIntegersThenDivide(minuend, subtrahend, dividend);

            Assert.Equal(expectedQuotient, actualQuotient);
        }

        [Fact]
        public void CanMultiply()
        {
            const int minuend = 4;
            const int subtrahend = 1;
            const int multiplier = 3;
            const int expectedProduct = 9;

            var actualProduct = ThreeIntegerOperations.SubtractTwoIntegersThenMultiply(minuend, subtrahend, multiplier);

            Assert.Equal(expectedProduct, actualProduct);
        }

        [Fact]
        public void CanSubtract()
        {
            const int minuend = 6;
            const int subtrahendOne = 3;
            const int subtrahendTwo = 2;
            const int expectedDifference = 1;

            var actualDifference = ThreeIntegerOperations.Subtract(minuend, subtrahendOne, subtrahendTwo);

            Assert.Equal(expectedDifference, actualDifference);
        }
    }
}
