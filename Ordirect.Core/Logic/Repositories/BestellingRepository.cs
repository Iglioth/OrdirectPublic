using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordirect.Core
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

        public List<int> GetDistinctRondes(int reserveringID)
        {
            return BestellingContext.GetDistinctRondes(reserveringID);
        }

        public List<Gerecht> GetGerechtenUitBestelling(int reserveringID, int ronde)
        {
            return BestellingContext.GetGerechtenUitBestelling(reserveringID, ronde);
        }

        //public List<Gerecht> GetHuidigeBestelling(int reserveringID)
        //{
        //    List<Gerecht> MinGerechten = BestellingContext.GetHuidigeBestellingGerechtenMinimaal(reserveringID);
        //    List<Gerecht> FullGerechten = new List<Gerecht>();

        //    foreach (Gerecht g in MinGerechten)
        //    {
        //        Gerecht gerecht = new Gerecht();
        //        gerecht = GerechtContext.GetGerechtById(g.GerechtID);
        //        FullGerechten.Add(gerecht);
        //    }

        //    return FullGerechten;
        //}

        public bool BumpBestellingUp(int gerechtID, int reserveringId)
        {
            return BestellingContext.BumpBestellingUp(gerechtID, reserveringId);
        }

        public bool BumpBestellingDown(int reserveringId, int gerechtid)
        {
            return BestellingContext.BumpbestellingDown(gerechtid, reserveringId);
        }

        public bool DeleteBestelling(int reserveringId, int gerechtID)
        {
            return BestellingContext.DeleteBestelling(reserveringId, gerechtID);
        }

        public bool UpdateBestelling(int reserveringID, int gerechtID, int nieuweRonde, int aantal, string naam, string Status, int ouderonde)
        {
            return BestellingContext.UpdateBestelling(reserveringID, gerechtID, nieuweRonde, aantal, naam, Status, ouderonde);
        }

        public List<Bestelling> GetOpenBestellingen(int reserveringID)
        {
            return BestellingContext.GetOpenBestellingen(reserveringID);
        }
    }
}
