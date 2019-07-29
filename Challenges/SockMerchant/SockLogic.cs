using System.Collections.Generic;
using System.Linq;

namespace Challenges.SockMerchant
{
    public class SockLogic
    {
        public int Pairs { get; private set; }

        public int CountPairs(int[] socks)
        {
            var socksAsList = socks.ToList();
            return this.CountPairsRecursively(socksAsList);
        }

        private int CountPairsRecursively(List<int> socks)
        {
            // find the first pair in the list
            var nextPair = socks.GroupBy(s => s)
                .Where(s => s.Count() > 1)
                .FirstOrDefault();

            // exit condition
            if (nextPair == null)
                return this.Pairs;

            // increment & remove that pair from the list
            this.Pairs++;

            var newSocks = new List<int>(socks);
            for (int i = 0; i < 2; i++)
                newSocks.Remove(nextPair.Key);

            //var newSocks = new List<int>(socks.Where(s => s!= nextPair.Key));
            return this.CountPairsRecursively(newSocks);
        }
    }
}
