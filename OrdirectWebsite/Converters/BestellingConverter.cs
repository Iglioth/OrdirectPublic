using Ordirect.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdirectWebsite
{
    public class BestellingConverter : IViewModelConverterContext<Bestelling, BestellingDetailViewModel>
    {
        public Bestelling DetailViewModelToModel(BestellingDetailViewModel vm)
        {
            return new Bestelling
            {
                Aantal = vm.Aantal,
                GerechtID = vm.GerechtID,
                ReserveringID = vm.ReserveringID,
                Ronde = vm.Ronde,
                Naam = vm.Naam
            };
        }

        public List<BestellingDetailViewModel> ModelsToViewModel(List<Bestelling> ms)
        {
            List<BestellingDetailViewModel> vm = new List<BestellingDetailViewModel>();
            foreach(Bestelling b in ms)
            {
                vm.Add(ModelToDetailViewModel(b));
            }
            return vm;
        }

        public BestellingDetailViewModel ModelToDetailViewModel(Bestelling b)
        {
            return new BestellingDetailViewModel
            {
                Aantal = b.Aantal,
                GerechtID = b.GerechtID,
                ReserveringID = b.ReserveringID,
                Ronde = b.Ronde,
                Naam = b.Naam
            };
        }

        public List<Bestelling> ViewModelToModels(List<BestellingDetailViewModel> vms)
        {
            List<Bestelling> bestellingen = new List<Bestelling>();
            foreach(BestellingDetailViewModel dvm in vms)
            {
                bestellingen.Add(DetailViewModelToModel(dvm));
            }
            return bestellingen;
        }
    }
}
