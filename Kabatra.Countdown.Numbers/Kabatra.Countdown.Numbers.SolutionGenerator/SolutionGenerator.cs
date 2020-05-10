namespace Kabatra.Countdown.Numbers.SolutionGenerator
{
    using System.Collections.Generic;
    using System.Linq;
    using Operations;

    public class SolutionGenerator
    {
        public static IEnumerable<decimal> GetSolution(IEnumerable<int> userPickedNumbers, int cecilGeneratedNumber)
        {
            var generatedPossibleSolutions = GetTwoIntegerOperationsSolutions(userPickedNumbers);
            var successfulSolutions = GetListOfSuccessfulSolutions(generatedPossibleSolutions, cecilGeneratedNumber);
            
            return successfulSolutions;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="generatedPossibleSolutions"></param>
        /// <param name="targetNumber"></param>
        /// <remarks>Answer must be:
        ///     1. a whole number
        ///     2. not negative
        ///     3. either equals the target number or be no more or less than off by 10.</remarks>
        /// <returns></returns>
        private static IEnumerable<decimal> GetListOfSuccessfulSolutions(IEnumerable<decimal> generatedPossibleSolutions, int targetNumber)
        {
            return generatedPossibleSolutions.Where(solution => 
                (solution % 1) == 0
                && solution > 0
                && (
                    solution == targetNumber
                    || (
                        (targetNumber - solution) <= 10
                        && (targetNumber - solution) >= 0
                    )
                    || (
                        (solution - targetNumber) <= 10
                        && (solution - targetNumber) >= 0
                    )
                )
            ).ToList();
        }

        private static IEnumerable<decimal> GetTwoIntegerOperationsSolutions(IEnumerable<int> userPickedNumbers)
        {
            var generatedPossibleSolutions = new List<decimal>();
            var pickedNumbers = userPickedNumbers.ToList();

            generatedPossibleSolutions.AddRange(GetTwoIntegerOperationsSolutionsOrderDoesNotMatter(pickedNumbers));
            generatedPossibleSolutions.AddRange(GetTwoIntegerOperationsSolutionsOrderDoesMatter(pickedNumbers));

            return generatedPossibleSolutions;
        }

        private static IEnumerable<decimal> GetTwoIntegerOperationsSolutionsOrderDoesMatter(IReadOnlyList<int> userPickedNumbers)
        {
            var generatedPossibleSolutions = new List<decimal>();

            var userPickedNumbersOrderOne = userPickedNumbers.ToList();
            var userPickedNumbersOrderTwo = new List<int>
            {
                userPickedNumbers[1],
                userPickedNumbers[0]
            };

            var userPickedNumbersListInArrangedOrderList = new List<List<int>>
            {
                userPickedNumbersOrderOne,
                userPickedNumbersOrderTwo
            };

            foreach (var userPickedNumbersList in userPickedNumbersListInArrangedOrderList)
            {
                var numberOne = userPickedNumbersList[0];
                var numberTwo = userPickedNumbersList[1];

                //for (var index = 1; index <= userPickedNumbersList.Count(); index++)
                //{
                    var differenceOfNumberOneNumberTwo = TwoIntegerOperations.Subtract(numberOne, numberTwo);
                    var quotientOfNumberOneNumberTwo = TwoIntegerOperations.Divide(numberOne, numberTwo);

                    generatedPossibleSolutions.Add(differenceOfNumberOneNumberTwo);
                    generatedPossibleSolutions.Add(quotientOfNumberOneNumberTwo);
                //}
            }

            //ToDo: the loop is generating too much data, for two integers should return 4 operations, instead it is returning 8
            return generatedPossibleSolutions;
        }

        private static IEnumerable<decimal> GetTwoIntegerOperationsSolutionsOrderDoesNotMatter(IReadOnlyList<int> userPickedNumbers)
        {
            var generatedPossibleSolutions = new List<decimal>();

            var numberOne = userPickedNumbers[0];
            var numberTwo = userPickedNumbers[1];

            var sumOfNumberOneNumberTwo = TwoIntegerOperations.Add(numberOne, numberTwo);
            var productOfNumberOneNumberTwo = TwoIntegerOperations.Multiply(numberOne, numberTwo);

            generatedPossibleSolutions.Add(sumOfNumberOneNumberTwo);
            generatedPossibleSolutions.Add(productOfNumberOneNumberTwo);

            return generatedPossibleSolutions;
        }
    }
}
