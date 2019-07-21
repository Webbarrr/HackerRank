using System;
using System.Collections.Generic;
using Challenges.BirthdayChocolate;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Birthday(new List<int>{2, 2, 1, 3, 2},4,2)); // 2
            Console.WriteLine(Birthday(new List<int>{1, 2, 1, 3, 2},3,2)); // 2
            Console.WriteLine(Birthday(new List<int>{1,1,1,1,1,1},3,2)); // 0
            Console.WriteLine(Birthday(new List<int>{4},4,1)); // 1
            Console.ReadLine();
        }

        static int Birthday(List<int> s, int d, int m)
        {
            // create the person & chocolate bar
            var person = new Person {BirthDate = d, BirthMonth = m};
            var chocolateBar = new ChocolateBar {Segments = s};

            // create the segment calculator
            var segmentCalculator = new SegmentCalculator();

            // return the count
            return segmentCalculator.CalculateSegments(person, chocolateBar);
        }
    }
}
