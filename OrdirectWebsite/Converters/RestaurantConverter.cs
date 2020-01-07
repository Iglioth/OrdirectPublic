using Ordirect.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdirectWebsite
{
    public class RestaurantConverter : IViewModelConverterContext<Restaurant, RestaurantDetailViewModel>
    {
        public Restaurant DetailViewModelToModel(RestaurantDetailViewModel vm)
        {
            return new Restaurant
            {
                RestaurantID = vm.RestaurantID,
                Adres = vm.Adres,
                Naam = vm.Naam,
                Telefoonnummer = vm.Telefoonnummer
                
            };
        }

        public List<RestaurantDetailViewModel> ModelsToViewModel(List<Restaurant> ms)
        {
            List<RestaurantDetailViewModel> restaurantdetailviewmodels = new List<RestaurantDetailViewModel>();
            foreach(Restaurant r in ms)
            {
                restaurantdetailviewmodels.Add(ModelToDetailViewModel(r));
            }
            return restaurantdetailviewmodels;
        }

        public RestaurantDetailViewModel ModelToDetailViewModel(Restaurant m)
        {
            return new RestaurantDetailViewModel
            {
                RestaurantID = m.RestaurantID,
                Adres = m.Adres,
                Naam = m.Naam,
                Telefoonnummer = m.Telefoonnummer
            };
        }

        public List<Restaurant> ViewModelToModels(List<RestaurantDetailViewModel> vms)
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            foreach(RestaurantDetailViewModel dvm in vms)
            {
                restaurants.Add(DetailViewModelToModel(dvm));
            }

            return restaurants;
        }
    }
}
