using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmoteka_baze
{
    public partial class CustomMessageBoxOdjava : Form
    {
        public CustomMessageBoxOdjava(string poruka)
        {
            InitializeComponent();
            lblPoruka.Text = poruka;
        }

        private void btnDA_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btnNE_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
