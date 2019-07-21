using System;
using System.Collections.Generic;
using System.Linq;

namespace BetweenTwoSets
{
    public class SetLogic
    {
        private List<int> _a;
        private List<int> _b;
        private int _incrementor;

        private readonly List<int> _potentialDivisors;

        public readonly List<int> ValidDivisors;

        public SetLogic()
        {
            ValidDivisors = new List<int>();
            _potentialDivisors = new List<int>();
        }

        public int GetTotalX(List<int> a, List<int> b)
        {
            this._a = a ?? throw new ArgumentNullException(nameof(a));
            this._b = b ?? throw new ArgumentNullException(nameof(b));

            // get the lower & upper boundaries from the given sets
            var lowerElement = a[a.Count - 1];
            var upperElement = b[0];

            _incrementor = (this.AreAllElementsEven() ? 2 : 1);

            bool failCondition;

            // find potential divisors
            for (int i = lowerElement; i <= upperElement; i+=_incrementor)
            {
                failCondition = false;

                foreach (var item in a)
                {
                    if (!(i % item == 0))
                    {
                        failCondition = true;
                        break;
                    }
                }

                if (!failCondition)
                    foreach (var item in b)
                    {
                        if (!(item % i == 0))
                        {
                            failCondition = true;
                            break;
                        }
                    }

                if (!failCondition)
                    ValidDivisors.Add(i);
            }

            return ValidDivisors.Count;
        }

        private bool ConsiderXInY(int x, List<int> y)
        {
            foreach (var i in y)
            {
                if (!(x % i == 0))
                    return false;
            }

            return true;
        }

        private bool AreAllElementsEven()
        {

            if (this._a.Where(n => n % 2 == 0).ToArray().Length == this._a.Count 
                && this._b.Where(n => n % 2 == 0).ToArray().Length == this._b.Count)
                return true;

            return false;
        }
    }
}
