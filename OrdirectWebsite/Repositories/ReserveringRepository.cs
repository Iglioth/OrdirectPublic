using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdirectWebsite
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
            bool Check = Context.CheckDuplicateReservering(restaurantID, KlantID);
            if(Check == true)
            {
                return Context.CreateReservering(datum, restaurantID, KlantID);
            }
            else
            {
                return false;
            }
        }

        

        public List<Reservering> GetReserveringenByEmail(int id)
        {
            return Context.GetReserveringenById(id);
        }




        internal Reservering GetReserveringByAccountAndRestaurantAndDate(int accountID, int restaurantID, string dtp )
        {
            return Context.GetReserveringByAccountAndRestaurantAndDate(accountID, restaurantID, dtp);
        }

        internal Reservering GetReserveringById(string text)
        {
            return Context.GetReserveringById(text);
        }
    }
}
