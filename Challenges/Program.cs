using System;
using System.Collections.Generic;
using Challenges.MigratoryBirds;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // test 1
            var result = MigratoryBirds(new List<int> {1, 1, 2, 2, 3});
            Console.WriteLine(result); // expecting 1

            // test 2
            result = MigratoryBirds(new List<int> { 3,2,2,1,1 });
            Console.WriteLine(result); // expecting 1

            // test 3
            result = MigratoryBirds(new List<int> {1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4});
            Console.WriteLine(result); // expecting 3

            Console.ReadLine();
        }

        static int MigratoryBirds(List<int> arr)
        {
            var birds = new List<Bird>();

            foreach (var bird in arr)
            {
                birds.Add(new Bird{Id = bird});
            }

            var birdWatcher = new BirdWatcher();
            return birdWatcher.MostCommonBird(birds);
        }
    }
}
