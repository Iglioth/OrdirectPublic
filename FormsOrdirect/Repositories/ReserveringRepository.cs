using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsOrdirect
{
    public class ReserveringRepository
    {
        IReserveringContext Context;

        public ReserveringRepository(IReserveringContext context)
        {
            Context = context;
        }

        public bool CreateReservering(DateTime datum, int restaurantID, int KlantID)
        {
            return Context.CreateReservering(datum, restaurantID, KlantID);
        }

        public List<Reservering> GetReserveringenByEmail(int id)
        {
            return Context.GetReserveringenById(id);
        }

        /*internal Reservering GetReserveringByAccountAndRestaurant(int accountID, int restaurantID)
        {
            //return Context.GetReserveringByAccountAndRestaurant()
        }*/
    }
}
