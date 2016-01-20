using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Wypozyczalnia.Formsy
{
    public partial class FrmEdytujFilm : Form
    {
        int id;
        string connString = "Data Source = baza.db; Version = 3";

        private void zatwierdz()
        {
            if (txt_rok_produkcji.Text.Length != 4 || txt_rok_produkcji.Text.Contains(" ") || string.IsNullOrWhiteSpace(txt_tytul_pol.Text) || string.IsNullOrWhiteSpace(txt_gatunek.Text) || string.IsNullOrWhiteSpace(cmb_taryfa.Text))
            {
                MessageBox.Show("Uzupełnij wymagane pola", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    string[] words1 = cmb_taryfa.Text.Split(' ');
                    SQLiteCommand command1 = new SQLiteCommand(conn);
                    command1.CommandText = @"
                                UPDATE Filmy
                                SET
                                tytul_pol = @tytul_pol,
                                tytul_org = @tytul_org,
                                rok_produkcji = @rok_produkcji, 
                                gatunek = @gatunek,
                                gatunek2 = @gatunek2, 
                                dystrybutor = @dystrybutor, 
                                kraj = @kraj, 
                                dlugosc = @dlugosc, 
                                nosnik = @nosnik,
                                id_taryfy = @id_taryfy,
                                lektor = @lektor,                                 
                                napisy = @napisy,
                                uwagi = @uwagi
                                WHERE id = @id
                                ";
                    command1.Parameters.Add(new SQLiteParameter("@id", id));
                    command1.Parameters.Add(new SQLiteParameter("@tytul_pol", txt_tytul_pol.Text.Trim()));
                    command1.Parameters.Add(new SQLiteParameter("@tytul_org", txt_tytul_org.Text.Trim()));
                    command1.Parameters.Add(new SQLiteParameter("@rok_produkcji", txt_rok_produkcji.Text));
                    command1.Parameters.Add(new SQLiteParameter("@gatunek", txt_gatunek.Text.Trim()));
                    command1.Parameters.Add(new SQLiteParameter("@gatunek2", txt_gatunek2.Text.Trim()));
                    command1.Parameters.Add(new SQLiteParameter("@dystrybutor", txt_dystrybutor.Text.Trim()));
                    command1.Parameters.Add(new SQLiteParameter("@kraj", txt_kraj.Text.Trim()));
                    command1.Parameters.Add(new SQLiteParameter("@dlugosc", txt_dlugosc.Text));
                    command1.Parameters.Add(new SQLiteParameter("@nosnik", cmb_nosnik.Text));
                    command1.Parameters.Add(new SQLiteParameter("@id_taryfy", words1[words1.Length - 1].Trim(new Char[] { '[', ']' })));
                    if (cb_lektor.Checked) command1.Parameters.Add(new SQLiteParameter("@lektor", 1));
                    else command1.Parameters.Add(new SQLiteParameter("@lektor", 0));
                    if (cb_napisy.Checked) command1.Parameters.Add(new SQLiteParameter("@napisy", 1));
                    else command1.Parameters.Add(new SQLiteParameter("@napisy", 0));
                    command1.Parameters.Add(new SQLiteParameter("@uwagi", txt_uwagi.Text.Replace(System.Environment.NewLine, "<n>")));
                    command1.ExecuteNonQuery();

                    SQLiteCommand command2 = new SQLiteCommand(conn);
                    command2.CommandText = "DELETE FROM TagiFilmy WHERE id_filmu = @id";
                    command2.Parameters.Add(new SQLiteParameter("@id", id));
                    command2.ExecuteNonQuery();

                    foreach (string o in lb_tagi.Items)
                    {
                        SQLiteCommand command3 = new SQLiteCommand(conn);
                        command3.CommandText = @"
                                SELECT Count(nazwa) FROM Tagi
                                WHERE nazwa = @nazwa
                                ";
                        command3.Parameters.Add(new SQLiteParameter("@nazwa", o));
                        if (command3.ExecuteScalar().ToString() == "0")
                        {
                            SQLiteCommand command4 = new SQLiteCommand(conn);
                            command4.CommandText = @"
                                INSERT INTO Tagi (nazwa)
                                VALUES (@nazwa)
                                ";
                            command4.Parameters.Add(new SQLiteParameter("@nazwa", o));
                            command4.ExecuteNonQuery();
                        }
                        SQLiteCommand command5 = new SQLiteCommand(conn);
                        command5.CommandText = @"
                                INSERT INTO TagiFilmy (id_filmu, tag)
                                VALUES (@id_filmu, @tag)
                                ";
                        command5.Parameters.Add(new SQLiteParameter("@id_filmu", id));
                        command5.Parameters.Add(new SQLiteParameter("@tag", o));
                        command5.ExecuteNonQuery();
                    }

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

                    SQLiteCommand command9 = new SQLiteCommand(conn);
                    command9.CommandText = "DELETE FROM Obsada WHERE id_filmu = @id";
                    command9.Parameters.Add(new SQLiteParameter("@id", id));
                    command9.ExecuteNonQuery();

                    foreach (string o in lb_rezyseria.Items)
                    {
                        SQLiteCommand command10 = new SQLiteCommand(conn);
                        command10.CommandText = @"
                                SELECT Count(imie_nazwisko) FROM Osoby
                                WHERE imie_nazwisko = @imie_nazwisko
                                ";
                        command10.Parameters.Add(new SQLiteParameter("@imie_nazwisko", o));
                        if (command10.ExecuteScalar().ToString() == "0")
                        {
                            SQLiteCommand command11 = new SQLiteCommand(conn);
                            command11.CommandText = @"
                                INSERT INTO Osoby (imie_nazwisko)
                                VALUES (@imie_nazwisko)
                                ";
                            command11.Parameters.Add(new SQLiteParameter("@imie_nazwisko", o));
                            command11.ExecuteNonQuery();
                        }
                        SQLiteCommand command12 = new SQLiteCommand(conn);
                        command12.CommandText = @"
                                INSERT INTO Obsada (id_filmu, osoba, id_roli)
                                VALUES (@id_filmu, @osoba, @id_roli)
                                ";
                        command12.Parameters.Add(new SQLiteParameter("@id_filmu", id));
                        command12.Parameters.Add(new SQLiteParameter("@osoba", o));
                        command12.Parameters.Add(new SQLiteParameter("@id_roli", 1));
                        command12.ExecuteNonQuery();
                    }

                    foreach (string o in lb_scenariusz.Items)
                    {
                        SQLiteCommand command13 = new SQLiteCommand(conn);
                        command13.CommandText = @"
                                SELECT Count(imie_nazwisko) FROM Osoby
                                WHERE imie_nazwisko = @imie_nazwisko
                                ";
                        command13.Parameters.Add(new SQLiteParameter("@imie_nazwisko", o));
                        if (command13.ExecuteScalar().ToString() == "0")
                        {
                            SQLiteCommand command14 = new SQLiteCommand(conn);
                            command14.CommandText = @"
                                INSERT INTO Osoby (imie_nazwisko)
                                VALUES (@imie_nazwisko)
                                ";
                            command14.Parameters.Add(new SQLiteParameter("@imie_nazwisko", o));
                            command14.ExecuteNonQuery();
                        }
                        SQLiteCommand command15 = new SQLiteCommand(conn);
                        command15.CommandText = @"
                                INSERT INTO Obsada (id_filmu, osoba, id_roli)
                                VALUES (@id_filmu, @osoba, @id_roli)
                                ";
                        command15.Parameters.Add(new SQLiteParameter("@id_filmu", id));
                        command15.Parameters.Add(new SQLiteParameter("@osoba", o));
                        command15.Parameters.Add(new SQLiteParameter("@id_roli", 2));
                        command15.ExecuteNonQuery();
                    }

                    foreach (string o in lb_muzyka.Items)
                    {
                        SQLiteCommand command16 = new SQLiteCommand(conn);
                        command16.CommandText = @"
                                SELECT Count(imie_nazwisko) FROM Osoby
                                WHERE imie_nazwisko = @imie_nazwisko
                                ";
                        command16.Parameters.Add(new SQLiteParameter("@imie_nazwisko", o));
                        if (command16.ExecuteScalar().ToString() == "0")
                        {
                            SQLiteCommand command17 = new SQLiteCommand(conn);
                            command17.CommandText = @"
                                INSERT INTO Osoby (imie_nazwisko)
                                VALUES (@imie_nazwisko)
                                ";
                            command17.Parameters.Add(new SQLiteParameter("@imie_nazwisko", o));
                            command17.ExecuteNonQuery();
                        }
                        SQLiteCommand command18 = new SQLiteCommand(conn);
                        command18.CommandText = @"
                                INSERT INTO Obsada (id_filmu, osoba, id_roli)
                                VALUES (@id_filmu, @osoba, @id_roli)
                                ";
                        command18.Parameters.Add(new SQLiteParameter("@id_filmu", id));
                        command18.Parameters.Add(new SQLiteParameter("@osoba", o));
                        command18.Parameters.Add(new SQLiteParameter("@id_roli", 3));
                        command18.ExecuteNonQuery();
                    }

                    foreach (string o in lb_zdjecia.Items)
                    {
                        SQLiteCommand command19 = new SQLiteCommand(conn);
                        command19.CommandText = @"
                                SELECT Count(imie_nazwisko) FROM Osoby
                                WHERE imie_nazwisko = @imie_nazwisko
                                ";
                        command19.Parameters.Add(new SQLiteParameter("@imie_nazwisko", o));
                        if (command19.ExecuteScalar().ToString() == "0")
                        {
                            SQLiteCommand command20 = new SQLiteCommand(conn);
                            command20.CommandText = @"
                                INSERT INTO Osoby (imie_nazwisko)
                                VALUES (@imie_nazwisko)
                                ";
                            command20.Parameters.Add(new SQLiteParameter("@imie_nazwisko", o));
                            command20.ExecuteNonQuery();
                        }
                        SQLiteCommand command21 = new SQLiteCommand(conn);
                        command21.CommandText = @"
                                INSERT INTO Obsada (id_filmu, osoba, id_roli)
                                VALUES (@id_filmu, @osoba, @id_roli)
                                ";
                        command21.Parameters.Add(new SQLiteParameter("@id_filmu", id));
                        command21.Parameters.Add(new SQLiteParameter("@osoba", o));
                        command21.Parameters.Add(new SQLiteParameter("@id_roli", 4));
                        command21.ExecuteNonQuery();
                    }

                    foreach (string o in lb_aktorzy.Items)
                    {
                        SQLiteCommand command22 = new SQLiteCommand(conn);
                        command22.CommandText = @"
                                SELECT Count(imie_nazwisko) FROM Osoby
                                WHERE imie_nazwisko = @imie_nazwisko
                                ";
                        command22.Parameters.Add(new SQLiteParameter("@imie_nazwisko", o));
                        if (command22.ExecuteScalar().ToString() == "0")
                        {
                            SQLiteCommand command23 = new SQLiteCommand(conn);
                            command23.CommandText = @"
                                INSERT INTO Osoby (imie_nazwisko)
                                VALUES (@imie_nazwisko)
                                ";
                            command23.Parameters.Add(new SQLiteParameter("@imie_nazwisko", o));
                            command23.ExecuteNonQuery();
                        }
                        SQLiteCommand command24 = new SQLiteCommand(conn);
                        command24.CommandText = @"
                                INSERT INTO Obsada (id_filmu, osoba, id_roli)
                                VALUES (@id_filmu, @osoba, @id_roli)
                                ";
                        command24.Parameters.Add(new SQLiteParameter("@id_filmu", id));
                        command24.Parameters.Add(new SQLiteParameter("@osoba", o));
                        command24.Parameters.Add(new SQLiteParameter("@id_roli", 5));
                        command24.ExecuteNonQuery();
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
                    this.Close();
                }
            }
        }

        public FrmEdytujFilm(int id_)
        {
            InitializeComponent();
            id = id_;
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                int id_taryfy = 0;
                SQLiteCommand command1 = new SQLiteCommand(conn);
                command1.CommandText = "SELECT * FROM Filmy WHERE id=@id";
                command1.Parameters.Add(new SQLiteParameter("@id", id));
                using (command1)
                {
                    using (SQLiteDataReader rdr = command1.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            txt_id.Text = rdr.GetValue(0).ToString();
                            txt_tytul_pol.Text = rdr.GetValue(1).ToString();
                            txt_tytul_org.Text = rdr.GetValue(2).ToString();
                            txt_rok_produkcji.Text = rdr.GetValue(3).ToString();
                            txt_gatunek.Text = rdr.GetValue(4).ToString();
                            txt_gatunek2.Text = rdr.GetValue(5).ToString();
                            txt_dystrybutor.Text = rdr.GetValue(6).ToString();
                            txt_kraj.Text = rdr.GetValue(7).ToString();
                            txt_dlugosc.Text = rdr.GetValue(8).ToString();
                            cmb_nosnik.Text = rdr.GetValue(9).ToString();
                            id_taryfy = rdr.GetInt32(10);
                            cb_lektor.Checked = rdr.GetValue(11) as bool? ?? false;
                            cb_napisy.Checked = rdr.GetValue(12) as bool? ?? false;
                            txt_uwagi.Text = rdr.GetValue(13).ToString().Replace("<n>", System.Environment.NewLine);
                        }
                    }
                }

                SQLiteCommand command2 = new SQLiteCommand(conn);
                command2.CommandText = "SELECT * FROM Taryfy";
                using (SQLiteDataReader rdr = command2.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        cmb_taryfa.Items.Add(rdr.GetValue(1).ToString() + " - " + rdr.GetValue(2).ToString().Replace(',', '.') + "zł za dzień [" + rdr.GetValue(0).ToString() + "]");
                    }
                }

                SQLiteCommand command3 = new SQLiteCommand(conn);
                command3.CommandText = "SELECT * FROM Taryfy WHERE id = @id";
                command3.Parameters.Add(new SQLiteParameter("@id", id_taryfy));
                using (SQLiteDataReader rdr = command3.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        cmb_taryfa.Text = rdr.GetValue(1).ToString() + " - " + rdr.GetValue(2).ToString().Replace(',','.') + "zł za dzień [" + rdr.GetValue(0).ToString() + "]";
                    }
                }


                SQLiteCommand command4 = new SQLiteCommand(conn);
                command4.CommandText = @"
                    SELECT tag
                    FROM TagiFilmy
                    WHERE id_filmu = @id_filmu
                    ";
                command4.Parameters.Add(new SQLiteParameter("@id_filmu", id));
                using (command4)
                {
                    using (SQLiteDataReader rdr = command4.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            lb_tagi.Items.Add(rdr.GetValue(0).ToString());
                        }
                    }
                }

                SQLiteCommand command5 = new SQLiteCommand(conn);
                command5.CommandText = @"
                        SELECT nazwa
                        FROM Tagi
                        ";
                using (command5)
                {
                    using (SQLiteDataReader rdr = command5.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            txt_dodaj_tag.AutoCompleteCustomSource.Add(rdr.GetValue(0).ToString());
                        }
                    }
                }

                SQLiteCommand command6 = new SQLiteCommand(conn);
                command6.CommandText = @"
                    SELECT osoba, id_roli
                    FROM Obsada
                    WHERE id_filmu = @id_filmu
                    ";
                command6.Parameters.Add(new SQLiteParameter("@id_filmu", id));
                using (command6)
                {
                    using (SQLiteDataReader rdr = command6.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            switch (rdr.GetInt32(1))
                            {
                                case 1: lb_rezyseria.Items.Add(rdr.GetValue(0).ToString()); break;
                                case 2: lb_scenariusz.Items.Add(rdr.GetValue(0).ToString()); break;
                                case 3: lb_muzyka.Items.Add(rdr.GetValue(0).ToString()); break;
                                case 4: lb_zdjecia.Items.Add(rdr.GetValue(0).ToString()); break;
                                case 5: lb_aktorzy.Items.Add(rdr.GetValue(0).ToString()); break;
                            }
                        }
                    }
                }

                SQLiteCommand command7 = new SQLiteCommand(conn);
                command7.CommandText = @"
                        SELECT imie_nazwisko
                        FROM Osoby
                        ";
                using (command7)
                {
                    using (SQLiteDataReader rdr = command7.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            txt_dodaj_rezysera.AutoCompleteCustomSource.Add(rdr.GetValue(0).ToString());
                            txt_dodaj_scenarzyste.AutoCompleteCustomSource.Add(rdr.GetValue(0).ToString());
                            txt_dodaj_kompozytora.AutoCompleteCustomSource.Add(rdr.GetValue(0).ToString());
                            txt_dodaj_zdjeciowca.AutoCompleteCustomSource.Add(rdr.GetValue(0).ToString());
                            txt_dodaj_aktora.AutoCompleteCustomSource.Add(rdr.GetValue(0).ToString());
                        }
                    }
                }

                conn.Close();
            }

        }

        private void btn_zatwierz_Click(object sender, EventArgs e)
        {
            zatwierdz();
        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_dlugosc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_dlugosc_TextChanged(object sender, EventArgs e)
        {
            string temp = null;
            foreach (char c in txt_dlugosc.Text)
            {
                if (char.IsControl(c) || char.IsNumber(c))
                {
                    temp += c;
                }
            }
            txt_dlugosc.Text = temp;
        }

        private void btn_dodaj_tag_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_dodaj_tag.Text))
            {
                if (!lb_tagi.Items.Contains(txt_dodaj_tag.Text.ToLower().Trim()))
                {
                    lb_tagi.Items.Add(txt_dodaj_tag.Text.ToLower().Trim());
                }
                txt_dodaj_tag.Text = "";
            }
        }

        private void btn_usun_tag_Click(object sender, EventArgs e)
        {
            if (lb_tagi.SelectedItems.Count > 0)
            {
                lb_tagi.Items.Remove(lb_tagi.SelectedItem);
            }
        }

        private void btn_dodaj_rezysera_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_dodaj_rezysera.Text))
            {
                string str = "";

                str += Char.ToUpper(txt_dodaj_rezysera.Text[0]);
                for (int i = 1; i < txt_dodaj_rezysera.Text.Length; i++)
                {
                    if (txt_dodaj_rezysera.Text[i - 1] == ' ' || txt_dodaj_rezysera.Text[i - 1] == '-') str += Char.ToUpper(txt_dodaj_rezysera.Text[i]);
                    else str += Char.ToLower(txt_dodaj_rezysera.Text[i]);
                }

                if (!lb_rezyseria.Items.Contains(str.Trim()))
                {
                    lb_rezyseria.Items.Add(str.Trim());
                }
                txt_dodaj_rezysera.Text = "";
            }
        }

        private void btn_usun_rezysera_Click(object sender, EventArgs e)
        {
            if (lb_rezyseria.SelectedItems.Count > 0)
                lb_rezyseria.Items.Remove(lb_rezyseria.SelectedItem);
        }

        private void btn_dodaj_scenarzyste_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_dodaj_scenarzyste.Text))
            {
                string str = "";

                str += Char.ToUpper(txt_dodaj_scenarzyste.Text[0]);
                for (int i = 1; i < txt_dodaj_scenarzyste.Text.Length; i++)
                {
                    if (txt_dodaj_scenarzyste.Text[i - 1] == ' ' || txt_dodaj_scenarzyste.Text[i - 1] == '-') str += Char.ToUpper(txt_dodaj_scenarzyste.Text[i]);
                    else str += Char.ToLower(txt_dodaj_scenarzyste.Text[i]);
                }

                if (!lb_scenariusz.Items.Contains(str.Trim()))
                {
                    lb_scenariusz.Items.Add(str.Trim());
                }
                txt_dodaj_scenarzyste.Text = "";
            }
        }

        private void btn_usun_scenarzyste_Click(object sender, EventArgs e)
        {
            if (lb_scenariusz.SelectedItems.Count > 0)
                lb_scenariusz.Items.Remove(lb_scenariusz.SelectedItem);
        }

        private void btn_dodaj_kompozytora_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_dodaj_kompozytora.Text))
            {
                string str = "";

                str += Char.ToUpper(txt_dodaj_kompozytora.Text[0]);
                for (int i = 1; i < txt_dodaj_kompozytora.Text.Length; i++)
                {
                    if (txt_dodaj_kompozytora.Text[i - 1] == ' ' || txt_dodaj_kompozytora.Text[i - 1] == '-') str += Char.ToUpper(txt_dodaj_kompozytora.Text[i]);
                    else str += Char.ToLower(txt_dodaj_kompozytora.Text[i]);
                }

                if (!lb_muzyka.Items.Contains(str.Trim()))
                {
                    lb_muzyka.Items.Add(str.Trim());
                }
                txt_dodaj_kompozytora.Text = "";
            }
        }

        private void btn_usun_kompozytora_Click(object sender, EventArgs e)
        {
            if (lb_muzyka.SelectedItems.Count > 0)
                lb_muzyka.Items.Remove(lb_muzyka.SelectedItem);
        }

        private void btn_dodaj_zdjeciowca_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_dodaj_zdjeciowca.Text))
            {
                string str = "";

                str += Char.ToUpper(txt_dodaj_zdjeciowca.Text[0]);
                for (int i = 1; i < txt_dodaj_zdjeciowca.Text.Length; i++)
                {
                    if (txt_dodaj_zdjeciowca.Text[i - 1] == ' ' || txt_dodaj_zdjeciowca.Text[i - 1] == '-') str += Char.ToUpper(txt_dodaj_zdjeciowca.Text[i]);
                    else str += Char.ToLower(txt_dodaj_zdjeciowca.Text[i]);
                }

                if (!lb_zdjecia.Items.Contains(str.Trim()))
                {
                    lb_zdjecia.Items.Add(str.Trim());
                }
                txt_dodaj_zdjeciowca.Text = "";
            }
        }

        private void btn_usun_zdjeciowca_Click(object sender, EventArgs e)
        {
            if (lb_zdjecia.SelectedItems.Count > 0)
                lb_zdjecia.Items.Remove(lb_zdjecia.SelectedItem);
        }

        private void btn_dodaj_aktora_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_dodaj_aktora.Text))
            {
                string str = "";

                str += Char.ToUpper(txt_dodaj_aktora.Text[0]);
                for (int i = 1; i < txt_dodaj_aktora.Text.Length; i++)
                {
                    if (txt_dodaj_aktora.Text[i - 1] == ' ' || txt_dodaj_aktora.Text[i - 1] == '-') str += Char.ToUpper(txt_dodaj_aktora.Text[i]);
                    else str += Char.ToLower(txt_dodaj_aktora.Text[i]);
                }

                if (!lb_aktorzy.Items.Contains(str.Trim()))
                {
                    lb_aktorzy.Items.Add(str.Trim());
                }
                txt_dodaj_aktora.Text = "";
            }
        }

        private void btn_usun_aktora_Click(object sender, EventArgs e)
        {
            if (lb_aktorzy.SelectedItems.Count > 0)
            {
                lb_aktorzy.Items.Remove(lb_aktorzy.SelectedItem);
            }
        }

        private void btn_gora_aktorzy_Click(object sender, EventArgs e)
        {
            if (lb_aktorzy.SelectedIndex != 0 && lb_aktorzy.SelectedItems.Count > 0)
            {
                int nowy_index = lb_aktorzy.SelectedIndex - 1;
                object wybrany_obiekt = lb_aktorzy.SelectedItem;
                lb_aktorzy.Items.Remove(wybrany_obiekt);
                lb_aktorzy.Items.Insert(nowy_index, wybrany_obiekt);
                lb_aktorzy.SetSelected(nowy_index, true);
            }
        }

        private void btn_dol_aktorzy_Click(object sender, EventArgs e)
        {
            if (lb_aktorzy.SelectedIndex != lb_aktorzy.Items.Count - 1 && lb_aktorzy.SelectedItems.Count > 0)
            {
                int nowy_index = lb_aktorzy.SelectedIndex + 1;
                object wybrany_obiekt = lb_aktorzy.SelectedItem;
                lb_aktorzy.Items.Remove(wybrany_obiekt);
                lb_aktorzy.Items.Insert(nowy_index, wybrany_obiekt);
                lb_aktorzy.SetSelected(nowy_index, true);
            }
        }

        private void btn_gora_tag_Click(object sender, EventArgs e)
        {
            if (lb_tagi.SelectedIndex != 0 && lb_tagi.SelectedItems.Count > 0)
            {
                int nowy_index = lb_tagi.SelectedIndex - 1;
                object wybrany_obiekt = lb_tagi.SelectedItem;
                lb_tagi.Items.Remove(wybrany_obiekt);
                lb_tagi.Items.Insert(nowy_index, wybrany_obiekt);
                lb_tagi.SetSelected(nowy_index, true);
            }
        }

        private void btn_dol_tag_Click(object sender, EventArgs e)
        {
            if (lb_tagi.SelectedIndex != lb_tagi.Items.Count - 1 && lb_tagi.SelectedItems.Count > 0)
            {
                int nowy_index = lb_tagi.SelectedIndex + 1;
                object wybrany_obiekt = lb_tagi.SelectedItem;
                lb_tagi.Items.Remove(wybrany_obiekt);
                lb_tagi.Items.Insert(nowy_index, wybrany_obiekt);
                lb_tagi.SetSelected(nowy_index, true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zatwierdz();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_tagi_DoubleClick(object sender, EventArgs e)
        {
            if (lb_tagi.SelectedItems.Count > 0)
            {
                FrmFormularzTaga frmFormularzTaga = new FrmFormularzTaga(lb_tagi.SelectedItem.ToString());
                frmFormularzTaga.ShowDialog();
            }
        }

        private void lb_rezyseria_DoubleClick(object sender, EventArgs e)
        {
            if (lb_rezyseria.SelectedItems.Count > 0)
            {
                FrmFormularzOsoby frmFormularzOsoby = new FrmFormularzOsoby(lb_rezyseria.SelectedItem.ToString());
                frmFormularzOsoby.ShowDialog();
            }
        }

        private void lb_scenariusz_DoubleClick(object sender, EventArgs e)
        {
            if (lb_scenariusz.SelectedItems.Count > 0)
            {
                FrmFormularzOsoby frmFormularzOsoby = new FrmFormularzOsoby(lb_scenariusz.SelectedItem.ToString());
                frmFormularzOsoby.ShowDialog();
            }
        }

        private void lb_muzyka_DoubleClick(object sender, EventArgs e)
        {
            if (lb_muzyka.SelectedItems.Count > 0)
            {
                FrmFormularzOsoby frmFormularzOsoby = new FrmFormularzOsoby(lb_muzyka.SelectedItem.ToString());
                frmFormularzOsoby.ShowDialog();
            }
        }

        private void lb_zdjecia_DoubleClick(object sender, EventArgs e)
        {
            if (lb_zdjecia.SelectedItems.Count > 0)
            {
                FrmFormularzOsoby frmFormularzOsoby = new FrmFormularzOsoby(lb_zdjecia.SelectedItem.ToString());
                frmFormularzOsoby.ShowDialog();
            }
        }

        private void lb_aktorzy_DoubleClick(object sender, EventArgs e)
        {
            if (lb_aktorzy.SelectedItems.Count > 0)
            {
                FrmFormularzOsoby frmFormularzOsoby = new FrmFormularzOsoby(lb_aktorzy.SelectedItem.ToString());
                frmFormularzOsoby.ShowDialog();
            }
        }

        private void lb_rezyseria_Leave(object sender, EventArgs e)
        {
            if (!btn_usun_rezysera.Focused)
                lb_rezyseria.SelectedIndex = -1;
        }

        private void lb_scenariusz_Leave(object sender, EventArgs e)
        {
            if (!btn_usun_scenarzyste.Focused)
                lb_scenariusz.SelectedIndex = -1;
        }

        private void lb_muzyka_Leave(object sender, EventArgs e)
        {
            if (!btn_usun_kompozytora.Focused)
                lb_muzyka.SelectedIndex = -1;
        }

        private void lb_zdjecia_Leave(object sender, EventArgs e)
        {
            if (!btn_usun_zdjeciowca.Focused)
                lb_zdjecia.SelectedIndex = -1;
        }

        private void lb_aktorzy_Leave(object sender, EventArgs e)
        {
            if (!btn_usun_aktora.Focused && !btn_gora_aktorzy.Focused && !btn_dol_aktorzy.Focused)
                lb_aktorzy.SelectedIndex = -1;
        }

        private void lb_tagi_Leave(object sender, EventArgs e)
        {
            if (!btn_usun_tag.Focused && !btn_gora_tag.Focused && !btn_dol_tag.Focused)
                lb_tagi.SelectedIndex = -1;
        }
    }
}
