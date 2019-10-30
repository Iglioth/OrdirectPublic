﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsOrdirect
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

        internal bool CheckRonde(int ronde, int reserveringID)
        {
            return repo.CheckRonde(ronde, reserveringID);
        }

        internal Reservering GetReserveringByAccountAndRestaurantAndDate(int accountID, int restaurantID, DateTime dt)
        {
            Reservering r = repo.GetReserveringByAccountAndRestaurantAndDate(accountID, restaurantID, dt);
            return r;
        }
    }
}
