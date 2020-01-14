using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdirectWebsite.Viewmodels
{
    public class BesAccViewModel
    {
        public AccountDetailViewModel AccountDetailViewModel { get; set; }
        public List<BestellingDetailViewModel> bestellingDetailViewModels { get; set; }
    }
}
