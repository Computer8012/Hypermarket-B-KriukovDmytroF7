using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypermarketCourseWork_B_.Models
{
    public class Camera : Product
    {
        public Camera(string brand, string name, decimal price, double maxDiscountPercent)
            : base(brand, name, price, maxDiscountPercent)
        {
        }

        public override string ToString()
        {
            return $"Camera | {base.ToString()}";
        }
    }
}
