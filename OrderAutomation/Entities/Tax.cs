using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Entities
{
    public class Tax
    {
        public int ID { get; set; }
        public string TaxName { get; set; }
        public int TaxPercent { get; set; }
    }
}
