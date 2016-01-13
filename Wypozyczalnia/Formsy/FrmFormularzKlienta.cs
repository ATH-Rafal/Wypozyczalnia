using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace Wypozyczalnia.Formsy
{
    public partial class FrmFormularzKlienta : Form
    {
        DataTable table = new DataTable();
        int id;
        int index;
        string parent_of_parent;
        string connString = "Data Source = baza.db; Version = 3";

        private void odswiez()
        {
            table.Clear();
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {

                SQLiteCommand command = new SQLiteCommand(conn);
                command.CommandText = @"SELECT Wypozyczenia.id, Wypozyczenia.id_filmu, Filmy.tytul_pol, Wypozyczenia.data_wypozyczenia, Wypozyczenia.dni, Wypozyczenia.cena
                                        FROM Wypozyczenia
                                        INNER JOIN Filmy ON Wypozyczenia.id_filmu = Filmy.id
                                        WHERE id_klienta=@id AND data_zwrotu IS NULL";
                command.Parameters.Add(new SQLiteParameter("@id", id));
                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                adapter.SelectCommand = command;            
                adapter.Fill(table);
            }
            dth_dane_wypozyczenia.DataSource = table;
        }

        public FrmFormularzKlienta(int _id, string _parent_of_parent)
        {
            id = _id;
            parent_of_parent = _parent_of_parent;
            InitializeComponent();
            odswiez();
            if (parent_of_parent == "FrmWypozyczenieFilmu") { btn_wypozycz.Text = "WYBIERZ"; btn_zwroc.Enabled = false; }     
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(conn);
                command.CommandText = "SELECT * FROM Klienci WHERE id=@id";
                command.Parameters.Add(new SQLiteParameter("@id", id));
                using (command)
                {
                    using (SQLiteDataReader rdr = command.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            txt_id.Text = rdr.GetValue(0).ToString();
                            txt_imie.Text = rdr.GetValue(1).ToString();
                            txt_nazwisko.Text = rdr.GetValue(2).ToString();
                            txt_pesel.Text = rdr.GetValue(3).ToString();
                            txt_nr_dowodu.Text = rdr.GetValue(4).ToString();
                            txt_nr_telefonu.Text = rdr.GetValue(5).ToString();
                            txt_email.Text = rdr.GetValue(6).ToString();
                            txt_miejscowosc.Text = rdr.GetValue(7).ToString();
                            txt_kod_pocztowy.Text = rdr.GetValue(8).ToString();
                            txt_ulica.Text = rdr.GetValue(9).ToString();
                            txt_nr_domu.Text = rdr.GetValue(10).ToString();
                        }
                    }
                }
                conn.Close();
            }
        }

        private void btn_wyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_wypozycz_Click(object sender, EventArgs e)
        {


            if (parent_of_parent == "FrmWypozyczenieFilmu")
            {
                ((FrmListaKlientow)this.Owner).czy_wybrano_prop = true;
                this.Close();
            }
            else
            {
                int liczba_wierszy = dth_dane_wypozyczenia.RowCount;
                if (dth_dane_wypozyczenia.RowCount != 0) index = dth_dane_wypozyczenia.SelectedRows[0].Index;

                FrmWypozyczenieFilmu frmWypozyczenieFilmu = new FrmWypozyczenieFilmu(id, this.Name);
                frmWypozyczenieFilmu.ShowDialog();
                odswiez();

                if (dth_dane_wypozyczenia.RowCount != 0)
                {
                    if (dth_dane_wypozyczenia.RowCount != liczba_wierszy)
                        dth_dane_wypozyczenia.CurrentCell = dth_dane_wypozyczenia.Rows[dth_dane_wypozyczenia.RowCount - 1].Cells[0];
                    else dth_dane_wypozyczenia.CurrentCell = dth_dane_wypozyczenia.Rows[index].Cells[0];
                }
            }
        }

        private void btn_zwroc_Click(object sender, EventArgs e)
        {
            if (dth_dane_wypozyczenia.SelectedRows.Count > 0)
            {
                FrmZwrotFilmu frmZwrotFilmu = new FrmZwrotFilmu(Int32.Parse(dth_dane_wypozyczenia.SelectedRows[0].Cells[0].Value.ToString()), this.Name);
                frmZwrotFilmu.ShowDialog();
                odswiez();
            }
        }
    }
}


