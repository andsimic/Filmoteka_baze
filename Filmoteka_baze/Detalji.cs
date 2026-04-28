using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;

namespace Filmoteka_baze
{
    public partial class Detalji : Form
    {
        int korisnikID;
        string konekcija = @"Server=DESKTOP-VL9Q1G1\SQLEXPRESS;Database=Filmoteka;Trusted_Connection=True;";
        int filmID;
        int izabranaOcena = 0;
        bool izMojiFilmovi = false;
        PictureBox[] zvezdice;

        Image starFull;
        Image starEmpty;
        public Detalji(int id, int korisnikID, bool izMoji = false)
        {
            InitializeComponent();
            filmID = id;
            this.korisnikID = korisnikID;
            izMojiFilmovi = izMoji;

            UcitajDetalje();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void UcitajDetalje()
        {
            using (SqlConnection conn = new SqlConnection(konekcija))
            {
                conn.Open();

                string query = @"SELECT 
    f.FilmID,
    f.Naziv AS FilmNaziv,
    f.Godina,
    f.TrajanjeMin,
    f.Opis,
    f.PutanjaPostera,
    f.PutanjaTrajlera,
    s.Naziv AS StudioNaziv,
    r.Ime + ' ' + r.Prezime AS ReziserNaziv,
    d.Naziv AS DrzavaNaziv,
    STUFF((
        SELECT ', ' + g.Ime + ' ' + g.Prezime
        FROM FilmGlumac fg
        INNER JOIN Glumac g ON fg.GlumacID = g.GlumacID
        WHERE fg.FilmID = f.FilmID
        FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, '') AS GlumciNazivi
FROM Film f
LEFT JOIN Studio s ON f.StudioID = s.StudioID
LEFT JOIN Reziser r ON f.ReziserID = r.ReziserID
LEFT JOIN Drzava d ON f.DrzavaID = d.DrzavaID
WHERE f.FilmID = @FilmID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FilmID", filmID);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // unutar reader.Read()
                    string putanjaTrailer = reader["PutanjaTrajlera"]?.ToString();
                    if (!string.IsNullOrWhiteSpace(putanjaTrailer) && File.Exists(putanjaTrailer))
                    {
                        axWmpTrailer.URL = putanjaTrailer;
                        axWmpTrailer.Ctlcontrols.stop(); // ili play direktno
                    }
                    lblNaziv.Text = reader["FilmNaziv"].ToString();

                    lblinfoOsnovno.Text =
                        reader["Godina"].ToString() + " | " +
                        reader["TrajanjeMin"].ToString() + " min | " +
                        reader["DrzavaNaziv"].ToString();

                    lblStudioIme.Text = reader["StudioNaziv"].ToString();
                    lblReziserIme.Text = reader["ReziserNaziv"].ToString();
                    lblGlumciLista.Text = reader["GlumciNazivi"].ToString();
                    lblOpisNaziv.Text = reader["Opis"].ToString();

                    string putanja = Path.Combine(
                        Application.StartupPath,
                        reader["PutanjaPostera"].ToString());

                    if (File.Exists(putanja))
                    {
                        using (var temp = Image.FromFile(putanja))
                        {
                            picPoster.Image = new Bitmap(temp);
                        }
                    }
                }

                reader.Close();
            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Detalji_Load(object sender, EventArgs e)
        {
            // 1. POZADINA
            using (SqlConnection conn = new SqlConnection(Konekcija.String))
            {
                conn.Open();

                string query = "SELECT PutanjaPozadine FROM Film WHERE FilmID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", filmID);

                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string putanja = result.ToString();

                    if (File.Exists(putanja))
                        pbPozadinaDetalji.Image = Image.FromFile(putanja);
                    else
                        pbPozadinaDetalji.BackColor = Color.Black;
                }
            }

            // 2. OCENA FILMA (iz baze)
            UcitajOcenuFilma();

            // 3. UCITAJ SLIKE
            starFull = Properties.Resources.star_full;
            starEmpty = Properties.Resources.star_empty;

            // 4. INICIJALIZUJ ZVEZDICE (OVO MORA PRE FOREACH)
            zvezdice = new PictureBox[]
            {
        picStar1, picStar2, picStar3, picStar4, picStar5
            };

            // 5. EVENTI
            for (int i = 0; i < zvezdice.Length; i++)
            {
                int index = i + 1;

                zvezdice[i].Tag = index;
                zvezdice[i].Click += Star_Click;
                zvezdice[i].MouseEnter += Star_MouseEnter;
                zvezdice[i].MouseLeave += Star_MouseLeave;
            }
            btnObrisi.Visible = izMojiFilmovi;
          
            // 6. AKO NIJE IZ MOJI FILMOVI → SAKRIJ SVE
            if (!izMojiFilmovi)
            {
                MojaOcena.Visible = false;
                txtKomentar.Visible = false;
                btnSacuvajKomentar.Visible = false;
                lblKomentar.Visible = false;
                btnDodajUGledane.Text = "Dodaj u gledane";
                btnDodajUGledane.Enabled = true;

                foreach (var z in zvezdice)
                    z.Visible = false;
            }
            else
            {
                // PRIKAŽI SVE
                MojaOcena.Visible = true;
                txtKomentar.Visible = true;
                btnSacuvajKomentar.Visible = true;
                lblKomentar.Visible = true;
                btnDodajUGledane.Text = "✔ Dodato";
                btnDodajUGledane.Enabled = false;
                btnDodajUGledane.BackColor = Color.FromArgb(180, 0, 0);

                foreach (var z in zvezdice)
                    z.Visible = true;

                // UČITAJ PODATKE
                UcitajMojuOcenu();
                UcitajKomentar();
            }
        }

        private void btnPocetna_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(180, 0, 0);
        }

