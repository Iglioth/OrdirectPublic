using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordirect.Core
{
    public class RestaurantRepository
    {
        IRestaurantContext Context;

        public RestaurantRepository(IRestaurantContext context)
        {
            Context = context;
        }

        public List<Restaurant> GetAllRestaurants()
        {
            return Context.GetGlobalRestaurants();
        }

        public Restaurant GetRestaurantByName(string Name)
        {
            return Context.GetRestaurantByName(Name); 
        }

        public Restaurant GetRestaurantByID(int id)
        {
            return Context.GetRestaurantByID(id);
        }
    }
}
