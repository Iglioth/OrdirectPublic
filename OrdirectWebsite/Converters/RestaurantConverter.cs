using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdirectWebsite
{
    public class RestaurantConverter
    {
        public RestaurantDetailViewModel ModelToViewModel(Restaurant r)
        {
            return new RestaurantDetailViewModel
            {
                Adres = r.Adres,
                Naam = r.Naam,
                RestaurantID = r.RestaurantID,
                Telefoonnummer = r.Telefoonnummer
            };
        }

        public Restaurant ViewModelToModel(RestaurantDetailViewModel viewModel)
        {
            return new Restaurant
            {
                RestaurantID = viewModel.RestaurantID,
                Adres = viewModel.Adres,
                Naam = viewModel.Naam,
                Telefoonnummer = viewModel.Telefoonnummer
            };
        }
    }
}
