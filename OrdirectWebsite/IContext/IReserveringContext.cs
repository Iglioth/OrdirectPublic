using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsOrdirect
{
    public interface IReserveringContext
    {
        bool CreateReservering(DateTime datum, int RestaurantID, int AccountID);

        List<Reservering> GetReserveringenById(int id);

        bool CheckDuplicateReservering(int Restaurantid, int AccountId);


        Reservering GetReserveringByAccountAndRestaurantAndDate(int accountID, int restaurantID, string dtp);
        Reservering GetReserveringById(string text);
    }
}
