using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdirectWebsite.Converters
{
    public class BestellingConverter
    {
        public BestellingDetailViewModel ModelToViewModel(Bestelling b)
        {
            return new BestellingDetailViewModel
            {
                Aantal = b.Aantal,
                GerechtID = b.GerechtID,
                ReserveringID = b.ReserveringID,
                Ronde = b.Ronde
            };
        }

        public Bestelling ViewModelToModel(BestellingDetailViewModel vm)
        {
            return new Bestelling
            {
                Aantal = vm.Aantal,
                GerechtID = vm.GerechtID,
                ReserveringID = vm.ReserveringID,
                Ronde = vm.Ronde
            };
        }
    }
}
