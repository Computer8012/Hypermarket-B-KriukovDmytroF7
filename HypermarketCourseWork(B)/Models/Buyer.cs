using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypermarketCourseWork_B_.Models
{
    public class Buyer
    {
        public decimal Money { get; set; }

        public Buyer(decimal money)
        {
            Money = money;
        }

        public virtual double GetIndividualDiscount()
        {
            return 0;
        }

        public virtual bool BuyProduct(Product product)
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
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"Regular buyer | Money: {Money} UAH | Discount: {GetIndividualDiscount()}%";
        }
    }
}
