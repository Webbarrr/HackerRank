using System;

namespace ElectronicsShop
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a shopper & assign a budget
            var shopper = new Shopper(10);
            // shop for available items
            Console.WriteLine(shopper.Shop(new ElectronicsShop(new int[] { 3, 1 }, new int[] { 5, 2, 8 })));

            // repeat
            shopper = new Shopper(5);
            Console.WriteLine(shopper.Shop(new ElectronicsShop(new int[] {5}, new int[] {4})));

            Console.ReadLine();
        }
    }
}
