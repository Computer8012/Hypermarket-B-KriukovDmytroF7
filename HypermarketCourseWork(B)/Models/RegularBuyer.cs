using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypermarketCourseWork_B_.Models
{
    public class RegularBuyer : Buyer
    {
        public string FullName { get; set; }

        public decimal TotalPurchasedAmount { get; set; }

        public RegularBuyer(
            string fullName,
            decimal money,
            decimal totalPurchasedAmount)
            : base(money)
        {
            FullName = fullName;
            TotalPurchasedAmount = totalPurchasedAmount;
        }

        public override double GetIndividualDiscount()
        {
            double discount = (double)(TotalPurchasedAmount / 1000);

            if (discount > 15)
            {
                discount = 15;
            }

            return discount;
        }

        public override bool BuyProduct(Product product)
        {
            double discount = GetIndividualDiscount();

            if (discount > product.MaxDiscountPercent)
            {
                discount = product.MaxDiscountPercent;
            }

            decimal finalPrice = product.Price - product.Price * (decimal)discount / 100;

            if (Money >= finalPrice)
            {
                Money -= finalPrice;

                TotalPurchasedAmount += finalPrice;

                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"{FullName} | Money: {Money} UAH | Purchased: {TotalPurchasedAmount} UAH | Discount: {GetIndividualDiscount()}%";
        }
    }
}
