using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Wypozyczalnia.Formsy
{
    public partial class FrmDodajKlienta : Form
    {
        string connString = "Data Source = baza.db; Version = 3";

        public FrmDodajKlienta()
        {
            InitializeComponent();
        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_imie.Text) || string.IsNullOrWhiteSpace(txt_nazwisko.Text) || string.IsNullOrWhiteSpace(txt_pesel.Text) || string.IsNullOrWhiteSpace(txt_miejscowosc.Text) || string.IsNullOrWhiteSpace(txt_kod_pocztowy.Text) || string.IsNullOrWhiteSpace(txt_nr_domu.Text))
            {
                MessageBox.Show("Uzupełnij wymagane pola", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                DialogResult result = MessageBox.Show("Czy dodać klienta?", "Pytanie", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    using (SQLiteConnection conn = new SQLiteConnection(connString))
                    {
                        conn.Open();
                        SQLiteCommand command = new SQLiteCommand(conn);
                        command.CommandText = @"
                                INSERT INTO Klienci (imie, nazwisko, pesel, nr_dowodu, nr_telefonu, email, miejscowosc, kod_pocztowy, ulica, nr_domu)
                                VALUES (@imie, @nazwisko, @pesel, @nr_dowodu, @nr_telefonu, @email, @miejscowosc, @kod_pocztowy, @ulica, @nr_domu)
                                ";

                        command.Parameters.Add(new SQLiteParameter("@imie", txt_imie.Text));
                        command.Parameters.Add(new SQLiteParameter("@nazwisko", txt_nazwisko.Text));
                        command.Parameters.Add(new SQLiteParameter("@pesel", txt_pesel.Text));
                        command.Parameters.Add(new SQLiteParameter("@nr_dowodu", txt_nr_dowodu.Text));
                        command.Parameters.Add(new SQLiteParameter("@nr_telefonu", txt_nr_telefonu.Text));
                        command.Parameters.Add(new SQLiteParameter("@email", txt_email.Text));
                        command.Parameters.Add(new SQLiteParameter("@miejscowosc", txt_miejscowosc.Text));
                        command.Parameters.Add(new SQLiteParameter("@kod_pocztowy", txt_kod_pocztowy.Text));
                        command.Parameters.Add(new SQLiteParameter("@ulica", txt_ulica.Text));
                        command.Parameters.Add(new SQLiteParameter("@nr_domu", txt_nr_domu.Text));

                        command.ExecuteNonQuery();
                        conn.Close();

                        this.Close();
                    }
                }
            }
        }
    }
}
