using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplesAndOranges
{
    public class House
    {
        private readonly int _startPosition;
        private readonly int _endPosition;

        public House(int startPosition, int endPosition)
        {
            this._startPosition = startPosition;
            this._endPosition = endPosition;
        }

        public void CountFallenFruit(Fruit fruit)
        {
            if (fruit == null)
                throw new ArgumentNullException(nameof(fruit));

            var landedCount = 0;

            foreach (var fallenFruit in fruit.FallenPositions)
            {
                // where did it land?
                var landedAt = fruit.Location + fallenFruit;

                // did it land within range?
                if (landedAt >= this._startPosition && landedAt <= this._endPosition)
                    landedCount++;
            }

            Console.WriteLine(landedCount);
        }
    }
}
