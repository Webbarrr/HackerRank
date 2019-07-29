using System.Linq;

namespace Challenges.BonAppetit
{
    public class BillCalculator
    {
        private readonly Customer _customer;

        public BillCalculator(Customer customer)
        {
            this._customer = customer ?? throw new System.ArgumentNullException(nameof(customer));
        }

        public int CalculateOverpayment()
        {
            // get the correct bill
            var correctBill = this._customer.Bill.Where((b, i) => i != this._customer.DidNotEatIndex).ToList();

            // how much did the customer already pay
            var alreadyPaid = this._customer.Paid;

            // how much should the customer have paid
            var correctSplit = correctBill.Sum() / 2;

            return correctSplit == alreadyPaid ? 0 : alreadyPaid - correctSplit;
        }
    }
}
