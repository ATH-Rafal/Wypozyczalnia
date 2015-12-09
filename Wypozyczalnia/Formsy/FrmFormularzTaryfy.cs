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
    public partial class FrmFormularzTaryfy : Form
    {
        string connString = "Data Source = baza.db; Version = 3";
        int id;

        public FrmFormularzTaryfy(int id_)
        {
            id = id_;
            InitializeComponent();

            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();

                SQLiteCommand command1 = new SQLiteCommand(conn);
                command1.CommandText = "SELECT * FROM Taryfy WHERE id=@id";
                command1.Parameters.Add(new SQLiteParameter("@id", id));
                using (command1)
                {
                    using (SQLiteDataReader rdr = command1.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            txt_id.Text = rdr.GetValue(0).ToString();
                            txt_nazwa.Text = rdr.GetValue(1).ToString();
                            txt_cena_za_dzien.Text = rdr.GetValue(2).ToString().Replace(',', '.');
                        }
                    }
                }

                SQLiteCommand command2 = new SQLiteCommand(conn);
                command2.CommandText = "SELECT * FROM TaryfyZasady WHERE id=@id ";
                command2.Parameters.Add(new SQLiteParameter("@id", id));
                using (command2)
                {
                    using (SQLiteDataReader rdr = command2.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            lb_zasady.Items.Add(rdr.GetValue(1).ToString() + " dni - " + rdr.GetValue(2).ToString().Replace(',', '.') + "zł");
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
