using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsOrdirect
{
    public class ReserveringMSSQLContext : BaseMSSQLContext, IReserveringContext
    {
        public bool CheckDuplicateReservering(int Restaurantid, int Accountid)
        {
            string sql = "Select * from Reservering where RestaurantID = @RestaurantId and AccountID = @AccountId";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("RestaurantID", Restaurantid);
            parameters.Add("AccountID", Accountid);
            bool result = GetBoolSql(sql, parameters);
            return result;
        }



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

        public Reservering GetReserveringByAccountAndRestaurantAndDate(int accountID, int restaurantID, string dtp)
        {
            string sql = "select * from Reservering Where AccountID = @AccountID and RestaurantID = @RestaurantID and Datum = @datum + '.000' ";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("RestaurantID", restaurantID);
            parameters.Add("AccountID", accountID);
            parameters.Add("datum", dtp);
            DataSet results = GetDataSetSql(sql, parameters);

            Reservering r = new Reservering();
            if (results != null && results.Tables[0].Rows.Count == 1)
            {
                r = DataSetParser.DataSetToReservering(results, 0);
            }
            else
            {
                MessageBox.Show("Too many/few data found.");
            }
            return r;
        }

        public Reservering GetReserveringById(string text)
        {
            string sql = "Select * From Reservering Where ReserveringID = @reserveringID";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("reserveringID", text);
            Reservering r = new Reservering();
            DataSet results = GetDataSetSql(sql, parameters);
            if (results != null && results.Tables[0].Rows.Count > 0)
            {
                r = DataSetParser.DataSetToReservering(results, 0);
            }
            else return null;

            return r;
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
            else
            {
                MessageBox.Show("Reserveringen Not Found in Database!");
            }
            return reserveringen;
        }


    }
}
