using FormsOrdirect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsOrdirect
{
    public class BestellingRepository
    {
        IBestellingContext Context;

        public BestellingRepository(IBestellingContext orderContext)
        {
            Context = orderContext;
        }

        public bool InsertBestelling(int ReserveringID, int GerechtID, int Ronde, int Aantal)
        {
            return Context.InsertBestelling(ReserveringID, GerechtID, Ronde, Aantal);
        }

        public List<Bestelling> GetBestellingen(int ReserveringID)
        {
            return Context.GetBestellingen(ReserveringID);
        }

        public bool CheckRonde(int ronde, int reserveringID)
        {
            return Context.CheckRonde(ronde, reserveringID);
        }
    }
}
