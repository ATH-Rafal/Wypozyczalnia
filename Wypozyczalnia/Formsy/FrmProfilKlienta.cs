using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wypozyczalnia.Formsy
{
    public partial class FrmProfilKlienta : Form
    {
        public FrmProfilKlienta()
        {
            InitializeComponent();
        }

        private void pnl_dane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void nr_klienta_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_powrot_menu_Click(object sender, EventArgs e)
        {
            FrmProfilKlienta frmProfilKlienta = new FrmProfilKlienta();
            this.Hide();
            frmProfilKlienta.ShowDialog();
            this.Show();
        }
    }
}
