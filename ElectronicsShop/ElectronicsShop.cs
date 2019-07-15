using System;
using System.Collections.Generic;
using System.Linq;

namespace ElectronicsShop
{

    public class ElectronicsShop
    {
        public int[] KeyboardPrices { get; }
        public int[] DrivePrices { get; }

        public ElectronicsShop(int[] keyboardPrices, int[] drivePrices)
        {
            this.KeyboardPrices = keyboardPrices ?? throw new ArgumentNullException(nameof(keyboardPrices));
            this.DrivePrices = drivePrices ?? throw new ArgumentNullException(nameof(drivePrices));
        }

        public IEnumerable<int> GetAffordableItems(int[] array, int budget)
        {
            return array.OrderByDescending(n => n).TakeWhile(n => n <= budget);
        }
    }
}
