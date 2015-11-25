using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Wypozyczalnia.Formsy
{
    public partial class FrmDodajFilm : Form
    {
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
                SQLiteCommand command1 = new SQLiteCommand(conn);
                command1.CommandText = @"
                                INSERT INTO Filmy (tytul_pol, tytul_org, rok_produkcji, klas_wiekowa, dlugosc, kraj, cena, nosnik, lektor, napisy, uwagi)
                                VALUES (@tytul_pol, @tytul_org, @rok_produkcji, @klas_wiekowa, @dlugosc, @kraj, @cena, @nosnik, @lektor, @napisy, @uwagi)
                                ;
                                SELECT last_insert_rowid()";

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

                string id = command1.ExecuteScalar().ToString();

                foreach (string o in lb_tagi.Items)
                {
                    string[] words = o.Split(' ');
                    SQLiteCommand command2 = new SQLiteCommand(conn);
                    command2.CommandText = @"
                                INSERT INTO TagiFilmy (id_filmu, id_taga)
                                VALUES (@id_filmu, @id_taga)
                                ";
                    command2.Parameters.Add(new SQLiteParameter("@id_filmu", id));
                    command2.Parameters.Add(new SQLiteParameter("@id_taga", words[words.Length - 1].Trim(new Char[] { '[', ']' })));
                    command2.ExecuteNonQuery();
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
