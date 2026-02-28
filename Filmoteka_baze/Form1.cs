using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Filmoteka_baze
{
    public partial class Glavna : Form
    {
        string konekcija = @"Server=DESKTOP-VL9Q1G1\SQLEXPRESS;Database=Filmoteka;Trusted_Connection=True;";

        Panel hoverPanel = null;
        bool hoverEnter = false;
        public Glavna()
        {
            InitializeComponent();
        }

private void UcitajFilmove()
    {
        flowFilmovi.Controls.Clear();

        using (SqlConnection conn = new SqlConnection(konekcija))
        {
            conn.Open();

            string query = "SELECT FilmID, Naziv, PutanjaPostera FROM Film";
            SqlCommand cmd = new SqlCommand(query, conn);
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
        }
    }
        private void FilmKlik(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;

            // uzmi parent panel ako je klik na label ili picturebox
            Panel panel = ctrl as Panel ?? ctrl.Parent as Panel;

            if (panel != null)
            {
                int filmID = Convert.ToInt32(panel.Tag);

                Detalji forma = new Detalji(filmID);
                forma.ShowDialog();
            }
        }
        private void Film_MouseEnter(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;

            Panel panel = ctrl as Panel ?? ctrl.Parent as Panel;

            if (panel == null) return;

            panel.BackColor = Color.FromArgb(60, 60, 60);

            foreach (Control c in panel.Controls)
            {
                if (c is PictureBox pic)
                {
                    pic.Size = new Size(170, 210);
                    pic.Location = new Point(5, 5);
                }
            }
        }

        private void Film_MouseLeave(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;

            Panel panel = ctrl as Panel ?? ctrl.Parent as Panel;

            if (panel == null) return;

            panel.BackColor = Color.FromArgb(45, 45, 45);

            foreach (Control c in panel.Controls)
            {
                if (c is PictureBox pic)
                {
                    pic.Size = new Size(160, 200);
                    pic.Location = new Point(10, 10);
                }
            }
        }
        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPocetna_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(40, 40, 40);
        }

        private void btnPocetna_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(24, 24, 24);
        }

        private void Glavna_Load(object sender, EventArgs e)
        {
            UcitajFilmove();
        }
    }
}
