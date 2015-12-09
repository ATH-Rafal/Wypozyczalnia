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
            frmListaKlientow.ShowDialog();
        }

        private void Lista_Filmow_Click(object sender, EventArgs e)
        {
            FrmListaFilmow  frmListaFilmow = new FrmListaFilmow(this.Name);
            frmListaFilmow.ShowDialog();
        }

        private void Lista_Tagow_Click(object sender, EventArgs e)
        {
            FrmListaTagow frmListaTagow = new FrmListaTagow(this.Name);
            frmListaTagow.ShowDialog();
        }

        private void Lista_Wypozyczen_Click(object sender, EventArgs e)
        {
            FrmHistoriaWypozyczen frmHistoriaWypozyczen = new FrmHistoriaWypozyczen();
            frmHistoriaWypozyczen.ShowDialog();
        }

        private void Lista_Taryf_Click(object sender, EventArgs e)
        {
            FrmListaTaryf frmListaTaryf = new FrmListaTaryf();
            frmListaTaryf.ShowDialog();
        }
    }
}
