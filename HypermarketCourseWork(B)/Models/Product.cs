using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypermarketCourseWork_B_.Models
{
    public class Product
    {
        public string Firm { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public double MaxDiscountPercent { get; set; }

        public Product(string firm, string name, decimal price, double maxDiscountPercent)
        {
            Firm = firm;
            Name = name;
            Price = price;
            MaxDiscountPercent = maxDiscountPercent;
        }

        public override string ToString()
        {
            return $"{Firm} {Name} - {Price} грн";
        }
    }
}
//Test test test