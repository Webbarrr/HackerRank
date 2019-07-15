using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetweenTwoSets
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GetTotalX(new List<int>
                {
                    2,
                    4
                }, new List<int>
                {
                    16,
                    32,
                    96
                });

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static int GetTotalX(List<int> list1, List<int> list2)
        {
            if (list1 == null)
                throw new ArgumentNullException(nameof(list1));

            if (list2 == null)
                throw new ArgumentNullException(nameof(list2));

            // something to hold our valid divisors
            var validDivisors = new List<int>();

            // find the upper & lower elements from the two lists
            var lowerElement = list1[list1.Count - 1];
            var upperElement = list2[0];

            for (var i = lowerElement; i < upperElement; i++)
            {
                foreach (var item in list1)
                {
                    if (i % item != 0)
                    {

                    }
                } 
            }

            return 0;
        }
    }
}
