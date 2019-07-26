using System;
using Challenges.DivisibleSumPairs;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // test 1
            var result = DivisibleSumPairs(6, 5, new[] {1, 2, 3, 4, 5, 6});
            Console.WriteLine(result); // expecting 3

            // test 2
            result = DivisibleSumPairs(6, 3, new[] {1, 3, 2, 6, 1, 2});
            Console.WriteLine(result); // expecting 5

            Console.ReadLine();
        }

        static int DivisibleSumPairs(int n, int k, int[] ar)
        {
            var arrayCalculator = new ArrayCalculator();

            return arrayCalculator.GetDivisibleSumPairCount(k, ar);
        }
    }
}
