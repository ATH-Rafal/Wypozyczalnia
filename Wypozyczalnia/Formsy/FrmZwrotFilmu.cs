using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wypozyczalnia.Formsy
{
    public partial class FrmZwrotFilmu : Form
    {
        string connString = "Data Source = baza.db; Version = 3";
        string parent_form;
        int id_filmu;
        int id;
        int dni_spoznienia = 0;
        float cena;
        DateTime data_wypozyczenia;
        DateTime termin_zwrotu;

        public FrmZwrotFilmu(int _id, string _parent_form)
        {            
            parent_form = _parent_form;
            if (parent_form == "FrmFormularzKlienta") id = _id;
            else
            {
                id_filmu = _id;
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    SQLiteCommand command = new SQLiteCommand(conn);
                    command.CommandText = @"SELECT id FROM Wypozyczenia
                                            WHERE id_filmu = @id_filmu
                                            AND data_zwrotu IS NULL";
                    command.Parameters.Add(new SQLiteParameter("@id_filmu", id_filmu));
                    id = Int32.Parse(command.ExecuteScalar().ToString());
                    conn.Close();
                }
            }

            InitializeComponent();

            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteCommand command1 = new SQLiteCommand(conn);
                command1.CommandText = @"SELECT Wypozyczenia.id, Klienci.nazwisko, Klienci.imie,
                                         Klienci.id, Filmy.tytul_pol, Filmy.id,
                                         Wypozyczenia.data_wypozyczenia, Wypozyczenia.dni,
                                         date(Wypozyczenia.data_wypozyczenia, (Wypozyczenia.dni || ' day')) AS termin_zwrotu,
                                         Wypozyczenia.cena FROM Klienci                                        
                                         INNER JOIN Wypozyczenia ON Klienci.id = Wypozyczenia.id_klienta 
                                         INNER JOIN Filmy ON Wypozyczenia.id_filmu = Filmy.id
                                         WHERE Wypozyczenia.id=@id";
                command1.Parameters.Add(new SQLiteParameter("@id", id));

                using (command1)
                {
                    using (SQLiteDataReader rdr = command1.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            txt_id.Text = rdr.GetValue(0).ToString();
                            txt_klient.Text = rdr.GetValue(1).ToString() + " " + rdr.GetValue(2).ToString() + " [" + rdr.GetValue(3).ToString() + "]";
                            txt_film.Text = rdr.GetValue(4).ToString() + " [" + rdr.GetValue(5).ToString() + "]";
                            data_wypozyczenia = rdr.GetDateTime(6);
                            txt_data.Text = data_wypozyczenia.ToString();
                            txt_dni.Text = rdr.GetValue(7).ToString();
                            termin_zwrotu = rdr.GetDateTime(8);
                            txt_termin_zwrotu.Text = termin_zwrotu.ToString();
                            cena = rdr.GetFloat(9);
                            label_cena.Text = "CENA: " + cena + "zł";
                        }
                    }
                }
                conn.Close();
            }
            if (DateTime.Now > termin_zwrotu)
                dni_spoznienia = (DateTime.Now - termin_zwrotu).Days;
            if (dni_spoznienia > 0)
            {
                using (SQLiteConnection conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    SQLiteCommand command2 = new SQLiteCommand(conn);
                    command2.CommandText = @"SELECT Taryfy.cena_za_dzien FROM Taryfy
                                             INNER JOIN Filmy ON Taryfy.id = Filmy.id_taryfy
                                             INNER JOIN Wypozyczenia ON Filmy.id = Wypozyczenia.id_filmu
                                             WHERE Wypozyczenia.id=@id";
                    command2.Parameters.Add(new SQLiteParameter("@id", id));
                    cena += float.Parse(command2.ExecuteScalar().ToString()) * dni_spoznienia;
                    conn.Close();
                    label_spoznienie.Text = "+" + dni_spoznienia + " dni spoznienia = " + cena + "zł";
                }                
            }
            
        }

        private void btn_zatwierdz_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(conn);
                command.CommandText = @"
                                UPDATE Wypozyczenia
                                SET
                                data_zwrotu = date('now'),
                                cena = @cena
                                WHERE id = @id
                                ";
                command.Parameters.Add(new SQLiteParameter("@id", id));
                command.Parameters.Add(new SQLiteParameter("@cena", cena));
                command.ExecuteNonQuery();
                conn.Close();
            }
            this.Close();
        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
