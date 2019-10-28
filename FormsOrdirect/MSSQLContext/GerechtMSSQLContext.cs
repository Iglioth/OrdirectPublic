using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsOrdirect
{
    public class GerechtMSSQLContext : BaseMSSQLContext, IGerechtContext
    {
        public Gerecht GetGerechtById(int id)
        {
            string sql = "select * from Gerecht where GerechtID = @ID";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("ID", id);

            int x = 0;
            DataSet ds = GetDataSetSql(sql, parameters);
            Gerecht g = DataSetParser.DataSetToGerecht(ds, x);
            return g;
        }

        public Gerecht GetGerechtByRondeAndGerechtIdAndOrderId(int ronde, int GerechtId, int OrderId)
        {
            string sql = "Select * From Gerecht Where GerechtId = (Select GerechtId From GerechtOrder where Ronde = @ronde And GerechtID = @id and OrderId = @OrderId)";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("ronde", ronde);
            parameters.Add("id", GerechtId);
            parameters.Add("OrderId", OrderId);

            DataSet set = GetDataSetSql(sql, parameters);
            Gerecht g = null;

            if (set != null && set.Tables[0].Rows.Count >= 1)
            {
                g = DataSetParser.DataSetToGerecht(set, 0);
            }

            return g;
        }   

        public List<Gerecht> GetAllGerechtenFromRestaurantID(int id)
        {
            string sql = "select * from Gerecht where RestaurantID = @Id";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("Id", id);
            List<Gerecht> gerechten = new List<Gerecht>();
            DataSet set = GetDataSetSql(sql, parameters);

            if (set != null && set.Tables[0].Rows.Count >= 1)
            {
                for (int x = 0; x < set.Tables[0].Rows.Count; x++)
                {
                    gerechten.Add(DataSetParser.DataSetToGerecht(set, x));
                }
            }

            else
            {
                MessageBox.Show("No Data Found from GetAllGerechtenFromRestaurant Query");
            }
            return gerechten;
        }

        public List<Gerecht> GetAllGerechtenAndRondesFromOrderId(int id)
        {
            string sql = "select Gerecht.GerechtID, Gerecht.RestaurantID, Gerecht.Descriptie, Gerecht.Naam, GerechtOrder.Ronde From Gerecht" +
                         " Inner Join GerechtOrder On Gerecht.GerechtID = GerechtOrder.GerechtID Where GerechtOrder.OrderID = @id";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("id", id);

            List<Gerecht> gerechten = new List<Gerecht>();
            DataSet set = GetDataSetSql(sql, parameters);

            if (set != null && set.Tables[0].Rows.Count >= 1)
            {
                for (int x = 0; x < set.Tables[0].Rows.Count; x++)
                {
                    gerechten.Add(DataSetParser.DataSetToGerechtWithRonde(set, x));
                }
            }

            else
            {
                MessageBox.Show("No Data Found from GetAllGerechtenAndRondesFromOrderId");
            }

            return gerechten;
        }

        public bool BestellingMaken(int ReserveringID, int GerechtID, int Aantal, int BestellingNummer)
        {
            throw new NotImplementedException();
        }
    }
}
