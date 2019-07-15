using System;
using System.Collections.Generic;
using System.Linq;

namespace ElectronicsShop
{
    public class Shopper
    {
        public int Budget { get; private set; }

        public Shopper(int budget)
        {
            if (budget < 0)
                throw new ArgumentOutOfRangeException(nameof(budget), "Budget must be non-negative");

            this.Budget = budget;
        }

        public int Shop(ElectronicsShop shop)
        {
            if (shop == null)
                throw new ArgumentNullException(nameof(shop));

            // get the affordable items
            var affordableKeyboardPrices = shop.GetAffordableItems(shop.KeyboardPrices, this.Budget);
            var affordableDrivePrices = shop.GetAffordableItems(shop.DrivePrices, this.Budget);

            // evaluate the shoppers options
            return EvaluateChoices(affordableKeyboardPrices, affordableDrivePrices);
        }

        private int EvaluateChoices(IEnumerable<int> keyboardPrices, IEnumerable<int> drivePrices)
        {
            // create a list of valid combinations
            var combinedTotals = new List<int>();

            foreach (var affordableKeyboardPrice in keyboardPrices)
            {
                foreach (var affordableDrivePrice in drivePrices)
                {
                    var price = affordableKeyboardPrice + affordableDrivePrice;

                    if (price <= this.Budget)
                        combinedTotals.Add(price);
                }
            }

            // return the most expensive item left over, or -1 if not
            return combinedTotals.Count == 0 ? -1 : combinedTotals.Max();
        }
    }
}
