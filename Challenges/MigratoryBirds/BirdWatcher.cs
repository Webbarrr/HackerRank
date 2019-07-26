using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenges.MigratoryBirds
{
    public class BirdWatcher
    {
        public int MostCommonBird(List<Bird> birds)
        {
            var birdTracker = new Dictionary<int,int>();

            var uniqueBirds = birds.Select(b => b.Id).Distinct();

            foreach (var uniqueBird in uniqueBirds)
            {
                var individualBirds = birds.Where(b => b.Id == uniqueBird);
                var counter = 0;

                foreach (var individualBird in individualBirds)
                    counter++;

                birdTracker.Add(uniqueBird,counter);
            }

            return birdTracker.OrderBy(b => b.Key).OrderByDescending(b => b.Value).FirstOrDefault().Key;
        }
    }
}
