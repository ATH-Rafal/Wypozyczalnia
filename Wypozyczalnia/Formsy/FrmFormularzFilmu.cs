using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Wypozyczalnia.Formsy
{
    public partial class FrmFormularzFilmu : Form
    {
        int id;
        string connString = "Data Source = baza.db; Version = 3";

        public FrmFormularzFilmu(int id_)
        {
            InitializeComponent();
            id = id_;
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
    }
}
