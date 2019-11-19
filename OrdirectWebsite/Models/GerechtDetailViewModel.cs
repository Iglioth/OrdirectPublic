using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdirectWebsite
{
    public class GerechtDetailViewModel
    {
        public int GerechtID { get; set; }
        public int RestaurantID { get; set; }
        public string Descriptie { get; set; }
        public string Naam { get; set; }
        public int Ronde { get; set; }
    }
}
