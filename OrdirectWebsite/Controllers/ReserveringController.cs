using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrdirectWebsite
{
    public class ReserveringController : Controller
    {
        //Properties
        ReserveringRepository repo;
        IReserveringContext context;

        //Converters
        ReserveringConverter ReserveringConverter = new ReserveringConverter();
        RestaurantConverter RestaurantConverter = new RestaurantConverter();

        //Constructor
        public ReserveringController()
        {
            context = new ReserveringMSSQLContext();
            repo = new ReserveringRepository(context);
        }

        [HttpGet]
        public IActionResult Index(int id)
        {
            ReserveringViewModel vm = new ReserveringViewModel();
            List<Reservering> reserveringen = repo.GetReserveringenById(id);
            return View(vm);
        }

        [HttpPost]
        public IActionResult Aanmaken(ResRevViewModel vm)
        {
            Reservering reservering = ReserveringConverter.DetailViewModelToModel(vm.ReserveringDetailViewModel);
            Restaurant restaurant = RestaurantConverter.DetailViewModelToModel(vm.RestaurantDetailViewModel);
            repo.CreateReservering(reservering.datetime, restaurant.RestaurantID, 1);
            return RedirectToAction("Index", controllerName: "Restaurant");
        }
    }
}
