using System;
using System.Collections.Generic;
using Challenges.BonAppetit;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            BonAppetit(new List<int> { 2,4,6 }, 2, 3); // Bon Appetit
            BonAppetit(new List<int> { 2,4,6 }, 2, 6); // 3

            BonAppetit(new List<int>{3,10,2,9}, 1,12); // 5

            BonAppetit(new List<int>{3,10,2,9},1,7); // Bon Appetit

            Console.ReadLine();
        }

        static void BonAppetit(List<int> bill, int k, int b)
        {
            var restaurant = new Restaurant();

            var customer = new Customer
            {
                DidNotEatIndex = k,
                Paid = b
            };

            // give the bill to the customer
            restaurant.GiveBillToCustomer(customer, bill);

            // now calculate
            customer.CalculateBill(new BillCalculator(customer));
        }
    }
}
