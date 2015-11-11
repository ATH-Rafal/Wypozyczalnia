using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Wypozyczalnia.Formsy
{
    public partial class FrmFormularzKlienta : Form
    {
        int id;
        string[] wartosciPrzedEdycja = new string[10];
        string connString = "Data Source = baza.db; Version = 3";

        public FrmFormularzKlienta(int id_)
        {
            InitializeComponent();
            id = id_;
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

    }
}


