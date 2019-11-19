using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdirectWebsite
{
    public class GerechtConverter
    {
        public GerechtDetailViewModel ModelToViewModel(Gerecht g)
        {
            return new GerechtDetailViewModel
            {
                RestaurantID = g.RestaurantID,
                Ronde = g.Ronde,
                Descriptie = g.Descriptie,
                GerechtID = g.GerechtID,
                Naam = g.Naam
            };
        }

        public Gerecht ViewModelToModel(GerechtDetailViewModel vm)
        {
            return new Gerecht
            {
                Ronde = vm.Ronde,
                Descriptie = vm.Descriptie,
                GerechtID = vm.GerechtID,
                Naam = vm.Naam,
                RestaurantID = vm.RestaurantID
            };
        }
    }
}
