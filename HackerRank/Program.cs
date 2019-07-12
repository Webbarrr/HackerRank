using System;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UtopianTree(0));
            Console.WriteLine(UtopianTree(1));
            Console.WriteLine(UtopianTree(4));
        }

        public static int UtopianTree(int growthCycles)
        {
            const int HEIGHT = 1;

            // no need to do anything
            if (growthCycles == 0)
                return HEIGHT;

            int retVal = HEIGHT;

            // iterate through numbers & get the new height
            for (int i = 1; i <= growthCycles; i++)
            {
                if (i % 2 == 1)
                    retVal *= 2;
                else
                    retVal++;
            }

            return retVal;
        }
    }
}
