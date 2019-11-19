using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdirectWebsite
{
    public class ReserveringConverter
    {
        public ReserveringDetailViewModel ModelToViewModel(Reservering r)
        {
            return new ReserveringDetailViewModel
            {
                KlantID = r.KlantID,
                ReserveringID = r.ReserveringID,
                RestaurantID = r.RestaurantID,
                datetime = r.datetime,
                Status = r.Status
            };
        }

        public Reservering ViewModelToModel(ReserveringDetailViewModel vm)
        {
            return new Reservering
            {
                KlantID = vm.KlantID,
                ReserveringID = vm.ReserveringID,
                RestaurantID = vm.RestaurantID,
                datetime = vm.datetime,
                Status = vm.Status
            };
        }
    }
}
