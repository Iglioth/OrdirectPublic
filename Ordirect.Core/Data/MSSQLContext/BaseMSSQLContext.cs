using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ordirect.Core
{
    public class BaseMSSQLContext
    {
        public string connectionString = @"Server = mssql.fhict.local; Database = dbi390337_rdirect; User Id = dbi390337_rdirect; Password = mnm626466;";

        public DataSet GetDataSetSql(string sql, Dictionary<object, object> parameters)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = conn.CreateCommand();
                
                foreach (KeyValuePair<object, object> kvp in parameters)
                {
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@" + kvp.Key ;
                    param.Value = kvp.Value;
                    cmd.Parameters.Add(param);
                }

                cmd.CommandText = sql;
                da.SelectCommand = cmd;

                conn.Open();
                da.Fill(ds);
                conn.Close();
            }
            catch (Exception ex)
            {
                return null;
            }

            return ds;
        }

        public bool GetBoolSql(string sql, Dictionary<object, object> parameters)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = conn.CreateCommand();

                foreach (KeyValuePair<object, object> kvp in parameters)
                {
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@" + kvp.Key;
                    param.Value = kvp.Value;
                    cmd.Parameters.Add(param);
                }

                cmd.CommandText = sql;
                da.SelectCommand = cmd;

                conn.Open();
                da.Fill(ds);
                conn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

    }
}
