using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.BreakingRecords
{
    public class CalculateBrokenRecords
    {
        public int[] GetBrokenRecords(int[] scores)
        {
            if (scores == null)
                throw new ArgumentNullException(nameof(scores));

            var minimumScore = scores[0];
            var maximumScore = scores[0];
            var timesBeaten = new int[] { 0, 0 };

            var newScores = scores.Skip(1).Take(scores.Length);

            foreach (var score in newScores)
            {
                if (score > minimumScore && score < maximumScore)
                    continue;

                if (score < minimumScore)
                {
                    minimumScore = score;
                    timesBeaten[1]++;
                }
                else if (score > maximumScore)
                {
                    maximumScore = score;
                    timesBeaten[0]++;
                }
            }

            return timesBeaten;
        }
    }
}
