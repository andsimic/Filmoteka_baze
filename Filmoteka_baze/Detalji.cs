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
        string konekcija = @"Server=DESKTOP-VL9Q1G1\SQLEXPRESS;Database=Filmoteka;Trusted_Connection=True;";
        int filmID;

        public Detalji(int id)
        {
            InitializeComponent();
            filmID = id;

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
    }
}
