using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Entities
{
    class Credit:Payment
    {
        public int Number { get; set; }
        public string Type { get; set; }
        public int ExpDate { get; set; }

        int Aouthorized()
        {
            return 0;
        }


    }
}
