using System;
using System.Windows.Forms;

namespace Wypozyczalnia.Formsy
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void Lista_Klientów_Click(object sender, EventArgs e)
        {
            FrmListaKlientow frmListaKlientow = new FrmListaKlientow(this.Name);
            this.Hide();
            frmListaKlientow.ShowDialog();
            this.Show();

        }

        private void Lista_Filmow_Click(object sender, EventArgs e)
        {
            FrmListaFilmow  frmListaFilmow = new FrmListaFilmow(this.Name);
            this.Hide();
            frmListaFilmow.ShowDialog();
            this.Show();
        }

        private void Zwrot_Filmow_Click(object sender, EventArgs e)
        {

        }

        private void Lista_Tagow_Click(object sender, EventArgs e)
        {
            FrmListaTagow frmListaTagow = new FrmListaTagow(this.Name);
            this.Hide();
            frmListaTagow.ShowDialog();
            this.Show();
        }

        private void Lista_Wypozyczen_Click(object sender, EventArgs e)
        {
            FrmHistoriaWypozyczen frmHistoriaWypozyczen = new FrmHistoriaWypozyczen();
            this.Hide();
            frmHistoriaWypozyczen.ShowDialog();
            this.Show();
        }
    }
}
