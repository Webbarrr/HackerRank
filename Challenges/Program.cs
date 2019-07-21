using System;
using Challenges.BreakingRecords;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            var recordCalculator = new CalculateBrokenRecords();

            var scores = new int[] {12, 24, 10, 24};

            var recordsBroken = recordCalculator.GetBrokenRecords(scores);

            var result = string.Join(" ", recordsBroken);

            Console.WriteLine(result); // expected "1 1"

            scores = new int[] { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 };

            recordsBroken = recordCalculator.GetBrokenRecords(scores);

            result = string.Join(" ", recordsBroken);

            Console.WriteLine(result); // expected "4 0"
            Console.ReadLine();
        }
    }
}
