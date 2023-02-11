using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class Seeds
    {
        public string Brand { get; set; }
        public int weight { get; set; }
        public int PricePerKg { get; set; }
        public override string ToString()
        {
            return $"Brand: {Brand}\nWeight: {weight}\nPricePerKg: {PricePerKg}";
        }
    }
}
