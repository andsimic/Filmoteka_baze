namespace Filmoteka_baze
{
    partial class Pocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pocetna));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.panelMeni = new System.Windows.Forms.Panel();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnDodajFilm = new System.Windows.Forms.Button();
            this.btnMojiFilmovi = new System.Windows.Forms.Button();
            this.btnSviFilmovi = new System.Windows.Forms.Button();
            this.btnPocetna = new System.Windows.Forms.Button();
            this.pnlGlavni = new System.Windows.Forms.Panel();
            this.flowTop10 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPozadina = new System.Windows.Forms.Panel();
            this.lblNazivFilma = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.pbPozadina = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            this.panelMeni.SuspendLayout();
            this.pnlGlavni.SuspendLayout();
            this.pnlPozadina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPozadina)).BeginInit();
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
            this.panelHeader.Size = new System.Drawing.Size(1350, 80);
            this.panelHeader.TabIndex = 5;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnZatvori.FlatAppearance.BorderSize = 0;
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvori.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvori.ForeColor = System.Drawing.Color.White;
            this.btnZatvori.Location = new System.Drawing.Point(1298, 10);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(40, 40);
            this.btnZatvori.TabIndex = 4;
            this.btnZatvori.Text = "✕";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            this.btnZatvori.MouseEnter += new System.EventHandler(this.btnZatvori_MouseEnter);
            this.btnZatvori.MouseLeave += new System.EventHandler(this.btnZatvori_MouseLeave);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.Color.White;
            this.lblNaslov.Location = new System.Drawing.Point(20, 10);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(234, 54);
            this.lblNaslov.TabIndex = 3;
            this.lblNaslov.Text = "FILMOTEKA";
            // 
            // panelMeni
            // 
            this.panelMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panelMeni.Controls.Add(this.btnOdjava);
            this.panelMeni.Controls.Add(this.btnDodajFilm);
            this.panelMeni.Controls.Add(this.btnMojiFilmovi);
            this.panelMeni.Controls.Add(this.btnSviFilmovi);
            this.panelMeni.Controls.Add(this.btnPocetna);
            this.panelMeni.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMeni.Location = new System.Drawing.Point(0, 80);
            this.panelMeni.Name = "panelMeni";
            this.panelMeni.Size = new System.Drawing.Size(220, 790);
            this.panelMeni.TabIndex = 6;
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnOdjava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdjava.FlatAppearance.BorderSize = 0;
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjava.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.ForeColor = System.Drawing.Color.White;
            this.btnOdjava.Image = ((System.Drawing.Image)(resources.GetObject("btnOdjava.Image")));
            this.btnOdjava.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdjava.Location = new System.Drawing.Point(0, 440);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOdjava.Size = new System.Drawing.Size(220, 60);
            this.btnOdjava.TabIndex = 4;
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
            this.btnDodajFilm.ForeColor = System.Drawing.Color.White;
            this.btnDodajFilm.Image = ((System.Drawing.Image)(resources.GetObject("btnDodajFilm.Image")));
            this.btnDodajFilm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajFilm.Location = new System.Drawing.Point(0, 350);
            this.btnDodajFilm.Name = "btnDodajFilm";
            this.btnDodajFilm.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDodajFilm.Size = new System.Drawing.Size(220, 60);
            this.btnDodajFilm.TabIndex = 3;
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
            this.btnMojiFilmovi.ForeColor = System.Drawing.Color.White;
            this.btnMojiFilmovi.Image = ((System.Drawing.Image)(resources.GetObject("btnMojiFilmovi.Image")));
            this.btnMojiFilmovi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMojiFilmovi.Location = new System.Drawing.Point(0, 260);
            this.btnMojiFilmovi.Name = "btnMojiFilmovi";
            this.btnMojiFilmovi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMojiFilmovi.Size = new System.Drawing.Size(220, 60);
            this.btnMojiFilmovi.TabIndex = 2;
            this.btnMojiFilmovi.Text = "Moji Filmovi";
            this.btnMojiFilmovi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMojiFilmovi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMojiFilmovi.UseVisualStyleBackColor = false;
            this.btnMojiFilmovi.Click += new System.EventHandler(this.btnMojiFilmovi_Click);
            this.btnMojiFilmovi.MouseEnter += new System.EventHandler(this.btnPocetna_MouseEnter);
            this.btnMojiFilmovi.MouseLeave += new System.EventHandler(this.btnPocetna_MouseLeave);
            // 
            // btnSviFilmovi
            // 
            this.btnSviFilmovi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnSviFilmovi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSviFilmovi.FlatAppearance.BorderSize = 0;
            this.btnSviFilmovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSviFilmovi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSviFilmovi.ForeColor = System.Drawing.Color.White;
            this.btnSviFilmovi.Image = ((System.Drawing.Image)(resources.GetObject("btnSviFilmovi.Image")));
            this.btnSviFilmovi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSviFilmovi.Location = new System.Drawing.Point(0, 170);
            this.btnSviFilmovi.Name = "btnSviFilmovi";
            this.btnSviFilmovi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSviFilmovi.Size = new System.Drawing.Size(220, 60);
            this.btnSviFilmovi.TabIndex = 1;
            this.btnSviFilmovi.Text = "Svi Filmovi";
            this.btnSviFilmovi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSviFilmovi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSviFilmovi.UseVisualStyleBackColor = false;
            this.btnSviFilmovi.Click += new System.EventHandler(this.btnSviFilmovi_Click_1);
            this.btnSviFilmovi.MouseEnter += new System.EventHandler(this.btnPocetna_MouseEnter);
            this.btnSviFilmovi.MouseLeave += new System.EventHandler(this.btnPocetna_MouseLeave);
            // 
            // btnPocetna
            // 
            this.btnPocetna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnPocetna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPocetna.FlatAppearance.BorderSize = 0;
            this.btnPocetna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPocetna.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPocetna.ForeColor = System.Drawing.Color.White;
            this.btnPocetna.Image = ((System.Drawing.Image)(resources.GetObject("btnPocetna.Image")));
            this.btnPocetna.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPocetna.Location = new System.Drawing.Point(0, 80);
            this.btnPocetna.Name = "btnPocetna";
            this.btnPocetna.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPocetna.Size = new System.Drawing.Size(220, 60);
            this.btnPocetna.TabIndex = 0;
            this.btnPocetna.Text = "Početna";
            this.btnPocetna.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPocetna.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPocetna.UseVisualStyleBackColor = false;
            this.btnPocetna.MouseEnter += new System.EventHandler(this.btnPocetna_MouseEnter);
            this.btnPocetna.MouseLeave += new System.EventHandler(this.btnPocetna_MouseLeave);
            // 
            // pnlGlavni
            // 
            this.pnlGlavni.AutoScroll = true;
            this.pnlGlavni.Controls.Add(this.flowTop10);
            this.pnlGlavni.Controls.Add(this.pnlPozadina);
            this.pnlGlavni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGlavni.Location = new System.Drawing.Point(220, 80);
            this.pnlGlavni.Name = "pnlGlavni";
            this.pnlGlavni.Size = new System.Drawing.Size(1130, 790);
            this.pnlGlavni.TabIndex = 7;
            // 
            // flowTop10
            // 
            this.flowTop10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowTop10.Location = new System.Drawing.Point(0, 450);
            this.flowTop10.Name = "flowTop10";
            this.flowTop10.Size = new System.Drawing.Size(1130, 340);
            this.flowTop10.TabIndex = 1;
            // 
            // pnlPozadina
            // 
            this.pnlPozadina.AutoScroll = true;
            this.pnlPozadina.Controls.Add(this.lblNazivFilma);
            this.pnlPozadina.Controls.Add(this.lblOpis);
            this.pnlPozadina.Controls.Add(this.pbPozadina);
            this.pnlPozadina.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPozadina.Location = new System.Drawing.Point(0, 0);
            this.pnlPozadina.Name = "pnlPozadina";
            this.pnlPozadina.Size = new System.Drawing.Size(1130, 450);
            this.pnlPozadina.TabIndex = 0;
            // 
            // lblNazivFilma
            // 
            this.lblNazivFilma.AutoSize = true;
            this.lblNazivFilma.BackColor = System.Drawing.Color.Transparent;
            this.lblNazivFilma.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivFilma.ForeColor = System.Drawing.Color.White;
            this.lblNazivFilma.Location = new System.Drawing.Point(30, 320);
            this.lblNazivFilma.Name = "lblNazivFilma";
            this.lblNazivFilma.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblNazivFilma.Size = new System.Drawing.Size(193, 64);
            this.lblNazivFilma.TabIndex = 1;
            this.lblNazivFilma.Text = "label1";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.BackColor = System.Drawing.Color.Transparent;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpis.ForeColor = System.Drawing.Color.LightGray;
            this.lblOpis.Location = new System.Drawing.Point(30, 380);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblOpis.Size = new System.Drawing.Size(123, 40);
            this.lblOpis.TabIndex = 2;
            this.lblOpis.Text = "label1";
            // 
            // pbPozadina
            // 
            this.pbPozadina.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPozadina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPozadina.Location = new System.Drawing.Point(0, 0);
            this.pbPozadina.Name = "pbPozadina";
            this.pbPozadina.Size = new System.Drawing.Size(1130, 450);
            this.pbPozadina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPozadina.TabIndex = 0;
            this.pbPozadina.TabStop = false;
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1350, 870);
            this.Controls.Add(this.pnlGlavni);
            this.Controls.Add(this.panelMeni);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pocetna";
            this.Text = "Pocetna";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pocetna_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMeni.ResumeLayout(false);
            this.pnlGlavni.ResumeLayout(false);
            this.pnlPozadina.ResumeLayout(false);
            this.pnlPozadina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPozadina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Panel panelMeni;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnDodajFilm;
        private System.Windows.Forms.Button btnMojiFilmovi;
        private System.Windows.Forms.Button btnSviFilmovi;
        private System.Windows.Forms.Button btnPocetna;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Panel pnlGlavni;
        private System.Windows.Forms.FlowLayoutPanel flowTop10;
        private System.Windows.Forms.Panel pnlPozadina;
        private System.Windows.Forms.PictureBox pbPozadina;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblNazivFilma;
    }
}