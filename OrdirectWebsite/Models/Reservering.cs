using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdirectWebsite
{
    public class Reservering
    {
        public int ReserveringID { get; set; }
        public DateTime datetime { get; set; }
        public string Status { get; set; }
        public int KlantID { get; set; }
        public int RestaurantID { get; set; }
    }
}
