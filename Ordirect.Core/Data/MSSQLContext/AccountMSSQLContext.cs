using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Ordirect.Core
{
    public class AccountMSSQLContext :  BaseMSSQLContext, IAccountContext
    {
        public AccountMSSQLContext(string connectionString) : base(connectionString)
        {

        }

        public Account GetAccountByID(int id)
        {
            string sql = "Select * From Account where AccountID= @id";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("id", id.ToString());

            DataSet results = GetDataSetSql(sql, parameters);
            Account a = null;

            if (results != null && results.Tables[0].Rows.Count > 0)
            {
                a = DataSetParser.DataSetToAccount(results, 0);
            }

            return a;

        }

        public Account Check(string Email)
        {
            string sql = "Select * From Account where Email = @Email";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("Email", Email.ToString());

            DataSet results = GetDataSetSql(sql, parameters);
            Account a = null;

            if (results != null && results.Tables[0].Rows.Count > 0)
            {
                a = DataSetParser.DataSetToAccount(results, 0);
            }
            else
            {
                return null;
            }
            return a;

        }

        public bool CreateAccount(string Voornaam, string Achternaam, string Email, string Wachtwoord, int RestaurantID, string Rol)
        {
            string sql = "Insert Into Account(Voornaam, Achternaam, Email, Wachtwoord, Rol) Values (@voornaam, @achternaam, @email, @wachtwoord, @Rol)";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("voornaam", Voornaam);
            parameters.Add("achternaam", Achternaam);
            parameters.Add("email", Email);
            parameters.Add("wachtwoord", Wachtwoord);
            parameters.Add("Rol", Rol);


            bool result = GetBoolSql(sql, parameters);
            return result;
        }

        public bool UpdateAccount(string voornaam, string achternaam, string wachtwoord, int id)
        {
            string sql = "Update Account Set Voornaam = @voornaam, Achternaam = @achternaam, Wachtwoord = @wachtwoord Where AccountID = @id";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("voornaam", voornaam);
            parameters.Add("achternaam", achternaam);
            parameters.Add("id", id);
            parameters.Add("wachtwoord", wachtwoord);

            bool result = GetBoolSql(sql, parameters);
            return result;
        }

        public List<Account> GetAll()
        {
            string sql = "Select * From Account";
            Dictionary<object, object> parameters = new Dictionary<object, object>();

            DataSet results = GetDataSetSql(sql, parameters);
            List<Account> Accounts = new List<Account>();
            if (results != null && results.Tables[0].Rows.Count > 0)
            {
                for (int x = 0; x < results.Tables[0].Rows.Count; x++)
                {
                    Account a = DataSetParser.DataSetToAccount(results, x);
                    Accounts.Add(a);
                }
            }
            else return null;

            return Accounts;

        }

        public List<Account> GetRestaurantAccounts(string v)
        {
            string sql = "Get * From Account Where RestaurantID = @restaurantid";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("restaurantid", v);

            DataSet results = GetDataSetSql(sql, parameters);
            List<Account> Accounts = new List<Account>();
            if (results != null && results.Tables[0].Rows.Count > 0)
            {
                for (int x = 0; x < results.Tables[0].Rows.Count; x++)
                {
                    Account a = DataSetParser.DataSetToAccount(results, x);
                    Accounts.Add(a);
                }
            }
            else return null;

            return Accounts;
        }

        public bool DeleteAccount(int id)
        {
            throw new NotImplementedException();
        }
    }
}
