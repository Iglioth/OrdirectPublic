using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordirect.Core
{
    public interface IBestellingContext
    {
        bool InsertBestelling(int ReserveringID, int GerechtID, int Ronde, int Aanatal);
        List<Bestelling> GetBestellingen(int ReserveringID);
        bool CheckRonde(int ronde, int reserveringID);
        List<int> GetDistinctRondes(int reserveringID);
        List<Gerecht> GetGerechtenUitBestelling(int reserveringID, int ronde);
        List<Gerecht> GetHuidigeBestellingGerechtenMinimaal(int reserveringID);
        bool BumpBestellingUp(int gerechtID, int reserveringId);
        bool BumpbestellingDown(int gerechtid, int reserveringId);
        bool DeleteBestelling(int reserveringId, int gerechtID);
    }
}
