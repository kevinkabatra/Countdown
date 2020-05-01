namespace Kabatra.Countdown.Numbers.SolutionGenerator
{
    /// <summary>
    ///     Handles all two digit arithmatic operations.
    /// </summary>
    public class TwoDigitOperations
    {
        /// <summary>
        ///     Finds the sum of two given numbers.
        /// </summary>
        /// <param name="addendOne"></param>
        /// <param name="addendTwo"></param>
        /// <returns></returns>
        public static int Add(int addendOne, int addendTwo)
        {
            return addendOne + addendTwo;
        }

        /// <summary>
        ///     Finds the difference of two given numbers.
        /// </summary>
        /// <param name="minuend"></param>
        /// <param name="subtrahend"></param>
        /// <returns></returns>
        public static int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        /// <summary>
        ///     Finds the product of two given numbers.
        /// </summary>
        /// <param name="multiplicand"></param>
        /// <param name="multiplier"></param>
        /// <returns></returns>
        public static int Multiply(int multiplicand, int multiplier)
        {
            return multiplicand * multiplier;
        }

        /// <summary>
        ///     Finds the quotient of two given numbers. 
        /// </summary>
        /// <param name="divisor"></param>
        /// <param name="dividend"></param>
        /// <returns></returns>
        public static int Divide(int divisor, int dividend)
        {
            return divisor / dividend;
        }
    }
}
