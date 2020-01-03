using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdirectWebsite
{
    public class Gerecht
    {
        public int GerechtID { get; set; }
        public int RestaurantID { get; set; }
        public string Descriptie { get; set; }
        public string Naam { get; set; }
        public int Aantal { get; set; }
    }
}
