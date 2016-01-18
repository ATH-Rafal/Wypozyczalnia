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
    public partial class FrmFormularzOsoby : Form
    {
        string connString = "Data Source = baza.db; Version = 3";
        string imie_nazwisko;
        public FrmFormularzOsoby(string _imie_nazwisko)
        {
            imie_nazwisko = _imie_nazwisko;
            InitializeComponent();
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();

                SQLiteCommand command1 = new SQLiteCommand(conn);
                command1.CommandText = "SELECT * FROM Osoby WHERE imie_nazwisko=@imie_nazwisko";
                command1.Parameters.Add(new SQLiteParameter("@imie_nazwisko", imie_nazwisko));
                using (command1)
                {
                    using (SQLiteDataReader rdr = command1.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            txt_nazwa.Text = rdr.GetValue(0).ToString();
                        }
                    }
                }

                SQLiteCommand command2 = new SQLiteCommand(conn);
                command2.CommandText = @"
                        SELECT Filmy.tytul_pol, Filmy.id, Obsada.id_roli
                        FROM Filmy
                        INNER JOIN Obsada ON Filmy.id = Obsada.id_filmu
                        INNER JOIN Osoby ON Obsada.osoba = Osoby.imie_nazwisko
                        WHERE Osoby.imie_nazwisko = @imie_nazwisko
                        ";
                command2.Parameters.Add(new SQLiteParameter("@imie_nazwisko", imie_nazwisko));
                using (command2)
                {                   
                    using (SQLiteDataReader rdr = command2.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            string rola = null;
                            switch (rdr.GetInt32(2))
                            {
                                case 1:
                                    rola = "Reżyser";
                                    break;
                                case 2:
                                    rola = "Scenariusz";
                                    break;
                                case 3:
                                    rola = "Muzyka";
                                    break;
                                case 4:
                                    rola = "Zdjęcia";
                                    break;
                                case 5:
                                    rola = "Aktor";
                                    break;
                            }
                            lb_filmy.Items.Add(rdr.GetValue(0).ToString() + " [" + rdr.GetValue(1).ToString() + "] - " + rola);                            
                        }
                    }
                }

                conn.Close();
            }
        }

        private void btn_zamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
