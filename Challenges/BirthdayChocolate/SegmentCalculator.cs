using System.Linq;

namespace Challenges.BirthdayChocolate
{
    public class SegmentCalculator
    {
        public int CalculateSegments(Person person, ChocolateBar chocolateBar)
        {
            if (person == null)
                throw new System.ArgumentNullException(nameof(person));

            if (chocolateBar == null)
                throw new System.ArgumentNullException(nameof(chocolateBar));

            // create a dummy chocolate bar
            var dummyChocolateBar = GetDummyChocolateBar(chocolateBar);

            // a count for the values to return
            var continguousSegmentCount = 0;

            while (dummyChocolateBar.Segments.Count >= person.BirthMonth)
            {
                // get the latest segments to test
                var segmentsToTest = dummyChocolateBar.Segments.Take(person.BirthMonth);

                var runningTotal = 0;

                // get the sum of the segments to test
                foreach (var segment in segmentsToTest)
                    runningTotal += segment;

                dummyChocolateBar.Segments.RemoveAt(0);

                if (runningTotal != person.BirthDate)
                    continue;

                continguousSegmentCount++;
            }

            return continguousSegmentCount;
        }

        private ChocolateBar GetDummyChocolateBar(ChocolateBar chocolateBar)
        {
            var dummyChocolateBar = new ChocolateBar();

            foreach (var segment in chocolateBar.Segments)
                dummyChocolateBar.Segments.Add(segment);

            return dummyChocolateBar;
        }
    }
}
