using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdirectWebsite
{
    public class ReserveringConverter : IViewModelConverterContext<Reservering, ReserveringDetailViewModel>
    {
        public Reservering DetailViewModelToModel(ReserveringDetailViewModel vm)
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

        public List<ReserveringDetailViewModel> ModelsToViewModel(List<Reservering> ms)
        {
            List<ReserveringDetailViewModel> reserveringDetailViewModels = new List<ReserveringDetailViewModel>();

            foreach (Reservering r in ms)
            {
                reserveringDetailViewModels.Add(
                    new ReserveringDetailViewModel
                    {
                        KlantID = r.KlantID,
                        ReserveringID = r.ReserveringID,
                        RestaurantID = r.RestaurantID,
                        datetime = r.datetime,
                        Status = r.Status
                    });

            }
            return reserveringDetailViewModels;
        }

        public ReserveringDetailViewModel ModelToDetailViewModel(Reservering r)
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



        public List<Reservering> ViewModelToModels(List<ReserveringDetailViewModel> vms)
        {
            List<Reservering> reserveringen = new List<Reservering>();

            foreach (ReserveringDetailViewModel vm in vms)
            {
                reserveringen.Add(
                    new Reservering
                    {
                        KlantID = vm.KlantID,
                        ReserveringID = vm.ReserveringID,
                        RestaurantID = vm.RestaurantID,
                        datetime = vm.datetime,
                        Status = vm.Status
                    });
            }

            return reserveringen;
        }
    }
}
