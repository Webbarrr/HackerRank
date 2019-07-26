using System;
using System.Collections.Generic;

namespace Challenges.DivisibleSumPairs
{
    public class ArrayCalculator
    {
        private readonly List<int[]> _sumPairs;

        public ArrayCalculator()
        {
            this._sumPairs = new List<int[]>();
        }

        public int GetDivisibleSumPairCount(int divisibleBy, int[] ints)
        {
            if (divisibleBy == 0)
                throw new InvalidOperationException("Expected number greater than 0.");

            if (ints == null)
                throw new ArgumentNullException(nameof(ints));

            var intsCount = ints.Length - 1;

            var x = ints.Length - 1;

            for (int i = 0; i < x; i++)
            {
                for (int j = i + 1; j < x; j++)
                {
                    if (ints[i] < ints[j])
                    {
                        var sum = ints[i] + ints[j];
                        if (sum % divisibleBy == 0)
                            this._sumPairs.Add(new int[]{ints[i], ints[j]});
                    }
                }
            }

            return this._sumPairs.Count;
        }
    }
}
