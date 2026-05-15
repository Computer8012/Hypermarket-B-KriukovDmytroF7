using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypermarketCourseWork_B_.Models
{
    public class DslrCamera : Camera
    {
        public DslrCamera(string brand, string name, decimal price, double maxDiscountPercent)
            : base(brand, name, price, maxDiscountPercent)
        {
        }

        public override string ToString()
        {
            return $"DSLR camera | {base.ToString()}";
        }
    }
}
