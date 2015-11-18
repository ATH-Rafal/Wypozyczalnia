using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Wypozyczalnia.Formsy
{
    public partial class FrmDodajFilm : Form
    {
        string connString = "Data Source = baza.db; Version = 3";

        public FrmDodajFilm()
        {
            InitializeComponent();
            cmb_nosnik.SelectedIndex = 0;
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(conn);
                command.CommandText = @"
                                INSERT INTO Filmy (tytul_pol, tytul_org, rok_produkcji, klas_wiekowa, dlugosc, kraj, cena, nosnik, lektor, napisy)
                                VALUES (@tytul_pol, @tytul_org, @rok_produkcji, @klas_wiekowa, @dlugosc, @kraj, @cena, @nosnik, @lektor, @napisy)
                                ";

                command.Parameters.Add(new SQLiteParameter("@tytul_pol", txt_tytul_pol.Text));
                command.Parameters.Add(new SQLiteParameter("@tytul_org", txt_tytul_org.Text));
                command.Parameters.Add(new SQLiteParameter("@rok_produkcji", txt_rok_produkcji.Text));
                command.Parameters.Add(new SQLiteParameter("@klas_wiekowa", txt_klas_wiekowa.Text));
                command.Parameters.Add(new SQLiteParameter("@dlugosc", txt_dlugosc.Text));
                command.Parameters.Add(new SQLiteParameter("@kraj", txt_kraj.Text));
                command.Parameters.Add(new SQLiteParameter("@cena", txt_cena.Text));
                command.Parameters.Add(new SQLiteParameter("@nosnik", cmb_nosnik.Text));
                if (cb_lektor.Checked) command.Parameters.Add(new SQLiteParameter("@lektor", 1));
                else command.Parameters.Add(new SQLiteParameter("@lektor", 0));
                if (cb_napisy.Checked) command.Parameters.Add(new SQLiteParameter("@napisy", 1));
                else command.Parameters.Add(new SQLiteParameter("@napisy", 0));

                command.ExecuteNonQuery();
                conn.Close();

                this.Close();

            }

        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_klas_wiekowa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_dlugosc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_cena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
