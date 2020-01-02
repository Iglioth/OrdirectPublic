using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdirectWebsite
{
    public class BestellingRepository
    {
        IBestellingContext BestellingContext;
        IGerechtContext GerechtContext;
        public BestellingRepository(IBestellingContext bestellingContext, IGerechtContext gerechtContext)
        {
            BestellingContext = bestellingContext;
            GerechtContext = gerechtContext;
        }

        public bool InsertBestelling(int ReserveringID, int GerechtID, int Ronde, int Aantal)
        {
            return BestellingContext.InsertBestelling(ReserveringID, GerechtID, Ronde, Aantal);
        }

        public List<Bestelling> GetBestellingen(int ReserveringID)
        {
            return BestellingContext.GetBestellingen(ReserveringID);
        }

        public bool CheckRonde(int ronde, int reserveringID)
        {
            return BestellingContext.CheckRonde(ronde, reserveringID);
        }

        internal List<int> GetDistinctRondes(int reserveringID)
        {
            return BestellingContext.GetDistinctRondes(reserveringID);
        }

        internal List<Gerecht> GetGerechtenUitBestelling(int reserveringID, int ronde)
        {
            return BestellingContext.GetGerechtenUitBestelling(reserveringID, ronde);
        }

        internal List<Gerecht> GetHuidigeBestelling(int reserveringID)
        {
            List<Gerecht> MinGerechten = BestellingContext.GetHuidigeBestellingGerechtenMinimaal(reserveringID);
            List<Gerecht> FullGerechten = new List<Gerecht>();

            foreach(Gerecht g in MinGerechten)
            {
                FullGerechten.Add(GerechtContext.GetGerechtById(g.GerechtID));
            }

            return FullGerechten;
        }

        internal void BumpBestellingUp(int gerechtID, int reserveringId)
        {
            BestellingContext.BumpBestellingUp(gerechtID, reserveringId);
        }

        internal void BumpBestellingDown(int reserveringId, int gerechtid)
        {
            throw new NotImplementedException();
        }
    }
}
