using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsOrdirect
{
    public partial class LogInScreen : Form
    {
        public AccountController ac = new AccountController();
        public LogInScreen()
        {
            InitializeComponent();
        }

        private void BRegistreer_Click(object sender, EventArgs e)
        {
            string Email = TBEmailRegistreren.Text;
            string Wachtwoord = TBWachtwoordRegistreren.Text;
            string Voornaam = TBVoornaamRegistreren.Text;
            string Achternaam = TBAchternaamRegistreren.Text;
            string RestaurantID = null;
            string Rol = "Klant";
            if(ac.CreateAccount(Voornaam, Achternaam, Wachtwoord, Email, RestaurantID, Rol) == true)
            {
                this.Hide();
                FOrdirect mainform = new FOrdirect(Email);
                mainform.Show();
            }
            else
            {
                MessageBox.Show("Registratie gefaald");
            }

        }

        private void BLogIn_Click(object sender, EventArgs e)
        {
            string Email = TBEmailLogIn.Text;
            string Wachtwoord = TBWachtwoordInloggen.Text;
            Account a = ac.GetAccountByEmail(Email);

            if(a != null && Email == a.Email && Wachtwoord == a.Wachtwoord)
            {
                FOrdirect fOrdirect = new FOrdirect(Email);
                fOrdirect.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}
