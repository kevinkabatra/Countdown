namespace Kabatra.Countdown.Numbers.SolutionGenerator.ThreeIntegerOperations
{
    /// <summary>
    ///     Handles all three number addition-based arithmetic operations.
    /// </summary>
    public partial class ThreeIntegerOperations
    {
        /// <summary>
        ///     Finds the sum of three given numbers.
        /// </summary>
        /// <param name="addendOne"></param>
        /// <param name="addendTwo"></param>
        /// <param name="addendThree"></param>
        /// <returns></returns>
        public static int Add(int addendOne, int addendTwo, int addendThree)
        {
            return addendOne + addendTwo + addendThree;
        }

        /// <summary>
        ///     Finds the sum of two given numbers, then divides the sum by a given number.
        /// </summary>
        /// <param name="addendOne"></param>
        /// <param name="addendTwo"></param>
        /// <param name="dividend"></param>
        /// <returns></returns>
        public static int AddTwoIntegersThenDivide(int addendOne, int addendTwo, int dividend)
        {
            return (addendOne + addendTwo) / dividend;
        }

        /// <summary>
        ///     Finds the sum of two given numbers, then multiplies the sum by a given number.
        /// </summary>
        /// <param name="addendOne"></param>
        /// <param name="addendTwo"></param>
        /// <param name="multiplier"></param>
        /// <returns></returns>
        public static int AddTwoIntegersThenMultiply(int addendOne, int addendTwo, int multiplier)
        {
            return (addendOne + addendTwo) * multiplier;
        }

        /// <summary>
        ///     Finds the sum of two given numbers, then subtracts the sum by a given number.
        /// </summary>
        /// <param name="addendOne"></param>
        /// <param name="addendTwo"></param>
        /// <param name="subtrahend"></param>
        /// <returns></returns>
        public static int AddTwoIntegersThenSubtract(int addendOne, int addendTwo, int subtrahend)
        {
            return addendOne + addendTwo - subtrahend;
        }
    }
}
