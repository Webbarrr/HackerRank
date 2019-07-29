using System;
using System.Collections.Generic;

namespace Challenges.BonAppetit
{
    public class Customer
    {
        public List<int> Bill { get; private set; }
        public int DidNotEatIndex { get; set; }
        public int Paid { get; set; }

        public Customer()
        {
            this.Bill = new List<int>();
        }

        public void GetBillFromRestaurant(List<int> bill)
        {
            this.Bill = bill ?? throw new System.ArgumentNullException(nameof(bill));
        }

        public void CalculateBill(BillCalculator billCalculator)
        {
            var result = billCalculator.CalculateOverpayment();

            switch (result)
            {
                case 0:
                    Console.WriteLine("Bon Appetit");
                    break;

                default:
                    Console.WriteLine(result);
                    break;
            }
        }
    }
}
