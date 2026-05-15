using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypermarketCourseWork_B_.Models
{
    public class Laptop : Product
    {
        public double ScreenSize { get; set; }
        public double Weight { get; set; }
        public int ProcessorCoreCount { get; set; }
        public int Memory { get; set; }

        public Laptop(
            string brand,
            string name,
            decimal price,
            double maxDiscountPercent,
            double screenSize,
            double weight,
            int processorCoreCount,
            int memory)
            : base(brand, name, price, maxDiscountPercent)
        {
            ScreenSize = screenSize;
            Weight = weight;
            ProcessorCoreCount = processorCoreCount;
            Memory = memory;
        }

        public override string ToString()
        {
            return $"Laptop | {base.ToString()} | Screen: {ScreenSize}\" | Weight: {Weight} kg | Cores: {ProcessorCoreCount} | Memory: {Memory} GB";
        }
    }
}
