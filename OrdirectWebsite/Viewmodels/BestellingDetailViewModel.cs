using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdirectWebsite
{
    public class BestellingDetailViewModel
    {
        public int ReserveringID { get; set; }
        public int GerechtID { get; set; }
        public int Ronde { get; set; }
        public int Aantal { get; set; }
        public string Naam { get; set; }
    }
}
