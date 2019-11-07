using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FormsOrdirect
{
    public class RestaurantController
    {
        RestaurantRepository rep;
        IRestaurantContext context;

        public RestaurantController()
        {
            context = new RestaurantMSSQLContext();
            rep = new RestaurantRepository(context);
        }

        public List<Restaurant> GetAllRestaurants()
        {
            List<Restaurant> restaurants = rep.GetAllRestaurants();
            return restaurants;
        }

        public Restaurant GetRestaurantByName(string Name)
        {
            Restaurant r = rep.GetRestaurantByName(Name);
            return r;
        }

        public Restaurant GetRestaurantByID(int id)
        {
            Restaurant r = rep.GetRestaurantByID(id);
            return r;
        }
    }

}
