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
    public class ReserveringController : Controller
    {
        //Properties
        ReserveringRepository ReserveringRepo;
        IReserveringContext context;

        //Converters
        ReserveringConverter ReserveringConverter = new ReserveringConverter();
        RestaurantConverter RestaurantConverter = new RestaurantConverter();

        //Constructor
        public ReserveringController(IConfiguration config)
        {
            context = new ReserveringMSSQLContext(config.GetConnectionString("DefaultConnection"));
            ReserveringRepo = new ReserveringRepository(context);
        }

        //Haalt alle reserveringen op van een account.
        [HttpGet]
        public IActionResult Index()
        {
            ReserveringViewModel vm = new ReserveringViewModel();
            List<Reservering> reserveringen = new List<Reservering>();
            reserveringen = ReserveringRepo.GetReserveringenById(Convert.ToInt32(HttpContext.Session.GetInt32("AccountID")));
            if(reserveringen == null)
            {
                return View("GeenReserveringen");
            }
            vm.reserveringDetailViewModels = ReserveringConverter.ModelsToViewModel(reserveringen);
            return View(vm);
        }

        //Haalt alle reserveringen op bij een restaurant.
        public IActionResult IndexVoorRestaurant()
        {
            ReserveringViewModel vm = new ReserveringViewModel();
            List<Reservering> reserveringen = ReserveringRepo.GetReserveringenByRestaurantId(Convert.ToInt32(HttpContext.Session.GetInt32("RestaurantID")));
            vm.reserveringDetailViewModels = ReserveringConverter.ModelsToViewModel(reserveringen);
            return View(vm);
        }

        //Maakt een reservering aan.
        [HttpPost]
        public IActionResult Aanmaken(ResRevViewModel vm)
        {
            Reservering reservering = ReserveringConverter.DetailViewModelToModel(vm.ReserveringDetailViewModel);
            Restaurant restaurant = RestaurantConverter.DetailViewModelToModel(vm.RestaurantDetailViewModel);
            ReserveringRepo.CreateReservering(reservering.datetime, restaurant.RestaurantID, 1);
            return RedirectToAction("Index", controllerName: "Restaurant");
        }

        //Gaat naar de details van een reservering
        public IActionResult Detail(ReserveringDetailViewModel vm)
        {
            return View(vm);
        }

        /*public IActionResult ToOverview(int id)
        {
            Reservering reservering = ReserveringRepo.GetReserveringById(id);
            return RedirectToAction(controllerName: "Bestelling", actionName: "Overview", routeValues: reservering);
        }*/

        //Verwijdert een reservering.
        public IActionResult Delete(ReserveringDetailViewModel detailViewModel)
        {
            Reservering r = ReserveringConverter.DetailViewModelToModel(detailViewModel);

            if (ReserveringRepo.DeleteReservering(r.ReserveringID))
            {
                return RedirectToAction("IndexVoorRestaurant");
            }
            else
            {
                return RedirectToAction("DeleteFailed");
            }
        }

        //foutafhandeling van de verwijdering van een reservering.
        public IActionResult DeleteFailed()
        {
            return View();
        }

        //Opent de reservering voor de klant om te bestellen.
        [HttpPost]
        public IActionResult Open(ReserveringDetailViewModel detailViewModel)
        {
            Reservering r = ReserveringConverter.DetailViewModelToModel(detailViewModel);
            ReserveringRepo.OpenReservering(r.ReserveringID);
            return RedirectToAction("IndexVoorRestaurant");
        }

        //Sluit de reservering zodat de klant niet meer kan bestellen.
        public IActionResult Sluit(ReserveringDetailViewModel detailViewModel)
        {
            Reservering r = ReserveringConverter.DetailViewModelToModel(detailViewModel);
            ReserveringRepo.SluitReservering(r.ReserveringID);
            return RedirectToAction("IndexVoorRestaurant");
        }

        //Accepteerd de reservering zodat de klant weet dat ze naar de reservering kunnen.
        [HttpPost]
        public IActionResult Accepteer(ReserveringDetailViewModel detailViewModel)
        {
            Reservering r = ReserveringConverter.DetailViewModelToModel(detailViewModel);
            ReserveringRepo.AccepteerReservering(r.ReserveringID);
            return RedirectToAction("IndexVoorRestaurant");
        }

        //Eindigt de reservering zodat hij niet meer opnieuw geopend kan worden. Dit wordt na betalen gedaan.
        [HttpPost]
        public IActionResult Eindig(ReserveringDetailViewModel detailViewModel)
        {
            Reservering r = ReserveringConverter.DetailViewModelToModel(detailViewModel);
            ReserveringRepo.EindigReservering(r.ReserveringID);
            return RedirectToAction("IndexVoorRestaurant");

        }

        //Haalt alle reserveringen op die open zijn bij een restaurant.
        public IActionResult OpenReserveringList()
        {
            int id = (int)HttpContext.Session.GetInt32("RestaurantID");
            List<Reservering> reserveringen = new List<Reservering>();
            reserveringen = ReserveringRepo.GetOpenReserveringenByRestaurantId(id);
            foreach (Reservering r in reserveringen)
            {
                 r.OpenBestellingen = ReserveringRepo.GetOpenBestellingenFromReservering(r.ReserveringID);
            }
            ReserveringViewModel reserveringViewModel = new ReserveringViewModel();
            reserveringViewModel.reserveringDetailViewModels = ReserveringConverter.ModelsToViewModel(reserveringen);

            return View(viewName: "ReserveringList", model: reserveringViewModel);
        }
    }
}
