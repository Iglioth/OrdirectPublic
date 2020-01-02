using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace OrdirectWebsite
{
    class DataSetParser
    {
        public static Account DataSetToAccount(DataSet set, int rowIndex)
        {
            if (string.IsNullOrEmpty(set.Tables[0].Rows[rowIndex][4].ToString()))
            {
                return new Account()
                {
                    AccountID = (int)set.Tables[0].Rows[rowIndex][0],
                    Wachtwoord = set.Tables[0].Rows[rowIndex][1].ToString(),
                    Voornaam = set.Tables[0].Rows[rowIndex][2].ToString(),
                    Achternaam = set.Tables[0].Rows[rowIndex][3].ToString(),
                    Email = set.Tables[0].Rows[rowIndex][5].ToString(),
                    Rol = set.Tables[0].Rows[rowIndex][6].ToString()
                };
            }
            else
            {
                return new Account()
                {
                    AccountID = (int)set.Tables[0].Rows[rowIndex][0],
                    Wachtwoord = set.Tables[0].Rows[rowIndex][1].ToString(),
                    Voornaam = set.Tables[0].Rows[rowIndex][2].ToString(),
                    Achternaam = set.Tables[0].Rows[rowIndex][3].ToString(),
                    RestaurantID = (int)set.Tables[0].Rows[rowIndex][4],
                    Email = set.Tables[0].Rows[rowIndex][5].ToString(),
                    Rol = set.Tables[0].Rows[rowIndex][6].ToString()
                };
            }

        }
        
        internal static Gerecht DataSetToMinimalGerecht(DataSet ds, int rowIndex)
        {
            return new Gerecht()
            {
                GerechtID = (int)ds.Tables[0].Rows[rowIndex][0],
                Naam = ds.Tables[0].Rows[rowIndex][1].ToString()
            };
        }

        internal static Gerecht DataSetToGerecht(DataSet ds, int rowIndex)
        {
            return new Gerecht()
            {
                GerechtID = (int)ds.Tables[0].Rows[rowIndex][0],
                RestaurantID = (int)ds.Tables[0].Rows[rowIndex][1],
                Descriptie = ds.Tables[0].Rows[rowIndex][3].ToString(),
                Naam = ds.Tables[0].Rows[rowIndex][4].ToString()
            };
        }

        internal static Gerecht DataSetToGerechtWithRonde(DataSet ds, int rowIndex)
        {
            return new Gerecht()
            {
                GerechtID = (int)ds.Tables[0].Rows[rowIndex][0],
                RestaurantID = (int)ds.Tables[0].Rows[rowIndex][1],
                Descriptie = ds.Tables[0].Rows[rowIndex][3].ToString(),
                Naam = ds.Tables[0].Rows[rowIndex][4].ToString(),
                Ronde = (int)ds.Tables[0].Rows[rowIndex][5]
            };
        }

        internal static Bestelling DataSetToBestelling(DataSet results, int x)
        {
            return new Bestelling()
            {
                ReserveringID = (int)results.Tables[0].Rows[x][0],
                GerechtID = (int)results.Tables[0].Rows[x][1],
                Aantal = (int)results.Tables[0].Rows[x][2],
                Ronde = (int)results.Tables[0].Rows[x][3]
            };
        }

        public static Restaurant DataSetToRestaurant(DataSet set, int rowIndex)
        {
            return new Restaurant()
            {
                RestaurantID = (int)set.Tables[0].Rows[rowIndex][0],
                Naam = set.Tables[0].Rows[rowIndex][1].ToString(),
                Adres = set.Tables[0].Rows[rowIndex][2].ToString(),
                Telefoonnummer = set.Tables[0].Rows[rowIndex][3].ToString(),

            };
        }

        public static Reservering DataSetToReservering(DataSet results, int x)
        {
            return new Reservering()
            {
                ReserveringID = (int)results.Tables[0].Rows[x][0],
                datetime = (DateTime)results.Tables[0].Rows[x][1],
                Status = results.Tables[0].Rows[x][2].ToString(),
                RestaurantID = (int)results.Tables[0].Rows[x][3],
                KlantID = (int)results.Tables[0].Rows[x][4],
                RestaurantNaam = results.Tables[0].Rows[x][5].ToString(),
            };
        }

        public static Reservering DataSetToRestaurantReservering(DataSet results, int x)
        {
            return new Reservering()
            {
                ReserveringID = (int)results.Tables[0].Rows[x][0],
                datetime = (DateTime)results.Tables[0].Rows[x][1],
                Status = results.Tables[0].Rows[x][2].ToString(),
                RestaurantID = (int)results.Tables[0].Rows[x][3],
                KlantID = (int)results.Tables[0].Rows[x][4],
                KlantVoorNaam = results.Tables[0].Rows[x][5].ToString(),
                KlantAchterNaam = results.Tables[0].Rows[x][6].ToString()
            };
            
        }
    }
}
