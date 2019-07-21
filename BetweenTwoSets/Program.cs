using System;
using System.Collections.Generic;

namespace BetweenTwoSets
{
    public static class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var a = new List<int> {2, 6};
                var b = new List<int> {24, 36};

                var setLogic = new SetLogic();
                var count = setLogic.GetTotalX(a, b);
                Console.WriteLine(count); // expecting 2

                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
