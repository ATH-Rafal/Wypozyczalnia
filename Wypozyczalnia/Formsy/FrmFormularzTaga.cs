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
    public partial class FrmFormularzTaga : Form
    {
        string connString = "Data Source = baza.db; Version = 3";
        string nazwa;
        public FrmFormularzTaga(string _nazwa)
        {
            nazwa = _nazwa;
            InitializeComponent();
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();

                txt_nazwa.Text = nazwa;
                SQLiteCommand command2 = new SQLiteCommand(conn);
                command2.CommandText = @"
                        SELECT Filmy.tytul_pol, Filmy.id 
                        FROM Filmy
                        INNER JOIN TagiFilmy ON Filmy.id = TagiFilmy.id_filmu
                        INNER JOIN Tagi ON TagiFilmy.tag = Tagi.nazwa
                        WHERE Tagi.nazwa = @nazwa
                        ";
                command2.Parameters.Add(new SQLiteParameter("@nazwa", nazwa));
                using (command2)
                {
                    using (SQLiteDataReader rdr = command2.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            lb_filmy.Items.Add(rdr.GetValue(0).ToString() + " [" + rdr.GetValue(1).ToString() + "]");
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
