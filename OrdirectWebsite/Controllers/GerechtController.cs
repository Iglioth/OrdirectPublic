using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrdirectWebsite
{
    public class GerechtController
    {
        GerechtRepository repo;
        IGerechtContext context;

        public GerechtController()
        {
            context = new GerechtMSSQLContext();
            repo = new GerechtRepository(context);
        }

        public Gerecht GetGerechtById(int id)
        {
            return repo.GetGerechtById(id);
        }

        Gerecht GetGerechtByRondeAndGerechtIdAndOrderId(int ronde, int GerechtId, int OrderId)
        {
            return repo.GetGerechtByRondeAndGerechtIdAndOrderId(ronde, GerechtId, OrderId);
        }

        public List<Gerecht> GetAllGerechtenFromRestaurantID(int id)
        {
            return repo.GetAllGerechtenFromRestaurantID(id);
        }

        List<Gerecht> GetAllGerechtenAndRondesFromOrderId(int id)
        {
            return repo.GetAllGerechtenAndRondesFromOrderId(id);
        }

        public bool MaakBestelling(int ReserveringID, int GerechtID, int Aantal, int BestellingNummer)
        {
            return repo.MaakBestelling(ReserveringID, GerechtID, Aantal, BestellingNummer);
        }

    }
}
