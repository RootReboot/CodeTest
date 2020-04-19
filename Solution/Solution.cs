using System;
using System.Collections.Generic;

namespace Solution
{
    public class Solution
    {

        /// <summary>
        /// Calculates the maximum product multiple of three between two numbers from the input array.
        /// </summary>
        public static (int? product, int? multiplier1, int? multiplier2, string error, bool multipleSolutions) MaximumProductMultThree(int[] array)
        {
            if (CheckArrayLength(array))
            {
                return (null, null, null, "Array with less then 2 elements", false);
            }

            if (array.Length == 2)
            {
                if (!CheckArrayElementsWhenLengthEqualsTwo(array))
                {
                    return (null, null, null, "Array with 2 elements without a product that is a multiple of 3", false);
                }
                else
                {
                    return (array[0] * array[1], array[0], array[1], null, false);
                }
            }

            return TraverseArray(array);
        }

        /// <summary>
        /// Algorithm to traverse the array and find the maximum product multiple of three between two numbers from the input array. 
        /// Finds the maximum positive multipliers(one is multiple of 3) and maximum negative multipliers(one is multiple of 3), and then in the CalculateProduct method checks,
        /// who has the bigger product, the positives or the negatives.
        /// </summary>
        private static (int? product, int? multiplier1, int? multiplier2, string error, bool multipleSolutions) TraverseArray(int[] array)
        {
            int positiveMultiplierDivThree = int.MinValue;
            int positiveMultiplier = int.MinValue;

            int negativeMultiplierDivThree = 0;
            int negativeMultiplier = 0;

            foreach (int number in array)
            {
                if (CheckIfNumberIsMultipleOfThree(number) && number > positiveMultiplierDivThree)
                {
                    positiveMultiplierDivThree = number;
                }
                else if (number > positiveMultiplier)
                {
                    positiveMultiplier = number;
                }


                if (number < 0)
                {
                    if (CheckIfNumberIsMultipleOfThree(number) && number < negativeMultiplierDivThree)
                    {
                        negativeMultiplierDivThree = number;
                    }
                    else if (number < negativeMultiplier)
                    {
                        negativeMultiplier = number;
                    }
                }
            }
            return CalculateProduct(positiveMultiplierDivThree, positiveMultiplier, negativeMultiplierDivThree, negativeMultiplier);
        }

        private static (int? product, int? multiplier1, int? multiplier2, string error, bool multipleSolutions) CalculateProduct(int positiveMultiplierDivThree, int positiveMultiplier, int negativeMultiplierDivThree, int negativeMultiplier)
        {
            if (!CheckIfNumberIsMultipleOfThree(positiveMultiplierDivThree) || !CheckIfNumberIsMultipleOfThree(negativeMultiplierDivThree))
            {
                return (null, null, null, "Array without a product that is a multiple of 3", false);
            }

            int mult1 = positiveMultiplierDivThree * positiveMultiplier;
            int mult2 = negativeMultiplierDivThree * negativeMultiplier;

            if (mult1 > mult2)
            {
                return (mult1, positiveMultiplierDivThree, positiveMultiplier, null, false);
            }
            else if (mult1 == mult2)
            {
                return (mult1, positiveMultiplierDivThree, positiveMultiplier, null, true);
            }
            else
            {
                return (mult2, negativeMultiplierDivThree, negativeMultiplier, null, false);
            }


        }

        private static bool CheckArrayLength(int[] array)
        {
            int arrayLength = array.Length;

            return arrayLength < 2 ? true : false;
        }

        private static bool CheckArrayElementsWhenLengthEqualsTwo(int[] array)
        {
            return (array.Length == 2 && (CheckIfNumberIsMultipleOfThree(array[0]) || CheckIfNumberIsMultipleOfThree(array[1]))) ? true : false;

        }

        private static bool CheckIfNumberIsMultipleOfThree(int number)
        {
            return number % 3 == 0 ? true : false;
        }
    }
}
