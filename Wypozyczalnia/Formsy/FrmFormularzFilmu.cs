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

        public FrmFormularzFilmu(int _id, string _parent_of_parent)
        {
            id = _id;
            parent_of_parent = _parent_of_parent;
            InitializeComponent();
            
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
                            txt_nosnik.Text = rdr.GetValue(8).ToString();
                            cb_lektor.Checked = rdr.GetValue(9) as bool? ?? false;
                            cb_napisy.Checked = rdr.GetValue(10) as bool? ?? false;
                            txt_uwagi.Text = rdr.GetValue(11).ToString();
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

                SQLiteCommand command3 = new SQLiteCommand(conn);
                command3.CommandText = @"
                    SELECT (COUNT(id_filmu) = COUNT(data_zwrotu))
                    FROM Wypozyczenia
                    WHERE id_filmu = @id
                    ";
                command3.Parameters.Add(new SQLiteParameter("@id", id));
                string command3_output = command3.ExecuteScalar().ToString();

                if (command3_output == "0")
                {
                    btn_wypozycz.Enabled = false;
                    lb_status.Text = ":Ten film jest aktualnie wypożyczony klientowi\n";
                    SQLiteCommand command4 = new SQLiteCommand(conn);
                    command4.CommandText = @"
                        SELECT Klienci.nazwisko, Klienci.imie, Wypozyczenia.id_klienta
                        FROM Wypozyczenia
                        INNER JOIN Klienci ON Wypozyczenia.id_klienta = Klienci.id
                        WHERE Wypozyczenia.id_filmu=@id AND data_zwrotu IS NULL
                        ";
                    command4.Parameters.Add(new SQLiteParameter("@id", id));
                    using (command4)
                    {
                        using (SQLiteDataReader rdr = command4.ExecuteReader())
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
            }
        }
    }
}
