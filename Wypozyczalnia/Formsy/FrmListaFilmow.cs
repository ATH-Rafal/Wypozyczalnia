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
    public partial class FrmListaFilmow : Form
    {
        public FrmListaFilmow()
        {
            InitializeComponent();
        }

        private void FrmListaFilmow_Load(object sender, EventArgs e)
        {

        }

        private void btn_dodaj_film_Click(object sender, EventArgs e)
        {
            FrmDodajFilm frmDodajFilm = new FrmDodajFilm();
            frmDodajFilm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_edytuj_film_Click(object sender, EventArgs e)
        {
            FrmEdytujFilm frmEdytujFilm = new FrmEdytujFilm();
            frmEdytujFilm.ShowDialog();

        }
    }
}
