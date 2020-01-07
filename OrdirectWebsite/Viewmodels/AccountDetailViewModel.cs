using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdirectWebsite
{
    public class AccountDetailViewModel
    {
        public int AccountID { get; set; }
        public string Email { get; set; }
        public string Wachtwoord { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Rol { get; set; }
        public int RestaurantID { get; set; }
    }
}
