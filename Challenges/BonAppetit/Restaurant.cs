using System.Collections.Generic;

namespace Challenges.BonAppetit
{
    public class Restaurant
    {
        public void GiveBillToCustomer(Customer customer, List<int> bill)
        {
            if (customer == null)
                throw new System.ArgumentNullException(nameof(customer));
            if (bill == null)
                throw new System.ArgumentNullException(nameof(bill));


            customer.GetBillFromRestaurant(bill);
        }
    }
}
