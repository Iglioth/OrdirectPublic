using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsOrdirect
{
    public class GerechtRepository
    {
        IGerechtContext context;

        public GerechtRepository(IGerechtContext context)
        {
            this.context = context;
        }

        public Gerecht GetGerechtById(int id)
        {
            return context.GetGerechtById(id);
        }

        public Gerecht GetGerechtByRondeAndGerechtIdAndOrderId(int ronde, int GerechtId, int OrderId)
        {
            return context.GetGerechtByRondeAndGerechtIdAndOrderId(ronde, GerechtId, OrderId);
        }

        public List<Gerecht> GetAllGerechtenFromRestaurantID(int id)
        {
            return context.GetAllGerechtenFromRestaurantID(id);
        }

        public List<Gerecht> GetAllGerechtenAndRondesFromOrderId(int id)
        {
            return context.GetAllGerechtenAndRondesFromOrderId(id);
        }
    }
}
