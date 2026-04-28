using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmoteka_baze
{
    public partial class Login : Form
    {
        bool prikaziLozinku = false;
        public Login()
        {
            InitializeComponent();
            panelRegistracija.Visible = false;
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(220, 0, 0);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(180, 0, 0);
        }

        private void btnRegistracija_MouseEnter(object sender, EventArgs e)
        {
            btnRegistracija.BackColor = Color.FromArgb(70, 70, 70);
        }

        private void btnRegistracija_MouseLeave(object sender, EventArgs e)
        {
            btnRegistracija.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void btnOko_Click(object sender, EventArgs e)
        {
            prikaziLozinku = !prikaziLozinku;

            if (prikaziLozinku)
            {
                txtLozinka.PasswordChar = '\0';
                btnOko.Image = Properties.Resources.eye_open;
            }
            else
            {
                txtLozinka.PasswordChar = '✦';
                btnOko.Image = Properties.Resources.eye_closed;
            }
        }

        private void btnZatvori_MouseEnter(object sender, EventArgs e)
        {
            btnZatvori.BackColor = Color.FromArgb(180, 0, 0);
        }

        private void btnZatvori_MouseLeave(object sender, EventArgs e)
        {
            btnZatvori.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelRegistracija.Visible = true;
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            panelRegistracija.Visible = false;
            panelLogin.Visible = true;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtKorisnickoIme.Text == "" || txtLozinka.Text == "")
            {
                CustomMessageBox xprazno = new CustomMessageBox("Popuni sva polja!");
                xprazno.ShowDialog();
                return;
            }

            using (SqlConnection conn = new SqlConnection(Konekcija.String))
            {
                conn.Open();

                string queryUser = "SELECT KorisnikID, Lozinka FROM Korisnik WHERE KorisnickoIme = @ime";

                SqlCommand cmd = new SqlCommand(queryUser, conn);
                cmd.Parameters.AddWithValue("@ime", txtKorisnickoIme.Text.Trim());

                SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.Read())
                {
                    reader.Close(); 
                    CustomMessageBox xime = new CustomMessageBox("Korisničko ime \nne postoji!");
                    xime.ShowDialog();
                    return;
                }

                string lozinkaIzBaze = reader["Lozinka"].ToString();
                int korisnikID = Convert.ToInt32(reader["KorisnikID"]);

                reader.Close();

                if (lozinkaIzBaze != txtLozinka.Text.Trim())
                {
                    CustomMessageBox xlozinka = new CustomMessageBox("Pogrešna lozinka!");
                    xlozinka.ShowDialog();
                    return;
                }

                CustomMessageBox uspesno = new CustomMessageBox("Uspešan login!");
                uspesno.ShowDialog();
                Pocetna pocetna = new Pocetna(korisnikID);
                pocetna.Show();
                this.Hide();
            }
        }

        private void btnPotvrdiRegistraciju_Click(object sender, EventArgs e)
        {
            if (txtRegKorisnickoIme.Text == "" ||
                txtRegLozinka.Text == "" ||
                txtPotvrdaLozinke.Text == "")
            {
                CustomMessageBox msg = new CustomMessageBox("Popuni sva polja!");
                msg.ShowDialog();
                return;
            }

            if (txtRegLozinka.Text != txtPotvrdaLozinke.Text)
            {
                CustomMessageBox msg = new CustomMessageBox("Lozinke se ne poklapaju!");
                msg.ShowDialog();
                return;
            }

            using (SqlConnection conn = new SqlConnection(Konekcija.String))
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM Korisnik WHERE KorisnickoIme = @ime";

                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@ime", txtRegKorisnickoIme.Text.Trim());

                int postoji = (int)checkCmd.ExecuteScalar();

                if (postoji > 0)
                {
                    CustomMessageBox msg = new CustomMessageBox("Korisničko ime već postoji!");
                    msg.ShowDialog();
                    return;
                }
                string insertQuery = "INSERT INTO Korisnik (KorisnickoIme, Lozinka) VALUES (@ime, @lozinka)";

                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@ime", txtRegKorisnickoIme.Text.Trim());
                insertCmd.Parameters.AddWithValue("@lozinka", txtRegLozinka.Text.Trim());

                insertCmd.ExecuteNonQuery();

                CustomMessageBox msgSuccess = new CustomMessageBox("Uspešno ste registrovani!");
                msgSuccess.ShowDialog();

                txtRegKorisnickoIme.Clear();
                txtRegLozinka.Clear();
                txtPotvrdaLozinke.Clear();

                panelRegistracija.Visible = false;
                panelLogin.Visible = true;
            }
        }
    }
}
