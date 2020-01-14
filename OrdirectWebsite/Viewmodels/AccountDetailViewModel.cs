using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrdirectWebsite
{
    public class AccountDetailViewModel
    {
        public int AccountID { get; set; }
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Wachtwoord { get; set; }

        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Rol { get; set; }
        public int RestaurantID { get; set; }
        public int OpenBestellingen { get; set; }
    }
}
