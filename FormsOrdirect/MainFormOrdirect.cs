﻿using System;
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
        GerechtController gc = new GerechtController();
        public FOrdirect(string Email)
        {
            InitializeComponent();
            LoadLists(Email);
        }

        public void LoadLists(string Email)
        {
            LBRestaurants.Items.Clear();
            LBReserveringen.Items.Clear();
            List<Restaurant> restaurants = rc.GetAllRestaurants();
            foreach (Restaurant r in restaurants)
            {
                LBRestaurants.Items.Add(r.Naam);
            }
            Account a = ac.GetAccountByEmail(Email);
            List<Reservering> reserveringen = rvc.GetReserveringenById(a.AccountID);
            foreach (Reservering r in reserveringen)
            {
                Restaurant Res = new Restaurant();
                Res = rc.GetRestaurantByID(r.RestaurantID);
                LBReserveringen.Items.Add(Res.RestaurantID + " Restaurant " + Res.Naam + " Om: " + r.datetime.ToString());
            }
            LNaamOutput.Text = Email;
            LNaamOutput.Visible = true;
        }

        public void LoadRestaurants(string Email)
        {
            LBRestaurants.Items.Clear();

            List<Restaurant> restaurants = rc.GetAllRestaurants();
            foreach (Restaurant r in restaurants)
            {
                LBRestaurants.Items.Add(r.Naam);
            }
        }

        public void LoadReserveringenFromUser(string Email)
        {
            Account a = ac.GetAccountByEmail(Email);
            List<Reservering> reserveringen = rvc.GetReserveringenById(a.AccountID);
            foreach (Reservering r in reserveringen)
            {
                Restaurant Res = new Restaurant();
                Res = rc.GetRestaurantByID(r.RestaurantID);
                LBReserveringen.Items.Add(Res.RestaurantID + " Restaurant: " + Res.Naam + " Om: " + r.datetime.ToString());
            }
            LNaamOutput.Text = Email;
            LNaamOutput.Visible = true;
        }

        public void LoadGerechtenFromRestaurant(int RestaurantID)
        {


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
            TCOrdirect.SelectTab(1);
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
            int RestaurantID = Convert.ToInt32(LBReserveringen.Text.Split(' ')[0]);
            Restaurant r = rc.GetRestaurantByID(RestaurantID);
            GBRestaurantDetailsReserveringen.Visible = true;
            LRestaurantIDOutputReserveringen.Text = r.RestaurantID.ToString();
            LRestaurantIDOutputReserveringen.Visible = true;
            LNaamOutputReserveringen.Text = r.Naam.ToString();
            LNaamOutputReserveringen.Visible = true;
            LAdresOutputReserveringen.Text = r.Adres.ToString();
            LAdresOutputReserveringen.Visible = true;
            LTelefoonNummerOutputReserveringen.Text = r.Telefoonnummer.ToString();
            LTelefoonNummerOutputReserveringen.Visible = true;
        }

        private void BNaarOrder_Click(object sender, EventArgs e)
        {
            Restaurant r = new Restaurant();
            r = rc.GetRestaurantByID(Convert.ToInt32(LRestaurantIDOutputReserveringen.Text));
            LGerechtenRestaurantOutputNaam.Text = LBReserveringen.Text ;
            LGerechtenRestaurantOutputNaam.Visible = true;
            TCOrdirect.SelectTab(2);
            List<Gerecht> Gerechten = new List<Gerecht>();
            Gerechten = gc.GetAllGerechtenFromRestaurantID(Convert.ToInt32(LGerechtenRestaurantOutputNaam.Text.Split(' ')[0]));
            foreach(Gerecht gerecht in Gerechten)
            {
                LBGerechten.Items.Add(gerecht.GerechtID + " " +  gerecht.Naam);
            }
        }

        private void LGerechtenRestaurantOutputNaam_Click(object sender, EventArgs e)
        {

        }

        private void LBGerechten_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gerecht g = new Gerecht();
            string ActiveGerecht = LBGerechten.SelectedItem.ToString();
            int id = Convert.ToInt32(ActiveGerecht.Split(' ')[0]);
            g = gc.GetGerechtById(id);
            LGerechtenOutputNaam.Text = g.Naam;
            LGerechtenOutputNaam.Visible = true;
            RTBGerechtDetails.Text = g.Descriptie;
            //PBGerechtDetails.Image

            GBGerechtDetails.Visible = true;
        }

        private void BToevoegen_Click(object sender, EventArgs e)
        {
            foreach(string item in LBGerechten.CheckedItems)
            {
                LBHuidigeBestelling.Items.Add(item);
            }

        }

        private void BBestellingToevoegen_Click(object sender, EventArgs e)
        {
            DateTime dtp = Convert.ToDateTime(LGerechtenRestaurantOutputNaam.Text.Split(' ').Last());
            int RestaurantID = Convert.ToInt32(LGerechtenRestaurantOutputNaam.Text.Split(' ')[0]);
            int AccountID = Convert.ToInt32(ac.GetAccountByEmail(LNaamOutput.Text).AccountID);
            Reservering r = rvc.GetReserveringByAccountAndRestaurantAndDate(AccountID, RestaurantID, dtp);
            int Ronde = 1;
            bool RondeCheck = true;
            while(RondeCheck == true){
                RondeCheck = rvc.CheckRonde(Ronde, r.ReserveringID);
                Ronde++;
            }
            foreach (string item in LBHuidigeBestelling.Items)
            {
                string GerechtID;
            }
        }
    }
}
