namespace Kabatra.Countdown.Numbers.SolutionGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Operations;

    public class SolutionGenerator
    {
        public static IEnumerable<int> GetSolution(IEnumerable<int> userPickedNumbers, int cecilGeneratedNumber)
        {
            var generatedPossibleSolutions = GetTwoIntegerOperationsSolutions(userPickedNumbers);
            var successfulSolutions = GetListOfSuccessfulSolutions(generatedPossibleSolutions, cecilGeneratedNumber);
            
            return successfulSolutions;
        }

        private static IEnumerable<int> GetListOfSuccessfulSolutions(IEnumerable<int> generatedPossibleSolutions, int cecilGeneratedNumber)
        {
            //ToDo: Determine if solution equals or is off by 10 when compared to CECIL's number.
            return generatedPossibleSolutions;
        }

        private static IEnumerable<int> GetTwoIntegerOperationsSolutions(IEnumerable<int> userPickedNumbers)
        {
            var generatedPossibleSolutions = new List<int>();
            var pickedNumbers = userPickedNumbers.ToList();

            generatedPossibleSolutions.AddRange(GetTwoIntegerOperationsSolutionsOrderDoesNotMatter(pickedNumbers));
            generatedPossibleSolutions.AddRange(GetTwoIntegerOperationsSolutionsOrderDoesMatter(pickedNumbers));

            return generatedPossibleSolutions;
        }

        private static IEnumerable<int> GetTwoIntegerOperationsSolutionsOrderDoesMatter(IReadOnlyList<int> userPickedNumbers)
        {
            var generatedPossibleSolutions = new List<int>();

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

                for (var index = 1; index <= userPickedNumbersList.Count(); index++)
                {
                    var differenceOfNumberOneNumberTwo = TwoIntegerOperations.Subtract(numberOne, numberTwo);
                    var quotientOfNumberOneNumberTwo = TwoIntegerOperations.Divide(numberOne, numberTwo);

                    generatedPossibleSolutions.Add(differenceOfNumberOneNumberTwo);
                    generatedPossibleSolutions.Add(quotientOfNumberOneNumberTwo);
                }
            }

            //ToDo: the loop is generating too much data, for two integers should return 4 operations, instead it is returning 8
            return generatedPossibleSolutions;
        }

        private static IEnumerable<int> GetTwoIntegerOperationsSolutionsOrderDoesNotMatter(IReadOnlyList<int> userPickedNumbers)
        {
            var generatedPossibleSolutions = new List<int>();

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
