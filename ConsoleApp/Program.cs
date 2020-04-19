using System;
using Solution;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 3, -1, -3 };
            var solution = Solution.Solution.MaximumProductMultThree(array);
            if (solution.error != null)
            {
                Console.WriteLine(solution.error);
            }
            else if (solution.multipleSolutions)
            {
                Console.WriteLine("There are two possible solutions to achieve the maximum product that is multiple of 3");
                Console.WriteLine("Solution1: " + solution.product + " = " + solution.multiplier1 + " * " + solution.multiplier2);
                Console.WriteLine("Solution2: " + solution.product + " = " + -solution.multiplier1 + " * " + -solution.multiplier2);
            }
            else
            {
                Console.WriteLine("Solution: " + solution.product + " = " + solution.multiplier1 + " * " + solution.multiplier2);
            }
        }
    }
}
