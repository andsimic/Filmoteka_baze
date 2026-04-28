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
using static Filmoteka_baze.Pocetna;

namespace Filmoteka_baze
{
    public partial class MojiFilmovi : Form
    {
        int korisnikID;
        
        public MojiFilmovi(int korisnikID)
        {
            InitializeComponent();
            this.korisnikID = korisnikID;
        }
        private void FilmKlik(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            Panel panel = ctrl as Panel ?? ctrl.Parent as Panel;

            if (panel != null)
            {
                int filmID = Convert.ToInt32(panel.Tag);

                Detalji d = new Detalji(filmID, korisnikID, true);
                d.Show();
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
        private void UcitajMojeFilmove()
        {
            flowMojiFilmovi.Controls.Clear();

            using (SqlConnection conn = new SqlConnection(Konekcija.String))
            {
                conn.Open();

                string query = @"
        SELECT f.FilmID, f.Naziv, f.PutanjaPostera
        FROM Film f
        JOIN KorisnikFilm kf ON f.FilmID = kf.FilmID
        WHERE kf.KorisnikID = @korisnikID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@korisnikID", korisnikID);

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

                    string putanja = reader["PutanjaPostera"].ToString();

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

                    Label lbl = new Label();
                    lbl.Text = reader["Naziv"].ToString();
                    lbl.ForeColor = Color.White;
                    lbl.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    lbl.Size = new Size(160, 40);
                    lbl.Location = new Point(10, 215);
                    lbl.TextAlign = ContentAlignment.MiddleCenter;

                    panelFilm.Controls.Add(pic);
                    panelFilm.Controls.Add(lbl);

                    // klik
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

                    flowMojiFilmovi.Controls.Add(panelFilm);
                }

                reader.Close();
            }
        }

        private void MojiFilmovi_Load(object sender, EventArgs e)
        {
            UcitajMojeFilmove();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            Pocetna p = new Pocetna(korisnikID);
            p.Show();
            this.Hide();
        }

        private void btnFilmovi_Click(object sender, EventArgs e)
        {
            Glavna g = new Glavna(korisnikID);
            g.Show();
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

        private void btnPocetna_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(180, 0, 0);
        }

        private void btnPocetna_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(24, 24, 24);
        }
    }
}
