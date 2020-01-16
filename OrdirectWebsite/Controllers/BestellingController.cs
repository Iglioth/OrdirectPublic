using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Ordirect.Core;
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

        public BestellingController(IConfiguration config)
        {
            BestellingContext = new BestellingMSSQLContext(config.GetConnectionString("DefaultConnection"));
            GerechtContext = new GerechtMSSQLContext(config.GetConnectionString("DefaultConnection"));
            BestellingRepo = new BestellingRepository(BestellingContext, GerechtContext);
            GerechtRepo = new GerechtRepository(GerechtContext);

        }

        //Een set up om te kunnen bestellen
        [HttpGet]
        public IActionResult SetUpBestelling(ReserveringDetailViewModel r)
        {
            HttpContext.Session.SetInt32("ReserveringId", r.ReserveringID);
            HttpContext.Session.SetInt32("RestaurantId", r.RestaurantID);
            return RedirectToAction("Overview");
        }

        //Crëert een overview van de order.
        public IActionResult Overview(int x)
        {
            int ReserveringID = Convert.ToInt32(HttpContext.Session.GetInt32("ReserveringId"));
            int RestaurantID = Convert.ToInt32(HttpContext.Session.GetInt32("RestaurantId"));

            List<Gerecht> RestaurantGerechten = GerechtRepo.GetAllGerechtenFromRestaurantID(RestaurantID);
            List<int> Rondes = BestellingRepo.GetDistinctRondes(ReserveringID);
            List<Bestelling> ReserveringBestellingen = BestellingRepo.GetBestellingen(ReserveringID);
            List<Gerecht> HuidigeBestelling = BestellingRepo.GetGerechtenUitBestelling(ReserveringID, 0);

            BestellingViewModel vm = new BestellingViewModel();

            if (x > 0)
            {
                List<Gerecht> GeselecteerdeBestelling = BestellingRepo.GetGerechtenUitBestelling(ReserveringID, x);
                vm.SelectedRonde = GerechtConverter.ModelsToViewModel(GeselecteerdeBestelling);
            }

            if (ReserveringBestellingen != null)
            {
                vm.bestellingDetailViewModels = BestellingConverter.ModelsToViewModel(ReserveringBestellingen);
                vm.Rondes = Rondes;
            }
            if (HuidigeBestelling != null)
            {
                vm.HuidigeBestelling = GerechtConverter.ModelsToViewModel(HuidigeBestelling);
            }
            
            vm.gerechtDetailViewModels = GerechtConverter.ModelsToViewModel(RestaurantGerechten);
            return View(model: vm, viewName: "Overview");
        }

        //Voegt iets toe aan de huidige bestelling en refreshed de pagina.
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
                if (g.GerechtID == gerecht.GerechtID)
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

        //Verwijdert iets uit de huidige bestelling en refreshed de pagina
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

                else if (g.GerechtID == gerecht.GerechtID && g.Aantal == 1)
                {
                    BestellingRepo.DeleteBestelling(ReserveringId, g.GerechtID);
                }
            }
            return RedirectToAction("Overview");
        }

        //Zet de huidige bestelling in als bestelling.
        public IActionResult Bestellen()
        {
            int id = (int)HttpContext.Session.GetInt32("ReserveringId");

            List<Bestelling> Allebestellingen = BestellingRepo.GetBestellingen(id);
            List<Bestelling> NieuweBestellingen = new List<Bestelling>();
            List<int> Rondes = BestellingRepo.GetDistinctRondes(id);
            foreach (Bestelling b in Allebestellingen)
            {
                if (b.Ronde == 0)
                {
                    NieuweBestellingen.Add(b);
                }
            }

            int nieuweRonde = Rondes.Count;
            foreach (Bestelling b in NieuweBestellingen)
            {
                BestellingRepo.UpdateBestelling(b.ReserveringID, b.GerechtID, nieuweRonde, b.Aantal, b.Naam, "Open", 0);
            }
            return RedirectToAction("Overview");
        }

        
        //Haalt alle bestellingen op voor een medewerker.
        public IActionResult Bestellingen(int id)
        {
            List<Bestelling> bestellingen = new List<Bestelling>();
            bestellingen = BestellingRepo.GetOpenBestellingen(id);
            BestellingViewModel viewModel = new BestellingViewModel();
            viewModel.bestellingDetailViewModels = BestellingConverter.ModelsToViewModel(bestellingen);
            return View(model: viewModel, viewName: "Bestellingen");
        }

        
        //Verandert de status naar afgerond van een bestelling.
        public IActionResult Afronden(BestellingDetailViewModel vm)
        {
            Bestelling b = new Bestelling();
            b = BestellingConverter.DetailViewModelToModel(vm);

            bool succes = BestellingRepo.UpdateBestelling(b.ReserveringID, b.GerechtID, b.Ronde, b.Aantal, b.Naam, "Ontvangen", b.Ronde);
            if (succes)
            {
                return Bestellingen(b.ReserveringID);
            }
            else
            {
                return View("AfrondenFail");
            }
        }
    }
}

