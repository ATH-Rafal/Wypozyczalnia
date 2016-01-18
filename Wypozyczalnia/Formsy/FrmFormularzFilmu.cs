using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Wypozyczalnia.Formsy
{
    public partial class FrmFormularzFilmu : Form
    {
        int id;
        bool zwrot = false;
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
                    btn_wypozycz.Text = "ZWRÓĆ";
                    zwrot = true;
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
                else
                {
                    btn_wypozycz.Text = "WYPOŻYCZ";
                    lb_status.Text = "Ten film nie jest aktualnie wypożyczony";
                    zwrot = false;
                }

                conn.Close();
            }
        }

        public FrmFormularzFilmu(int _id)
        {
            id = _id;
            InitializeComponent();


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
                        txt_taryfa.Text = rdr.GetValue(1).ToString() + " - " + rdr.GetValue(2).ToString().Replace(',', '.') + "zł za dzień [" + rdr.GetValue(0).ToString() + "]";
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
                conn.Close();
            }

            odswiezStatus();
        }

        private void lb_tagi_DoubleClick(object sender, EventArgs e)
        {
            if (lb_tagi.SelectedItems.Count > 0)
            {
                FrmFormularzTaga frmFormularzTaga = new FrmFormularzTaga(lb_tagi.SelectedItem.ToString());
                frmFormularzTaga.ShowDialog();
            }
        }

        private void btn_wypozycz_Click(object sender, EventArgs e)
        {

                if (zwrot == false)
                {
                    FrmWypozyczenieFilmu frmWypozyczenieFilmu = new FrmWypozyczenieFilmu(id, this.Name);
                    frmWypozyczenieFilmu.ShowDialog();
                    odswiezStatus();
                }
                else
                {
                    FrmZwrotFilmu frmZwrotFilmu = new FrmZwrotFilmu(id, this.Name);
                    frmZwrotFilmu.ShowDialog();
                    odswiezStatus();
                }
            
        }

        private void btn_zamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_rezyseria_DoubleClick(object sender, EventArgs e)
        {
            if (lb_rezyseria.SelectedItems.Count > 0)
            {
                FrmFormularzOsoby frmFormularzOsoby = new FrmFormularzOsoby(lb_rezyseria.SelectedItem.ToString());
                frmFormularzOsoby.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
