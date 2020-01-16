using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Ordirect.Core;

namespace OrdirectWebsite
{
    public class RestaurantController : Controller
    {
        RestaurantRepository rep;
        IRestaurantContext context;

        RestaurantConverter converter = new RestaurantConverter();

        public RestaurantController(IConfiguration config)
        {
            context = new RestaurantMSSQLContext(config.GetConnectionString("DefaultConnection"));
            rep = new RestaurantRepository(context);
        }

        //Haalt alle Restaurants op.
        [HttpGet]
        public IActionResult Index()
        {
            List<Restaurant> restaurants = rep.GetAllRestaurants();
            RestaurantViewModel vm = new RestaurantViewModel
            {
                restaurantDetailViewModels = converter.ModelsToViewModel(restaurants)
            };

            return View(vm);
        }

        //Bekijkt de detail van een restaurant.
        public IActionResult Detail(int id)
        {
            Restaurant r = rep.GetRestaurantByID(id);

            if(r == null)
            {
                r = rep.GetRestaurantByID((int)HttpContext.Session.GetInt32("RestaurantID"));
            }
            ResRevViewModel vm = new ResRevViewModel();
            vm.RestaurantDetailViewModel = converter.ModelToDetailViewModel(r);
            return View(vm);
        }
    }
}



