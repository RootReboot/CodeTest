using System;
using System.Collections.Generic;
using Xunit;

namespace Solution.Tests
{
    public class MaximumProductMultThree_Test
    {

        [Fact]
        public void CheckInputArrayHasLessThenTwoIntegers()
        {
            (int?, int?, int?, string, bool) expected = (null, null, null, "Array with less then 2 elements", false);

            int[] testArray = { 1 };

            Assert.Equal(expected, Solution.MaximumProductMultThree(testArray));
        }

        [Fact]
        public void CheckReturnWithoutAMultipleOfThree()
        {
            (int?, int?, int?, string, bool) expected = (null, null, null, "Array without a product that is a multiple of 3", false);

            int[] testArray = { 1, 4, 1, 5, 7 };

            Assert.Equal(expected, Solution.MaximumProductMultThree(testArray));
        }

        [Fact]
        public void CheckReturnWithoutAMultipleOfThreeWithOnly2ElementsInArray()
        {
            (int?, int?, int?, string, bool) expected = (null, null, null, "Array with 2 elements without a product that is a multiple of 3", false);

            int[] testArray = { 1, 4 };

            Assert.Equal(expected, Solution.MaximumProductMultThree(testArray));
        }

        [Fact]
        public void CheckIfReturnIsAProductOfANumberMultipliedByItself()
        {
            (int?, int?, int?, string, bool) expected = (6, 3, 2, null, false);

            int[] testArray = { 3, 1, 2 };

            Assert.Equal(expected, Solution.MaximumProductMultThree(testArray));
        }

        [Fact]
        public void CheckMaximumProductWhenThereIsOneProductMultipleOfThreeAndOneNotMultipleOfThree()
        {
            (int?, int?, int?, string, bool) expected = (48, 6, 8, null, false);

            int[] testArray = { 6, 8, 8, 7, 2, 5 };

            Assert.Equal(expected, Solution.MaximumProductMultThree(testArray));
        }

        [Fact]
        public void CheckMaximumProductWhenMoreThenOneIsMultipleOfThree()
        {
            (int?, int?, int?, string, bool) expected = (48, 6, 8, null, false);

            int[] testArray = { 6, 8, 8, 3, 6, 5 };

            Assert.Equal(expected, Solution.MaximumProductMultThree(testArray));
        }

        [Fact]
        public void CheckMultipliersWhenMoreThenOneCombinationAchievesTheMaximumProduct()
        {
            (int?, int?, int?, string, bool) expected = (18, 6, 3, null, true);

            int[] testArray = { 6, 3, -6, -3, 3, -1 };

            Assert.Equal(expected, Solution.MaximumProductMultThree(testArray));
        }
    }
}