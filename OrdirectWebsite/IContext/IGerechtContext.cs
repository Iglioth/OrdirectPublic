using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdirectWebsite
{
    public interface IGerechtContext
    {
        Gerecht GetGerechtById(int id);

        Gerecht GetGerechtByRondeAndGerechtIdAndOrderId(int ronde, int GerechtId, int OrderId);

        List<Gerecht> GetAllGerechtenFromRestaurantID(int id);

        List<Gerecht> GetAllGerechtenAndRondesFromOrderId(int id);

        bool BestellingMaken(int ReserveringID, int GerechtID, int Aantal, int BestellingNummer);
    }
}
