using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordirect.Core
{
    public class Reservering
    {
        public int ReserveringID { get; set; }
        public DateTime datetime { get; set; }
        public string Status { get; set; }
        public int KlantID { get; set; }
        public int RestaurantID { get; set; }
        public string RestaurantNaam { get; set; }
        public string KlantVoorNaam { get; set; }
        public string KlantAchterNaam { get; set; }
    }
}
