using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrdirectWebsite
{
    public class ReserveringController
    {
        ReserveringRepository repo;
        IReserveringContext context;



        public ReserveringController()
        {
            context = new ReserveringMSSQLContext();
            repo = new ReserveringRepository(context);
        }

        public bool CreateReservering(DateTime date, int ReserveringID, int KlantID)
        {
            bool result = repo.CreateReservering(date, ReserveringID, KlantID);
            return result;
        }

        public List<Reservering> GetReserveringenById(int id)
        {
            List<Reservering> reserveringen = repo.GetReserveringenByEmail(id);
            return reserveringen;
        }



        internal Reservering GetReserveringByAccountAndRestaurantAndDate(int accountID, int restaurantID, string dt)
        {
            Reservering r = repo.GetReserveringByAccountAndRestaurantAndDate(accountID, restaurantID, dt);
            return r;
        }

        internal Reservering GetReserveringById(string text)
        {
            return repo.GetReserveringById(text);
        }
    }
}
