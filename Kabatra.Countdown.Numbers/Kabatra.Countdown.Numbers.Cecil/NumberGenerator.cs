namespace Kabatra.Countdown.Numbers.Cecil
{
    /// <summary>
    ///     CECIL, Countdowns Electronic Calculator in Leeds, is a random number generator used to set three-digit target numbers for
    ///     number rounds on Countdown.
    /// </summary>
    /// <seealso cref="http://wiki.apterous.org/CECIL"/>
    public class NumberGenerator
    {
        /// <summary>
        ///     Generates a random number and returns it.
        /// </summary>
        /// <param name="maximumNumber">The maximum value that can be generated.</param>
        /// <param name="minimumNumber">The minimum value that can be generated.</param>
        /// <returns>Int. Representing the number that is generated.</returns>
        public static int GetRandomNumber(int maximumNumber = 999, int minimumNumber = 100)
        {
            var randomGenerator = new System.Random();
            var randomNumber = randomGenerator.Next(minimumNumber, maximumNumber);

            return randomNumber;
        }
    }
}
