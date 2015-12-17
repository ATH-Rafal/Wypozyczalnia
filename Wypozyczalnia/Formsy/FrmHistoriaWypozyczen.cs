using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wypozyczalnia.Formsy
{
    public partial class FrmHistoriaWypozyczen : Form
    {
        string connString = "Data Source = baza.db; Version = 3";
        DataTable table = new DataTable(); // Bardzo pomocny obiekt do pracy na wynikach zapytania

        private void filtruj()
        {
            DateTime temp;
            switch (cmb_kolumna.Text)
            {
                case "ID Wypożyczenia":
                    table.DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", "Convert([id], System.String)", txt_filtr.Text); break;
                case "ID Klienta":
                    table.DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", "Convert([id_klienta], System.String)", txt_filtr.Text); break;
                case "Nazwisko":
                    table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "nazwisko", txt_filtr.Text); break;
                case "Imię":
                    table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "imie", txt_filtr.Text); break;
                case "ID Filmu":
                    table.DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", "Convert([id_filmu], System.String)", txt_filtr.Text); break;
                case "Tytuł polski":
                    table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "tytul_pol", txt_filtr.Text); break;
                case "Dni wypożyczenia":
                    if (!string.IsNullOrWhiteSpace(txt_filtr.Text))
                        table.DefaultView.RowFilter = "dni " + cmb_porownanie.Text + " " + txt_filtr.Text;
                    else table.DefaultView.RowFilter = "[id] IS NOT NULL";
                    break;
                case "Cena":
                    if (!string.IsNullOrWhiteSpace(txt_filtr.Text))
                        table.DefaultView.RowFilter = "cena " + cmb_porownanie.Text + " " + txt_filtr.Text;
                    else table.DefaultView.RowFilter = "[id] IS NOT NULL";
                    break;
                case "Data wypożyczenia":
                    if (!string.IsNullOrWhiteSpace(txt_filtr.Text) && DateTime.TryParseExact(txt_filtr.Text, "yyyy-MM-dd", null , DateTimeStyles.None, out temp))
                        table.DefaultView.RowFilter = "data_wypozyczenia " + cmb_porownanie.Text + " #" + txt_filtr.Text + "#";
                    else table.DefaultView.RowFilter = "[id] IS NOT NULL";
                    break;
                case "Termin zwrotu":
                    if (!string.IsNullOrWhiteSpace(txt_filtr.Text) && DateTime.TryParseExact(txt_filtr.Text, "yyyy-MM-dd", null, DateTimeStyles.None, out temp))
                        table.DefaultView.RowFilter = "termin_zwrotu " + cmb_porownanie.Text + " #" + txt_filtr.Text + "#";
                    else table.DefaultView.RowFilter = "[id] IS NOT NULL";
                    break;
                case "Data zwrotu":
                    if (!string.IsNullOrWhiteSpace(txt_filtr.Text) && DateTime.TryParseExact(txt_filtr.Text, "yyyy-MM-dd", null, DateTimeStyles.None, out temp))
                        table.DefaultView.RowFilter = "data_zwrotu " + cmb_porownanie.Text + " #" + txt_filtr.Text + "#";
                    else table.DefaultView.RowFilter = "[id] IS NOT NULL";
                    break;
            }

            if (cmb_typ.Text == "Zwrócone")
                table.DefaultView.RowFilter += " AND data_zwrotu IS NOT NULL";
            if (cmb_typ.Text == "Niezwrócone")
                table.DefaultView.RowFilter += " AND data_zwrotu IS NULL";
            if (cb_spoznione.Checked == true)
                table.DefaultView.RowFilter += " AND ((termin_zwrotu < #" + DateTime.Now.ToString("yyyy-MM-dd") + "# AND data_zwrotu IS NULL) OR (termin_zwrotu < data_zwrotu))";
        }

        public FrmHistoriaWypozyczen()
        {
            InitializeComponent();
            table.Clear();
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(@"
                                                            SELECT Wypozyczenia.id, Wypozyczenia.id_klienta, Klienci.nazwisko, Klienci.imie, Wypozyczenia.id_filmu, Filmy.tytul_pol, Wypozyczenia.dni, Wypozyczenia.cena, Wypozyczenia.data_wypozyczenia, date(Wypozyczenia.data_wypozyczenia, (Wypozyczenia.dni || ' day')) AS termin_zwrotu, Wypozyczenia.data_zwrotu
                                                            FROM Klienci
                                                            INNER JOIN Wypozyczenia ON Klienci.id = Wypozyczenia.id_klienta
                                                            INNER JOIN Filmy ON Wypozyczenia.id_filmu = Filmy.id                                                            
                                                            ",
                                                            conn);
                adapter.Fill(table); // wypełniamy DataTabla danymi z wyniku zapytania
            }
            dtg_historia.DataSource = table; // Przypisujemy dane z DataTabla do naszego GridView
            cmb_kolumna.SelectedIndex = 0;
            cmb_porownanie.SelectedIndex = 0;
            cmb_typ.SelectedIndex = 0;
        }

        private void cb_spoznione_CheckedChanged(object sender, EventArgs e)
        {
            filtruj();
        }

        private void cmb_typ_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtruj();
        }

        private void txt_filtr_TextChanged(object sender, EventArgs e)
        {
            filtruj();
        }

        private void cmb_kolumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_filtr.Text = "";
            if (cmb_kolumna.Text == "Cena" || cmb_kolumna.Text == "Dni wypożyczenia" || cmb_kolumna.Text == "Data wypożyczenia" || cmb_kolumna.Text == "Termin zwrotu" || cmb_kolumna.Text == "Data zwrotu") cmb_porownanie.Enabled = true;
            else cmb_porownanie.Enabled = false;
        }

        private void cmb_porownanie_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtruj();
        }

        private void txt_filtr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_kolumna.Text == "ID Wypożyczenia" || cmb_kolumna.Text == "ID Klienta" || cmb_kolumna.Text == "ID Filmu" || cmb_kolumna.Text == "Dni wypożyczenia")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            if (cmb_kolumna.Text == "Cena")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
            if (cmb_kolumna.Text == "Data wypożyczenia" || cmb_kolumna.Text == "Termin zwrotu" || cmb_kolumna.Text == "Data zwrotu")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != '-')
                {
                    e.Handled = true;
                }
            }
        }
    }
}
