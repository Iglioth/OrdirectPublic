using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FormsOrdirect
{
    class AccountMSSQLContext :  BaseMSSQLContext, IAccountContext
    {


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

        public Account GetAccountByEmail(string Email)
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

            return a;

        }

        public bool CreateAccount(string Voornaam, string Achternaam, string Email, string Wachtwoord, string RestaurantID, string Rol)
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
    }
}
