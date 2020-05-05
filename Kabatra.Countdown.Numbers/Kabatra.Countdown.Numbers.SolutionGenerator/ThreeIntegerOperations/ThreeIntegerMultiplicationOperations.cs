namespace Kabatra.Countdown.Numbers.SolutionGenerator.ThreeIntegerOperations
{
    /// <summary>
    ///     Handles all three number multiplication-based arithmetic operations.
    /// </summary>
    public partial class ThreeIntegerOperations
    {
        /// <summary>
        ///     Finds the product of three given numbers.
        /// </summary>
        /// <param name="multiplicand"></param>
        /// <param name="multiplierOne"></param>
        /// <param name="multiplierTwo"></param>
        /// <returns></returns>
        public static int Multiply(int multiplicand, int multiplierOne, int multiplierTwo)
        {
            return multiplicand * multiplierOne * multiplierTwo;
        }

        /// <summary>
        ///     Finds the product of two given numbers, then adds to the product by a given number.
        /// </summary>
        /// <param name="multiplicand"></param>
        /// <param name="multiplier"></param>
        /// <param name="addend"></param>
        /// <returns></returns>
        public static int MultiplyTwoIntegersThenAdd(int multiplicand, int multiplier, int addend)
        {
            return multiplicand * multiplier + addend;
        }

        /// <summary>
        ///     Finds the product of two given numbers, then divides the product by a given number.
        /// </summary>
        /// <param name="multiplicand"></param>
        /// <param name="multiplier"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        public static int MultiplyTwoIntegersThenDivide(int multiplicand, int multiplier, int divisor)
        {
            return multiplicand * multiplier / divisor;
        }

        /// <summary>
        ///     Finds the product of two given numbers, then subtracts from the product by a given number.
        /// </summary>
        /// <param name="multiplicand"></param>
        /// <param name="multiplier"></param>
        /// <param name="subtrahend"></param>
        /// <returns></returns>
        public static int MultiplyTwoIntegersThenSubtract(int multiplicand, int multiplier, int subtrahend)
        {
            return multiplicand * multiplier - subtrahend;
        }
    }
}
