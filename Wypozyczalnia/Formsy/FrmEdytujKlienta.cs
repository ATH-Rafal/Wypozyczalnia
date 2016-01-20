using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Wypozyczalnia.Formsy
{
    public partial class FrmEdytujKlienta : Form
    {
        int id;
        string connString = "Data Source = baza.db; Version = 3";

        public FrmEdytujKlienta(int id_)
        {
            InitializeComponent();
            id = id_;
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(conn);
                command.CommandText = "SELECT * FROM Klienci WHERE id=@id";
                command.Parameters.Add(new SQLiteParameter("@id", id));
                using (command)
                {
                    using (SQLiteDataReader rdr = command.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            txt_id.Text = rdr.GetValue(0).ToString();
                            txt_imie.Text = rdr.GetValue(1).ToString();
                            txt_nazwisko.Text = rdr.GetValue(2).ToString();
                            txt_pesel.Text = rdr.GetValue(3).ToString();
                            txt_nr_dowodu.Text = rdr.GetValue(4).ToString();
                            txt_nr_telefonu.Text = rdr.GetValue(5).ToString();
                            txt_email.Text = rdr.GetValue(6).ToString();
                            txt_miejscowosc.Text = rdr.GetValue(7).ToString();
                            txt_kod_pocztowy.Text = rdr.GetValue(8).ToString();
                            txt_ulica.Text = rdr.GetValue(9).ToString();
                            txt_nr_domu.Text = rdr.GetValue(10).ToString();
                        }
                    }
                }
                conn.Close();
            }
        }

        private void btn_zatwierdz_Click(object sender, EventArgs e)
        {
            if (txt_kod_pocztowy.Text.Length != 6 || txt_kod_pocztowy.Text.Contains(" ") || txt_pesel.Text.Length != 11 || txt_pesel.Text.Contains(" ") || string.IsNullOrWhiteSpace(txt_imie.Text) || string.IsNullOrWhiteSpace(txt_nazwisko.Text) || string.IsNullOrWhiteSpace(txt_pesel.Text) || string.IsNullOrWhiteSpace(txt_miejscowosc.Text) || string.IsNullOrWhiteSpace(txt_kod_pocztowy.Text) || string.IsNullOrWhiteSpace(txt_nr_domu.Text))
            {
                MessageBox.Show("Uzupełnij wymagane pola", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {


                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    SQLiteCommand command = new SQLiteCommand(conn);
                    command.CommandText = @"
                                UPDATE Klienci
                                SET
                                imie = @imie,
                                nazwisko = @nazwisko,
                                pesel = @pesel, 
                                nr_dowodu = @nr_dowodu, 
                                nr_telefonu = @nr_telefonu, 
                                email = @email, 
                                miejscowosc = @miejscowosc, 
                                kod_pocztowy = @kod_pocztowy, 
                                ulica = @ulica, 
                                nr_domu = @nr_domu
                                WHERE id = @id
                                ";

                    command.Parameters.Add(new SQLiteParameter("@id", id));
                    command.Parameters.Add(new SQLiteParameter("@imie", txt_imie.Text.Trim()));
                    command.Parameters.Add(new SQLiteParameter("@nazwisko", txt_nazwisko.Text.Trim()));
                    command.Parameters.Add(new SQLiteParameter("@pesel", txt_pesel.Text));
                    command.Parameters.Add(new SQLiteParameter("@nr_dowodu", txt_nr_dowodu.Text));
                    command.Parameters.Add(new SQLiteParameter("@nr_telefonu", txt_nr_telefonu.Text));
                    command.Parameters.Add(new SQLiteParameter("@email", txt_email.Text));
                    command.Parameters.Add(new SQLiteParameter("@miejscowosc", txt_miejscowosc.Text.Trim()));
                    command.Parameters.Add(new SQLiteParameter("@kod_pocztowy", txt_kod_pocztowy.Text));
                    command.Parameters.Add(new SQLiteParameter("@ulica", txt_ulica.Text.Trim()));
                    command.Parameters.Add(new SQLiteParameter("@nr_domu", txt_nr_domu.Text.Trim()));

                    command.ExecuteNonQuery();
                    conn.Close();

                    this.Close();
                }



            }
        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_nr_telefonu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_nr_dowodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txt_nr_telefonu_TextChanged(object sender, EventArgs e)
        {
            string temp = null;
            foreach (char c in txt_nr_telefonu.Text)
            {
                if (char.IsControl(c) || char.IsNumber(c))
                {
                    temp += c;
                }
            }
            txt_nr_telefonu.Text = temp;
        }

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsSymbol(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            string temp = null;
            foreach (char c in txt_email.Text)
            {
                if (char.IsControl(c) || char.IsSymbol(c) || char.IsLetterOrDigit(c) || c != ' ')
                {
                    temp += c;
                }
            }
            txt_email.Text = temp;
        }
    }
}
