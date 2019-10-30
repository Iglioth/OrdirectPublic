namespace FormsOrdirect
{
    partial class FOrdirect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBRestaurants = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LOutputTelefoonnummer = new System.Windows.Forms.Label();
            this.LOutputAdres = new System.Windows.Forms.Label();
            this.LOutputNaam = new System.Windows.Forms.Label();
            this.LTelefoonNummer = new System.Windows.Forms.Label();
            this.LAdres = new System.Windows.Forms.Label();
            this.Lnaam = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LVerificatie = new System.Windows.Forms.Label();
            this.BReserveer = new System.Windows.Forms.Button();
            this.DTPTime = new System.Windows.Forms.DateTimePicker();
            this.LDatum = new System.Windows.Forms.Label();
            this.DTPDate = new System.Windows.Forms.DateTimePicker();
            this.LTijd = new System.Windows.Forms.Label();
            this.TCOrdirect = new System.Windows.Forms.TabControl();
            this.TPRestaurants = new System.Windows.Forms.TabPage();
            this.TPReserveringen = new System.Windows.Forms.TabPage();
            this.GBRestaurantDetailsReserveringen = new System.Windows.Forms.GroupBox();
            this.LRestaurantIdReserveringen = new System.Windows.Forms.Label();
            this.LRestaurantIDOutputReserveringen = new System.Windows.Forms.Label();
            this.BNaarOrder = new System.Windows.Forms.Button();
            this.LTelefoonNummerOutputReserveringen = new System.Windows.Forms.Label();
            this.LAdresOutputReserveringen = new System.Windows.Forms.Label();
            this.LNaamOutputReserveringen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LNaamReserveringen = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LBReserveringen = new System.Windows.Forms.ListBox();
            this.TPOrder = new System.Windows.Forms.TabPage();
            this.LReserveringNummerGerechten = new System.Windows.Forms.Label();
            this.LGerechtenRestaurantOutputNaam = new System.Windows.Forms.Label();
            this.LOrderRestaurantNaam = new System.Windows.Forms.Label();
            this.GBBestellingen = new System.Windows.Forms.GroupBox();
            this.LBestellingGerechten = new System.Windows.Forms.Label();
            this.LBBestellingGerechten = new System.Windows.Forms.ListBox();
            this.BBestellingToevoegen = new System.Windows.Forms.Button();
            this.LBHuidigeBestelling = new System.Windows.Forms.ListBox();
            this.LBBestellingen = new System.Windows.Forms.ListBox();
            this.GBGerechten = new System.Windows.Forms.GroupBox();
            this.GBGerechtDetails = new System.Windows.Forms.GroupBox();
            this.LGerechtenOutputNaam = new System.Windows.Forms.Label();
            this.PBGerechtDetails = new System.Windows.Forms.PictureBox();
            this.GBDescription = new System.Windows.Forms.GroupBox();
            this.RTBGerechtDetails = new System.Windows.Forms.RichTextBox();
            this.LGerechtNaam = new System.Windows.Forms.Label();
            this.BToevoegen = new System.Windows.Forms.Button();
            this.LBGerechten = new System.Windows.Forms.CheckedListBox();
            this.LRol = new System.Windows.Forms.Label();
            this.LNaamOutput = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.LVerificatieLogInSuccesvol = new System.Windows.Forms.Label();
            this.LReserveringNummer = new System.Windows.Forms.Label();
            this.LReserveringNummerOutputGerechten = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.TCOrdirect.SuspendLayout();
            this.TPRestaurants.SuspendLayout();
            this.TPReserveringen.SuspendLayout();
            this.GBRestaurantDetailsReserveringen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.TPOrder.SuspendLayout();
            this.GBBestellingen.SuspendLayout();
            this.GBGerechten.SuspendLayout();
            this.GBGerechtDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBGerechtDetails)).BeginInit();
            this.GBDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBRestaurants
            // 
            this.LBRestaurants.FormattingEnabled = true;
            this.LBRestaurants.Location = new System.Drawing.Point(6, 14);
            this.LBRestaurants.Name = "LBRestaurants";
            this.LBRestaurants.Size = new System.Drawing.Size(120, 407);
            this.LBRestaurants.TabIndex = 0;
            this.LBRestaurants.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LOutputTelefoonnummer);
            this.groupBox1.Controls.Add(this.LOutputAdres);
            this.groupBox1.Controls.Add(this.LOutputNaam);
            this.groupBox1.Controls.Add(this.LTelefoonNummer);
            this.groupBox1.Controls.Add(this.LAdres);
            this.groupBox1.Controls.Add(this.Lnaam);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(144, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 188);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restaurant Details:";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LOutputTelefoonnummer
            // 
            this.LOutputTelefoonnummer.AutoSize = true;
            this.LOutputTelefoonnummer.Location = new System.Drawing.Point(120, 153);
            this.LOutputTelefoonnummer.Name = "LOutputTelefoonnummer";
            this.LOutputTelefoonnummer.Size = new System.Drawing.Size(98, 13);
            this.LOutputTelefoonnummer.TabIndex = 6;
            this.LOutputTelefoonnummer.Text = "<Telefoonnummer>";
            this.LOutputTelefoonnummer.Visible = false;
            // 
            // LOutputAdres
            // 
            this.LOutputAdres.AutoSize = true;
            this.LOutputAdres.Location = new System.Drawing.Point(67, 97);
            this.LOutputAdres.Name = "LOutputAdres";
            this.LOutputAdres.Size = new System.Drawing.Size(46, 13);
            this.LOutputAdres.TabIndex = 5;
            this.LOutputAdres.Text = "<Adres>";
            this.LOutputAdres.Visible = false;
            // 
            // LOutputNaam
            // 
            this.LOutputNaam.AutoSize = true;
            this.LOutputNaam.Location = new System.Drawing.Point(68, 42);
            this.LOutputNaam.Name = "LOutputNaam";
            this.LOutputNaam.Size = new System.Drawing.Size(47, 13);
            this.LOutputNaam.TabIndex = 4;
            this.LOutputNaam.Text = "<Naam>";
            this.LOutputNaam.Visible = false;
            // 
            // LTelefoonNummer
            // 
            this.LTelefoonNummer.AutoSize = true;
            this.LTelefoonNummer.Location = new System.Drawing.Point(25, 153);
            this.LTelefoonNummer.Name = "LTelefoonNummer";
            this.LTelefoonNummer.Size = new System.Drawing.Size(89, 13);
            this.LTelefoonNummer.TabIndex = 3;
            this.LTelefoonNummer.Text = "Telefoonnummer:";
            // 
            // LAdres
            // 
            this.LAdres.AutoSize = true;
            this.LAdres.Location = new System.Drawing.Point(24, 97);
            this.LAdres.Name = "LAdres";
            this.LAdres.Size = new System.Drawing.Size(37, 13);
            this.LAdres.TabIndex = 2;
            this.LAdres.Text = "Adres:";
            // 
            // Lnaam
            // 
            this.Lnaam.AutoSize = true;
            this.Lnaam.Location = new System.Drawing.Point(24, 42);
            this.Lnaam.Name = "Lnaam";
            this.Lnaam.Size = new System.Drawing.Size(38, 13);
            this.Lnaam.TabIndex = 1;
            this.Lnaam.Text = "Naam:";
            this.Lnaam.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(450, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 160);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LVerificatie);
            this.groupBox2.Controls.Add(this.BReserveer);
            this.groupBox2.Controls.Add(this.DTPTime);
            this.groupBox2.Controls.Add(this.LDatum);
            this.groupBox2.Controls.Add(this.DTPDate);
            this.groupBox2.Controls.Add(this.LTijd);
            this.groupBox2.Location = new System.Drawing.Point(144, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(632, 208);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reservering aanmaken:";
            this.groupBox2.Visible = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // LVerificatie
            // 
            this.LVerificatie.AutoSize = true;
            this.LVerificatie.Location = new System.Drawing.Point(470, 101);
            this.LVerificatie.Name = "LVerificatie";
            this.LVerificatie.Size = new System.Drawing.Size(58, 13);
            this.LVerificatie.TabIndex = 11;
            this.LVerificatie.Text = "<Succes!>";
            this.LVerificatie.Visible = false;
            // 
            // BReserveer
            // 
            this.BReserveer.Location = new System.Drawing.Point(304, 137);
            this.BReserveer.Name = "BReserveer";
            this.BReserveer.Size = new System.Drawing.Size(75, 23);
            this.BReserveer.TabIndex = 10;
            this.BReserveer.Text = "Reserveer";
            this.BReserveer.UseVisualStyleBackColor = true;
            this.BReserveer.Click += new System.EventHandler(this.BReserveer_Click);
            // 
            // DTPTime
            // 
            this.DTPTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTPTime.Location = new System.Drawing.Point(62, 94);
            this.DTPTime.Name = "DTPTime";
            this.DTPTime.Size = new System.Drawing.Size(200, 20);
            this.DTPTime.TabIndex = 9;
            // 
            // LDatum
            // 
            this.LDatum.AutoSize = true;
            this.LDatum.Location = new System.Drawing.Point(15, 38);
            this.LDatum.Name = "LDatum";
            this.LDatum.Size = new System.Drawing.Size(41, 13);
            this.LDatum.TabIndex = 8;
            this.LDatum.Text = "Datum:";
            // 
            // DTPDate
            // 
            this.DTPDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDate.Location = new System.Drawing.Point(62, 32);
            this.DTPDate.Name = "DTPDate";
            this.DTPDate.Size = new System.Drawing.Size(200, 20);
            this.DTPDate.TabIndex = 7;
            this.DTPDate.ValueChanged += new System.EventHandler(this.DTPDate_ValueChanged);
            // 
            // LTijd
            // 
            this.LTijd.AutoSize = true;
            this.LTijd.Location = new System.Drawing.Point(15, 100);
            this.LTijd.Name = "LTijd";
            this.LTijd.Size = new System.Drawing.Size(27, 13);
            this.LTijd.TabIndex = 6;
            this.LTijd.Text = "Tijd:";
            // 
            // TCOrdirect
            // 
            this.TCOrdirect.Controls.Add(this.TPRestaurants);
            this.TCOrdirect.Controls.Add(this.TPReserveringen);
            this.TCOrdirect.Controls.Add(this.TPOrder);
            this.TCOrdirect.Location = new System.Drawing.Point(1, 60);
            this.TCOrdirect.Name = "TCOrdirect";
            this.TCOrdirect.SelectedIndex = 0;
            this.TCOrdirect.Size = new System.Drawing.Size(801, 474);
            this.TCOrdirect.TabIndex = 8;
            // 
            // TPRestaurants
            // 
            this.TPRestaurants.BackColor = System.Drawing.Color.Khaki;
            this.TPRestaurants.Controls.Add(this.groupBox1);
            this.TPRestaurants.Controls.Add(this.groupBox2);
            this.TPRestaurants.Controls.Add(this.LBRestaurants);
            this.TPRestaurants.Location = new System.Drawing.Point(4, 22);
            this.TPRestaurants.Name = "TPRestaurants";
            this.TPRestaurants.Padding = new System.Windows.Forms.Padding(3);
            this.TPRestaurants.Size = new System.Drawing.Size(793, 448);
            this.TPRestaurants.TabIndex = 0;
            this.TPRestaurants.Text = "Restaurants";
            this.TPRestaurants.Click += new System.EventHandler(this.TPRestaurants_Click);
            // 
            // TPReserveringen
            // 
            this.TPReserveringen.BackColor = System.Drawing.Color.PaleGreen;
            this.TPReserveringen.Controls.Add(this.GBRestaurantDetailsReserveringen);
            this.TPReserveringen.Controls.Add(this.LBReserveringen);
            this.TPReserveringen.Location = new System.Drawing.Point(4, 22);
            this.TPReserveringen.Name = "TPReserveringen";
            this.TPReserveringen.Padding = new System.Windows.Forms.Padding(3);
            this.TPReserveringen.Size = new System.Drawing.Size(793, 448);
            this.TPReserveringen.TabIndex = 1;
            this.TPReserveringen.Text = "Reserveringen";
            this.TPReserveringen.Click += new System.EventHandler(this.TPReserveringen_Click);
            // 
            // GBRestaurantDetailsReserveringen
            // 
            this.GBRestaurantDetailsReserveringen.Controls.Add(this.LReserveringNummerOutputGerechten);
            this.GBRestaurantDetailsReserveringen.Controls.Add(this.LReserveringNummer);
            this.GBRestaurantDetailsReserveringen.Controls.Add(this.LRestaurantIdReserveringen);
            this.GBRestaurantDetailsReserveringen.Controls.Add(this.LRestaurantIDOutputReserveringen);
            this.GBRestaurantDetailsReserveringen.Controls.Add(this.BNaarOrder);
            this.GBRestaurantDetailsReserveringen.Controls.Add(this.LTelefoonNummerOutputReserveringen);
            this.GBRestaurantDetailsReserveringen.Controls.Add(this.LAdresOutputReserveringen);
            this.GBRestaurantDetailsReserveringen.Controls.Add(this.LNaamOutputReserveringen);
            this.GBRestaurantDetailsReserveringen.Controls.Add(this.label4);
            this.GBRestaurantDetailsReserveringen.Controls.Add(this.label5);
            this.GBRestaurantDetailsReserveringen.Controls.Add(this.LNaamReserveringen);
            this.GBRestaurantDetailsReserveringen.Controls.Add(this.pictureBox2);
            this.GBRestaurantDetailsReserveringen.Location = new System.Drawing.Point(254, 18);
            this.GBRestaurantDetailsReserveringen.Name = "GBRestaurantDetailsReserveringen";
            this.GBRestaurantDetailsReserveringen.Size = new System.Drawing.Size(522, 188);
            this.GBRestaurantDetailsReserveringen.TabIndex = 2;
            this.GBRestaurantDetailsReserveringen.TabStop = false;
            this.GBRestaurantDetailsReserveringen.Text = "Restaurant Details:";
            this.GBRestaurantDetailsReserveringen.Visible = false;
            // 
            // LRestaurantIdReserveringen
            // 
            this.LRestaurantIdReserveringen.AutoSize = true;
            this.LRestaurantIdReserveringen.Location = new System.Drawing.Point(23, 43);
            this.LRestaurantIdReserveringen.Name = "LRestaurantIdReserveringen";
            this.LRestaurantIdReserveringen.Size = new System.Drawing.Size(104, 13);
            this.LRestaurantIdReserveringen.TabIndex = 10;
            this.LRestaurantIdReserveringen.Text = "Restaurant Nummer:";
            // 
            // LRestaurantIDOutputReserveringen
            // 
            this.LRestaurantIDOutputReserveringen.AutoSize = true;
            this.LRestaurantIDOutputReserveringen.Location = new System.Drawing.Point(133, 43);
            this.LRestaurantIDOutputReserveringen.Name = "LRestaurantIDOutputReserveringen";
            this.LRestaurantIDOutputReserveringen.Size = new System.Drawing.Size(30, 13);
            this.LRestaurantIDOutputReserveringen.TabIndex = 9;
            this.LRestaurantIDOutputReserveringen.Text = "<ID>";
            this.LRestaurantIDOutputReserveringen.Visible = false;
            // 
            // BNaarOrder
            // 
            this.BNaarOrder.Location = new System.Drawing.Point(242, 159);
            this.BNaarOrder.Name = "BNaarOrder";
            this.BNaarOrder.Size = new System.Drawing.Size(75, 23);
            this.BNaarOrder.TabIndex = 8;
            this.BNaarOrder.Text = "Order";
            this.BNaarOrder.UseVisualStyleBackColor = true;
            this.BNaarOrder.Click += new System.EventHandler(this.BNaarOrder_Click);
            // 
            // LTelefoonNummerOutputReserveringen
            // 
            this.LTelefoonNummerOutputReserveringen.AutoSize = true;
            this.LTelefoonNummerOutputReserveringen.Location = new System.Drawing.Point(120, 153);
            this.LTelefoonNummerOutputReserveringen.Name = "LTelefoonNummerOutputReserveringen";
            this.LTelefoonNummerOutputReserveringen.Size = new System.Drawing.Size(98, 13);
            this.LTelefoonNummerOutputReserveringen.TabIndex = 6;
            this.LTelefoonNummerOutputReserveringen.Text = "<Telefoonnummer>";
            this.LTelefoonNummerOutputReserveringen.Visible = false;
            // 
            // LAdresOutputReserveringen
            // 
            this.LAdresOutputReserveringen.AutoSize = true;
            this.LAdresOutputReserveringen.Location = new System.Drawing.Point(67, 97);
            this.LAdresOutputReserveringen.Name = "LAdresOutputReserveringen";
            this.LAdresOutputReserveringen.Size = new System.Drawing.Size(46, 13);
            this.LAdresOutputReserveringen.TabIndex = 5;
            this.LAdresOutputReserveringen.Text = "<Adres>";
            this.LAdresOutputReserveringen.Visible = false;
            // 
            // LNaamOutputReserveringen
            // 
            this.LNaamOutputReserveringen.AutoSize = true;
            this.LNaamOutputReserveringen.Location = new System.Drawing.Point(67, 69);
            this.LNaamOutputReserveringen.Name = "LNaamOutputReserveringen";
            this.LNaamOutputReserveringen.Size = new System.Drawing.Size(47, 13);
            this.LNaamOutputReserveringen.TabIndex = 4;
            this.LNaamOutputReserveringen.Text = "<Naam>";
            this.LNaamOutputReserveringen.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefoonnummer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Adres:";
            // 
            // LNaamReserveringen
            // 
            this.LNaamReserveringen.AutoSize = true;
            this.LNaamReserveringen.Location = new System.Drawing.Point(23, 69);
            this.LNaamReserveringen.Name = "LNaamReserveringen";
            this.LNaamReserveringen.Size = new System.Drawing.Size(38, 13);
            this.LNaamReserveringen.TabIndex = 1;
            this.LNaamReserveringen.Text = "Naam:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(334, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 160);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // LBReserveringen
            // 
            this.LBReserveringen.FormattingEnabled = true;
            this.LBReserveringen.Location = new System.Drawing.Point(7, 14);
            this.LBReserveringen.Name = "LBReserveringen";
            this.LBReserveringen.Size = new System.Drawing.Size(241, 407);
            this.LBReserveringen.TabIndex = 1;
            this.LBReserveringen.SelectedIndexChanged += new System.EventHandler(this.LBReserveringen_SelectedIndexChanged);
            // 
            // TPOrder
            // 
            this.TPOrder.BackColor = System.Drawing.Color.Pink;
            this.TPOrder.Controls.Add(this.LReserveringNummerGerechten);
            this.TPOrder.Controls.Add(this.LGerechtenRestaurantOutputNaam);
            this.TPOrder.Controls.Add(this.LOrderRestaurantNaam);
            this.TPOrder.Controls.Add(this.GBBestellingen);
            this.TPOrder.Controls.Add(this.GBGerechten);
            this.TPOrder.Location = new System.Drawing.Point(4, 22);
            this.TPOrder.Name = "TPOrder";
            this.TPOrder.Size = new System.Drawing.Size(793, 448);
            this.TPOrder.TabIndex = 2;
            this.TPOrder.Text = "Order";
            // 
            // LReserveringNummerGerechten
            // 
            this.LReserveringNummerGerechten.AutoSize = true;
            this.LReserveringNummerGerechten.Location = new System.Drawing.Point(542, 6);
            this.LReserveringNummerGerechten.Name = "LReserveringNummerGerechten";
            this.LReserveringNummerGerechten.Size = new System.Drawing.Size(101, 13);
            this.LReserveringNummerGerechten.TabIndex = 4;
            this.LReserveringNummerGerechten.Text = "Reserveringnummer";
            // 
            // LGerechtenRestaurantOutputNaam
            // 
            this.LGerechtenRestaurantOutputNaam.AutoSize = true;
            this.LGerechtenRestaurantOutputNaam.Location = new System.Drawing.Point(78, 6);
            this.LGerechtenRestaurantOutputNaam.Name = "LGerechtenRestaurantOutputNaam";
            this.LGerechtenRestaurantOutputNaam.Size = new System.Drawing.Size(111, 13);
            this.LGerechtenRestaurantOutputNaam.TabIndex = 3;
            this.LGerechtenRestaurantOutputNaam.Text = "<<RestaurantNaam>>";
            this.LGerechtenRestaurantOutputNaam.Visible = false;
            this.LGerechtenRestaurantOutputNaam.Click += new System.EventHandler(this.LGerechtenRestaurantOutputNaam_Click);
            // 
            // LOrderRestaurantNaam
            // 
            this.LOrderRestaurantNaam.AutoSize = true;
            this.LOrderRestaurantNaam.Location = new System.Drawing.Point(10, 6);
            this.LOrderRestaurantNaam.Name = "LOrderRestaurantNaam";
            this.LOrderRestaurantNaam.Size = new System.Drawing.Size(62, 13);
            this.LOrderRestaurantNaam.TabIndex = 2;
            this.LOrderRestaurantNaam.Text = "Restaurant:";
            // 
            // GBBestellingen
            // 
            this.GBBestellingen.Controls.Add(this.LBestellingGerechten);
            this.GBBestellingen.Controls.Add(this.LBBestellingGerechten);
            this.GBBestellingen.Controls.Add(this.BBestellingToevoegen);
            this.GBBestellingen.Controls.Add(this.LBHuidigeBestelling);
            this.GBBestellingen.Controls.Add(this.LBBestellingen);
            this.GBBestellingen.Location = new System.Drawing.Point(7, 233);
            this.GBBestellingen.Name = "GBBestellingen";
            this.GBBestellingen.Size = new System.Drawing.Size(778, 209);
            this.GBBestellingen.TabIndex = 0;
            this.GBBestellingen.TabStop = false;
            this.GBBestellingen.Text = "Bestellingen";
            // 
            // LBestellingGerechten
            // 
            this.LBestellingGerechten.AutoSize = true;
            this.LBestellingGerechten.Location = new System.Drawing.Point(394, 55);
            this.LBestellingGerechten.Name = "LBestellingGerechten";
            this.LBestellingGerechten.Size = new System.Drawing.Size(60, 13);
            this.LBestellingGerechten.TabIndex = 6;
            this.LBestellingGerechten.Text = "Gerechten:";
            // 
            // LBBestellingGerechten
            // 
            this.LBBestellingGerechten.FormattingEnabled = true;
            this.LBBestellingGerechten.Location = new System.Drawing.Point(394, 71);
            this.LBBestellingGerechten.Name = "LBBestellingGerechten";
            this.LBBestellingGerechten.Size = new System.Drawing.Size(98, 134);
            this.LBBestellingGerechten.TabIndex = 5;
            // 
            // BBestellingToevoegen
            // 
            this.BBestellingToevoegen.Location = new System.Drawing.Point(209, 184);
            this.BBestellingToevoegen.Name = "BBestellingToevoegen";
            this.BBestellingToevoegen.Size = new System.Drawing.Size(75, 23);
            this.BBestellingToevoegen.TabIndex = 3;
            this.BBestellingToevoegen.Text = "Bestellen";
            this.BBestellingToevoegen.UseVisualStyleBackColor = true;
            this.BBestellingToevoegen.Click += new System.EventHandler(this.BBestellingToevoegen_Click);
            // 
            // LBHuidigeBestelling
            // 
            this.LBHuidigeBestelling.FormattingEnabled = true;
            this.LBHuidigeBestelling.Location = new System.Drawing.Point(6, 19);
            this.LBHuidigeBestelling.Name = "LBHuidigeBestelling";
            this.LBHuidigeBestelling.Size = new System.Drawing.Size(120, 186);
            this.LBHuidigeBestelling.TabIndex = 2;
            // 
            // LBBestellingen
            // 
            this.LBBestellingen.FormattingEnabled = true;
            this.LBBestellingen.Location = new System.Drawing.Point(290, 19);
            this.LBBestellingen.Name = "LBBestellingen";
            this.LBBestellingen.Size = new System.Drawing.Size(98, 186);
            this.LBBestellingen.TabIndex = 1;
            // 
            // GBGerechten
            // 
            this.GBGerechten.Controls.Add(this.GBGerechtDetails);
            this.GBGerechten.Controls.Add(this.BToevoegen);
            this.GBGerechten.Controls.Add(this.LBGerechten);
            this.GBGerechten.Location = new System.Drawing.Point(7, 22);
            this.GBGerechten.Name = "GBGerechten";
            this.GBGerechten.Size = new System.Drawing.Size(778, 205);
            this.GBGerechten.TabIndex = 1;
            this.GBGerechten.TabStop = false;
            this.GBGerechten.Text = "A";
            // 
            // GBGerechtDetails
            // 
            this.GBGerechtDetails.Controls.Add(this.LGerechtenOutputNaam);
            this.GBGerechtDetails.Controls.Add(this.PBGerechtDetails);
            this.GBGerechtDetails.Controls.Add(this.GBDescription);
            this.GBGerechtDetails.Controls.Add(this.LGerechtNaam);
            this.GBGerechtDetails.Location = new System.Drawing.Point(290, 18);
            this.GBGerechtDetails.Name = "GBGerechtDetails";
            this.GBGerechtDetails.Size = new System.Drawing.Size(482, 181);
            this.GBGerechtDetails.TabIndex = 2;
            this.GBGerechtDetails.TabStop = false;
            this.GBGerechtDetails.Text = "Gerecht Details:";
            this.GBGerechtDetails.Visible = false;
            // 
            // LGerechtenOutputNaam
            // 
            this.LGerechtenOutputNaam.AutoSize = true;
            this.LGerechtenOutputNaam.Location = new System.Drawing.Point(74, 32);
            this.LGerechtenOutputNaam.Name = "LGerechtenOutputNaam";
            this.LGerechtenOutputNaam.Size = new System.Drawing.Size(97, 13);
            this.LGerechtenOutputNaam.TabIndex = 2;
            this.LGerechtenOutputNaam.Text = "<<GerechtNaam>>";
            this.LGerechtenOutputNaam.Visible = false;
            // 
            // PBGerechtDetails
            // 
            this.PBGerechtDetails.Location = new System.Drawing.Point(270, 14);
            this.PBGerechtDetails.Name = "PBGerechtDetails";
            this.PBGerechtDetails.Size = new System.Drawing.Size(206, 156);
            this.PBGerechtDetails.TabIndex = 0;
            this.PBGerechtDetails.TabStop = false;
            // 
            // GBDescription
            // 
            this.GBDescription.Controls.Add(this.RTBGerechtDetails);
            this.GBDescription.Location = new System.Drawing.Point(6, 58);
            this.GBDescription.Name = "GBDescription";
            this.GBDescription.Size = new System.Drawing.Size(221, 117);
            this.GBDescription.TabIndex = 1;
            this.GBDescription.TabStop = false;
            this.GBDescription.Text = "Informatie over het gerecht:";
            // 
            // RTBGerechtDetails
            // 
            this.RTBGerechtDetails.Location = new System.Drawing.Point(6, 16);
            this.RTBGerechtDetails.Name = "RTBGerechtDetails";
            this.RTBGerechtDetails.Size = new System.Drawing.Size(209, 96);
            this.RTBGerechtDetails.TabIndex = 0;
            this.RTBGerechtDetails.Text = "";
            // 
            // LGerechtNaam
            // 
            this.LGerechtNaam.AutoSize = true;
            this.LGerechtNaam.Location = new System.Drawing.Point(30, 32);
            this.LGerechtNaam.Name = "LGerechtNaam";
            this.LGerechtNaam.Size = new System.Drawing.Size(38, 13);
            this.LGerechtNaam.TabIndex = 0;
            this.LGerechtNaam.Text = "Naam:";
            // 
            // BToevoegen
            // 
            this.BToevoegen.Location = new System.Drawing.Point(209, 176);
            this.BToevoegen.Name = "BToevoegen";
            this.BToevoegen.Size = new System.Drawing.Size(75, 23);
            this.BToevoegen.TabIndex = 1;
            this.BToevoegen.Text = "Toevoegen";
            this.BToevoegen.UseVisualStyleBackColor = true;
            this.BToevoegen.Click += new System.EventHandler(this.BToevoegen_Click);
            // 
            // LBGerechten
            // 
            this.LBGerechten.FormattingEnabled = true;
            this.LBGerechten.Location = new System.Drawing.Point(6, 18);
            this.LBGerechten.Name = "LBGerechten";
            this.LBGerechten.Size = new System.Drawing.Size(197, 184);
            this.LBGerechten.TabIndex = 0;
            this.LBGerechten.SelectedIndexChanged += new System.EventHandler(this.LBGerechten_SelectedIndexChanged);
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.Location = new System.Drawing.Point(569, 9);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(49, 13);
            this.LRol.TabIndex = 8;
            this.LRol.Text = "Welkom:";
            this.LRol.Click += new System.EventHandler(this.LRol_Click);
            // 
            // LNaamOutput
            // 
            this.LNaamOutput.AutoSize = true;
            this.LNaamOutput.Location = new System.Drawing.Point(624, 9);
            this.LNaamOutput.Name = "LNaamOutput";
            this.LNaamOutput.Size = new System.Drawing.Size(47, 13);
            this.LNaamOutput.TabIndex = 10;
            this.LNaamOutput.Text = "<Naam>";
            this.LNaamOutput.Visible = false;
            this.LNaamOutput.Click += new System.EventHandler(this.LNaamOutput_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(12, 12);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 11;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // LVerificatieLogInSuccesvol
            // 
            this.LVerificatieLogInSuccesvol.AutoSize = true;
            this.LVerificatieLogInSuccesvol.Location = new System.Drawing.Point(263, 17);
            this.LVerificatieLogInSuccesvol.Name = "LVerificatieLogInSuccesvol";
            this.LVerificatieLogInSuccesvol.Size = new System.Drawing.Size(104, 13);
            this.LVerificatieLogInSuccesvol.TabIndex = 12;
            this.LVerificatieLogInSuccesvol.Text = "<Log in Succesvol!>";
            this.LVerificatieLogInSuccesvol.Visible = false;
            // 
            // LReserveringNummer
            // 
            this.LReserveringNummer.AutoSize = true;
            this.LReserveringNummer.Location = new System.Drawing.Point(25, 128);
            this.LReserveringNummer.Name = "LReserveringNummer";
            this.LReserveringNummer.Size = new System.Drawing.Size(107, 13);
            this.LReserveringNummer.TabIndex = 11;
            this.LReserveringNummer.Text = "Reservering nummer:";
            // 
            // LReserveringNummerOutputGerechten
            // 
            this.LReserveringNummerOutputGerechten.AutoSize = true;
            this.LReserveringNummerOutputGerechten.Location = new System.Drawing.Point(138, 128);
            this.LReserveringNummerOutputGerechten.Name = "LReserveringNummerOutputGerechten";
            this.LReserveringNummerOutputGerechten.Size = new System.Drawing.Size(115, 13);
            this.LReserveringNummerOutputGerechten.TabIndex = 12;
            this.LReserveringNummerOutputGerechten.Text = "<ReserveringNummer>";
            this.LReserveringNummerOutputGerechten.Visible = false;
            // 
            // FOrdirect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 536);
            this.Controls.Add(this.LVerificatieLogInSuccesvol);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.LNaamOutput);
            this.Controls.Add(this.LRol);
            this.Controls.Add(this.TCOrdirect);
            this.Name = "FOrdirect";
            this.Text = "Ordirect";
            this.Load += new System.EventHandler(this.FOrdirect_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.TCOrdirect.ResumeLayout(false);
            this.TPRestaurants.ResumeLayout(false);
            this.TPReserveringen.ResumeLayout(false);
            this.GBRestaurantDetailsReserveringen.ResumeLayout(false);
            this.GBRestaurantDetailsReserveringen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.TPOrder.ResumeLayout(false);
            this.TPOrder.PerformLayout();
            this.GBBestellingen.ResumeLayout(false);
            this.GBBestellingen.PerformLayout();
            this.GBGerechten.ResumeLayout(false);
            this.GBGerechtDetails.ResumeLayout(false);
            this.GBGerechtDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBGerechtDetails)).EndInit();
            this.GBDescription.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBRestaurants;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LAdres;
        private System.Windows.Forms.Label Lnaam;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LTelefoonNummer;
        private System.Windows.Forms.Label LOutputTelefoonnummer;
        private System.Windows.Forms.Label LOutputAdres;
        private System.Windows.Forms.Label LOutputNaam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LVerificatie;
        private System.Windows.Forms.Button BReserveer;
        private System.Windows.Forms.DateTimePicker DTPTime;
        private System.Windows.Forms.Label LDatum;
        private System.Windows.Forms.DateTimePicker DTPDate;
        private System.Windows.Forms.Label LTijd;
        private System.Windows.Forms.TabControl TCOrdirect;
        private System.Windows.Forms.TabPage TPRestaurants;
        private System.Windows.Forms.TabPage TPReserveringen;
        private System.Windows.Forms.Label LRol;
        private System.Windows.Forms.GroupBox GBRestaurantDetailsReserveringen;
        private System.Windows.Forms.Label LTelefoonNummerOutputReserveringen;
        private System.Windows.Forms.Label LAdresOutputReserveringen;
        private System.Windows.Forms.Label LNaamOutputReserveringen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LNaamReserveringen;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox LBReserveringen;
        private System.Windows.Forms.Label LNaamOutput;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label LVerificatieLogInSuccesvol;
        private System.Windows.Forms.TabPage TPOrder;
        private System.Windows.Forms.Button BNaarOrder;
        private System.Windows.Forms.GroupBox GBBestellingen;
        private System.Windows.Forms.Label LBestellingGerechten;
        private System.Windows.Forms.ListBox LBBestellingGerechten;
        private System.Windows.Forms.Button BBestellingToevoegen;
        private System.Windows.Forms.ListBox LBHuidigeBestelling;
        private System.Windows.Forms.ListBox LBBestellingen;
        private System.Windows.Forms.GroupBox GBGerechten;
        private System.Windows.Forms.GroupBox GBGerechtDetails;
        private System.Windows.Forms.PictureBox PBGerechtDetails;
        private System.Windows.Forms.GroupBox GBDescription;
        private System.Windows.Forms.RichTextBox RTBGerechtDetails;
        private System.Windows.Forms.Label LGerechtNaam;
        private System.Windows.Forms.Button BToevoegen;
        private System.Windows.Forms.CheckedListBox LBGerechten;
        private System.Windows.Forms.Label LGerechtenRestaurantOutputNaam;
        private System.Windows.Forms.Label LOrderRestaurantNaam;
        private System.Windows.Forms.Label LRestaurantIdReserveringen;
        private System.Windows.Forms.Label LRestaurantIDOutputReserveringen;
        private System.Windows.Forms.Label LGerechtenOutputNaam;
        private System.Windows.Forms.Label LReserveringNummerGerechten;
        private System.Windows.Forms.Label LReserveringNummerOutputGerechten;
        private System.Windows.Forms.Label LReserveringNummer;
    }
}

