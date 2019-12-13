using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrdirectWebsite
{
    public class ReserveringMSSQLContext : BaseMSSQLContext, IReserveringContext
    {
        public bool AccepteerReservering(int reserveringId)
        {
            string sql = "Update Reservering Set Status = 'Geaccepteerd' Where ReserveringID = @ReserveringId";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("ReserveringId", reserveringId);
            bool result = GetBoolSql(sql, parameters);
            return result;
        }

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

        public bool DeleteReservering(int id)
        {
            string sql = "Delete From Reservering Where ReserveringID = @ReserveringId";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("ReserveringId", id);
            bool result = GetBoolSql(sql, parameters);
            return result;
        }

        public Reservering GetReserveringByAccountAndRestaurantAndDate(int accountID, int restaurantID, string dtp)
        {
            string sql = "select * from Reservering Where AccountID = @AccountID and RestaurantID = @RestaurantID and Datum = @datum + ':00.000' ";
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
                return null;
            }
            return r;
            
        }

        public Reservering GetReserveringById(int id)
        {
            string sql = "Select * From Reservering Where ReserveringID = @reserveringID";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("reserveringID", id);
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

            string sql = "Select R.ReserveringID, R.Datum, R.Status, R.RestaurantID, R.AccountID, A.Naam From Reservering R inner join Restaurant A on R.RestaurantID = A.RestaurantID where AccountID = @id";
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
                return null;
            }
            return reserveringen;
        }

        public List<Reservering> GetReserveringenByRestaurantId(int restaurantId)
        {
            List<Reservering> reserveringen = new List<Reservering>();

            string sql = "Select R.ReserveringID, R.Datum, R.Status, R.RestaurantID, R.AccountID, A.Voornaam, A.Achternaam From Reservering R inner join Account A on R.AccountID = A.AccountID where R.RestaurantID = @id";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("id", restaurantId);

            DataSet results = GetDataSetSql(sql, parameters);

            if (results != null && results.Tables[0].Rows.Count > 0)
            {
                for (int x = 0; x < results.Tables[0].Rows.Count; x++)
                {
                    Reservering r = DataSetParser.DataSetToRestaurantReservering(results, x);
                    reserveringen.Add(r);
                }
            }
            else
            {
                return null;
            }
            return reserveringen;
        }

        public bool OpenReservering(int reserveringId)
        {
            string sql = "Update Reservering Set Status = 'Open' Where ReserveringID = @ReserveringId";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("ReserveringId", reserveringId);
            bool result = GetBoolSql(sql, parameters);
            return result;
        }

        public bool SluitReservering(int reserveringId)
        {
            string sql = "Update Reservering Set Status = 'Gesloten' Where ReserveringID = @ReserveringId";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("ReserveringId", reserveringId);
            bool result = GetBoolSql(sql, parameters);
            return result;
        }
    }
}
