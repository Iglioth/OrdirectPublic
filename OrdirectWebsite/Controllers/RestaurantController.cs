﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrdirectWebsite
{
    public class RestaurantController : Controller
    {
        RestaurantRepository rep;
        IRestaurantContext context;

        RestaurantConverter converter = new RestaurantConverter();

        public RestaurantController()
        {
            context = new RestaurantMSSQLContext();
            rep = new RestaurantRepository(context);
        }


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

        public IActionResult Detail(int id)
        {
            Restaurant r = rep.GetRestaurantByID(id);
            ResRevViewModel vm = new ResRevViewModel();
            vm.RestaurantDetailViewModel = converter.ModelToDetailViewModel(r);
            return View(vm);
        }
    }
}



