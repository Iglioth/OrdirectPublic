using FormsOrdirect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsOrdirect
{
    public interface IBestellingContext
    {
        bool InsertBestelling(int GerechtID, int ReserveringID, int Ronde, int Aanatal);

        List<Bestelling> GetBestellingen(int ReserveringID);

        bool CheckRonde(int ronde, int reserveringID);

    }
} 
