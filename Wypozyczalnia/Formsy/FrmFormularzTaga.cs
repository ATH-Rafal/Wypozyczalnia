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
        int id;
        public FrmFormularzTaga(int _id)
        {
            id = _id;
            InitializeComponent();
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();

                SQLiteCommand command1 = new SQLiteCommand(conn);
                command1.CommandText = "SELECT * FROM Tagi WHERE id=@id";
                command1.Parameters.Add(new SQLiteParameter("@id", id));
                using (command1)
                {
                    using (SQLiteDataReader rdr = command1.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            txt_id.Text = rdr.GetValue(0).ToString();
                        }
                    }
                }

                SQLiteCommand command2 = new SQLiteCommand(conn);
                command2.CommandText = @"
                        SELECT Filmy.tytul_pol, Filmy.id 
                        FROM Filmy
                        INNER JOIN TagiFilmy ON Filmy.id = TagiFilmy.id_filmu
                        INNER JOIN Tagi ON TagiFilmy.id_taga = Tagi.id
                        WHERE Tagi.id = @id
                        ";
                command2.Parameters.Add(new SQLiteParameter("@id", id));
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
