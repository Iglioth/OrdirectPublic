using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrdirectWebsite
{
    public class ReserveringController : Controller
    {
        //Properties
        ReserveringRepository ReserveringRepo;
        IReserveringContext context;

        //Converters
        ReserveringConverter ReserveringConverter = new ReserveringConverter();
        RestaurantConverter RestaurantConverter = new RestaurantConverter();

        //Constructor
        public ReserveringController()
        {
            context = new ReserveringMSSQLContext();
            ReserveringRepo = new ReserveringRepository(context);
        }

        [HttpGet]
        public IActionResult Index()
        {
            ReserveringViewModel vm = new ReserveringViewModel();
            List<Reservering> reserveringen = ReserveringRepo.GetReserveringenById(Convert.ToInt32(HttpContext.Session.GetInt32("AccountID")));
            vm.reserveringDetailViewModels = ReserveringConverter.ModelsToViewModel(reserveringen);
            return View(vm);
        }

        [HttpPost]
        public IActionResult Aanmaken(ResRevViewModel vm)
        {
            Reservering reservering = ReserveringConverter.DetailViewModelToModel(vm.ReserveringDetailViewModel);
            Restaurant restaurant = RestaurantConverter.DetailViewModelToModel(vm.RestaurantDetailViewModel);
            ReserveringRepo.CreateReservering(reservering.datetime, restaurant.RestaurantID, 1);
            return RedirectToAction("Index", controllerName: "Restaurant");
        }
        
        public IActionResult Detail(ReserveringDetailViewModel vm)
        {
            return View(vm);
        }

        public IActionResult ToOverview(int id)
        {
            Reservering reservering = ReserveringRepo.GetReserveringById(id);
            return RedirectToAction(controllerName: "Bestelling", actionName: "Overview", routeValues: reservering);
        }

        public IActionResult Delete(int id)
        {

            if (ReserveringRepo.DeleteReservering(id))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("DeleteFailed");
            }
        }

        public IActionResult DeleteFailed()
        {
            return View();
        }
    }
}
