using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdirectWebsite
{
    public class BestellingViewModel
    {
        public List<BestellingDetailViewModel> bestellingDetailViewModels { get; set; }
        public List<int> Rondes { get; set; }
        public List<GerechtDetailViewModel> gerechtDetailViewModels { get; set; }
        public List<GerechtDetailViewModel> HuidigeBestelling { get; set; }
        public int SelectedGerecht { get; set; }
    }
}
