namespace Filmoteka_baze
{
    partial class CustomMessageBoxOdjava
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
            this.lblPoruka = new System.Windows.Forms.Label();
            this.btnDA = new System.Windows.Forms.Button();
            this.btnNE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPoruka
            // 
            this.lblPoruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoruka.ForeColor = System.Drawing.Color.White;
            this.lblPoruka.Location = new System.Drawing.Point(6, -1);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(260, 71);
            this.lblPoruka.TabIndex = 1;
            this.lblPoruka.Text = "Da li ste sigurni da želite da se odjavite?";
            this.lblPoruka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDA
            // 
            this.btnDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDA.FlatAppearance.BorderSize = 0;
            this.btnDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDA.Location = new System.Drawing.Point(22, 92);
            this.btnDA.Name = "btnDA";
            this.btnDA.Size = new System.Drawing.Size(100, 30);
            this.btnDA.TabIndex = 2;
            this.btnDA.Text = "DA";
            this.btnDA.UseVisualStyleBackColor = false;
            this.btnDA.Click += new System.EventHandler(this.btnDA_Click);
            // 
            // btnNE
            // 
            this.btnNE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnNE.FlatAppearance.BorderSize = 0;
            this.btnNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNE.ForeColor = System.Drawing.Color.LightGray;
            this.btnNE.Location = new System.Drawing.Point(138, 92);
            this.btnNE.Name = "btnNE";
            this.btnNE.Size = new System.Drawing.Size(100, 30);
            this.btnNE.TabIndex = 3;
            this.btnNE.Text = "NE";
            this.btnNE.UseVisualStyleBackColor = false;
            this.btnNE.Click += new System.EventHandler(this.btnNE_Click);
            // 
            // CustomMessageBoxOdjava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(278, 134);
            this.Controls.Add(this.btnNE);
            this.Controls.Add(this.btnDA);
            this.Controls.Add(this.lblPoruka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomMessageBoxOdjava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomMessageBoxOdjava";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.Button btnDA;
        private System.Windows.Forms.Button btnNE;
    }
}