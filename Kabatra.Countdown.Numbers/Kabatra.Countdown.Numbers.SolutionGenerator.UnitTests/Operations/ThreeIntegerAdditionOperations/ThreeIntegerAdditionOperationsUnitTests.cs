namespace Kabatra.Countdown.Numbers.SolutionGenerator.UnitTests.Operations.ThreeIntegerAdditionOperations
{
    using Xunit;
    using ThreeIntegerOperations = Numbers.SolutionGenerator.Operations.ThreeIntegerOperations.ThreeIntegerOperations;

    public class ThreeIntegerAdditionOperationsUnitTests
    {
        [Fact]
        public void CanAdd()
        {
            const int addendOne = 1;
            const int addendTwo = 2;
            const int addendThree = 3;
            const int expectedSum = 6;

            var actualSum = ThreeIntegerOperations.Add(addendOne, addendTwo, addendThree);

            Assert.Equal(expectedSum, actualSum);
        }

        [Fact]
        public void CanDivide()
        {
            const int addendOne = 2;
            const int addendTwo = 4;
            const int dividend = 2;
            const int expectedQuotient = 3;

            var actualQuotient = ThreeIntegerOperations.AddTwoIntegersThenDivide(addendOne, addendTwo, dividend);

            Assert.Equal(expectedQuotient, actualQuotient);
        }

        [Fact]
        public void CanMultiply()
        {
            const int addendOne = 1;
            const int addendTwo = 2;
            const int multiplier = 3;
            const int expectedProduct = 9;

            var actualProduct = ThreeIntegerOperations.AddTwoIntegersThenMultiply(addendOne, addendTwo, multiplier);

            Assert.Equal(expectedProduct, actualProduct);
        }

        [Fact]
        public void CanSubtract()
        {
            const int addendOne = 1;
            const int addendTwo = 2;
            const int subtrahend = 2;
            const int expectedDifference = 1;

            var actualDifference = ThreeIntegerOperations.AddTwoIntegersThenSubtract(addendOne, addendTwo, subtrahend);

            Assert.Equal(expectedDifference, actualDifference);
        }
    }
}