using System;
using System.Collections.Generic;
using System.Linq;

namespace ElectronicsShop
{
    public class ElectronicsShop
    {
        private int _budget;

        public int GetMoneySpent(int[] keyboardPrices, int[] drivePrices, int budget)
        {
            if (keyboardPrices == null)
                throw new ArgumentNullException(nameof(keyboardPrices));

            if (drivePrices == null)
                throw new ArgumentNullException(nameof(drivePrices));

            if (budget < 0)
                throw new ArgumentOutOfRangeException(nameof(budget), "Budget must be non-negative");

            this._budget = budget;

            // filter out items that are over budget & sort
            var affordableKeyboardPrices = GetAffordableItems(keyboardPrices);
            var affordableDrivePrices = GetAffordableItems(drivePrices);

            // create a new list of valid combinations
            var combinedTotals = new List<int>();

            foreach (var affordableKeyboardPrice in affordableKeyboardPrices)
            {
                foreach (var affordableDrivePrice in affordableDrivePrices)
                {
                    var price = affordableKeyboardPrice + affordableDrivePrice;

                    if (price <= this._budget)
                        combinedTotals.Add(price);
                }
            }

            return combinedTotals.Count == 0 ? -1 : combinedTotals[0];
        }

        private IEnumerable<int> GetAffordableItems(int[] array)
        {
            return array.OrderBy(n => n).TakeWhile(n => n <= this._budget).Reverse();
        }
    }
}
