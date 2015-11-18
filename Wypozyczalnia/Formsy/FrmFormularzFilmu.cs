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
                SQLiteCommand command = new SQLiteCommand(conn);
                command.CommandText = "SELECT * FROM Filmy WHERE id=@id";
                command.Parameters.Add(new SQLiteParameter("@id", id));
                using (command)
                {
                    using (SQLiteDataReader rdr = command.ExecuteReader())
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
    }
}
