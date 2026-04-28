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
            this.btnZatvori = new System.Windows.Forms.Button();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.panelMeni = new System.Windows.Forms.Panel();
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
            this.lblOnece = new System.Windows.Forms.Label();
            this.axWmpTrailer = new AxWMPLib.AxWindowsMediaPlayer();
            this.picStar2 = new System.Windows.Forms.PictureBox();
            this.picStar3 = new System.Windows.Forms.PictureBox();
            this.picStar5 = new System.Windows.Forms.PictureBox();
            this.picStar4 = new System.Windows.Forms.PictureBox();
            this.picStar1 = new System.Windows.Forms.PictureBox();
            this.pbPozadinaDetalji = new System.Windows.Forms.PictureBox();
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.btnPocetna = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnDodajFilm = new System.Windows.Forms.Button();
            this.btnMojiFilmovi = new System.Windows.Forms.Button();
            this.btnFilmovi = new System.Windows.Forms.Button();
            this.MojaOcena = new System.Windows.Forms.Label();
            this.txtKomentar = new System.Windows.Forms.TextBox();
            this.btnSacuvajKomentar = new System.Windows.Forms.Button();
            this.lblKomentar = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWmpTrailer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPozadinaDetalji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
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
            this.panelHeader.Size = new System.Drawing.Size(1329, 80);
            this.panelHeader.TabIndex = 3;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnZatvori.FlatAppearance.BorderSize = 0;
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvori.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvori.Location = new System.Drawing.Point(1269, 10);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(40, 40);
            this.btnZatvori.TabIndex = 1;
            this.btnZatvori.Text = "✕";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            this.btnZatvori.MouseEnter += new System.EventHandler(this.btnPocetna_MouseEnter);
            this.btnZatvori.MouseLeave += new System.EventHandler(this.btnPocetna_MouseLeave);
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
            // panelMeni
            // 
            this.panelMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panelMeni.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMeni.Location = new System.Drawing.Point(0, 80);
            this.panelMeni.Name = "panelMeni";
            this.panelMeni.Size = new System.Drawing.Size(220, 665);
            this.panelMeni.TabIndex = 4;
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
            this.lblOcena.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcena.ForeColor = System.Drawing.Color.Gold;
            this.lblOcena.Location = new System.Drawing.Point(530, 500);
            this.lblOcena.Name = "lblOcena";
            this.lblOcena.Size = new System.Drawing.Size(155, 45);
            this.lblOcena.TabIndex = 19;
            this.lblOcena.Text = "☆☆☆☆☆";
            // 
            // btnDodajUGledane
            // 
            this.btnDodajUGledane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.btnDodajUGledane.Click += new System.EventHandler(this.btnDodajUGledane_Click);
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
            // lblOnece
            // 
            this.lblOnece.AutoSize = true;
            this.lblOnece.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnece.ForeColor = System.Drawing.Color.Gold;
            this.lblOnece.Location = new System.Drawing.Point(530, 470);
            this.lblOnece.Name = "lblOnece";
            this.lblOnece.Size = new System.Drawing.Size(117, 45);
            this.lblOnece.TabIndex = 24;
            this.lblOnece.Text = "Ocena:";
            // 
            // axWmpTrailer
            // 
            this.axWmpTrailer.Enabled = true;
            this.axWmpTrailer.Location = new System.Drawing.Point(770, 70);
            this.axWmpTrailer.Name = "axWmpTrailer";
            this.axWmpTrailer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWmpTrailer.OcxState")));
            this.axWmpTrailer.Size = new System.Drawing.Size(500, 400);
            this.axWmpTrailer.TabIndex = 22;
            // 
            // picStar2
            // 
            this.picStar2.Location = new System.Drawing.Point(853, 446);
            this.picStar2.Name = "picStar2";
            this.picStar2.Size = new System.Drawing.Size(30, 30);
            this.picStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStar2.TabIndex = 29;
            this.picStar2.TabStop = false;
            // 
            // picStar3
            // 
            this.picStar3.Location = new System.Drawing.Point(889, 446);
            this.picStar3.Name = "picStar3";
            this.picStar3.Size = new System.Drawing.Size(30, 30);
            this.picStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStar3.TabIndex = 28;
            this.picStar3.TabStop = false;
            // 
            // picStar5
            // 
            this.picStar5.Location = new System.Drawing.Point(961, 446);
            this.picStar5.Name = "picStar5";
            this.picStar5.Size = new System.Drawing.Size(30, 30);
            this.picStar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStar5.TabIndex = 27;
            this.picStar5.TabStop = false;
            // 
            // picStar4
            // 
            this.picStar4.Location = new System.Drawing.Point(925, 446);
            this.picStar4.Name = "picStar4";
            this.picStar4.Size = new System.Drawing.Size(30, 30);
            this.picStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStar4.TabIndex = 26;
            this.picStar4.TabStop = false;
            // 
            // picStar1
            // 
            this.picStar1.Location = new System.Drawing.Point(817, 446);
            this.picStar1.Name = "picStar1";
            this.picStar1.Size = new System.Drawing.Size(30, 30);
            this.picStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStar1.TabIndex = 25;
            this.picStar1.TabStop = false;
            // 
            // pbPozadinaDetalji
            // 
            this.pbPozadinaDetalji.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPozadinaDetalji.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbPozadinaDetalji.Location = new System.Drawing.Point(220, 245);
            this.pbPozadinaDetalji.Name = "pbPozadinaDetalji";
            this.pbPozadinaDetalji.Size = new System.Drawing.Size(1109, 500);
            this.pbPozadinaDetalji.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPozadinaDetalji.TabIndex = 23;
            this.pbPozadinaDetalji.TabStop = false;
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
            this.btnPocetna.Click += new System.EventHandler(this.btnPocetna_Click);
            this.btnPocetna.MouseEnter += new System.EventHandler(this.btnPocetna_MouseEnter);
            this.btnPocetna.MouseLeave += new System.EventHandler(this.btnPocetna_MouseLeave);
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
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            this.btnOdjava.MouseEnter += new System.EventHandler(this.btnPocetna_MouseEnter);
            this.btnOdjava.MouseLeave += new System.EventHandler(this.btnPocetna_MouseLeave);
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
            this.btnDodajFilm.MouseEnter += new System.EventHandler(this.btnPocetna_MouseEnter);
            this.btnDodajFilm.MouseLeave += new System.EventHandler(this.btnPocetna_MouseLeave);
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
            this.btnMojiFilmovi.Click += new System.EventHandler(this.btnMojiFilmovi_Click);
            this.btnMojiFilmovi.MouseEnter += new System.EventHandler(this.btnPocetna_MouseEnter);
            this.btnMojiFilmovi.MouseLeave += new System.EventHandler(this.btnPocetna_MouseLeave);
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
            this.btnFilmovi.Click += new System.EventHandler(this.btnFilmovi_Click);
            this.btnFilmovi.MouseEnter += new System.EventHandler(this.btnPocetna_MouseEnter);
            this.btnFilmovi.MouseLeave += new System.EventHandler(this.btnPocetna_MouseLeave);
            // 
            // MojaOcena
            // 
            this.MojaOcena.AutoSize = true;
            this.MojaOcena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MojaOcena.ForeColor = System.Drawing.Color.Gold;
            this.MojaOcena.Location = new System.Drawing.Point(813, 401);
            this.MojaOcena.Name = "MojaOcena";
            this.MojaOcena.Size = new System.Drawing.Size(144, 29);
            this.MojaOcena.TabIndex = 30;
            this.MojaOcena.Text = "Moja ocena:";
            // 
            // txtKomentar
            // 
            this.txtKomentar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtKomentar.ForeColor = System.Drawing.Color.LightGray;
            this.txtKomentar.Location = new System.Drawing.Point(817, 530);
            this.txtKomentar.Multiline = true;
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(300, 80);
            this.txtKomentar.TabIndex = 31;
            // 
            // btnSacuvajKomentar
            // 
            this.btnSacuvajKomentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvajKomentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvajKomentar.ForeColor = System.Drawing.Color.White;
            this.btnSacuvajKomentar.Location = new System.Drawing.Point(868, 616);
            this.btnSacuvajKomentar.Name = "btnSacuvajKomentar";
            this.btnSacuvajKomentar.Size = new System.Drawing.Size(204, 52);
            this.btnSacuvajKomentar.TabIndex = 32;
            this.btnSacuvajKomentar.Text = "Sačuvaj komentar";
            this.btnSacuvajKomentar.UseVisualStyleBackColor = true;
            this.btnSacuvajKomentar.Click += new System.EventHandler(this.btnSacuvajKomentar_Click);
            // 
            // lblKomentar
            // 
            this.lblKomentar.AutoSize = true;
            this.lblKomentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKomentar.ForeColor = System.Drawing.Color.White;
            this.lblKomentar.Location = new System.Drawing.Point(812, 487);
            this.lblKomentar.Name = "lblKomentar";
            this.lblKomentar.Size = new System.Drawing.Size(165, 29);
            this.lblKomentar.TabIndex = 33;
            this.lblKomentar.Text = "Vaš komentar:";
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnObrisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnObrisi.FlatAppearance.BorderSize = 0;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.ForeColor = System.Drawing.Color.White;
            this.btnObrisi.Location = new System.Drawing.Point(250, 673);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(274, 49);
            this.btnObrisi.TabIndex = 34;
            this.btnObrisi.Text = "Obriši iz mojih filmova";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // Detalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1329, 745);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.lblKomentar);
            this.Controls.Add(this.btnSacuvajKomentar);
            this.Controls.Add(this.txtKomentar);
            this.Controls.Add(this.MojaOcena);
            this.Controls.Add(this.picStar2);
            this.Controls.Add(this.picStar3);
            this.Controls.Add(this.picStar5);
            this.Controls.Add(this.picStar4);
            this.Controls.Add(this.picStar1);
            this.Controls.Add(this.pbPozadinaDetalji);
            this.Controls.Add(this.axWmpTrailer);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnDodajUGledane);
            this.Controls.Add(this.lblOnece);
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
            this.Load += new System.EventHandler(this.Detalji_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWmpTrailer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPozadinaDetalji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
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
        private System.Windows.Forms.PictureBox pbPozadinaDetalji;
        private System.Windows.Forms.Label lblOnece;
        private System.Windows.Forms.PictureBox picStar1;
        private System.Windows.Forms.PictureBox picStar4;
        private System.Windows.Forms.PictureBox picStar5;
        private System.Windows.Forms.PictureBox picStar3;
        private System.Windows.Forms.PictureBox picStar2;
        private System.Windows.Forms.Label MojaOcena;
        private System.Windows.Forms.TextBox txtKomentar;
        private System.Windows.Forms.Button btnSacuvajKomentar;
        private System.Windows.Forms.Label lblKomentar;
        private System.Windows.Forms.Button btnObrisi;
    }
}