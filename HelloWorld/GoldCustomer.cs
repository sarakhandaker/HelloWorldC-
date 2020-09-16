using System;
namespace HelloWorld
{
    public class GoldCustomer :Customer
    {
        public void OfferVoucher()
        {
            this.CalculateRating();
        }
    }
}
