using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Filmoteka_baze
{
    public partial class Glavna : Form
    {
        int korisnikID;
        string konekcija =Konekcija.String;
        int trenutnaStrana = 1;
        int poStrani = 20;

        Panel hoverPanel = null;
        bool hoverEnter = false;
        public Glavna()
        {
            InitializeComponent();
        }
        public Glavna(int korisnikID)
        {
            InitializeComponent();
            this.korisnikID = korisnikID;
        }
        public int UkupnoFilmova()
        {
            using (SqlConnection conn = new SqlConnection(konekcija))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Film", conn);
                return (int)cmd.ExecuteScalar();
            }
        }
        private void UcitajFilmove()
    {
        flowFilmovi.Controls.Clear();

        using (SqlConnection conn = new SqlConnection(konekcija))
        {
              
                conn.Open();

                int offset = (trenutnaStrana - 1) * poStrani;

                string query = @"
SELECT FilmID, Naziv, PutanjaPostera
FROM Film
ORDER BY FilmID
OFFSET @offset ROWS FETCH NEXT @limit ROWS ONLY";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@offset", offset);
                cmd.Parameters.AddWithValue("@limit", poStrani);
               
            SqlDataReader reader = cmd.ExecuteReader();
            

                while (reader.Read())
            {
                Panel panelFilm = new Panel();
                panelFilm.Size = new Size(180, 260);
                panelFilm.BackColor = Color.FromArgb(45, 45, 45);
                panelFilm.Margin = new Padding(10);
                int filmID = Convert.ToInt32(reader["FilmID"]);
                panelFilm.Tag = filmID;

                    PictureBox pic = new PictureBox();
                pic.Size = new Size(160, 200);
                pic.Location = new Point(10, 10);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.BackColor = Color.Black;

                    string putanja = Path.Combine(Application.StartupPath, reader["PutanjaPostera"].ToString());

                    try
                {
                    if (!string.IsNullOrWhiteSpace(putanja) && File.Exists(putanja))
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
                lbl.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                lbl.Size = new Size(160, 40);
                lbl.Location = new Point(10, 215);
                lbl.TextAlign = ContentAlignment.MiddleCenter;

                panelFilm.Controls.Add(pic);
                panelFilm.Controls.Add(lbl);

                panelFilm.Click += FilmKlik;
                pic.Click += FilmKlik;
                lbl.Click += FilmKlik;

                panelFilm.Cursor = Cursors.Hand;
                pic.Cursor = Cursors.Hand;
                lbl.Cursor = Cursors.Hand;

                panelFilm.MouseEnter += Film_MouseEnter;
                panelFilm.MouseLeave += Film_MouseLeave;

                pic.MouseEnter += Film_MouseEnter;
                pic.MouseLeave += Film_MouseLeave;

                lbl.MouseEnter += Film_MouseEnter;
                lbl.MouseLeave += Film_MouseLeave;

                    flowFilmovi.Controls.Add(panelFilm);
            }

            reader.Close();
             
                int ukupno = UkupnoFilmova();

                btnPrev.Enabled = trenutnaStrana > 1;
                btnNext.Enabled = trenutnaStrana * poStrani < ukupno;
            }
    }
        private void FilmKlik(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;

            Panel panel = ctrl as Panel ?? ctrl.Parent as Panel;

            if (panel != null)
            {
                int filmID = Convert.ToInt32(panel.Tag);

                Detalji forma = new Detalji(filmID, korisnikID);
                forma.Show();
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
        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPocetna_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(180, 0, 0);
        }

        private void btnPocetna_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(24, 24, 24);
        }
        private void AzurirajStranu()
        {
            lblStrana.Text = $"Strana {trenutnaStrana}";
        }
        private void Glavna_Load(object sender, EventArgs e)
        {
            UcitajFilmove();
            NamestiNavigaciju();
            panelNavigacija.BringToFront();
            AzurirajStranu();
        }
        private void NamestiNavigaciju()
        {
            btnPrev.Location = new Point(panelNavigacija.Width / 2 - 120, 10);
            lblStrana.Location = new Point(panelNavigacija.Width / 2 - 30, 15);
            btnNext.Location = new Point(panelNavigacija.Width / 2 + 60, 10);
        }
        private void btnZatvori_MouseEnter(object sender, EventArgs e)
        {

            btnZatvori.BackColor = Color.FromArgb(180, 0, 0);
        }

        private void btnZatvori_MouseLeave(object sender, EventArgs e)
        {
            btnZatvori.BackColor = Color.FromArgb(18, 18, 18);
        }

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            Pocetna p = new Pocetna(korisnikID);
            p.Show();
            this.Hide();
    }
   

        private void btnNext_Click(object sender, EventArgs e)
        {
            trenutnaStrana++;
            UcitajFilmove();
            AzurirajStranu();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (trenutnaStrana > 1)
            {
                trenutnaStrana--;
                UcitajFilmove();
                AzurirajStranu();
            }
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
