using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordirect.Core
{
    public interface IReserveringContext
    {
        bool CreateReservering(DateTime datum, int RestaurantID, int AccountID);

        List<Reservering> GetReserveringenById(int id);

        bool CheckDuplicateReservering(int Restaurantid, int AccountId);

        Reservering GetReserveringByAccountAndRestaurantAndDate(int accountID, int restaurantID, string dtp);

        Reservering GetReserveringById(int id);
        bool DeleteReservering(int id);
        List<Reservering> GetReserveringenByRestaurantId(int restaurantId);
        bool OpenReservering(int reserveringId);
        bool SluitReservering(int reserveringId);
        bool AccepteerReservering(int reserveringId);
        bool EindigReservering(int reserveringID);
    }
}
