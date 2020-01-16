using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordirect.Core
{
    public class BestellingMSSQLContext : BaseMSSQLContext, IBestellingContext
    {
        public BestellingMSSQLContext(string connectionString) : base(connectionString)
        {

        }

        public bool InsertBestelling(int reserveringID, int gerechtID, int ronde, int v)
        {
            string sql = "insert into GerechtReservering (ReserveringID, GerechtID, Aantal, Ronde) Values (@reserveringID, @gerechtID, @aantal, @ronde)";
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
            string sql = "Select GerechtReservering.ReserveringID, GerechtReservering.GerechtID, GerechtReservering.Aantal, GerechtReservering.Ronde, Gerecht.Naam from GerechtReservering inner join Gerecht on GerechtReservering.GerechtID = Gerecht.GerechtID where ReserveringID = @reserveringID";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("reserveringID", ReserveringID);
            DataSet results = GetDataSetSql(sql, parameters);
            List<Bestelling> Bestellingen = new List<Bestelling>();
            if (results != null && results.Tables[0].Rows.Count > 0)
            {
                for (int x = 0; x < results.Tables[0].Rows.Count; x++)
                {
                    Bestelling b = DataSetParser.DataSetToBestelling(results, x);
                    Bestellingen.Add(b);
                }
            }
            else return null;

            return Bestellingen;
        }

        public List<Bestelling> GetOpenBestellingen(int ReserveringID)
        {
            string sql = "Select GerechtReservering.ReserveringID, GerechtReservering.GerechtID, GerechtReservering.Aantal, GerechtReservering.Ronde, Gerecht.Naam from GerechtReservering inner join Gerecht on GerechtReservering.GerechtID = Gerecht.GerechtID where ReserveringID = @reserveringID and Status = 'Open'";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("reserveringID", ReserveringID);
            DataSet results = GetDataSetSql(sql, parameters);
            List<Bestelling> Bestellingen = new List<Bestelling>();
            if (results != null && results.Tables[0].Rows.Count > 0)
            {
                for (int x = 0; x < results.Tables[0].Rows.Count; x++)
                {
                    Bestelling b = DataSetParser.DataSetToBestelling(results, x);
                    Bestellingen.Add(b);
                }
            }
            else return null;

            return Bestellingen;
        }



        //public bool CheckRonde(int ronde, int reserveringID)
        //{
        //    string sql = "Select Ronde from GerechtReservering where ReserveringID = @ReserveringId and Ronde = @Ronde";
        //    Dictionary<object, object> parameters = new Dictionary<object, object>();
        //    parameters.Add("ReserveringId", reserveringID);
        //    parameters.Add("Ronde", ronde);
        //    DataSet results = GetDataSetSql(sql, parameters);
        //    if (results.Tables[0].Rows.Count == 0)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        public List<int> GetDistinctRondes(int reserveringID)
        {
            List<int> Rondes = new List<int>();

            string sql = "Select Distinct Ronde From GerechtReservering Where ReserveringID = @ReserveringId Order By Ronde Asc";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("ReserveringId", reserveringID);

            DataSet results = GetDataSetSql(sql, parameters);
            if (results != null && results.Tables[0].Rows.Count > 0)
            {
                for (int x = 0; x < results.Tables[0].Rows.Count; x++)
                {
                    Rondes.Add((int)results.Tables[0].Rows[x][0]);
                }
            }
            else
            {
                return null;
            }
            return Rondes;
        }

        public List<Gerecht> GetGerechtenUitBestelling(int reserveringID, int ronde)
        {
            List<Gerecht> GerechtenUitBestelling = new List<Gerecht>();
            string sql = "Select GerechtReservering.GerechtID, Gerecht.Naam, GerechtReservering.Aantal From (GerechtReservering INNER JOIN Gerecht ON GerechtReservering.GerechtID = Gerecht.GerechtID) Where GerechtReservering.ReserveringID = @ReserveringId AND GerechtReservering.Ronde = @ronde ";
            Dictionary<object, object> Parameters = new Dictionary<object, object>();
            Parameters.Add("ReserveringId", reserveringID);
            Parameters.Add("ronde", ronde);

            DataSet Results = GetDataSetSql(sql, Parameters);
            if (Results != null && Results.Tables[0].Rows.Count > 0)
            {
                for (int x = 0; x < Results.Tables[0].Rows.Count; x++)
                {
                    GerechtenUitBestelling.Add(DataSetParser.DataSetToMinimalGerecht(Results, x));
                }
            }

            return GerechtenUitBestelling;
        }

        //public List<Gerecht> GetHuidigeBestellingGerechtenMinimaal(int reserveringID)
        //{
        //    string sql = "Select GerechtID From GerechtReservering Where Ronde = 0 and ReserveringID = @id";
        //    Dictionary<object, object> parameters = new Dictionary<object, object>();
        //    parameters.Add("id", reserveringID);

        //    List<Gerecht> MinGerechten = new List<Gerecht>();
        //    DataSet Results = GetDataSetSql(sql, parameters);
        //    if (Results != null && Results.Tables[0].Rows.Count > 0)
        //    {
        //        for (int x = 0; x < Results.Tables[0].Rows.Count; x++)
        //        {
        //            MinGerechten.Add(DataSetParser.DataSetToMinimalGerecht(Results, x));
        //        }
        //    }
        //    return MinGerechten;
        //}

        public bool BumpBestellingUp(int gerechtid, int reserveringId)
        {
            string sql = "Update GerechtReservering Set Aantal = Aantal + 1 Where GerechtId = @gerechtid And ReserveringId = @reserveringid And Ronde = 0";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("reserveringid", reserveringId);
            parameters.Add("gerechtid", gerechtid);

            bool Succes = GetBoolSql(sql, parameters);
            return Succes;
        }

        public bool BumpbestellingDown(int gerechtid, int reserveringid)
        {
            string sql = "Update GerechtReservering Set Aantal = Aantal - 1 Where GerechtId = @gerechtid And ReserveringId = @reserveringid And Ronde = 0";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("reserveringid", reserveringid);
            parameters.Add("gerechtid", gerechtid);


            bool Succes = GetBoolSql(sql, parameters);
            return Succes;
        }

        public bool DeleteBestelling(int reserveringid, int gerechtid)
        {
            string sql = "Delete From GerechtReservering Where ReserveringId = @reserveringid And GerechtId = @gerechtid And Ronde = 0";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("reserveringid", reserveringid);
            parameters.Add("gerechtid", gerechtid);

            bool Succes = GetBoolSql(sql, parameters);

            return Succes;
        }

        public bool UpdateBestelling(int reserveringID, int gerechtID, int nieuweRonde, int aantal, string Naam, string Status, int ouderonde)
        {
            string sql = "Update GerechtReservering SET Ronde = @ronde, Status = @Status Where ReserveringID = @reserveringid and GerechtID = @gerechtid and Aantal = @aantal and Ronde = @ouderonde ";
            Dictionary<object, object> parameters = new Dictionary<object, object>();
            parameters.Add("reserveringID", reserveringID);
            parameters.Add("gerechtID", gerechtID);
            parameters.Add("aantal", aantal);
            parameters.Add("ronde", nieuweRonde);
            parameters.Add("Status", Status);
            parameters.Add("ouderonde", ouderonde);

            bool result = GetBoolSql(sql, parameters);
            return result;
        }
    }
}