        private void btnPocetna_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(24, 24, 24);
        }

        private void btnFilmovi_Click(object sender, EventArgs e)
        {
            Glavna g = new Glavna(korisnikID);
            g.Show();
            this.Hide();
        }

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            Pocetna p = new Pocetna(korisnikID);
            p.Show();
            this.Hide();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            CustomMessageBoxOdjava msg = new CustomMessageBoxOdjava("Da li želite da se odjavite?");

            if (msg.ShowDialog() == DialogResult.Yes)
            {
                foreach (Form f in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (!(f is Login))
                        f.Hide();
                }

                Login login = new Login();
                login.Show();
            }
        }

        private void btnDodajUGledane_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Konekcija.String))
            {
                conn.Open();

                // 1. PROVERA
                string checkQuery = "SELECT COUNT(*) FROM KorisnikFilm WHERE KorisnikID=@korisnikID AND FilmID=@filmID";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@korisnikID", korisnikID);
                checkCmd.Parameters.AddWithValue("@filmID", filmID);

                int postoji = (int)checkCmd.ExecuteScalar();

                if (postoji > 0)
                {
                    CustomMessageBox msg = new CustomMessageBox("Film je već dodat na listu!");
                    msg.ShowDialog();
                    return;
                }

                // 2. INSERT
                string insertQuery = "INSERT INTO KorisnikFilm (KorisnikID, FilmID, Odgledan) VALUES (@korisnikID, @filmID, 1)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@korisnikID", korisnikID);
                insertCmd.Parameters.AddWithValue("@filmID", filmID);

                insertCmd.ExecuteNonQuery();

                CustomMessageBox msg2 = new CustomMessageBox("Film je uspešno dodat!");
                msg2.ShowDialog();
            }
        }

        private void btnMojiFilmovi_Click(object sender, EventArgs e)
        {
            MojiFilmovi mf = new MojiFilmovi(korisnikID);
            mf.Show();
            this.Close();
        }
        private void PrikaziZvezdice(int ocena)
        {
            string zvezdice = "";

            for (int i = 1; i <= 5; i++)
            {
                if (i <= ocena)
                    zvezdice += "★";
                else
                    zvezdice += "☆";
            }

            lblOcena.Text = zvezdice;
        }
        private void UcitajOcenuFilma()
        {
            using (SqlConnection conn = new SqlConnection(Konekcija.String))
            {
                conn.Open();

                string query = @"SELECT TOP 1 Vrednost 
                         FROM Ocena 
                         WHERE FilmID = @filmID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@filmID", filmID);

                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    int ocena = Convert.ToInt32(result);
                    PrikaziZvezdice(ocena);
                }
                else
                {
                    lblOcena.Text = "☆☆☆☆☆";
                }
            }
        }
        private void PrikaziZvezdiceMoje(int ocena)
        {
            for (int i = 0; i < zvezdice.Length; i++)
            {
                if (i < ocena)
                    zvezdice[i].Image = starFull;
                else
                    zvezdice[i].Image = starEmpty;
            }
        }
        private void Star_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;

            izabranaOcena = (int)pic.Tag;

            PrikaziZvezdiceMoje(izabranaOcena);
            MojaOcena.Text = "Moja ocena: " + izabranaOcena;

            SacuvajOcenu();
        }
        private void Star_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            int hover = (int)pic.Tag;

            PrikaziZvezdiceMoje(hover);
        }
        private void Star_MouseLeave(object sender, EventArgs e)
        {
            PrikaziZvezdiceMoje(izabranaOcena);
        }
        private void SacuvajOcenu()
        {
            using (SqlConnection conn = new SqlConnection(Konekcija.String))
            {
                conn.Open();

                string query = @"UPDATE KorisnikFilm
                         SET LicnaOcena = @ocena
                         WHERE KorisnikID = @korisnikID AND FilmID = @filmID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ocena", izabranaOcena);
                cmd.Parameters.AddWithValue("@korisnikID", korisnikID);
                cmd.Parameters.AddWithValue("@filmID", filmID);

                cmd.ExecuteNonQuery();
            }
        }
        private void UcitajMojuOcenu()
        {
            using (SqlConnection conn = new SqlConnection(Konekcija.String))
            {
                conn.Open();

                string query = @"SELECT LicnaOcena 
                         FROM KorisnikFilm 
                         WHERE KorisnikID=@k AND FilmID=@f";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@k", korisnikID);
                cmd.Parameters.AddWithValue("@f", filmID);

                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    izabranaOcena = Convert.ToInt32(result);
                }
                else
                {
                    izabranaOcena = 0;
                }

                PrikaziZvezdiceMoje(izabranaOcena);
                MojaOcena.Text = "Moja ocena: " + izabranaOcena;
            }
        }
        private void UcitajKomentar()
        {
            using (SqlConnection conn = new SqlConnection(Konekcija.String))
            {
                conn.Open();

                string query = @"SELECT Komentar 
                         FROM KorisnikFilm 
                         WHERE KorisnikID=@k AND FilmID=@f";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@k", korisnikID);
                cmd.Parameters.AddWithValue("@f", filmID);

                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    txtKomentar.Text = result.ToString();
                }
                else
                {
                    txtKomentar.Text = "";
                }
            }
        }
        private void btnSacuvajKomentar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Konekcija.String))
            {
                conn.Open();

                string query = @"UPDATE KorisnikFilm
                         SET Komentar = @komentar
                         WHERE KorisnikID = @k AND FilmID = @f";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@komentar", txtKomentar.Text);
                cmd.Parameters.AddWithValue("@k", korisnikID);
                cmd.Parameters.AddWithValue("@f", filmID);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Komentar sačuvan!");
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            CustomMessageBoxOdjava msg = new CustomMessageBoxOdjava("Da li želite da obrišete film?");

            if (msg.ShowDialog() == DialogResult.No)
                return;

            using (SqlConnection conn = new SqlConnection(Konekcija.String))
            {
                conn.Open();

                string query = @"DELETE FROM KorisnikFilm 
                         WHERE KorisnikID=@k AND FilmID=@f";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@k", korisnikID);
                cmd.Parameters.AddWithValue("@f", filmID);

                cmd.ExecuteNonQuery();
            }

            CustomMessageBox msg1 = new CustomMessageBox("Film je obrisan iz liste!");
            msg1.ShowDialog();

            // VRATI NA MOJI FILMOVI
            MojiFilmovi mf = new MojiFilmovi(korisnikID);
            mf.Show();
            this.Close();
        }

    }
}
