﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsOrdirect
{
    public interface IRestaurantContext
    {
        List<Restaurant> GetGlobalRestaurants();

        Restaurant GetRestaurantByName(string Name);

        Restaurant GetRestaurantByID(int id);
    }
}
