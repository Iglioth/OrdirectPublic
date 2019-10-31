using FormsOrdirect.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsOrdirect
{
    public class BestellingMSSQLContext : BaseMSSQLContext, IBestellingContext
    {
        public bool InsertBestelling(int gerechtID, int reserveringID, int ronde, int v)
        {
            string sql = "insert into (ReserveringID, GerechtID, Aantal, Ronde) GerechtReservering Values (ReserveringID = @reserveringID, " +
                "GerechtID = @gerechtID, Aantal = @aantal, Ronde = @ronde";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("reserveringID", reserveringID);
            parameters.Add("gerechtID", gerechtID);
            parameters.Add("aantal", v);
            parameters.Add("ronde", ronde);

            bool result = GetBoolSql(sql, parameters);
            return result;
        }

        public List<Bestelling> GetBestellingen(int ReserveringID)
        {
            string sql = "Select * From GerechtReservering Where ReserveringID = reserveringID";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("reserveringID", ReserveringID);
            DataSet results = GetDataSetSql(sql, parameters);
            List<Bestelling> Bestellingen = new List<Bestelling>();
            if (results != null && results.Tables[0].Rows.Count > 0)
            {
                for(int x = 0; x < results.Tables[0].Rows.Count; x++)
                {
                    Bestelling b = DataSetParser.DataSetToBestelling(results, x);
                    Bestellingen.Add(b);
                }
            }
            else return null;

            return Bestellingen;
        }

        public bool CheckRonde(int ronde, int reserveringID)
        {
            string sql = "Select Ronde from GerechtReservering where ReserveringID = @ReserveringId and Ronde = @Ronde";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("ReserveringId", reserveringID);
            parameters.Add("Ronde", ronde);
            bool result = GetBoolSql(sql, parameters);
            if(result == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
