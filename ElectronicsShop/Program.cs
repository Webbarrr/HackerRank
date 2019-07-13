using System;
using System.Collections.Generic;
using System.Linq;

namespace ElectronicsShop
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(GetMoneySpent(new int[] { 3, 1 }, new int[] { 5, 2, 8 }, 10));
            Console.WriteLine(GetMoneySpent(new int[] { 5}, new int[] { 4 }, 5));
            Console.ReadLine();
        }

        static int GetMoneySpent(int[] keyboards, int[] drives, int budget)
        {
            if (budget == 0)
                return -1;

            // sort the two arrays so the highest values are at the front
            keyboards = SortArrayDescending(keyboards);
            drives = SortArrayDescending(drives);

            // delete any that are over our budget
            var affordableKeyboards = GetAffordableItems(keyboards, budget);
            var affordableDrives = GetAffordableItems(drives, budget);

            // make a list to contain the combined totals
            var combinedTotals = new List<int>();

            foreach (var keyboard in keyboards)
            {
                foreach (var drive in drives)
                {
                    combinedTotals.Add(keyboard + drive);
                }
            }

            // sort the list & delete anything over budget
            combinedTotals.Sort();
            combinedTotals.Reverse();
            combinedTotals.RemoveAll(n => n > budget);

            return combinedTotals.Count == 0 ? -1 : combinedTotals[0];
        }

        static int[] SortArrayDescending(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);

            return array;
        }

        static int[] GetAffordableItems(int[] array, int budget)
        {
            return array.Where(n => n < budget).ToArray();
        }
    }
}
