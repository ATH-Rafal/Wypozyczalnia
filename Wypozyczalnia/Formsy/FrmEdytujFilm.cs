using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Wypozyczalnia.Formsy
{
    public partial class FrmEdytujFilm : Form
    {
        int id;
        string connString = "Data Source = baza.db; Version = 3";

        public FrmEdytujFilm(int id_)
        {
            InitializeComponent();
            id = id_;
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(conn);
                command.CommandText = "SELECT * FROM Filmy WHERE id=@id";
                command.Parameters.Add(new SQLiteParameter("@id", id));
                using (command)
                {
                    using (SQLiteDataReader rdr = command.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            txt_id.Text = rdr.GetValue(0).ToString();
                            txt_tytul_pol.Text = rdr.GetValue(1).ToString();
                            txt_tytul_org.Text = rdr.GetValue(2).ToString();
                            txt_rok_produkcji.Text = rdr.GetValue(3).ToString();
                            txt_klas_wiekowa.Text = rdr.GetValue(4).ToString();
                            txt_dlugosc.Text = rdr.GetValue(5).ToString();
                            txt_kraj.Text = rdr.GetValue(6).ToString();
                            txt_cena.Text = rdr.GetValue(7).ToString();
                            cmb_nosnik.Text = rdr.GetValue(8).ToString();
                            cb_lektor.Checked = rdr.GetValue(9) as bool? ?? false;
                            cb_napisy.Checked = rdr.GetValue(10) as bool? ?? false;
                        }
                    }
                }
                conn.Close();
            }
        }

        private void btn_zatwierz_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(conn);
                command.CommandText = @"
                                UPDATE Filmy
                                SET
                                tytul_pol = @tytul_pol,
                                tytul_org = @tytul_org,
                                rok_produkcji = @rok_produkcji, 
                                klas_wiekowa = @klas_wiekowa, 
                                dlugosc = @dlugosc, 
                                kraj = @kraj, 
                                cena = @cena, 
                                nosnik = @nosnik, 
                                lektor = @lektor, 
                                napisy = @napisy
                                WHERE id = @id
                                ";

                command.Parameters.Add(new SQLiteParameter("@id", id));
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
