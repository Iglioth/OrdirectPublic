using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsOrdirect
{
    public class ReserveringMSSQLContext : BaseMSSQLContext, IReserveringContext
    {
        public bool CreateReservering(DateTime datum, int RestaurantID, int AccountID)
        {
                string sql = "Insert Into Reservering (Datum, Status, RestaurantID, AccountID) Values (@datum, 'Pending', @RestaurantID, @AccountID)";
                Dictionary<object, object> parameters = new Dictionary<object, object>();
                parameters.Add("datum", datum);
                parameters.Add("RestaurantID", RestaurantID);
                parameters.Add("AccountID", AccountID);
                bool result = GetBoolSql(sql, parameters);
                return result;
        }

        public List<Reservering> GetReserveringenById(int id)
        {
            List<Reservering> reserveringen = new List<Reservering>();

            string sql = "select * from Reservering where AccountID = @id";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("id", id);

            DataSet results = GetDataSetSql(sql, parameters);

            if (results != null && results.Tables[0].Rows.Count > 0)
            {
                for (int x = 0; x < results.Tables[0].Rows.Count; x++)
                {
                    Reservering r = DataSetParser.DataSetToReservering(results, x);
                    reserveringen.Add(r);
                }
            }

            return reserveringen;
        }
    }
}
