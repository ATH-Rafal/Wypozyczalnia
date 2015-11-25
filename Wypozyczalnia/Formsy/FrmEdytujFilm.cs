using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Wypozyczalnia.Formsy
{
    public partial class FrmEdytujFilm : Form
    {
        int id;
        ListBox.ObjectCollection obiekty;
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

        public FrmEdytujFilm(int id_)
        {
            InitializeComponent();
            id = id_;
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();

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
                            txt_klas_wiekowa.Text = rdr.GetValue(4).ToString();
                            txt_dlugosc.Text = rdr.GetValue(5).ToString();
                            txt_kraj.Text = rdr.GetValue(6).ToString();
                            txt_cena.Text = rdr.GetValue(7).ToString();
                            cmb_nosnik.Text = rdr.GetValue(8).ToString();
                            cb_lektor.Checked = rdr.GetValue(9) as bool? ?? false;
                            cb_napisy.Checked = rdr.GetValue(10) as bool? ?? false;
                            txt_uwagi.Text = rdr.GetValue(11).ToString().Replace("<n>", System.Environment.NewLine);
                        }
                    }
                }

                SQLiteCommand command2 = new SQLiteCommand(conn);
                command2.CommandText = @"
                    SELECT Tagi.nazwa, Tagi.id 
                    FROM Tagi
                    INNER JOIN TagiFilmy ON Tagi.id = TagiFilmy.id_taga
                    INNER JOIN Filmy ON TagiFilmy.id_filmu = Filmy.id
                    WHERE Filmy.id = @id
                    ";
                command2.Parameters.Add(new SQLiteParameter("@id", id));
                using (command2)
                {
                    using (SQLiteDataReader rdr = command2.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            lb_tagi.Items.Add(rdr.GetValue(0).ToString() + " [" + rdr.GetValue(1).ToString() + "]");
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

                SQLiteCommand command1 = new SQLiteCommand(conn);
                command1.CommandText = @"
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
                                napisy = @napisy,
                                uwagi = @uwagi
                                WHERE id = @id
                                ";
                command1.Parameters.Add(new SQLiteParameter("@id", id));
                command1.Parameters.Add(new SQLiteParameter("@tytul_pol", txt_tytul_pol.Text));
                command1.Parameters.Add(new SQLiteParameter("@tytul_org", txt_tytul_org.Text));
                command1.Parameters.Add(new SQLiteParameter("@rok_produkcji", txt_rok_produkcji.Text));
                command1.Parameters.Add(new SQLiteParameter("@klas_wiekowa", txt_klas_wiekowa.Text));
                command1.Parameters.Add(new SQLiteParameter("@dlugosc", txt_dlugosc.Text));
                command1.Parameters.Add(new SQLiteParameter("@kraj", txt_kraj.Text));
                command1.Parameters.Add(new SQLiteParameter("@cena", txt_cena.Text));
                command1.Parameters.Add(new SQLiteParameter("@nosnik", cmb_nosnik.Text));
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
                    string[] words = o.Split(' ');
                    SQLiteCommand command3 = new SQLiteCommand(conn);
                    command3.CommandText = @"
                                INSERT INTO TagiFilmy (id_filmu, id_taga)
                                VALUES (@id_filmu, @id_taga)
                                ";
                    command3.Parameters.Add(new SQLiteParameter("@id_filmu", id));
                    command3.Parameters.Add(new SQLiteParameter("@id_taga", words[words.Length - 1].Trim(new Char[] { '[', ']' })));
                    command3.ExecuteNonQuery();
                }

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
    }
}
