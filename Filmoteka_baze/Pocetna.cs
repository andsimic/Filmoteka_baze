using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;


namespace Filmoteka_baze
{
    public partial class Pocetna : Form
    {
        int korisnikID;
        public Pocetna()
        {
            InitializeComponent();
        }
        public Pocetna(int korisnikID)
        {
            InitializeComponent();
            this.korisnikID = korisnikID;
        }
        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnZatvori_MouseEnter(object sender, EventArgs e)
        {
            btnZatvori.BackColor = Color.FromArgb(180, 0, 0);
        }

        private void btnZatvori_MouseLeave(object sender, EventArgs e)
        {
            btnZatvori.BackColor = Color.FromArgb(20, 20, 20);
        }
        Random rnd = new Random();
        private void Pocetna_Load(object sender, EventArgs e)
        {
            UcitajFilmove();
            UcitajTop10();
            string[] poruke = {
    "🎬 Film izabran za vas",
    "🔥 Popularno sada",
    "⭐ Preporuka dana",
    "🎥 Ne propustite",
    "🍿 Večerašnji izbor"
};
            if (filmovi.Count == 0) return;

            var film = filmovi[rnd.Next(filmovi.Count)];
            lblNazivFilma.Text = film.Naziv;
            lblOpis.Text = poruke[rnd.Next(poruke.Length)];

            string putanja = film.PutanjaPozadine;

            if (System.IO.File.Exists(putanja))
            {
                pbPozadina.Image = Image.FromFile(putanja);
            }
            else
            {
                pbPozadina.BackColor = Color.Black;
            }

            //lblFilmNaziv.Text = film.Naziv;
        }
        private void UcitajFilmove()
        {
            filmovi.Clear();

            using (SqlConnection conn = new SqlConnection(Konekcija.String))
            {
                conn.Open();

                string query = "SELECT Naziv, PutanjaPozadine FROM Film";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    filmovi.Add(new Film
                    {
                        Naziv = reader["Naziv"].ToString(),
                        PutanjaPozadine = reader["PutanjaPozadine"].ToString()
                    });
                }
            }
        }
        private void Film_MouseEnter(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            Panel panel = ctrl as Panel ?? ctrl.Parent as Panel;

            if (panel == null) return;
            panel.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void Film_MouseLeave(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            Panel panel = ctrl as Panel ?? ctrl.Parent as Panel;

            if (panel == null) return;

            panel.BackColor = Color.FromArgb(45, 45, 45); 
        }
        public class Film
        {
            public string Naziv { get; set; }
            public string PutanjaPozadine { get; set; }
        }
        List<Film> filmovi = new List<Film>();
        private void FilmKlik(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            Panel panel = ctrl as Panel ?? ctrl.Parent as Panel;

            if (panel != null)
            {
                int filmID = Convert.ToInt32(panel.Tag);
                Detalji f = new Detalji(filmID, korisnikID);
                f.Show();
            }
        }
        private void UcitajTop10()
        {
            flowTop10.Controls.Clear();

            using (SqlConnection conn = new SqlConnection(Konekcija.String))
            {
                conn.Open();

                string query = @"SELECT TOP 10 FilmID, Naziv, PutanjaPostera FROM Film ORDER BY NEWID()";
                Label lblTop10 = new Label();
                lblTop10.Text = "🔥 Top 10 filmova";
                lblTop10.ForeColor = Color.FromArgb(180, 0, 0);
                lblTop10.Font = new Font("MV Boli", 20, FontStyle.Bold);
                lblTop10.Size = new Size(150, 220);
                lblTop10.TextAlign = ContentAlignment.MiddleLeft;

                flowTop10.Controls.Add(lblTop10);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Panel panelFilm = new Panel();
                    panelFilm.Size = new Size(140, 220);
                    panelFilm.BackColor = Color.FromArgb(45, 45, 45);
                    panelFilm.Margin = new Padding(10);
                    int filmID = Convert.ToInt32(reader["FilmID"]);
                    panelFilm.Tag = filmID;

                    PictureBox pic = new PictureBox();
                    pic.Size = new Size(130, 160);
                    pic.Location = new Point(10, 10);
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                    pic.BackColor = Color.Black;

                    string putanja = reader["PutanjaPostera"].ToString();

                    try
                    {
                        if (!string.IsNullOrWhiteSpace(putanja) && System.IO.File.Exists(putanja))
                        {
                            using (var temp = Image.FromFile(putanja))
                            {
                                pic.Image = new Bitmap(temp);
                            }
                        }
                        else
                        {
                            pic.BackColor = Color.DarkGray;
                        }
                    }
                    catch
                    {
                        pic.BackColor = Color.Red;
                    }

                    Label lbl = new Label();
                    lbl.Text = reader["Naziv"].ToString();
                    lbl.ForeColor = Color.White;
                    lbl.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    lbl.Size = new Size(130, 40);
                    lbl.Location = new Point(10, 175);
                    lbl.TextAlign = ContentAlignment.MiddleCenter;

                    panelFilm.Controls.Add(pic);
                    panelFilm.Controls.Add(lbl);

                    panelFilm.Click += FilmKlik;
                    pic.Click += FilmKlik;
                    lbl.Click += FilmKlik;

                    panelFilm.MouseEnter += Film_MouseEnter;
                    panelFilm.MouseLeave += Film_MouseLeave;
                    pic.MouseEnter += Film_MouseEnter;
                    pic.MouseLeave += Film_MouseLeave;

                    lbl.MouseEnter += Film_MouseEnter;
                    lbl.MouseLeave += Film_MouseLeave;

                    flowTop10.Controls.Add(panelFilm);
                }

                reader.Close();
            }
        }

        private void btnSviFilmovi_Click_1(object sender, EventArgs e)
        {
            Glavna g = new Glavna(korisnikID);
            g.Show();
            this.Hide();
        }

        private void btnPocetna_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(180, 0, 0);
        }

        private void btnPocetna_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(24, 24, 24);
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

        private void btnMojiFilmovi_Click(object sender, EventArgs e)
        {
            MojiFilmovi mf = new MojiFilmovi(korisnikID);
            mf.Show();
            this.Hide();
        }
    }
}