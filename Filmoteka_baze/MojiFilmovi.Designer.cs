namespace Filmoteka_baze
{
    partial class MojiFilmovi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MojiFilmovi));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.panelMeni = new System.Windows.Forms.Panel();
            this.btnPocetna = new System.Windows.Forms.Button();
            this.btnFilmovi = new System.Windows.Forms.Button();
            this.btnMojiFilmovi = new System.Windows.Forms.Button();
            this.btnDodajFilm = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.flowMojiFilmovi = new System.Windows.Forms.FlowLayoutPanel();
            this.panelHeader.SuspendLayout();
            this.panelMeni.SuspendLayout();
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
            this.btnZatvori.ForeColor = System.Drawing.Color.White;
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
            this.lblNaslov.ForeColor = System.Drawing.Color.LightGray;
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
            this.panelMeni.Controls.Add(this.btnFilmovi);
            this.panelMeni.Controls.Add(this.btnPocetna);
            this.panelMeni.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMeni.Location = new System.Drawing.Point(0, 80);
            this.panelMeni.Name = "panelMeni";
            this.panelMeni.Size = new System.Drawing.Size(220, 665);
            this.panelMeni.TabIndex = 4;
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
            this.btnPocetna.TabIndex = 1;
            this.btnPocetna.Text = "Početna";
            this.btnPocetna.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPocetna.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPocetna.UseVisualStyleBackColor = false;
            this.btnPocetna.Click += new System.EventHandler(this.btnPocetna_Click);
            this.btnPocetna.MouseEnter += new System.EventHandler(this.btnPocetna_MouseEnter);
            this.btnPocetna.MouseLeave += new System.EventHandler(this.btnPocetna_MouseLeave);
            // 
            // btnFilmovi
            // 
            this.btnFilmovi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnFilmovi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilmovi.FlatAppearance.BorderSize = 0;
            this.btnFilmovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilmovi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilmovi.ForeColor = System.Drawing.Color.White;
            this.btnFilmovi.Image = ((System.Drawing.Image)(resources.GetObject("btnFilmovi.Image")));
            this.btnFilmovi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilmovi.Location = new System.Drawing.Point(0, 170);
            this.btnFilmovi.Name = "btnFilmovi";
            this.btnFilmovi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFilmovi.Size = new System.Drawing.Size(220, 60);
            this.btnFilmovi.TabIndex = 1;
            this.btnFilmovi.Text = "Svi Filmovi";
            this.btnFilmovi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilmovi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFilmovi.UseVisualStyleBackColor = false;
            this.btnFilmovi.Click += new System.EventHandler(this.btnFilmovi_Click);
            this.btnFilmovi.MouseEnter += new System.EventHandler(this.btnPocetna_MouseEnter);
            this.btnFilmovi.MouseLeave += new System.EventHandler(this.btnPocetna_MouseLeave);
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
            this.btnMojiFilmovi.TabIndex = 6;
            this.btnMojiFilmovi.Text = "Moji Filmovi";
            this.btnMojiFilmovi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMojiFilmovi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMojiFilmovi.UseVisualStyleBackColor = false;
            this.btnMojiFilmovi.MouseEnter += new System.EventHandler(this.btnPocetna_MouseEnter);
            this.btnMojiFilmovi.MouseLeave += new System.EventHandler(this.btnPocetna_MouseLeave);
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
            this.btnDodajFilm.TabIndex = 7;
            this.btnDodajFilm.Text = "Dodaj Film";
            this.btnDodajFilm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajFilm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodajFilm.UseVisualStyleBackColor = false;
            this.btnDodajFilm.MouseEnter += new System.EventHandler(this.btnPocetna_MouseEnter);
            this.btnDodajFilm.MouseLeave += new System.EventHandler(this.btnPocetna_MouseLeave);
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
            this.btnOdjava.TabIndex = 8;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdjava.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            this.btnOdjava.MouseEnter += new System.EventHandler(this.btnPocetna_MouseEnter);
            this.btnOdjava.MouseLeave += new System.EventHandler(this.btnPocetna_MouseLeave);
            // 
            // flowMojiFilmovi
            // 
            this.flowMojiFilmovi.AutoScroll = true;
            this.flowMojiFilmovi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowMojiFilmovi.Location = new System.Drawing.Point(220, 80);
            this.flowMojiFilmovi.Name = "flowMojiFilmovi";
            this.flowMojiFilmovi.Size = new System.Drawing.Size(1109, 665);
            this.flowMojiFilmovi.TabIndex = 6;
            // 
            // MojiFilmovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1329, 745);
            this.Controls.Add(this.flowMojiFilmovi);
            this.Controls.Add(this.panelMeni);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MojiFilmovi";
            this.Text = "MojiFilmovi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MojiFilmovi_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMeni.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Panel panelMeni;
        private System.Windows.Forms.Button btnPocetna;
        private System.Windows.Forms.Button btnFilmovi;
        private System.Windows.Forms.Button btnMojiFilmovi;
        private System.Windows.Forms.Button btnDodajFilm;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.FlowLayoutPanel flowMojiFilmovi;
    }
}