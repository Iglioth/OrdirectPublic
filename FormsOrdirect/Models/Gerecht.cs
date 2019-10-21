using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsOrdirect
{
    public class Gerecht
    {
        public int GerechtID { get; set; }
        public int RestaurantID { get; set; }
        public Image image { get; set; }
        public string Descriptie { get; set; }
        public string Naam { get; set; }
        public int Ronde { get; set; }
    }
}
