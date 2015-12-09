using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Wypozyczalnia.Formsy
{
    public partial class FrmFormularzFilmu : Form
    {
        int id;
        string parent_of_parent;
        string connString = "Data Source = baza.db; Version = 3";

        private void odswiezStatus()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();

                SQLiteCommand command1 = new SQLiteCommand(conn);
                command1.CommandText = @"
                    SELECT (COUNT(id_filmu) = COUNT(data_zwrotu))
                    FROM Wypozyczenia
                    WHERE id_filmu = @id
                    ";
                command1.Parameters.Add(new SQLiteParameter("@id", id));
                string command1_output = command1.ExecuteScalar().ToString();

                if (command1_output == "0")
                {
                    btn_wypozycz.Enabled = false;
                    lb_status.Text = ":Ten film jest aktualnie wypożyczony klientowi\n";
                    SQLiteCommand command2 = new SQLiteCommand(conn);
                    command2.CommandText = @"
                        SELECT Klienci.nazwisko, Klienci.imie, Wypozyczenia.id_klienta
                        FROM Wypozyczenia
                        INNER JOIN Klienci ON Wypozyczenia.id_klienta = Klienci.id
                        WHERE Wypozyczenia.id_filmu=@id AND data_zwrotu IS NULL
                        ";
                    command2.Parameters.Add(new SQLiteParameter("@id", id));
                    using (command2)
                    {
                        using (SQLiteDataReader rdr = command2.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                lb_status.Text += "[" + rdr.GetValue(0).ToString() + " " + rdr.GetValue(1).ToString() + " [" + rdr.GetValue(2).ToString();
                            }
                        }
                    }
                }

                conn.Close();
            }
        }

        public FrmFormularzFilmu(int _id, string _parent_of_parent)
        {
            id = _id;
            parent_of_parent = _parent_of_parent;
            InitializeComponent();

            if (parent_of_parent == "FrmWypozyczenieFilmu") btn_wypozycz.Text = "WYBIERZ";

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
                            txt_nosnik.Text = rdr.GetValue(9).ToString();
                            id_taryfy = rdr.GetInt32(10);
                            cb_lektor.Checked = rdr.GetValue(11) as bool? ?? false;
                            cb_napisy.Checked = rdr.GetValue(12) as bool? ?? false;
                            txt_uwagi.Text = rdr.GetValue(13).ToString().Replace("<n>", System.Environment.NewLine);
                        }
                    }
                }

                SQLiteCommand command2 = new SQLiteCommand(conn);
                command2.CommandText = "SELECT * FROM Taryfy WHERE id = @id";
                command2.Parameters.Add(new SQLiteParameter("@id", id_taryfy));
                using (SQLiteDataReader rdr = command2.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        txt_taryfa.Text = rdr.GetValue(1).ToString() + " - " + rdr.GetValue(2).ToString() + "zł za dzień [" + rdr.GetValue(0).ToString() + "]";
                    }
                }

                SQLiteCommand command3 = new SQLiteCommand(conn);
                command3.CommandText = @"
                    SELECT Tagi.nazwa, Tagi.id 
                    FROM Tagi
                    INNER JOIN TagiFilmy ON Tagi.id = TagiFilmy.id_taga
                    INNER JOIN Filmy ON TagiFilmy.id_filmu = Filmy.id
                    WHERE Filmy.id = @id
                    ";
                command3.Parameters.Add(new SQLiteParameter("@id", id));
                using (SQLiteDataReader rdr = command3.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        lb_tagi.Items.Add(rdr.GetValue(0).ToString() + " [" + rdr.GetValue(1).ToString() + "]");
                    }
                }


                conn.Close();
            }

            odswiezStatus();
        }

        private void btn_Wyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btn_wypozycz_Click(object sender, EventArgs e)
        {
            if (parent_of_parent == "FrmWypozyczenieFilmu")
            {
                ((FrmListaFilmow)this.Owner).czy_wybrano_prop = true;
                this.Close();
            }
            else
            {
                FrmWypozyczenieFilmu frmWypozyczenieFilmu = new FrmWypozyczenieFilmu(id, this.Name);
                frmWypozyczenieFilmu.ShowDialog();
                odswiezStatus();
            }
        }
    }
}
