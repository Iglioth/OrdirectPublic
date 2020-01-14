using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordirect.Core
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
            if (Check == true)
            {
                return Context.CreateReservering(datum, restaurantID, KlantID);
            }
            else
            {
                return false;
            }
        }

        public List<Reservering> GetReserveringenById(int id)
        {
            return Context.GetReserveringenById(id);
        }

        public Reservering GetReserveringByAccountAndRestaurantAndDate(int accountID, int restaurantID, string dtp)
        {
            return Context.GetReserveringByAccountAndRestaurantAndDate(accountID, restaurantID, dtp);
        }

        public Reservering GetReserveringById(int id)
        {
            return Context.GetReserveringById(id);
        }

        public bool DeleteReservering(int id)
        {
            
            if (Context.DeleteReservering(id))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public List<Reservering> GetReserveringenByRestaurantId(int RestaurantId)
        {
            List<Reservering> ReserveringenVanRestaurant = Context.GetReserveringenByRestaurantId(RestaurantId);
            if (ReserveringenVanRestaurant != null)
            {
                return ReserveringenVanRestaurant;
            }
            else
                return null;
        }

        public bool OpenReservering(int reserveringId)
        {
            if (Context.OpenReservering(reserveringId))
            {
                return true;
            }
            else
                return false;
        }

        public bool SluitReservering(int reserveringId)
        {
            if (Context.SluitReservering(reserveringId))
            {
                return true;
            }
            else
                return false;
        }

        public bool AccepteerReservering(int reserveringId)
        {
            if (Context.AccepteerReservering(reserveringId))
            {
                return true;
            }
            else
                return false;
        }

        public bool EindigReservering(int reserveringID)
        {
            if (Context.EindigReservering(reserveringID))
            {
                return true;
            }
            else
                return false;

        }

        public List<Reservering> GetOpenReserveringenByRestaurantId(int id)
        {
            return Context.GetOpenReserveringenByRestaurantId(id);
        }

        public int GetOpenBestellingenFromReservering(int reserveringID)
        {
            return Context.GetOpenBestellingenFromReservering(reserveringID).Count;
        }
    }
}
