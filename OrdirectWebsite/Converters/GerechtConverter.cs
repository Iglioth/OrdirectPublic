using Ordirect.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdirectWebsite
{
    public class GerechtConverter : IViewModelConverterContext<Gerecht, GerechtDetailViewModel>
    {
        public Gerecht DetailViewModelToModel(GerechtDetailViewModel vm)
        {
            return new Gerecht
            {
                Descriptie = vm.Descriptie,
                GerechtID = vm.GerechtID,
                Naam = vm.Naam,
                RestaurantID = vm.RestaurantID,
                Aantal = vm.Aantal
            };
        }

        public List<GerechtDetailViewModel> ModelsToViewModel(List<Gerecht> ms)
        {
            List<GerechtDetailViewModel> vm = new List<GerechtDetailViewModel>();
            foreach(Gerecht g in ms)
            {
                vm.Add(ModelToDetailViewModel(g));
            }

            return vm;
        }

        public GerechtDetailViewModel ModelToDetailViewModel(Gerecht g)
        {
            return new GerechtDetailViewModel
            {
                RestaurantID = g.RestaurantID,
                Descriptie = g.Descriptie,
                GerechtID = g.GerechtID,
                Naam = g.Naam,
                Aantal = g.Aantal
            };
        }

        public List<Gerecht> ViewModelToModels(List<GerechtDetailViewModel> vms)
        {
            List<Gerecht> g = new List<Gerecht>();
            foreach (GerechtDetailViewModel dvm in vms)
            {
                g.Add(DetailViewModelToModel(dvm));
            }

            return g;
        }
    }
}
