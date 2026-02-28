namespace Filmoteka_baze
{
    partial class Detalji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detalji));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.panelMeni = new System.Windows.Forms.Panel();
            this.btnPocetna = new System.Windows.Forms.Button();
            this.btnFilmovi = new System.Windows.Forms.Button();
            this.btnMojiFilmovi = new System.Windows.Forms.Button();
            this.btnDodajFilm = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblinfoOsnovno = new System.Windows.Forms.Label();
            this.lblStudio = new System.Windows.Forms.Label();
            this.lblStudioIme = new System.Windows.Forms.Label();
            this.lblReziser = new System.Windows.Forms.Label();
            this.lblReziserIme = new System.Windows.Forms.Label();
            this.lblGlumci = new System.Windows.Forms.Label();
            this.lblGlumciLista = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblOpisNaziv = new System.Windows.Forms.Label();
            this.lblOcena = new System.Windows.Forms.Label();
            this.btnDodajUGledane = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.axWmpTrailer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWmpTrailer)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panelHeader.Controls.Add(this.btnZatvori);
            this.panelHeader.Controls.Add(this.lblNaslov);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1206, 80);
            this.panelHeader.TabIndex = 3;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(20, 10);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(234, 54);
            this.lblNaslov.TabIndex = 3;
            this.lblNaslov.Text = "FILMOTEKA";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnZatvori.FlatAppearance.BorderSize = 0;
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvori.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvori.Location = new System.Drawing.Point(1146, 10);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(40, 40);
            this.btnZatvori.TabIndex = 1;
            this.btnZatvori.Text = "X";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // panelMeni
            // 
            this.panelMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panelMeni.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMeni.Location = new System.Drawing.Point(0, 80);
            this.panelMeni.Name = "panelMeni";
            this.panelMeni.Size = new System.Drawing.Size(220, 531);
            this.panelMeni.TabIndex = 4;
            // 
            // btnPocetna
            // 
            this.btnPocetna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnPocetna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPocetna.FlatAppearance.BorderSize = 0;
            this.btnPocetna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPocetna.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPocetna.Image = ((System.Drawing.Image)(resources.GetObject("btnPocetna.Image")));
            this.btnPocetna.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPocetna.Location = new System.Drawing.Point(0, 170);
            this.btnPocetna.Name = "btnPocetna";
            this.btnPocetna.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPocetna.Size = new System.Drawing.Size(220, 60);
            this.btnPocetna.TabIndex = 1;
            this.btnPocetna.Text = "Početna";
            this.btnPocetna.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPocetna.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPocetna.UseVisualStyleBackColor = false;
            // 
            // btnFilmovi
            // 
            this.btnFilmovi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnFilmovi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilmovi.FlatAppearance.BorderSize = 0;
            this.btnFilmovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilmovi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilmovi.Image = ((System.Drawing.Image)(resources.GetObject("btnFilmovi.Image")));
            this.btnFilmovi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilmovi.Location = new System.Drawing.Point(0, 260);
            this.btnFilmovi.Name = "btnFilmovi";
            this.btnFilmovi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFilmovi.Size = new System.Drawing.Size(220, 60);
            this.btnFilmovi.TabIndex = 2;
            this.btnFilmovi.Text = "Svi Filmovi";
            this.btnFilmovi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilmovi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFilmovi.UseVisualStyleBackColor = false;
            // 
            // btnMojiFilmovi
            // 
            this.btnMojiFilmovi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnMojiFilmovi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMojiFilmovi.FlatAppearance.BorderSize = 0;
            this.btnMojiFilmovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMojiFilmovi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMojiFilmovi.Image = ((System.Drawing.Image)(resources.GetObject("btnMojiFilmovi.Image")));
            this.btnMojiFilmovi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMojiFilmovi.Location = new System.Drawing.Point(0, 350);
            this.btnMojiFilmovi.Name = "btnMojiFilmovi";
            this.btnMojiFilmovi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMojiFilmovi.Size = new System.Drawing.Size(220, 60);
            this.btnMojiFilmovi.TabIndex = 5;
            this.btnMojiFilmovi.Text = "Moji Filmovi";
            this.btnMojiFilmovi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMojiFilmovi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMojiFilmovi.UseVisualStyleBackColor = false;
            // 
            // btnDodajFilm
            // 
            this.btnDodajFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnDodajFilm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodajFilm.FlatAppearance.BorderSize = 0;
            this.btnDodajFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajFilm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajFilm.Image = ((System.Drawing.Image)(resources.GetObject("btnDodajFilm.Image")));
            this.btnDodajFilm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajFilm.Location = new System.Drawing.Point(0, 440);
            this.btnDodajFilm.Name = "btnDodajFilm";
            this.btnDodajFilm.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDodajFilm.Size = new System.Drawing.Size(220, 60);
            this.btnDodajFilm.TabIndex = 6;
            this.btnDodajFilm.Text = "Dodaj Film";
            this.btnDodajFilm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajFilm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodajFilm.UseVisualStyleBackColor = false;
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnOdjava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdjava.FlatAppearance.BorderSize = 0;
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjava.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.Image = ((System.Drawing.Image)(resources.GetObject("btnOdjava.Image")));
            this.btnOdjava.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdjava.Location = new System.Drawing.Point(0, 530);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOdjava.Size = new System.Drawing.Size(220, 60);
            this.btnOdjava.TabIndex = 7;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdjava.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOdjava.UseVisualStyleBackColor = false;
            // 
            // picPoster
            // 
            this.picPoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.picPoster.Location = new System.Drawing.Point(250, 90);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(250, 375);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPoster.TabIndex = 8;
            this.picPoster.TabStop = false;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.BackColor = System.Drawing.Color.Transparent;
            this.lblNaziv.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(530, 90);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(242, 54);
            this.lblNaziv.TabIndex = 9;
            this.lblNaziv.Text = "Naziv Filma";
            // 
            // lblinfoOsnovno
            // 
            this.lblinfoOsnovno.AutoSize = true;
            this.lblinfoOsnovno.BackColor = System.Drawing.Color.Transparent;
            this.lblinfoOsnovno.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfoOsnovno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblinfoOsnovno.Location = new System.Drawing.Point(530, 140);
            this.lblinfoOsnovno.Name = "lblinfoOsnovno";
            this.lblinfoOsnovno.Size = new System.Drawing.Size(214, 30);
            this.lblinfoOsnovno.TabIndex = 10;
            this.lblinfoOsnovno.Text = "2024 | 120 min | USA";
            // 
            // lblStudio
            // 
            this.lblStudio.AutoSize = true;
            this.lblStudio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudio.ForeColor = System.Drawing.Color.White;
            this.lblStudio.Location = new System.Drawing.Point(530, 180);
            this.lblStudio.Name = "lblStudio";
            this.lblStudio.Size = new System.Drawing.Size(85, 30);
            this.lblStudio.TabIndex = 11;
            this.lblStudio.Text = "Studio:";
            // 
            // lblStudioIme
            // 
            this.lblStudioIme.AutoSize = true;
            this.lblStudioIme.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudioIme.Location = new System.Drawing.Point(610, 180);
            this.lblStudioIme.Name = "lblStudioIme";
            this.lblStudioIme.Size = new System.Drawing.Size(116, 30);
            this.lblStudioIme.TabIndex = 12;
            this.lblStudioIme.Text = "Studio ime";
            // 
            // lblReziser
            // 
            this.lblReziser.AutoSize = true;
            this.lblReziser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReziser.ForeColor = System.Drawing.Color.White;
            this.lblReziser.Location = new System.Drawing.Point(530, 210);
            this.lblReziser.Name = "lblReziser";
            this.lblReziser.Size = new System.Drawing.Size(93, 30);
            this.lblReziser.TabIndex = 13;
            this.lblReziser.Text = "Režiser:";
            // 
            // lblReziserIme
            // 
            this.lblReziserIme.AutoSize = true;
            this.lblReziserIme.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReziserIme.Location = new System.Drawing.Point(615, 210);
            this.lblReziserIme.Name = "lblReziserIme";
            this.lblReziserIme.Size = new System.Drawing.Size(135, 30);
            this.lblReziserIme.TabIndex = 14;
            this.lblReziserIme.Text = "Ime Razisera";
            // 
            // lblGlumci
            // 
            this.lblGlumci.AutoSize = true;
            this.lblGlumci.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGlumci.ForeColor = System.Drawing.Color.White;
            this.lblGlumci.Location = new System.Drawing.Point(530, 240);
            this.lblGlumci.Name = "lblGlumci";
            this.lblGlumci.Size = new System.Drawing.Size(91, 30);
            this.lblGlumci.TabIndex = 15;
            this.lblGlumci.Text = "Glumci:";
            // 
            // lblGlumciLista
            // 
            this.lblGlumciLista.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGlumciLista.Location = new System.Drawing.Point(615, 240);
            this.lblGlumciLista.Name = "lblGlumciLista";
            this.lblGlumciLista.Size = new System.Drawing.Size(700, 50);
            this.lblGlumciLista.TabIndex = 16;
            this.lblGlumciLista.Text = "Lista glumaca";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpis.ForeColor = System.Drawing.Color.White;
            this.lblOpis.Location = new System.Drawing.Point(530, 300);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(66, 30);
            this.lblOpis.TabIndex = 17;
            this.lblOpis.Text = "Opis:";
            // 
            // lblOpisNaziv
            // 
            this.lblOpisNaziv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpisNaziv.ForeColor = System.Drawing.Color.White;
            this.lblOpisNaziv.Location = new System.Drawing.Point(530, 330);
            this.lblOpisNaziv.Name = "lblOpisNaziv";
            this.lblOpisNaziv.Size = new System.Drawing.Size(700, 180);
            this.lblOpisNaziv.TabIndex = 18;
            this.lblOpisNaziv.Text = "Opis filma ide ovde...";
            // 
            // lblOcena
            // 
            this.lblOcena.AutoSize = true;
            this.lblOcena.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcena.ForeColor = System.Drawing.Color.Gold;
            this.lblOcena.Location = new System.Drawing.Point(530, 520);
            this.lblOcena.Name = "lblOcena";
            this.lblOcena.Size = new System.Drawing.Size(225, 38);
            this.lblOcena.TabIndex = 19;
            this.lblOcena.Text = "Ocena: ★★★★★";
            // 
            // btnDodajUGledane
            // 
            this.btnDodajUGledane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDodajUGledane.FlatAppearance.BorderSize = 0;
            this.btnDodajUGledane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajUGledane.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajUGledane.ForeColor = System.Drawing.Color.White;
            this.btnDodajUGledane.Location = new System.Drawing.Point(530, 560);
            this.btnDodajUGledane.Name = "btnDodajUGledane";
            this.btnDodajUGledane.Size = new System.Drawing.Size(200, 45);
            this.btnDodajUGledane.TabIndex = 20;
            this.btnDodajUGledane.Text = "Dodaj u gledane";
            this.btnDodajUGledane.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajUGledane.UseVisualStyleBackColor = false;
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnNazad.FlatAppearance.BorderSize = 0;
            this.btnNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.ForeColor = System.Drawing.Color.White;
            this.btnNazad.Location = new System.Drawing.Point(250, 480);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(120, 40);
            this.btnNazad.TabIndex = 21;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // axWmpTrailer
            // 
            this.axWmpTrailer.Enabled = true;
            this.axWmpTrailer.Location = new System.Drawing.Point(770, 90);
            this.axWmpTrailer.Name = "axWmpTrailer";
            this.axWmpTrailer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWmpTrailer.OcxState")));
            this.axWmpTrailer.Size = new System.Drawing.Size(500, 400);
            this.axWmpTrailer.TabIndex = 22;
            // 
            // Detalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1206, 611);
            this.Controls.Add(this.axWmpTrailer);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnDodajUGledane);
            this.Controls.Add(this.lblOcena);
            this.Controls.Add(this.lblOpisNaziv);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblGlumciLista);
            this.Controls.Add(this.lblGlumci);
            this.Controls.Add(this.lblReziserIme);
            this.Controls.Add(this.lblReziser);
            this.Controls.Add(this.lblStudioIme);
            this.Controls.Add(this.lblStudio);
            this.Controls.Add(this.lblinfoOsnovno);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.picPoster);
            this.Controls.Add(this.btnPocetna);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnDodajFilm);
            this.Controls.Add(this.btnMojiFilmovi);
            this.Controls.Add(this.btnFilmovi);
            this.Controls.Add(this.panelMeni);
            this.Controls.Add(this.panelHeader);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Detalji";
            this.Text = "Detalji";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWmpTrailer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Panel panelMeni;
        private System.Windows.Forms.Button btnPocetna;
        private System.Windows.Forms.Button btnFilmovi;
        private System.Windows.Forms.Button btnMojiFilmovi;
        private System.Windows.Forms.Button btnDodajFilm;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.PictureBox picPoster;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblinfoOsnovno;
        private System.Windows.Forms.Label lblStudio;
        private System.Windows.Forms.Label lblStudioIme;
        private System.Windows.Forms.Label lblReziser;
        private System.Windows.Forms.Label lblReziserIme;
        private System.Windows.Forms.Label lblGlumci;
        private System.Windows.Forms.Label lblGlumciLista;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblOpisNaziv;
        private System.Windows.Forms.Label lblOcena;
        private System.Windows.Forms.Button btnDodajUGledane;
        private System.Windows.Forms.Button btnNazad;
        private AxWMPLib.AxWindowsMediaPlayer axWmpTrailer;
    }
}