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
            BestellingRepo = new BestellingRepository(BestellingContext, GerechtContext);
            GerechtContext = new GerechtMSSQLContext();
            GerechtRepo = new GerechtRepository(GerechtContext);
        }

        [HttpGet]
        public IActionResult Overview(Reservering r)
        {
            HttpContext.Session.SetInt32("ReserveringId", r.ReserveringID);

            List<Gerecht> RestaurantGerechten = GerechtRepo.GetAllGerechtenFromRestaurantID(r.RestaurantID);
            List<int> Rondes = BestellingRepo.GetDistinctRondes(r.ReserveringID);
            List<Bestelling> ReserveringBestellingen = BestellingRepo.GetBestellingen(r.ReserveringID);
            List<Gerecht> HuidigeBestelling = BestellingRepo.GetHuidigeBestelling(r.ReserveringID);

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

        public IActionResult VoegToeAanHuidigeBestelling(int gerechtid)
        {
            bool NietNieuw = new bool();
            int ReserveringId = Convert.ToInt32(HttpContext.Session.GetInt32("ReserveringId"));
            List<Gerecht> HuidigeBestelling = BestellingRepo.GetHuidigeBestelling(ReserveringId);
            foreach(Gerecht g in HuidigeBestelling)
            {
                if(g.GerechtID == gerechtid)
                {
                    BestellingRepo.BumpBestellingUp(g.GerechtID, ReserveringId);
                    NietNieuw = true;
                    break;
                }
            }
            if (NietNieuw == false)
            {
                BestellingRepo.InsertBestelling(ReserveringId, gerechtid, 0, 1);
            }
            return RedirectToAction("Overview");
        }

        public IActionResult VerwijderVanHuidigeBestelling(int gerechtid)
        {
            bool NietNieuw = new bool();
            int ReserveringId = Convert.ToInt32(HttpContext.Session.GetInt32("ReserveringId"));
            List<Gerecht> HuidigeBestelling = BestellingRepo.GetHuidigeBestelling(ReserveringId);
            foreach (Gerecht g in HuidigeBestelling)
            {
                if (g.GerechtID == gerechtid)
                {
                    BestellingRepo.BumpBestellingUp
                    NietNieuw = true;
                    break;
                }
            }
            if (NietNieuw == false)
            {
                BestellingRepo.InsertBestelling(ReserveringId, gerechtid, 0, 1);
            }
            return RedirectToAction("Overview");
        }

    }
}
