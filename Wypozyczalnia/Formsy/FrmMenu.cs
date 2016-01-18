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
    public partial class FrmMenu : Form
    {
        string connString = "Data Source = baza.db; Version = 3";
        DataTable wyp_table = new DataTable();
        int wyp_index;

        DataTable kli_table = new DataTable(); // Bardzo pomocny obiekt do pracy na wynikach zapytania
        int kli_id;
        int kli_index;

        DataTable fil_table = new DataTable(); // Bardzo pomocny obiekt do pracy na wynikach zapytania
        int fil_id;
        int fil_index;

        DataTable tar_table = new DataTable(); // Bardzo pomocny obiekt do pracy na wynikach zapytania
        int tar_id;
        int tar_index;

        DataTable tag_table = new DataTable();
        DataTable oso_table = new DataTable();

        bool czy_zwrocono = false;

        public bool czy_zwrocono_prop
        {
            get
            {
                return czy_zwrocono;
            }
            set
            {
                czy_zwrocono = value;
            }
        }

        private void wyp_odswiez()
        {
            wyp_table.Clear();
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(@"
                                                            SELECT Wypozyczenia.id, Wypozyczenia.id_klienta, Klienci.nazwisko, Klienci.imie, Wypozyczenia.id_filmu, Filmy.tytul_pol, Wypozyczenia.dni, Wypozyczenia.cena, Wypozyczenia.data_wypozyczenia, date(Wypozyczenia.data_wypozyczenia, (Wypozyczenia.dni || ' day')) AS termin_zwrotu, Wypozyczenia.data_zwrotu
                                                            FROM Klienci
                                                            INNER JOIN Wypozyczenia ON Klienci.id = Wypozyczenia.id_klienta
                                                            INNER JOIN Filmy ON Wypozyczenia.id_filmu = Filmy.id                                                            
                                                            ",
                                                            conn);
                adapter.Fill(wyp_table); // wypełniamy DataTabla danymi z wyniku zapytania
            }
            wyp_dtg_historia.DataSource = wyp_table; // Przypisujemy dane z DataTabla do naszego GridView
        }

        private void kli_odswiez()
        {
            kli_table.Clear();
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM Klienci;", conn);
                adapter.Fill(kli_table); // wypełniamy DataTabla danymi z wyniku zapytania
            }
            kli_dataGridView1.DataSource = kli_table; // Przypisujemy dane z DataTabla do naszego GridView            
        }

        private void fil_odswiez()
        {
            fil_table.Clear();
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM Filmy;", conn);
                adapter.Fill(fil_table); // wypełniamy DataTabla danymi z wyniku zapytania
            }
            fil_dataGridView1.DataSource = fil_table; // Przypisujemy dane z DataTabla do naszego GridView            
        }

        private void tar_odswiez()
        {
            tar_table.Clear();
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM Taryfy;", conn);
                adapter.Fill(tar_table); // wypełniamy DataTabla danymi z wyniku zapytania
            }
            tar_dataGridView1.DataSource = tar_table; // Przypisujemy dane z DataTabla do naszego GridView            
        }

        private void tag_odswiez()
        {
            tag_table.Clear();
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM Tagi;", conn);
                adapter.Fill(tag_table); // wypełniamy DataTabla danymi z wyniku zapytania
            }
            tag_dataGridView1.DataSource = tag_table; // Przypisujemy dane z DataTabla do naszego GridView            
        }

        private void oso_odswiez()
        {
            oso_table.Clear();
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM Osoby;", conn);
                adapter.Fill(oso_table); // wypełniamy DataTabla danymi z wyniku zapytania
            }
            oso_dataGridView2.DataSource = oso_table; // Przypisujemy dane z DataTabla do naszego GridView            
        }


        private void przejdzDoKlienta()
        {
            if (kli_dataGridView1.SelectedRows.Count > 0)
            {
                kli_id = Int32.Parse(kli_dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                FrmFormularzKlienta FrmFormularzKlienta = new FrmFormularzKlienta(kli_id);
                FrmFormularzKlienta.ShowDialog(this);
            }
        }

        private void przejdzDoFilmu()
        {
            if (fil_dataGridView1.SelectedRows.Count > 0)
            {
                fil_id = Int32.Parse(fil_dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                FrmFormularzFilmu FrmWysFilmu = new FrmFormularzFilmu(fil_id);
                FrmWysFilmu.ShowDialog(this);
            }
        }

        private void przejdzDoTaryfy()
        {
            if (tar_dataGridView1.SelectedRows.Count > 0)
            {
                tar_id = Int32.Parse(tar_dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                FrmFormularzTaryfy frmFormularzTaryfy = new FrmFormularzTaryfy(tar_id);
                frmFormularzTaryfy.ShowDialog(this);
            }
        }

        private void przejdzDoTaga()
        {
            if (tag_dataGridView1.SelectedRows.Count > 0)
            {
                FrmFormularzTaga frmFormularzTaga = new FrmFormularzTaga(tag_dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                frmFormularzTaga.ShowDialog(this);
            }
        }

        private void przejdzDoFilmowca()
        {
            if (oso_dataGridView2.SelectedRows.Count > 0)
            {
                FrmFormularzOsoby frmFormularzOsoby = new FrmFormularzOsoby(oso_dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                frmFormularzOsoby.ShowDialog(this);
            }
        }

        private void wyp_filtruj()
        {
            DateTime temp;
            switch (wyp_cmb_kolumna.Text)
            {
                case "ID Wypożyczenia":
                    wyp_table.DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", "Convert([id], System.String)", wyp_txt_filtr.Text); break;
                case "ID Klienta":
                    wyp_table.DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", "Convert([id_klienta], System.String)", wyp_txt_filtr.Text); break;
                case "Nazwisko":
                    wyp_table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "nazwisko", wyp_txt_filtr.Text); break;
                case "Imię":
                    wyp_table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "imie", wyp_txt_filtr.Text); break;
                case "ID Filmu":
                    wyp_table.DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", "Convert([id_filmu], System.String)", wyp_txt_filtr.Text); break;
                case "Tytuł polski":
                    wyp_table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "tytul_pol", wyp_txt_filtr.Text); break;
                case "Dni wypożyczenia":
                    if (!string.IsNullOrWhiteSpace(wyp_txt_filtr.Text))
                        wyp_table.DefaultView.RowFilter = "dni " + wyp_cmb_porownanie.Text + " " + wyp_txt_filtr.Text;
                    else wyp_table.DefaultView.RowFilter = "[id] IS NOT NULL";
                    break;
                case "Cena":
                    if (!string.IsNullOrWhiteSpace(wyp_txt_filtr.Text))
                        wyp_table.DefaultView.RowFilter = "cena " + wyp_cmb_porownanie.Text + " " + wyp_txt_filtr.Text;
                    else wyp_table.DefaultView.RowFilter = "[id] IS NOT NULL";
                    break;
                case "Data wypożyczenia":
                    if (!string.IsNullOrWhiteSpace(wyp_txt_filtr.Text) && DateTime.TryParseExact(wyp_txt_filtr.Text, "yyyy-MM-dd", null, DateTimeStyles.None, out temp))
                        wyp_table.DefaultView.RowFilter = "data_wypozyczenia " + wyp_cmb_porownanie.Text + " #" + wyp_txt_filtr.Text + "#";
                    else wyp_table.DefaultView.RowFilter = "[id] IS NOT NULL";
                    break;
                case "Termin zwrotu":
                    if (!string.IsNullOrWhiteSpace(wyp_txt_filtr.Text) && DateTime.TryParseExact(wyp_txt_filtr.Text, "yyyy-MM-dd", null, DateTimeStyles.None, out temp))
                        wyp_table.DefaultView.RowFilter = "termin_zwrotu " + wyp_cmb_porownanie.Text + " #" + wyp_txt_filtr.Text + "#";
                    else wyp_table.DefaultView.RowFilter = "[id] IS NOT NULL";
                    break;
                case "Data zwrotu":
                    if (!string.IsNullOrWhiteSpace(wyp_txt_filtr.Text) && DateTime.TryParseExact(wyp_txt_filtr.Text, "yyyy-MM-dd", null, DateTimeStyles.None, out temp))
                        wyp_table.DefaultView.RowFilter = "data_zwrotu " + wyp_cmb_porownanie.Text + " #" + wyp_txt_filtr.Text + "#";
                    else wyp_table.DefaultView.RowFilter = "[id] IS NOT NULL";
                    break;
            }

            if (wyp_cmb_typ.Text == "Zwrócone")
                wyp_table.DefaultView.RowFilter += " AND data_zwrotu IS NOT NULL";
            if (wyp_cmb_typ.Text == "Niezwrócone")
                wyp_table.DefaultView.RowFilter += " AND data_zwrotu IS NULL";
            if (wyp_cb_spoznione.Checked == true)
                wyp_table.DefaultView.RowFilter += " AND ((termin_zwrotu < #" + DateTime.Now.ToString("yyyy-MM-dd") + "# AND data_zwrotu IS NULL) OR (termin_zwrotu < data_zwrotu))";
        }

        private void fil_filtruj()
        {
            switch (fil_cmb_kolumna.Text)
            {
                case "ID":
                    fil_table.DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", "Convert([id], System.String)", fil_txt_filtr.Text); break;
                case "Tytuł polski":
                    fil_table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "tytul_pol", fil_txt_filtr.Text); break;
                case "Tytuł oryginalny":
                    fil_table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "tytul_org", fil_txt_filtr.Text); break;
                case "Rok produkcji":
                    if (!string.IsNullOrWhiteSpace(fil_txt_filtr.Text))
                        fil_table.DefaultView.RowFilter = "rok_produkcji " + fil_cmb_porownanie.Text + " " + fil_txt_filtr.Text;
                    else fil_table.DefaultView.RowFilter = "[id] IS NOT NULL";
                    break;
                case "Gatunek":
                    fil_table.DefaultView.RowFilter = string.Format("([{0}] LIKE '%{1}%' OR [{2}] LIKE '%{1}%')", "gatunek", fil_txt_filtr.Text, "gatunek2"); break;
                case "Dystrybutor":
                    fil_table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "dystrybutor", fil_txt_filtr.Text); break;
                case "Kraj":
                    fil_table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "kraj", fil_txt_filtr.Text); break;
                case "Długość":
                    if (!string.IsNullOrWhiteSpace(fil_txt_filtr.Text))
                        fil_table.DefaultView.RowFilter = "dlugosc " + fil_cmb_porownanie.Text + " " + fil_txt_filtr.Text;
                    else fil_table.DefaultView.RowFilter = "[id] IS NOT NULL";
                    break;
                case "Nośnik":
                    fil_table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "nosnik", fil_txt_filtr.Text); break;
                case "ID taryfy":
                    fil_table.DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", "Convert([id_taryfy], System.String)", fil_txt_filtr.Text); break;
            }
            if (fil_cb_lektor.Checked == true) fil_table.DefaultView.RowFilter += " AND lektor = true";
            if (fil_cb_napisy.Checked == true) fil_table.DefaultView.RowFilter += " AND napisy = true";
        }

        private void tar_filtruj()
        {
            switch (tar_cmb_kolumna.Text)
            {
                case "ID": tar_table.DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", "Convert([id], System.String)", tar_txt_filtr.Text); break;
                case "Nazwa": tar_table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "nazwa", tar_txt_filtr.Text); break;
                case "Cena za dzień":
                    if (!string.IsNullOrWhiteSpace(tar_txt_filtr.Text))
                        tar_table.DefaultView.RowFilter = "cena_za_dzien " + tar_cmb_porownanie.Text + " " + tar_txt_filtr.Text;
                    else tar_table.DefaultView.RowFilter = null;
                    break;
            }
        }

        public FrmMenu()
        {
            InitializeComponent();
            //Wypozyczanie
            wyp_odswiez();
            wyp_cmb_kolumna.SelectedIndex = 1;
            wyp_cmb_porownanie.SelectedIndex = 0;
            wyp_cmb_typ.SelectedIndex = 0;
            //Klienci
            kli_odswiez();
            kli_cmb_kolumna.SelectedIndex = 0;
            //Filmy
            fil_odswiez();
            fil_cmb_kolumna.SelectedIndex = 0;
            fil_cmb_porownanie.SelectedIndex = 0;
            //Taryfy
            tar_odswiez();
            tar_cmb_kolumna.SelectedIndex = 0;
            tar_cmb_porownanie.SelectedIndex = 0;
            //Pozostale
            tag_odswiez();
            oso_odswiez();
        }

        private void wyp_cb_spoznione_CheckedChanged(object sender, EventArgs e)
        {
            wyp_filtruj();
        }

        private void wyp_cmb_typ_SelectedIndexChanged(object sender, EventArgs e)
        {
            wyp_filtruj();
        }

        private void wyp_cmb_kolumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            wyp_txt_filtr.Text = "";
            if (wyp_cmb_kolumna.Text == "Cena" || wyp_cmb_kolumna.Text == "Dni wypożyczenia" || wyp_cmb_kolumna.Text == "Data wypożyczenia" || wyp_cmb_kolumna.Text == "Termin zwrotu" || wyp_cmb_kolumna.Text == "Data zwrotu") wyp_cmb_porownanie.Enabled = true;
            else wyp_cmb_porownanie.Enabled = false;
        }

        private void wyp_cmb_porownanie_SelectedIndexChanged(object sender, EventArgs e)
        {
            wyp_filtruj();
        }

        private void wyp_txt_filtr_TextChanged(object sender, EventArgs e)
        {
            wyp_filtruj();
        }

        private void wyp_txt_filtr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (wyp_cmb_kolumna.Text == "ID Wypożyczenia" || wyp_cmb_kolumna.Text == "ID Klienta" || wyp_cmb_kolumna.Text == "ID Filmu" || wyp_cmb_kolumna.Text == "Dni wypożyczenia")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            if (wyp_cmb_kolumna.Text == "Cena")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
            if (wyp_cmb_kolumna.Text == "Data wypożyczenia" || wyp_cmb_kolumna.Text == "Termin zwrotu" || wyp_cmb_kolumna.Text == "Data zwrotu")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != '-')
                {
                    e.Handled = true;
                }
            }
        }

        private void btn_dodaj_wyp_Click(object sender, EventArgs e)
        {
            int liczba_wierszy = wyp_dtg_historia.RowCount;
            if (wyp_dtg_historia.RowCount != 0) wyp_index = wyp_dtg_historia.SelectedRows[0].Index;

            FrmWypozyczenieFilmu frmWypozyczenieFilmu = new FrmWypozyczenieFilmu();
            frmWypozyczenieFilmu.ShowDialog(this);
            wyp_odswiez();

            if (wyp_dtg_historia.RowCount != 0)
            {
                if (wyp_dtg_historia.RowCount != liczba_wierszy)
                    wyp_dtg_historia.CurrentCell = wyp_dtg_historia.Rows[wyp_dtg_historia.RowCount - 1].Cells[0];
                else wyp_dtg_historia.CurrentCell = wyp_dtg_historia.Rows[wyp_index].Cells[0];
            }
        }

        private void kli_btn_pokaz_profil_Click(object sender, EventArgs e)
        {
            przejdzDoKlienta();
        }

        private void kli_dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            przejdzDoKlienta();
        }

        private void kli_btn_dodaj_klienta_Click(object sender, EventArgs e)
        {
            int liczba_wierszy = kli_dataGridView1.RowCount;
            if (kli_dataGridView1.RowCount != 0) kli_index = kli_dataGridView1.SelectedRows[0].Index;

            FrmDodajKlienta FrmDodajKlienta = new FrmDodajKlienta();
            FrmDodajKlienta.ShowDialog();
            kli_odswiez();

            if (kli_dataGridView1.RowCount != 0)
            {
                if (kli_dataGridView1.RowCount != liczba_wierszy)
                    kli_dataGridView1.CurrentCell = kli_dataGridView1.Rows[kli_dataGridView1.RowCount - 1].Cells[0];
                else kli_dataGridView1.CurrentCell = kli_dataGridView1.Rows[kli_index].Cells[0];
            }
        }

        private void kli_btn_usun_klienta_Click(object sender, EventArgs e)
        {
            if (kli_dataGridView1.SelectedRows.Count > 0)
            {
                kli_id = Int32.Parse(kli_dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                if (kli_dataGridView1.RowCount != 0) kli_index = kli_dataGridView1.SelectedRows[0].Index;
                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć klienta numer " + kli_id + "?\nUsuniętę zostaną również wypożyczenia klienta.\n\nOperacji nie można cofnąć.", "Ważne", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    using (SQLiteConnection conn = new SQLiteConnection(connString))
                    {
                        conn.Open();
                        SQLiteCommand command1 = new SQLiteCommand(conn);
                        command1.CommandText = "DELETE FROM Klienci WHERE id = @id";
                        command1.Parameters.Add(new SQLiteParameter("@id", kli_id));
                        command1.ExecuteNonQuery();
                        SQLiteCommand command2 = new SQLiteCommand(conn);
                        command2.CommandText = "DELETE FROM Wypozyczenia WHERE id_klienta = @id";
                        command2.Parameters.Add(new SQLiteParameter("@id", kli_id));
                        command2.ExecuteNonQuery();
                        conn.Close();
                        kli_odswiez();
                        if (kli_dataGridView1.RowCount != 0)
                        {
                            if (kli_index == kli_dataGridView1.RowCount) kli_dataGridView1.CurrentCell = kli_dataGridView1.Rows[kli_index - 1].Cells[0];
                            else kli_dataGridView1.CurrentCell = kli_dataGridView1.Rows[kli_index].Cells[0];
                        }
                    }
            }
        }

        private void kli_btn_edytuj_klienta_Click(object sender, EventArgs e)
        {
            if (kli_dataGridView1.SelectedRows.Count > 0)
            {
                kli_id = Int32.Parse(kli_dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                kli_index = kli_dataGridView1.SelectedRows[0].Index;
                FrmEdytujKlienta FrmEdytujKlienta = new FrmEdytujKlienta(kli_id);
                FrmEdytujKlienta.ShowDialog();
                kli_odswiez();
                kli_dataGridView1.CurrentCell = kli_dataGridView1.Rows[kli_index].Cells[0];
            }
        }

        private void kli_txt_filtr_TextChanged(object sender, EventArgs e)
        {
            if (kli_cmb_kolumna.Text == "ID" || kli_cmb_kolumna.Text == "PESEL" || kli_cmb_kolumna.Text == "Nr. telefonu")
            {
                string temp = null;
                foreach (char c in kli_txt_filtr.Text)
                {
                    if (char.IsControl(c) || char.IsNumber(c))
                    {
                        temp += c;
                    }
                }
                kli_txt_filtr.Text = temp;
            }

            switch (kli_cmb_kolumna.Text)
            {
                case "ID": kli_table.DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", "Convert([id], System.String)", kli_txt_filtr.Text); break;
                case "Imię": kli_table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "imie", kli_txt_filtr.Text); break;
                case "Nazwisko": kli_table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "nazwisko", kli_txt_filtr.Text); break;
                case "PESEL": kli_table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "pesel", kli_txt_filtr.Text); break;
                case "Nr. dowodu": kli_table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "nr_dowodu", kli_txt_filtr.Text); break;
                case "Nr. telefonu": kli_table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "nr_telefonu", kli_txt_filtr.Text); break;
                case "E-Mail": kli_table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "email", kli_txt_filtr.Text); break;
                case "Miejscowość": kli_table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "miejscowosc", kli_txt_filtr.Text); break;
                case "Kod pocztowy": kli_table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "kod_pocztowy", kli_txt_filtr.Text); break;
                case "Ulica": kli_table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "ulica", kli_txt_filtr.Text); break;
                case "Nr. domu": kli_table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "nr_domu", kli_txt_filtr.Text); break;
            }
        }

        private void kli_cmb_kolumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            kli_txt_filtr.Text = "";
        }

        private void kli_txt_filtr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (kli_cmb_kolumna.Text == "ID" || kli_cmb_kolumna.Text == "PESEL" || kli_cmb_kolumna.Text == "Nr. telefonu")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            if (kli_cmb_kolumna.Text == "Nr. dowodu")
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            if (kli_cmb_kolumna.Text == "Kod pocztowy")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != '-')
                {
                    e.Handled = true;
                }
            }
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            wyp_odswiez();
        }

        private void fil_btn_pokaz_film_Click(object sender, EventArgs e)
        {
            przejdzDoFilmu();
        }

        private void fil_dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            przejdzDoFilmu();
        }

        private void fil_btn_dodaj_film_Click(object sender, EventArgs e)
        {
            int liczba_wierszy = fil_dataGridView1.RowCount;
            if (fil_dataGridView1.RowCount != 0) fil_index = fil_dataGridView1.SelectedRows[0].Index;

            FrmDodajFilm frmDodajFilm = new FrmDodajFilm();
            frmDodajFilm.ShowDialog();
            fil_odswiez();

            if (fil_dataGridView1.RowCount != 0)
            {
                if (fil_dataGridView1.RowCount != liczba_wierszy)
                    fil_dataGridView1.CurrentCell = fil_dataGridView1.Rows[fil_dataGridView1.RowCount - 1].Cells[0];
                else fil_dataGridView1.CurrentCell = fil_dataGridView1.Rows[fil_index].Cells[0];
            }
        }

        private void fil_btn_edytuj_film_Click(object sender, EventArgs e)
        {
            if (fil_dataGridView1.SelectedRows.Count > 0)
            {
                fil_id = Int32.Parse(fil_dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                fil_index = fil_dataGridView1.SelectedRows[0].Index;
                FrmEdytujFilm frmEdytujFilm = new FrmEdytujFilm(fil_id);
                frmEdytujFilm.ShowDialog();
                fil_odswiez();
                fil_dataGridView1.CurrentCell = fil_dataGridView1.Rows[fil_index].Cells[0];
            }
        }

        private void fil_btn_usun_film_Click(object sender, EventArgs e)
        {
            if (fil_dataGridView1.SelectedRows.Count > 0)
            {
                fil_id = Int32.Parse(fil_dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                if (fil_dataGridView1.RowCount != 0) fil_index = fil_dataGridView1.SelectedRows[0].Index;
                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć film numer " + fil_id + "?\nUsuniętę zostaną również wypożyczenia filmu.\n\nOperacji nie można cofnąć.", "Ważne", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    using (SQLiteConnection conn = new SQLiteConnection(connString))
                    {
                        conn.Open();
                        SQLiteCommand command1 = new SQLiteCommand(conn);
                        command1.CommandText = "DELETE FROM Filmy WHERE id = @id";
                        command1.Parameters.Add(new SQLiteParameter("@id", fil_id));
                        command1.ExecuteNonQuery();
                        SQLiteCommand command2 = new SQLiteCommand(conn);
                        command2.CommandText = "DELETE FROM Wypozyczenia WHERE id_filmu = @id";
                        command2.Parameters.Add(new SQLiteParameter("@id", fil_id));
                        command2.ExecuteNonQuery();
                        SQLiteCommand command3 = new SQLiteCommand(conn);
                        command3.CommandText = "DELETE FROM TagiFilmy WHERE id_filmu = @id";
                        command3.Parameters.Add(new SQLiteParameter("@id", fil_id));
                        command3.ExecuteNonQuery();
                        SQLiteCommand command4 = new SQLiteCommand(conn);
                        command4.CommandText = "DELETE FROM Obsada WHERE id_filmu = @id";
                        command4.Parameters.Add(new SQLiteParameter("@id", fil_id));
                        command4.ExecuteNonQuery();
                        List<string> tagi = new List<string>();
                        SQLiteCommand command6 = new SQLiteCommand(conn);
                        command6.CommandText = "SELECT nazwa FROM Tagi";
                        using (command6)
                        {
                            using (SQLiteDataReader rdr = command6.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    tagi.Add(rdr.GetValue(0).ToString());
                                }
                            }
                        }
                        foreach (string s in tagi)
                        {
                            SQLiteCommand command7 = new SQLiteCommand(conn);
                            command7.CommandText = "SELECT Count(*) FROM TagiFilmy WHERE tag = @tag";
                            command7.Parameters.Add(new SQLiteParameter("@tag", s));
                            if (command7.ExecuteScalar().ToString() == "0")
                            {
                                SQLiteCommand command8 = new SQLiteCommand(conn);
                                command8.CommandText = "DELETE FROM Tagi WHERE nazwa = @nazwa";
                                command8.Parameters.Add(new SQLiteParameter("@nazwa", s));
                                command8.ExecuteNonQuery();
                            }
                        }
                        List<string> osoby = new List<string>();
                        SQLiteCommand command25 = new SQLiteCommand(conn);
                        command25.CommandText = "SELECT imie_nazwisko FROM Osoby";
                        using (command25)
                        {
                            using (SQLiteDataReader rdr = command25.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    osoby.Add(rdr.GetValue(0).ToString());
                                }
                            }
                        }
                        foreach (string s in osoby)
                        {
                            SQLiteCommand command26 = new SQLiteCommand(conn);
                            command26.CommandText = "SELECT Count(*) FROM Obsada WHERE osoba = @osoba";
                            command26.Parameters.Add(new SQLiteParameter("@osoba", s));
                            if (command26.ExecuteScalar().ToString() == "0")
                            {
                                SQLiteCommand command27 = new SQLiteCommand(conn);
                                command27.CommandText = "DELETE FROM Osoby WHERE imie_nazwisko = @imie_nazwisko";
                                command27.Parameters.Add(new SQLiteParameter("@imie_nazwisko", s));
                                command27.ExecuteNonQuery();
                            }
                        }
                        conn.Close();

                        fil_odswiez();
                        if (fil_dataGridView1.RowCount != 0)
                        {
                            if (fil_index == fil_dataGridView1.RowCount) fil_dataGridView1.CurrentCell = fil_dataGridView1.Rows[fil_index - 1].Cells[0];
                            else fil_dataGridView1.CurrentCell = fil_dataGridView1.Rows[fil_index].Cells[0];
                        }
                    }
            }
        }

        private void fil_txt_filtr_TextChanged(object sender, EventArgs e)
        {
            if (fil_cmb_kolumna.Text == "ID" || fil_cmb_kolumna.Text == "Rok produkcji" || fil_cmb_kolumna.Text == "Długość" || fil_cmb_kolumna.Text == "ID taryfy")
            {
                string temp = null;
                foreach (char c in fil_txt_filtr.Text)
                {
                    if (char.IsControl(c) || char.IsNumber(c))
                    {
                        temp += c;
                    }
                }
                fil_txt_filtr.Text = temp;
            }

            fil_filtruj();
        }

        private void fil_cmb_kolumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            fil_txt_filtr.Text = "";
            if (fil_cmb_kolumna.Text == "Długość" || fil_cmb_kolumna.Text == "Rok produkcji") fil_cmb_porownanie.Enabled = true;
            else fil_cmb_porownanie.Enabled = false;
        }

        private void fil_cb_lektor_CheckedChanged(object sender, EventArgs e)
        {
            fil_filtruj();
        }

        private void fil_cb_napisy_CheckedChanged(object sender, EventArgs e)
        {
            fil_filtruj();
        }

        private void fil_txt_filtr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (fil_cmb_kolumna.Text == "ID" || fil_cmb_kolumna.Text == "Rok produkcji" || fil_cmb_kolumna.Text == "Długość" || fil_cmb_kolumna.Text == "ID taryfy")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void fil_cmb_porownanie_SelectedIndexChanged(object sender, EventArgs e)
        {
            fil_filtruj();
        }

        private void tar_btn_dodaj_Click(object sender, EventArgs e)
        {
            int liczba_wierszy = tar_dataGridView1.RowCount;
            if (tar_dataGridView1.RowCount != 0) tar_index = tar_dataGridView1.SelectedRows[0].Index;

            FrmDodajTaryfe frmDodajTaryfe = new FrmDodajTaryfe();
            frmDodajTaryfe.ShowDialog();
            tar_odswiez();

            if (tar_dataGridView1.RowCount != 0)
            {
                if (tar_dataGridView1.RowCount != liczba_wierszy)
                    tar_dataGridView1.CurrentCell = tar_dataGridView1.Rows[tar_dataGridView1.RowCount - 1].Cells[0];
                else tar_dataGridView1.CurrentCell = tar_dataGridView1.Rows[tar_index].Cells[0];
            }
        }

        private void tar_btn_edytuj_Click(object sender, EventArgs e)
        {
            if (tar_dataGridView1.SelectedRows.Count > 0)
            {
                tar_id = Int32.Parse(tar_dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                tar_index = tar_dataGridView1.SelectedRows[0].Index;
                FrmEdyfujTaryfe frmEdyfujTaryfe = new FrmEdyfujTaryfe(tar_id);
                frmEdyfujTaryfe.ShowDialog();
                tar_odswiez();
                tar_dataGridView1.CurrentCell = tar_dataGridView1.Rows[tar_index].Cells[0];
            }
        }

        private void tar_btn_usun_Click(object sender, EventArgs e)
        {
            if (tar_dataGridView1.SelectedRows.Count > 0)
            {
                tar_id = Int32.Parse(tar_dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    SQLiteCommand command1 = new SQLiteCommand(conn);
                    command1.CommandText = "SELECT Count(*) FROM Filmy WHERE id_taryfy = @id";
                    command1.Parameters.Add(new SQLiteParameter("@id", tar_id));
                    if (command1.ExecuteScalar().ToString() != "0")
                    {
                        MessageBox.Show("Dana taryfa jest przypisana do przynajmniej jednego filmu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                        return;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć taryfę numer " + tar_id + "?\nOperacji nie można cofnąć.", "Ważne", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            if (tar_dataGridView1.RowCount != 0) tar_index = tar_dataGridView1.SelectedRows[0].Index;
                            SQLiteCommand command2 = new SQLiteCommand(conn);
                            command2.CommandText = "DELETE FROM Taryfy WHERE id = @id";
                            command2.Parameters.Add(new SQLiteParameter("@id", tar_id));
                            command2.ExecuteNonQuery();
                            SQLiteCommand command3 = new SQLiteCommand(conn);
                            command3.CommandText = "DELETE FROM TaryfyZasady WHERE id = @id";
                            command3.Parameters.Add(new SQLiteParameter("@id", tar_id));
                            command3.ExecuteNonQuery();
                            conn.Close();

                            tar_odswiez();

                            if (tar_dataGridView1.RowCount != 0)
                            {
                                if (tar_index == tar_dataGridView1.RowCount) tar_dataGridView1.CurrentCell = tar_dataGridView1.Rows[tar_index - 1].Cells[0];
                                else tar_dataGridView1.CurrentCell = tar_dataGridView1.Rows[tar_index].Cells[0];
                            }
                        }
                    }
                }
            }
        }

        private void tar_dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            przejdzDoTaryfy();

        }

        private void tar_btn_pokaz_taryfe_Click(object sender, EventArgs e)
        {
            przejdzDoTaryfy();
        }

        private void tar_txt_filtr_TextChanged(object sender, EventArgs e)
        {
            if (tar_cmb_kolumna.Text == "ID")
            {
                string temp = null;
                foreach (char c in tar_txt_filtr.Text)
                {
                    if (char.IsControl(c) || char.IsNumber(c))
                    {
                        temp += c;
                    }
                }
                tar_txt_filtr.Text = temp;
            }
            if (tar_cmb_kolumna.Text == "Cena za dzień")
            {
                string temp = null;
                foreach (char c in tar_txt_filtr.Text)
                {
                    if (char.IsControl(c) || char.IsNumber(c) || c == '.')
                    {
                        temp += c;
                    }
                }
                tar_txt_filtr.Text = temp;
            }
            tar_filtruj();
        }

        private void tar_cmb_kolumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            tar_txt_filtr.Text = "";
            if (tar_cmb_kolumna.Text == "Cena za dzień") tar_cmb_porownanie.Enabled = true;
            else tar_cmb_porownanie.Enabled = false;
        }

        private void tar_cmb_porownanie_SelectedIndexChanged(object sender, EventArgs e)
        {
            tar_filtruj();
        }

        private void tar_txt_filtr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tar_cmb_kolumna.Text == "ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            if (tar_cmb_kolumna.Text == "Cena za dzień")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
        }

        private void tag_txt_filtr_TextChanged(object sender, EventArgs e)
        {
            tag_table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "nazwa", tag_txt_filtr.Text);
        }

        private void oso_txt_filtr_TextChanged(object sender, EventArgs e)
        {
            oso_table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "imie_nazwisko", oso_txt_filtr.Text);
        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {
            tag_odswiez();
            oso_odswiez();
        }

        private void tag_btn_pokaz_Click(object sender, EventArgs e)
        {
            przejdzDoTaga();
        }

        private void tag_dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            przejdzDoTaga();
        }

        private void oso_btn_pokaz_Click(object sender, EventArgs e)
        {
            przejdzDoFilmowca();
        }

        private void oso_dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            przejdzDoFilmowca();
        }

        private void btn_pokaz_wyp_Click(object sender, EventArgs e)
        {
            if (wyp_dtg_historia.SelectedRows.Count > 0)
            {
                wyp_index = wyp_dtg_historia.SelectedRows[0].Index;
                FrmZwrotFilmu frmZwrotFilmu = new FrmZwrotFilmu(Int32.Parse(wyp_dtg_historia.SelectedRows[0].Cells[0].Value.ToString()), this.Name);
                frmZwrotFilmu.ShowDialog(this);
                if (czy_zwrocono == true)
                {
                    wyp_odswiez();
                    if (wyp_dtg_historia.RowCount > 0)
                        wyp_dtg_historia.CurrentCell = wyp_dtg_historia.Rows[wyp_index].Cells[0];
                    czy_zwrocono = false;
                }
            }
        }
    }
}
