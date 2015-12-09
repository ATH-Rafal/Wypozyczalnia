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
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();               
                SQLiteCommand command = new SQLiteCommand(conn);
                command.CommandText = "SELECT * FROM Taryfy";
                using (SQLiteDataReader rdr = command.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        cmb_taryfa.Items.Add(rdr.GetValue(1).ToString() + " - " + rdr.GetValue(2).ToString() + "zł za dzień [" + rdr.GetValue(0).ToString() + "]");
                    }
                }
                cmb_taryfa.SelectedIndex = 0;
                cmb_nosnik.SelectedIndex = 0;
                conn.Close();
            }
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            if (txt_rok_produkcji.Text.Length != 4 || string.IsNullOrWhiteSpace(txt_tytul_pol.Text) || string.IsNullOrWhiteSpace(txt_gatunek.Text) || string.IsNullOrWhiteSpace(cmb_taryfa.Text))
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
                                INSERT INTO Filmy (tytul_pol, tytul_org, rok_produkcji, gatunek, gatunek2, dystrybutor, kraj, dlugosc, nosnik, id_taryfy, lektor, napisy, uwagi)
                                VALUES (@tytul_pol, @tytul_org, @rok_produkcji, @gatunek, @gatunek2, @dystrybutor, @kraj, @dlugosc, @nosnik, @id_taryfy, @lektor, @napisy, @uwagi)
                                ;
                                SELECT last_insert_rowid()";
                    
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

                    string id = command1.ExecuteScalar().ToString();

                    foreach (string o in lb_tagi.Items)
                    {
                        string[] words2 = o.Split(' ');
                        SQLiteCommand command2 = new SQLiteCommand(conn);
                        command2.CommandText = @"
                                INSERT INTO TagiFilmy (id_filmu, id_taga)
                                VALUES (@id_filmu, @id_taga)
                                ";
                        command2.Parameters.Add(new SQLiteParameter("@id_filmu", id));
                        command2.Parameters.Add(new SQLiteParameter("@id_taga", words2[words2.Length - 1].Trim(new Char[] { '[', ']' })));
                        command2.ExecuteNonQuery();
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
    }
}
