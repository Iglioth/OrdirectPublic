using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsOrdirect
{
    public class GerechtRepository
    {
        IGerechtContext Context;

        public GerechtRepository(IGerechtContext context)
        {
            Context = context;
        }

        public Gerecht GetGerechtById(int id)
        {
            return Context.GetGerechtById(id);
        }

        public Gerecht GetGerechtByRondeAndGerechtIdAndOrderId(int ronde, int GerechtId, int OrderId)
        {
            return Context.GetGerechtByRondeAndGerechtIdAndOrderId(ronde, GerechtId, OrderId);
        }

        public List<Gerecht> GetAllGerechtenFromRestaurantID(int id)
        {
            return Context.GetAllGerechtenFromRestaurantID(id);
        }

        public List<Gerecht> GetAllGerechtenAndRondesFromOrderId(int id)
        {
            return Context.GetAllGerechtenAndRondesFromOrderId(id);
        }

        internal bool MaakBestelling(int ReserveringID, int GerechtID, int Aantal, int BestellingNummer)
        {
            return Context.BestellingMaken(ReserveringID, GerechtID, Aantal, BestellingNummer);
        }
    }
}
