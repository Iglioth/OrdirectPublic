namespace FormsOrdirect
{
    partial class LogInScreen
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
            this.BLogIn = new System.Windows.Forms.Button();
            this.LEmail = new System.Windows.Forms.Label();
            this.BRegistreer = new System.Windows.Forms.Button();
            this.TBEmailLogIn = new System.Windows.Forms.TextBox();
            this.GBLogIn = new System.Windows.Forms.GroupBox();
            this.GBRegistreren = new System.Windows.Forms.GroupBox();
            this.TBWachtwoordInloggen = new System.Windows.Forms.TextBox();
            this.LWachtwoord = new System.Windows.Forms.Label();
            this.TBWachtwoordRegistreren = new System.Windows.Forms.TextBox();
            this.LWachtwoordRegistreren = new System.Windows.Forms.Label();
            this.TBEmailRegistreren = new System.Windows.Forms.TextBox();
            this.LEmailRegistreren = new System.Windows.Forms.Label();
            this.TBVoornaamRegistreren = new System.Windows.Forms.TextBox();
            this.LVoornaamRegistreren = new System.Windows.Forms.Label();
            this.TBAchternaamRegistreren = new System.Windows.Forms.TextBox();
            this.LAchternaamRegistreren = new System.Windows.Forms.Label();
            this.GBLogIn.SuspendLayout();
            this.GBRegistreren.SuspendLayout();
            this.SuspendLayout();
            // 
            // BLogIn
            // 
            this.BLogIn.Location = new System.Drawing.Point(114, 206);
            this.BLogIn.Name = "BLogIn";
            this.BLogIn.Size = new System.Drawing.Size(75, 23);
            this.BLogIn.TabIndex = 12;
            this.BLogIn.Text = "Log in";
            this.BLogIn.UseVisualStyleBackColor = true;
            this.BLogIn.Click += new System.EventHandler(this.BLogIn_Click);
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Location = new System.Drawing.Point(34, 34);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(35, 13);
            this.LEmail.TabIndex = 13;
            this.LEmail.Text = "Email:";
            // 
            // BRegistreer
            // 
            this.BRegistreer.Location = new System.Drawing.Point(119, 206);
            this.BRegistreer.Name = "BRegistreer";
            this.BRegistreer.Size = new System.Drawing.Size(75, 23);
            this.BRegistreer.TabIndex = 14;
            this.BRegistreer.Text = "Registreer";
            this.BRegistreer.UseVisualStyleBackColor = true;
            this.BRegistreer.Click += new System.EventHandler(this.BRegistreer_Click);
            // 
            // TBEmailLogIn
            // 
            this.TBEmailLogIn.Location = new System.Drawing.Point(75, 31);
            this.TBEmailLogIn.Name = "TBEmailLogIn";
            this.TBEmailLogIn.Size = new System.Drawing.Size(100, 20);
            this.TBEmailLogIn.TabIndex = 15;
            // 
            // GBLogIn
            // 
            this.GBLogIn.Controls.Add(this.TBWachtwoordInloggen);
            this.GBLogIn.Controls.Add(this.LWachtwoord);
            this.GBLogIn.Controls.Add(this.TBEmailLogIn);
            this.GBLogIn.Controls.Add(this.LEmail);
            this.GBLogIn.Controls.Add(this.BLogIn);
            this.GBLogIn.Location = new System.Drawing.Point(54, 60);
            this.GBLogIn.Name = "GBLogIn";
            this.GBLogIn.Size = new System.Drawing.Size(195, 235);
            this.GBLogIn.TabIndex = 16;
            this.GBLogIn.TabStop = false;
            this.GBLogIn.Text = "Log In:";
            // 
            // GBRegistreren
            // 
            this.GBRegistreren.Controls.Add(this.TBAchternaamRegistreren);
            this.GBRegistreren.Controls.Add(this.LAchternaamRegistreren);
            this.GBRegistreren.Controls.Add(this.TBVoornaamRegistreren);
            this.GBRegistreren.Controls.Add(this.LVoornaamRegistreren);
            this.GBRegistreren.Controls.Add(this.TBWachtwoordRegistreren);
            this.GBRegistreren.Controls.Add(this.BRegistreer);
            this.GBRegistreren.Controls.Add(this.LWachtwoordRegistreren);
            this.GBRegistreren.Controls.Add(this.TBEmailRegistreren);
            this.GBRegistreren.Controls.Add(this.LEmailRegistreren);
            this.GBRegistreren.Location = new System.Drawing.Point(306, 60);
            this.GBRegistreren.Name = "GBRegistreren";
            this.GBRegistreren.Size = new System.Drawing.Size(200, 235);
            this.GBRegistreren.TabIndex = 17;
            this.GBRegistreren.TabStop = false;
            this.GBRegistreren.Text = "Registreren:";
            // 
            // TBWachtwoordInloggen
            // 
            this.TBWachtwoordInloggen.Location = new System.Drawing.Point(75, 74);
            this.TBWachtwoordInloggen.Name = "TBWachtwoordInloggen";
            this.TBWachtwoordInloggen.Size = new System.Drawing.Size(100, 20);
            this.TBWachtwoordInloggen.TabIndex = 17;
            // 
            // LWachtwoord
            // 
            this.LWachtwoord.AutoSize = true;
            this.LWachtwoord.Location = new System.Drawing.Point(1, 77);
            this.LWachtwoord.Name = "LWachtwoord";
            this.LWachtwoord.Size = new System.Drawing.Size(71, 13);
            this.LWachtwoord.TabIndex = 16;
            this.LWachtwoord.Text = "Wachtwoord:";
            // 
            // TBWachtwoordRegistreren
            // 
            this.TBWachtwoordRegistreren.Location = new System.Drawing.Point(94, 74);
            this.TBWachtwoordRegistreren.Name = "TBWachtwoordRegistreren";
            this.TBWachtwoordRegistreren.Size = new System.Drawing.Size(100, 20);
            this.TBWachtwoordRegistreren.TabIndex = 21;
            // 
            // LWachtwoordRegistreren
            // 
            this.LWachtwoordRegistreren.AutoSize = true;
            this.LWachtwoordRegistreren.Location = new System.Drawing.Point(20, 77);
            this.LWachtwoordRegistreren.Name = "LWachtwoordRegistreren";
            this.LWachtwoordRegistreren.Size = new System.Drawing.Size(71, 13);
            this.LWachtwoordRegistreren.TabIndex = 20;
            this.LWachtwoordRegistreren.Text = "Wachtwoord:";
            // 
            // TBEmailRegistreren
            // 
            this.TBEmailRegistreren.Location = new System.Drawing.Point(94, 31);
            this.TBEmailRegistreren.Name = "TBEmailRegistreren";
            this.TBEmailRegistreren.Size = new System.Drawing.Size(100, 20);
            this.TBEmailRegistreren.TabIndex = 19;
            // 
            // LEmailRegistreren
            // 
            this.LEmailRegistreren.AutoSize = true;
            this.LEmailRegistreren.Location = new System.Drawing.Point(53, 34);
            this.LEmailRegistreren.Name = "LEmailRegistreren";
            this.LEmailRegistreren.Size = new System.Drawing.Size(35, 13);
            this.LEmailRegistreren.TabIndex = 18;
            this.LEmailRegistreren.Text = "Email:";
            // 
            // TBVoornaamRegistreren
            // 
            this.TBVoornaamRegistreren.Location = new System.Drawing.Point(94, 117);
            this.TBVoornaamRegistreren.Name = "TBVoornaamRegistreren";
            this.TBVoornaamRegistreren.Size = new System.Drawing.Size(100, 20);
            this.TBVoornaamRegistreren.TabIndex = 23;
            // 
            // LVoornaamRegistreren
            // 
            this.LVoornaamRegistreren.AutoSize = true;
            this.LVoornaamRegistreren.Location = new System.Drawing.Point(29, 120);
            this.LVoornaamRegistreren.Name = "LVoornaamRegistreren";
            this.LVoornaamRegistreren.Size = new System.Drawing.Size(58, 13);
            this.LVoornaamRegistreren.TabIndex = 22;
            this.LVoornaamRegistreren.Text = "Voornaam:";
            // 
            // TBAchternaamRegistreren
            // 
            this.TBAchternaamRegistreren.Location = new System.Drawing.Point(94, 156);
            this.TBAchternaamRegistreren.Name = "TBAchternaamRegistreren";
            this.TBAchternaamRegistreren.Size = new System.Drawing.Size(100, 20);
            this.TBAchternaamRegistreren.TabIndex = 25;
            // 
            // LAchternaamRegistreren
            // 
            this.LAchternaamRegistreren.AutoSize = true;
            this.LAchternaamRegistreren.Location = new System.Drawing.Point(20, 159);
            this.LAchternaamRegistreren.Name = "LAchternaamRegistreren";
            this.LAchternaamRegistreren.Size = new System.Drawing.Size(67, 13);
            this.LAchternaamRegistreren.TabIndex = 24;
            this.LAchternaamRegistreren.Text = "Achternaam:";
            // 
            // LogInScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 357);
            this.Controls.Add(this.GBRegistreren);
            this.Controls.Add(this.GBLogIn);
            this.Name = "LogInScreen";
            this.Text = "LogInScreen";
            this.GBLogIn.ResumeLayout(false);
            this.GBLogIn.PerformLayout();
            this.GBRegistreren.ResumeLayout(false);
            this.GBRegistreren.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BLogIn;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Button BRegistreer;
        private System.Windows.Forms.TextBox TBEmailLogIn;
        private System.Windows.Forms.GroupBox GBLogIn;
        private System.Windows.Forms.GroupBox GBRegistreren;
        private System.Windows.Forms.TextBox TBWachtwoordInloggen;
        private System.Windows.Forms.Label LWachtwoord;
        private System.Windows.Forms.TextBox TBAchternaamRegistreren;
        private System.Windows.Forms.Label LAchternaamRegistreren;
        private System.Windows.Forms.TextBox TBVoornaamRegistreren;
        private System.Windows.Forms.Label LVoornaamRegistreren;
        private System.Windows.Forms.TextBox TBWachtwoordRegistreren;
        private System.Windows.Forms.Label LWachtwoordRegistreren;
        private System.Windows.Forms.TextBox TBEmailRegistreren;
        private System.Windows.Forms.Label LEmailRegistreren;
    }
}