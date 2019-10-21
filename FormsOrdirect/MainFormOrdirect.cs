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
    public partial class FOrdirect : Form
    {
        AccountController ac = new AccountController();
        RestaurantController rc = new RestaurantController();
        ReserveringController rvc = new ReserveringController();
        public FOrdirect(string Email)
        {
            InitializeComponent();
            LoadLists(Email);
        }

        public void LoadLists(string Email)
        {
            List<Restaurant> restaurants = rc.GetAllRestaurants();
            foreach (Restaurant r in restaurants)
            {
                LBRestaurants.Items.Add(r.Naam);
            }
            Account a = ac.GetAccountByEmail(Email);
            List<Reservering> reserveringen = rvc.GetReserveringenById(a.AccountID);
            foreach (Reservering r in reserveringen)
            {
                LBReserveringen.Items.Add("Restaurant " + rc.GetRestaurantByID(r.RestaurantID).Naam + " Om: " + r.datetime.ToString());
            }
            LNaamOutput.Text = Email;
            LNaamOutput.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Restaurant r = rc.GetRestaurantByName(LBRestaurants.Text.ToString());
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            LOutputNaam.Text = r.Naam.ToString();
            LOutputNaam.Visible = true;
            LOutputAdres.Text = r.Adres.ToString();
            LOutputAdres.Visible = true;
            LOutputTelefoonnummer.Text = r.Telefoonnummer.ToString();
            LOutputTelefoonnummer.Visible = true;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BReserveer_Click(object sender, EventArgs e)
        {
            string Email = LNaamOutput.Text;
            string RestaurantName = LBRestaurants.Text.ToString();
            string Date = DTPDate.Value.ToShortDateString();
            string Time = DTPTime.Value.ToShortTimeString();
            string datetime = Date + " " + Time + ":00";
            DateTime dateTime = Convert.ToDateTime(datetime);
            Restaurant r = rc.GetRestaurantByName(RestaurantName);
            Account a = ac.GetAccountByEmail(Email);// Moet nog gefixt worden.
            if(rvc.CreateReservering(dateTime, r.RestaurantID, a.AccountID) == true)
            {
                LVerificatie.Text = "Reservering Aangemaakt";
                LVerificatie.Visible = true;
            }
            else
            {
                LVerificatie.Text = "Reservering Mislukt :(";
                LVerificatie.Visible = true;
            }
        }

        private void DTPDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LRol_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TPReserveringen_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TPRestaurants_Click(object sender, EventArgs e)
        {

            
        }

        private void FOrdirect_Load(object sender, EventArgs e)
        {

        }

        private void LNaamOutput_Click(object sender, EventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadLists(LNaamOutput.Text);
        }

        private void LBReserveringen_SelectedIndexChanged(object sender, EventArgs e)
        {
            string RestaurantString = LBReserveringen.Text.Split(' ')[1];
            Restaurant r = rc.GetRestaurantByName(RestaurantString);
            GBRestaurantDetailsReserveringen.Visible = true;
            LNaamOutputReserveringen.Text = r.Naam.ToString();
            LNaamOutputReserveringen.Visible = true;
            LAdresOutputReserveringen.Text = r.Adres.ToString();
            LAdresOutputReserveringen.Visible = true;
            LTelefoonNummerOutputReserveringen.Text = r.Telefoonnummer.ToString();
            LTelefoonNummerOutputReserveringen.Visible = true;
        }

        private void BNaarOrder_Click(object sender, EventArgs e)
        {
            rc.GetRestaurantByName(LNaamOutputReserveringen.Text);
            
        }
    }
}
