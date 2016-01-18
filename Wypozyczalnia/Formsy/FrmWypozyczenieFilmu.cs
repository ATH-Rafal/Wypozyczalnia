using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wypozyczalnia.Formsy
{
    public partial class FrmWypozyczenieFilmu : Form
    {
        int? id_taryfy = null;
        string parent_form;
        string connString = "Data Source = baza.db; Version = 3";

        public string txt_id_klienta_text
        {
            get
            {
                return txt_id_klienta.Text;
            }
            set
            {
                txt_id_klienta.Text = value;
            }
        }

        public string txt_id_filmu_text
        {
            get
            {
                return txt_id_filmu.Text;
            }
            set
            {
                txt_id_filmu.Text = value;
            }
        }

        private void odswiezCene()
        {
            if (id_taryfy == null)
            {
                label_cena.Text = "CENA: ...";
            }
            else
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {                   
                    float cena_za_dzien;
                    float cena_promocji;
                    int? promocja_dni = null;

                    conn.Open();
                    
                    SQLiteCommand command1 = new SQLiteCommand(conn);
                    command1.CommandText = "SELECT cena_za_dzien FROM Taryfy WHERE id=@id";
                    command1.Parameters.Add(new SQLiteParameter("@id", id_taryfy));
                    cena_za_dzien = float.Parse(command1.ExecuteScalar().ToString());

                    for (int i = Int32.Parse(txt_dni.Text); i > 1; i--)
                    {
                        SQLiteCommand command2 = new SQLiteCommand(conn);
                        command2.CommandText = "SELECT Count(*) FROM TaryfyZasady WHERE id=@id AND dni=@dni";
                        command2.Parameters.Add(new SQLiteParameter("@id", id_taryfy));
                        command2.Parameters.Add(new SQLiteParameter("@dni", i));
                        if (command2.ExecuteScalar().ToString() != "0")
                        {
                            promocja_dni = i;
                            break;
                        }
                    }

                    if (promocja_dni != null)
                    {
                        SQLiteCommand command3 = new SQLiteCommand(conn);
                        command3.CommandText = "SELECT cena FROM TaryfyZasady WHERE id=@id AND dni=@dni";
                        command3.Parameters.Add(new SQLiteParameter("@id", id_taryfy));
                        command3.Parameters.Add(new SQLiteParameter("@dni", promocja_dni));
                        cena_promocji = float.Parse(command3.ExecuteScalar().ToString());

                        label_cena.Text = "CENA: " + (cena_promocji + (Int32.Parse(txt_dni.Text) - promocja_dni) * cena_za_dzien) + "zł";
                    }
                    else label_cena.Text = "CENA: " + Int32.Parse(txt_dni.Text) * cena_za_dzien + "zł";

                    conn.Close();
                }
            }
        }

        public FrmWypozyczenieFilmu(int _id, string _parent_form)
        {
            parent_form = _parent_form;
            InitializeComponent();
            if (parent_form == "FrmFormularzKlienta")
            {
                txt_id_klienta.Text = _id.ToString();
                txt_id_klienta.ReadOnly = true;
                txt_id_klienta.BackColor = System.Drawing.SystemColors.Control;
                btn_wybierz_klienta.Enabled = false;
            }
            if (parent_form == "FrmFormularzFilmu")
            {
                txt_id_filmu.Text = _id.ToString();
                txt_id_filmu.ReadOnly = true;
                txt_id_filmu.BackColor = System.Drawing.SystemColors.Control;
                btn_wybierz_film.Enabled = false;
            }

        }

        public FrmWypozyczenieFilmu()
        {
            InitializeComponent();
        }

        private void btn_zatwierdz_Click(object sender, EventArgs e)
        {
            bool czy_kontynuowac = true;
            if (string.IsNullOrWhiteSpace(txt_id_klienta.Text) || string.IsNullOrWhiteSpace(txt_id_filmu.Text) || string.IsNullOrWhiteSpace(txt_dni.Text))
            {
                MessageBox.Show("Uzupełnij wymagane pola", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();

                    SQLiteCommand command1 = new SQLiteCommand(conn);
                    command1.CommandText = "SELECT Count(*) FROM Klienci WHERE id=@id";
                    command1.Parameters.Add(new SQLiteParameter("@id", txt_id_klienta.Text));
                    string command1_output = command1.ExecuteScalar().ToString();
                    if (command1_output == "0")
                    {
                        MessageBox.Show("Nie znaleziono klienta o numerze " + txt_id_klienta.Text, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        czy_kontynuowac = false;
                        conn.Close();
                    }

                    if (czy_kontynuowac == true)
                    {
                        SQLiteCommand command2 = new SQLiteCommand(conn);
                        command2.CommandText = "SELECT Count(*) FROM Filmy WHERE id=@id";
                        command2.Parameters.Add(new SQLiteParameter("@id", txt_id_filmu.Text));
                        string command2_output = command2.ExecuteScalar().ToString();
                        if (command2_output == "0")
                        {
                            MessageBox.Show("Nie znaleziono filmu o numerze " + txt_id_filmu.Text, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            czy_kontynuowac = false;
                            conn.Close();
                        }
                    }

                    if (czy_kontynuowac == true)
                    {
                        SQLiteCommand command3 = new SQLiteCommand(conn);
                        command3.CommandText = @"
                            SELECT (COUNT(id_filmu) = COUNT(data_zwrotu))
                            FROM Wypozyczenia
                            WHERE id_filmu = @id
                            ";
                        command3.Parameters.Add(new SQLiteParameter("@id", txt_id_filmu.Text));
                        string command3_output = command3.ExecuteScalar().ToString();
                        if (command3_output == "0")
                        {
                            MessageBox.Show("Ten film jest aktualnie wypożyczony", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            czy_kontynuowac = false;
                            conn.Close();
                        }

                        if (czy_kontynuowac == true)
                        {
                            string[] words4 = label_cena.Text.Split(' ');
                            SQLiteCommand command4 = new SQLiteCommand(conn);
                            command4.CommandText = @"
                                        INSERT INTO Wypozyczenia (id_klienta, id_filmu, dni, cena, data_wypozyczenia)
                                        VALUES (@id_klienta, @id_filmu, @dni, @cena, date('now'))
                                        ";

                            command4.Parameters.Add(new SQLiteParameter("@id_klienta", txt_id_klienta.Text));
                            command4.Parameters.Add(new SQLiteParameter("@id_filmu", txt_id_filmu.Text));
                            command4.Parameters.Add(new SQLiteParameter("@dni", txt_dni.Text));
                            command4.Parameters.Add(new SQLiteParameter("@cena", words4[words4.Length - 1].Trim(new Char[] { 'z', 'ł' }).Replace(',', '.')));

                            command4.ExecuteNonQuery();

                            conn.Close();
                            this.Close();
                        }
                    }
                }

            }
        }

        private void btn_wybierz_klienta_Click(object sender, EventArgs e)
        {
            FrmListaKlientow frmListaKlientow = new FrmListaKlientow(this.Name);
            frmListaKlientow.ShowDialog(this);
        }

        private void btn_wybierz_film_Click(object sender, EventArgs e)
        {
            FrmListaFilmow frmListaFilmow = new FrmListaFilmow(this.Name);
            frmListaFilmow.ShowDialog(this);
        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_id_klienta_TextChanged(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(conn);
                command.CommandText = "SELECT Nazwisko, Imie, id, Count(*) FROM Klienci WHERE id=@id";
                command.Parameters.Add(new SQLiteParameter("@id", txt_id_klienta.Text));
                using (SQLiteDataReader rdr = command.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        if (rdr.GetInt32(3) == 0) txt_klient.Text = "";
                        else txt_klient.Text = rdr.GetValue(0).ToString() + " " + rdr.GetValue(1).ToString() + " [" + rdr.GetValue(2).ToString() + "]";
                    }
                }
                conn.Close();
            }

            string temp = null;
            foreach (char c in txt_id_klienta.Text)
            {
                if (char.IsControl(c) || char.IsNumber(c))
                {
                    temp += c;
                }
            }
            txt_id_klienta.Text = temp;
        }

        private void txt_id_filmu_TextChanged(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                
                SQLiteCommand command1 = new SQLiteCommand(conn);
                command1.CommandText = "SELECT tytul_pol, id, Count(*), id_taryfy FROM Filmy WHERE id=@id";
                command1.Parameters.Add(new SQLiteParameter("@id", txt_id_filmu.Text));
                using (SQLiteDataReader rdr = command1.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        if (rdr.GetInt32(2) == 0) { txt_film.Text = ""; id_taryfy = null; }
                        else
                        {
                            txt_film.Text = rdr.GetValue(0).ToString() + " [" + rdr.GetValue(1).ToString() + "]";
                            id_taryfy = rdr.GetInt32(3);
                        }
                    }
                }
                conn.Close();
                odswiezCene();
            }

            string temp = null;
            foreach (char c in txt_id_filmu.Text)
            {
                if (char.IsControl(c) || char.IsNumber(c))
                {
                    temp += c;
                }
            }
            txt_id_filmu.Text = temp;
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_dni_TextChanged(object sender, EventArgs e)
        {
            if (txt_dni.Value == 0) txt_dni.Value = 1;
            odswiezCene();
        }

        private void txt_id_klienta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_id_filmu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
