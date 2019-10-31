using FormsOrdirect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsOrdirect
{
    public class BestellingController
    {
        BestellingRepository repo;
        IBestellingContext context;

        public BestellingController()
        {
            context = new BestellingMSSQLContext();
            repo = new BestellingRepository(context);
        }

        public bool InsertBestelling(int gerechtID, int reserveringID, int ronde, int v)
        {
            return repo.InsertBestelling(gerechtID, reserveringID, ronde, v);
        }

        public bool CheckRonde(int ronde, int reserveringID)
        {
            return repo.CheckRonde(ronde, reserveringID);
        }

        internal List<Bestelling> GetBestellingen(int reserveringID)
        {
            return repo.GetBestellingen(reserveringID);
        }
    }
}
