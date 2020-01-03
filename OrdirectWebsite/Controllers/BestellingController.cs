using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdirectWebsite
{
    public class BestellingController : Controller
    {
        BestellingRepository BestellingRepo;
        GerechtRepository GerechtRepo;
        IGerechtContext GerechtContext;
        IBestellingContext BestellingContext;

        readonly BestellingConverter BestellingConverter = new BestellingConverter();
        readonly GerechtConverter GerechtConverter = new GerechtConverter();

        public BestellingController()
        {
            BestellingContext = new BestellingMSSQLContext();
            GerechtContext = new GerechtMSSQLContext();
            BestellingRepo = new BestellingRepository(BestellingContext, GerechtContext);
            GerechtRepo = new GerechtRepository(GerechtContext);
        }

        [HttpGet]
        public IActionResult SetUpBestelling(ReserveringDetailViewModel r)
        {
            HttpContext.Session.SetInt32("ReserveringId", r.ReserveringID);
            HttpContext.Session.SetInt32("RestaurantId", r.RestaurantID);
            return RedirectToAction("Overview");
        }

        [HttpGet]
        public IActionResult Overview()
        {
            int ReserveringID = Convert.ToInt32(HttpContext.Session.GetInt32("ReserveringId"));
            int RestaurantID = Convert.ToInt32(HttpContext.Session.GetInt32("RestaurantId"));

            List<Gerecht> RestaurantGerechten = GerechtRepo.GetAllGerechtenFromRestaurantID(RestaurantID);
            List<int> Rondes = BestellingRepo.GetDistinctRondes(ReserveringID);
            List<Bestelling> ReserveringBestellingen = BestellingRepo.GetBestellingen(ReserveringID);
            List<Gerecht> HuidigeBestelling = BestellingRepo.GetGerechtenUitBestelling(ReserveringID, 0);

            BestellingViewModel vm = new BestellingViewModel();
            if (ReserveringBestellingen != null)
            {
                vm.bestellingDetailViewModels = BestellingConverter.ModelsToViewModel(ReserveringBestellingen);
                vm.Rondes = Rondes;
            }
            if(HuidigeBestelling != null)
            {
                vm.HuidigeBestelling = GerechtConverter.ModelsToViewModel(HuidigeBestelling);
            }
            vm.gerechtDetailViewModels = GerechtConverter.ModelsToViewModel(RestaurantGerechten);
            return View(vm);
        }

        [HttpGet]
        public IActionResult VoegToeAanHuidigeBestelling(GerechtDetailViewModel gerechtDetailViewModel)
        {
            Gerecht gerecht = new Gerecht();
            gerecht = GerechtConverter.DetailViewModelToModel(gerechtDetailViewModel);
            bool NietNieuw = new bool();
            NietNieuw = false;
            int ReserveringId = Convert.ToInt32(HttpContext.Session.GetInt32("ReserveringId"));
            List<Gerecht> HuidigeBestelling = BestellingRepo.GetGerechtenUitBestelling(ReserveringId, 0);
            foreach (Gerecht g in HuidigeBestelling)
            {
                if(g.GerechtID == gerecht.GerechtID)
                {
                    BestellingRepo.BumpBestellingUp(g.GerechtID, ReserveringId);
                    NietNieuw = true;
                    break;
                }
            }
            if (!NietNieuw)
            {
                BestellingRepo.InsertBestelling(ReserveringId, gerecht.GerechtID, 0, 1);
            }
            return RedirectToAction("Overview");
        }

        [HttpGet]
        public IActionResult VerwijderVanHuidigeBestelling(GerechtDetailViewModel gerechtDetailViewModel)
        {
            Gerecht gerecht = new Gerecht();
            gerecht = GerechtConverter.DetailViewModelToModel(gerechtDetailViewModel);
            int ReserveringId = Convert.ToInt32(HttpContext.Session.GetInt32("ReserveringId"));
            List<Gerecht> HuidigeBestelling = BestellingRepo.GetGerechtenUitBestelling(ReserveringId, 0);
            foreach (Gerecht g in HuidigeBestelling)
            {
                if (g.GerechtID == gerecht.GerechtID && g.Aantal >= 2)
                {
                    BestellingRepo.BumpBestellingDown(ReserveringId, g.GerechtID);
                    break;
                }

                else if(g.GerechtID == gerecht.GerechtID && g.Aantal == 1)
                {
                    BestellingRepo.DeleteBestelling(ReserveringId, g.GerechtID);
                }
            } 
            return RedirectToAction("Overview");
        }

    }
}
