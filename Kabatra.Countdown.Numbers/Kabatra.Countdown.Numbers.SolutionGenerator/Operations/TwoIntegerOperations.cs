﻿namespace Kabatra.Countdown.Numbers.SolutionGenerator.Operations
{
    /// <summary>
    ///     Handles all two number arithmetic operations.
    /// </summary>
    public class TwoIntegerOperations
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
        public static decimal Divide(int divisor, int dividend)
        {
            return decimal.Divide(divisor, dividend);
        }
    }
}
