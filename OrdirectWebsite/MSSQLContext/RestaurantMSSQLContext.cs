using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace OrdirectWebsite
{
    public class RestaurantMSSQLContext : BaseMSSQLContext, IRestaurantContext
    {

        public List<Restaurant> GetGlobalRestaurants()
        {
            string sql = "Select * From restaurant";
            Dictionary<object, object> parameters = new Dictionary<object, object>();

            DataSet results = GetDataSetSql(sql, parameters);
            List<Restaurant> restaurants = new List<Restaurant>();

            if (results != null && results.Tables[0].Rows.Count > 0)
            {
                for(int x = 0; x < results.Tables[0].Rows.Count; x++)
                {
                    Restaurant r = DataSetParser.DataSetToRestaurant(results, x);
                    restaurants.Add(r);
                }
            }

            return restaurants;
        }

        public Restaurant GetRestaurantByName(string Name)
        {
            string sql = "Select * From restaurant where Naam like @name";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("name", Name);


            DataSet results = GetDataSetSql(sql, parameters);
            Restaurant r = null;

            if (results != null && results.Tables[0].Rows.Count == 1)
            {
                r = DataSetParser.DataSetToRestaurant(results, 0);
            }

            return r;
        }

        public Restaurant GetRestaurantByID(int id)
        {
            string sql = "Select * From restaurant where RestaurantID = @id";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("id", id.ToString());
 
            DataSet results = GetDataSetSql(sql, parameters);
            Restaurant r = null;

            if (results != null && results.Tables[0].Rows.Count == 1)
            {
                r = DataSetParser.DataSetToRestaurant(results, 0);
            }
            return r;

        }
    }
}
