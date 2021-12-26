using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Entities
{
    public class Item
    {
        public int ID { get; set; }
        public string ItemName { get; set; }
        public decimal ShippingWeight { get; set; }
        public string Description { get; set; }
        public int TaxID { get; set; }
        public decimal Price { get; set; }
    }
}
