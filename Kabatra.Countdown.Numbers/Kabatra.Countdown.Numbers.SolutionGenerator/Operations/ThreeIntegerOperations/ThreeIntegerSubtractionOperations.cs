namespace Kabatra.Countdown.Numbers.SolutionGenerator.Operations.ThreeIntegerOperations
{
    /// <summary>
    ///     Handles all three number subtraction-based arithmetic operations.
    /// </summary>
    public partial class ThreeIntegerOperations
    {
        /// <summary>
        ///     Finds the difference of three given numbers.
        /// </summary>
        /// <param name="minuend"></param>
        /// <param name="subtrahendOne"></param>
        /// <param name="subtrahendTwo"></param>
        /// <returns></returns>
        public static int Subtract(int minuend, int subtrahendOne, int subtrahendTwo)
        {
            return minuend - subtrahendOne - subtrahendTwo;
        }

        /// <summary>
        ///     Finds the difference of two given numbers, then adds to the difference by a given number.
        /// </summary>
        /// <param name="minuend"></param>
        /// <param name="subtrahend"></param>
        /// <param name="addend"></param>
        /// <returns></returns>
        public static int SubtractTwoIntegersThenAdd(int minuend, int subtrahend, int addend)
        {
            return minuend - subtrahend + addend;
        }

        /// <summary>
        ///     Finds the difference of two given numbers, then divides the difference by a given number.
        /// </summary>
        /// <param name="minuend"></param>
        /// <param name="subtrahend"></param>
        /// <param name="dividend"></param>
        /// <returns></returns>
        public static int SubtractTwoIntegersThenDivide(int minuend, int subtrahend, int dividend)
        {
            return (minuend - subtrahend) / dividend;
        }

        /// <summary>
        ///     Finds the difference of two given numbers, then multiplies the difference by a given number.
        /// </summary>
        /// <param name="minuend"></param>
        /// <param name="subtrahend"></param>
        /// <param name="multiplier"></param>
        /// <returns></returns>
        public static int SubtractTwoIntegersThenMultiply(int minuend, int subtrahend, int multiplier)
        {
            return (minuend - subtrahend) * multiplier;
        }
    }
}
