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
            BestellingRepo = new BestellingRepository(BestellingContext);
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
            BestellingViewModel vm = new BestellingViewModel();
            vm.bestellingDetailViewModels = BestellingConverter.ModelsToViewModel(ReserveringBestellingen);
            vm.gerechtDetailViewModels = GerechtConverter.ModelsToViewModel(RestaurantGerechten);
            vm.Rondes = Rondes;
            return View(vm);
        }

        public bool InsertBestelling(int gerechtID, int reserveringID, int ronde, int v)
        {
            return BestellingRepo.InsertBestelling(gerechtID, reserveringID, ronde, v);
        }

        public bool CheckRonde(int ronde, int reserveringID)
        {
            return BestellingRepo.CheckRonde(ronde, reserveringID);
        }

        internal List<Bestelling> GetBestellingen(int reserveringID)
        {
            return BestellingRepo.GetBestellingen(reserveringID);
        }

        internal List<int> GetDistinctRondes(int ReserveringID)
        {
            return BestellingRepo.GetDistinctRondes(ReserveringID);
        }

        internal List<Gerecht> GetGerechtenUitBestelling(int ReserveringID, int ronde)
        {
            return BestellingRepo.GetGerechtenUitBestelling(ReserveringID, ronde);
        }
    }
}
