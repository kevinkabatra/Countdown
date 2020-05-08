namespace Kabatra.Countdown.Numbers.SolutionGenerator.Operations.ThreeIntegerOperations
{
    /// <summary>
    ///     Handles all three number division-based arithmetic operations.
    /// </summary>
    public partial class ThreeIntegerOperations
    {
        /// <summary>
        ///     Finds the quotient of three given numbers.
        /// </summary>
        /// <param name="divisor"></param>
        /// <param name="dividendOne"></param>
        /// <param name="dividendTwo"></param>
        /// <returns></returns>
        public static int Divide(int divisor, int dividendOne, int dividendTwo)
        {
            return divisor / dividendOne / dividendTwo;
        }

        /// <summary>
        ///     Finds the quotient of two given numbers, then adds to the quotient by a given number.
        /// </summary>
        /// <param name="divisor"></param>
        /// <param name="dividend"></param>
        /// <param name="addend"></param>
        /// <returns></returns>
        public static int DivideTwoIntegersThenAdd(int divisor, int dividend, int addend)
        {
            return divisor / dividend + addend;
        }

        /// <summary>
        ///     Finds the quotient of two given numbers, then multiplies the quotient by a given number.
        /// </summary>
        /// <param name="divisor"></param>
        /// <param name="dividend"></param>
        /// <param name="multiplier"></param>
        /// <returns></returns>
        public static int DivideTwoIntegersThenMultiply(int divisor, int dividend, int multiplier)
        {
            return (divisor / dividend) * multiplier;
        }

        /// <summary>
        ///     Finds the quotient of two given numbers, then subtracts from the quotient by a given number.
        /// </summary>
        /// <param name="divisor"></param>
        /// <param name="dividend"></param>
        /// <param name="subtrahend"></param>
        /// <returns></returns>
        public static int DivideTwoIntegersThenSubtract(int divisor, int dividend, int subtrahend)
        {
            return divisor / dividend - subtrahend;
        }
    }
}
