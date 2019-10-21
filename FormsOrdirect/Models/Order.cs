using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsOrdirect.Models
{
    class Order
    {
        public int OrderID { get; set; }
        public int AccountID { get; set; }
        public string Status { get; set; }
    }
}
