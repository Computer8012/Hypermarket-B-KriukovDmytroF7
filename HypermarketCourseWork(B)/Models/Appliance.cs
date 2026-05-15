using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypermarketCourseWork_B_.Models
{
    public class Appliance : Product
    {
        public Appliance(
            string brand,
            string name,
            decimal price,
            double maxDiscountPercent)
            : base(brand, name, price, maxDiscountPercent)
        {

        }
    }
}
