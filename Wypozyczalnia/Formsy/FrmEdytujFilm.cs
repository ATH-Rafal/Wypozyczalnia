using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Wypozyczalnia.Formsy
{
    public partial class FrmEdytujFilm : Form
    {
        int id;
        ListBox.ObjectCollection obiekty;
        List<osoba> osoby = new List<osoba>();
        string connString = "Data Source = baza.db; Version = 3";

        public ListBox.ObjectCollection obiekty_prop
        {
            get
            {
                return obiekty;
            }
            set
            {
                obiekty = value;
            }
        }

        public List<osoba> osoby_prop
        {
            get
            {
                return osoby;
            }
            set
            {
                osoby = value;
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
                        cmb_taryfa.Text = rdr.GetValue(1).ToString() + " - " + rdr.GetValue(2).ToString() + "zł za dzień [" + rdr.GetValue(0).ToString() + "]";
                    }
                }


                SQLiteCommand command4 = new SQLiteCommand(conn);
                command4.CommandText = @"
                    SELECT Tagi.nazwa, Tagi.id 
                    FROM Tagi
                    INNER JOIN TagiFilmy ON Tagi.id = TagiFilmy.id_taga
                    INNER JOIN Filmy ON TagiFilmy.id_filmu = Filmy.id
                    WHERE Filmy.id = @id
                    ";
                command4.Parameters.Add(new SQLiteParameter("@id", id));
                using (command4)
                {
                    using (SQLiteDataReader rdr = command4.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            lb_tagi.Items.Add(rdr.GetValue(0).ToString() + " [" + rdr.GetValue(1).ToString() + "]");
                        }
                    }
                }

                SQLiteCommand command5 = new SQLiteCommand(conn);
                command5.CommandText = @"
                    SELECT id_osoby, id_roli
                    FROM Obsada
                    WHERE id_filmu = @id
                    ";
                command5.Parameters.Add(new SQLiteParameter("@id", id));
                using (command5)
                {
                    using (SQLiteDataReader rdr = command5.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            osoby.Add(new osoba(rdr.GetInt32(0), rdr.GetInt32(1)));
                        }
                    }
                }
                conn.Close();
            }

        }

        private void btn_zatwierz_Click(object sender, EventArgs e)
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
                    command1.Parameters.Add(new SQLiteParameter("@tytul_pol", txt_tytul_pol.Text));
                    command1.Parameters.Add(new SQLiteParameter("@tytul_org", txt_tytul_org.Text));
                    command1.Parameters.Add(new SQLiteParameter("@rok_produkcji", txt_rok_produkcji.Text));
                    command1.Parameters.Add(new SQLiteParameter("@gatunek", txt_gatunek.Text));
                    command1.Parameters.Add(new SQLiteParameter("@gatunek2", txt_gatunek2.Text));
                    command1.Parameters.Add(new SQLiteParameter("@dystrybutor", txt_dystrybutor.Text));
                    command1.Parameters.Add(new SQLiteParameter("@kraj", txt_kraj.Text));
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
                        string[] words3 = o.Split(' ');
                        SQLiteCommand command3 = new SQLiteCommand(conn);
                        command3.CommandText = @"
                                INSERT INTO TagiFilmy (id_filmu, id_taga)
                                VALUES (@id_filmu, @id_taga)
                                ";
                        command3.Parameters.Add(new SQLiteParameter("@id_filmu", id));
                        command3.Parameters.Add(new SQLiteParameter("@id_taga", words3[words3.Length - 1].Trim(new Char[] { '[', ']' })));
                        command3.ExecuteNonQuery();
                    }

                    SQLiteCommand command4 = new SQLiteCommand(conn);
                    command4.CommandText = "DELETE FROM Obsada WHERE id_filmu = @id";
                    command4.Parameters.Add(new SQLiteParameter("@id", id));
                    command4.ExecuteNonQuery();

                    foreach (osoba o in osoby)
                    {
                        SQLiteCommand command5 = new SQLiteCommand(conn);
                        command5.CommandText = @"
                                INSERT INTO Obsada (id_filmu, id_osoby, id_roli)
                                VALUES (@id_filmu, @id_osoby, @id_roli)
                                ";
                        command5.Parameters.Add(new SQLiteParameter("@id_filmu", id));
                        command5.Parameters.Add(new SQLiteParameter("@id_osoby", o._id_osoby));
                        command5.Parameters.Add(new SQLiteParameter("@id_roli", o._id_roli));
                        command5.ExecuteNonQuery();
                    }

                    conn.Close();
                    this.Close();
                }
            }
        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_zarzadzanie_tagami_Click(object sender, EventArgs e)
        {
            FrmZarzadzanieTagami frmZarzadzanieTagami = new FrmZarzadzanieTagami(lb_tagi.Items, this.Name);
            frmZarzadzanieTagami.ShowDialog(this);
            lb_tagi.Items.Clear();
            foreach (object o in obiekty)
            {
                lb_tagi.Items.Add(o);
            }
        }

        private void lb_tagi_DoubleClick(object sender, EventArgs e)
        {
            if (lb_tagi.SelectedItems.Count > 0)
            {
                string[] words = lb_tagi.SelectedItem.ToString().Split(' ');
                string id_taga = words[words.Length - 1].Trim(new Char[] { '[', ']' });
                FrmFormularzTaga frmFormularzTaga = new FrmFormularzTaga(Int32.Parse(id_taga));
                frmFormularzTaga.ShowDialog();
            }
        }

        private void txt_dlugosc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_obsada_Click(object sender, EventArgs e)
        {
            FrmZarzadzanieObsada frmZarzadzanieObsada = new FrmZarzadzanieObsada(osoby, this.Name);
            frmZarzadzanieObsada.ShowDialog(this);
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
    }
}
