using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdirectWebsite
{
    public interface IBestellingContext
    {
        bool InsertBestelling(int ReserveringID, int GerechtID, int Ronde, int Aanatal);

        List<Bestelling> GetBestellingen(int ReserveringID);

        bool CheckRonde(int ronde, int reserveringID);
        List<int> GetDistinctRondes(int reserveringID);
        List<Gerecht> GetGerechtenUitBestelling(int reserveringID, int ronde);
    }
}
