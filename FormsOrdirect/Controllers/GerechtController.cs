using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsOrdirect
{
    public class GerechtController
    {
        GerechtRepository repo;
        IGerechtContext context;

        public GerechtController()
        {
            repo = new GerechtRepository(context);
            context = new GerechtMSSQLContext();
        }

        Gerecht GetGerechtById(int id)
        {
            return repo.GetGerechtById(id);
        }

        Gerecht GetGerechtByRondeAndGerechtIdAndOrderId(int ronde, int GerechtId, int OrderId)
        {
            return repo.GetGerechtByRondeAndGerechtIdAndOrderId(ronde, GerechtId, OrderId);
        }

        List<Gerecht> GetAllGerechtenFromRestaurantID(int id)
        {
            return repo.GetAllGerechtenFromRestaurantID(id);
        }

        List<Gerecht> GetAllGerechtenAndRondesFromOrderId(int id)
        {
            return repo.GetAllGerechtenAndRondesFromOrderId(id);
        }
    }
}
