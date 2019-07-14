using System;

namespace ElectronicsShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var electronicsShop = new ElectronicsShop();

            Console.WriteLine(electronicsShop.GetMoneySpent(new int[] { 3, 1 }, new int[] { 5, 2, 8 }, 10));
            Console.WriteLine(electronicsShop.GetMoneySpent(new int[] { 5 }, new int[] { 4 }, 5));
            Console.ReadLine();
        }
    }
}
