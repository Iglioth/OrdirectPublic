using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdirectWebsite.Models
{
    public class BesGerViewModel
    {
        public List<Gerecht> RestaurantGerechten { get; set; }
        public List<Bestelling> ReserveringBestellingen { get; set; }
    }
}
