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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Lista_Klientów_Click(object sender, EventArgs e)
        {
            FrmListaKlientow frmListaKlientow = new FrmListaKlientow();
            frmListaKlientow.ShowDialog();
        }

        private void Lista_Filmow_Click(object sender, EventArgs e)
        {
            FrmListaFilmow  frmListaFilmow = new FrmListaFilmow();
            frmListaFilmow.ShowDialog();
        }
    }
}
