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
            FrmListaKlientow frmListaKlientow = new FrmListaKlientow();
            this.Hide();
            frmListaKlientow.ShowDialog();
            this.Show();

        }

        private void Lista_Filmow_Click(object sender, EventArgs e)
        {
            FrmListaFilmow  frmListaFilmow = new FrmListaFilmow();
            this.Hide();
            frmListaFilmow.ShowDialog();
            this.Show();
        }
    }
}
